using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16._09
{
    
    class BankAccount2
    {
        //поля класса:
        public static int currNumber=1;
        private int accountNumber;
        private int balance;
        private AccountType typeOfAccount;

        public BankAccount2()
        {
            
            accountNumber = currNumber;
            currNumber++;
            
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

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
