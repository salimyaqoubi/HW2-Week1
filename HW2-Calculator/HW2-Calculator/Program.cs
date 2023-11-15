using System;

class SimpleCalculator
{
    static void Main()
    {
        while (true)
        {

            Console.WriteLine("Welcome to the Simple Calculator!");
            Console.WriteLine("Options:\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Exit");

            int calcu = Convert.ToInt32(Console.ReadLine());

            if (calcu >= 5)
            {
                break;
            }
            Console.WriteLine("enter first operand ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Second operand ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            int[] operation = new int[4];
            operation[0] = operand1 + operand2;
            operation[1] = operand1 - operand2;
            operation[2] = operand1 * operand2;
            operation[3] = operand1 / operand2;
            string result = "";

            for (int i = 0; i <= operation.Length; i++)
            {
                if (i == calcu)
                {
                    Console.WriteLine(operation[i - 1]);
                    Console.WriteLine("Do you have another operation");
                    result = Console.ReadLine();
                }
            }

            if (result != "yes")
            {
                break;
            }
            while (false) 
            {
                Console.Write("Perform another operation? (yes/no): ");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse == "no")
                {
                    Console.WriteLine("Thank you for using the Simple Calculator!");
                }
            }
        }
    }


        }
}
