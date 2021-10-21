using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            BankAccount myAccount = new BankAccount();
            myAccount.SetAccountNumber(123);
            myAccount.SetBalance(1000);
            myAccount.SetAccountType(AccountType.Credit);
            myAccount.GetInfo();


            Console.WriteLine("Упражнение 7.2");
            BankAccount2 myAccount2 = new BankAccount2();
            myAccount2.SetBalance(1000);
            myAccount2.SetAccountType(AccountType.Credit);
            myAccount2.GetInfo();

            BankAccount2 myAccount3 = new BankAccount2();
            myAccount3.SetBalance(1000);
            myAccount3.SetAccountType(AccountType.Credit);
            myAccount3.GetInfo();


            Console.WriteLine("Упражнение 7.3");
            BankAccount3 myAccount4 = new BankAccount3();
            myAccount4.SetBalance(1000);
            myAccount4.SetAccountType(AccountType.Credit);
            myAccount4.GetInfo();

            myAccount4.AddMoney(100);
            myAccount4.GetInfo();
            myAccount4.SpendMoney(2000);
            myAccount4.GetInfo();
            myAccount4.SpendMoney(1000);
            myAccount4.GetInfo();

            Console.WriteLine("Домашнее задание 7.1");
            Building House = new Building();
            Console.WriteLine("Введите количество квартир в доме");
            int flats_number = int.Parse(Console.ReadLine());
            House.SetTheFlatsNumber(flats_number);
            Console.WriteLine("Введите количество этажей в доме");
            int floors_number = int.Parse(Console.ReadLine());
            House.SetTheFloors(floors_number);
            Console.WriteLine("Введите количество подъездов в доме");
            int sections_number = int.Parse(Console.ReadLine());
            House.SetTheSectionsNumber(sections_number);
            Console.WriteLine("Введите высоту здания");
            int height = int.Parse(Console.ReadLine());
            House.SetTheHeight(height);
            House.GetInfo();

            Console.WriteLine($"Высота одного этажа: {House.CountFloorHeight()}");
            Console.WriteLine($"На одном этаже {House.CountFlatsOnFloor()} квартир");
            Console.WriteLine($"В одном подъезде {House.CountFlatsInSection()} квартир");





        }

    }
}
