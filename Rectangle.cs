using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int length, int width)
        {
            this.length = (length > 0 && length <= 1200) ? length : 1;
            this.width = (width > 0 && width <= 1200) ? width : 1;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            if (length > 0 && length <= 1200)
            {
                this.length = length;
            }
            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            if (width > 0 && width <= 1200)
            {
                this.width = width;
            }
            return this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
