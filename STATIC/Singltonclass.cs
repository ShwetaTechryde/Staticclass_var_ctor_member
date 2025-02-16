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
            Console.WriteLine("Singlton class constructor");// make defult constructor private
            //1.Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
        }
        //Create a static creation method that acts as a constructor.Under the hood, this method calls the private constructor to create an object and saves it in a static field.All following calls to this method return the cached object.
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

//Pseudocode
//In this example, the database connection class acts as a Singleton.This class doesn’t have a public constructor, so the only way to get its object is to call the getInstance method. This method caches the first created object and returns it in all subsequent calls.

//// The Database class defines the `getInstance` method that lets
//// clients access the same instance of a database connection
//// throughout the program.
//class Database is
//    // The field for storing the singleton instance should be
//    // declared static.
//    private static field instance: Database

//    // The singleton's constructor should always be private to
//    // prevent direct construction calls with the `new`
//    // operator.
//    private constructor Database() is
//        // Some initialization code, such as the actual
//        // connection to a database server.
//        // ...

//// The static method that controls access to the singleton
//// instance.
//    public static method getInstance() is
//        if (Database.instance == null) then
//            acquireThreadLock() and then
//                // Ensure that the instance hasn't yet been
//                // initialized by another thread while this one
//                // has been waiting for the lock's release.
//                if (Database.instance == null) then
//                    Database.instance = new Database()
//        return Database.instance

//    // Finally, any singleton should define some business logic
//    // which can be executed on its instance.
//    public method query(sql) is
//        // For instance, all database queries of an app go
//        // through this method. Therefore, you can place
//        // throttling or caching logic here.
//        // ...

//class Application is
//    method main() is
//        Database foo = Database.getInstance()
//        foo.query("SELECT ...")
//        // ...
//        Database bar = Database.getInstance()
//        bar.query("SELECT ...")
//        // The variable `bar` will contain the same object as
//        // the variable `foo`.