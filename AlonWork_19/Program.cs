using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить:

            //    -все компьютеры с указанным процессором. Название процессора запросить у пользователя;

            //    -все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;

            //    -вывести весь список, отсортированный по увеличению стоимости;

            //    -вывести весь список, сгруппированный по типу процессора;

            //    -найти самый дорогой и самый бюджетный компьютер;

            //    -есть ли хотя бы один компьютер в количестве не менее 30 штук?

            List<PC> pc = new List<PC>()
            {
                new PC () {Num=1,  Name="Dell",      CPU="Intel",  CPU_frequency=3200,   RAM=64,   HDD=2048, GPU=11,     Price=200,     Amount=3},
                new PC () {Num=2,  Name="Asus",      CPU="AMD",    CPU_frequency=5200,   RAM=128,  HDD=4096, GPU=24,     Price=1000,    Amount=1},
                new PC () {Num=3,  Name="HP",        CPU="Intel",  CPU_frequency=2800,   RAM=16,   HDD=1024, GPU=2,      Price=70,      Amount=10},
                new PC () {Num=4,  Name="Dell",      CPU="Intel",  CPU_frequency=2800,   RAM=32,   HDD=1024, GPU=2,      Price=90,      Amount=5},
                new PC () {Num=5,  Name="HP",        CPU="AMD",    CPU_frequency=3200,   RAM=32,   HDD=1024, GPU=6,      Price=130,     Amount=5},
                new PC () {Num=6,  Name="Asus",      CPU="AMD",    CPU_frequency=5100,   RAM=512,  HDD=4096, GPU=48,     Price=2000,    Amount=1},
                new PC () {Num=7,  Name="Dell",      CPU="Intel",  CPU_frequency=3200,   RAM=16,   HDD=1024, GPU=4,      Price=60,      Amount=3},
                new PC () {Num=8,  Name="Acer",      CPU="AMD",    CPU_frequency=1800,   RAM=4,    HDD=256,  GPU=1,      Price=30,      Amount=30},
                new PC () {Num=9,  Name="Lenovo",    CPU="AMD",    CPU_frequency=2400,   RAM=8,    HDD=512,  GPU=4,      Price=50,      Amount=3},
                new PC () {Num=10, Name="Matreshka", CPU="Baykal", CPU_frequency=100500, RAM=1024, HDD=8192, GPU=100500, Price=999999,  Amount=1},
            };


            Console.WriteLine("Компьютеры с каким процессором Вас интересуют?");
            string n1 = "Intel";
            string n2 = "AMD";
            string n3 = "Baykal";
            
            Console.WriteLine("1 - Intel");
            Console.WriteLine("2 - AMD");            
            Console.WriteLine("3 - Baykal");
            
            Console.WriteLine();
            Console.WriteLine("Введите значение кода");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            
            switch (n)
            {
                case 1:
                    {
                        List<PC> pc1 = pc.Where(x => x.CPU == n1).ToList();
                        foreach (PC e in pc)
                        {
                            Console.WriteLine($"{e.Num}, {e.Name}, CPU {e.CPU}, - {e.CPU_frequency}, RAM {e.RAM}, HDD {e.HDD}, GPU {e.GPU}, Цена {e.Price}, Количество {e.Amount}");
                        }
                        Console.WriteLine();
                        break;

                    }
                case 2:
                    {
                        List<PC> pc1 = pc.Where(x => x.CPU == n2).ToList();
                        foreach (PC e in pc)
                        {
                            Console.WriteLine($"{e.Num}, {e.Name}, CPU {e.CPU}, - {e.CPU_frequency}, RAM {e.RAM}, HDD {e.HDD}, GPU {e.GPU}, Цена {e.Price}, Количество {e.Amount}");
                        }
                        Console.WriteLine();
                        break;
                    }
                case 3:
                    {
                        List<PC> pc1 = pc.Where(x => x.CPU == n3).ToList();
                        foreach (PC e in pc)
                        {
                            Console.WriteLine($"{e.Num}, {e.Name}, CPU {e.CPU}, - {e.CPU_frequency}, RAM {e.RAM}, HDD {e.HDD}, GPU {e.GPU}, Цена {e.Price}, Количество {e.Amount}");
                        }
                        Console.WriteLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка выбора");
                        break;
                    }
            }
            Console.ReadKey();

            //static void Print(List<PC> pc)
            //{
            //    foreach (PC e in pc)
            //    {
            //        Console.WriteLine($"{e.Num} {e.Name} {e.CPU} {e.CPU_frequency} {e.RAM} {e.HDD} {e.GPU} {e.Price} {e.Amount}");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
