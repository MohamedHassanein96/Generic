namespace GenericTask2
{
    internal class Program
    {
        static void Main()

        {
            //bool IsEqual = Calcultor.AreEqual(10, 20);
            bool IsEqual = Calcultor.AreEqual("abc", "abc");
            //bool IsEqual = Calcultor.AreEqual(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            

        } 
    }class Calcultor()
    {
       public static bool AreEqual(int a, int b)
        {
            return a == b;
        }
        public static bool AreEqual(string a, string b)
        {
            return a == b;
        }
        public static bool AreEqual(double a, double b)
        {
            return a == b;
        }
    }
}

