using System;

namespace _23may_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1 
            ////-verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiyi indexi tapan alqoritm(binary search)
            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23 };
            ////int n = 16;
            ////int min = 0;
            ////int max = numbers.length - 1;
            ////int index = 0;

            ////while (min <= max)
            ////{
            ////    int mid = (min + max) / 2;
            ////    if (numbers[mid] == n)
            ////    {

            ////        console.writeline(mid);
            ////        break;
            ////    }
            ////    else if (n > numbers[mid])

            ////        min = mid + 1;

            ////    else
            ////        max = mid - 1;



            //}


            #endregion
            // Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritm
            //int[] numbers = { 23, 35, 23, 2, 54, 56, 562, 3, 12 };
            //for (int i = 0; i < numbers.Length - 1; i++)
            //    for (int j = 0; j < numbers.Length - i - 1; j++)
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            int temp = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = temp;
            //        }




            //for (int b = 0; b < numbers.Length; b++)
            //{
            //    Console.WriteLine(numbers[b]);
            //}




            //Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub olmadığını tapan alqoritm.Yəni birinci array-dəki ədədlərin hamısı 2ci array-də də varsa true çıxır output-a , hər hansısa biri yoxdursa false

            //int[] numbers = { 1, 3, 2, };
            //int[] numbers2 = { 4, 5, 1, 3, 6, 7 };

            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers2.Length; j++)
            //        if (numbers[i] == numbers2[j])
            //        {

            //            count++;
            //            break;
            //        }
            //}

            //if (count == numbers.Length)
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");



        }
    }
}
    



