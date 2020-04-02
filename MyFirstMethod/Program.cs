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
    
    }

}
