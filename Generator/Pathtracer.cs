using System;
using System.Collections.Generic;
using System.Text;
using static Generator.Gfx;

namespace Generator
{
    public class Experiment
    {
        public static void Sample(IGeometricVolume volume, MediaMaterial media, float3 wIn, float3 Lpos, 
            out float3 x, out float3 w, out int n, out float3 X, out float A)
        {
            n = 0;
            float Importance = 1;
            x = float3(0, 0, 0);
            w = wIn;
            A = 0;
            X = x;
            while (true)
            {
                n++;
                Importance *= media.ScatteringAlbedo;
                float pX = media.Phase.Eval(dot(w, normalize(Lpos - x))) * Importance;
                A = A + pX;
                if (random() < pX / A)
                    X = x;
                w = media.Phase.ImportanceSample(w);
                float d = volume.ClosestHit(x, w);
                float t = -log(1 - random()) / media.Density;
                if (t > d)
                {
                    x = x + w * d;
                    return;
                }
                x = x + w * t;
            }
        }
    }
}
