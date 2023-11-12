using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ivan
{
    public abstract class Prism
    {
        public string Name { get; set; }

        public Prism()
        {
            Name = "";
        }

        protected Prism(string name)
        {
            Name = name;
        }

        public abstract double GetVolume();
    }
}
