using System;
using System.Linq;

namespace L03_Array
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] ds = new string[4]{"Dinomanh","Hoang","Hung","Tien"}; // string[] ds = {"Dinomanh","Hoang","Hung","Tien"};
        //   ds[0] = "Dinomanh";
        //   ds[1] = "Hoang";
        //   ds[2] = "Hung";
        //   ds[3] = "Tien";
        //Rank: số chiều của mảng 
         int[] arr = {3,1,7,0,6,5,4,2};
         Console.WriteLine($"Length: {arr.Length}");
         Console.WriteLine($"Rank: {arr.Rank}");
         Console.WriteLine($"arr[2] = {arr.GetValue(2)}" );
         Console.WriteLine($"Min = {arr.Min()}");
         Console.WriteLine($"Max = {arr.Max()}");
         Console.WriteLine($"Sum of array: {arr.Sum()} ");
         
        //Duyệt mảng:
        //C1:
         Array.ForEach<int>(arr,(int i) =>{
         Console.Write(i);
          Console.Write(" ");
         });
         Console.WriteLine();
         //C2:
         for(int i = 0;i < arr.Length;i++){
            Console.Write(arr[i]);
            Console.Write(" ");
         }

         Console.WriteLine();
        //Sắp xếp mảng:
        Array.Sort(arr);
         Array.ForEach<int>(arr,(int i) =>{
         Console.Write(i);
          Console.Write(" ");
         });
        Console.WriteLine();

        int k = Array.BinarySearch(arr,8);
        if(k > 0){
            Console.WriteLine("Found");
        }
        else
           Console.WriteLine("Not Found");

        }
    }
}
