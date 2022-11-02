using System;
// using Ayush.name;//either we can add Ayush.name inside of main method or this way  

//or we use Alias for e.g

using An = Ayush.name;
using AP = Ayush.Pascalcase;
class Namespace{
    static void Main()
    {
        //  print.nm(); //Calling the method under the namespace (Ayush.name.print.nm)
        // Ayush.Pascalcase.print.nm(); //this is way to call two different methods (or)

        An.print.nm();  //we can do it even this way using Alias 
        AP.print.nm();  //this is using Alias
    }
}
namespace Ayush
{
    namespace name
    {
        class print
        {
            public static void nm() 
            {
                Console.WriteLine("this is Ayush");
            }

        }
    }
}

namespace Ayush
{
    namespace Pascalcase
    {
        class print
        {
            public static void nm()
            {
                Console.WriteLine("Pascalcase");
            }

        }
    }
}