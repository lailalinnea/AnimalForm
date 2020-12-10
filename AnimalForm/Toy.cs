using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    class Toy
    {
        private string name;

        public Toy(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            string name = this.name;
            return name;
        }
    }
}
