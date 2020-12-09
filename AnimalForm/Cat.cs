using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base()
        {
            /*initiera attributen i objektet*/

            SetSpecies(SPECIES.CAT); // CAT=0, DOG=1, BIRD=2
            SetCanFly(false);
            SetName(name);
            SetAge(age);

        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Meow. I am a cat named " + GetName());
            base.IntroduceYourself();
        }
    }
}
