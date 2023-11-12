using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ivan
{
    public class TrianglePrism : Prism
    {
        public double S { get; set; }
        public double H { get; set; }

        public TrianglePrism() : base()
        {
            S = 0;
            H = 0;
        }

        public TrianglePrism(string name, double s, double h) : base(name)
        {
            S = s;
            H = h;
        }

        public override double GetVolume()
        {
            return (S * H) / 3d;
        }

        public override string ToString()
        {
            return $"Трикутна призма. S: {S}. H: {H}. Об'єм: {GetVolume()}.";
        }

    }
}
