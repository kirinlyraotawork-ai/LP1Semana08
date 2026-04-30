using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Huntress : Character
    {
        public int Dexterity { get; }

        public Huntress(string name, int health, int damage, int dexterity) : base(name,health,damage)
        {
            Dexterity = dexterity;
            
        }
/*
        public override void Describe()
        {
            Console.Write($"{base.ToString()}, Dexterity: {Dexterity})");
            Console.WriteLine("Attack: Fangs of Frost!");
            //Console.WriteLine(ToString());
        }*/

        public override string ToString()
        {
            return $"{base.ToString()}, Dexterity: {Dexterity})";
            Console.WriteLine("Attack: Fangs of Frost!");
        }
/*
        public override string ToString()
        {
            return $"{base.ToString()} Dexterity: {Dexterity}";
        }*/
    }
}