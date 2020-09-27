using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TechLeaders2020TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Program.GetNumbers();
            Console.WriteLine();
            int[] numbers = Program.GenerateArray(str);
            Console.WriteLine();
            Program.ShowResult(numbers);
            Console.ReadKey();
        }

        static string[] GetNumbers()
        {
            string str;
            int check;
            do
            {
                str = Program.ReadUserString();
                check = Program.CheckString(str);
            }
            while (check != 1);
                string[] numbers = str.Split(new char[] { ' ' });
            return (numbers);
        }

        static string ReadUserString()
        {
            return (Console.ReadLine());
        }

        static int CheckString (string str)
        {
            string[] num = str.Split(new char[] { ' ' });
            if (num.Length != 2)
                return (0);
            else if ((Convert.ToInt32(num[0]) > 100 || Convert.ToInt32(num[0]) < 0) || (Convert.ToInt32(num[1]) > 10 || Convert.ToInt32(num[1]) < 0))
                return (0);
            else
                return (1);
        }

        static int[] GenerateArray (string[] str)
        {
            int[] nums = new int[Convert.ToInt32(str[1])];
            Random rnd = new Random();
            for (int i = 0; i < Convert.ToInt32(str[1]); i++)
            {
                nums[i] = RandomizeArray(rnd, Convert.ToInt32(str[0]));
                Console.Write($"{nums[i]} ");
            }
            return (nums);
        }

        static int RandomizeArray (Random rnd, int max)
        {
            
            return (rnd.Next(-max, max));
        }

        static void ShowResult (int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (sum == 0)
                {
                    Console.Write(num);
                    sum += num;
                }
                else if (num >= 0)
                {
                    Console.Write($"+{num}");
                    sum += num;
                }
                else
                {
                    Console.Write($"-({num})");
                    sum -= num;
                }
            }
            Console.Write($" = {sum}");
            /*Возможно задание подразумевало, что итоговый результат нужно сначала собрать в сторку, а потом выводить. 
             * Но в условии это оговорено не было, а я решил, что в текущих условиях это будет излишним усложнением.*/
        }
    }
}
