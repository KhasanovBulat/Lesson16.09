 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16._09
{
   
    class BankAccount
    {
        //поля класса:
        private int accountNumber = 123456;
        private int balance;
        private AccountType typeOfAccount;


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
