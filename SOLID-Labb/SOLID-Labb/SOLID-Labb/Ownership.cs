using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Ownership
    {
        string _owner;
        Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Brown"),
                            new Bird("Red")};

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
        public void TransferOwner()
        {
            foreach(var animal in animals)
            {
                if (animal is Dog dog)
            {
                    dog.WhatOwner("Niklas");
                }
            }
        }
    }
}
