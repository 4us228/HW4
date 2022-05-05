using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Class2
    {
        //Задание 3
        public int[] arr;
        public Class2(int size, int begin, int end)
        {
            Random r = new Random();    
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++) { arr2[i] = r.Next(begin,end); }
            this.arr = arr2;
        }
        
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < this.arr.Length; i++) { sum += this.arr[i]; }
            return sum;
        }
        public int[] Inverse()
        {
            int[] arr = new int[this.arr.Length];
            Array.Copy(this.arr, arr , arr.Length);
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = Math.Abs(arr[i]);
            }
            return arr;
        }
        public int[] Multi(int mutiply)
        {
            int[] arr = this.arr;
            for (int i = 0; i < arr.Length; i++) { 
            arr[i] *= mutiply;
            }
            return arr;

        }
    }
}
