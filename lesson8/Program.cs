using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static int Verification() //проверка на  исключения
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        static byte Verification2() //проверка на  исключения
        {
            byte n = 0;
            if (byte.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        //метод для задания 2
        static string Reversing(string word)
        {
            char[] word_array = word.ToCharArray();
            Array.Reverse(word_array);
            string reverse_word = new string(word_array);
            return reverse_word;
        }

        //метод для задание 4
        public static bool IsRealezatingIFormatable(Object obj)
        {
            if (obj is IFormattable)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("task 8.1");
            Bank_account person1 = new Bank_account();
            Bank_account person2 = new Bank_account();
            Console.WriteLine("Введите баланс первого счета");
            Console.WriteLine("Введите баланс второго счета");
            int balance1 = Verification();
            person1.Setbalance(balance1);
            int balance2 = Verification();
            person2.Setbalance(balance2);
            Console.WriteLine("Баланс первого счета: " + person1.Getbalance());
            Console.WriteLine("Баланс второго счета: " + person2.Getbalance());
            Console.WriteLine("Какую сумму вы хотите перевести");
            int sum = Verification();
            Console.WriteLine("С какого счета вы хотите перевести средства(1 или 2) ");
            switch (Verification2())
            {
                case 1:
                    Console.Write("Баланс второго счета после операции: ");
                    person1.Transfer(ref person1, sum, balance1, balance2);
                    break;

                case 2:
                    Console.Write("Баланс первого счета после операции: ");
                    person2.Transfer(ref person2, sum, balance2, balance1);
                    break;
                default:
                    Console.WriteLine("Неверно указан счет");
                    break;
            }
            Console.WriteLine("task 8.2");
            Console.WriteLine("Введите ваше слово");
            string input = Console.ReadLine();
            string output = Reversing(input);
            Console.WriteLine(output);
            Console.WriteLine("task 8.3");
            Console.WriteLine("Введите имя файла");
            string search_ = Console.ReadLine();
            if (File.Exists(search_))
            {
                File.WriteAllText(search_,File.ReadAllText(search_).ToUpper());
                foreach (char c in File.ReadAllText(search_)) 
                {
                    Console.Write(c);
                }                   
            }
            else
            {
                Console.WriteLine("Такого файла не существует");
            }
            Console.WriteLine(" ");
            Console.WriteLine("task 8.4");
            if (IsRealezatingIFormatable(new Test()))
            {
                Console.WriteLine("Наследуется");
            }
            else 
            {
                Console.WriteLine("Не наследуется");
            }














        }
    }
}
