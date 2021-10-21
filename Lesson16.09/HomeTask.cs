using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._09
{

    class HomeTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание");
            CremationMorgue cremationMorgue1 = new CremationMorgue("morgue1", 10, 1980, false, 10000);
            cremationMorgue1.AddBody(new Body("Иванов Пётр Иванович",61,"Инсульт"));
            cremationMorgue1.AddBody(new Body("Смирнова Мария Николаевна",76,"Инфаркт"));
            cremationMorgue1.ProcessBody();
            cremationMorgue1.ProcessBody();
            cremationMorgue1.ProcessBody();


            ScientificMorgue scientificmorgue_1 = new ScientificMorgue("Научно-исследовательское отделение морга №1", 81);
            scientificmorgue_1.AddBody(new Body("Кислов Никита Владимирович", 35, "Суицид"));
            scientificmorgue_1.AddBody(new Body("Денисова Наталья Евгеньевна", 54, "Сахарный диабет"));
            scientificmorgue_1.AddBody(new Body("Маслова Дарья Станиславовна", 40, "Ишемическая болезнь сердца"));
            scientificmorgue_1.ProcessBody();
            scientificmorgue_1.EquipmentNumber = 59;
            scientificmorgue_1.IncreaseEquipmentNumber();
            Console.WriteLine("Текущее количество оборудования:" + " " + scientificmorgue_1.EquipmentNumber);

            Console.ReadKey();


            
        }
    }
}
