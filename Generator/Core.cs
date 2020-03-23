using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    /// <summary>
    /// Represents a perfect importance phase function
    /// </summary>
    public interface IPhaseFunction
    {
        /// <summary>
        /// Given the cosine of the angle between two directions
        /// returns the ratio of light for such scattering
        /// </summary>
        float Eval(float cosTheta);

        /// <summary>
        /// Generates a sample that importance sample this function for a specific direction.
        /// x ~ Eval(dot(w, x))
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        float3 ImportanceSample(float3 w);
    }

    /// <summary>
    /// Represents a volume implicitly using a ray-cast function
    /// </summary>
    public interface IGeometricVolume
    {
        /// <summary>
        /// Determines the distance along the ray where the surface is hit
        /// </summary>
        /// <returns>Distance value if exists (always positive). NaN if there is no hit to the volume</returns>
        float ClosestHit(float3 x, float3 w);

        /// <summary>
        /// Determines whenever a specific position is inside the volume.
        /// </summary>
        bool IsInside(float3 x);
    }

    public interface IEnvironment
    {
        float3 IncommingLight(float3 x, float3 w);
    }

    public struct MediaMaterial
    {
        public float Density { get; private set; }

        public float ScatteringAlbedo { get; private set; }

        public IPhaseFunction Phase { get; private set; }

        public MediaMaterial(IPhaseFunction phase, float density, float scatteringAlbedo)
        {
            this.Phase = phase;
            this.Density = density;
            this.ScatteringAlbedo = scatteringAlbedo;
        }
    }
}
