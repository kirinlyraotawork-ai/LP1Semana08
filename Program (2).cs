using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main()
        {
            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(4, 10, 3),
                new SettlerUnit(),
                new MilitaryUnit(4, 4, 6),
                new MilitaryUnit(12, 16, 3),
                new SettlerUnit(),
            };

            // Unidade 0 ataca unidade 1
            (units[0] as MilitaryUnit).Attack(units[1]);
            // Unidade 0 ataca unidade 2
            (units[0] as MilitaryUnit).Attack(units[2]);
            // Unidade 2 ataca unidade 0
            (units[2] as MilitaryUnit).Attack(units[0]);
            // Unidade 2 ataca unidade 3
            (units[2] as MilitaryUnit).Attack(units[3]);
            // Unidade 2 ataca unidade 4
            (units[2] as MilitaryUnit).Attack(units[4]);
            // Unidade 3 ataca unidade 0
            (units[3] as MilitaryUnit).Attack(units[0]);

            foreach (Unit u in units)
            {
                // Chamar Move() e ver numeração romana
                u.Move();
                // "Imprimir" cada unidade
                // chamando implicitamente o método ToString() de cada uma delas
                Console.WriteLine(u);
            }

            // Output esperado:
            //
            // Moved IV positions
            // MilitaryUnit: HP=7 COST=5.00 AP=3 XP=2
            // Moved I positions
            // SettlerUnit: HP=0 COST=5.00
            // Moved IV positions
            // MilitaryUnit: HP=4 COST=9.00 AP=6 XP=3
            // Moved XII positions
            // MilitaryUnit: HP=11 COST=4.00 AP=3 XP=1
            // Moved I positions
        }
    }
}
