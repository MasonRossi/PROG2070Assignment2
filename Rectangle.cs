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
            this.length = length;
            this.width = width;
        }

        // Get and Set Methods
        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        // Perimeter and Area Methods
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
