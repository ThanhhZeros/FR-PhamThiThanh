using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Shape
    {
        float height;
        float weight;
        public float DienTich()
        {
            return height * weight;
        }
        public Shape()
        {
            height = 0;
            weight = 0;
        }
        public Shape(float height, float weight)
        {
            this.height = height;
            this.weight = weight;
        }
        ~Shape()
        {
            Console.WriteLine("Huy "+ height + " va "+ weight);
        }
    }
}
