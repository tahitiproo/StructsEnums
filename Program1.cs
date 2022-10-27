using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndStruсts
{
    class Program
    {
        public struct Alkash
        {
            public string firstName;
            public string secondName;
            public int ident;
            public string dateBirth;
            public char alkoMetr;
            public double alkogolb;
            public double dolyalk;
            public void Print1()
            {
                Console.WriteLine($"Студент {firstName} {secondName} под номером {ident}, родившийся {dateBirth}, является алкоголиком {alkoMetr} " +
                    $"степени и выпил {alkogolb} л алкоголя, что составляет {dolyalk}% от общего объёма выпитого");
                Console.WriteLine();
            }
        }
        public struct Usverb
        {
            public string firstName;
            public string town;
            public byte age;
            public uint pinCode;
            public void VivodUsverb()
            {
                Console.WriteLine($"{firstName} жил в городе {town}, его возраст составляет {age} лет и его пинкод: {pinCode}");
            }
        }
        public struct Holiday
        {
            public double normPrice;
            public double salePrice;
            public double holidayPrice;
            public void Output()
            {
                double ekonom = normPrice*(salePrice / 100);
                double viski = holidayPrice/ekonom;
                Console.WriteLine(ekonom);
                Console.WriteLine(Math.Round(viski));
            }
        }
        static double Output(double skor)
        {
            skor = skor * (100000) / 3600;
            return Math.Round(skor);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            Random rndm = new Random();
            Alkash typicalFizTech1 = new Alkash();
            Alkash typicalFizTech2 = new Alkash();
            Alkash typicalFizTech3 = new Alkash();
            Alkash typicalFizTech4 = new Alkash();
            Alkash typicalFizTech5 = new Alkash();
            typicalFizTech1.firstName = "Денис";
            typicalFizTech1.secondName = "Сабаев";
            typicalFizTech1.ident = rndm.Next(0000, 9999);
            typicalFizTech1.dateBirth = "31.12.1999";
            typicalFizTech1.alkoMetr = 'a';
            typicalFizTech1.alkogolb = 10.25;

            typicalFizTech2.firstName = "Таня";
            typicalFizTech2.secondName = "Матенцова";
            typicalFizTech2.ident = rndm.Next(0000, 9999);
            typicalFizTech2.dateBirth = "16.08.2006";
            typicalFizTech2.alkoMetr = 'b';
            typicalFizTech2.alkogolb = 3.74;

            typicalFizTech3.firstName = "Ксения";
            typicalFizTech3.secondName = "Зелёная";
            typicalFizTech3.ident = rndm.Next(0000, 9999);
            typicalFizTech3.dateBirth = "14.10.2005";
            typicalFizTech3.alkoMetr = 'с';
            typicalFizTech3.alkogolb = 1;

            typicalFizTech4.firstName = "Сергей";
            typicalFizTech4.secondName = "Пак";
            typicalFizTech4.ident = rndm.Next(0000, 9999);
            typicalFizTech4.dateBirth = "09.06.2004";
            typicalFizTech4.alkoMetr = 'a';
            typicalFizTech4.alkogolb = 7.2;

            typicalFizTech5.firstName = "Олег";
            typicalFizTech5.secondName = "Долгопрудный";
            typicalFizTech5.ident = rndm.Next(0000, 9999);
            typicalFizTech5.dateBirth = "04.04.2003";
            typicalFizTech5.alkoMetr = 'd';
            typicalFizTech5.alkogolb = 0.2;

            double sumalk = typicalFizTech1.alkogolb + typicalFizTech2.alkogolb + typicalFizTech3.alkogolb +
                typicalFizTech4.alkogolb + typicalFizTech5.alkogolb;
            typicalFizTech1.dolyalk = Math.Round(typicalFizTech1.alkogolb / sumalk * 100,2);
            typicalFizTech2.dolyalk = Math.Round(typicalFizTech2.alkogolb / sumalk * 100, 2);
            typicalFizTech3.dolyalk = Math.Round(typicalFizTech3.alkogolb / sumalk * 100, 2);
            typicalFizTech4.dolyalk = Math.Round(typicalFizTech4.alkogolb / sumalk * 100, 2);
            typicalFizTech5.dolyalk = Math.Round(typicalFizTech5.alkogolb / sumalk * 100, 2);

            typicalFizTech1.Print1();
            typicalFizTech2.Print1();
            typicalFizTech3.Print1();
            typicalFizTech4.Print1();
            typicalFizTech5.Print1();

            Console.WriteLine("Упражнение 2");
            Console.WriteLine($"Тип данных: byte, максимальное значение: {byte.MaxValue}, минимальное значение: {byte.MinValue}");
            Console.WriteLine($"Тип данных: sbyte, максимальное значение: {sbyte.MaxValue}, минимальное значение: {sbyte.MinValue}");
            Console.WriteLine($"Тип данных: short, максимальное значение: {short.MaxValue}, минимальное значение: {short.MinValue}");
            Console.WriteLine($"Тип данных: ushort, максимальное значение: {ushort.MaxValue}, минимальное значение: {ushort.MinValue}");
            Console.WriteLine($"Тип данных: int, максимальное значение: {int.MaxValue}, минимальное значение: {int.MinValue}");
            Console.WriteLine($"Тип данных: uint, максимальное значение: {uint.MaxValue}, минимальное значение: {uint.MinValue}");
            Console.WriteLine($"Тип данных: long, максимальное значение: {long.MaxValue}, минимальное значение: {long.MinValue}");
            Console.WriteLine($"Тип данных: ulong, максимальное значение: {ulong.MaxValue}, минимальное значение: {ulong.MinValue}");
            Console.WriteLine($"Тип данных: string, максимальное значение: бесконечность, минимальное значение: {null}");
            Console.WriteLine($"Тип данных: DateTime, максимальное значение: {DateTime.MaxValue}, минимальное значение: {DateTime.MinValue}");
            Console.WriteLine($"Тип данных: TimeSpan, максимальное значение: {TimeSpan.MaxValue}, минимальное значение: {TimeSpan.MinValue}");
            Console.WriteLine($"Тип данных: char, максимальное значение: {char.MaxValue}, минимальное значение {char.MinValue}");
            Console.WriteLine($"Тип данных: bool, максимальное значение: {true}, минимальное значение: {false}");
            Console.WriteLine($"Тип данных: float, максимальное значение: {float.MaxValue}, минимальное значение: {float.MinValue}");
            Console.WriteLine($"Тип данных: double, максимальное значение: {double.MaxValue}, минимальное значение: {double.MinValue}");
            Console.WriteLine($"Тип данных: decimal, максимальное значение: {decimal.MaxValue}, минимальное значение: {decimal.MinValue}");
            Console.WriteLine($"Тип данных: object, он настолько хорош, что может принимать любое значение и принимать любую форму");
            
            Console.WriteLine("Упражнение 3");
            Usverb chel = new Usverb();
            Console.Write("Введите имя: ");
            chel.firstName = Console.ReadLine();
            Console.Write("Введите город проживания: ");
            chel.town = Console.ReadLine();
            Console.Write("Введите возраст: ");
            chel.age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите пинкод: ");
            chel.pinCode = uint.Parse(Console.ReadLine());
            chel.VivodUsverb();

            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите имя и фамилию через пробел");
            string[] a = Console.ReadLine().Split(' ').Select(y=> y).ToArray();
            Console.WriteLine($"{ a[0]} { a[1]}");
            string init = a[0][0] + "." + a[1][0];
            Console.WriteLine(init);
            

            Console.WriteLine("Упражнение 5");
            Holiday otpusk = new Holiday();
            Console.WriteLine("Введите стандартную цену вискаря");
            otpusk.normPrice = short.Parse(Console.ReadLine());
            Console.WriteLine("Скидка на виски в дьютифри составляет: ");
            otpusk.salePrice = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            otpusk.holidayPrice = int.Parse(Console.ReadLine());
            otpusk.Output();
            

            Console.WriteLine("Упражнение 6");
            double skor = double.Parse(Console.ReadLine());
            Console.WriteLine(Output(skor));
            
            Console.WriteLine("Упражнение 7");
            Console.WriteLine("Введите строку: ");
            StringBuilder x = new StringBuilder(Console.ReadLine());
            for(int c = 0; c<x.Length; c++)
            {
                Console.WriteLine($"Работа с {c} элементом");
                if(char.IsLower(x[c]))
                {
                    x[c] = char.ToUpper(x[c]);
                }
                else if(char.IsUpper(x[c]))
                {
                    x[c]=char.ToLower(x[c]);
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine(x);
            
        }
    }
}
