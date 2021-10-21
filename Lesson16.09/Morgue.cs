using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._09
{
    abstract class Morgue
    {
        //Свойство Size

        public int Size { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }

        public bool IsPrivate { get; set; }

        List<Body> bodyList = new List<Body>();




        public abstract void ProcessBody();

        public void Print()
        {
            string type;
            if (IsPrivate)
            {
                type = "Частный";
            }
            else
            {
                type = "Государственный";
            }

            Console.WriteLine($"Название: {Name}, Тип морга: {type}, Год открытия: {Year}, Вместимость: {Size}");
        }

        public bool AddBody(Body body)
        {
            if (CurrentSize() < Size)
            {
                bodyList.Add(body);
                return true;
            }
            return false;
        }

        public int CurrentSize()
        {
            return bodyList.Count;
        }

        //удаляем тело из морга и возвращает удаленное тело
        public Body RemoveBody()
        {
            Body b = bodyList[0];
            bodyList.RemoveAt(0);
            return b;
        }

        public Body GetBody(int index)
        {
            return bodyList[index];
        }




   



    }
}
