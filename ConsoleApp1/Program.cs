using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main()
        {
            //bool IsEqual = Calculator<int>.AreEqual(10, 10);
            //bool IsEqual = Calculator<string>.AreEqual("ABC", "ABC");
            bool IsEqual = Calculator<double>.AreEqual(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
            
        }
        
    }
}