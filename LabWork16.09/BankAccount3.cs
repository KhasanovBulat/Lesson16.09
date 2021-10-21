using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16._09
{
    
    class BankAccount3
    {
        //поля класса:
        public static int currNumber=1;
        private int accountNumber;
        private int balance;
        private AccountType typeOfAccount;

        public BankAccount3()
        {
            accountNumber = currNumber;
            currNumber++;
        }

        public void AddMoney(int sum)
        {
            balance += sum;
            Console.WriteLine("Счет был пополнен на " + sum);
        }

        public void SpendMoney(int sum)
        {
            if(balance >= sum)
            {
                balance -= sum;
                Console.WriteLine("Со счета было списано " + sum);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете для списания "+sum);
            }

        }




        //геттер для поля accountNumber
        public int GetAccountNumber()
        {
            return accountNumber;
        }

        //в случае одинаковых названия приоритет будет у локальных перменных
        //this нужен для оращения к полю
        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }


        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        public void SetAccountType(AccountType accountType)
        {
            typeOfAccount = accountType;
        }

        public void GetInfo()
        { 
            Console.WriteLine($"Номер счёта: {accountNumber}, Баланс: {balance}, Тип счета: {typeOfAccount}");
        }

    }
    
}
