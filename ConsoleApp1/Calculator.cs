using System.ComponentModel.Design;
using System.Numerics;

namespace ConsoleApp1
{
    internal partial class Program
    {
        //class Calculator<T> where T :  INumber<T> 


        //{
           
        //   public static  bool AreEqual<T> (T n1 , T n2) where T: INumber<T> 
        //    {
        //        return (n1 == n2);
        //    }
        //    public static bool AreEqual(string s1, string s2) 
        //    {
        //        return (s1 == s2);
        //    }
        //}
        class Calculator
        {
            public static bool AreEqual<T>(T V1,T V2)
            {
                if (V1.Equals(V2))
                {
                    return true;
                }
                else return false;
            }
        }
        
    }
}