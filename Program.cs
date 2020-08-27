using System;

namespace Variables2 {
    class Program {
        static void Main (string[] args) {
            int firstNumber;
            int secondNumber;
            int result;
            
            Console.Write ("Please enter the first number");
            firstNumber = int.Parse(Console.ReadLine ());

            Console.Write ("Please, Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine ());
            result = firstNumber / secondNumber;
            Console.WriteLine ("The answer is " + result);

        }
    }
}