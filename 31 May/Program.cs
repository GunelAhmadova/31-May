using System;

namespace _31_May
{
    class Program
    {
        static void Main(string[] args)
        {
            // Layihe run olanda bizden say istesin. Daha sonra hemin say qeder employee  datalari daxil etmeyimizi istesin
            //butun employeeri daxil etdikden sonra filterleme aparib aparmaq
            //istemediyimi sorussun aparmaq istemesek butun employeeleri gostersin aparsaq filtirlenmis employeeleri gostersin.
            //Adı təyin olunmamış Human yaradıla bilminməz.

            Console.WriteLine("iscinin sayini daxil edin");
            int count = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i + 1 + " iscinin ad ve soyadini daxil et");
                employees[i].FullName = Console.ReadLine();
                 Console.WriteLine(i + 1 + "iscinin yasini daxil et");
                employees[i].Age = byte.Parse(Console.ReadLine());
                Console.WriteLine(i + 1 + "iscinin vezifesini daxil et");
                employees[i].Position = Console.ReadLine();
                Console.WriteLine(i + 1 + "iscinin maasini daxil et");
                employees[i].Salary = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("filtirleme aparmaq isteyirsiZ? HE=y, yox=x");
            string test = Console.ReadLine();
            if (test == "y")
            {
                Console.WriteLine("minimum maasi daxil et");
                double minsalary = double.Parse(Console.ReadLine());
                Console.WriteLine("maksimum maasi daxil et");
                double maxsalary = double.Parse(Console.ReadLine());
                for (int i = 0; i < employees.Length; i++)
                {
                    if (minsalary >= employees[i].Salary && maxsalary <= employees[i].Salary)
                    {
                        Console.WriteLine($"{employees[i].FullName}, {employees[i].Salary}" );
                    }
                 } 

            }






        }
    }
}
