using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate string Del(string letter);
namespace Module08_Delegate
{
    class Program
    {
        static string word = "";
        public static string AddCharacter(string letter)
        {
            word = word + letter;
            return word;
        }
        public static string DeleteLastCharacter(string letter)
        {
            word = word.Remove(word.Length - 1);
            return word;
        }
        public static string UpperCharacter(string letter)
        {
            word = word.ToUpper();
            return word;
        }
        public static void DelegateMethod(string letter)
        {
            Console.WriteLine(word);
        }
        static void Main()
        {
            Del del = new Del(AddCharacter);
            word = del("h");
            del("i");
            del("!");
            Del del1 = new Del (UpperCharacter);
            word = del1("");
            Del del2 = new Del(DeleteLastCharacter);
            word = del2("");
            Console.WriteLine("{0}", word);
            Console.ReadKey();
        }

    }
}

