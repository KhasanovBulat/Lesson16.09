using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._09
{
    class ScientificMorgue : Morgue
    {
        public int EmployeesNumber { get; set; }
        public string ResearchArea { get; }
        public int EquipmentNumber { get; set; }
        

        public ScientificMorgue(string name, int employees_number)
        {
            Name = name;
            Year = 1993;
            EmployeesNumber = employees_number;
        }

        public ScientificMorgue(string name, int size, int equipment_number)
        {
            Name = name;
            EmployeesNumber = 82;
            Size = size;
            EquipmentNumber = equipment_number;
        }

        public override void ProcessBody() 
        {
            Console.WriteLine("Введите индекс тела:");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                if (index < CurrentSize() && index >= 0)
                {
                    
                    Body body1 = GetBody(index);
                    Console.WriteLine("Тело с ФИО" + body1.Fio + "было изучено");
                }
                else
                {
                    Console.WriteLine("Индекс должен быть больше 0 и меньше " + CurrentSize());
                }
            }
            else
            {
                Console.WriteLine("Индекс должен целым числом");
            }
            
        }

        

        public int IncreaseEquipmentNumber()
        {
            return EquipmentNumber++;
        }

        

        
        
    }
}
