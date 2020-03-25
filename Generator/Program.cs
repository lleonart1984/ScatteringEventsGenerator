using System;
using System.IO;
using static Generator.Gfx;

namespace Generator
{
    class Program
    {
        #region Objects

        class UnitarySphereGeomery : IGeometricVolume
        {
            public float ClosestHit(float3 x, float3 w)
            {
                float b = 2 * dot(x, w);
                float c = Gfx.dot(x, x) - 1;
                float Disc = b * b - 4 * c;

                if (Disc < 0)
                    return float.NaN;

                float t0 = -b - sqrt(Disc);
                float t1 = -b + sqrt(Disc);
                if (t0 > 0)
                    return t0 * 0.5f;
                return t1 * 0.5f;
            }

            public bool IsInside(float3 x)
            {
                return length(x) <= 1;
            }

            public readonly static IGeometricVolume Instance = new UnitarySphereGeomery();
        }

        class Anisotropic : IPhaseFunction
        {
            float g;
            float one_minus_g2;
            float one_plus_g2;
            float one_over_2g;

            public Anisotropic(float g)
            {
                this.g = g;
                this.one_minus_g2 = (1.0f - g * g);
                this.one_plus_g2 = (1.0f + g * g);
                this.one_over_2g = (0.5f / g);
            }

            public float Eval(float cosTheta)
            {
                return 0.25f / Pi * (one_minus_g2) / pow(one_plus_g2 - 2 * g * cosTheta, 1.5f);
            }

            void CreateOrthonormalBasis(float3 D, out float3 B, out float3 T)
            {
                float3 other = abs(D.z) < 0.999 ? float3(0, 0, 1) : float3(1, 0, 0);
                B = normalize(cross(other, D));
                T = normalize(cross(D, B));
            }

            float invertcdf(float xi)
            {
                float t = (one_minus_g2) / (1.0f - g + 2.0f * g * xi);
                return one_over_2g * (one_plus_g2 - t * t);
            }

            public float3 ImportanceSample(float3 w)
            {
                float phi = random() * 2 * Pi;
                float cosTheta = invertcdf(random());
                float sinTheta = sqrt(max(0, 1.0f - cosTheta * cosTheta));

                float3 t0, t1;
                CreateOrthonormalBasis(w, out t0, out t1);

                return sinTheta * sin(phi) * t0 + sinTheta * cos(phi) * t1 +
                    cosTheta * w;
            }
        }

        class Isotropic : IPhaseFunction
        {
            public float Eval(float cosTheta)
            {
                return PiOver4;
            }

            public float3 ImportanceSample(float3 w)
            {
                return randomSphere();
            }

            public static readonly IPhaseFunction Instance = new Isotropic();
        }

        class PhaseFunctions
        {
            public static IPhaseFunction Create(float g)
            {
                if (Math.Abs(g) < 0.001)
                    return Isotropic.Instance;
                return new Anisotropic(g);
            }
        }

        #endregion

        static void GenerateParameters(out float density, out float scatteringAlbedo, out float g, out float3 Lin)
        {
            float sd = random();
            
            g = Math.Max(-0.999f, Math.Min(0.999f, random() * 2 - 1));
            density = sd < 0.1 ? (float)Math.Max(0.01, sd * 10) : sd < 0.5 ? (float)(1 + 4 * (sd - 0.1) / (0.4)) : (float)Math.Exp((sd - 0.5) * 4) * 5;
            scatteringAlbedo = 1 - pow(random(), 4);
            Lin = randomSphere()* (1 + log(Math.Max(0.001f, 1 - random())));
        }

        static void Main(string[] args)
        {
            File.WriteAllText("locker.txt", "generator");

            StreamWriter writer = new StreamWriter("DataSet.ds");
            Console.WriteLine("Generating file...");
            int N = 1 << 20; // 1M tests
            while (N-- > 0)
            {
                if (N%1024 == 0)
                {
                    Console.CursorLeft = 0;
                    Console.Write("Progress: " + (((1 << 20) - N) * 100.0f / (1 << 20)).ToString("F2") + "%                         ");
                }

                float density, scatteringAlbedo, g;
                float3 Lin;
                GenerateParameters(out density, out scatteringAlbedo, out g, out Lin);
                float3 x, w, X;
                float Accum;
                int n;
                MediaMaterial media = new MediaMaterial(PhaseFunctions.Create(g), density, scatteringAlbedo);
                Experiment.Sample(UnitarySphereGeomery.Instance, media, float3(0,0,1), Lin, out x, out w, out n, out X, out Accum);

                // Rotate x to the yz-plane and other vectors with the same matrix
                float3 zAxis = float3(0, 0, 1);
                float3 xAxis = abs(x.z) > 0.999 ? float3(1, 0, 0) : normalize(cross(float3(0, 0, 1), x));
                float3 yAxis = cross(xAxis, zAxis);

                mat3x3 normR = transpose(new mat3x3(xAxis, yAxis, zAxis));
                float3 normx = mul(x, normR);
                float3 normw = mul(w, normR);
                float3 normX = mul(X, normR);
                float3 normLin = mul(Lin, normR);
                float3 B = float3(1, 0, 0);
                float3 T = cross(normx, B);
                float theta = acos(Math.Max(-1, Math.Min(1, x.z)));
                float beta = dot(normw, T);
                float alpha = dot(normw, B);
                // normalizing
                alpha = abs(alpha) / sqrt(Math.Max(0.001f, 1 - beta * beta));
                beta = beta * 0.5f + 0.5f;
                theta = theta / Pi;
                float Xz = normX.z * 0.5f + 0.5f;
                float Xy = normX.y / sqrt(Math.Max(0.001f, 1 - normX.z * normX.z)) * 0.5f + 0.5f;
                float Xx = normX.x / sqrt(Math.Max(0.001f, 1 - normX.y * normX.y - normX.z * normX.z)) * 0.5f + 0.5f;
                Accum = 2 / (1 + exp(-Accum)) - 1;

                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                    density, scatteringAlbedo, g, normLin.x, normLin.y, normLin.z, theta, beta, alpha, 1.0f / n, Xx, Xy, Xz, Accum);
            }
            writer.Close();

            File.Delete("locker.txt");
        }
    }
}
