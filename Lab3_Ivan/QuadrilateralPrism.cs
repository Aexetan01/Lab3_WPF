using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ivan
{
    public class QuadrilateralPrism : Prism
    {
        public double A { get; set; }
        public double H { get; set; }
        public QuadrilateralPrism() : base()
        {
            A = 0;
            H = 0;
        }

        public QuadrilateralPrism(string name, double a, double h) : base(name)
        {
            A = a;
            H = h;
        }


        public override double GetVolume()
        {
            return Math.Pow(A, 2) * H;
        }

        public override string ToString()
        {
            return $"Чотирикутна призма. A: {A}. H: {H}. Об'єм: {GetVolume()}.";
        }
    }
}
