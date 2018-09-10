using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleArea
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get 
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left
                && Right <= other.Right
                && Bottom <= other.Bottom
                && Top >= other.Top;
        }
    }
}
