using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{ 
    /// <summary>
    /// Выполнил Цубера Кристиан.
    /// </summary>
    internal class Program
    { 
       
        static void Main(string[] args)
        {
            string filename = "file.txt";
            string fileNameForAuth = "Logins_and_passwords.txt";
            int[] arr = new int[20];
            StaticClass.divideOn3(arr);//Задание 1
            StaticClass.loadArrFromFile(AppDomain.CurrentDomain.BaseDirectory + filename);
            Console.ReadLine();
            authorization(AppDomain.CurrentDomain.BaseDirectory + fileNameForAuth); //Задание 4
            Console.ReadLine();

        }
        static void authorization(string file) {                                   
            Account account = new Account();
           string[] arr = StaticClass.loadStrArrayFromFile(file);
            int count = 3;
            do
            {
                Console.WriteLine("Здравствуйте введите ваш логин");
                account.Login= Console.ReadLine();
                Console.WriteLine("Введите ваш пароль");
                account.Password= Console.ReadLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (account.Login.Equals(arr[i]) && account.Password.Equals(arr[i + 1]))
                    {
                        Console.WriteLine("Доступ разрешен");
                        count = 0;
                        break;

                    }
                    
                }
                count--;
                Console.WriteLine($"У вас осталось {count} попыток");
            }while (count > 0);

           





        }
    }
} 
