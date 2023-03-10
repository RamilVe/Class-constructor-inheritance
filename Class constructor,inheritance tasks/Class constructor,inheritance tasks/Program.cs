using System;
using System.Reflection.Metadata;
using System.Reflection;

namespace Class_constructor_inheritance_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazi daxil edin: ");
            string text = Console.ReadLine();

            FixSentence(ref text);

            Console.WriteLine(text);
            Console.WriteLine(FindWordsCount(text));

            int[] numbers = { 1, 2, 3 };

            Add(ref numbers, 44);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            string[] fullnames = { "Hikmet Abbasov", "Tofiq Qulamov", "Nermin Memmedov" };

            var names = MakeFirstNameArr(fullnames);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            
            Car car1 = new Car
            {

                FuelCapacity = 100,
                CurrentFuel= 30
            };

            Console.WriteLine("Nece litr benzin elave etmek isteyirsiniz?");
            var fuelStr = Console.ReadLine();
            var fuel = Convert.ToInt32(fuelStr);
            car1.AddFuel(fuel);
            Console.WriteLine(car1.CurrentFuel);
        }

        //Dərsdə yazdıqlarımızı tam şəkildə yazmaq
        static void FixSentence(ref string str)
        {
            str = str.Trim();
            string newStr = "";

            var arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    if (newStr != "")
                        newStr += ' ';

                    newStr += arr[i];
                }
            }

            str = newStr;
        }

        static int FindWordsCount(string str)
        {
            FixSentence(ref str);
            return str.Split(' ').Length;
        }

        static void Add(ref int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }

        static string[] MakeFirstNameArr(string[] fullnames)
        {
            string[] arr = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                int firstSpaceIndex = fullnames[i].IndexOf(' ');
                arr[i] = fullnames[i].Substring(0, firstSpaceIndex);
            }

            return arr;
        }

        static bool IsCapitalized(string str)
        {
            if (!Char.IsUpper(str[0]))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLower(str[i]))
                    return false;
            }


            return true;
        }

        static bool IsFullname(string str)
        {
            var words = str.Split(' ');

            if (words.Length != 2)
                return false;

            if (!IsCapitalized(words[0]) || !IsCapitalized(words[1]))
                return false;

            return true;
        }

    }
}
