using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp48
{
    class Program
    {
         static void Reverse_String()
        {
            string str = "Sonal";
            string reverse_str = String.Empty;
            int len = str.Length - 1;
            while(len>=0)
            {
                reverse_str = reverse_str + str[len];
                len--;
            }
            Console.WriteLine("Reverse of string:"+reverse_str);

        }

        static void Reverse_List()
        {
            List<int> Numbers = new List<int> { 1,2,4,5,6,7,9};
            Numbers.Reverse();

            foreach(var li in Numbers)
            {
                Console.Write(li+" ");
            }
        }
        static void Reverse_Array()
        {
            string[] arr = { "Sonal", "Lavi", "Deepali", "Naman", "Ashish" };
           Array.Reverse(arr);

            Console.WriteLine("Reverse of array:");
            foreach (var item in arr)
            {
                Console.Write("{0} ",item);
            }
            
        }
        static void Dup_List()
        {
            List<int> num = new List<int> { 1, 2, 9, 87, 4, 5, 6, 1, 9, 2 };

            for(int i= 0; i<=num.Count-1;i++)
            {
                for (int j = i+1; j < num.Count; j++)
                {
                    if (num[i]==num[j])
                    {
                        Console.Write(num[i]+" ");
                    }
                }
            }
        }
        static void Dup_listByLinq()
        {
            List<int> list = new List<int> { 1, 2, 9, 87, 4, 5, 6, 1, 9, 2 };

            var dup = from s in list
                      group s by s into s
                      where s.Count() > 1
                      select s.First();

            foreach (var item in dup)
            {
                Console.WriteLine(item);
            }
           
        }
        static void Dup_listByLinq1()
        {
            List<string> name = new List<string> { "sonal", "anmol", "pooja", "Amit", "anmol" };
            var dup = from s in name
                      group s by s into s
                      where s.Count() > 1
                      select s.First();
            foreach (var item in dup)
            {
                Console.WriteLine(item);
            }

        }

        static void Max_MinList()
        {
            var list = new List<int> { 1, 8, 9, 4, 3, 6, 7, 10, 8, 50 };

            Console.WriteLine(list.Max()); 
            Console.WriteLine(list.Min()); 
        }
        static void Main(string[] args)
        {
            //Reverse_String();
            // Reverse_List();
            //Reverse_Array();
            //Dup_List();
            Dup_listByLinq1();
           // Max_MinList();
            Console.ReadLine();
        }
    }
}
