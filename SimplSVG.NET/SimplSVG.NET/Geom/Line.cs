using System;

namespace SimplSVG.NET.Geom
{
    public struct Line
    {
        public Line(float x1, float y1, float x2, float y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public readonly float X1;
        public readonly float Y1;
        public float X2;
        public float Y2;

        public float Length
        {
            get
            {
                var x = X2 - X1;
                var y = Y2 - Y1;
                return (float)Math.Sqrt(x * x + y * y);
            }
        }

        public void SetLength(float len)
        {
            var x = X2 - X1;
            var y = Y2 - Y1;
            var len2 = Math.Sqrt(x * x + y * y);

            var x2 = (float)(X1 + x / len2);
            var y2 = (float)(Y1 + y / len2);

            X2 = X1 + (x2 - X1) * len;
            Y2 = Y1 + (y2 - Y1) * len;
        }
    }
}
