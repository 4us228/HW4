using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    //Задание 2
    static class StaticClass
    {
        #region Загрузка String из файла
        public static string[] loadStrArrayFromFile(string filename)
        {
            if (!File.Exists(filename)) throw new FileNotFoundException();

            string[] arr = new string[1000];
            StreamReader st = new StreamReader(filename);
            st.ReadLine();
            int counter = 0;
            while (!st.EndOfStream)
            {
                arr[counter++] = st.ReadLine();
            }
            st.Close();
            string[] arrAftercopy = new string[counter];
            Array.Copy(arr, arrAftercopy, counter);
            return arrAftercopy;
        }
        #endregion

        #region Загрузка int из файла
        public static int[] loadArrFromFile(string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException();

            int[] arr = new int[1000];
            StreamReader st = new StreamReader(fileName);
            st.ReadLine();
            int counter = 0;
            while (!st.EndOfStream)
            {
                arr[counter++] = int.Parse(st.ReadLine());
            }
            st.Close();
            int[] arrAftercopy = new int[counter];
            Array.Copy(arr, arrAftercopy, counter);
            return arrAftercopy;

        }
        #endregion
        //Задание 1
        public static void divideOn3(int[] arr)
        {
            Array.Clear(arr, 0, arr.Length);
            arr = new int[20];
            Random rand = new Random();
            int count = 0;
            for (int i = 0; i < arr.Length; i++) { arr[i] = rand.Next(-10_000, 10_000); }
            for (int i = 0; i < arr.Length - 1; i++) { if (arr[i] % 3 == 0 && (arr[i + 1]) % 3 != 0 || arr[i] % 3 != 0 && (arr[i] + 1) % 3 == 0) { count++; } }
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + " "); }
            Console.WriteLine();
            Console.WriteLine($"Количество пар = {count}");
        }
       
    }
}
