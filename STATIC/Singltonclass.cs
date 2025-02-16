using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    public class Singltonclass
    {
        private static Singltonclass instance = null;
        private static readonly object padlock = new object();
        private Singltonclass()
        {
            Console.WriteLine("Singlton class constructor");
        }
        public static Singltonclass Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singltonclass();
                    }
                    return instance;
                }
            }
        }

        public void PrintCIN(string message)
        {
            Console.WriteLine(message);
        }
    }


    class Program
    {
        static void Main()
        {
            Singltonclass.Instance.PrintCIN("Hi am vhechicLe");
            Singltonclass.Instance.PrintCIN("Hi am Auto");
            Singltonclass.Instance.PrintCIN("i am driver ");
        }
    }
}
