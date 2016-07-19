using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceFile
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    class myEnum : myCollection
    {

        virtual public void createEnum()
        {
            Console.WriteLine("\n\n\n\n\t\t\t\t      Moje enum");
            //enum
            int a = (int)Days.Monday;
            int b = (int)Days.Tuesday;
            int c = (int)Days.Wednesday;
            int d = (int)Days.Thursday;
            int e = (int)Days.Friday;
            int f = (int)Days.Saturday;
            int g = (int)Days.Sunday;

            Console.WriteLine("\n\n\n\t\tMonday = {0}", a); 
            Console.WriteLine("\n\t\tTuesday = {0}", b);
            Console.WriteLine("\n\t\tWednesday = {0}", c);
            Console.WriteLine("\n\t\tThursday = {0}", d);
            Console.WriteLine("\n\t\tFriday = {0}", e);
            Console.WriteLine("\n\t\tSaturday = {0}", f);
            Console.WriteLine("\n\t\tSunday = {0}", g);                   
        }         
    }
}
