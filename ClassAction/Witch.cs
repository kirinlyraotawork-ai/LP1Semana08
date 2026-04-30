using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Witch : Character
    {
        public int Intelligence { get; }

        public Witch(string name, int health, int damage, int intelligence) : base(name,health,damage)
        {
            Intelligence = intelligence;
            
        }
        public override void Describe()
        {
            Console.Write($"{base.ToString()}, Intelligence: {Intelligence})");
            Console.WriteLine("Attack: Essence Drain!");
            //Console.WriteLine(ToString());
        }
/*
        public override string ToString()
        {
            return $"{base.ToString()} Intelligence: {Intelligence}";
        }*/
    }
}