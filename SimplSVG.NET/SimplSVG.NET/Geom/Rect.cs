using System;

namespace SimplSVG.NET.Geom
{
    public struct Rect
    {
        public Rect(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public float X;
        public float Y;
        public float Width;
        public float Height;
        public Size Size => new Size(Width, Height);
        public float Left => X;
        public float Right => X + Width;
        public float Top => Y;
        public float Bottom => Y + Height;

        public bool IsEmpty => Math.Abs(Width) < float.Epsilon && Math.Abs(Height) < float.Epsilon;

        public void Translate(float tx, float ty)
        {
            X += tx;
            Y += ty;
        }

        public void TranslateTo(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool Contains(float x, float y)
        {
            if (x < X || x > X + Width - 1f)
                return false;

            if (y < Y || y > Y + Height - 1f)
                return false;

            return true;
        }

        public bool FuzzyEq(Rect obj1, Rect obj2) =>
            Math.Abs(obj1.Width - obj2.Width) < float.Epsilon &&
            Math.Abs(obj1.Height - obj2.Height) < float.Epsilon &&
            Math.Abs(obj1.X - obj2.X) < float.Epsilon &&
            Math.Abs(obj1.Y - obj2.Y) < float.Epsilon;
    }
}
