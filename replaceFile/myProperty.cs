using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceFile
{
  public class myProperty : Interface1
    {     
            private string name;
        //property
            public string Name
        {
            get { return name; }
            set { name = value; }
        }
            public void myInterface()
            {
                Console.WriteLine("\n\n\n\t\t\t\t  Moj interfejs dziala");
            }
            virtual public void programWork()
            {
            } 
    }
}
