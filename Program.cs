using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTumakov
{
    class Program
    {
        enum BankAcc
        {
            Savings = 01,
            Current = 10,
        }
        struct InfAboutAcc
        {
            public int accNumber;
            public string bankAcc;
            public double balance;
            public void Print()
            {
                Console.WriteLine($"Номер счёта: {accNumber}, Тип счёта: {bankAcc}, Баланс счёта: {balance}");
            }
        }
        enum HEIs
        {
            КФУ,
            КАИ,
            КХТИ,
        }
        struct Rab
        {
            public string secondName;
            public HEIs univer;
            public void Vivod()
            {
                Console.WriteLine($"Фамилия работника: {secondName}, ВУЗ работника: {univer}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            BankAcc account = BankAcc.Savings;
            Console.WriteLine((int)account);
            Console.WriteLine("Упражнение 3.2");
            InfAboutAcc myacc = new InfAboutAcc();
            Console.Write("Введите номер банковского счёта: ");
            myacc.accNumber = int.Parse(Console.ReadLine());
            myacc.bankAcc = "Текущий";
            Console.Write("Введите баланс банковского счёта(ввод дробных значений осуществляйте через запятую): ");
            myacc.balance = double.Parse(Console.ReadLine());
            myacc.Print();
            Console.WriteLine("Домашнее задание 3.1");
            Rab muzhik = new Rab();
            Console.WriteLine("Введите фаилию работника: ");
            muzhik.secondName = Console.ReadLine();
            muzhik.univer = HEIs.КФУ;
            muzhik.Vivod();
        }
    }
}
