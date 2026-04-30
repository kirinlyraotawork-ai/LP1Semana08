using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Templar : Character
    {
        public int Strenght { get; }
        public int Intelligence { get; }

        public Templar(string name, int health, int damage, int strenght, int intelligence) : base(name,health,damage)
        {
            Strenght = strenght;
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            Console.Write($"{base.ToString()}, Strenght: {Strenght}, Intelligence: {Intelligence})");
            Console.WriteLine("Attack: Divine Blast!");
            //Console.WriteLine(ToString());
        }
/*
        public override string ToString()
        {
            return $"{base.ToString()} Strenght: {Strenght}, Intelligence: {Intelligence}";
        }
        */
    }
}