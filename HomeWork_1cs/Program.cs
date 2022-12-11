using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello_World
{
    internal class Program
    {
        static void PrintName(string _name, string _order = "")
        {
            Console.WriteLine("Hello, ");
            if (_order == "-")
            {
                for (int i = _name.Length - 1; i >= 0; i--)
                {
                    Console.Write(_name[i]);
                }
            }
            else
            {
                for (int i = 0; i < _name.Length; i = i + 2)
                {
                    Console.Write(_name[i]);
                }
            }

            Console.WriteLine("!");
        }

       static void Main(string[] args)
        {
            string name = "";
            string order;
            try
            {
                
                name = args[0];
                order = args[1];
            }
            catch
            {
                Console.WriteLine("Как Вас зовут?");
                name = Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Hello, ");
                for (int i = 0; i < name.Length; i++)
                {
                    Console.Write(name[i]);
                }
                Console.WriteLine("!");
                PrintName(name);
            }
            Console.ReadKey();            
       }
    }
}