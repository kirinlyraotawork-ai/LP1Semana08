using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Marauder : Character
    {
        public int Strenght { get; }

        public Marauder(string name, int health, int damage, int strengh) : base(name,health,damage)
        {
            Strenght = strengh;
            
        }

        public override void Describe()
        {
            Console.Write($"{base.ToString()}, Strenght: {Strenght})");
            Console.WriteLine("Attack: Earthquake!");
            //Console.WriteLine(ToString());
        }

        
/*
        public override string ToString()
        {
            return $"{base.ToString()} Strenght: {Strenght}";
        }*/
        
    }
}


    /*

        public override int Health
        {
            get { return base.Health + XP; }
            set { base.Health = value - XP; }
        }

        public override float Cost => AttackPower + XP;

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
    }
    */