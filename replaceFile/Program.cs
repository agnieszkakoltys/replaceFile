using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceFile
{

    class classForProtection1
    {
        protected int x = 123;

    }

    class classForProtection2 : classForProtection1
    {

        public class Program
        {

            public class person
            {
                private String FirstName, LastName; // atrybuty prywatne

                // konstruktory
                public person(String firstName, String lastName)
                {
                    this.FirstName = firstName;
                    this.LastName = lastName;
                }
                public void showIt()
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.Write("Program napisany przez: ");
                    System.Console.Write(this.FirstName + " ");
                    System.Console.Write(this.LastName);
                }

            }


            static void Main(string[] args)
            {
                myProperty l = new myList();
                l.programWork();

                myCollection c = new myCollection();
                c.createException();

                myEnum e = new myEnum();
                e.createEnum();

                myProperty r = new myProperty();
                r.Name = "\n\n\t\t\t\tMoje propercje dzialaja";
                Console.WriteLine(r.Name);

                Interface1 i = new myProperty();
                i.myInterface();

                classForProtection1 c1 = new classForProtection1();
                classForProtection2 c2 = new classForProtection2();
                Console.Write("Owoc mojej protekcji: ");
                Console.Write(c2.x);

                person cz = new person("Agnieszka", "Koltys");
                cz.showIt();

                Console.ReadKey();
            }
        }

    }
}

