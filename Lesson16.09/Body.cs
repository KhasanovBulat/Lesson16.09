using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._09
{
    class Body
    {
        public string Fio { get; set; }
        public int Age { get; set; }
        public string DeathCause { get; set; }
        public bool IsIdentified { get; set; }

        public Body(string fio, int age, string death_cause)
        {
            Fio = fio;
            Age = age;
            DeathCause = death_cause;
        }

        public void IdentificationInfo()
        {
            string type;
            if (IsIdentified)
            {
                type = "Тело было опознано";
            }
            else
            {
                type = "Тело не было опознано";
            }
            Console.WriteLine($"Опознание тела:{type}");
        }

        public void PrintTheDeathCause()
        {
            Console.WriteLine($"Причиной смерти стала {DeathCause}");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Fio: "+Fio + ", Age: " + Age);
        }


        public bool IsKillByThemself()
        {
            Random rnd = new Random();
            int val = rnd.Next(2);
            if (val == 0) return true;
            return false;
        }

    } 



}
