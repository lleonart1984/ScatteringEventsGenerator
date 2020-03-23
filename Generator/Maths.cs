using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    #region Vectors

    #region float2

    public struct float1
    {
        public float x;
        public float1(float x)
        {
            this.x = x;
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public static float1 operator +(float1 v1, float1 v2)
        {
            return new float1(v1.x + (v2.x));
        }

        public static float1 operator +(float v1, float1 v2)
        {
            return new float1(v1 + (v2.x));
        }

        public static float1 operator -(float1 v1, float1 v2)
        {
            return new float1(v1.x - (v2.x));
        }

        public static float1 operator -(float1 v1)
        {
            return new float1(-v1.x);
        }

        public static float1 operator *(float1 v1, float1 v2)
        {
            return new float1(v1.x * (v2.x));
        }
        public static float1 operator /(float1 v1, float1 v2)
        {
            return new float1(v1.x / (v2.x));
        }

        public static float1 operator /(float v1, float1 v2)
        {
            return new float1(v1 / (v2.x));
        }

        public static float1 operator *(float1 v, float factor)
        {
            return new float1(v.x * factor);
        }
        public static float1 operator /(float1 v, float factor)
        {
            return new float1(v.x / factor);
        }

        public static float1 operator *(float factor, float1 v)
        {
            return v * factor;
        }
    }
    public struct float2
    {
        public float x;

        public float y;

        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float2(float x)
            : this(x, x)
        {
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public static float2 operator +(float2 v1, float2 v2)
        {
            return new float2(v1.x + (v2.x), v1.y + (v2.y));
        }
        public static float2 operator +(float v1, float2 v2)
        {
            return new float2(v1 + (v2.x), v1 + (v2.y));
        }


        public static float2 operator *(float2 v1, float2 v2)
        {
            return new float2(v1.x * (v2.x), v1.y * (v2.y));
        }
        public static float2 operator /(float2 v1, float2 v2)
        {
            return new float2(v1.x / (v2.x), v1.y / (v2.y));
        }
        public static float2 operator /(float v1, float2 v2)
        {
            return new float2(v1 / (v2.x), v1 / (v2.y));
        }

        public static float2 operator *(float2 v, float factor)
        {
            return new float2(v.x * factor, v.y * factor);
        }
        public static float2 operator /(float2 v, float factor)
        {
            return new float2(v.x / factor, v.y / factor);
        }

        public static float2 operator *(float factor, float2 v)
        {
            return v * factor;
        }

        public static float2 operator &(float2 v1, float2 v2)
        {
            return new float2((int)v1.x & (int)v2.x, (int)v1.y & (int)v2.y);
        }

        public static float2 operator |(float2 v1, float2 v2)
        {
            return new float2((int)v1.x | (int)v2.x, (int)v1.y | (int)v2.y);
        }

        public static float2 operator ^(float2 v1, float2 v2)
        {
            return new float2((int)v1.x ^ (int)v2.x, (int)v1.y ^ (int)v2.y);
        }

        public static float2 operator ~(float2 v)
        {
            return new float2(~(int)v.x, ~(int)v.y);
        }

        public static float2 operator %(float2 v1, float2 v2)
        {
            return new float2(v1.x % v2.x, v1.y % v2.y);
        }

        public static explicit operator float(float2 v)
        {
            return (v.x);
        }

        public static float2 operator -(float2 v1, float2 v2)
        {
            return new float2(v1.x - (v2.x), v1.y - (v2.y));
        }

        public static float2 operator -(float2 v2)
        {
            return new float2(-(v2.x), -(v2.y));
        }

        public override string ToString()
        {
            return this.x.ToString() + "; " + this.y.ToString();
        }
    }

    #endregion

    #region float3

    public struct float3
    {
        public float x;

        public float y;

        public float z;

        public float3(float x, float y, float z)
        {

            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float3(float x)
            : this(x, x, x)
        {
        }

        public float3(float2 xy, float z) : this(xy.x, xy.y, z)
        {
        }

        public float2 xy
        {
            get { return new float2(x, y); }
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public float Average
        {
            get { return (x + y + z) / 3; }
        }

        public static float3 operator +(float3 v1, float3 v2)
        {
            return new float3(v1.x + (v2.x), v1.y + (v2.y), v1.z + (v2.z));
        }

        public static float3 operator +(float v1, float3 v2)
        {
            return new float3(v1 + (v2.x), v1 + (v2.y), v1 + (v2.z));
        }


        public static float3 operator *(float3 v1, float3 v2)
        {
            return new float3(v1.x * (v2.x), v1.y * (v2.y), v1.z * (v2.z));
        }
        public static float3 operator /(float3 v1, float3 v2)
        {
            return new float3(v1.x / (v2.x), v1.y / (v2.y), v1.z / (v2.z));
        }
        public static float3 operator /(float v1, float3 v2)
        {
            return new float3(v1 / (v2.x), v1 / (v2.y), v1 / (v2.z));
        }

        public static float3 operator *(float3 v, float factor)
        {
            return new float3(v.x * factor, v.y * factor, v.z * factor);
        }
        public static float3 operator /(float3 v, float factor)
        {
            return new float3(v.x / factor, v.y / factor, v.z / factor);
        }

        public static float3 operator *(float factor, float3 v)
        {
            return v * factor;
        }

        public static float3 operator &(float3 v1, float3 v2)
        {
            return new float3((int)v1.x & (int)v2.x, (int)v1.y & (int)v2.y, (int)v1.z & (int)v2.z);
        }

        public static float3 operator |(float3 v1, float3 v2)
        {
            return new float3((int)v1.x | (int)v2.x, (int)v1.y | (int)v2.y, (int)v1.z | (int)v2.z);
        }

        public static float3 operator ^(float3 v1, float3 v2)
        {
            return new float3((int)v1.x ^ (int)v2.x, (int)v1.y ^ (int)v2.y, (int)v1.z ^ (int)v2.z);
        }

        public static float3 operator ~(float3 v)
        {
            return new float3(~(int)v.x, ~(int)v.y, ~(int)v.z);
        }

        public static float3 operator %(float3 v1, float3 v2)
        {
            return new float3(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z);
        }

        public static explicit operator float2(float3 v)
        {
            return new float2(v.x, v.y);
        }

        public static explicit operator float(float3 v)
        {
            return v.x;
        }

        public static float3 operator -(float3 v1, float3 v2)
        {
            return new float3(v1.x - (v2.x), v1.y - (v2.y), v1.z - (v2.z));
        }

        public static float3 operator -(float3 v)
        {
            return new float3(-v.x, -v.y, -v.z);
        }

        public override string ToString()
        {
            return this.x.ToString() + "; " + this.y.ToString() + "; " + this.z.ToString();
        }
    }

    #endregion

    #region float4

    public struct float4
    {
        public float x;

        public float y;

        public float z;

        public float w;

        public float2 xy
        {
            get { return new float2(x, y); }
            set
            {
                this.x = value.x;
                this.y = value.y;
            }
        }

        public float3 xyz
        {
            get { return new float3(x, y, z); }
            set
            {
                this.x = value.x;
                this.y = value.y;
                this.z = value.z;
            }
        }

        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float4(float3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }

        public float4(float x)
            : this(x, x, x, x)
        {
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public static float4 operator +(float4 v1, float4 v2)
        {
            return new float4(v1.x + (v2.x), v1.y + (v2.y), v1.z + (v2.z), v1.w + (v2.w));
        }

        public static float4 operator +(float v1, float4 v2)
        {
            return new float4(v1 + (v2.x), v1 + (v2.y), v1 + (v2.z), v1 + (v2.w));
        }

        public static float4 operator *(float4 v1, float4 v2)
        {
            return new float4(v1.x * (v2.x), v1.y * (v2.y), v1.z * (v2.z), v1.w * (v2.w));
        }

        public static float4 operator /(float4 v1, float4 v2)
        {
            return new float4(v1.x / (v2.x), v1.y / (v2.y), v1.z / (v2.z), v1.w / (v2.w));
        }
        public static float4 operator /(float v1, float4 v2)
        {
            return new float4(v1 / (v2.x), v1 / (v2.y), v1 / (v2.z), v1 / (v2.w));
        }

        public static float4 operator *(float4 v, float factor)
        {
            return new float4(v.x * factor, v.y * factor, v.z * factor, v.w * factor);
        }
        public static float4 operator /(float4 v, float factor)
        {
            return new float4(v.x / factor, v.y / factor, v.z / factor, v.w / factor);
        }

        public static float4 operator *(float factor, float4 v)
        {
            return v * factor;
        }

        public static float4 operator &(float4 v1, float4 v2)
        {
            return new float4((int)v1.x & (int)v2.x, (int)v1.y & (int)v2.y, (int)v1.z & (int)v2.z, (int)v1.w & (int)v2.w);
        }

        public static float4 operator |(float4 v1, float4 v2)
        {
            return new float4((int)v1.x | (int)v2.x, (int)v1.y | (int)v2.y, (int)v1.z | (int)v2.z, (int)v1.w | (int)v2.w);
        }

        public static float4 operator ^(float4 v1, float4 v2)
        {
            return new float4((int)v1.x ^ (int)v2.x, (int)v1.y ^ (int)v2.y, (int)v1.z ^ (int)v2.z, (int)v1.w ^ (int)v2.w);
        }

        public static float4 operator ~(float4 v)
        {
            return new float4(~(int)v.x, ~(int)v.y, ~(int)v.z, ~(int)v.w);
        }

        public static float4 operator %(float4 v1, float4 v2)
        {
            return new float4(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z, v1.w % v2.w);
        }

        public static explicit operator float3(float4 v)
        {
            return new float3(v.x, v.y, v.z);
        }

        public static explicit operator float2(float4 v)
        {
            return new float2(v.x, v.y);
        }

        public static explicit operator float(float4 v)
        {
            return (v.x);
        }

        public static float4 operator -(float4 v1, float4 v2)
        {
            return new float4(v1.x - (v2.x), v1.y - (v2.y), v1.z - (v2.z), v1.w - (v2.w));
        }

        public static float4 operator -(float4 v2)
        {
            return new float4(-(v2.x), -(v2.y), -(v2.z), -(v2.w));
        }

        public override string ToString()
        {
            return this.x.ToString() + "; " + this.y.ToString() + "; " + this.z.ToString() + "; " + this.w.ToString();
        }
    }

    #endregion

    #endregion

    #region Matrices


    #region mat1x1
    public struct mat1x1
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat1x1(float M00)
        {
            this.M00 = M00;
        }
        #endregion

        #region Operators
        public static mat1x1 operator +(mat1x1 m1, mat1x1 m2)
        {
            return new mat1x1(m1.M00 + (m2.M00));
        }

        public static mat1x1 operator *(mat1x1 m1, float a)
        {
            return new mat1x1(m1.M00 * (a));
        }

        public static mat1x1 operator *(float a, mat1x1 m) { return m * a; }

        public static mat1x1 operator /(mat1x1 m1, float a)
        {
            return new mat1x1(m1.M00 / (a));
        }

        public static mat1x1 operator -(mat1x1 m1, mat1x1 m2)
        {
            return new mat1x1(m1.M00 - (m2.M00));
        }

        public static mat1x1 operator /(mat1x1 m1, mat1x1 m2)
        {
            return new mat1x1(m1.M00 / (m2.M00));
        }

        public static mat1x1 operator *(mat1x1 m1, mat1x1 m2)
        {
            return new mat1x1(m1.M00 * (m2.M00));
        }

        public mat1x1 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions


        public static implicit operator float1(mat1x1 m)
        {
            return new float1(m.M00);
        }

        public static implicit operator mat1x1(float1 v)
        {
            return new mat1x1(v.x);
        }

        #endregion

        public mat1x1 Inverse
        {
            get { return new mat1x1(1 / this.M00); }
        }

        public float Determinant
        {
            get { return Gfx.determinant(this); }
        }

        public bool IsSingular { get { return Determinant == 0; } }
    }
    #endregion


    #region mat1x2
    public struct mat1x2
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat1x2(float value)
        {
            M00 = value;
            M01 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat1x2(float M00, float M01)
        {
            this.M00 = M00;
            this.M01 = M01;
        }
        #endregion

        #region Operators
        public static mat1x2 operator +(mat1x2 m1, mat1x2 m2)
        {
            return new mat1x2(m1.M00 + (m2.M00), m1.M01 + (m2.M01));
        }

        public static mat1x2 operator *(mat1x2 m1, float a)
        {
            return new mat1x2(m1.M00 * (a), m1.M01 * (a));
        }

        public static mat1x2 operator *(float a, mat1x2 m) { return m * a; }

        public static mat1x2 operator /(mat1x2 m1, float a)
        {
            return new mat1x2(m1.M00 / (a), m1.M01 / (a));
        }

        public static mat1x2 operator -(mat1x2 m1, mat1x2 m2)
        {
            return new mat1x2(m1.M00 - (m2.M00), m1.M01 - (m2.M01));
        }

        public static mat1x2 operator /(mat1x2 m1, mat1x2 m2)
        {
            return new mat1x2(m1.M00 / (m2.M00), m1.M01 / (m2.M01));
        }

        public static mat1x2 operator *(mat1x2 m1, mat1x2 m2)
        {
            return new mat1x2(m1.M00 * (m2.M00), m1.M01 * (m2.M01));
        }

        public mat2x1 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat1x2 m)
        {
            return new mat1x1(m.M00);
        }

        public static implicit operator float2(mat1x2 m)
        {
            return new float2(m.M00, m.M01);
        }

        public static implicit operator mat1x2(float2 v)
        {
            return new mat1x2(v.x, v.y);
        }

        #endregion

    }
    #endregion


    #region mat1x3
    public struct mat1x3
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat1x3(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat1x3(float M00, float M01, float M02)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
        }
        #endregion

        #region Operators
        public static mat1x3 operator +(mat1x3 m1, mat1x3 m2)
        {
            return new mat1x3(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02));
        }

        public static mat1x3 operator *(mat1x3 m1, float a)
        {
            return new mat1x3(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a));
        }

        public static mat1x3 operator *(float a, mat1x3 m) { return m * a; }

        public static mat1x3 operator /(mat1x3 m1, float a)
        {
            return new mat1x3(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a));
        }

        public static mat1x3 operator -(mat1x3 m1, mat1x3 m2)
        {
            return new mat1x3(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02));
        }

        public static mat1x3 operator /(mat1x3 m1, mat1x3 m2)
        {
            return new mat1x3(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02));
        }

        public static mat1x3 operator *(mat1x3 m1, mat1x3 m2)
        {
            return new mat1x3(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02));
        }

        public mat3x1 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat1x3 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat1x3 m)
        {
            return new mat1x2(m.M00, m.M01);
        }

        public static implicit operator float3(mat1x3 m)
        {
            return new float3(m.M00, m.M01, m.M02);
        }

        public static implicit operator mat1x3(float3 v)
        {
            return new mat1x3(v.x, v.y, v.z);
        }

        #endregion

    }
    #endregion


    #region mat1x4
    public struct mat1x4
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 3
        /// </sumary>
        public float M03;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat1x4(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M03 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat1x4(float M00, float M01, float M02, float M03)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M03 = M03;
        }
        #endregion

        #region Operators
        public static mat1x4 operator +(mat1x4 m1, mat1x4 m2)
        {
            return new mat1x4(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M03 + (m2.M03));
        }

        public static mat1x4 operator *(mat1x4 m1, float a)
        {
            return new mat1x4(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M03 * (a));
        }

        public static mat1x4 operator *(float a, mat1x4 m) { return m * a; }

        public static mat1x4 operator /(mat1x4 m1, float a)
        {
            return new mat1x4(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M03 / (a));
        }

        public static mat1x4 operator -(mat1x4 m1, mat1x4 m2)
        {
            return new mat1x4(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M03 - (m2.M03));
        }

        public static mat1x4 operator /(mat1x4 m1, mat1x4 m2)
        {
            return new mat1x4(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M03 / (m2.M03));
        }

        public static mat1x4 operator *(mat1x4 m1, mat1x4 m2)
        {
            return new mat1x4(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M03 * (m2.M03));
        }

        public mat4x1 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat1x4 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat1x4 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat1x4 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }

        public static implicit operator float4(mat1x4 m)
        {
            return new float4(m.M00, m.M01, m.M02, m.M03);
        }

        public static implicit operator mat1x4(float4 v)
        {
            return new mat1x4(v.x, v.y, v.z, v.w);
        }

        #endregion

    }
    #endregion


    #region mat2x1
    public struct mat2x1
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat2x1(float value)
        {
            M00 = value;
            M10 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat2x1(float M00, float M10)
        {
            this.M00 = M00;
            this.M10 = M10;
        }
        #endregion

        #region Operators
        public static mat2x1 operator +(mat2x1 m1, mat2x1 m2)
        {
            return new mat2x1(m1.M00 + (m2.M00), m1.M10 + (m2.M10));
        }

        public static mat2x1 operator *(mat2x1 m1, float a)
        {
            return new mat2x1(m1.M00 * (a), m1.M10 * (a));
        }

        public static mat2x1 operator *(float a, mat2x1 m) { return m * a; }

        public static mat2x1 operator /(mat2x1 m1, float a)
        {
            return new mat2x1(m1.M00 / (a), m1.M10 / (a));
        }

        public static mat2x1 operator -(mat2x1 m1, mat2x1 m2)
        {
            return new mat2x1(m1.M00 - (m2.M00), m1.M10 - (m2.M10));
        }

        public static mat2x1 operator /(mat2x1 m1, mat2x1 m2)
        {
            return new mat2x1(m1.M00 / (m2.M00), m1.M10 / (m2.M10));
        }

        public static mat2x1 operator *(mat2x1 m1, mat2x1 m2)
        {
            return new mat2x1(m1.M00 * (m2.M00), m1.M10 * (m2.M10));
        }

        public mat1x2 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat2x1 m)
        {
            return new mat1x1(m.M00);
        }

        public static explicit operator float2(mat2x1 m)
        {
            return new float2(m.M00, m.M10);
        }

        public static explicit operator mat2x1(float2 v)
        {
            return new mat2x1(v.x, v.y);
        }

        #endregion

    }
    #endregion


    #region mat2x2
    public struct mat2x2
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat2x2(float value)
        {
            M00 = value;
            M01 = value;
            M10 = value;
            M11 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat2x2(float M00, float M01, float M10, float M11)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M10 = M10;
            this.M11 = M11;
        }
        #endregion

        #region Operators
        public static mat2x2 operator +(mat2x2 m1, mat2x2 m2)
        {
            return new mat2x2(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M10 + (m2.M10), m1.M11 + (m2.M11));
        }

        public static mat2x2 operator *(mat2x2 m1, float a)
        {
            return new mat2x2(m1.M00 * (a), m1.M01 * (a), m1.M10 * (a), m1.M11 * (a));
        }

        public static mat2x2 operator *(float a, mat2x2 m) { return m * a; }

        public static mat2x2 operator /(mat2x2 m1, float a)
        {
            return new mat2x2(m1.M00 / (a), m1.M01 / (a), m1.M10 / (a), m1.M11 / (a));
        }

        public static mat2x2 operator -(mat2x2 m1, mat2x2 m2)
        {
            return new mat2x2(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M10 - (m2.M10), m1.M11 - (m2.M11));
        }

        public static mat2x2 operator /(mat2x2 m1, mat2x2 m2)
        {
            return new mat2x2(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M10 / (m2.M10), m1.M11 / (m2.M11));
        }

        public static mat2x2 operator *(mat2x2 m1, mat2x2 m2)
        {
            return new mat2x2(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M10 * (m2.M10), m1.M11 * (m2.M11));
        }

        public mat2x2 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat2x2 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat2x2 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat2x1(mat2x2 m)
        {
            return new mat2x1(m.M00, m.M10);
        }

        public static explicit operator float4(mat2x2 m)
        {
            return new float4(m.M00, m.M01, m.M10, m.M11);
        }

        public static explicit operator mat2x2(float4 v)
        {
            return new mat2x2(v.x, v.y, v.z, v.w);
        }

        #endregion

        public mat2x2 Inverse
        {
            get
            {
                /// 00 01
                /// 10 11
                float Min00 = M11;
                float Min01 = M10;

                float det = Min00 * M00 - Min01 * M01;

                if (det == 0)
                    throw new InvalidOperationException("Singular matrices have not inverse");

                float Min10 = M01;
                float Min11 = M00;

                return new mat2x2(
                    (+Min00 / det), (-Min10 / det),
                    (-Min01 / det), (+Min11 / det));
            }
        }

        public float Determinant
        {
            get { return Gfx.determinant(this); }
        }

        public bool IsSingular { get { return Determinant == 0; } }
    }
    #endregion


    #region mat2x3
    public struct mat2x3
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat2x3(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M10 = value;
            M11 = value;
            M12 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat2x3(float M00, float M01, float M02, float M10, float M11, float M12)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
        }
        #endregion

        #region Operators
        public static mat2x3 operator +(mat2x3 m1, mat2x3 m2)
        {
            return new mat2x3(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12));
        }

        public static mat2x3 operator *(mat2x3 m1, float a)
        {
            return new mat2x3(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a));
        }

        public static mat2x3 operator *(float a, mat2x3 m) { return m * a; }

        public static mat2x3 operator /(mat2x3 m1, float a)
        {
            return new mat2x3(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a));
        }

        public static mat2x3 operator -(mat2x3 m1, mat2x3 m2)
        {
            return new mat2x3(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12));
        }

        public static mat2x3 operator /(mat2x3 m1, mat2x3 m2)
        {
            return new mat2x3(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12));
        }

        public static mat2x3 operator *(mat2x3 m1, mat2x3 m2)
        {
            return new mat2x3(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12));
        }

        public mat3x2 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat2x3 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat2x3 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat2x3 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat2x1(mat2x3 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat2x3 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }


        #endregion

    }
    #endregion


    #region mat2x4
    public struct mat2x4
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 3
        /// </sumary>
        public float M03;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 3
        /// </sumary>
        public float M13;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat2x4(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M03 = value;
            M10 = value;
            M11 = value;
            M12 = value;
            M13 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat2x4(float M00, float M01, float M02, float M03, float M10, float M11, float M12, float M13)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M03 = M03;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
            this.M13 = M13;
        }
        #endregion

        #region Operators
        public static mat2x4 operator +(mat2x4 m1, mat2x4 m2)
        {
            return new mat2x4(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M03 + (m2.M03), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12), m1.M13 + (m2.M13));
        }

        public static mat2x4 operator *(mat2x4 m1, float a)
        {
            return new mat2x4(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M03 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a), m1.M13 * (a));
        }

        public static mat2x4 operator *(float a, mat2x4 m) { return m * a; }

        public static mat2x4 operator /(mat2x4 m1, float a)
        {
            return new mat2x4(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M03 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a), m1.M13 / (a));
        }

        public static mat2x4 operator -(mat2x4 m1, mat2x4 m2)
        {
            return new mat2x4(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M03 - (m2.M03), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12), m1.M13 - (m2.M13));
        }

        public static mat2x4 operator /(mat2x4 m1, mat2x4 m2)
        {
            return new mat2x4(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M03 / (m2.M03), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12), m1.M13 / (m2.M13));
        }

        public static mat2x4 operator *(mat2x4 m1, mat2x4 m2)
        {
            return new mat2x4(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M03 * (m2.M03), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12), m1.M13 * (m2.M13));
        }

        public mat4x2 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat2x4 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat2x4 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat2x4 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat1x4(mat2x4 m)
        {
            return new mat1x4(m.M00, m.M01, m.M02, m.M03);
        }
        public static explicit operator mat2x1(mat2x4 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat2x4 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat2x3(mat2x4 m)
        {
            return new mat2x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12);
        }


        #endregion

    }
    #endregion


    #region mat3x1
    public struct mat3x1
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat3x1(float value)
        {
            M00 = value;
            M10 = value;
            M20 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat3x1(float M00, float M10, float M20)
        {
            this.M00 = M00;
            this.M10 = M10;
            this.M20 = M20;
        }
        #endregion

        #region Operators
        public static mat3x1 operator +(mat3x1 m1, mat3x1 m2)
        {
            return new mat3x1(m1.M00 + (m2.M00), m1.M10 + (m2.M10), m1.M20 + (m2.M20));
        }

        public static mat3x1 operator *(mat3x1 m1, float a)
        {
            return new mat3x1(m1.M00 * (a), m1.M10 * (a), m1.M20 * (a));
        }

        public static mat3x1 operator *(float a, mat3x1 m) { return m * a; }

        public static mat3x1 operator /(mat3x1 m1, float a)
        {
            return new mat3x1(m1.M00 / (a), m1.M10 / (a), m1.M20 / (a));
        }

        public static mat3x1 operator -(mat3x1 m1, mat3x1 m2)
        {
            return new mat3x1(m1.M00 - (m2.M00), m1.M10 - (m2.M10), m1.M20 - (m2.M20));
        }

        public static mat3x1 operator /(mat3x1 m1, mat3x1 m2)
        {
            return new mat3x1(m1.M00 / (m2.M00), m1.M10 / (m2.M10), m1.M20 / (m2.M20));
        }

        public static mat3x1 operator *(mat3x1 m1, mat3x1 m2)
        {
            return new mat3x1(m1.M00 * (m2.M00), m1.M10 * (m2.M10), m1.M20 * (m2.M20));
        }

        public mat1x3 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat3x1 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat2x1(mat3x1 m)
        {
            return new mat2x1(m.M00, m.M10);
        }

        public static explicit operator float3(mat3x1 m)
        {
            return new float3(m.M00, m.M10, m.M20);
        }

        public static explicit operator mat3x1(float3 v)
        {
            return new mat3x1(v.x, v.y, v.z);
        }

        #endregion

    }
    #endregion


    #region mat3x2
    public struct mat3x2
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat3x2(float value)
        {
            M00 = value;
            M01 = value;
            M10 = value;
            M11 = value;
            M20 = value;
            M21 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat3x2(float M00, float M01, float M10, float M11, float M20, float M21)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M10 = M10;
            this.M11 = M11;
            this.M20 = M20;
            this.M21 = M21;
        }
        #endregion

        #region Operators
        public static mat3x2 operator +(mat3x2 m1, mat3x2 m2)
        {
            return new mat3x2(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M20 + (m2.M20), m1.M21 + (m2.M21));
        }

        public static mat3x2 operator *(mat3x2 m1, float a)
        {
            return new mat3x2(m1.M00 * (a), m1.M01 * (a), m1.M10 * (a), m1.M11 * (a), m1.M20 * (a), m1.M21 * (a));
        }

        public static mat3x2 operator *(float a, mat3x2 m) { return m * a; }

        public static mat3x2 operator /(mat3x2 m1, float a)
        {
            return new mat3x2(m1.M00 / (a), m1.M01 / (a), m1.M10 / (a), m1.M11 / (a), m1.M20 / (a), m1.M21 / (a));
        }

        public static mat3x2 operator -(mat3x2 m1, mat3x2 m2)
        {
            return new mat3x2(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M20 - (m2.M20), m1.M21 - (m2.M21));
        }

        public static mat3x2 operator /(mat3x2 m1, mat3x2 m2)
        {
            return new mat3x2(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M20 / (m2.M20), m1.M21 / (m2.M21));
        }

        public static mat3x2 operator *(mat3x2 m1, mat3x2 m2)
        {
            return new mat3x2(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M20 * (m2.M20), m1.M21 * (m2.M21));
        }

        public mat2x3 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat3x2 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat3x2 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat2x1(mat3x2 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat3x2 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat3x1(mat3x2 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }


        #endregion

    }
    #endregion


    #region mat3x3
    public struct mat3x3
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 2
        /// </sumary>
        public float M22;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat3x3(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M10 = value;
            M11 = value;
            M12 = value;
            M20 = value;
            M21 = value;
            M22 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat3x3(float M00, float M01, float M02, float M10, float M11, float M12, float M20, float M21, float M22)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
            this.M20 = M20;
            this.M21 = M21;
            this.M22 = M22;
        }

        public mat3x3(float3 r0, float3 r1, float3 r2) :this(r0.x,r0.y,r0.z, r1.x, r1.y, r1.z, r2.x, r2.y, r2.z)
        {
        }
        #endregion

        #region Operators
        public static mat3x3 operator +(mat3x3 m1, mat3x3 m2)
        {
            return new mat3x3(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12), m1.M20 + (m2.M20), m1.M21 + (m2.M21), m1.M22 + (m2.M22));
        }

        public static mat3x3 operator *(mat3x3 m1, float a)
        {
            return new mat3x3(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a), m1.M20 * (a), m1.M21 * (a), m1.M22 * (a));
        }

        public static mat3x3 operator *(float a, mat3x3 m) { return m * a; }

        public static mat3x3 operator /(mat3x3 m1, float a)
        {
            return new mat3x3(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a), m1.M20 / (a), m1.M21 / (a), m1.M22 / (a));
        }

        public static mat3x3 operator -(mat3x3 m1, mat3x3 m2)
        {
            return new mat3x3(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12), m1.M20 - (m2.M20), m1.M21 - (m2.M21), m1.M22 - (m2.M22));
        }

        public static mat3x3 operator /(mat3x3 m1, mat3x3 m2)
        {
            return new mat3x3(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12), m1.M20 / (m2.M20), m1.M21 / (m2.M21), m1.M22 / (m2.M22));
        }

        public static mat3x3 operator *(mat3x3 m1, mat3x3 m2)
        {
            return new mat3x3(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12), m1.M20 * (m2.M20), m1.M21 * (m2.M21), m1.M22 * (m2.M22));
        }

        public mat3x3 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat3x3 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat3x3 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat3x3 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat2x1(mat3x3 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat3x3 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat2x3(mat3x3 m)
        {
            return new mat2x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12);
        }
        public static explicit operator mat3x1(mat3x3 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }
        public static explicit operator mat3x2(mat3x3 m)
        {
            return new mat3x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21);
        }


        #endregion

        public mat3x3 Inverse
        {
            get
            {
                /// 00 01 02
                /// 10 11 12
                /// 20 21 22
                float Min00 = M11 * M22 - M12 * M21;
                float Min01 = M10 * M22 - M12 * M20;
                float Min02 = M10 * M21 - M11 * M20;

                float det = Min00 * M00 - Min01 * M01 + Min02 * M02;

                if (det == 0)
                    throw new InvalidOperationException("Singular matrices have not inverse");

                float Min10 = M01 * M22 - M02 * M21;
                float Min11 = M00 * M22 - M02 * M20;
                float Min12 = M00 * M21 - M01 * M20;

                float Min20 = M01 * M12 - M02 * M11;
                float Min21 = M00 * M12 - M02 * M10;
                float Min22 = M00 * M11 - M01 * M10;

                return new mat3x3(
                    (+Min00 / det), (-Min10 / det), (+Min20 / det),
                    (-Min01 / det), (+Min11 / det), (-Min21 / det),
                    (+Min02 / det), (-Min12 / det), (+Min22 / det));
            }
        }

        public float Determinant
        {
            get { return Gfx.determinant(this); }
        }

        public bool IsSingular { get { return Determinant == 0; } }
    }
    #endregion


    #region mat3x4
    public struct mat3x4
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 3
        /// </sumary>
        public float M03;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 3
        /// </sumary>
        public float M13;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 2
        /// </sumary>
        public float M22;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 3
        /// </sumary>
        public float M23;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat3x4(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M03 = value;
            M10 = value;
            M11 = value;
            M12 = value;
            M13 = value;
            M20 = value;
            M21 = value;
            M22 = value;
            M23 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat3x4(float M00, float M01, float M02, float M03, float M10, float M11, float M12, float M13, float M20, float M21, float M22, float M23)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M03 = M03;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
            this.M13 = M13;
            this.M20 = M20;
            this.M21 = M21;
            this.M22 = M22;
            this.M23 = M23;
        }
        #endregion

        #region Operators
        public static mat3x4 operator +(mat3x4 m1, mat3x4 m2)
        {
            return new mat3x4(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M03 + (m2.M03), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12), m1.M13 + (m2.M13), m1.M20 + (m2.M20), m1.M21 + (m2.M21), m1.M22 + (m2.M22), m1.M23 + (m2.M23));
        }

        public static mat3x4 operator *(mat3x4 m1, float a)
        {
            return new mat3x4(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M03 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a), m1.M13 * (a), m1.M20 * (a), m1.M21 * (a), m1.M22 * (a), m1.M23 * (a));
        }

        public static mat3x4 operator *(float a, mat3x4 m) { return m * a; }

        public static mat3x4 operator /(mat3x4 m1, float a)
        {
            return new mat3x4(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M03 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a), m1.M13 / (a), m1.M20 / (a), m1.M21 / (a), m1.M22 / (a), m1.M23 / (a));
        }

        public static mat3x4 operator -(mat3x4 m1, mat3x4 m2)
        {
            return new mat3x4(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M03 - (m2.M03), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12), m1.M13 - (m2.M13), m1.M20 - (m2.M20), m1.M21 - (m2.M21), m1.M22 - (m2.M22), m1.M23 - (m2.M23));
        }

        public static mat3x4 operator /(mat3x4 m1, mat3x4 m2)
        {
            return new mat3x4(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M03 / (m2.M03), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12), m1.M13 / (m2.M13), m1.M20 / (m2.M20), m1.M21 / (m2.M21), m1.M22 / (m2.M22), m1.M23 / (m2.M23));
        }

        public static mat3x4 operator *(mat3x4 m1, mat3x4 m2)
        {
            return new mat3x4(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M03 * (m2.M03), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12), m1.M13 * (m2.M13), m1.M20 * (m2.M20), m1.M21 * (m2.M21), m1.M22 * (m2.M22), m1.M23 * (m2.M23));
        }

        public mat4x3 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat3x4 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat3x4 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat3x4 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat1x4(mat3x4 m)
        {
            return new mat1x4(m.M00, m.M01, m.M02, m.M03);
        }
        public static explicit operator mat2x1(mat3x4 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat3x4 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat2x3(mat3x4 m)
        {
            return new mat2x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12);
        }
        public static explicit operator mat2x4(mat3x4 m)
        {
            return new mat2x4(m.M00, m.M01, m.M02, m.M03, m.M10, m.M11, m.M12, m.M13);
        }
        public static explicit operator mat3x1(mat3x4 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }
        public static explicit operator mat3x2(mat3x4 m)
        {
            return new mat3x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21);
        }
        public static explicit operator mat3x3(mat3x4 m)
        {
            return new mat3x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12, m.M20, m.M21, m.M22);
        }


        #endregion

    }
    #endregion


    #region mat4x1
    public struct mat4x1
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 0
        /// </sumary>
        public float M30;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat4x1(float value)
        {
            M00 = value;
            M10 = value;
            M20 = value;
            M30 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat4x1(float M00, float M10, float M20, float M30)
        {
            this.M00 = M00;
            this.M10 = M10;
            this.M20 = M20;
            this.M30 = M30;
        }
        #endregion

        #region Operators
        public static mat4x1 operator +(mat4x1 m1, mat4x1 m2)
        {
            return new mat4x1(m1.M00 + (m2.M00), m1.M10 + (m2.M10), m1.M20 + (m2.M20), m1.M30 + (m2.M30));
        }

        public static mat4x1 operator *(mat4x1 m1, float a)
        {
            return new mat4x1(m1.M00 * (a), m1.M10 * (a), m1.M20 * (a), m1.M30 * (a));
        }

        public static mat4x1 operator *(float a, mat4x1 m) { return m * a; }

        public static mat4x1 operator /(mat4x1 m1, float a)
        {
            return new mat4x1(m1.M00 / (a), m1.M10 / (a), m1.M20 / (a), m1.M30 / (a));
        }

        public static mat4x1 operator -(mat4x1 m1, mat4x1 m2)
        {
            return new mat4x1(m1.M00 - (m2.M00), m1.M10 - (m2.M10), m1.M20 - (m2.M20), m1.M30 - (m2.M30));
        }

        public static mat4x1 operator /(mat4x1 m1, mat4x1 m2)
        {
            return new mat4x1(m1.M00 / (m2.M00), m1.M10 / (m2.M10), m1.M20 / (m2.M20), m1.M30 / (m2.M30));
        }

        public static mat4x1 operator *(mat4x1 m1, mat4x1 m2)
        {
            return new mat4x1(m1.M00 * (m2.M00), m1.M10 * (m2.M10), m1.M20 * (m2.M20), m1.M30 * (m2.M30));
        }

        public mat1x4 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat4x1 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat2x1(mat4x1 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat3x1(mat4x1 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }

        public static explicit operator float4(mat4x1 m)
        {
            return new float4(m.M00, m.M10, m.M20, m.M30);
        }

        public static explicit operator mat4x1(float4 v)
        {
            return new mat4x1(v.x, v.y, v.z, v.w);
        }

        #endregion

    }
    #endregion


    #region mat4x2
    public struct mat4x2
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 0
        /// </sumary>
        public float M30;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 1
        /// </sumary>
        public float M31;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat4x2(float value)
        {
            M00 = value;
            M01 = value;
            M10 = value;
            M11 = value;
            M20 = value;
            M21 = value;
            M30 = value;
            M31 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat4x2(float M00, float M01, float M10, float M11, float M20, float M21, float M30, float M31)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M10 = M10;
            this.M11 = M11;
            this.M20 = M20;
            this.M21 = M21;
            this.M30 = M30;
            this.M31 = M31;
        }
        #endregion

        #region Operators
        public static mat4x2 operator +(mat4x2 m1, mat4x2 m2)
        {
            return new mat4x2(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M20 + (m2.M20), m1.M21 + (m2.M21), m1.M30 + (m2.M30), m1.M31 + (m2.M31));
        }

        public static mat4x2 operator *(mat4x2 m1, float a)
        {
            return new mat4x2(m1.M00 * (a), m1.M01 * (a), m1.M10 * (a), m1.M11 * (a), m1.M20 * (a), m1.M21 * (a), m1.M30 * (a), m1.M31 * (a));
        }

        public static mat4x2 operator *(float a, mat4x2 m) { return m * a; }

        public static mat4x2 operator /(mat4x2 m1, float a)
        {
            return new mat4x2(m1.M00 / (a), m1.M01 / (a), m1.M10 / (a), m1.M11 / (a), m1.M20 / (a), m1.M21 / (a), m1.M30 / (a), m1.M31 / (a));
        }

        public static mat4x2 operator -(mat4x2 m1, mat4x2 m2)
        {
            return new mat4x2(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M20 - (m2.M20), m1.M21 - (m2.M21), m1.M30 - (m2.M30), m1.M31 - (m2.M31));
        }

        public static mat4x2 operator /(mat4x2 m1, mat4x2 m2)
        {
            return new mat4x2(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M20 / (m2.M20), m1.M21 / (m2.M21), m1.M30 / (m2.M30), m1.M31 / (m2.M31));
        }

        public static mat4x2 operator *(mat4x2 m1, mat4x2 m2)
        {
            return new mat4x2(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M20 * (m2.M20), m1.M21 * (m2.M21), m1.M30 * (m2.M30), m1.M31 * (m2.M31));
        }

        public mat2x4 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat4x2 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat4x2 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat2x1(mat4x2 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat4x2 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat3x1(mat4x2 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }
        public static explicit operator mat3x2(mat4x2 m)
        {
            return new mat3x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21);
        }
        public static explicit operator mat4x1(mat4x2 m)
        {
            return new mat4x1(m.M00, m.M10, m.M20, m.M30);
        }


        #endregion

    }
    #endregion


    #region mat4x3
    public struct mat4x3
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 2
        /// </sumary>
        public float M22;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 0
        /// </sumary>
        public float M30;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 1
        /// </sumary>
        public float M31;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 2
        /// </sumary>
        public float M32;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat4x3(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M10 = value;
            M11 = value;
            M12 = value;
            M20 = value;
            M21 = value;
            M22 = value;
            M30 = value;
            M31 = value;
            M32 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat4x3(float M00, float M01, float M02, float M10, float M11, float M12, float M20, float M21, float M22, float M30, float M31, float M32)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
            this.M20 = M20;
            this.M21 = M21;
            this.M22 = M22;
            this.M30 = M30;
            this.M31 = M31;
            this.M32 = M32;
        }
        #endregion

        #region Operators
        public static mat4x3 operator +(mat4x3 m1, mat4x3 m2)
        {
            return new mat4x3(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12), m1.M20 + (m2.M20), m1.M21 + (m2.M21), m1.M22 + (m2.M22), m1.M30 + (m2.M30), m1.M31 + (m2.M31), m1.M32 + (m2.M32));
        }

        public static mat4x3 operator *(mat4x3 m1, float a)
        {
            return new mat4x3(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a), m1.M20 * (a), m1.M21 * (a), m1.M22 * (a), m1.M30 * (a), m1.M31 * (a), m1.M32 * (a));
        }

        public static mat4x3 operator *(float a, mat4x3 m) { return m * a; }

        public static mat4x3 operator /(mat4x3 m1, float a)
        {
            return new mat4x3(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a), m1.M20 / (a), m1.M21 / (a), m1.M22 / (a), m1.M30 / (a), m1.M31 / (a), m1.M32 / (a));
        }

        public static mat4x3 operator -(mat4x3 m1, mat4x3 m2)
        {
            return new mat4x3(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12), m1.M20 - (m2.M20), m1.M21 - (m2.M21), m1.M22 - (m2.M22), m1.M30 - (m2.M30), m1.M31 - (m2.M31), m1.M32 - (m2.M32));
        }

        public static mat4x3 operator /(mat4x3 m1, mat4x3 m2)
        {
            return new mat4x3(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12), m1.M20 / (m2.M20), m1.M21 / (m2.M21), m1.M22 / (m2.M22), m1.M30 / (m2.M30), m1.M31 / (m2.M31), m1.M32 / (m2.M32));
        }

        public static mat4x3 operator *(mat4x3 m1, mat4x3 m2)
        {
            return new mat4x3(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12), m1.M20 * (m2.M20), m1.M21 * (m2.M21), m1.M22 * (m2.M22), m1.M30 * (m2.M30), m1.M31 * (m2.M31), m1.M32 * (m2.M32));
        }

        public mat3x4 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat4x3 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat4x3 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat4x3 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat2x1(mat4x3 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat4x3 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat2x3(mat4x3 m)
        {
            return new mat2x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12);
        }
        public static explicit operator mat3x1(mat4x3 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }
        public static explicit operator mat3x2(mat4x3 m)
        {
            return new mat3x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21);
        }
        public static explicit operator mat3x3(mat4x3 m)
        {
            return new mat3x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12, m.M20, m.M21, m.M22);
        }
        public static explicit operator mat4x1(mat4x3 m)
        {
            return new mat4x1(m.M00, m.M10, m.M20, m.M30);
        }
        public static explicit operator mat4x2(mat4x3 m)
        {
            return new mat4x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21, m.M30, m.M31);
        }


        #endregion

    }
    #endregion


    #region mat4x4
    public struct mat4x4
    {
        #region Instances
        /// <sumary>
        /// Gets or sets the element at row 0 and column 0
        /// </sumary>
        public float M00;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 1
        /// </sumary>
        public float M01;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 2
        /// </sumary>
        public float M02;
        /// <sumary>
        /// Gets or sets the element at row 0 and column 3
        /// </sumary>
        public float M03;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 0
        /// </sumary>
        public float M10;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 1
        /// </sumary>
        public float M11;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 2
        /// </sumary>
        public float M12;
        /// <sumary>
        /// Gets or sets the element at row 1 and column 3
        /// </sumary>
        public float M13;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 0
        /// </sumary>
        public float M20;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 1
        /// </sumary>
        public float M21;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 2
        /// </sumary>
        public float M22;
        /// <sumary>
        /// Gets or sets the element at row 2 and column 3
        /// </sumary>
        public float M23;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 0
        /// </sumary>
        public float M30;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 1
        /// </sumary>
        public float M31;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 2
        /// </sumary>
        public float M32;
        /// <sumary>
        /// Gets or sets the element at row 3 and column 3
        /// </sumary>
        public float M33;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the mat with the same value for all its components.
        /// </summary>
        public mat4x4(float value)
        {
            M00 = value;
            M01 = value;
            M02 = value;
            M03 = value;
            M10 = value;
            M11 = value;
            M12 = value;
            M13 = value;
            M20 = value;
            M21 = value;
            M22 = value;
            M23 = value;
            M30 = value;
            M31 = value;
            M32 = value;
            M33 = value;
        }

        /// <summary>
        /// Initializes the mat with the specified values.
        /// </summary>
        public mat4x4(float M00, float M01, float M02, float M03, float M10, float M11, float M12, float M13, float M20, float M21, float M22, float M23, float M30, float M31, float M32, float M33)
        {
            this.M00 = M00;
            this.M01 = M01;
            this.M02 = M02;
            this.M03 = M03;
            this.M10 = M10;
            this.M11 = M11;
            this.M12 = M12;
            this.M13 = M13;
            this.M20 = M20;
            this.M21 = M21;
            this.M22 = M22;
            this.M23 = M23;
            this.M30 = M30;
            this.M31 = M31;
            this.M32 = M32;
            this.M33 = M33;
        }
        #endregion

        #region Operators
        public static mat4x4 operator +(mat4x4 m1, mat4x4 m2)
        {
            return new mat4x4(m1.M00 + (m2.M00), m1.M01 + (m2.M01), m1.M02 + (m2.M02), m1.M03 + (m2.M03), m1.M10 + (m2.M10), m1.M11 + (m2.M11), m1.M12 + (m2.M12), m1.M13 + (m2.M13), m1.M20 + (m2.M20), m1.M21 + (m2.M21), m1.M22 + (m2.M22), m1.M23 + (m2.M23), m1.M30 + (m2.M30), m1.M31 + (m2.M31), m1.M32 + (m2.M32), m1.M33 + (m2.M33));
        }

        public static mat4x4 operator *(mat4x4 m1, float a)
        {
            return new mat4x4(m1.M00 * (a), m1.M01 * (a), m1.M02 * (a), m1.M03 * (a), m1.M10 * (a), m1.M11 * (a), m1.M12 * (a), m1.M13 * (a), m1.M20 * (a), m1.M21 * (a), m1.M22 * (a), m1.M23 * (a), m1.M30 * (a), m1.M31 * (a), m1.M32 * (a), m1.M33 * (a));
        }

        public static mat4x4 operator *(float a, mat4x4 m) { return m * a; }

        public static mat4x4 operator /(mat4x4 m1, float a)
        {
            return new mat4x4(m1.M00 / (a), m1.M01 / (a), m1.M02 / (a), m1.M03 / (a), m1.M10 / (a), m1.M11 / (a), m1.M12 / (a), m1.M13 / (a), m1.M20 / (a), m1.M21 / (a), m1.M22 / (a), m1.M23 / (a), m1.M30 / (a), m1.M31 / (a), m1.M32 / (a), m1.M33 / (a));
        }

        public static mat4x4 operator -(mat4x4 m1, mat4x4 m2)
        {
            return new mat4x4(m1.M00 - (m2.M00), m1.M01 - (m2.M01), m1.M02 - (m2.M02), m1.M03 - (m2.M03), m1.M10 - (m2.M10), m1.M11 - (m2.M11), m1.M12 - (m2.M12), m1.M13 - (m2.M13), m1.M20 - (m2.M20), m1.M21 - (m2.M21), m1.M22 - (m2.M22), m1.M23 - (m2.M23), m1.M30 - (m2.M30), m1.M31 - (m2.M31), m1.M32 - (m2.M32), m1.M33 - (m2.M33));
        }

        public static mat4x4 operator /(mat4x4 m1, mat4x4 m2)
        {
            return new mat4x4(m1.M00 / (m2.M00), m1.M01 / (m2.M01), m1.M02 / (m2.M02), m1.M03 / (m2.M03), m1.M10 / (m2.M10), m1.M11 / (m2.M11), m1.M12 / (m2.M12), m1.M13 / (m2.M13), m1.M20 / (m2.M20), m1.M21 / (m2.M21), m1.M22 / (m2.M22), m1.M23 / (m2.M23), m1.M30 / (m2.M30), m1.M31 / (m2.M31), m1.M32 / (m2.M32), m1.M33 / (m2.M33));
        }

        public static mat4x4 operator *(mat4x4 m1, mat4x4 m2)
        {
            return new mat4x4(m1.M00 * (m2.M00), m1.M01 * (m2.M01), m1.M02 * (m2.M02), m1.M03 * (m2.M03), m1.M10 * (m2.M10), m1.M11 * (m2.M11), m1.M12 * (m2.M12), m1.M13 * (m2.M13), m1.M20 * (m2.M20), m1.M21 * (m2.M21), m1.M22 * (m2.M22), m1.M23 * (m2.M23), m1.M30 * (m2.M30), m1.M31 * (m2.M31), m1.M32 * (m2.M32), m1.M33 * (m2.M33));
        }

        public mat4x4 Transpose
        {
            get
            {
                return Gfx.transpose(this);
            }
        }

        #endregion

        #region Conversions

        public static explicit operator mat1x1(mat4x4 m)
        {
            return new mat1x1(m.M00);
        }
        public static explicit operator mat1x2(mat4x4 m)
        {
            return new mat1x2(m.M00, m.M01);
        }
        public static explicit operator mat1x3(mat4x4 m)
        {
            return new mat1x3(m.M00, m.M01, m.M02);
        }
        public static explicit operator mat1x4(mat4x4 m)
        {
            return new mat1x4(m.M00, m.M01, m.M02, m.M03);
        }
        public static explicit operator mat2x1(mat4x4 m)
        {
            return new mat2x1(m.M00, m.M10);
        }
        public static explicit operator mat2x2(mat4x4 m)
        {
            return new mat2x2(m.M00, m.M01, m.M10, m.M11);
        }
        public static explicit operator mat2x3(mat4x4 m)
        {
            return new mat2x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12);
        }
        public static explicit operator mat2x4(mat4x4 m)
        {
            return new mat2x4(m.M00, m.M01, m.M02, m.M03, m.M10, m.M11, m.M12, m.M13);
        }
        public static explicit operator mat3x1(mat4x4 m)
        {
            return new mat3x1(m.M00, m.M10, m.M20);
        }
        public static explicit operator mat3x2(mat4x4 m)
        {
            return new mat3x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21);
        }
        public static explicit operator mat3x3(mat4x4 m)
        {
            return new mat3x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12, m.M20, m.M21, m.M22);
        }
        public static explicit operator mat3x4(mat4x4 m)
        {
            return new mat3x4(m.M00, m.M01, m.M02, m.M03, m.M10, m.M11, m.M12, m.M13, m.M20, m.M21, m.M22, m.M23);
        }
        public static explicit operator mat4x1(mat4x4 m)
        {
            return new mat4x1(m.M00, m.M10, m.M20, m.M30);
        }
        public static explicit operator mat4x2(mat4x4 m)
        {
            return new mat4x2(m.M00, m.M01, m.M10, m.M11, m.M20, m.M21, m.M30, m.M31);
        }
        public static explicit operator mat4x3(mat4x4 m)
        {
            return new mat4x3(m.M00, m.M01, m.M02, m.M10, m.M11, m.M12, m.M20, m.M21, m.M22, m.M30, m.M31, m.M32);
        }


        #endregion

        public mat4x4 Inverse
        {
            get
            {
                float Min00 = M11 * M22 * M33 + M12 * M23 * M31 + M13 * M21 * M32 - M11 * M23 * M32 - M12 * M21 * M33 - M13 * M22 * M31;
                float Min01 = M10 * M22 * M33 + M12 * M23 * M30 + M13 * M20 * M32 - M10 * M23 * M32 - M12 * M20 * M33 - M13 * M22 * M30;
                float Min02 = M10 * M21 * M33 + M11 * M23 * M30 + M13 * M20 * M31 - M10 * M23 * M31 - M11 * M20 * M33 - M13 * M21 * M30;
                float Min03 = M10 * M21 * M32 + M11 * M22 * M30 + M12 * M20 * M31 - M10 * M22 * M31 - M11 * M20 * M32 - M12 * M21 * M30;

                float det = Min00 * M00 - Min01 * M01 + Min02 * M02 - Min03 * M03;

                if (det == 0)
                    throw new InvalidOperationException("Singular matrices have not inverse");

                float Min10 = M01 * M22 * M33 + M02 * M23 * M31 + M03 * M21 * M32 - M01 * M23 * M32 - M02 * M21 * M33 - M03 * M22 * M31;
                float Min11 = M00 * M22 * M33 + M02 * M23 * M30 + M03 * M20 * M32 - M00 * M23 * M32 - M02 * M20 * M33 - M03 * M22 * M30;
                float Min12 = M00 * M21 * M33 + M01 * M23 * M30 + M03 * M20 * M31 - M00 * M23 * M31 - M01 * M20 * M33 - M03 * M21 * M30;
                float Min13 = M00 * M21 * M32 + M01 * M22 * M30 + M02 * M20 * M31 - M00 * M22 * M31 - M01 * M20 * M32 - M02 * M21 * M30;

                float Min20 = M01 * M12 * M33 + M02 * M13 * M31 + M03 * M11 * M32 - M01 * M13 * M32 - M02 * M11 * M33 - M03 * M12 * M31;
                float Min21 = M00 * M12 * M33 + M02 * M13 * M30 + M03 * M10 * M32 - M00 * M13 * M32 - M02 * M10 * M33 - M03 * M12 * M30;
                float Min22 = M00 * M11 * M33 + M01 * M13 * M30 + M03 * M10 * M31 - M00 * M13 * M31 - M01 * M10 * M33 - M03 * M11 * M30;
                float Min23 = M00 * M11 * M32 + M01 * M12 * M30 + M02 * M10 * M31 - M00 * M12 * M31 - M01 * M10 * M32 - M02 * M11 * M30;

                float Min30 = M01 * M12 * M23 + M02 * M13 * M21 + M03 * M11 * M22 - M01 * M13 * M22 - M02 * M11 * M23 - M03 * M12 * M21;
                float Min31 = M00 * M12 * M23 + M02 * M13 * M20 + M03 * M10 * M22 - M00 * M13 * M22 - M02 * M10 * M23 - M03 * M12 * M20;
                float Min32 = M00 * M11 * M23 + M01 * M13 * M20 + M03 * M10 * M21 - M00 * M13 * M21 - M01 * M10 * M23 - M03 * M11 * M20;
                float Min33 = M00 * M11 * M22 + M01 * M12 * M20 + M02 * M10 * M21 - M00 * M12 * M21 - M01 * M10 * M22 - M02 * M11 * M20;

                return new mat4x4(
                    (+Min00 / det), (-Min10 / det), (+Min20 / det), (-Min30 / det),
                    (-Min01 / det), (+Min11 / det), (-Min21 / det), (+Min31 / det),
                    (+Min02 / det), (-Min12 / det), (+Min22 / det), (-Min32 / det),
                    (-Min03 / det), (+Min13 / det), (-Min23 / det), (+Min33 / det));
            }
        }

        public float Determinant
        {
            get { return Gfx.determinant(this); }
        }

        public bool IsSingular { get { return Determinant == 0; } }

    }
    #endregion

    #endregion

    public class Gfx
    {
        static Random rnd = new Random();
       
        public static float random()
        {
            return (float)rnd.NextDouble();
        }

        public static float3 randomSphere()
        {
            while (true)
            {
                float3 v = float3(random() * 2 - 1, random() * 2 - 1, random() * 2 - 1);
                float l = length(v);
                if (l > 0 && l <= 1)
                    return v / l;
            }
        }

        public static float3 randomHemisphere(float3 N)
        {
            float3 v = randomSphere();
            return (dot(v, N) > 0) ? v : -v;
        }

        public float randomNormal(float mu = 0, float sigma = 1)
        {
            double u1 = 1.0 - rnd.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rnd.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return (float)(mu + sigma * randStdNormal); //random normal(mean,stdDev^2)
        }

        public static float3 float3(float x)
        {
            return new float3(x, x, x);
        }
        public static float3 float3(float x, float y, float z)
        {
            return new float3(x, y, z);
        }

        public static float4 float4(float x, float y, float z, float w)
        {
            return new float4(x, y, z, w);
        }

        public static float4 float4(float3 v, float w)
        {
            return new float4(v, w);
        }

        public static float2 float2(float x, float y)
        {
            return new float2(x, y);
        }

        public const float Pi = (float)Math.PI;
        public const float TwicePi = 2 * (float)Math.PI;
        public const float PiOver4 = Pi / 4;

        #region abs

        /// <summary>
        /// Performs the abs function to the specified Vector1 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static float abs(float v)
        {
            return ((float)Math.Abs(v));
        }

        /// <summary>
        /// Performs the abs function to the specified Vector2 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static float2 abs(float2 v)
        {
            return new float2((float)Math.Abs(v.x), (float)Math.Abs(v.y));
        }

        /// <summary>
        /// Performs the abs function to the specified float3 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static float3 abs(float3 v)
        {
            return new float3((float)Math.Abs(v.x), (float)Math.Abs(v.y), (float)Math.Abs(v.z));
        }

        /// <summary>
        /// Performs the abs function to the specified float4 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static float4 abs(float4 v)
        {
            return new float4((float)Math.Abs(v.x), (float)Math.Abs(v.y), (float)Math.Abs(v.z), (float)Math.Abs(v.w));
        }


        /// <summary>
        /// Performs the abs function to the specified mat1x1 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat1x1 abs(mat1x1 v)
        {
            return new mat1x1((float)Math.Abs(v.M00));
        }

        /// <summary>
        /// Performs the abs function to the specified mat1x2 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat1x2 abs(mat1x2 v)
        {
            return new mat1x2((float)Math.Abs(v.M00), (float)Math.Abs(v.M01));
        }

        /// <summary>
        /// Performs the abs function to the specified mat1x3 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat1x3 abs(mat1x3 v)
        {
            return new mat1x3((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02));
        }

        /// <summary>
        /// Performs the abs function to the specified mat1x4 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat1x4 abs(mat1x4 v)
        {
            return new mat1x4((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M03));
        }

        /// <summary>
        /// Performs the abs function to the specified mat2x1 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat2x1 abs(mat2x1 v)
        {
            return new mat2x1((float)Math.Abs(v.M00), (float)Math.Abs(v.M10));
        }

        /// <summary>
        /// Performs the abs function to the specified mat2x2 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat2x2 abs(mat2x2 v)
        {
            return new mat2x2((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11));
        }

        /// <summary>
        /// Performs the abs function to the specified mat2x3 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat2x3 abs(mat2x3 v)
        {
            return new mat2x3((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12));
        }

        /// <summary>
        /// Performs the abs function to the specified mat2x4 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat2x4 abs(mat2x4 v)
        {
            return new mat2x4((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M03), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12), (float)Math.Abs(v.M13));
        }

        /// <summary>
        /// Performs the abs function to the specified mat3x1 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat3x1 abs(mat3x1 v)
        {
            return new mat3x1((float)Math.Abs(v.M00), (float)Math.Abs(v.M10), (float)Math.Abs(v.M20));
        }

        /// <summary>
        /// Performs the abs function to the specified mat3x2 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat3x2 abs(mat3x2 v)
        {
            return new mat3x2((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21));
        }

        /// <summary>
        /// Performs the abs function to the specified mat3x3 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat3x3 abs(mat3x3 v)
        {
            return new mat3x3((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21), (float)Math.Abs(v.M22));
        }

        /// <summary>
        /// Performs the abs function to the specified mat3x4 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat3x4 abs(mat3x4 v)
        {
            return new mat3x4((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M03), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12), (float)Math.Abs(v.M13), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21), (float)Math.Abs(v.M22), (float)Math.Abs(v.M23));
        }

        /// <summary>
        /// Performs the abs function to the specified mat4x1 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat4x1 abs(mat4x1 v)
        {
            return new mat4x1((float)Math.Abs(v.M00), (float)Math.Abs(v.M10), (float)Math.Abs(v.M20), (float)Math.Abs(v.M30));
        }

        /// <summary>
        /// Performs the abs function to the specified mat4x2 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat4x2 abs(mat4x2 v)
        {
            return new mat4x2((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21), (float)Math.Abs(v.M30), (float)Math.Abs(v.M31));
        }

        /// <summary>
        /// Performs the abs function to the specified mat4x3 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat4x3 abs(mat4x3 v)
        {
            return new mat4x3((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21), (float)Math.Abs(v.M22), (float)Math.Abs(v.M30), (float)Math.Abs(v.M31), (float)Math.Abs(v.M32));
        }

        /// <summary>
        /// Performs the abs function to the specified mat4x4 object.
        /// Gets the absolute value for each component.
        /// </summary>
        public static mat4x4 abs(mat4x4 v)
        {
            return new mat4x4((float)Math.Abs(v.M00), (float)Math.Abs(v.M01), (float)Math.Abs(v.M02), (float)Math.Abs(v.M03), (float)Math.Abs(v.M10), (float)Math.Abs(v.M11), (float)Math.Abs(v.M12), (float)Math.Abs(v.M13), (float)Math.Abs(v.M20), (float)Math.Abs(v.M21), (float)Math.Abs(v.M22), (float)Math.Abs(v.M23), (float)Math.Abs(v.M30), (float)Math.Abs(v.M31), (float)Math.Abs(v.M32), (float)Math.Abs(v.M33));
        }

        #endregion
        #region absdot
        public static float absdot(float3 a, float3 b)
        {
            return abs(dot(a, b));
        }

        public static float absdot(float4 a, float4 b)
        {
            return abs(dot(a, b));
        }
        #endregion
        #region acos

        /// <summary>
        /// Performs the acos function to the specified Vector1 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static float acos(float v)
        {
            return ((float)Math.Acos(v));
        }

        /// <summary>
        /// Performs the acos function to the specified Vector2 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static float2 acos(float2 v)
        {
            return new float2((float)Math.Acos(v.x), (float)Math.Acos(v.y));
        }

        /// <summary>
        /// Performs the acos function to the specified float3 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static float3 acos(float3 v)
        {
            return new float3((float)Math.Acos(v.x), (float)Math.Acos(v.y), (float)Math.Acos(v.z));
        }

        /// <summary>
        /// Performs the acos function to the specified float4 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static float4 acos(float4 v)
        {
            return new float4((float)Math.Acos(v.x), (float)Math.Acos(v.y), (float)Math.Acos(v.z), (float)Math.Acos(v.w));
        }


        /// <summary>
        /// Performs the acos function to the specified mat1x1 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat1x1 acos(mat1x1 v)
        {
            return new mat1x1((float)Math.Acos(v.M00));
        }

        /// <summary>
        /// Performs the acos function to the specified mat1x2 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat1x2 acos(mat1x2 v)
        {
            return new mat1x2((float)Math.Acos(v.M00), (float)Math.Acos(v.M01));
        }

        /// <summary>
        /// Performs the acos function to the specified mat1x3 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat1x3 acos(mat1x3 v)
        {
            return new mat1x3((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02));
        }

        /// <summary>
        /// Performs the acos function to the specified mat1x4 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat1x4 acos(mat1x4 v)
        {
            return new mat1x4((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M03));
        }

        /// <summary>
        /// Performs the acos function to the specified mat2x1 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat2x1 acos(mat2x1 v)
        {
            return new mat2x1((float)Math.Acos(v.M00), (float)Math.Acos(v.M10));
        }

        /// <summary>
        /// Performs the acos function to the specified mat2x2 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat2x2 acos(mat2x2 v)
        {
            return new mat2x2((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11));
        }

        /// <summary>
        /// Performs the acos function to the specified mat2x3 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat2x3 acos(mat2x3 v)
        {
            return new mat2x3((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12));
        }

        /// <summary>
        /// Performs the acos function to the specified mat2x4 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat2x4 acos(mat2x4 v)
        {
            return new mat2x4((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M03), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12), (float)Math.Acos(v.M13));
        }

        /// <summary>
        /// Performs the acos function to the specified mat3x1 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat3x1 acos(mat3x1 v)
        {
            return new mat3x1((float)Math.Acos(v.M00), (float)Math.Acos(v.M10), (float)Math.Acos(v.M20));
        }

        /// <summary>
        /// Performs the acos function to the specified mat3x2 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat3x2 acos(mat3x2 v)
        {
            return new mat3x2((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21));
        }

        /// <summary>
        /// Performs the acos function to the specified mat3x3 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat3x3 acos(mat3x3 v)
        {
            return new mat3x3((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21), (float)Math.Acos(v.M22));
        }

        /// <summary>
        /// Performs the acos function to the specified mat3x4 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat3x4 acos(mat3x4 v)
        {
            return new mat3x4((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M03), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12), (float)Math.Acos(v.M13), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21), (float)Math.Acos(v.M22), (float)Math.Acos(v.M23));
        }

        /// <summary>
        /// Performs the acos function to the specified mat4x1 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat4x1 acos(mat4x1 v)
        {
            return new mat4x1((float)Math.Acos(v.M00), (float)Math.Acos(v.M10), (float)Math.Acos(v.M20), (float)Math.Acos(v.M30));
        }

        /// <summary>
        /// Performs the acos function to the specified mat4x2 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat4x2 acos(mat4x2 v)
        {
            return new mat4x2((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21), (float)Math.Acos(v.M30), (float)Math.Acos(v.M31));
        }

        /// <summary>
        /// Performs the acos function to the specified mat4x3 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat4x3 acos(mat4x3 v)
        {
            return new mat4x3((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21), (float)Math.Acos(v.M22), (float)Math.Acos(v.M30), (float)Math.Acos(v.M31), (float)Math.Acos(v.M32));
        }

        /// <summary>
        /// Performs the acos function to the specified mat4x4 object.
        /// Gets the arc cosine of each component.
        /// </summary>
        public static mat4x4 acos(mat4x4 v)
        {
            return new mat4x4((float)Math.Acos(v.M00), (float)Math.Acos(v.M01), (float)Math.Acos(v.M02), (float)Math.Acos(v.M03), (float)Math.Acos(v.M10), (float)Math.Acos(v.M11), (float)Math.Acos(v.M12), (float)Math.Acos(v.M13), (float)Math.Acos(v.M20), (float)Math.Acos(v.M21), (float)Math.Acos(v.M22), (float)Math.Acos(v.M23), (float)Math.Acos(v.M30), (float)Math.Acos(v.M31), (float)Math.Acos(v.M32), (float)Math.Acos(v.M33));
        }

        #endregion
        #region all

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(float v)
        {
            {
                return v != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(float2 v)
        {
            {
                return v.x != 0 && v.y != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(float3 v)
        {
            {
                return v.x != 0 && v.y != 0 && v.z != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(float4 v)
        {
            {
                return v.x != 0 && v.y != 0 && v.z != 0 && v.w != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat1x1 v)
        {
            {
                return v.M00 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat1x2 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat1x3 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat1x4 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M03 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat2x1 v)
        {
            {
                return v.M00 != 0 && v.M10 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat2x2 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M10 != 0 && v.M11 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat2x3 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat2x4 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M03 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0 && v.M13 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat3x1 v)
        {
            {
                return v.M00 != 0 && v.M10 != 0 && v.M20 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat3x2 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M10 != 0 && v.M11 != 0 && v.M20 != 0 && v.M21 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat3x3 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0 && v.M20 != 0 && v.M21 != 0 && v.M22 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat3x4 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M03 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0 && v.M13 != 0 && v.M20 != 0 && v.M21 != 0 && v.M22 != 0 && v.M23 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat4x1 v)
        {
            {
                return v.M00 != 0 && v.M10 != 0 && v.M20 != 0 && v.M30 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat4x2 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M10 != 0 && v.M11 != 0 && v.M20 != 0 && v.M21 != 0 && v.M30 != 0 && v.M31 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat4x3 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0 && v.M20 != 0 && v.M21 != 0 && v.M22 != 0 && v.M30 != 0 && v.M31 != 0 && v.M32 != 0;
            }
        }

        /// <summary>
        /// Tests if all components of v are nonzero.
        /// </summary>
        public static bool all(mat4x4 v)
        {
            {
                return v.M00 != 0 && v.M01 != 0 && v.M02 != 0 && v.M03 != 0 && v.M10 != 0 && v.M11 != 0 && v.M12 != 0 && v.M13 != 0 && v.M20 != 0 && v.M21 != 0 && v.M22 != 0 && v.M23 != 0 && v.M30 != 0 && v.M31 != 0 && v.M32 != 0 && v.M33 != 0;
            }
        }
        #endregion
        #region any

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(float v)
        {
            {
                return v != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(float2 v)
        {
            {
                return v.x != 0 || v.y != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(float3 v)
        {
            {
                return v.x != 0 || v.y != 0 || v.z != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(float4 v)
        {
            {
                return v.x != 0 || v.y != 0 || v.z != 0 || v.w != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat1x1 v)
        {
            {
                return v.M00 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat1x2 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat1x3 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat1x4 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M03 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat2x1 v)
        {
            {
                return v.M00 != 0 || v.M10 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat2x2 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M10 != 0 || v.M11 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat2x3 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat2x4 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M03 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0 || v.M13 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat3x1 v)
        {
            {
                return v.M00 != 0 || v.M10 != 0 || v.M20 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat3x2 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M10 != 0 || v.M11 != 0 || v.M20 != 0 || v.M21 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat3x3 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0 || v.M20 != 0 || v.M21 != 0 || v.M22 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat3x4 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M03 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0 || v.M13 != 0 || v.M20 != 0 || v.M21 != 0 || v.M22 != 0 || v.M23 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat4x1 v)
        {
            {
                return v.M00 != 0 || v.M10 != 0 || v.M20 != 0 || v.M30 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat4x2 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M10 != 0 || v.M11 != 0 || v.M20 != 0 || v.M21 != 0 || v.M30 != 0 || v.M31 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat4x3 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0 || v.M20 != 0 || v.M21 != 0 || v.M22 != 0 || v.M30 != 0 || v.M31 != 0 || v.M32 != 0;
            }
        }

        /// <summary>
        /// Tests if any component of v is nonzero.
        /// </summary>
        public static bool any(mat4x4 v)
        {
            {
                return v.M00 != 0 || v.M01 != 0 || v.M02 != 0 || v.M03 != 0 || v.M10 != 0 || v.M11 != 0 || v.M12 != 0 || v.M13 != 0 || v.M20 != 0 || v.M21 != 0 || v.M22 != 0 || v.M23 != 0 || v.M30 != 0 || v.M31 != 0 || v.M32 != 0 || v.M33 != 0;
            }
        }
        #endregion
        #region asin

        /// <summary>
        /// Performs the asin function to the specified Vector1 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static float asin(float v)
        {
            return ((float)Math.Asin(v));
        }

        /// <summary>
        /// Performs the asin function to the specified Vector2 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static float2 asin(float2 v)
        {
            return new float2((float)Math.Asin(v.x), (float)Math.Asin(v.y));
        }

        /// <summary>
        /// Performs the asin function to the specified float3 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static float3 asin(float3 v)
        {
            return new float3((float)Math.Asin(v.x), (float)Math.Asin(v.y), (float)Math.Asin(v.z));
        }

        /// <summary>
        /// Performs the asin function to the specified float4 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static float4 asin(float4 v)
        {
            return new float4((float)Math.Asin(v.x), (float)Math.Asin(v.y), (float)Math.Asin(v.z), (float)Math.Asin(v.w));
        }


        /// <summary>
        /// Performs the asin function to the specified mat1x1 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat1x1 asin(mat1x1 v)
        {
            return new mat1x1((float)Math.Asin(v.M00));
        }

        /// <summary>
        /// Performs the asin function to the specified mat1x2 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat1x2 asin(mat1x2 v)
        {
            return new mat1x2((float)Math.Asin(v.M00), (float)Math.Asin(v.M01));
        }

        /// <summary>
        /// Performs the asin function to the specified mat1x3 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat1x3 asin(mat1x3 v)
        {
            return new mat1x3((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02));
        }

        /// <summary>
        /// Performs the asin function to the specified mat1x4 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat1x4 asin(mat1x4 v)
        {
            return new mat1x4((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M03));
        }

        /// <summary>
        /// Performs the asin function to the specified mat2x1 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat2x1 asin(mat2x1 v)
        {
            return new mat2x1((float)Math.Asin(v.M00), (float)Math.Asin(v.M10));
        }

        /// <summary>
        /// Performs the asin function to the specified mat2x2 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat2x2 asin(mat2x2 v)
        {
            return new mat2x2((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11));
        }

        /// <summary>
        /// Performs the asin function to the specified mat2x3 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat2x3 asin(mat2x3 v)
        {
            return new mat2x3((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12));
        }

        /// <summary>
        /// Performs the asin function to the specified mat2x4 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat2x4 asin(mat2x4 v)
        {
            return new mat2x4((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M03), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12), (float)Math.Asin(v.M13));
        }

        /// <summary>
        /// Performs the asin function to the specified mat3x1 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat3x1 asin(mat3x1 v)
        {
            return new mat3x1((float)Math.Asin(v.M00), (float)Math.Asin(v.M10), (float)Math.Asin(v.M20));
        }

        /// <summary>
        /// Performs the asin function to the specified mat3x2 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat3x2 asin(mat3x2 v)
        {
            return new mat3x2((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21));
        }

        /// <summary>
        /// Performs the asin function to the specified mat3x3 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat3x3 asin(mat3x3 v)
        {
            return new mat3x3((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21), (float)Math.Asin(v.M22));
        }

        /// <summary>
        /// Performs the asin function to the specified mat3x4 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat3x4 asin(mat3x4 v)
        {
            return new mat3x4((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M03), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12), (float)Math.Asin(v.M13), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21), (float)Math.Asin(v.M22), (float)Math.Asin(v.M23));
        }

        /// <summary>
        /// Performs the asin function to the specified mat4x1 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat4x1 asin(mat4x1 v)
        {
            return new mat4x1((float)Math.Asin(v.M00), (float)Math.Asin(v.M10), (float)Math.Asin(v.M20), (float)Math.Asin(v.M30));
        }

        /// <summary>
        /// Performs the asin function to the specified mat4x2 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat4x2 asin(mat4x2 v)
        {
            return new mat4x2((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21), (float)Math.Asin(v.M30), (float)Math.Asin(v.M31));
        }

        /// <summary>
        /// Performs the asin function to the specified mat4x3 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat4x3 asin(mat4x3 v)
        {
            return new mat4x3((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21), (float)Math.Asin(v.M22), (float)Math.Asin(v.M30), (float)Math.Asin(v.M31), (float)Math.Asin(v.M32));
        }

        /// <summary>
        /// Performs the asin function to the specified mat4x4 object.
        /// Gets the arc sine of each component.
        /// </summary>
        public static mat4x4 asin(mat4x4 v)
        {
            return new mat4x4((float)Math.Asin(v.M00), (float)Math.Asin(v.M01), (float)Math.Asin(v.M02), (float)Math.Asin(v.M03), (float)Math.Asin(v.M10), (float)Math.Asin(v.M11), (float)Math.Asin(v.M12), (float)Math.Asin(v.M13), (float)Math.Asin(v.M20), (float)Math.Asin(v.M21), (float)Math.Asin(v.M22), (float)Math.Asin(v.M23), (float)Math.Asin(v.M30), (float)Math.Asin(v.M31), (float)Math.Asin(v.M32), (float)Math.Asin(v.M33));
        }

        #endregion
        #region atan

        /// <summary>
        /// Performs the atan function to the specified Vector1 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static float atan(float v)
        {
            return ((float)Math.Atan(v));
        }

        /// <summary>
        /// Performs the atan function to the specified Vector2 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static float2 atan(float2 v)
        {
            return new float2((float)Math.Atan(v.x), (float)Math.Atan(v.y));
        }

        /// <summary>
        /// Performs the atan function to the specified float3 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static float3 atan(float3 v)
        {
            return new float3((float)Math.Atan(v.x), (float)Math.Atan(v.y), (float)Math.Atan(v.z));
        }

        /// <summary>
        /// Performs the atan function to the specified float4 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static float4 atan(float4 v)
        {
            return new float4((float)Math.Atan(v.x), (float)Math.Atan(v.y), (float)Math.Atan(v.z), (float)Math.Atan(v.w));
        }


        /// <summary>
        /// Performs the atan function to the specified mat1x1 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat1x1 atan(mat1x1 v)
        {
            return new mat1x1((float)Math.Atan(v.M00));
        }

        /// <summary>
        /// Performs the atan function to the specified mat1x2 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat1x2 atan(mat1x2 v)
        {
            return new mat1x2((float)Math.Atan(v.M00), (float)Math.Atan(v.M01));
        }

        /// <summary>
        /// Performs the atan function to the specified mat1x3 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat1x3 atan(mat1x3 v)
        {
            return new mat1x3((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02));
        }

        /// <summary>
        /// Performs the atan function to the specified mat1x4 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat1x4 atan(mat1x4 v)
        {
            return new mat1x4((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M03));
        }

        /// <summary>
        /// Performs the atan function to the specified mat2x1 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat2x1 atan(mat2x1 v)
        {
            return new mat2x1((float)Math.Atan(v.M00), (float)Math.Atan(v.M10));
        }

        /// <summary>
        /// Performs the atan function to the specified mat2x2 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat2x2 atan(mat2x2 v)
        {
            return new mat2x2((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11));
        }

        /// <summary>
        /// Performs the atan function to the specified mat2x3 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat2x3 atan(mat2x3 v)
        {
            return new mat2x3((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12));
        }

        /// <summary>
        /// Performs the atan function to the specified mat2x4 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat2x4 atan(mat2x4 v)
        {
            return new mat2x4((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M03), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12), (float)Math.Atan(v.M13));
        }

        /// <summary>
        /// Performs the atan function to the specified mat3x1 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat3x1 atan(mat3x1 v)
        {
            return new mat3x1((float)Math.Atan(v.M00), (float)Math.Atan(v.M10), (float)Math.Atan(v.M20));
        }

        /// <summary>
        /// Performs the atan function to the specified mat3x2 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat3x2 atan(mat3x2 v)
        {
            return new mat3x2((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21));
        }

        /// <summary>
        /// Performs the atan function to the specified mat3x3 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat3x3 atan(mat3x3 v)
        {
            return new mat3x3((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21), (float)Math.Atan(v.M22));
        }

        /// <summary>
        /// Performs the atan function to the specified mat3x4 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat3x4 atan(mat3x4 v)
        {
            return new mat3x4((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M03), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12), (float)Math.Atan(v.M13), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21), (float)Math.Atan(v.M22), (float)Math.Atan(v.M23));
        }

        /// <summary>
        /// Performs the atan function to the specified mat4x1 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat4x1 atan(mat4x1 v)
        {
            return new mat4x1((float)Math.Atan(v.M00), (float)Math.Atan(v.M10), (float)Math.Atan(v.M20), (float)Math.Atan(v.M30));
        }

        /// <summary>
        /// Performs the atan function to the specified mat4x2 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat4x2 atan(mat4x2 v)
        {
            return new mat4x2((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21), (float)Math.Atan(v.M30), (float)Math.Atan(v.M31));
        }

        /// <summary>
        /// Performs the atan function to the specified mat4x3 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat4x3 atan(mat4x3 v)
        {
            return new mat4x3((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21), (float)Math.Atan(v.M22), (float)Math.Atan(v.M30), (float)Math.Atan(v.M31), (float)Math.Atan(v.M32));
        }

        /// <summary>
        /// Performs the atan function to the specified mat4x4 object.
        /// Gets the arc tangent of v. Return value is in range [-pi/2, pi/2].
        /// </summary>
        public static mat4x4 atan(mat4x4 v)
        {
            return new mat4x4((float)Math.Atan(v.M00), (float)Math.Atan(v.M01), (float)Math.Atan(v.M02), (float)Math.Atan(v.M03), (float)Math.Atan(v.M10), (float)Math.Atan(v.M11), (float)Math.Atan(v.M12), (float)Math.Atan(v.M13), (float)Math.Atan(v.M20), (float)Math.Atan(v.M21), (float)Math.Atan(v.M22), (float)Math.Atan(v.M23), (float)Math.Atan(v.M30), (float)Math.Atan(v.M31), (float)Math.Atan(v.M32), (float)Math.Atan(v.M33));
        }

        #endregion
        #region atan2

        /// <summary>
        /// Performs the atan2 function to the specified Vector1 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static float atan2(float v1, float v2)
        {
            return ((float)Math.Atan2(v1, v2));
        }

        /// <summary>
        /// Performs the atan2 function to the specified Vector2 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static float2 atan2(float2 v1, float2 v2)
        {
            return new float2((float)Math.Atan2(v1.x, v2.x), (float)Math.Atan2(v1.y, v2.y));
        }

        /// <summary>
        /// Performs the atan2 function to the specified float3 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static float3 atan2(float3 v1, float3 v2)
        {
            return new float3((float)Math.Atan2(v1.x, v2.x), (float)Math.Atan2(v1.y, v2.y), (float)Math.Atan2(v1.z, v2.z));
        }

        /// <summary>
        /// Performs the atan2 function to the specified float4 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static float4 atan2(float4 v1, float4 v2)
        {
            return new float4((float)Math.Atan2(v1.x, v2.x), (float)Math.Atan2(v1.y, v2.y), (float)Math.Atan2(v1.z, v2.z), (float)Math.Atan2(v1.w, v2.w));
        }


        /// <summary>
        /// Performs the atan2 function to the specified mat1x1 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat1x1 atan2(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1((float)Math.Atan2(v1.M00, v2.M00));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat1x2 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat1x2 atan2(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat1x3 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat1x3 atan2(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat1x4 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat1x4 atan2(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M03, v2.M03));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat2x1 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat2x1 atan2(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M10, v2.M10));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat2x2 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat2x2 atan2(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat2x3 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat2x3 atan2(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat2x4 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat2x4 atan2(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M03, v2.M03), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12), (float)Math.Atan2(v1.M13, v2.M13));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat3x1 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat3x1 atan2(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M20, v2.M20));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat3x2 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat3x2 atan2(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat3x3 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat3x3 atan2(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21), (float)Math.Atan2(v1.M22, v2.M22));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat3x4 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat3x4 atan2(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M03, v2.M03), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12), (float)Math.Atan2(v1.M13, v2.M13), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21), (float)Math.Atan2(v1.M22, v2.M22), (float)Math.Atan2(v1.M23, v2.M23));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat4x1 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat4x1 atan2(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M30, v2.M30));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat4x2 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat4x2 atan2(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21), (float)Math.Atan2(v1.M30, v2.M30), (float)Math.Atan2(v1.M31, v2.M31));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat4x3 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat4x3 atan2(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21), (float)Math.Atan2(v1.M22, v2.M22), (float)Math.Atan2(v1.M30, v2.M30), (float)Math.Atan2(v1.M31, v2.M31), (float)Math.Atan2(v1.M32, v2.M32));
        }

        /// <summary>
        /// Performs the atan2 function to the specified mat4x4 objects.
        /// Gets the arc tangent of (v2/v1).
        /// </summary>
        public static mat4x4 atan2(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4((float)Math.Atan2(v1.M00, v2.M00), (float)Math.Atan2(v1.M01, v2.M01), (float)Math.Atan2(v1.M02, v2.M02), (float)Math.Atan2(v1.M03, v2.M03), (float)Math.Atan2(v1.M10, v2.M10), (float)Math.Atan2(v1.M11, v2.M11), (float)Math.Atan2(v1.M12, v2.M12), (float)Math.Atan2(v1.M13, v2.M13), (float)Math.Atan2(v1.M20, v2.M20), (float)Math.Atan2(v1.M21, v2.M21), (float)Math.Atan2(v1.M22, v2.M22), (float)Math.Atan2(v1.M23, v2.M23), (float)Math.Atan2(v1.M30, v2.M30), (float)Math.Atan2(v1.M31, v2.M31), (float)Math.Atan2(v1.M32, v2.M32), (float)Math.Atan2(v1.M33, v2.M33));
        }

        #endregion
        #region ceil

        /// <summary>
        /// Performs the ceil function to the specified Vector1 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static float ceil(float v)
        {
            return ((float)Math.Ceiling(v));
        }

        /// <summary>
        /// Performs the ceil function to the specified Vector2 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static float2 ceil(float2 v)
        {
            return new float2((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y));
        }

        /// <summary>
        /// Performs the ceil function to the specified float3 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static float3 ceil(float3 v)
        {
            return new float3((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z));
        }

        /// <summary>
        /// Performs the ceil function to the specified float4 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static float4 ceil(float4 v)
        {
            return new float4((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z), (float)Math.Ceiling(v.w));
        }


        /// <summary>
        /// Performs the ceil function to the specified mat1x1 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat1x1 ceil(mat1x1 v)
        {
            return new mat1x1((float)Math.Ceiling(v.M00));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat1x2 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat1x2 ceil(mat1x2 v)
        {
            return new mat1x2((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat1x3 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat1x3 ceil(mat1x3 v)
        {
            return new mat1x3((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat1x4 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat1x4 ceil(mat1x4 v)
        {
            return new mat1x4((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M03));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat2x1 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat2x1 ceil(mat2x1 v)
        {
            return new mat2x1((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M10));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat2x2 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat2x2 ceil(mat2x2 v)
        {
            return new mat2x2((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat2x3 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat2x3 ceil(mat2x3 v)
        {
            return new mat2x3((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat2x4 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat2x4 ceil(mat2x4 v)
        {
            return new mat2x4((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M03), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12), (float)Math.Ceiling(v.M13));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat3x1 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat3x1 ceil(mat3x1 v)
        {
            return new mat3x1((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M20));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat3x2 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat3x2 ceil(mat3x2 v)
        {
            return new mat3x2((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat3x3 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat3x3 ceil(mat3x3 v)
        {
            return new mat3x3((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21), (float)Math.Ceiling(v.M22));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat3x4 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat3x4 ceil(mat3x4 v)
        {
            return new mat3x4((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M03), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12), (float)Math.Ceiling(v.M13), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21), (float)Math.Ceiling(v.M22), (float)Math.Ceiling(v.M23));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat4x1 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat4x1 ceil(mat4x1 v)
        {
            return new mat4x1((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M30));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat4x2 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat4x2 ceil(mat4x2 v)
        {
            return new mat4x2((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21), (float)Math.Ceiling(v.M30), (float)Math.Ceiling(v.M31));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat4x3 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat4x3 ceil(mat4x3 v)
        {
            return new mat4x3((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21), (float)Math.Ceiling(v.M22), (float)Math.Ceiling(v.M30), (float)Math.Ceiling(v.M31), (float)Math.Ceiling(v.M32));
        }

        /// <summary>
        /// Performs the ceil function to the specified mat4x4 object.
        /// Gets the smallest integer that is greater than or equal to each component.
        /// </summary>
        public static mat4x4 ceil(mat4x4 v)
        {
            return new mat4x4((float)Math.Ceiling(v.M00), (float)Math.Ceiling(v.M01), (float)Math.Ceiling(v.M02), (float)Math.Ceiling(v.M03), (float)Math.Ceiling(v.M10), (float)Math.Ceiling(v.M11), (float)Math.Ceiling(v.M12), (float)Math.Ceiling(v.M13), (float)Math.Ceiling(v.M20), (float)Math.Ceiling(v.M21), (float)Math.Ceiling(v.M22), (float)Math.Ceiling(v.M23), (float)Math.Ceiling(v.M30), (float)Math.Ceiling(v.M31), (float)Math.Ceiling(v.M32), (float)Math.Ceiling(v.M33));
        }

        #endregion
        #region clamp

        /// <summary>
        /// Performs the clamp function to the specified Vector1 objects.
        /// Gets the clamp of each component to range [v2, s]
        /// </summary>
        public static float clamp(float x, float v1, float v2)
        {
            return min(v2, max(x, v1));
        }


        /// <summary>
        /// Performs the clamp function to the specified Vector2 objects.
        /// Gets the clamp of each component to range [v2, s]
        /// </summary>
        public static float2 clamp(float2 x, float2 v1, float2 v2)
        {
            return min(v2, max(x, v1));
        }


        /// <summary>
        /// Performs the clamp function to the specified float3 objects.
        /// Gets the clamp of each component to range [v2, s]
        /// </summary>
        public static float3 clamp(float3 x, float3 v1, float3 v2)
        {

            return min(v2, max(x, v1));

        }


        /// <summary>
        /// Performs the clamp function to the specified float4 objects.
        /// Gets the clamp of each component to range [v2, s]
        /// </summary>
        public static float4 clamp(float4 x, float4 v1, float4 v2)
        {

            return min(v2, max(x, v1));

        }

        #endregion
        #region cos

        /// <summary>
        /// Performs the cos function to the specified Vector1 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static float cos(float v)
        {
            return ((float)Math.Cos(v));
        }

        /// <summary>
        /// Performs the cos function to the specified Vector2 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static float2 cos(float2 v)
        {
            return new float2((float)Math.Cos(v.x), (float)Math.Cos(v.y));
        }

        /// <summary>
        /// Performs the cos function to the specified float3 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static float3 cos(float3 v)
        {
            return new float3((float)Math.Cos(v.x), (float)Math.Cos(v.y), (float)Math.Cos(v.z));
        }

        /// <summary>
        /// Performs the cos function to the specified float4 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static float4 cos(float4 v)
        {
            return new float4((float)Math.Cos(v.x), (float)Math.Cos(v.y), (float)Math.Cos(v.z), (float)Math.Cos(v.w));
        }


        /// <summary>
        /// Performs the cos function to the specified mat1x1 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat1x1 cos(mat1x1 v)
        {
            return new mat1x1((float)Math.Cos(v.M00));
        }

        /// <summary>
        /// Performs the cos function to the specified mat1x2 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat1x2 cos(mat1x2 v)
        {
            return new mat1x2((float)Math.Cos(v.M00), (float)Math.Cos(v.M01));
        }

        /// <summary>
        /// Performs the cos function to the specified mat1x3 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat1x3 cos(mat1x3 v)
        {
            return new mat1x3((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02));
        }

        /// <summary>
        /// Performs the cos function to the specified mat1x4 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat1x4 cos(mat1x4 v)
        {
            return new mat1x4((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M03));
        }

        /// <summary>
        /// Performs the cos function to the specified mat2x1 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat2x1 cos(mat2x1 v)
        {
            return new mat2x1((float)Math.Cos(v.M00), (float)Math.Cos(v.M10));
        }

        /// <summary>
        /// Performs the cos function to the specified mat2x2 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat2x2 cos(mat2x2 v)
        {
            return new mat2x2((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11));
        }

        /// <summary>
        /// Performs the cos function to the specified mat2x3 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat2x3 cos(mat2x3 v)
        {
            return new mat2x3((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12));
        }

        /// <summary>
        /// Performs the cos function to the specified mat2x4 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat2x4 cos(mat2x4 v)
        {
            return new mat2x4((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M03), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12), (float)Math.Cos(v.M13));
        }

        /// <summary>
        /// Performs the cos function to the specified mat3x1 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat3x1 cos(mat3x1 v)
        {
            return new mat3x1((float)Math.Cos(v.M00), (float)Math.Cos(v.M10), (float)Math.Cos(v.M20));
        }

        /// <summary>
        /// Performs the cos function to the specified mat3x2 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat3x2 cos(mat3x2 v)
        {
            return new mat3x2((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21));
        }

        /// <summary>
        /// Performs the cos function to the specified mat3x3 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat3x3 cos(mat3x3 v)
        {
            return new mat3x3((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21), (float)Math.Cos(v.M22));
        }

        /// <summary>
        /// Performs the cos function to the specified mat3x4 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat3x4 cos(mat3x4 v)
        {
            return new mat3x4((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M03), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12), (float)Math.Cos(v.M13), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21), (float)Math.Cos(v.M22), (float)Math.Cos(v.M23));
        }

        /// <summary>
        /// Performs the cos function to the specified mat4x1 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat4x1 cos(mat4x1 v)
        {
            return new mat4x1((float)Math.Cos(v.M00), (float)Math.Cos(v.M10), (float)Math.Cos(v.M20), (float)Math.Cos(v.M30));
        }

        /// <summary>
        /// Performs the cos function to the specified mat4x2 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat4x2 cos(mat4x2 v)
        {
            return new mat4x2((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21), (float)Math.Cos(v.M30), (float)Math.Cos(v.M31));
        }

        /// <summary>
        /// Performs the cos function to the specified mat4x3 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat4x3 cos(mat4x3 v)
        {
            return new mat4x3((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21), (float)Math.Cos(v.M22), (float)Math.Cos(v.M30), (float)Math.Cos(v.M31), (float)Math.Cos(v.M32));
        }

        /// <summary>
        /// Performs the cos function to the specified mat4x4 object.
        /// Gets the cosine of each component.
        /// </summary>
        public static mat4x4 cos(mat4x4 v)
        {
            return new mat4x4((float)Math.Cos(v.M00), (float)Math.Cos(v.M01), (float)Math.Cos(v.M02), (float)Math.Cos(v.M03), (float)Math.Cos(v.M10), (float)Math.Cos(v.M11), (float)Math.Cos(v.M12), (float)Math.Cos(v.M13), (float)Math.Cos(v.M20), (float)Math.Cos(v.M21), (float)Math.Cos(v.M22), (float)Math.Cos(v.M23), (float)Math.Cos(v.M30), (float)Math.Cos(v.M31), (float)Math.Cos(v.M32), (float)Math.Cos(v.M33));
        }

        #endregion
        #region cosh

        /// <summary>
        /// Performs the cosh function to the specified Vector1 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static float cosh(float v)
        {
            return ((float)Math.Cosh(v));
        }

        /// <summary>
        /// Performs the cosh function to the specified Vector2 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static float2 cosh(float2 v)
        {
            return new float2((float)Math.Cosh(v.x), (float)Math.Cosh(v.y));
        }

        /// <summary>
        /// Performs the cosh function to the specified float3 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static float3 cosh(float3 v)
        {
            return new float3((float)Math.Cosh(v.x), (float)Math.Cosh(v.y), (float)Math.Cosh(v.z));
        }

        /// <summary>
        /// Performs the cosh function to the specified float4 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static float4 cosh(float4 v)
        {
            return new float4((float)Math.Cosh(v.x), (float)Math.Cosh(v.y), (float)Math.Cosh(v.z), (float)Math.Cosh(v.w));
        }


        /// <summary>
        /// Performs the cosh function to the specified mat1x1 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat1x1 cosh(mat1x1 v)
        {
            return new mat1x1((float)Math.Cosh(v.M00));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat1x2 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat1x2 cosh(mat1x2 v)
        {
            return new mat1x2((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat1x3 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat1x3 cosh(mat1x3 v)
        {
            return new mat1x3((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat1x4 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat1x4 cosh(mat1x4 v)
        {
            return new mat1x4((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M03));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat2x1 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat2x1 cosh(mat2x1 v)
        {
            return new mat2x1((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M10));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat2x2 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat2x2 cosh(mat2x2 v)
        {
            return new mat2x2((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat2x3 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat2x3 cosh(mat2x3 v)
        {
            return new mat2x3((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat2x4 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat2x4 cosh(mat2x4 v)
        {
            return new mat2x4((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M03), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12), (float)Math.Cosh(v.M13));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat3x1 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat3x1 cosh(mat3x1 v)
        {
            return new mat3x1((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M20));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat3x2 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat3x2 cosh(mat3x2 v)
        {
            return new mat3x2((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat3x3 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat3x3 cosh(mat3x3 v)
        {
            return new mat3x3((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21), (float)Math.Cosh(v.M22));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat3x4 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat3x4 cosh(mat3x4 v)
        {
            return new mat3x4((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M03), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12), (float)Math.Cosh(v.M13), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21), (float)Math.Cosh(v.M22), (float)Math.Cosh(v.M23));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat4x1 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat4x1 cosh(mat4x1 v)
        {
            return new mat4x1((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M30));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat4x2 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat4x2 cosh(mat4x2 v)
        {
            return new mat4x2((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21), (float)Math.Cosh(v.M30), (float)Math.Cosh(v.M31));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat4x3 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat4x3 cosh(mat4x3 v)
        {
            return new mat4x3((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21), (float)Math.Cosh(v.M22), (float)Math.Cosh(v.M30), (float)Math.Cosh(v.M31), (float)Math.Cosh(v.M32));
        }

        /// <summary>
        /// Performs the cosh function to the specified mat4x4 object.
        /// Gets the hyperbolic cosine of each component.
        /// </summary>
        public static mat4x4 cosh(mat4x4 v)
        {
            return new mat4x4((float)Math.Cosh(v.M00), (float)Math.Cosh(v.M01), (float)Math.Cosh(v.M02), (float)Math.Cosh(v.M03), (float)Math.Cosh(v.M10), (float)Math.Cosh(v.M11), (float)Math.Cosh(v.M12), (float)Math.Cosh(v.M13), (float)Math.Cosh(v.M20), (float)Math.Cosh(v.M21), (float)Math.Cosh(v.M22), (float)Math.Cosh(v.M23), (float)Math.Cosh(v.M30), (float)Math.Cosh(v.M31), (float)Math.Cosh(v.M32), (float)Math.Cosh(v.M33));
        }

        #endregion
        #region cross
        public static float3 cross(float3 pto1, float3 pto2)
        {
            return new float3(
                pto1.y * pto2.z - pto1.z * pto2.y,
                pto1.z * pto2.x - pto1.x * pto2.z,
                pto1.x * pto2.y - pto1.y * pto2.x);
        }
        #endregion
        #region degrees

        /// <summary>
        /// Performs the degrees function to the specified Vector1 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static float degrees(float v)
        {
            return ((float)(180 * v / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified Vector2 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static float2 degrees(float2 v)
        {
            return new float2((float)(180 * v.x / Math.PI), (float)(180 * v.y / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified float3 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static float3 degrees(float3 v)
        {
            return new float3((float)(180 * v.x / Math.PI), (float)(180 * v.y / Math.PI), (float)(180 * v.z / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified float4 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static float4 degrees(float4 v)
        {
            return new float4((float)(180 * v.x / Math.PI), (float)(180 * v.y / Math.PI), (float)(180 * v.z / Math.PI), (float)(180 * v.w / Math.PI));
        }


        /// <summary>
        /// Performs the degrees function to the specified mat1x1 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat1x1 degrees(mat1x1 v)
        {
            return new mat1x1((float)(180 * v.M00 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat1x2 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat1x2 degrees(mat1x2 v)
        {
            return new mat1x2((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat1x3 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat1x3 degrees(mat1x3 v)
        {
            return new mat1x3((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat1x4 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat1x4 degrees(mat1x4 v)
        {
            return new mat1x4((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M03 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat2x1 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat2x1 degrees(mat2x1 v)
        {
            return new mat2x1((float)(180 * v.M00 / Math.PI), (float)(180 * v.M10 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat2x2 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat2x2 degrees(mat2x2 v)
        {
            return new mat2x2((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat2x3 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat2x3 degrees(mat2x3 v)
        {
            return new mat2x3((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat2x4 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat2x4 degrees(mat2x4 v)
        {
            return new mat2x4((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M03 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI), (float)(180 * v.M13 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat3x1 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat3x1 degrees(mat3x1 v)
        {
            return new mat3x1((float)(180 * v.M00 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M20 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat3x2 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat3x2 degrees(mat3x2 v)
        {
            return new mat3x2((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat3x3 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat3x3 degrees(mat3x3 v)
        {
            return new mat3x3((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI), (float)(180 * v.M22 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat3x4 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat3x4 degrees(mat3x4 v)
        {
            return new mat3x4((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M03 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI), (float)(180 * v.M13 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI), (float)(180 * v.M22 / Math.PI), (float)(180 * v.M23 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat4x1 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat4x1 degrees(mat4x1 v)
        {
            return new mat4x1((float)(180 * v.M00 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M30 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat4x2 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat4x2 degrees(mat4x2 v)
        {
            return new mat4x2((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI), (float)(180 * v.M30 / Math.PI), (float)(180 * v.M31 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat4x3 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat4x3 degrees(mat4x3 v)
        {
            return new mat4x3((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI), (float)(180 * v.M22 / Math.PI), (float)(180 * v.M30 / Math.PI), (float)(180 * v.M31 / Math.PI), (float)(180 * v.M32 / Math.PI));
        }

        /// <summary>
        /// Performs the degrees function to the specified mat4x4 object.
        /// Gets the values of each component converted from radiands to degrees.
        /// </summary>
        public static mat4x4 degrees(mat4x4 v)
        {
            return new mat4x4((float)(180 * v.M00 / Math.PI), (float)(180 * v.M01 / Math.PI), (float)(180 * v.M02 / Math.PI), (float)(180 * v.M03 / Math.PI), (float)(180 * v.M10 / Math.PI), (float)(180 * v.M11 / Math.PI), (float)(180 * v.M12 / Math.PI), (float)(180 * v.M13 / Math.PI), (float)(180 * v.M20 / Math.PI), (float)(180 * v.M21 / Math.PI), (float)(180 * v.M22 / Math.PI), (float)(180 * v.M23 / Math.PI), (float)(180 * v.M30 / Math.PI), (float)(180 * v.M31 / Math.PI), (float)(180 * v.M32 / Math.PI), (float)(180 * v.M33 / Math.PI));
        }

        #endregion
        #region determinant

        public static float determinant(mat1x1 m)
        {
            return m.M00;
        }

        public static float determinant(mat2x2 m)
        {
            return m.M00 * m.M11 - m.M01 * m.M10;
        }

        public static float determinant(mat3x3 m)
        {
            /// 00 01 02
            /// 10 11 12
            /// 20 21 22
            float Min00 = m.M11 * m.M22 - m.M12 * m.M21;
            float Min01 = m.M10 * m.M22 - m.M12 * m.M20;
            float Min02 = m.M10 * m.M21 - m.M11 * m.M20;

            return Min00 * m.M00 - Min01 * m.M01 + Min02 * m.M02;
        }

        public static float determinant(mat4x4 m)
        {
            float Min00 = m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M13 * m.M21 * m.M32 - m.M11 * m.M23 * m.M32 - m.M12 * m.M21 * m.M33 - m.M13 * m.M22 * m.M31;
            float Min01 = m.M10 * m.M22 * m.M33 + m.M12 * m.M23 * m.M30 + m.M13 * m.M20 * m.M32 - m.M10 * m.M23 * m.M32 - m.M12 * m.M20 * m.M33 - m.M13 * m.M22 * m.M30;
            float Min02 = m.M10 * m.M21 * m.M33 + m.M11 * m.M23 * m.M30 + m.M13 * m.M20 * m.M31 - m.M10 * m.M23 * m.M31 - m.M11 * m.M20 * m.M33 - m.M13 * m.M21 * m.M30;
            float Min03 = m.M10 * m.M21 * m.M32 + m.M11 * m.M22 * m.M30 + m.M12 * m.M20 * m.M31 - m.M10 * m.M22 * m.M31 - m.M11 * m.M20 * m.M32 - m.M12 * m.M21 * m.M30;

            return Min00 * m.M00 - Min01 * m.M01 + Min02 * m.M02 - Min03 * m.M03;
        }

        #endregion
        #region distance

        /// <summary>
        /// Performs the distance function to the specified Vector1 objects.
        /// Gets the distance between v1 and v2.
        /// </summary>
        public static float distance(float v1, float v2)
        {

            float d = v1 - v2;
            return (float)Math.Sqrt(dot(d, d));

        }


        /// <summary>
        /// Performs the distance function to the specified Vector2 objects.
        /// Gets the distance between v1 and v2.
        /// </summary>
        public static float distance(float2 v1, float2 v2)
        {

            float2 d = v1 - v2;
            return (float)Math.Sqrt(dot(d, d));

        }


        /// <summary>
        /// Performs the distance function to the specified float3 objects.
        /// Gets the distance between v1 and v2.
        /// </summary>
        public static float distance(float3 v1, float3 v2)
        {

            float3 d = v1 - v2;
            return (float)Math.Sqrt(dot(d, d));

        }


        /// <summary>
        /// Performs the distance function to the specified float4 objects.
        /// Gets the distance between v1 and v2.
        /// </summary>
        public static float distance(float4 v1, float4 v2)
        {

            float4 d = v1 - v2;
            return (float)Math.Sqrt(dot(d, d));

        }

        #endregion
        #region dot

        /// <summary>
        /// Performs the dot function to the specified Vector1 objects.
        /// Gets the dot product of v1 and v2.
        /// </summary>
        public static float dot(float v1, float v2)
        {
            return v1 * v2;
        }


        /// <summary>
        /// Performs the dot function to the specified Vector2 objects.
        /// Gets the dot product of v1 and v2.
        /// </summary>
        public static float dot(float2 v1, float2 v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }


        /// <summary>
        /// Performs the dot function to the specified float3 objects.
        /// Gets the dot product of v1 and v2.
        /// </summary>
        public static float dot(float3 v1, float3 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }


        /// <summary>
        /// Performs the dot function to the specified float4 objects.
        /// Gets the dot product of v1 and v2.
        /// </summary>
        public static float dot(float4 v1, float4 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z + v1.w * v2.w;
        }

        #endregion
        #region exp

        /// <summary>
        /// Performs the exp function to the specified Vector1 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static float exp(float v)
        {
            return ((float)Math.Exp(v));
        }

        public static float1 exp(float1 v)
        {
            return new float1((float)Math.Exp(v.x));
        }

        /// <summary>
        /// Performs the exp function to the specified Vector2 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static float2 exp(float2 v)
        {
            return new float2((float)Math.Exp(v.x), (float)Math.Exp(v.y));
        }

        /// <summary>
        /// Performs the exp function to the specified float3 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static float3 exp(float3 v)
        {
            return new float3((float)Math.Exp(v.x), (float)Math.Exp(v.y), (float)Math.Exp(v.z));
        }

        /// <summary>
        /// Performs the exp function to the specified float4 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static float4 exp(float4 v)
        {
            return new float4((float)Math.Exp(v.x), (float)Math.Exp(v.y), (float)Math.Exp(v.z), (float)Math.Exp(v.w));
        }


        /// <summary>
        /// Performs the exp function to the specified mat1x1 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat1x1 exp(mat1x1 v)
        {
            return new mat1x1((float)Math.Exp(v.M00));
        }

        /// <summary>
        /// Performs the exp function to the specified mat1x2 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat1x2 exp(mat1x2 v)
        {
            return new mat1x2((float)Math.Exp(v.M00), (float)Math.Exp(v.M01));
        }

        /// <summary>
        /// Performs the exp function to the specified mat1x3 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat1x3 exp(mat1x3 v)
        {
            return new mat1x3((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02));
        }

        /// <summary>
        /// Performs the exp function to the specified mat1x4 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat1x4 exp(mat1x4 v)
        {
            return new mat1x4((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M03));
        }

        /// <summary>
        /// Performs the exp function to the specified mat2x1 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat2x1 exp(mat2x1 v)
        {
            return new mat2x1((float)Math.Exp(v.M00), (float)Math.Exp(v.M10));
        }

        /// <summary>
        /// Performs the exp function to the specified mat2x2 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat2x2 exp(mat2x2 v)
        {
            return new mat2x2((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11));
        }

        /// <summary>
        /// Performs the exp function to the specified mat2x3 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat2x3 exp(mat2x3 v)
        {
            return new mat2x3((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12));
        }

        /// <summary>
        /// Performs the exp function to the specified mat2x4 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat2x4 exp(mat2x4 v)
        {
            return new mat2x4((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M03), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12), (float)Math.Exp(v.M13));
        }

        /// <summary>
        /// Performs the exp function to the specified mat3x1 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat3x1 exp(mat3x1 v)
        {
            return new mat3x1((float)Math.Exp(v.M00), (float)Math.Exp(v.M10), (float)Math.Exp(v.M20));
        }

        /// <summary>
        /// Performs the exp function to the specified mat3x2 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat3x2 exp(mat3x2 v)
        {
            return new mat3x2((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21));
        }

        /// <summary>
        /// Performs the exp function to the specified mat3x3 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat3x3 exp(mat3x3 v)
        {
            return new mat3x3((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21), (float)Math.Exp(v.M22));
        }

        /// <summary>
        /// Performs the exp function to the specified mat3x4 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat3x4 exp(mat3x4 v)
        {
            return new mat3x4((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M03), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12), (float)Math.Exp(v.M13), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21), (float)Math.Exp(v.M22), (float)Math.Exp(v.M23));
        }

        /// <summary>
        /// Performs the exp function to the specified mat4x1 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat4x1 exp(mat4x1 v)
        {
            return new mat4x1((float)Math.Exp(v.M00), (float)Math.Exp(v.M10), (float)Math.Exp(v.M20), (float)Math.Exp(v.M30));
        }

        /// <summary>
        /// Performs the exp function to the specified mat4x2 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat4x2 exp(mat4x2 v)
        {
            return new mat4x2((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21), (float)Math.Exp(v.M30), (float)Math.Exp(v.M31));
        }

        /// <summary>
        /// Performs the exp function to the specified mat4x3 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat4x3 exp(mat4x3 v)
        {
            return new mat4x3((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21), (float)Math.Exp(v.M22), (float)Math.Exp(v.M30), (float)Math.Exp(v.M31), (float)Math.Exp(v.M32));
        }

        /// <summary>
        /// Performs the exp function to the specified mat4x4 object.
        /// Gets the exponentiation of e to each component.
        /// </summary>
        public static mat4x4 exp(mat4x4 v)
        {
            return new mat4x4((float)Math.Exp(v.M00), (float)Math.Exp(v.M01), (float)Math.Exp(v.M02), (float)Math.Exp(v.M03), (float)Math.Exp(v.M10), (float)Math.Exp(v.M11), (float)Math.Exp(v.M12), (float)Math.Exp(v.M13), (float)Math.Exp(v.M20), (float)Math.Exp(v.M21), (float)Math.Exp(v.M22), (float)Math.Exp(v.M23), (float)Math.Exp(v.M30), (float)Math.Exp(v.M31), (float)Math.Exp(v.M32), (float)Math.Exp(v.M33));
        }

        #endregion
        #region exp2

        /// <summary>
        /// Performs the exp2 function to the specified Vector1 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static float exp2(float v)
        {
            return ((float)Math.Pow(2, v));
        }

        /// <summary>
        /// Performs the exp2 function to the specified Vector2 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static float2 exp2(float2 v)
        {
            return new float2((float)Math.Pow(2, v.x), (float)Math.Pow(2, v.y));
        }

        /// <summary>
        /// Performs the exp2 function to the specified float3 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static float3 exp2(float3 v)
        {
            return new float3((float)Math.Pow(2, v.x), (float)Math.Pow(2, v.y), (float)Math.Pow(2, v.z));
        }

        /// <summary>
        /// Performs the exp2 function to the specified float4 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static float4 exp2(float4 v)
        {
            return new float4((float)Math.Pow(2, v.x), (float)Math.Pow(2, v.y), (float)Math.Pow(2, v.z), (float)Math.Pow(2, v.w));
        }


        /// <summary>
        /// Performs the exp2 function to the specified mat1x1 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat1x1 exp2(mat1x1 v)
        {
            return new mat1x1((float)Math.Pow(2, v.M00));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat1x2 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat1x2 exp2(mat1x2 v)
        {
            return new mat1x2((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat1x3 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat1x3 exp2(mat1x3 v)
        {
            return new mat1x3((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat1x4 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat1x4 exp2(mat1x4 v)
        {
            return new mat1x4((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M03));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat2x1 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat2x1 exp2(mat2x1 v)
        {
            return new mat2x1((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M10));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat2x2 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat2x2 exp2(mat2x2 v)
        {
            return new mat2x2((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat2x3 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat2x3 exp2(mat2x3 v)
        {
            return new mat2x3((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat2x4 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat2x4 exp2(mat2x4 v)
        {
            return new mat2x4((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M03), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12), (float)Math.Pow(2, v.M13));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat3x1 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat3x1 exp2(mat3x1 v)
        {
            return new mat3x1((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M20));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat3x2 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat3x2 exp2(mat3x2 v)
        {
            return new mat3x2((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat3x3 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat3x3 exp2(mat3x3 v)
        {
            return new mat3x3((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21), (float)Math.Pow(2, v.M22));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat3x4 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat3x4 exp2(mat3x4 v)
        {
            return new mat3x4((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M03), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12), (float)Math.Pow(2, v.M13), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21), (float)Math.Pow(2, v.M22), (float)Math.Pow(2, v.M23));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat4x1 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat4x1 exp2(mat4x1 v)
        {
            return new mat4x1((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M30));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat4x2 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat4x2 exp2(mat4x2 v)
        {
            return new mat4x2((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21), (float)Math.Pow(2, v.M30), (float)Math.Pow(2, v.M31));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat4x3 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat4x3 exp2(mat4x3 v)
        {
            return new mat4x3((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21), (float)Math.Pow(2, v.M22), (float)Math.Pow(2, v.M30), (float)Math.Pow(2, v.M31), (float)Math.Pow(2, v.M32));
        }

        /// <summary>
        /// Performs the exp2 function to the specified mat4x4 object.
        /// Gets the exponentiation of 2 to each component.
        /// </summary>
        public static mat4x4 exp2(mat4x4 v)
        {
            return new mat4x4((float)Math.Pow(2, v.M00), (float)Math.Pow(2, v.M01), (float)Math.Pow(2, v.M02), (float)Math.Pow(2, v.M03), (float)Math.Pow(2, v.M10), (float)Math.Pow(2, v.M11), (float)Math.Pow(2, v.M12), (float)Math.Pow(2, v.M13), (float)Math.Pow(2, v.M20), (float)Math.Pow(2, v.M21), (float)Math.Pow(2, v.M22), (float)Math.Pow(2, v.M23), (float)Math.Pow(2, v.M30), (float)Math.Pow(2, v.M31), (float)Math.Pow(2, v.M32), (float)Math.Pow(2, v.M33));
        }

        #endregion
        #region faceNormal
        public static float3 faceNormal(float3 normal, float3 direction)
        {
            return Gfx.dot(normal, direction) > 0 ? normal : -normal;
        }
        #endregion
        #region floor

        /// <summary>
        /// Performs the floor function to the specified Vector1 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static float floor(float v)
        {
            return ((float)Math.Floor(v));
        }

        /// <summary>
        /// Performs the floor function to the specified Vector2 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static float2 floor(float2 v)
        {
            return new float2((float)Math.Floor(v.x), (float)Math.Floor(v.y));
        }

        /// <summary>
        /// Performs the floor function to the specified float3 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static float3 floor(float3 v)
        {
            return new float3((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z));
        }

        /// <summary>
        /// Performs the floor function to the specified float4 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static float4 floor(float4 v)
        {
            return new float4((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z), (float)Math.Floor(v.w));
        }


        /// <summary>
        /// Performs the floor function to the specified mat1x1 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat1x1 floor(mat1x1 v)
        {
            return new mat1x1((float)Math.Floor(v.M00));
        }

        /// <summary>
        /// Performs the floor function to the specified mat1x2 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat1x2 floor(mat1x2 v)
        {
            return new mat1x2((float)Math.Floor(v.M00), (float)Math.Floor(v.M01));
        }

        /// <summary>
        /// Performs the floor function to the specified mat1x3 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat1x3 floor(mat1x3 v)
        {
            return new mat1x3((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02));
        }

        /// <summary>
        /// Performs the floor function to the specified mat1x4 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat1x4 floor(mat1x4 v)
        {
            return new mat1x4((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M03));
        }

        /// <summary>
        /// Performs the floor function to the specified mat2x1 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat2x1 floor(mat2x1 v)
        {
            return new mat2x1((float)Math.Floor(v.M00), (float)Math.Floor(v.M10));
        }

        /// <summary>
        /// Performs the floor function to the specified mat2x2 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat2x2 floor(mat2x2 v)
        {
            return new mat2x2((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11));
        }

        /// <summary>
        /// Performs the floor function to the specified mat2x3 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat2x3 floor(mat2x3 v)
        {
            return new mat2x3((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12));
        }

        /// <summary>
        /// Performs the floor function to the specified mat2x4 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat2x4 floor(mat2x4 v)
        {
            return new mat2x4((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M03), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12), (float)Math.Floor(v.M13));
        }

        /// <summary>
        /// Performs the floor function to the specified mat3x1 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat3x1 floor(mat3x1 v)
        {
            return new mat3x1((float)Math.Floor(v.M00), (float)Math.Floor(v.M10), (float)Math.Floor(v.M20));
        }

        /// <summary>
        /// Performs the floor function to the specified mat3x2 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat3x2 floor(mat3x2 v)
        {
            return new mat3x2((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21));
        }

        /// <summary>
        /// Performs the floor function to the specified mat3x3 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat3x3 floor(mat3x3 v)
        {
            return new mat3x3((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21), (float)Math.Floor(v.M22));
        }

        /// <summary>
        /// Performs the floor function to the specified mat3x4 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat3x4 floor(mat3x4 v)
        {
            return new mat3x4((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M03), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12), (float)Math.Floor(v.M13), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21), (float)Math.Floor(v.M22), (float)Math.Floor(v.M23));
        }

        /// <summary>
        /// Performs the floor function to the specified mat4x1 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat4x1 floor(mat4x1 v)
        {
            return new mat4x1((float)Math.Floor(v.M00), (float)Math.Floor(v.M10), (float)Math.Floor(v.M20), (float)Math.Floor(v.M30));
        }

        /// <summary>
        /// Performs the floor function to the specified mat4x2 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat4x2 floor(mat4x2 v)
        {
            return new mat4x2((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21), (float)Math.Floor(v.M30), (float)Math.Floor(v.M31));
        }

        /// <summary>
        /// Performs the floor function to the specified mat4x3 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat4x3 floor(mat4x3 v)
        {
            return new mat4x3((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21), (float)Math.Floor(v.M22), (float)Math.Floor(v.M30), (float)Math.Floor(v.M31), (float)Math.Floor(v.M32));
        }

        /// <summary>
        /// Performs the floor function to the specified mat4x4 object.
        /// Gets the greatest integer that is less than or equal to each component.
        /// </summary>
        public static mat4x4 floor(mat4x4 v)
        {
            return new mat4x4((float)Math.Floor(v.M00), (float)Math.Floor(v.M01), (float)Math.Floor(v.M02), (float)Math.Floor(v.M03), (float)Math.Floor(v.M10), (float)Math.Floor(v.M11), (float)Math.Floor(v.M12), (float)Math.Floor(v.M13), (float)Math.Floor(v.M20), (float)Math.Floor(v.M21), (float)Math.Floor(v.M22), (float)Math.Floor(v.M23), (float)Math.Floor(v.M30), (float)Math.Floor(v.M31), (float)Math.Floor(v.M32), (float)Math.Floor(v.M33));
        }

        #endregion
        #region fmod

        /// <summary>
        /// Performs the fmod function to the specified Vector1 objects.
        /// 
        /// </summary>
        public static float fmod(float v1, float v2)
        {
            return (v1 % v2);
        }

        /// <summary>
        /// Performs the fmod function to the specified Vector2 objects.
        /// 
        /// </summary>
        public static float2 fmod(float2 v1, float2 v2)
        {
            return new float2(v1.x % v2.x, v1.y % v2.y);
        }

        /// <summary>
        /// Performs the fmod function to the specified float3 objects.
        /// 
        /// </summary>
        public static float3 fmod(float3 v1, float3 v2)
        {
            return new float3(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z);
        }

        /// <summary>
        /// Performs the fmod function to the specified float4 objects.
        /// 
        /// </summary>
        public static float4 fmod(float4 v1, float4 v2)
        {
            return new float4(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z, v1.w % v2.w);
        }


        /// <summary>
        /// Performs the fmod function to the specified mat1x1 objects.
        /// 
        /// </summary>
        public static mat1x1 fmod(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1(v1.M00 % v2.M00);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat1x2 objects.
        /// 
        /// </summary>
        public static mat1x2 fmod(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2(v1.M00 % v2.M00, v1.M01 % v2.M01);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat1x3 objects.
        /// 
        /// </summary>
        public static mat1x3 fmod(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat1x4 objects.
        /// 
        /// </summary>
        public static mat1x4 fmod(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M03 % v2.M03);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat2x1 objects.
        /// 
        /// </summary>
        public static mat2x1 fmod(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1(v1.M00 % v2.M00, v1.M10 % v2.M10);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat2x2 objects.
        /// 
        /// </summary>
        public static mat2x2 fmod(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M10 % v2.M10, v1.M11 % v2.M11);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat2x3 objects.
        /// 
        /// </summary>
        public static mat2x3 fmod(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat2x4 objects.
        /// 
        /// </summary>
        public static mat2x4 fmod(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M03 % v2.M03, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12, v1.M13 % v2.M13);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat3x1 objects.
        /// 
        /// </summary>
        public static mat3x1 fmod(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1(v1.M00 % v2.M00, v1.M10 % v2.M10, v1.M20 % v2.M20);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat3x2 objects.
        /// 
        /// </summary>
        public static mat3x2 fmod(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M20 % v2.M20, v1.M21 % v2.M21);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat3x3 objects.
        /// 
        /// </summary>
        public static mat3x3 fmod(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12, v1.M20 % v2.M20, v1.M21 % v2.M21, v1.M22 % v2.M22);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat3x4 objects.
        /// 
        /// </summary>
        public static mat3x4 fmod(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M03 % v2.M03, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12, v1.M13 % v2.M13, v1.M20 % v2.M20, v1.M21 % v2.M21, v1.M22 % v2.M22, v1.M23 % v2.M23);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat4x1 objects.
        /// 
        /// </summary>
        public static mat4x1 fmod(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1(v1.M00 % v2.M00, v1.M10 % v2.M10, v1.M20 % v2.M20, v1.M30 % v2.M30);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat4x2 objects.
        /// 
        /// </summary>
        public static mat4x2 fmod(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M20 % v2.M20, v1.M21 % v2.M21, v1.M30 % v2.M30, v1.M31 % v2.M31);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat4x3 objects.
        /// 
        /// </summary>
        public static mat4x3 fmod(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12, v1.M20 % v2.M20, v1.M21 % v2.M21, v1.M22 % v2.M22, v1.M30 % v2.M30, v1.M31 % v2.M31, v1.M32 % v2.M32);
        }

        /// <summary>
        /// Performs the fmod function to the specified mat4x4 objects.
        /// 
        /// </summary>
        public static mat4x4 fmod(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4(v1.M00 % v2.M00, v1.M01 % v2.M01, v1.M02 % v2.M02, v1.M03 % v2.M03, v1.M10 % v2.M10, v1.M11 % v2.M11, v1.M12 % v2.M12, v1.M13 % v2.M13, v1.M20 % v2.M20, v1.M21 % v2.M21, v1.M22 % v2.M22, v1.M23 % v2.M23, v1.M30 % v2.M30, v1.M31 % v2.M31, v1.M32 % v2.M32, v1.M33 % v2.M33);
        }

        #endregion
        #region frac

        /// <summary>
        /// Performs the frac function to the specified Vector1 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static float frac(float v)
        {
            return (v % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified Vector2 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static float2 frac(float2 v)
        {
            return new float2(v.x % 1, v.y % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified float3 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static float3 frac(float3 v)
        {
            return new float3(v.x % 1, v.y % 1, v.z % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified float4 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static float4 frac(float4 v)
        {
            return new float4(v.x % 1, v.y % 1, v.z % 1, v.w % 1);
        }


        /// <summary>
        /// Performs the frac function to the specified mat1x1 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat1x1 frac(mat1x1 v)
        {
            return new mat1x1(v.M00 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat1x2 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat1x2 frac(mat1x2 v)
        {
            return new mat1x2(v.M00 % 1, v.M01 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat1x3 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat1x3 frac(mat1x3 v)
        {
            return new mat1x3(v.M00 % 1, v.M01 % 1, v.M02 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat1x4 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat1x4 frac(mat1x4 v)
        {
            return new mat1x4(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M03 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat2x1 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat2x1 frac(mat2x1 v)
        {
            return new mat2x1(v.M00 % 1, v.M10 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat2x2 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat2x2 frac(mat2x2 v)
        {
            return new mat2x2(v.M00 % 1, v.M01 % 1, v.M10 % 1, v.M11 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat2x3 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat2x3 frac(mat2x3 v)
        {
            return new mat2x3(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat2x4 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat2x4 frac(mat2x4 v)
        {
            return new mat2x4(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M03 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1, v.M13 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat3x1 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat3x1 frac(mat3x1 v)
        {
            return new mat3x1(v.M00 % 1, v.M10 % 1, v.M20 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat3x2 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat3x2 frac(mat3x2 v)
        {
            return new mat3x2(v.M00 % 1, v.M01 % 1, v.M10 % 1, v.M11 % 1, v.M20 % 1, v.M21 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat3x3 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat3x3 frac(mat3x3 v)
        {
            return new mat3x3(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1, v.M20 % 1, v.M21 % 1, v.M22 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat3x4 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat3x4 frac(mat3x4 v)
        {
            return new mat3x4(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M03 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1, v.M13 % 1, v.M20 % 1, v.M21 % 1, v.M22 % 1, v.M23 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat4x1 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat4x1 frac(mat4x1 v)
        {
            return new mat4x1(v.M00 % 1, v.M10 % 1, v.M20 % 1, v.M30 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat4x2 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat4x2 frac(mat4x2 v)
        {
            return new mat4x2(v.M00 % 1, v.M01 % 1, v.M10 % 1, v.M11 % 1, v.M20 % 1, v.M21 % 1, v.M30 % 1, v.M31 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat4x3 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat4x3 frac(mat4x3 v)
        {
            return new mat4x3(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1, v.M20 % 1, v.M21 % 1, v.M22 % 1, v.M30 % 1, v.M31 % 1, v.M32 % 1);
        }

        /// <summary>
        /// Performs the frac function to the specified mat4x4 object.
        /// Gets the fractional part of each component.
        /// </summary>
        public static mat4x4 frac(mat4x4 v)
        {
            return new mat4x4(v.M00 % 1, v.M01 % 1, v.M02 % 1, v.M03 % 1, v.M10 % 1, v.M11 % 1, v.M12 % 1, v.M13 % 1, v.M20 % 1, v.M21 % 1, v.M22 % 1, v.M23 % 1, v.M30 % 1, v.M31 % 1, v.M32 % 1, v.M33 % 1);
        }

        #endregion
        #region ldexp

        /// <summary>
        /// Performs the ldexp function to the specified Vector1 objects.
        /// 
        /// </summary>
        public static float ldexp(float v1, float v2)
        {
            return (v1 * (float)Math.Pow(2, v2));
        }

        /// <summary>
        /// Performs the ldexp function to the specified Vector2 objects.
        /// 
        /// </summary>
        public static float ldexp(float2 v1, float2 v2)
        {
            return (v1.x * (float)Math.Pow(2, v2.x) + v1.y * (float)Math.Pow(2, v2.y));
        }

        /// <summary>
        /// Performs the ldexp function to the specified float3 objects.
        /// 
        /// </summary>
        public static float ldexp(float3 v1, float3 v2)
        {
            return (v1.x * (float)Math.Pow(2, v2.x) + v1.y * (float)Math.Pow(2, v2.y) + v1.z * (float)Math.Pow(2, v2.z));
        }

        /// <summary>
        /// Performs the ldexp function to the specified float4 objects.
        /// 
        /// </summary>
        public static float ldexp(float4 v1, float4 v2)
        {
            return (v1.x * (float)Math.Pow(2, v2.x) + v1.y * (float)Math.Pow(2, v2.y) + v1.z * (float)Math.Pow(2, v2.z) + v1.w * (float)Math.Pow(2, v2.w));
        }

        #endregion
        #region length

        /// <summary>
        /// Performs the length function to the specified Vector1 object.
        /// Gets the length of the v vector.
        /// </summary>
        public static float length(float v)
        {

            return (float)Math.Sqrt(dot(v, v));

        }


        /// <summary>
        /// Performs the length function to the specified Vector2 object.
        /// Gets the length of the v vector.
        /// </summary>
        public static float length(float2 v)
        {

            return (float)Math.Sqrt(dot(v, v));

        }


        /// <summary>
        /// Performs the length function to the specified float3 object.
        /// Gets the length of the v vector.
        /// </summary>
        public static float length(float3 v)
        {

            return (float)Math.Sqrt(dot(v, v));

        }


        /// <summary>
        /// Performs the length function to the specified float4 object.
        /// Gets the length of the v vector.
        /// </summary>
        public static float length(float4 v)
        {

            return (float)Math.Sqrt(dot(v, v));

        }

        #endregion
        #region lerp

        /// <summary>
        /// Performs the lerp function to the specified Vector1 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static float lerp(float v1, float v2, float s)
        {
            return (v1 + s * (v2 - v1));
        }

        /// <summary>
        /// Performs the lerp function to the specified Vector2 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static float2 lerp(float2 v1, float2 v2, float2 s)
        {
            return new float2(v1.x + s.x * (v2.x - v1.x), v1.y + s.y * (v2.y - v1.y));
        }

        /// <summary>
        /// Performs the lerp function to the specified float3 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static float3 lerp(float3 v1, float3 v2, float3 s)
        {
            return new float3(v1.x + s.x * (v2.x - v1.x), v1.y + s.y * (v2.y - v1.y), v1.z + s.z * (v2.z - v1.z));
        }

        /// <summary>
        /// Performs the lerp function to the specified float4 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static float4 lerp(float4 v1, float4 v2, float4 s)
        {
            return new float4(v1.x + s.x * (v2.x - v1.x), v1.y + s.y * (v2.y - v1.y), v1.z + s.z * (v2.z - v1.z), v1.w + s.w * (v2.w - v1.w));
        }


        /// <summary>
        /// Performs the lerp function to the specified mat1x1 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat1x1 lerp(mat1x1 v1, mat1x1 v2, mat1x1 s)
        {
            return new mat1x1(v1.M00 + s.M00 * (v2.M00 - v1.M00));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat1x2 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat1x2 lerp(mat1x2 v1, mat1x2 v2, mat1x2 s)
        {
            return new mat1x2(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat1x3 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat1x3 lerp(mat1x3 v1, mat1x3 v2, mat1x3 s)
        {
            return new mat1x3(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat1x4 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat1x4 lerp(mat1x4 v1, mat1x4 v2, mat1x4 s)
        {
            return new mat1x4(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M03 + s.M03 * (v2.M03 - v1.M03));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat2x1 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat2x1 lerp(mat2x1 v1, mat2x1 v2, mat2x1 s)
        {
            return new mat2x1(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M10 + s.M10 * (v2.M10 - v1.M10));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat2x2 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat2x2 lerp(mat2x2 v1, mat2x2 v2, mat2x2 s)
        {
            return new mat2x2(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat2x3 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat2x3 lerp(mat2x3 v1, mat2x3 v2, mat2x3 s)
        {
            return new mat2x3(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat2x4 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat2x4 lerp(mat2x4 v1, mat2x4 v2, mat2x4 s)
        {
            return new mat2x4(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M03 + s.M03 * (v2.M03 - v1.M03), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12), v1.M13 + s.M13 * (v2.M13 - v1.M13));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat3x1 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat3x1 lerp(mat3x1 v1, mat3x1 v2, mat3x1 s)
        {
            return new mat3x1(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M20 + s.M20 * (v2.M20 - v1.M20));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat3x2 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat3x2 lerp(mat3x2 v1, mat3x2 v2, mat3x2 s)
        {
            return new mat3x2(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat3x3 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat3x3 lerp(mat3x3 v1, mat3x3 v2, mat3x3 s)
        {
            return new mat3x3(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21), v1.M22 + s.M22 * (v2.M22 - v1.M22));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat3x4 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat3x4 lerp(mat3x4 v1, mat3x4 v2, mat3x4 s)
        {
            return new mat3x4(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M03 + s.M03 * (v2.M03 - v1.M03), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12), v1.M13 + s.M13 * (v2.M13 - v1.M13), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21), v1.M22 + s.M22 * (v2.M22 - v1.M22), v1.M23 + s.M23 * (v2.M23 - v1.M23));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat4x1 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat4x1 lerp(mat4x1 v1, mat4x1 v2, mat4x1 s)
        {
            return new mat4x1(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M30 + s.M30 * (v2.M30 - v1.M30));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat4x2 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat4x2 lerp(mat4x2 v1, mat4x2 v2, mat4x2 s)
        {
            return new mat4x2(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21), v1.M30 + s.M30 * (v2.M30 - v1.M30), v1.M31 + s.M31 * (v2.M31 - v1.M31));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat4x3 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat4x3 lerp(mat4x3 v1, mat4x3 v2, mat4x3 s)
        {
            return new mat4x3(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21), v1.M22 + s.M22 * (v2.M22 - v1.M22), v1.M30 + s.M30 * (v2.M30 - v1.M30), v1.M31 + s.M31 * (v2.M31 - v1.M31), v1.M32 + s.M32 * (v2.M32 - v1.M32));
        }

        /// <summary>
        /// Performs the lerp function to the specified mat4x4 objects.
        /// Gets the linnear interpolation between v1 and v2 using s. v1 + (v2 - v1)*s.
        /// </summary>
        public static mat4x4 lerp(mat4x4 v1, mat4x4 v2, mat4x4 s)
        {
            return new mat4x4(v1.M00 + s.M00 * (v2.M00 - v1.M00), v1.M01 + s.M01 * (v2.M01 - v1.M01), v1.M02 + s.M02 * (v2.M02 - v1.M02), v1.M03 + s.M03 * (v2.M03 - v1.M03), v1.M10 + s.M10 * (v2.M10 - v1.M10), v1.M11 + s.M11 * (v2.M11 - v1.M11), v1.M12 + s.M12 * (v2.M12 - v1.M12), v1.M13 + s.M13 * (v2.M13 - v1.M13), v1.M20 + s.M20 * (v2.M20 - v1.M20), v1.M21 + s.M21 * (v2.M21 - v1.M21), v1.M22 + s.M22 * (v2.M22 - v1.M22), v1.M23 + s.M23 * (v2.M23 - v1.M23), v1.M30 + s.M30 * (v2.M30 - v1.M30), v1.M31 + s.M31 * (v2.M31 - v1.M31), v1.M32 + s.M32 * (v2.M32 - v1.M32), v1.M33 + s.M33 * (v2.M33 - v1.M33));
        }

        #endregion
        #region lit
        public static float4 lit(float NdotL, float NdotH, float power)
        {
            {
                return new float4(1, NdotL < 0 ? 0 : NdotL, NdotL < 0 || NdotH < 0 ? 0 : (float)Math.Pow(NdotH, power), 1);
            }
        }
        #endregion
        #region log

        /// <summary>
        /// Performs the log function to the specified Vector1 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static float log(float v)
        {
            return ((float)Math.Log(v));
        }

        public static float1 log(float1 v)
        {
            return new float1((float)Math.Log(v.x));
        }

        /// <summary>
        /// Performs the log function to the specified Vector2 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static float2 log(float2 v)
        {
            return new float2((float)Math.Log(v.x), (float)Math.Log(v.y));
        }

        /// <summary>
        /// Performs the log function to the specified float3 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static float3 log(float3 v)
        {
            return new float3((float)Math.Log(v.x), (float)Math.Log(v.y), (float)Math.Log(v.z));
        }

        /// <summary>
        /// Performs the log function to the specified float4 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static float4 log(float4 v)
        {
            return new float4((float)Math.Log(v.x), (float)Math.Log(v.y), (float)Math.Log(v.z), (float)Math.Log(v.w));
        }


        /// <summary>
        /// Performs the log function to the specified mat1x1 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat1x1 log(mat1x1 v)
        {
            return new mat1x1((float)Math.Log(v.M00));
        }

        /// <summary>
        /// Performs the log function to the specified mat1x2 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat1x2 log(mat1x2 v)
        {
            return new mat1x2((float)Math.Log(v.M00), (float)Math.Log(v.M01));
        }

        /// <summary>
        /// Performs the log function to the specified mat1x3 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat1x3 log(mat1x3 v)
        {
            return new mat1x3((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02));
        }

        /// <summary>
        /// Performs the log function to the specified mat1x4 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat1x4 log(mat1x4 v)
        {
            return new mat1x4((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M03));
        }

        /// <summary>
        /// Performs the log function to the specified mat2x1 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat2x1 log(mat2x1 v)
        {
            return new mat2x1((float)Math.Log(v.M00), (float)Math.Log(v.M10));
        }

        /// <summary>
        /// Performs the log function to the specified mat2x2 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat2x2 log(mat2x2 v)
        {
            return new mat2x2((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M10), (float)Math.Log(v.M11));
        }

        /// <summary>
        /// Performs the log function to the specified mat2x3 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat2x3 log(mat2x3 v)
        {
            return new mat2x3((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12));
        }

        /// <summary>
        /// Performs the log function to the specified mat2x4 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat2x4 log(mat2x4 v)
        {
            return new mat2x4((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M03), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12), (float)Math.Log(v.M13));
        }

        /// <summary>
        /// Performs the log function to the specified mat3x1 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat3x1 log(mat3x1 v)
        {
            return new mat3x1((float)Math.Log(v.M00), (float)Math.Log(v.M10), (float)Math.Log(v.M20));
        }

        /// <summary>
        /// Performs the log function to the specified mat3x2 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat3x2 log(mat3x2 v)
        {
            return new mat3x2((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M20), (float)Math.Log(v.M21));
        }

        /// <summary>
        /// Performs the log function to the specified mat3x3 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat3x3 log(mat3x3 v)
        {
            return new mat3x3((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12), (float)Math.Log(v.M20), (float)Math.Log(v.M21), (float)Math.Log(v.M22));
        }

        /// <summary>
        /// Performs the log function to the specified mat3x4 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat3x4 log(mat3x4 v)
        {
            return new mat3x4((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M03), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12), (float)Math.Log(v.M13), (float)Math.Log(v.M20), (float)Math.Log(v.M21), (float)Math.Log(v.M22), (float)Math.Log(v.M23));
        }

        /// <summary>
        /// Performs the log function to the specified mat4x1 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat4x1 log(mat4x1 v)
        {
            return new mat4x1((float)Math.Log(v.M00), (float)Math.Log(v.M10), (float)Math.Log(v.M20), (float)Math.Log(v.M30));
        }

        /// <summary>
        /// Performs the log function to the specified mat4x2 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat4x2 log(mat4x2 v)
        {
            return new mat4x2((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M20), (float)Math.Log(v.M21), (float)Math.Log(v.M30), (float)Math.Log(v.M31));
        }

        /// <summary>
        /// Performs the log function to the specified mat4x3 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat4x3 log(mat4x3 v)
        {
            return new mat4x3((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12), (float)Math.Log(v.M20), (float)Math.Log(v.M21), (float)Math.Log(v.M22), (float)Math.Log(v.M30), (float)Math.Log(v.M31), (float)Math.Log(v.M32));
        }

        /// <summary>
        /// Performs the log function to the specified mat4x4 object.
        /// Gets the base-e logarithm for each component.
        /// </summary>
        public static mat4x4 log(mat4x4 v)
        {
            return new mat4x4((float)Math.Log(v.M00), (float)Math.Log(v.M01), (float)Math.Log(v.M02), (float)Math.Log(v.M03), (float)Math.Log(v.M10), (float)Math.Log(v.M11), (float)Math.Log(v.M12), (float)Math.Log(v.M13), (float)Math.Log(v.M20), (float)Math.Log(v.M21), (float)Math.Log(v.M22), (float)Math.Log(v.M23), (float)Math.Log(v.M30), (float)Math.Log(v.M31), (float)Math.Log(v.M32), (float)Math.Log(v.M33));
        }

        #endregion
        #region log10

        /// <summary>
        /// Performs the log10 function to the specified Vector1 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static float log10(float v)
        {
            return ((float)Math.Log10(v));
        }

        /// <summary>
        /// Performs the log10 function to the specified Vector2 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static float2 log10(float2 v)
        {
            return new float2((float)Math.Log10(v.x), (float)Math.Log10(v.y));
        }

        /// <summary>
        /// Performs the log10 function to the specified float3 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static float3 log10(float3 v)
        {
            return new float3((float)Math.Log10(v.x), (float)Math.Log10(v.y), (float)Math.Log10(v.z));
        }

        /// <summary>
        /// Performs the log10 function to the specified float4 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static float4 log10(float4 v)
        {
            return new float4((float)Math.Log10(v.x), (float)Math.Log10(v.y), (float)Math.Log10(v.z), (float)Math.Log10(v.w));
        }


        /// <summary>
        /// Performs the log10 function to the specified mat1x1 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat1x1 log10(mat1x1 v)
        {
            return new mat1x1((float)Math.Log10(v.M00));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat1x2 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat1x2 log10(mat1x2 v)
        {
            return new mat1x2((float)Math.Log10(v.M00), (float)Math.Log10(v.M01));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat1x3 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat1x3 log10(mat1x3 v)
        {
            return new mat1x3((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat1x4 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat1x4 log10(mat1x4 v)
        {
            return new mat1x4((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M03));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat2x1 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat2x1 log10(mat2x1 v)
        {
            return new mat2x1((float)Math.Log10(v.M00), (float)Math.Log10(v.M10));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat2x2 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat2x2 log10(mat2x2 v)
        {
            return new mat2x2((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat2x3 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat2x3 log10(mat2x3 v)
        {
            return new mat2x3((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat2x4 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat2x4 log10(mat2x4 v)
        {
            return new mat2x4((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M03), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12), (float)Math.Log10(v.M13));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat3x1 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat3x1 log10(mat3x1 v)
        {
            return new mat3x1((float)Math.Log10(v.M00), (float)Math.Log10(v.M10), (float)Math.Log10(v.M20));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat3x2 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat3x2 log10(mat3x2 v)
        {
            return new mat3x2((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat3x3 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat3x3 log10(mat3x3 v)
        {
            return new mat3x3((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21), (float)Math.Log10(v.M22));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat3x4 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat3x4 log10(mat3x4 v)
        {
            return new mat3x4((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M03), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12), (float)Math.Log10(v.M13), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21), (float)Math.Log10(v.M22), (float)Math.Log10(v.M23));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat4x1 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat4x1 log10(mat4x1 v)
        {
            return new mat4x1((float)Math.Log10(v.M00), (float)Math.Log10(v.M10), (float)Math.Log10(v.M20), (float)Math.Log10(v.M30));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat4x2 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat4x2 log10(mat4x2 v)
        {
            return new mat4x2((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21), (float)Math.Log10(v.M30), (float)Math.Log10(v.M31));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat4x3 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat4x3 log10(mat4x3 v)
        {
            return new mat4x3((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21), (float)Math.Log10(v.M22), (float)Math.Log10(v.M30), (float)Math.Log10(v.M31), (float)Math.Log10(v.M32));
        }

        /// <summary>
        /// Performs the log10 function to the specified mat4x4 object.
        /// Gets the base-10 logarithm for each component.
        /// </summary>
        public static mat4x4 log10(mat4x4 v)
        {
            return new mat4x4((float)Math.Log10(v.M00), (float)Math.Log10(v.M01), (float)Math.Log10(v.M02), (float)Math.Log10(v.M03), (float)Math.Log10(v.M10), (float)Math.Log10(v.M11), (float)Math.Log10(v.M12), (float)Math.Log10(v.M13), (float)Math.Log10(v.M20), (float)Math.Log10(v.M21), (float)Math.Log10(v.M22), (float)Math.Log10(v.M23), (float)Math.Log10(v.M30), (float)Math.Log10(v.M31), (float)Math.Log10(v.M32), (float)Math.Log10(v.M33));
        }

        #endregion
        #region log2

        /// <summary>
        /// Performs the log2 function to the specified Vector1 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static float log2(float v)
        {
            return ((float)Math.Log(v, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified Vector2 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static float2 log2(float2 v)
        {
            return new float2((float)Math.Log(v.x, 2), (float)Math.Log(v.y, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified float3 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static float3 log2(float3 v)
        {
            return new float3((float)Math.Log(v.x, 2), (float)Math.Log(v.y, 2), (float)Math.Log(v.z, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified float4 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static float4 log2(float4 v)
        {
            return new float4((float)Math.Log(v.x, 2), (float)Math.Log(v.y, 2), (float)Math.Log(v.z, 2), (float)Math.Log(v.w, 2));
        }


        /// <summary>
        /// Performs the log2 function to the specified mat1x1 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat1x1 log2(mat1x1 v)
        {
            return new mat1x1((float)Math.Log(v.M00, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat1x2 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat1x2 log2(mat1x2 v)
        {
            return new mat1x2((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat1x3 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat1x3 log2(mat1x3 v)
        {
            return new mat1x3((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat1x4 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat1x4 log2(mat1x4 v)
        {
            return new mat1x4((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M03, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat2x1 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat2x1 log2(mat2x1 v)
        {
            return new mat2x1((float)Math.Log(v.M00, 2), (float)Math.Log(v.M10, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat2x2 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat2x2 log2(mat2x2 v)
        {
            return new mat2x2((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat2x3 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat2x3 log2(mat2x3 v)
        {
            return new mat2x3((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat2x4 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat2x4 log2(mat2x4 v)
        {
            return new mat2x4((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M03, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2), (float)Math.Log(v.M13, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat3x1 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat3x1 log2(mat3x1 v)
        {
            return new mat3x1((float)Math.Log(v.M00, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M20, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat3x2 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat3x2 log2(mat3x2 v)
        {
            return new mat3x2((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat3x3 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat3x3 log2(mat3x3 v)
        {
            return new mat3x3((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2), (float)Math.Log(v.M22, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat3x4 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat3x4 log2(mat3x4 v)
        {
            return new mat3x4((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M03, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2), (float)Math.Log(v.M13, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2), (float)Math.Log(v.M22, 2), (float)Math.Log(v.M23, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat4x1 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat4x1 log2(mat4x1 v)
        {
            return new mat4x1((float)Math.Log(v.M00, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M30, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat4x2 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat4x2 log2(mat4x2 v)
        {
            return new mat4x2((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2), (float)Math.Log(v.M30, 2), (float)Math.Log(v.M31, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat4x3 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat4x3 log2(mat4x3 v)
        {
            return new mat4x3((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2), (float)Math.Log(v.M22, 2), (float)Math.Log(v.M30, 2), (float)Math.Log(v.M31, 2), (float)Math.Log(v.M32, 2));
        }

        /// <summary>
        /// Performs the log2 function to the specified mat4x4 object.
        /// Gets the base-2 logarithm for each component.
        /// </summary>
        public static mat4x4 log2(mat4x4 v)
        {
            return new mat4x4((float)Math.Log(v.M00, 2), (float)Math.Log(v.M01, 2), (float)Math.Log(v.M02, 2), (float)Math.Log(v.M03, 2), (float)Math.Log(v.M10, 2), (float)Math.Log(v.M11, 2), (float)Math.Log(v.M12, 2), (float)Math.Log(v.M13, 2), (float)Math.Log(v.M20, 2), (float)Math.Log(v.M21, 2), (float)Math.Log(v.M22, 2), (float)Math.Log(v.M23, 2), (float)Math.Log(v.M30, 2), (float)Math.Log(v.M31, 2), (float)Math.Log(v.M32, 2), (float)Math.Log(v.M33, 2));
        }

        #endregion
        #region max

        /// <summary>
        /// Performs the max function to the specified Vector1 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static float max(float v1, float v2)
        {
            return ((float)Math.Max(v1, v2));
        }

        public static float1 max(float1 v1, float1 v2)
        {
            return new float1((float)Math.Max(v1.x, v2.x));
        }

        /// <summary>
        /// Performs the max function to the specified Vector2 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static float2 max(float2 v1, float2 v2)
        {
            return new float2((float)Math.Max(v1.x, v2.x), (float)Math.Max(v1.y, v2.y));
        }

        /// <summary>
        /// Performs the max function to the specified float3 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static float3 max(float3 v1, float3 v2)
        {
            return new float3((float)Math.Max(v1.x, v2.x), (float)Math.Max(v1.y, v2.y), (float)Math.Max(v1.z, v2.z));
        }

        /// <summary>
        /// Performs the max function to the specified float4 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static float4 max(float4 v1, float4 v2)
        {
            return new float4((float)Math.Max(v1.x, v2.x), (float)Math.Max(v1.y, v2.y), (float)Math.Max(v1.z, v2.z), (float)Math.Max(v1.w, v2.w));
        }


        /// <summary>
        /// Performs the max function to the specified mat1x1 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat1x1 max(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1((float)Math.Max(v1.M00, v2.M00));
        }

        /// <summary>
        /// Performs the max function to the specified mat1x2 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat1x2 max(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01));
        }

        /// <summary>
        /// Performs the max function to the specified mat1x3 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat1x3 max(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02));
        }

        /// <summary>
        /// Performs the max function to the specified mat1x4 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat1x4 max(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M03, v2.M03));
        }

        /// <summary>
        /// Performs the max function to the specified mat2x1 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat2x1 max(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M10, v2.M10));
        }

        /// <summary>
        /// Performs the max function to the specified mat2x2 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat2x2 max(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11));
        }

        /// <summary>
        /// Performs the max function to the specified mat2x3 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat2x3 max(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12));
        }

        /// <summary>
        /// Performs the max function to the specified mat2x4 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat2x4 max(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M03, v2.M03), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12), (float)Math.Max(v1.M13, v2.M13));
        }

        /// <summary>
        /// Performs the max function to the specified mat3x1 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat3x1 max(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M20, v2.M20));
        }

        /// <summary>
        /// Performs the max function to the specified mat3x2 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat3x2 max(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21));
        }

        /// <summary>
        /// Performs the max function to the specified mat3x3 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat3x3 max(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21), (float)Math.Max(v1.M22, v2.M22));
        }

        /// <summary>
        /// Performs the max function to the specified mat3x4 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat3x4 max(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M03, v2.M03), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12), (float)Math.Max(v1.M13, v2.M13), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21), (float)Math.Max(v1.M22, v2.M22), (float)Math.Max(v1.M23, v2.M23));
        }

        /// <summary>
        /// Performs the max function to the specified mat4x1 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat4x1 max(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M30, v2.M30));
        }

        /// <summary>
        /// Performs the max function to the specified mat4x2 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat4x2 max(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21), (float)Math.Max(v1.M30, v2.M30), (float)Math.Max(v1.M31, v2.M31));
        }

        /// <summary>
        /// Performs the max function to the specified mat4x3 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat4x3 max(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21), (float)Math.Max(v1.M22, v2.M22), (float)Math.Max(v1.M30, v2.M30), (float)Math.Max(v1.M31, v2.M31), (float)Math.Max(v1.M32, v2.M32));
        }

        /// <summary>
        /// Performs the max function to the specified mat4x4 objects.
        /// Gets the greater value between v1 and v2 components.
        /// </summary>
        public static mat4x4 max(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4((float)Math.Max(v1.M00, v2.M00), (float)Math.Max(v1.M01, v2.M01), (float)Math.Max(v1.M02, v2.M02), (float)Math.Max(v1.M03, v2.M03), (float)Math.Max(v1.M10, v2.M10), (float)Math.Max(v1.M11, v2.M11), (float)Math.Max(v1.M12, v2.M12), (float)Math.Max(v1.M13, v2.M13), (float)Math.Max(v1.M20, v2.M20), (float)Math.Max(v1.M21, v2.M21), (float)Math.Max(v1.M22, v2.M22), (float)Math.Max(v1.M23, v2.M23), (float)Math.Max(v1.M30, v2.M30), (float)Math.Max(v1.M31, v2.M31), (float)Math.Max(v1.M32, v2.M32), (float)Math.Max(v1.M33, v2.M33));
        }

        #endregion
        #region min

        /// <summary>
        /// Performs the min function to the specified Vector1 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static float min(float v1, float v2)
        {
            return ((float)Math.Min(v1, v2));
        }

        /// <summary>
        /// Performs the min function to the specified Vector2 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static float2 min(float2 v1, float2 v2)
        {
            return new float2((float)Math.Min(v1.x, v2.x), (float)Math.Min(v1.y, v2.y));
        }

        /// <summary>
        /// Performs the min function to the specified float3 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static float3 min(float3 v1, float3 v2)
        {
            return new float3((float)Math.Min(v1.x, v2.x), (float)Math.Min(v1.y, v2.y), (float)Math.Min(v1.z, v2.z));
        }

        /// <summary>
        /// Performs the min function to the specified float4 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static float4 min(float4 v1, float4 v2)
        {
            return new float4((float)Math.Min(v1.x, v2.x), (float)Math.Min(v1.y, v2.y), (float)Math.Min(v1.z, v2.z), (float)Math.Min(v1.w, v2.w));
        }


        /// <summary>
        /// Performs the min function to the specified mat1x1 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat1x1 min(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1((float)Math.Min(v1.M00, v2.M00));
        }

        /// <summary>
        /// Performs the min function to the specified mat1x2 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat1x2 min(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01));
        }

        /// <summary>
        /// Performs the min function to the specified mat1x3 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat1x3 min(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02));
        }

        /// <summary>
        /// Performs the min function to the specified mat1x4 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat1x4 min(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M03, v2.M03));
        }

        /// <summary>
        /// Performs the min function to the specified mat2x1 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat2x1 min(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M10, v2.M10));
        }

        /// <summary>
        /// Performs the min function to the specified mat2x2 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat2x2 min(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11));
        }

        /// <summary>
        /// Performs the min function to the specified mat2x3 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat2x3 min(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12));
        }

        /// <summary>
        /// Performs the min function to the specified mat2x4 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat2x4 min(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M03, v2.M03), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12), (float)Math.Min(v1.M13, v2.M13));
        }

        /// <summary>
        /// Performs the min function to the specified mat3x1 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat3x1 min(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M20, v2.M20));
        }

        /// <summary>
        /// Performs the min function to the specified mat3x2 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat3x2 min(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21));
        }

        /// <summary>
        /// Performs the min function to the specified mat3x3 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat3x3 min(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21), (float)Math.Min(v1.M22, v2.M22));
        }

        /// <summary>
        /// Performs the min function to the specified mat3x4 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat3x4 min(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M03, v2.M03), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12), (float)Math.Min(v1.M13, v2.M13), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21), (float)Math.Min(v1.M22, v2.M22), (float)Math.Min(v1.M23, v2.M23));
        }

        /// <summary>
        /// Performs the min function to the specified mat4x1 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat4x1 min(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M30, v2.M30));
        }

        /// <summary>
        /// Performs the min function to the specified mat4x2 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat4x2 min(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21), (float)Math.Min(v1.M30, v2.M30), (float)Math.Min(v1.M31, v2.M31));
        }

        /// <summary>
        /// Performs the min function to the specified mat4x3 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat4x3 min(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21), (float)Math.Min(v1.M22, v2.M22), (float)Math.Min(v1.M30, v2.M30), (float)Math.Min(v1.M31, v2.M31), (float)Math.Min(v1.M32, v2.M32));
        }

        /// <summary>
        /// Performs the min function to the specified mat4x4 objects.
        /// Gets the smaller value between v1 and v2 components.
        /// </summary>
        public static mat4x4 min(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4((float)Math.Min(v1.M00, v2.M00), (float)Math.Min(v1.M01, v2.M01), (float)Math.Min(v1.M02, v2.M02), (float)Math.Min(v1.M03, v2.M03), (float)Math.Min(v1.M10, v2.M10), (float)Math.Min(v1.M11, v2.M11), (float)Math.Min(v1.M12, v2.M12), (float)Math.Min(v1.M13, v2.M13), (float)Math.Min(v1.M20, v2.M20), (float)Math.Min(v1.M21, v2.M21), (float)Math.Min(v1.M22, v2.M22), (float)Math.Min(v1.M23, v2.M23), (float)Math.Min(v1.M30, v2.M30), (float)Math.Min(v1.M31, v2.M31), (float)Math.Min(v1.M32, v2.M32), (float)Math.Min(v1.M33, v2.M33));
        }

        #endregion
        #region mul
        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x1 mul(mat1x1 m1, mat1x1 m2)
        {
            return new mat1x1(m1.M00 * (m2.M00));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x2 mul(mat1x1 m1, mat1x2 m2)
        {
            return new mat1x2(m1.M00 * (m2.M00), m1.M00 * (m2.M01));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x3 mul(mat1x1 m1, mat1x3 m2)
        {
            return new mat1x3(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x4 mul(mat1x1 m1, mat1x4 m2)
        {
            return new mat1x4(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M00 * (m2.M03));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x1 mul(mat1x2 m1, mat2x1 m2)
        {
            return new mat1x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x2 mul(mat1x2 m1, mat2x2 m2)
        {
            return new mat1x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)));
        }

        public static float2 mul(float2 v, mat2x2 m2)
        {
            return new mat1x2(v.x * (m2.M00) + (v.y * (m2.M10)), v.x * (m2.M01) + (v.y * (m2.M11)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x3 mul(mat1x2 m1, mat2x3 m2)
        {
            return new mat1x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x4 mul(mat1x2 m1, mat2x4 m2)
        {
            return new mat1x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x1 mul(mat1x3 m1, mat3x1 m2)
        {
            return new mat1x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)));
        }

        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float mul(float3 v, mat3x1 m)
        {
            return (v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x2 mul(mat1x3 m1, mat3x2 m2)
        {
            return new mat1x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)));
        }
        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float2 mul(float3 v, mat3x2 m)
        {
            return new float2(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x3 mul(mat1x3 m1, mat3x3 m2)
        {
            return new mat1x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)));
        }

        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float3 mul(float3 v, mat3x3 m)
        {
            return new float3(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)), v.x * (m.M02) + (v.y * (m.M12)) + (v.z * (m.M22)));
        }


        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x4 mul(mat1x3 m1, mat3x4 m2)
        {
            return new mat1x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)));
        }

        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float4 mul(float3 v, mat3x4 m)
        {
            return new float4(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)), v.x * (m.M02) + (v.y * (m.M12)) + (v.z * (m.M22)), v.x * (m.M03) + (v.y * (m.M13)) + (v.z * (m.M23)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x1 mul(mat1x4 m1, mat4x1 m2)
        {
            return new mat1x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)));
        }
        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float mul(float4 v, mat4x1 m)
        {
            return (v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)) + (v.w * (m.M30)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x2 mul(mat1x4 m1, mat4x2 m2)
        {
            return new mat1x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)));
        }

        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float2 mul(float4 v, mat4x2 m)
        {
            return new float2(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)) + (v.w * (m.M30)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)) + (v.w * (m.M31)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x3 mul(mat1x4 m1, mat4x3 m2)
        {
            return new mat1x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)));
        }

        /// <summary>
        /// Performs mat multiplication between v and m.
        /// </summary>
        public static float3 mul(float4 v, mat4x3 m)
        {
            return new float3(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)) + (v.w * (m.M30)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)) + (v.w * (m.M31)), v.x * (m.M02) + (v.y * (m.M12)) + (v.z * (m.M22)) + (v.w * (m.M32)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat1x4 mul(mat1x4 m1, mat4x4 m2)
        {
            return new mat1x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)) + (m1.M03 * (m2.M33)));
        }

        /// <summary>
        /// Performs mat multiplication between a vector and a mat.
        /// </summary>
        public static float4 mul(float4 v, mat4x4 m)
        {
            return new float4(v.x * (m.M00) + (v.y * (m.M10)) + (v.z * (m.M20)) + (v.w * (m.M30)), v.x * (m.M01) + (v.y * (m.M11)) + (v.z * (m.M21)) + (v.w * (m.M31)), v.x * (m.M02) + (v.y * (m.M12)) + (v.z * (m.M22)) + (v.w * (m.M32)), v.x * (m.M03) + (v.y * (m.M13)) + (v.z * (m.M23)) + (v.w * (m.M33)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x1 mul(mat2x1 m1, mat1x1 m2)
        {
            return new mat2x1(m1.M00 * (m2.M00), m1.M10 * (m2.M00));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x2 mul(mat2x1 m1, mat1x2 m2)
        {
            return new mat2x2(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M10 * (m2.M00), m1.M10 * (m2.M01));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x3 mul(mat2x1 m1, mat1x3 m2)
        {
            return new mat2x3(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x4 mul(mat2x1 m1, mat1x4 m2)
        {
            return new mat2x4(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M00 * (m2.M03), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02), m1.M10 * (m2.M03));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x1 mul(mat2x2 m1, mat2x1 m2)
        {
            return new mat2x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x2 mul(mat2x2 m1, mat2x2 m2)
        {
            return new mat2x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x3 mul(mat2x2 m1, mat2x3 m2)
        {
            return new mat2x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x4 mul(mat2x2 m1, mat2x4 m2)
        {
            return new mat2x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x1 mul(mat2x3 m1, mat3x1 m2)
        {
            return new mat2x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x2 mul(mat2x3 m1, mat3x2 m2)
        {
            return new mat2x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x3 mul(mat2x3 m1, mat3x3 m2)
        {
            return new mat2x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x4 mul(mat2x3 m1, mat3x4 m2)
        {
            return new mat2x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x1 mul(mat2x4 m1, mat4x1 m2)
        {
            return new mat2x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x2 mul(mat2x4 m1, mat4x2 m2)
        {
            return new mat2x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x3 mul(mat2x4 m1, mat4x3 m2)
        {
            return new mat2x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat2x4 mul(mat2x4 m1, mat4x4 m2)
        {
            return new mat2x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)) + (m1.M03 * (m2.M33)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)) + (m1.M13 * (m2.M33)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x1 mul(mat3x1 m1, mat1x1 m2)
        {
            return new mat3x1(m1.M00 * (m2.M00), m1.M10 * (m2.M00), m1.M20 * (m2.M00));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x2 mul(mat3x1 m1, mat1x2 m2)
        {
            return new mat3x2(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M20 * (m2.M00), m1.M20 * (m2.M01));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x3 mul(mat3x1 m1, mat1x3 m2)
        {
            return new mat3x3(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02), m1.M20 * (m2.M00), m1.M20 * (m2.M01), m1.M20 * (m2.M02));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x4 mul(mat3x1 m1, mat1x4 m2)
        {
            return new mat3x4(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M00 * (m2.M03), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02), m1.M10 * (m2.M03), m1.M20 * (m2.M00), m1.M20 * (m2.M01), m1.M20 * (m2.M02), m1.M20 * (m2.M03));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x1 mul(mat3x2 m1, mat2x1 m2)
        {
            return new mat3x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x2 mul(mat3x2 m1, mat2x2 m2)
        {
            return new mat3x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x3 mul(mat3x2 m1, mat2x3 m2)
        {
            return new mat3x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x4 mul(mat3x2 m1, mat2x4 m2)
        {
            return new mat3x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x1 mul(mat3x3 m1, mat3x1 m2)
        {
            return new mat3x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x2 mul(mat3x3 m1, mat3x2 m2)
        {
            return new mat3x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x3 mul(mat3x3 m1, mat3x3 m2)
        {
            return new mat3x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x4 mul(mat3x3 m1, mat3x4 m2)
        {
            return new mat3x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)) + (m1.M22 * (m2.M23)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x1 mul(mat3x4 m1, mat4x1 m2)
        {
            return new mat3x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x2 mul(mat3x4 m1, mat4x2 m2)
        {
            return new mat3x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x3 mul(mat3x4 m1, mat4x3 m2)
        {
            return new mat3x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)) + (m1.M23 * (m2.M32)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat3x4 mul(mat3x4 m1, mat4x4 m2)
        {
            return new mat3x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)) + (m1.M03 * (m2.M33)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)) + (m1.M13 * (m2.M33)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)) + (m1.M23 * (m2.M32)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)) + (m1.M22 * (m2.M23)) + (m1.M23 * (m2.M33)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x1 mul(mat4x1 m1, mat1x1 m2)
        {
            return new mat4x1(m1.M00 * (m2.M00), m1.M10 * (m2.M00), m1.M20 * (m2.M00), m1.M30 * (m2.M00));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x2 mul(mat4x1 m1, mat1x2 m2)
        {
            return new mat4x2(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M20 * (m2.M00), m1.M20 * (m2.M01), m1.M30 * (m2.M00), m1.M30 * (m2.M01));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x3 mul(mat4x1 m1, mat1x3 m2)
        {
            return new mat4x3(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02), m1.M20 * (m2.M00), m1.M20 * (m2.M01), m1.M20 * (m2.M02), m1.M30 * (m2.M00), m1.M30 * (m2.M01), m1.M30 * (m2.M02));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x4 mul(mat4x1 m1, mat1x4 m2)
        {
            return new mat4x4(m1.M00 * (m2.M00), m1.M00 * (m2.M01), m1.M00 * (m2.M02), m1.M00 * (m2.M03), m1.M10 * (m2.M00), m1.M10 * (m2.M01), m1.M10 * (m2.M02), m1.M10 * (m2.M03), m1.M20 * (m2.M00), m1.M20 * (m2.M01), m1.M20 * (m2.M02), m1.M20 * (m2.M03), m1.M30 * (m2.M00), m1.M30 * (m2.M01), m1.M30 * (m2.M02), m1.M30 * (m2.M03));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x1 mul(mat4x2 m1, mat2x1 m2)
        {
            return new mat4x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x2 mul(mat4x2 m1, mat2x2 m2)
        {
            return new mat4x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x3 mul(mat4x2 m1, mat2x3 m2)
        {
            return new mat4x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x4 mul(mat4x2 m1, mat2x4 m2)
        {
            return new mat4x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)), m1.M30 * (m2.M03) + (m1.M31 * (m2.M13)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x1 mul(mat4x3 m1, mat3x1 m2)
        {
            return new mat4x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x2 mul(mat4x3 m1, mat3x2 m2)
        {
            return new mat4x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x3 mul(mat4x3 m1, mat3x3 m2)
        {
            return new mat4x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)) + (m1.M32 * (m2.M22)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x4 mul(mat4x3 m1, mat3x4 m2)
        {
            return new mat4x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)) + (m1.M22 * (m2.M23)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)) + (m1.M32 * (m2.M22)), m1.M30 * (m2.M03) + (m1.M31 * (m2.M13)) + (m1.M32 * (m2.M23)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x1 mul(mat4x4 m1, mat4x1 m2)
        {
            return new mat4x1(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)) + (m1.M33 * (m2.M30)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x2 mul(mat4x4 m1, mat4x2 m2)
        {
            return new mat4x2(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)) + (m1.M33 * (m2.M30)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)) + (m1.M33 * (m2.M31)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x3 mul(mat4x4 m1, mat4x3 m2)
        {
            return new mat4x3(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)) + (m1.M23 * (m2.M32)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)) + (m1.M33 * (m2.M30)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)) + (m1.M33 * (m2.M31)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)) + (m1.M32 * (m2.M22)) + (m1.M33 * (m2.M32)));
        }

        /// <summary>
        /// Performs mat multiplication between m1 and m2.
        /// </summary>
        public static mat4x4 mul(mat4x4 m1, mat4x4 m2)
        {
            return new mat4x4(m1.M00 * (m2.M00) + (m1.M01 * (m2.M10)) + (m1.M02 * (m2.M20)) + (m1.M03 * (m2.M30)), m1.M00 * (m2.M01) + (m1.M01 * (m2.M11)) + (m1.M02 * (m2.M21)) + (m1.M03 * (m2.M31)), m1.M00 * (m2.M02) + (m1.M01 * (m2.M12)) + (m1.M02 * (m2.M22)) + (m1.M03 * (m2.M32)), m1.M00 * (m2.M03) + (m1.M01 * (m2.M13)) + (m1.M02 * (m2.M23)) + (m1.M03 * (m2.M33)), m1.M10 * (m2.M00) + (m1.M11 * (m2.M10)) + (m1.M12 * (m2.M20)) + (m1.M13 * (m2.M30)), m1.M10 * (m2.M01) + (m1.M11 * (m2.M11)) + (m1.M12 * (m2.M21)) + (m1.M13 * (m2.M31)), m1.M10 * (m2.M02) + (m1.M11 * (m2.M12)) + (m1.M12 * (m2.M22)) + (m1.M13 * (m2.M32)), m1.M10 * (m2.M03) + (m1.M11 * (m2.M13)) + (m1.M12 * (m2.M23)) + (m1.M13 * (m2.M33)), m1.M20 * (m2.M00) + (m1.M21 * (m2.M10)) + (m1.M22 * (m2.M20)) + (m1.M23 * (m2.M30)), m1.M20 * (m2.M01) + (m1.M21 * (m2.M11)) + (m1.M22 * (m2.M21)) + (m1.M23 * (m2.M31)), m1.M20 * (m2.M02) + (m1.M21 * (m2.M12)) + (m1.M22 * (m2.M22)) + (m1.M23 * (m2.M32)), m1.M20 * (m2.M03) + (m1.M21 * (m2.M13)) + (m1.M22 * (m2.M23)) + (m1.M23 * (m2.M33)), m1.M30 * (m2.M00) + (m1.M31 * (m2.M10)) + (m1.M32 * (m2.M20)) + (m1.M33 * (m2.M30)), m1.M30 * (m2.M01) + (m1.M31 * (m2.M11)) + (m1.M32 * (m2.M21)) + (m1.M33 * (m2.M31)), m1.M30 * (m2.M02) + (m1.M31 * (m2.M12)) + (m1.M32 * (m2.M22)) + (m1.M33 * (m2.M32)), m1.M30 * (m2.M03) + (m1.M31 * (m2.M13)) + (m1.M32 * (m2.M23)) + (m1.M33 * (m2.M33)));
        }

        #endregion
        #region normalize

        /// <summary>
        /// Performs the normalize function to the specified Vector1 object.
        /// Gets the normalized vector.
        /// </summary>
        public static float normalize(float v)
        {

            return v / (float)Math.Sqrt(dot(v, v));

        }


        /// <summary>
        /// Performs the normalize function to the specified Vector2 object.
        /// Gets the normalized vector.
        /// </summary>
        public static float2 normalize(float2 v)
        {

            return v / (float)Math.Sqrt(dot(v, v));

        }


        /// <summary>
        /// Performs the normalize function to the specified float3 object.
        /// Gets the normalized vector.
        /// </summary>
        public static float3 normalize(float3 v)
        {
            float dot = Gfx.dot(v, v);
            if (dot == 0) return new float3();

            return v / (float)Math.Sqrt(dot);
        }


        /// <summary>
        /// Performs the normalize function to the specified float4 object.
        /// Gets the normalized vector.
        /// </summary>
        public static float4 normalize(float4 v)
        {

            return v / (float)Math.Sqrt(dot(v, v));

        }

        #endregion
        #region pow

        /// <summary>
        /// Performs the pow function to the specified Vector1 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static float pow(float v1, float v2)
        {
            return ((float)Math.Pow(v1, v2));
        }

        /// <summary>
        /// Performs the pow function to the specified Vector2 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static float2 pow(float2 v1, float2 v2)
        {
            return new float2((float)Math.Pow(v1.x, v2.x), (float)Math.Pow(v1.y, v2.y));
        }

        /// <summary>
        /// Performs the pow function to the specified float3 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static float3 pow(float3 v1, float3 v2)
        {
            return new float3((float)Math.Pow(v1.x, v2.x), (float)Math.Pow(v1.y, v2.y), (float)Math.Pow(v1.z, v2.z));
        }

        /// <summary>
        /// Performs the pow function to the specified float4 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static float4 pow(float4 v1, float4 v2)
        {
            return new float4((float)Math.Pow(v1.x, v2.x), (float)Math.Pow(v1.y, v2.y), (float)Math.Pow(v1.z, v2.z), (float)Math.Pow(v1.w, v2.w));
        }


        /// <summary>
        /// Performs the pow function to the specified mat1x1 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat1x1 pow(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1((float)Math.Pow(v1.M00, v2.M00));
        }

        /// <summary>
        /// Performs the pow function to the specified mat1x2 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat1x2 pow(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01));
        }

        /// <summary>
        /// Performs the pow function to the specified mat1x3 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat1x3 pow(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02));
        }

        /// <summary>
        /// Performs the pow function to the specified mat1x4 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat1x4 pow(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M03, v2.M03));
        }

        /// <summary>
        /// Performs the pow function to the specified mat2x1 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat2x1 pow(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M10, v2.M10));
        }

        /// <summary>
        /// Performs the pow function to the specified mat2x2 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat2x2 pow(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11));
        }

        /// <summary>
        /// Performs the pow function to the specified mat2x3 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat2x3 pow(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12));
        }

        /// <summary>
        /// Performs the pow function to the specified mat2x4 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat2x4 pow(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M03, v2.M03), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12), (float)Math.Pow(v1.M13, v2.M13));
        }

        /// <summary>
        /// Performs the pow function to the specified mat3x1 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat3x1 pow(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M20, v2.M20));
        }

        /// <summary>
        /// Performs the pow function to the specified mat3x2 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat3x2 pow(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21));
        }

        /// <summary>
        /// Performs the pow function to the specified mat3x3 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat3x3 pow(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21), (float)Math.Pow(v1.M22, v2.M22));
        }

        /// <summary>
        /// Performs the pow function to the specified mat3x4 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat3x4 pow(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M03, v2.M03), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12), (float)Math.Pow(v1.M13, v2.M13), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21), (float)Math.Pow(v1.M22, v2.M22), (float)Math.Pow(v1.M23, v2.M23));
        }

        /// <summary>
        /// Performs the pow function to the specified mat4x1 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat4x1 pow(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M30, v2.M30));
        }

        /// <summary>
        /// Performs the pow function to the specified mat4x2 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat4x2 pow(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21), (float)Math.Pow(v1.M30, v2.M30), (float)Math.Pow(v1.M31, v2.M31));
        }

        /// <summary>
        /// Performs the pow function to the specified mat4x3 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat4x3 pow(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21), (float)Math.Pow(v1.M22, v2.M22), (float)Math.Pow(v1.M30, v2.M30), (float)Math.Pow(v1.M31, v2.M31), (float)Math.Pow(v1.M32, v2.M32));
        }

        /// <summary>
        /// Performs the pow function to the specified mat4x4 objects.
        /// Gets the power of v1 to v2 components.
        /// </summary>
        public static mat4x4 pow(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4((float)Math.Pow(v1.M00, v2.M00), (float)Math.Pow(v1.M01, v2.M01), (float)Math.Pow(v1.M02, v2.M02), (float)Math.Pow(v1.M03, v2.M03), (float)Math.Pow(v1.M10, v2.M10), (float)Math.Pow(v1.M11, v2.M11), (float)Math.Pow(v1.M12, v2.M12), (float)Math.Pow(v1.M13, v2.M13), (float)Math.Pow(v1.M20, v2.M20), (float)Math.Pow(v1.M21, v2.M21), (float)Math.Pow(v1.M22, v2.M22), (float)Math.Pow(v1.M23, v2.M23), (float)Math.Pow(v1.M30, v2.M30), (float)Math.Pow(v1.M31, v2.M31), (float)Math.Pow(v1.M32, v2.M32), (float)Math.Pow(v1.M33, v2.M33));
        }

        #endregion
        #region radians

        /// <summary>
        /// Performs the radians function to the specified Vector1 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static float radians(float v)
        {
            return ((float)(v * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified Vector2 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static float2 radians(float2 v)
        {
            return new float2((float)(v.x * Math.PI / 180), (float)(v.y * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified float3 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static float3 radians(float3 v)
        {
            return new float3((float)(v.x * Math.PI / 180), (float)(v.y * Math.PI / 180), (float)(v.z * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified float4 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static float4 radians(float4 v)
        {
            return new float4((float)(v.x * Math.PI / 180), (float)(v.y * Math.PI / 180), (float)(v.z * Math.PI / 180), (float)(v.w * Math.PI / 180));
        }


        /// <summary>
        /// Performs the radians function to the specified mat1x1 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat1x1 radians(mat1x1 v)
        {
            return new mat1x1((float)(v.M00 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat1x2 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat1x2 radians(mat1x2 v)
        {
            return new mat1x2((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat1x3 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat1x3 radians(mat1x3 v)
        {
            return new mat1x3((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat1x4 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat1x4 radians(mat1x4 v)
        {
            return new mat1x4((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M03 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat2x1 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat2x1 radians(mat2x1 v)
        {
            return new mat2x1((float)(v.M00 * Math.PI / 180), (float)(v.M10 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat2x2 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat2x2 radians(mat2x2 v)
        {
            return new mat2x2((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat2x3 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat2x3 radians(mat2x3 v)
        {
            return new mat2x3((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat2x4 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat2x4 radians(mat2x4 v)
        {
            return new mat2x4((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M03 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180), (float)(v.M13 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat3x1 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat3x1 radians(mat3x1 v)
        {
            return new mat3x1((float)(v.M00 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M20 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat3x2 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat3x2 radians(mat3x2 v)
        {
            return new mat3x2((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat3x3 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat3x3 radians(mat3x3 v)
        {
            return new mat3x3((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180), (float)(v.M22 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat3x4 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat3x4 radians(mat3x4 v)
        {
            return new mat3x4((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M03 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180), (float)(v.M13 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180), (float)(v.M22 * Math.PI / 180), (float)(v.M23 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat4x1 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat4x1 radians(mat4x1 v)
        {
            return new mat4x1((float)(v.M00 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M30 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat4x2 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat4x2 radians(mat4x2 v)
        {
            return new mat4x2((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180), (float)(v.M30 * Math.PI / 180), (float)(v.M31 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat4x3 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat4x3 radians(mat4x3 v)
        {
            return new mat4x3((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180), (float)(v.M22 * Math.PI / 180), (float)(v.M30 * Math.PI / 180), (float)(v.M31 * Math.PI / 180), (float)(v.M32 * Math.PI / 180));
        }

        /// <summary>
        /// Performs the radians function to the specified mat4x4 object.
        /// Gets the values of each component converted from degrees to radians.
        /// </summary>
        public static mat4x4 radians(mat4x4 v)
        {
            return new mat4x4((float)(v.M00 * Math.PI / 180), (float)(v.M01 * Math.PI / 180), (float)(v.M02 * Math.PI / 180), (float)(v.M03 * Math.PI / 180), (float)(v.M10 * Math.PI / 180), (float)(v.M11 * Math.PI / 180), (float)(v.M12 * Math.PI / 180), (float)(v.M13 * Math.PI / 180), (float)(v.M20 * Math.PI / 180), (float)(v.M21 * Math.PI / 180), (float)(v.M22 * Math.PI / 180), (float)(v.M23 * Math.PI / 180), (float)(v.M30 * Math.PI / 180), (float)(v.M31 * Math.PI / 180), (float)(v.M32 * Math.PI / 180), (float)(v.M33 * Math.PI / 180));
        }

        #endregion
        #region reflect

        /// <summary>
        /// Performs the reflect function to the specified float3 objects.
        /// Gets the reflection vector. L is direction to Light, N is the surface normal
        /// </summary>
        public static float3 reflect(float3 L, float3 N)
        {

            return 2 * dot(L, N) * N - L;

        }

        #endregion
        #region refract

        /// <summary>
        /// Performs the refract function to the specified float3 objects.
        /// Gets the refraction vector.
        /// L is direction to Light, N is the normal, eta is the refraction index factor.
        /// </summary>
        public static float3 refract(float3 L, float3 N, float eta)
        {
            float3 I = -1 * L;

            float cosAngle = Gfx.dot(I, N);
            float delta = 1.0f - eta * eta * (1.0f - cosAngle * cosAngle);

            if (delta < 0)
                return new float3(0, 0, 0);

            return Gfx.normalize(eta * I - N * (eta * cosAngle + (float)Math.Sqrt(delta)));
        }

        #endregion
        #region round

        /// <summary>
        /// Performs the round function to the specified Vector1 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static float round(float v)
        {
            return ((float)Math.Round(v));
        }

        /// <summary>
        /// Performs the round function to the specified Vector2 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static float2 round(float2 v)
        {
            return new float2((float)Math.Round(v.x), (float)Math.Round(v.y));
        }

        /// <summary>
        /// Performs the round function to the specified float3 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static float3 round(float3 v)
        {
            return new float3((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z));
        }

        /// <summary>
        /// Performs the round function to the specified float4 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static float4 round(float4 v)
        {
            return new float4((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z), (float)Math.Round(v.w));
        }


        /// <summary>
        /// Performs the round function to the specified mat1x1 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat1x1 round(mat1x1 v)
        {
            return new mat1x1((float)Math.Round(v.M00));
        }

        /// <summary>
        /// Performs the round function to the specified mat1x2 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat1x2 round(mat1x2 v)
        {
            return new mat1x2((float)Math.Round(v.M00), (float)Math.Round(v.M01));
        }

        /// <summary>
        /// Performs the round function to the specified mat1x3 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat1x3 round(mat1x3 v)
        {
            return new mat1x3((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02));
        }

        /// <summary>
        /// Performs the round function to the specified mat1x4 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat1x4 round(mat1x4 v)
        {
            return new mat1x4((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M03));
        }

        /// <summary>
        /// Performs the round function to the specified mat2x1 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat2x1 round(mat2x1 v)
        {
            return new mat2x1((float)Math.Round(v.M00), (float)Math.Round(v.M10));
        }

        /// <summary>
        /// Performs the round function to the specified mat2x2 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat2x2 round(mat2x2 v)
        {
            return new mat2x2((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M10), (float)Math.Round(v.M11));
        }

        /// <summary>
        /// Performs the round function to the specified mat2x3 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat2x3 round(mat2x3 v)
        {
            return new mat2x3((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12));
        }

        /// <summary>
        /// Performs the round function to the specified mat2x4 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat2x4 round(mat2x4 v)
        {
            return new mat2x4((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M03), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12), (float)Math.Round(v.M13));
        }

        /// <summary>
        /// Performs the round function to the specified mat3x1 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat3x1 round(mat3x1 v)
        {
            return new mat3x1((float)Math.Round(v.M00), (float)Math.Round(v.M10), (float)Math.Round(v.M20));
        }

        /// <summary>
        /// Performs the round function to the specified mat3x2 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat3x2 round(mat3x2 v)
        {
            return new mat3x2((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M20), (float)Math.Round(v.M21));
        }

        /// <summary>
        /// Performs the round function to the specified mat3x3 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat3x3 round(mat3x3 v)
        {
            return new mat3x3((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12), (float)Math.Round(v.M20), (float)Math.Round(v.M21), (float)Math.Round(v.M22));
        }

        /// <summary>
        /// Performs the round function to the specified mat3x4 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat3x4 round(mat3x4 v)
        {
            return new mat3x4((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M03), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12), (float)Math.Round(v.M13), (float)Math.Round(v.M20), (float)Math.Round(v.M21), (float)Math.Round(v.M22), (float)Math.Round(v.M23));
        }

        /// <summary>
        /// Performs the round function to the specified mat4x1 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat4x1 round(mat4x1 v)
        {
            return new mat4x1((float)Math.Round(v.M00), (float)Math.Round(v.M10), (float)Math.Round(v.M20), (float)Math.Round(v.M30));
        }

        /// <summary>
        /// Performs the round function to the specified mat4x2 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat4x2 round(mat4x2 v)
        {
            return new mat4x2((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M20), (float)Math.Round(v.M21), (float)Math.Round(v.M30), (float)Math.Round(v.M31));
        }

        /// <summary>
        /// Performs the round function to the specified mat4x3 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat4x3 round(mat4x3 v)
        {
            return new mat4x3((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12), (float)Math.Round(v.M20), (float)Math.Round(v.M21), (float)Math.Round(v.M22), (float)Math.Round(v.M30), (float)Math.Round(v.M31), (float)Math.Round(v.M32));
        }

        /// <summary>
        /// Performs the round function to the specified mat4x4 object.
        /// Rounds each component of v to the nearest integer.
        /// </summary>
        public static mat4x4 round(mat4x4 v)
        {
            return new mat4x4((float)Math.Round(v.M00), (float)Math.Round(v.M01), (float)Math.Round(v.M02), (float)Math.Round(v.M03), (float)Math.Round(v.M10), (float)Math.Round(v.M11), (float)Math.Round(v.M12), (float)Math.Round(v.M13), (float)Math.Round(v.M20), (float)Math.Round(v.M21), (float)Math.Round(v.M22), (float)Math.Round(v.M23), (float)Math.Round(v.M30), (float)Math.Round(v.M31), (float)Math.Round(v.M32), (float)Math.Round(v.M33));
        }

        #endregion
        #region rsqrt

        /// <summary>
        /// Performs the rsqrt function to the specified Vector1 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static float rsqrt(float v)
        {
            return (1 / (float)Math.Sqrt(v));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified Vector2 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static float2 rsqrt(float2 v)
        {
            return new float2(1 / (float)Math.Sqrt(v.x), 1 / (float)Math.Sqrt(v.y));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified float3 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static float3 rsqrt(float3 v)
        {
            return new float3(1 / (float)Math.Sqrt(v.x), 1 / (float)Math.Sqrt(v.y), 1 / (float)Math.Sqrt(v.z));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified float4 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static float4 rsqrt(float4 v)
        {
            return new float4(1 / (float)Math.Sqrt(v.x), 1 / (float)Math.Sqrt(v.y), 1 / (float)Math.Sqrt(v.z), 1 / (float)Math.Sqrt(v.w));
        }


        /// <summary>
        /// Performs the rsqrt function to the specified mat1x1 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat1x1 rsqrt(mat1x1 v)
        {
            return new mat1x1(1 / (float)Math.Sqrt(v.M00));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat1x2 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat1x2 rsqrt(mat1x2 v)
        {
            return new mat1x2(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat1x3 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat1x3 rsqrt(mat1x3 v)
        {
            return new mat1x3(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat1x4 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat1x4 rsqrt(mat1x4 v)
        {
            return new mat1x4(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M03));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat2x1 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat2x1 rsqrt(mat2x1 v)
        {
            return new mat2x1(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M10));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat2x2 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat2x2 rsqrt(mat2x2 v)
        {
            return new mat2x2(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat2x3 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat2x3 rsqrt(mat2x3 v)
        {
            return new mat2x3(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat2x4 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat2x4 rsqrt(mat2x4 v)
        {
            return new mat2x4(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M03), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12), 1 / (float)Math.Sqrt(v.M13));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat3x1 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat3x1 rsqrt(mat3x1 v)
        {
            return new mat3x1(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M20));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat3x2 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat3x2 rsqrt(mat3x2 v)
        {
            return new mat3x2(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat3x3 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat3x3 rsqrt(mat3x3 v)
        {
            return new mat3x3(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21), 1 / (float)Math.Sqrt(v.M22));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat3x4 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat3x4 rsqrt(mat3x4 v)
        {
            return new mat3x4(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M03), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12), 1 / (float)Math.Sqrt(v.M13), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21), 1 / (float)Math.Sqrt(v.M22), 1 / (float)Math.Sqrt(v.M23));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat4x1 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat4x1 rsqrt(mat4x1 v)
        {
            return new mat4x1(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M30));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat4x2 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat4x2 rsqrt(mat4x2 v)
        {
            return new mat4x2(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21), 1 / (float)Math.Sqrt(v.M30), 1 / (float)Math.Sqrt(v.M31));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat4x3 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat4x3 rsqrt(mat4x3 v)
        {
            return new mat4x3(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21), 1 / (float)Math.Sqrt(v.M22), 1 / (float)Math.Sqrt(v.M30), 1 / (float)Math.Sqrt(v.M31), 1 / (float)Math.Sqrt(v.M32));
        }

        /// <summary>
        /// Performs the rsqrt function to the specified mat4x4 object.
        /// Gets the inverse of the square root of each component.
        /// </summary>
        public static mat4x4 rsqrt(mat4x4 v)
        {
            return new mat4x4(1 / (float)Math.Sqrt(v.M00), 1 / (float)Math.Sqrt(v.M01), 1 / (float)Math.Sqrt(v.M02), 1 / (float)Math.Sqrt(v.M03), 1 / (float)Math.Sqrt(v.M10), 1 / (float)Math.Sqrt(v.M11), 1 / (float)Math.Sqrt(v.M12), 1 / (float)Math.Sqrt(v.M13), 1 / (float)Math.Sqrt(v.M20), 1 / (float)Math.Sqrt(v.M21), 1 / (float)Math.Sqrt(v.M22), 1 / (float)Math.Sqrt(v.M23), 1 / (float)Math.Sqrt(v.M30), 1 / (float)Math.Sqrt(v.M31), 1 / (float)Math.Sqrt(v.M32), 1 / (float)Math.Sqrt(v.M33));
        }

        #endregion
        #region saturate

        /// <summary>
        /// Performs the saturate function to the specified Vector1 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static float saturate(float v)
        {
            return (Math.Max(0, Math.Min(1, v)));
        }

        /// <summary>
        /// Performs the saturate function to the specified Vector2 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static float2 saturate(float2 v)
        {
            return new float2(Math.Max(0, Math.Min(1, v.x)), Math.Max(0, Math.Min(1, v.y)));
        }

        /// <summary>
        /// Performs the saturate function to the specified float3 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static float3 saturate(float3 v)
        {
            return new float3(Math.Max(0, Math.Min(1, v.x)), Math.Max(0, Math.Min(1, v.y)), Math.Max(0, Math.Min(1, v.z)));
        }

        /// <summary>
        /// Performs the saturate function to the specified float4 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static float4 saturate(float4 v)
        {
            return new float4(Math.Max(0, Math.Min(1, v.x)), Math.Max(0, Math.Min(1, v.y)), Math.Max(0, Math.Min(1, v.z)), Math.Max(0, Math.Min(1, v.w)));
        }


        /// <summary>
        /// Performs the saturate function to the specified mat1x1 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat1x1 saturate(mat1x1 v)
        {
            return new mat1x1(Math.Max(0, Math.Min(1, v.M00)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat1x2 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat1x2 saturate(mat1x2 v)
        {
            return new mat1x2(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat1x3 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat1x3 saturate(mat1x3 v)
        {
            return new mat1x3(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat1x4 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat1x4 saturate(mat1x4 v)
        {
            return new mat1x4(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M03)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat2x1 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat2x1 saturate(mat2x1 v)
        {
            return new mat2x1(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M10)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat2x2 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat2x2 saturate(mat2x2 v)
        {
            return new mat2x2(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat2x3 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat2x3 saturate(mat2x3 v)
        {
            return new mat2x3(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat2x4 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat2x4 saturate(mat2x4 v)
        {
            return new mat2x4(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M03)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)), Math.Max(0, Math.Min(1, v.M13)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat3x1 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat3x1 saturate(mat3x1 v)
        {
            return new mat3x1(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M20)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat3x2 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat3x2 saturate(mat3x2 v)
        {
            return new mat3x2(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat3x3 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat3x3 saturate(mat3x3 v)
        {
            return new mat3x3(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)), Math.Max(0, Math.Min(1, v.M22)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat3x4 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat3x4 saturate(mat3x4 v)
        {
            return new mat3x4(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M03)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)), Math.Max(0, Math.Min(1, v.M13)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)), Math.Max(0, Math.Min(1, v.M22)), Math.Max(0, Math.Min(1, v.M23)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat4x1 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat4x1 saturate(mat4x1 v)
        {
            return new mat4x1(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M30)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat4x2 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat4x2 saturate(mat4x2 v)
        {
            return new mat4x2(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)), Math.Max(0, Math.Min(1, v.M30)), Math.Max(0, Math.Min(1, v.M31)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat4x3 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat4x3 saturate(mat4x3 v)
        {
            return new mat4x3(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)), Math.Max(0, Math.Min(1, v.M22)), Math.Max(0, Math.Min(1, v.M30)), Math.Max(0, Math.Min(1, v.M31)), Math.Max(0, Math.Min(1, v.M32)));
        }

        /// <summary>
        /// Performs the saturate function to the specified mat4x4 object.
        /// Clamps each component between 0 and 1.
        /// </summary>
        public static mat4x4 saturate(mat4x4 v)
        {
            return new mat4x4(Math.Max(0, Math.Min(1, v.M00)), Math.Max(0, Math.Min(1, v.M01)), Math.Max(0, Math.Min(1, v.M02)), Math.Max(0, Math.Min(1, v.M03)), Math.Max(0, Math.Min(1, v.M10)), Math.Max(0, Math.Min(1, v.M11)), Math.Max(0, Math.Min(1, v.M12)), Math.Max(0, Math.Min(1, v.M13)), Math.Max(0, Math.Min(1, v.M20)), Math.Max(0, Math.Min(1, v.M21)), Math.Max(0, Math.Min(1, v.M22)), Math.Max(0, Math.Min(1, v.M23)), Math.Max(0, Math.Min(1, v.M30)), Math.Max(0, Math.Min(1, v.M31)), Math.Max(0, Math.Min(1, v.M32)), Math.Max(0, Math.Min(1, v.M33)));
        }

        #endregion
        #region sign

        /// <summary>
        /// Performs the sign function to the specified Vector1 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static float sign(float v)
        {
            return (float)Math.Sign(v);
        }

        /// <summary>
        /// Performs the sign function to the specified Vector2 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static float2 sign(float2 v)
        {
            return new float2((float)Math.Sign(v.x), (float)Math.Sign(v.y));
        }

        /// <summary>
        /// Performs the sign function to the specified float3 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static float3 sign(float3 v)
        {
            return new float3((float)Math.Sign(v.x), (float)Math.Sign(v.y), (float)Math.Sign(v.z));
        }

        /// <summary>
        /// Performs the sign function to the specified float4 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static float4 sign(float4 v)
        {
            return new float4((float)Math.Sign(v.x), (float)Math.Sign(v.y), (float)Math.Sign(v.z), (float)Math.Sign(v.w));
        }


        /// <summary>
        /// Performs the sign function to the specified mat1x1 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat1x1 sign(mat1x1 v)
        {
            return new mat1x1((float)Math.Sign(v.M00));
        }

        /// <summary>
        /// Performs the sign function to the specified mat1x2 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat1x2 sign(mat1x2 v)
        {
            return new mat1x2((float)Math.Sign(v.M00), (float)Math.Sign(v.M01));
        }

        /// <summary>
        /// Performs the sign function to the specified mat1x3 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat1x3 sign(mat1x3 v)
        {
            return new mat1x3((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02));
        }

        /// <summary>
        /// Performs the sign function to the specified mat1x4 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat1x4 sign(mat1x4 v)
        {
            return new mat1x4((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M03));
        }

        /// <summary>
        /// Performs the sign function to the specified mat2x1 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat2x1 sign(mat2x1 v)
        {
            return new mat2x1((float)Math.Sign(v.M00), (float)Math.Sign(v.M10));
        }

        /// <summary>
        /// Performs the sign function to the specified mat2x2 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat2x2 sign(mat2x2 v)
        {
            return new mat2x2((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11));
        }

        /// <summary>
        /// Performs the sign function to the specified mat2x3 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat2x3 sign(mat2x3 v)
        {
            return new mat2x3((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12));
        }

        /// <summary>
        /// Performs the sign function to the specified mat2x4 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat2x4 sign(mat2x4 v)
        {
            return new mat2x4((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M03), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12), (float)Math.Sign(v.M13));
        }

        /// <summary>
        /// Performs the sign function to the specified mat3x1 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat3x1 sign(mat3x1 v)
        {
            return new mat3x1((float)Math.Sign(v.M00), (float)Math.Sign(v.M10), (float)Math.Sign(v.M20));
        }

        /// <summary>
        /// Performs the sign function to the specified mat3x2 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat3x2 sign(mat3x2 v)
        {
            return new mat3x2((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21));
        }

        /// <summary>
        /// Performs the sign function to the specified mat3x3 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat3x3 sign(mat3x3 v)
        {
            return new mat3x3((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21), (float)Math.Sign(v.M22));
        }

        /// <summary>
        /// Performs the sign function to the specified mat3x4 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat3x4 sign(mat3x4 v)
        {
            return new mat3x4((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M03), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12), (float)Math.Sign(v.M13), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21), (float)Math.Sign(v.M22), (float)Math.Sign(v.M23));
        }

        /// <summary>
        /// Performs the sign function to the specified mat4x1 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat4x1 sign(mat4x1 v)
        {
            return new mat4x1((float)Math.Sign(v.M00), (float)Math.Sign(v.M10), (float)Math.Sign(v.M20), (float)Math.Sign(v.M30));
        }

        /// <summary>
        /// Performs the sign function to the specified mat4x2 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat4x2 sign(mat4x2 v)
        {
            return new mat4x2((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21), (float)Math.Sign(v.M30), (float)Math.Sign(v.M31));
        }

        /// <summary>
        /// Performs the sign function to the specified mat4x3 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat4x3 sign(mat4x3 v)
        {
            return new mat4x3((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21), (float)Math.Sign(v.M22), (float)Math.Sign(v.M30), (float)Math.Sign(v.M31), (float)Math.Sign(v.M32));
        }

        /// <summary>
        /// Performs the sign function to the specified mat4x4 object.
        /// Gets the sign of each component of v.
        /// </summary>
        public static mat4x4 sign(mat4x4 v)
        {
            return new mat4x4((float)Math.Sign(v.M00), (float)Math.Sign(v.M01), (float)Math.Sign(v.M02), (float)Math.Sign(v.M03), (float)Math.Sign(v.M10), (float)Math.Sign(v.M11), (float)Math.Sign(v.M12), (float)Math.Sign(v.M13), (float)Math.Sign(v.M20), (float)Math.Sign(v.M21), (float)Math.Sign(v.M22), (float)Math.Sign(v.M23), (float)Math.Sign(v.M30), (float)Math.Sign(v.M31), (float)Math.Sign(v.M32), (float)Math.Sign(v.M33));
        }

        #endregion
        #region sin

        /// <summary>
        /// Performs the sin function to the specified Vector1 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static float sin(float v)
        {
            return ((float)Math.Sin(v));
        }

        /// <summary>
        /// Performs the sin function to the specified Vector2 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static float2 sin(float2 v)
        {
            return new float2((float)Math.Sin(v.x), (float)Math.Sin(v.y));
        }

        /// <summary>
        /// Performs the sin function to the specified float3 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static float3 sin(float3 v)
        {
            return new float3((float)Math.Sin(v.x), (float)Math.Sin(v.y), (float)Math.Sin(v.z));
        }

        /// <summary>
        /// Performs the sin function to the specified float4 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static float4 sin(float4 v)
        {
            return new float4((float)Math.Sin(v.x), (float)Math.Sin(v.y), (float)Math.Sin(v.z), (float)Math.Sin(v.w));
        }


        /// <summary>
        /// Performs the sin function to the specified mat1x1 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat1x1 sin(mat1x1 v)
        {
            return new mat1x1((float)Math.Sin(v.M00));
        }

        /// <summary>
        /// Performs the sin function to the specified mat1x2 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat1x2 sin(mat1x2 v)
        {
            return new mat1x2((float)Math.Sin(v.M00), (float)Math.Sin(v.M01));
        }

        /// <summary>
        /// Performs the sin function to the specified mat1x3 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat1x3 sin(mat1x3 v)
        {
            return new mat1x3((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02));
        }

        /// <summary>
        /// Performs the sin function to the specified mat1x4 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat1x4 sin(mat1x4 v)
        {
            return new mat1x4((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M03));
        }

        /// <summary>
        /// Performs the sin function to the specified mat2x1 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat2x1 sin(mat2x1 v)
        {
            return new mat2x1((float)Math.Sin(v.M00), (float)Math.Sin(v.M10));
        }

        /// <summary>
        /// Performs the sin function to the specified mat2x2 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat2x2 sin(mat2x2 v)
        {
            return new mat2x2((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11));
        }

        /// <summary>
        /// Performs the sin function to the specified mat2x3 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat2x3 sin(mat2x3 v)
        {
            return new mat2x3((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12));
        }

        /// <summary>
        /// Performs the sin function to the specified mat2x4 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat2x4 sin(mat2x4 v)
        {
            return new mat2x4((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M03), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12), (float)Math.Sin(v.M13));
        }

        /// <summary>
        /// Performs the sin function to the specified mat3x1 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat3x1 sin(mat3x1 v)
        {
            return new mat3x1((float)Math.Sin(v.M00), (float)Math.Sin(v.M10), (float)Math.Sin(v.M20));
        }

        /// <summary>
        /// Performs the sin function to the specified mat3x2 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat3x2 sin(mat3x2 v)
        {
            return new mat3x2((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21));
        }

        /// <summary>
        /// Performs the sin function to the specified mat3x3 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat3x3 sin(mat3x3 v)
        {
            return new mat3x3((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21), (float)Math.Sin(v.M22));
        }

        /// <summary>
        /// Performs the sin function to the specified mat3x4 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat3x4 sin(mat3x4 v)
        {
            return new mat3x4((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M03), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12), (float)Math.Sin(v.M13), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21), (float)Math.Sin(v.M22), (float)Math.Sin(v.M23));
        }

        /// <summary>
        /// Performs the sin function to the specified mat4x1 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat4x1 sin(mat4x1 v)
        {
            return new mat4x1((float)Math.Sin(v.M00), (float)Math.Sin(v.M10), (float)Math.Sin(v.M20), (float)Math.Sin(v.M30));
        }

        /// <summary>
        /// Performs the sin function to the specified mat4x2 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat4x2 sin(mat4x2 v)
        {
            return new mat4x2((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21), (float)Math.Sin(v.M30), (float)Math.Sin(v.M31));
        }

        /// <summary>
        /// Performs the sin function to the specified mat4x3 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat4x3 sin(mat4x3 v)
        {
            return new mat4x3((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21), (float)Math.Sin(v.M22), (float)Math.Sin(v.M30), (float)Math.Sin(v.M31), (float)Math.Sin(v.M32));
        }

        /// <summary>
        /// Performs the sin function to the specified mat4x4 object.
        /// Gets the sine of each component of v.
        /// </summary>
        public static mat4x4 sin(mat4x4 v)
        {
            return new mat4x4((float)Math.Sin(v.M00), (float)Math.Sin(v.M01), (float)Math.Sin(v.M02), (float)Math.Sin(v.M03), (float)Math.Sin(v.M10), (float)Math.Sin(v.M11), (float)Math.Sin(v.M12), (float)Math.Sin(v.M13), (float)Math.Sin(v.M20), (float)Math.Sin(v.M21), (float)Math.Sin(v.M22), (float)Math.Sin(v.M23), (float)Math.Sin(v.M30), (float)Math.Sin(v.M31), (float)Math.Sin(v.M32), (float)Math.Sin(v.M33));
        }

        #endregion
        #region sinh

        /// <summary>
        /// Performs the sinh function to the specified Vector1 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static float sinh(float v)
        {
            return ((float)Math.Sinh(v));
        }

        /// <summary>
        /// Performs the sinh function to the specified Vector2 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static float2 sinh(float2 v)
        {
            return new float2((float)Math.Sinh(v.x), (float)Math.Sinh(v.y));
        }

        /// <summary>
        /// Performs the sinh function to the specified float3 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static float3 sinh(float3 v)
        {
            return new float3((float)Math.Sinh(v.x), (float)Math.Sinh(v.y), (float)Math.Sinh(v.z));
        }

        /// <summary>
        /// Performs the sinh function to the specified float4 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static float4 sinh(float4 v)
        {
            return new float4((float)Math.Sinh(v.x), (float)Math.Sinh(v.y), (float)Math.Sinh(v.z), (float)Math.Sinh(v.w));
        }


        /// <summary>
        /// Performs the sinh function to the specified mat1x1 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat1x1 sinh(mat1x1 v)
        {
            return new mat1x1((float)Math.Sinh(v.M00));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat1x2 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat1x2 sinh(mat1x2 v)
        {
            return new mat1x2((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat1x3 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat1x3 sinh(mat1x3 v)
        {
            return new mat1x3((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat1x4 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat1x4 sinh(mat1x4 v)
        {
            return new mat1x4((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M03));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat2x1 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat2x1 sinh(mat2x1 v)
        {
            return new mat2x1((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M10));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat2x2 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat2x2 sinh(mat2x2 v)
        {
            return new mat2x2((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat2x3 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat2x3 sinh(mat2x3 v)
        {
            return new mat2x3((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat2x4 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat2x4 sinh(mat2x4 v)
        {
            return new mat2x4((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M03), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12), (float)Math.Sinh(v.M13));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat3x1 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat3x1 sinh(mat3x1 v)
        {
            return new mat3x1((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M20));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat3x2 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat3x2 sinh(mat3x2 v)
        {
            return new mat3x2((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat3x3 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat3x3 sinh(mat3x3 v)
        {
            return new mat3x3((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21), (float)Math.Sinh(v.M22));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat3x4 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat3x4 sinh(mat3x4 v)
        {
            return new mat3x4((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M03), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12), (float)Math.Sinh(v.M13), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21), (float)Math.Sinh(v.M22), (float)Math.Sinh(v.M23));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat4x1 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat4x1 sinh(mat4x1 v)
        {
            return new mat4x1((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M30));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat4x2 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat4x2 sinh(mat4x2 v)
        {
            return new mat4x2((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21), (float)Math.Sinh(v.M30), (float)Math.Sinh(v.M31));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat4x3 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat4x3 sinh(mat4x3 v)
        {
            return new mat4x3((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21), (float)Math.Sinh(v.M22), (float)Math.Sinh(v.M30), (float)Math.Sinh(v.M31), (float)Math.Sinh(v.M32));
        }

        /// <summary>
        /// Performs the sinh function to the specified mat4x4 object.
        /// Gets the hyperbolic sine of each component of v.
        /// </summary>
        public static mat4x4 sinh(mat4x4 v)
        {
            return new mat4x4((float)Math.Sinh(v.M00), (float)Math.Sinh(v.M01), (float)Math.Sinh(v.M02), (float)Math.Sinh(v.M03), (float)Math.Sinh(v.M10), (float)Math.Sinh(v.M11), (float)Math.Sinh(v.M12), (float)Math.Sinh(v.M13), (float)Math.Sinh(v.M20), (float)Math.Sinh(v.M21), (float)Math.Sinh(v.M22), (float)Math.Sinh(v.M23), (float)Math.Sinh(v.M30), (float)Math.Sinh(v.M31), (float)Math.Sinh(v.M32), (float)Math.Sinh(v.M33));
        }

        #endregion
        #region smoothstep

        /// <summary>
        /// Performs the smoothstep function to the specified Vector1 objects.
        /// Gets 0 if s < v1, 1 if s > v2, and performs an hermite interpolation between 0 and 1 on the other case.
        /// </summary>
        public static float smoothstep(float v1, float v2, float s)
        {

            float t = clamp((s - v1) / (v2 - v1), (0), (1));
            return t * t * ((3.0f) - 2.0f * t);

        }


        /// <summary>
        /// Performs the smoothstep function to the specified Vector2 objects.
        /// Gets 0 if s < v1, 1 if s > v2, and performs an hermite interpolation between 0 and 1 on the other case.
        /// </summary>
        public static float2 smoothstep(float2 v1, float2 v2, float2 s)
        {

            float2 t = clamp((s - v1) / (v2 - v1), new float2(0), new float2(1));
            return t * t * (new float2(3.0f) - 2.0f * t);

        }


        /// <summary>
        /// Performs the smoothstep function to the specified float3 objects.
        /// Gets 0 if s < v1, 1 if s > v2, and performs an hermite interpolation between 0 and 1 on the other case.
        /// </summary>
        public static float3 smoothstep(float3 v1, float3 v2, float3 s)
        {

            float3 t = clamp((s - v1) / (v2 - v1), new float3(0), new float3(1));
            return t * t * (new float3(3.0f) - 2.0f * t);

        }


        /// <summary>
        /// Performs the smoothstep function to the specified float4 objects.
        /// Gets 0 if s < v1, 1 if s > v2, and performs an hermite interpolation between 0 and 1 on the other case.
        /// </summary>
        public static float4 smoothstep(float4 v1, float4 v2, float4 s)
        {

            float4 t = clamp((s - v1) / (v2 - v1), new float4(0), new float4(1));
            return t * t * (new float4(3.0f) - 2.0f * t);

        }

        #endregion
        #region sqrt

        /// <summary>
        /// Performs the sqrt function to the specified Vector1 object.
        /// Gets the square root of each component.
        /// </summary>
        public static float sqrt(float v)
        {
            return ((float)Math.Sqrt(v));
        }

        /// <summary>
        /// Performs the sqrt function to the specified Vector2 object.
        /// Gets the square root of each component.
        /// </summary>
        public static float2 sqrt(float2 v)
        {
            return new float2((float)Math.Sqrt(v.x), (float)Math.Sqrt(v.y));
        }

        /// <summary>
        /// Performs the sqrt function to the specified float3 object.
        /// Gets the square root of each component.
        /// </summary>
        public static float3 sqrt(float3 v)
        {
            return new float3((float)Math.Sqrt(v.x), (float)Math.Sqrt(v.y), (float)Math.Sqrt(v.z));
        }

        /// <summary>
        /// Performs the sqrt function to the specified float4 object.
        /// Gets the square root of each component.
        /// </summary>
        public static float4 sqrt(float4 v)
        {
            return new float4((float)Math.Sqrt(v.x), (float)Math.Sqrt(v.y), (float)Math.Sqrt(v.z), (float)Math.Sqrt(v.w));
        }


        /// <summary>
        /// Performs the sqrt function to the specified mat1x1 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat1x1 sqrt(mat1x1 v)
        {
            return new mat1x1((float)Math.Sqrt(v.M00));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat1x2 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat1x2 sqrt(mat1x2 v)
        {
            return new mat1x2((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat1x3 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat1x3 sqrt(mat1x3 v)
        {
            return new mat1x3((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat1x4 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat1x4 sqrt(mat1x4 v)
        {
            return new mat1x4((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M03));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat2x1 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat2x1 sqrt(mat2x1 v)
        {
            return new mat2x1((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M10));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat2x2 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat2x2 sqrt(mat2x2 v)
        {
            return new mat2x2((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat2x3 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat2x3 sqrt(mat2x3 v)
        {
            return new mat2x3((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat2x4 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat2x4 sqrt(mat2x4 v)
        {
            return new mat2x4((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M03), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12), (float)Math.Sqrt(v.M13));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat3x1 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat3x1 sqrt(mat3x1 v)
        {
            return new mat3x1((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M20));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat3x2 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat3x2 sqrt(mat3x2 v)
        {
            return new mat3x2((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat3x3 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat3x3 sqrt(mat3x3 v)
        {
            return new mat3x3((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21), (float)Math.Sqrt(v.M22));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat3x4 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat3x4 sqrt(mat3x4 v)
        {
            return new mat3x4((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M03), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12), (float)Math.Sqrt(v.M13), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21), (float)Math.Sqrt(v.M22), (float)Math.Sqrt(v.M23));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat4x1 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat4x1 sqrt(mat4x1 v)
        {
            return new mat4x1((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M30));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat4x2 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat4x2 sqrt(mat4x2 v)
        {
            return new mat4x2((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21), (float)Math.Sqrt(v.M30), (float)Math.Sqrt(v.M31));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat4x3 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat4x3 sqrt(mat4x3 v)
        {
            return new mat4x3((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21), (float)Math.Sqrt(v.M22), (float)Math.Sqrt(v.M30), (float)Math.Sqrt(v.M31), (float)Math.Sqrt(v.M32));
        }

        /// <summary>
        /// Performs the sqrt function to the specified mat4x4 object.
        /// Gets the square root of each component.
        /// </summary>
        public static mat4x4 sqrt(mat4x4 v)
        {
            return new mat4x4((float)Math.Sqrt(v.M00), (float)Math.Sqrt(v.M01), (float)Math.Sqrt(v.M02), (float)Math.Sqrt(v.M03), (float)Math.Sqrt(v.M10), (float)Math.Sqrt(v.M11), (float)Math.Sqrt(v.M12), (float)Math.Sqrt(v.M13), (float)Math.Sqrt(v.M20), (float)Math.Sqrt(v.M21), (float)Math.Sqrt(v.M22), (float)Math.Sqrt(v.M23), (float)Math.Sqrt(v.M30), (float)Math.Sqrt(v.M31), (float)Math.Sqrt(v.M32), (float)Math.Sqrt(v.M33));
        }

        #endregion
        #region step

        /// <summary>
        /// Performs the step function to the specified Vector1 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static float step(float v1, float v2)
        {
            return (v1 >= v2 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified Vector2 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static float2 step(float2 v1, float2 v2)
        {
            return new float2(v1.x >= v2.x ? 1 : 0, v1.y >= v2.y ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified float3 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static float3 step(float3 v1, float3 v2)
        {
            return new float3(v1.x >= v2.x ? 1 : 0, v1.y >= v2.y ? 1 : 0, v1.z >= v2.z ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified float4 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static float4 step(float4 v1, float4 v2)
        {
            return new float4(v1.x >= v2.x ? 1 : 0, v1.y >= v2.y ? 1 : 0, v1.z >= v2.z ? 1 : 0, v1.w >= v2.w ? 1 : 0);
        }


        /// <summary>
        /// Performs the step function to the specified mat1x1 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat1x1 step(mat1x1 v1, mat1x1 v2)
        {
            return new mat1x1(v1.M00 >= v2.M00 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat1x2 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat1x2 step(mat1x2 v1, mat1x2 v2)
        {
            return new mat1x2(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat1x3 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat1x3 step(mat1x3 v1, mat1x3 v2)
        {
            return new mat1x3(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat1x4 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat1x4 step(mat1x4 v1, mat1x4 v2)
        {
            return new mat1x4(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M03 >= v2.M03 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat2x1 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat2x1 step(mat2x1 v1, mat2x1 v2)
        {
            return new mat2x1(v1.M00 >= v2.M00 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat2x2 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat2x2 step(mat2x2 v1, mat2x2 v2)
        {
            return new mat2x2(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat2x3 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat2x3 step(mat2x3 v1, mat2x3 v2)
        {
            return new mat2x3(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat2x4 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat2x4 step(mat2x4 v1, mat2x4 v2)
        {
            return new mat2x4(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M03 >= v2.M03 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0, v1.M13 >= v2.M13 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat3x1 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat3x1 step(mat3x1 v1, mat3x1 v2)
        {
            return new mat3x1(v1.M00 >= v2.M00 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat3x2 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat3x2 step(mat3x2 v1, mat3x2 v2)
        {
            return new mat3x2(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat3x3 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat3x3 step(mat3x3 v1, mat3x3 v2)
        {
            return new mat3x3(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0, v1.M22 >= v2.M22 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat3x4 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat3x4 step(mat3x4 v1, mat3x4 v2)
        {
            return new mat3x4(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M03 >= v2.M03 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0, v1.M13 >= v2.M13 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0, v1.M22 >= v2.M22 ? 1 : 0, v1.M23 >= v2.M23 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat4x1 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat4x1 step(mat4x1 v1, mat4x1 v2)
        {
            return new mat4x1(v1.M00 >= v2.M00 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M30 >= v2.M30 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat4x2 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat4x2 step(mat4x2 v1, mat4x2 v2)
        {
            return new mat4x2(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0, v1.M30 >= v2.M30 ? 1 : 0, v1.M31 >= v2.M31 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat4x3 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat4x3 step(mat4x3 v1, mat4x3 v2)
        {
            return new mat4x3(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0, v1.M22 >= v2.M22 ? 1 : 0, v1.M30 >= v2.M30 ? 1 : 0, v1.M31 >= v2.M31 ? 1 : 0, v1.M32 >= v2.M32 ? 1 : 0);
        }

        /// <summary>
        /// Performs the step function to the specified mat4x4 objects.
        /// Gets v1 >= v2 ? 1 : 0
        /// </summary>
        public static mat4x4 step(mat4x4 v1, mat4x4 v2)
        {
            return new mat4x4(v1.M00 >= v2.M00 ? 1 : 0, v1.M01 >= v2.M01 ? 1 : 0, v1.M02 >= v2.M02 ? 1 : 0, v1.M03 >= v2.M03 ? 1 : 0, v1.M10 >= v2.M10 ? 1 : 0, v1.M11 >= v2.M11 ? 1 : 0, v1.M12 >= v2.M12 ? 1 : 0, v1.M13 >= v2.M13 ? 1 : 0, v1.M20 >= v2.M20 ? 1 : 0, v1.M21 >= v2.M21 ? 1 : 0, v1.M22 >= v2.M22 ? 1 : 0, v1.M23 >= v2.M23 ? 1 : 0, v1.M30 >= v2.M30 ? 1 : 0, v1.M31 >= v2.M31 ? 1 : 0, v1.M32 >= v2.M32 ? 1 : 0, v1.M33 >= v2.M33 ? 1 : 0);
        }

        #endregion
        #region tan

        /// <summary>
        /// Performs the tan function to the specified Vector1 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static float tan(float v)
        {
            return ((float)Math.Tan(v));
        }

        /// <summary>
        /// Performs the tan function to the specified Vector2 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static float2 tan(float2 v)
        {
            return new float2((float)Math.Tan(v.x), (float)Math.Tan(v.y));
        }

        /// <summary>
        /// Performs the tan function to the specified float3 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static float3 tan(float3 v)
        {
            return new float3((float)Math.Tan(v.x), (float)Math.Tan(v.y), (float)Math.Tan(v.z));
        }

        /// <summary>
        /// Performs the tan function to the specified float4 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static float4 tan(float4 v)
        {
            return new float4((float)Math.Tan(v.x), (float)Math.Tan(v.y), (float)Math.Tan(v.z), (float)Math.Tan(v.w));
        }


        /// <summary>
        /// Performs the tan function to the specified mat1x1 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat1x1 tan(mat1x1 v)
        {
            return new mat1x1((float)Math.Tan(v.M00));
        }

        /// <summary>
        /// Performs the tan function to the specified mat1x2 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat1x2 tan(mat1x2 v)
        {
            return new mat1x2((float)Math.Tan(v.M00), (float)Math.Tan(v.M01));
        }

        /// <summary>
        /// Performs the tan function to the specified mat1x3 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat1x3 tan(mat1x3 v)
        {
            return new mat1x3((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02));
        }

        /// <summary>
        /// Performs the tan function to the specified mat1x4 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat1x4 tan(mat1x4 v)
        {
            return new mat1x4((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M03));
        }

        /// <summary>
        /// Performs the tan function to the specified mat2x1 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat2x1 tan(mat2x1 v)
        {
            return new mat2x1((float)Math.Tan(v.M00), (float)Math.Tan(v.M10));
        }

        /// <summary>
        /// Performs the tan function to the specified mat2x2 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat2x2 tan(mat2x2 v)
        {
            return new mat2x2((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11));
        }

        /// <summary>
        /// Performs the tan function to the specified mat2x3 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat2x3 tan(mat2x3 v)
        {
            return new mat2x3((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12));
        }

        /// <summary>
        /// Performs the tan function to the specified mat2x4 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat2x4 tan(mat2x4 v)
        {
            return new mat2x4((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M03), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12), (float)Math.Tan(v.M13));
        }

        /// <summary>
        /// Performs the tan function to the specified mat3x1 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat3x1 tan(mat3x1 v)
        {
            return new mat3x1((float)Math.Tan(v.M00), (float)Math.Tan(v.M10), (float)Math.Tan(v.M20));
        }

        /// <summary>
        /// Performs the tan function to the specified mat3x2 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat3x2 tan(mat3x2 v)
        {
            return new mat3x2((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21));
        }

        /// <summary>
        /// Performs the tan function to the specified mat3x3 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat3x3 tan(mat3x3 v)
        {
            return new mat3x3((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21), (float)Math.Tan(v.M22));
        }

        /// <summary>
        /// Performs the tan function to the specified mat3x4 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat3x4 tan(mat3x4 v)
        {
            return new mat3x4((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M03), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12), (float)Math.Tan(v.M13), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21), (float)Math.Tan(v.M22), (float)Math.Tan(v.M23));
        }

        /// <summary>
        /// Performs the tan function to the specified mat4x1 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat4x1 tan(mat4x1 v)
        {
            return new mat4x1((float)Math.Tan(v.M00), (float)Math.Tan(v.M10), (float)Math.Tan(v.M20), (float)Math.Tan(v.M30));
        }

        /// <summary>
        /// Performs the tan function to the specified mat4x2 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat4x2 tan(mat4x2 v)
        {
            return new mat4x2((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21), (float)Math.Tan(v.M30), (float)Math.Tan(v.M31));
        }

        /// <summary>
        /// Performs the tan function to the specified mat4x3 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat4x3 tan(mat4x3 v)
        {
            return new mat4x3((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21), (float)Math.Tan(v.M22), (float)Math.Tan(v.M30), (float)Math.Tan(v.M31), (float)Math.Tan(v.M32));
        }

        /// <summary>
        /// Performs the tan function to the specified mat4x4 object.
        /// Gets the tangent of each component of v.
        /// </summary>
        public static mat4x4 tan(mat4x4 v)
        {
            return new mat4x4((float)Math.Tan(v.M00), (float)Math.Tan(v.M01), (float)Math.Tan(v.M02), (float)Math.Tan(v.M03), (float)Math.Tan(v.M10), (float)Math.Tan(v.M11), (float)Math.Tan(v.M12), (float)Math.Tan(v.M13), (float)Math.Tan(v.M20), (float)Math.Tan(v.M21), (float)Math.Tan(v.M22), (float)Math.Tan(v.M23), (float)Math.Tan(v.M30), (float)Math.Tan(v.M31), (float)Math.Tan(v.M32), (float)Math.Tan(v.M33));
        }

        #endregion
        #region tanh

        /// <summary>
        /// Performs the tanh function to the specified Vector1 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static float tanh(float v)
        {
            return ((float)Math.Tanh(v));
        }

        public static float1 tanh(float1 v)
        {
            return new float1((float)Math.Tanh(v.x));
        }

        /// <summary>
        /// Performs the tanh function to the specified Vector2 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static float2 tanh(float2 v)
        {
            return new float2((float)Math.Tanh(v.x), (float)Math.Tanh(v.y));
        }

        /// <summary>
        /// Performs the tanh function to the specified float3 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static float3 tanh(float3 v)
        {
            return new float3((float)Math.Tanh(v.x), (float)Math.Tanh(v.y), (float)Math.Tanh(v.z));
        }

        /// <summary>
        /// Performs the tanh function to the specified float4 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static float4 tanh(float4 v)
        {
            return new float4((float)Math.Tanh(v.x), (float)Math.Tanh(v.y), (float)Math.Tanh(v.z), (float)Math.Tanh(v.w));
        }


        /// <summary>
        /// Performs the tanh function to the specified mat1x1 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat1x1 tanh(mat1x1 v)
        {
            return new mat1x1((float)Math.Tanh(v.M00));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat1x2 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat1x2 tanh(mat1x2 v)
        {
            return new mat1x2((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat1x3 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat1x3 tanh(mat1x3 v)
        {
            return new mat1x3((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat1x4 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat1x4 tanh(mat1x4 v)
        {
            return new mat1x4((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M03));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat2x1 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat2x1 tanh(mat2x1 v)
        {
            return new mat2x1((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M10));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat2x2 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat2x2 tanh(mat2x2 v)
        {
            return new mat2x2((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat2x3 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat2x3 tanh(mat2x3 v)
        {
            return new mat2x3((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat2x4 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat2x4 tanh(mat2x4 v)
        {
            return new mat2x4((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M03), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12), (float)Math.Tanh(v.M13));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat3x1 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat3x1 tanh(mat3x1 v)
        {
            return new mat3x1((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M20));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat3x2 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat3x2 tanh(mat3x2 v)
        {
            return new mat3x2((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat3x3 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat3x3 tanh(mat3x3 v)
        {
            return new mat3x3((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21), (float)Math.Tanh(v.M22));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat3x4 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat3x4 tanh(mat3x4 v)
        {
            return new mat3x4((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M03), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12), (float)Math.Tanh(v.M13), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21), (float)Math.Tanh(v.M22), (float)Math.Tanh(v.M23));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat4x1 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat4x1 tanh(mat4x1 v)
        {
            return new mat4x1((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M30));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat4x2 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat4x2 tanh(mat4x2 v)
        {
            return new mat4x2((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21), (float)Math.Tanh(v.M30), (float)Math.Tanh(v.M31));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat4x3 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat4x3 tanh(mat4x3 v)
        {
            return new mat4x3((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21), (float)Math.Tanh(v.M22), (float)Math.Tanh(v.M30), (float)Math.Tanh(v.M31), (float)Math.Tanh(v.M32));
        }

        /// <summary>
        /// Performs the tanh function to the specified mat4x4 object.
        /// Gets the hyperbolic tangent of each component of v.
        /// </summary>
        public static mat4x4 tanh(mat4x4 v)
        {
            return new mat4x4((float)Math.Tanh(v.M00), (float)Math.Tanh(v.M01), (float)Math.Tanh(v.M02), (float)Math.Tanh(v.M03), (float)Math.Tanh(v.M10), (float)Math.Tanh(v.M11), (float)Math.Tanh(v.M12), (float)Math.Tanh(v.M13), (float)Math.Tanh(v.M20), (float)Math.Tanh(v.M21), (float)Math.Tanh(v.M22), (float)Math.Tanh(v.M23), (float)Math.Tanh(v.M30), (float)Math.Tanh(v.M31), (float)Math.Tanh(v.M32), (float)Math.Tanh(v.M33));
        }

        #endregion
        #region transpose
        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat1x1 transpose(mat1x1 m)
        {
            return new mat1x1(m.M00);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat2x1 transpose(mat1x2 m)
        {
            return new mat2x1(m.M00, m.M01);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat3x1 transpose(mat1x3 m)
        {
            return new mat3x1(m.M00, m.M01, m.M02);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat4x1 transpose(mat1x4 m)
        {
            return new mat4x1(m.M00, m.M01, m.M02, m.M03);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat1x2 transpose(mat2x1 m)
        {
            return new mat1x2(m.M00, m.M10);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat2x2 transpose(mat2x2 m)
        {
            return new mat2x2(m.M00, m.M10, m.M01, m.M11);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat3x2 transpose(mat2x3 m)
        {
            return new mat3x2(m.M00, m.M10, m.M01, m.M11, m.M02, m.M12);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat4x2 transpose(mat2x4 m)
        {
            return new mat4x2(m.M00, m.M10, m.M01, m.M11, m.M02, m.M12, m.M03, m.M13);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat1x3 transpose(mat3x1 m)
        {
            return new mat1x3(m.M00, m.M10, m.M20);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat2x3 transpose(mat3x2 m)
        {
            return new mat2x3(m.M00, m.M10, m.M20, m.M01, m.M11, m.M21);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat3x3 transpose(mat3x3 m)
        {
            return new mat3x3(m.M00, m.M10, m.M20, m.M01, m.M11, m.M21, m.M02, m.M12, m.M22);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat4x3 transpose(mat3x4 m)
        {
            return new mat4x3(m.M00, m.M10, m.M20, m.M01, m.M11, m.M21, m.M02, m.M12, m.M22, m.M03, m.M13, m.M23);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat1x4 transpose(mat4x1 m)
        {
            return new mat1x4(m.M00, m.M10, m.M20, m.M30);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat2x4 transpose(mat4x2 m)
        {
            return new mat2x4(m.M00, m.M10, m.M20, m.M30, m.M01, m.M11, m.M21, m.M31);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat3x4 transpose(mat4x3 m)
        {
            return new mat3x4(m.M00, m.M10, m.M20, m.M30, m.M01, m.M11, m.M21, m.M31, m.M02, m.M12, m.M22, m.M32);
        }

        /// <summary>
        /// Returns the transpose mat for the specific object.
        /// </summary>
        public static mat4x4 transpose(mat4x4 m)
        {
            return new mat4x4(m.M00, m.M10, m.M20, m.M30, m.M01, m.M11, m.M21, m.M31, m.M02, m.M12, m.M22, m.M32, m.M03, m.M13, m.M23, m.M33);
        }

        #endregion
    }
}
