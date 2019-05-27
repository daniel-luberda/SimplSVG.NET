using System;

namespace SimplSVG.NET.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsDefault<T>(this T obj) => obj == default;
    }
}
