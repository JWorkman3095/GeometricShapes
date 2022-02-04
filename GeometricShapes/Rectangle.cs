using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    public class Rectangle {

        public int Height { get; set; }
        public int Witdh { get; set; }

        public Rectangle(int height, int width) {
            Height = height;
            Witdh = width;
            
        }
        public void PrintPerimeter() {
            int perimeter = (Height + Witdh) * 2;

            Console.WriteLine($"A rectangle with a height of {Height} and width of {Witdh}" +
                $" has a permiter of {perimeter}");


        }
    }
}
