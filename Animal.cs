using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Animal
    {

        string _name;
        string _breed;
        int _legs;

        public string Name { get => _name; set => _name = value; }
        public string Breed { get => _breed; set => _breed = value; }
        public int Legs { get => _legs; set => _legs = value; }
    }
}
