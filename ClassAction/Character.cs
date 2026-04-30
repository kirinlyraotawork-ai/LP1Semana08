using System;

namespace ClassAction
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Damage { get; }

        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public abstract void Describe();
        

        //
        public override string ToString()
        {
            return $"[{GetType().Name}] (Health: {Health} Damage: {Damage}";
        }

    //

        public virtual void Attack()
        {
            //Console.WriteLine($"[{GetType().Name}] (Health: {Health} Damage: {Damage})");
            Console.Write("Attack: ");
        }

        
    }
}