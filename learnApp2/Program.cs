using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new[] { 3, 3, 1, 5, 6, 2 };
            var list2 = new[] { 19, 5, 22, 22, 1 };
            var result = Sort(GetUnicValues(list1, list2));
            foreach (int item in result)
                Console.WriteLine(item);
          
        }
        public static List<int> GetUnicValues(int[] list1, int[] list2)
        {
            List<int> result = new List<int>();
            int[] summOfList = list1.Concat(list2).ToArray();
            for (int i = 0; i < summOfList.Length; i++)
            {
                int copyOfItem = 0;
                for (int j = i + 1; j < summOfList.Length; j++)
                {
                    if (summOfList[i] == summOfList[j])
                    {
                        copyOfItem++;
                    }
                }
                if (copyOfItem == 0)
                {
                    result.Add(summOfList[i]);
                }
            }
            return result ;
        }
        public static List<int> Sort (List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int min = list[i];
                for (int j = i; j < list.Count; j++)
                {
                    if (min > list[j])
                    {
                        min = list[j];
                        list[j] = list[i];
                        list[i] = min;
                    }
                }
                
            }
            return list;
        }
       


    }

    }
     
    
   
