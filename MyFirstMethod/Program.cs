using System;

namespace MyFirstMethod
{
    /// <summary>
    /// This is our project's main class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTo10();
            

        }
        
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }    
    
        static void Main(string[] args)
        {
            CountToN(3);
            CountTo10(15, 19);
        }
        /// <summary>
        /// Thsi method will print numbers from 1 to 10
        /// </summary>
        static void CountTo10()
        {
            CountTo10(10);
        }
        /// <summary>
        /// This method will print numbers from 1 to <see cref="n"/>.
        /// </summary>
        /// <param name="n"></param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// This method will print number from <cref="n1"/> to <cref="n2"/>.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

}
