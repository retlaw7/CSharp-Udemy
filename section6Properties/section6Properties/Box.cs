using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6Properties
{
    class Box
    {
        //member variable
        private int length = 3;
        public int height;
        // public int width;
        public int volume;
        public int Width { get; set; }
        public int FrontSurface
        {
            get
            {
                return this.height * this.length;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0){
                    height = -value;
                } else {
                    height = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return this.Width * this.length * this.height;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"length is: {length}, height is {height}, width is {Width}, volume is {Volume}");
        }
        public void setLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Length needs to be higher than 0");
            }
            this.length = length;
        }
        
        public int getLength()
        {
            return this.length;
        }
    }
}
