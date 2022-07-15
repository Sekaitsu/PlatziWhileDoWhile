namespace platziWhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool continueSoftwareExecution = true;

            //while (continueSoftwareExecution=true)
            //{
            //    Console.WriteLine("Do you wish to keep the software running? whrite 1 yes , 0 if no");
            //    int value = Convert.ToInt16(Console.ReadLine());

            //    if (value == 1)
            //    {
            //        Console.WriteLine("Heey! , the software keep running");
            //    }
            //    else if (value == 0)
            //    {
            //        Console.WriteLine("Oh, the software stop running");
            //        continueSoftwareExecution = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Put a correct input, try again");
            //    }
            //}

            //si no sabemos en  que valor ingresa 

            bool continueSoftwareExecution = false;
            do
            {
                Console.WriteLine("Do you wish to keep the software running? whrite 1 yes , 0 if no");
                int value = Convert.ToInt16(Console.ReadLine());

                if (value == 1)
                {
                    Console.WriteLine("Heey! , the software keep running");
                }
                else if (value == 0)
                {
                    Console.WriteLine("Oh, the software stop running");
                    continueSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("Put a correct input, try again");
                }
            } while (continueSoftwareExecution == true);
        }
    }
}