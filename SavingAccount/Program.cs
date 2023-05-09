// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleProgram
{


    public abstract class Account
    {
      
        public abstract string AccountNo { get; set; }

        public virtual void BankName()
        {
            Console.WriteLine("Welcome to ABCD Bank");
        }

       
        public abstract string Deposit(double money);
        public abstract string Withdraw(double money);
    }


    public class SavingsAccount : Account
    {
        private string acccNo;
    
        public override string Deposit(double money)
        {
            return "AC type savings: Deposit transaction done sucessfully";
        }

        public override string Withdraw(double money)
        {
            return "AC type savings: Withdraw transaction done sucessfully";
        }

        
        public override string AccountNo
        {
            get
            {
                return acccNo;
            }
            set
            {
                acccNo = value;
            }
        }
    }


    class Program
    {
   
        static void Main(string[] args)
        {
            SavingsAccount objSavingsAccount = new SavingsAccount();
            objSavingsAccount.BankName();
            objSavingsAccount.AccountNo = "010110110";
            Console.WriteLine("Account Number: " + objSavingsAccount.AccountNo);
            string msg = objSavingsAccount.Deposit(1000);
            Console.WriteLine(msg);
            msg = objSavingsAccount.Deposit(500);
            Console.WriteLine(msg);
        }
    }
}