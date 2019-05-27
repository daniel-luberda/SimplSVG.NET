using System;

namespace SimplSVG.NET.Extensions
{
    public static class FloatExtensions
    {
        public static bool IsValidLength(this float value) => value > 0f;
    }
}
