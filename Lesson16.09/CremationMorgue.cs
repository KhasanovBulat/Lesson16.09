using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._09
{
    class CremationMorgue : Morgue
    {
       
        public int Price { get; } //только для чтения
        public int Income { get; set; } //для чтения и записи

        public CremationMorgue(string name, int year, int price)
        {
            Name = name;
            Size = 10;
            Year = year;
            IsPrivate = false;
            Price = price;

        }

        public CremationMorgue(string name, int size, int year, bool isPrivate, int price)
        {
            Name = name;
            Size = size;
            Year = year;
            IsPrivate = isPrivate;
            Price = price;

        }
        //переопределяем (override) родительский метод ProcessBody (меняем его реализацию)
        //ключевое слово override нужно писать для того, чтобы переопределить метод.
        public override void ProcessBody()
        {
            if (CurrentSize() > 0)
            {
                Income += Price;
                Body body = RemoveBody();
                Console.WriteLine("Тело c ФИО " + body.Fio + " было кремировано");
            }
            else
            {
                Console.WriteLine("В морге нет тел для кремирования");
            }
        }

        //возвращает доход за вычетом налогов
        public double CalcIncomeAfterTax()
        {
            return Income * 0.87;
        }



    }
}
