using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 2, 3, -1, 24, 100 };
            var geridonsu=QuickShort(arr, 0, arr.Length);

            foreach (var item in geridonsu)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static int[] QuickShort(int[] arr,int baslangıc,int son)
        {
            if(baslangıc<son)
            {
                int pivot = Parcalama(arr, baslangıc, son);
                QuickShort(arr, baslangıc, pivot);
                QuickShort(arr, pivot + 1, son);
            }
            return arr;
        }

        public static void Takas(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }

        public static int Parcalama(int[]arr,int baslangıc,int son)
        {
            int pivoteleman = arr[baslangıc];
            int takasindex = baslangıc;
            for (int i = baslangıc+1; i < son; i++)
            {
                if(arr[i]<pivoteleman)
                {
                    takasindex++;
                    Takas(arr, i, takasindex);
                }
            }
            Takas(arr, baslangıc, takasindex);
            return takasindex;
        }
    }
}
