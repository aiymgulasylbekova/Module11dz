using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников:");
            int n = int.Parse(Console.ReadLine());
            Employee[] arr = new Employee[n];// создание массива типа Employee
            for (int i = 0; i < n; i++)//заполнение данных первого сотрудника, с которым далее будет сравниваться год приема на работу
            {
                arr[i].date = new int[3];
                if (i == 0)
                {
                    Console.WriteLine("Введите информацию о  0 сотруднике");
                    Console.WriteLine("Введите имя");
                    arr[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите должность 1-Менеджер, 2-Секретарь");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1": arr[i].Position = Positions.Manager; break;
                        case "2": arr[i].Position = Positions.Secretary; break;
                    }
                    Console.WriteLine("Введите зарплату");
                    arr[i].Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите день приема на работу");
                    arr[i].Day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите месяц приема на работу");
                    arr[i].Month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите год приема на работу");
                    arr[i].Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите пол");
                    arr[i].Gender = Console.ReadLine();

                }
                else 
                { 
                    Console.WriteLine("Введите информацию о " + i + " сотруднике");
                    Console.WriteLine("Введите имя");
                    arr[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите должность 1-Менеджер, 2-Секретарь ");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1": arr[i].Position = Positions.Manager; break;
                        case "2": arr[i].Position = Positions.Secretary; break;
                    }
                    Console.WriteLine("Введите зарплату");
                    arr[i].Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите день приема на работу");
                    arr[i].Day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите месяц приема на работу");
                    arr[i].Month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите год приема на работу");
                    arr[i].Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите пол");
                    arr[i].Gender = Console.ReadLine();
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    Employee temp;
                    if (arr[j].Name.CompareTo(arr[j + 1].Name) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            bool check = true;
            do
            {
                Console.WriteLine("1- вывести информацию о сотрудниках; 2 - менеджеры, по зарплате; 3 - принятые после первого сотрудника; 4 - сотрудники мужчины; 5- сотрудники женщины") ;
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        {
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine(arr[i].ToString());
                            }
                        }
                        break;
                    case "2":
                        {
                            double midSalary = 0;
                            int s = 0;
                            for (int i = 0; i < n; i++)
                            {
                                if (arr[i].Position == Positions.Secretary)
                                {
                                    midSalary = +arr[i].Salary;
                                    s++;
                                }
                            }
                            midSalary = midSalary / n;
                            for (int i = 0; i < n; i++)
                            {
                                if (arr[i].Position == Positions.Manager && arr[i].Salary > midSalary)
                                {
                                    Console.WriteLine("Имя менеджера " + arr[i].Name + "  Зарплата - " + arr[i].Salary + "  Дата приема на работу - " + arr[i].Day + "." + arr[i].Month + "." + arr[i].Year);
                                }
                            }
                        }
                        break;
                    case "3":
                        {
                            for (int i = 1; i < n; i++)
                            {
                                if (arr[i].Year > arr[0].Year) Console.WriteLine(arr[i].ToString());
                                else
                                {
                                    if (arr[i].Month > arr[0].Month) Console.WriteLine(arr[i].ToString());
                                    else
                                    {
                                        if (arr[i].Day > arr[0].Day) Console.WriteLine(arr[i].ToString());
                                    }
                                }
                            }
                        }
                        break;
                    case "4":
                        {
                            for(int i=0; i<n; i++)
                            {
                                if (arr[i].Gender == "man")
                                {
                                    Console.WriteLine("Мужчины:"+ arr[i]);
                                }
                        
                            }
                        }
                        break;
                    case "5":
                        {
                            for(int i=0; i<n; i++)
                            {
                                if (arr[i].Gender == "women")
                                {
                                    Console.WriteLine("Женщины:" + arr[i]);
                                }
                            }
                        }
                        break;
                    default: check = false; break;
                }
            }
            while (check);
            Console.ReadLine();
        }
    }
    enum Positions { Manager, Secretary};//перечисление
}