using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopCondition = true;

            while(loopCondition)
            {
                    Console.WriteLine("Please enter first input number: ");
                    Calculate.Instance.ValueOne = Convert.ToDecimal(Console.ReadLine());  
                    Console.WriteLine("Please enter second input number: ");
                    Calculate.Instance.ValueTwo = Convert.ToDecimal(Console.ReadLine());  
                    Console.WriteLine("Addition : " + Calculate.Instance.Addition());  
                    Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());  
                    Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());  
                    Console.WriteLine("Division : " + Calculate.Instance.Division());  

                    Console.WriteLine("\n----------------------\n");  
                    Console.WriteLine("Press Q or q to exit the application. Press any other key to continue.");
                    Console.WriteLine("\n"); 
                    var selection = Console.ReadLine();
                    switch(selection){
                        case "Q":
                        case "q":
                            loopCondition = false;
                            break;
                        default:
                            break;
                    }
            }
        }  
    }  
  
    public sealed class Calculate {  
        private Calculate() {}  
        private static Calculate instance = null;  
        public static Calculate Instance {  
            get {  
                if (instance == null) {  
                    instance = new Calculate();  
                }  
                return instance;  
            }  
        }  
  
        public decimal ValueOne {  
            get;  
            set;  
        }  
        public decimal ValueTwo {  
            get;  
            set;  
        }  
  
        public decimal Addition() {  
            return Math.Round(ValueOne + ValueTwo, 2, MidpointRounding.AwayFromZero);  
        }  
  
        public decimal Subtraction() {  
            return Math.Round(ValueOne - ValueTwo, 2, MidpointRounding.AwayFromZero);  
        }  
  
        public decimal Multiplication() {  
            return Math.Round(ValueOne * ValueTwo, 2, MidpointRounding.AwayFromZero);  
        }  
  
        public decimal Division() {  
            return Math.Round(ValueOne / ValueTwo, 2, MidpointRounding.AwayFromZero);  
        }  
    }  
}  