using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    /*

      Reflection Code

      http://stackoverflow.com/questions/1825147/type-gettypenamespace-a-b-classname-returns-null
      http://www.codeproject.com/Articles/17269/Reflection-in-C-Tutorial
  */
    public class MyClass
    {
        public virtual int Add(int numb1, int numb2)
        {
            int result = numb1 + numb2;
            return result;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Class Name");

            // Create MyClass object
            Type myTypeObj = Type.GetType("ReflectionExample." + Console.ReadLine());

            Console.WriteLine("Method Name");

            // Get Method Information.
            MethodInfo myMethodInfo = myTypeObj.GetMethod(Console.ReadLine());

            object obj = Activator.CreateInstance(myTypeObj);

            Console.WriteLine("First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            object[] mParam = new object[] { a, b };
            // Get and display the Invoke method.
            Console.Write("\nFirst method - " + myTypeObj.FullName + " returns " +
                                 myMethodInfo.Invoke(obj, mParam) + "\n");
        }
    }
}
