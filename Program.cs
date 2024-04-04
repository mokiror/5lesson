 using System;
//чтобы каждый раз не проаписывать метод класса консоль 
using static System.Console;
using cli = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNS
{

    namespace SandBox
    {
        public class SomeClass
        {
            private string name;

            public string Name { get { return name; } }

            public SomeClass(string _name)
            {
                name = _name + " " + DateTime.Now.ToString
                    ("yyyy.MM.dd HH:mm:ss:fffff");
            }

            public override string ToString()
            {
                return "АААААААААААААААААААА";
            }
        }
    }

    public class SomeClass
    {
        private string name;

        public string Name { get { return name; } }

        public SomeClass(string _name)
        {
            name = _name + " " + DateTime.Now.ToString
                ("yyyy.MM.dd HH:mm:ss:fffff");
        }

        public override string ToString()
        {
            return "АХАХХАХАХАХАХААА";
        }
    }
}

namespace _5lesson
{

    public class SomeClass
    {
        private string name;

        public string Name { get { return name; } }

        public SomeClass(string _name)
        {
            name = _name + " " + DateTime.Now.ToString
                ("yyyy.MM.dd HH:mm:ss:fffff");
        }

        public override string ToString() { 
            return "АААААААААААААААААААА";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           /* System.Object tmp;
            object tmp2;*/
           /* List<SomeClass> list = new 
                List<SomeClass>();*/


            var obj = new SomeClass("test");
            var obj2 = new AnotherNS.SomeClass("test");
            var obj3 = new AnotherNS.SandBox.SomeClass("test");
            Console.WriteLine("тип:  " + obj.GetType() + " имя: " + obj.Name + " " + obj);
            Console.WriteLine("\nтип:  " + obj2.GetType() + " имя: " + obj2.Name + " " + obj2);
           
            cli.WriteLine("\nтип:  " + obj3.GetType() + " имя: "  + obj3.Name);

            Console.ReadKey();


        }
    }
}
