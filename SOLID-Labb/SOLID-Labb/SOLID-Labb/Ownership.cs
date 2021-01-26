using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Ownership
    {
        Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Brown"),
                            new Bird("Red")};
        public void TransferOwner()
        {
            if (animal is Dog dog)
            {
                dog.TransferOwner("Niklas");
            }
        }
    }
}
