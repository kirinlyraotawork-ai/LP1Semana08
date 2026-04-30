using System;

namespace Game
{
    public abstract class Unit
    {
        public int Movement { get; set; }
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        protected Unit(int movement, int health)
        {
            Movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"A unidade moveu-se {ToRoman(Movement)} casas.");
        }

        private string ToRoman(int number)
        {
            if (number < 1 || number > 3999)
                return "Invalid Roman Number";

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return thousands[number / 1000] +
                   hundreds[(number % 1000) / 100] +
                   tens[(number % 100) / 10] +
                   ones[number % 10];
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:F2}";
        }

        
    }
}