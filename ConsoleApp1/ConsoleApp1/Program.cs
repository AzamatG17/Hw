using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\azama\OneDrive\Documents\C#\dars13\first.txt";
            Console.WriteLine(" 1 You wont creat account");
            Console.WriteLine(" 2 You wont show users");
            Console.WriteLine(" 2 You wont delete account");
            Console.Write(" : ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: First(file); break;
                case 2: Sekond(file); break;
                case 3: Third(file); break;
                    default: Console.WriteLine(" Don`t have "); ; break;
            }
        }
        public static void First(string file)
        {
            if (File.Exists(file))
            {
                Console.WriteLine(" File have");
            }
            else
            {
                File.Create(file);
                Console.WriteLine(" file will be crate");
            }
            Console.Write(" Write full name : ");
            string name = Console.ReadLine();
            Console.Write(" Write password : ");
            int pass = int.Parse(Console.ReadLine());
            Console.Write(" Write your phone number : ");
            int phoneNum = int.Parse(Console.ReadLine());
            using (StreamWriter write = File.AppendText(file))
            {
                int user = 1;
                write.WriteLine($" User: {user}, full name: {name}, Password: {pass}, Phone number: {phoneNum}");
                user++;
            }

        }
        public static void Sekond(string file) 
        {
            Console.Write(" what your user number : ");
            int userNum = int.Parse(Console.ReadLine());
            using (StreamReader read = new StreamReader(file))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number) && number == userNum)
                    {
                        continue;
                    }

                    Console.WriteLine(line);
                }
            }
        }
        public static void Third(string file)
        {
            Console.Write(" What your user num : ");
            int userNum = int.Parse(Console.ReadLine());
            Console.Write(" What user num you wont delete : ");
            int deleteNum = int.Parse(Console.ReadLine());
            using (StreamReader read = new StreamReader(file))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number) && number == deleteNum)
                    {
                        line = null;
                    }

                    Console.WriteLine(file);
                }
            }
        }
    }
}
