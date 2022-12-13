using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Generics <T>
    {
        public void writeToConsole (T param)
        {
            System.Console.WriteLine($"Value passed to write on console is {param}");
        }

        public someType returnMe<someType> (someType value )
        {
            return value;
        }
    }

    class GenericConstraints
    {
        
        public string compareValues<T> (T value1, T value2 ) where T : struct // T must be of value type
        {
            return value1.ToString() + value2.ToString();
        }

        public void someMethod<U> (U value10) where U: new()
        {
            var temp = new U();
        }

    }


}
