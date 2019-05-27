using System;

namespace SimplSVG.NET.Geom
{
    public readonly struct Size
    {
        public Size(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public readonly float Width;
        public readonly float Height;

        public bool IsEmpty => Math.Abs(Width) < float.Epsilon && Math.Abs(Height) < float.Epsilon;

        public Rect ToRect(float x, float y) => new Rect(x, y, Width, Height);

        public bool FuzzyEq(Size obj1, Size obj2) =>
            Math.Abs(obj1.Width - obj2.Width) < float.Epsilon && 
            Math.Abs(obj1.Height - obj2.Height) < float.Epsilon;
    }
}