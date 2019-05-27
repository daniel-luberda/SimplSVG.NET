using System;

namespace SimplSVG.NET.Geom
{
    public class Geom
    {
        public static float Bound(float min, float val, float max)
        {
            if (val > max)
                return max;

            if (val < min)
                return min;

            return val;
        }


    }
}
