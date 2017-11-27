using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_10_11
{
    public interface IAccount
    {        
        int getID
        { get; }
        double getBalance
        { get; }
        double getIntRate
        { get; }
    }

    public class Account : IAccount
    {
        private string owner;
        private double intrate;
        private double balance;
        private int id;
        private static int nextid = 1;
        private const int discont = 3;
        public bool Before
        {
            set
            {
                if (value) intrate -= discont;
            }
        }

        public Account(string owner, double intrate, double balance)
        {
            this.owner = owner;
            this.intrate = intrate;
            this.balance = balance;
            id = nextid++;
        }

        public string Getowner()
        {
            return owner;
        }        
        public void AddCash(double a)
        {
            balance += a;
        }
        public int getID
        {
            get
            { return id; }
        }
        public double getBalance
        {
            get
            { return balance; }
        }
        public double getIntRate
        {
            get
            { return intrate; }
        }
        public override string ToString()
        {
            return String.Format("ID: {0} \nВладелец: {1} \nПроц.ставка: {2}% \nБаланс: ${3}", id, owner, intrate, balance);
        }
    }

    public class Bank
    {
        List<Account> BankList = new List<Account>();
        public void AddAccount(params Account[] Acc)
        {
            BankList.AddRange(Acc);
            Console.WriteLine("Открыт счёт:");
            for (int i = 0; i < Acc.Length; i++)
                Console.WriteLine(Acc[i].ToString());
            Console.WriteLine();
        }

        public void DeleteAccount(bool before, Account acc)
        {
            Console.WriteLine("Закрытие счёта:");
            Console.WriteLine(acc.ToString());
            acc.Before = before;
            if (before) Console.WriteLine("Вы закрываете счёт досрочно \nДоход по досрочно закрываемому счету определится по сниженной процентной ставке");
            BankList.Remove(acc);
            double a = acc.getBalance;
            double b = acc.getIntRate;
            double c = a+a*b/100;
            Console.WriteLine("Закрыт счёт по процентной ставке {0}%, выдано со счёта ${1}", acc.getIntRate, c);
            Console.WriteLine();
        }

        public void AddCash(Account account, int a)
        {
            account.AddCash(a);
            Console.WriteLine("На счет {0} зачислено ${1}. Текущий баланс ${2} ", account.getID , a, account.getBalance);
            Console.WriteLine();
        }
        public override string ToString()
        {
            Console.WriteLine("Все счета в банке:");
            string str = "";
            for (int i = 0; i < BankList.Count; i++)
                str += String.Format(BankList[i].ToString() + "\n");
            return str; 
        }
    }

    public class StaticConstructor
    {
        public static void Main(string[] args)
        {
            Account acc1, acc2, acc3;
            Bank Bank1 = new Bank();

            Bank1.AddAccount(acc1 = new Account("Настя", 15, 0));
            Bank1.AddAccount(acc2 = new Account("Никита", 15, 0));
            Bank1.AddAccount(acc3 = new Account("Наташа", 10, 0));
            
            Console.WriteLine(Bank1.ToString());

            Bank1.AddCash(acc1, 1500);
            Bank1.AddCash(acc2, 1000);
            Bank1.AddCash(acc3, 200);

            Console.WriteLine(Bank1.ToString());

            Bank1.DeleteAccount(true, acc1);
            Bank1.DeleteAccount(false, acc2);
            Bank1.DeleteAccount(true, acc3);

            Console.WriteLine(Bank1.ToString());
            Console.ReadLine();
        }
    }
}
