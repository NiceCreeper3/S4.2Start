using System;

namespace S4._2StartMedRespurori
{
    class Program
    {
        // values
        static int inputNummber;
        static short whatTheUserWantsToDo;
        static bool isRunning = true;

        static void Main(string[] args)
        {
            programMenu();
        }

        static void programMenu()
        {
            // blliver ved med at køre pogram ind til bruggeren quiter
            while (isRunning)
            {
                // makes sure no one tipes ind som thing that isent a nummber 
                try
                {
                    // viser hvad du kan i programt
                    Console.WriteLine(
                        "\n Tipe the nummber of the thing you want to do" +
                        "\n (1):Recursion" +
                        "\n (2):finder dit tal i fatrorios " +
                        "\n (3):Recursion" +
                        "\n (0):Quit");
                    // indtar brugerens walge
                    whatTheUserWantsToDo = short.Parse(Console.ReadLine());

                    // fjerner text så det ikke fylder skerm op
                    Console.Clear();

                    switch (whatTheUserWantsToDo)
                    {
                        // Reacurson
                        case 1:
                            Console.WriteLine("Rite a nummber and i wil make a Recursion on it \n huske at Fibonathi gøre sårdan");
                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine(Recursion(inputNummber));
                            break;

                        // Fibonacci
                        case 2:
                            Console.WriteLine("Rite a nummber and i wil make a Recursion on it");
                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine($" the nummber you get is: {Fibonacci(inputNummber)} if you go {inputNummber} rows fruge it");                           
                            break;

                        case 3:
                            Console.WriteLine("Rite a nummber and ");
                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine(FindNummerIFibonacci(inputNummber));   
                            break;

                        case 0:
                            isRunning = false;
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Somthing vent wrong did you forget to put ind a nummber");
                }

            }
        }

        // Makes a Recursion on the nummber the user inputted
        static int Recursion(int nummber)
        {
            try
            {
                if (nummber < 3)  //returns vendon     
                    return Math.Max(nummber, 1);
                else // Recursive case 
                {
                    return nummber * Recursion(nummber - 1);
                }
            }
            catch (Exception) // theks if som thing goes wrong
            {

                throw;
            }
        }

        static int Fibonacci(int nummber)
        {
            // hvis tallet er lavet ved vi aligevelg hvad den skal være
            if (nummber < 2)
                return 1;
            else
                return Fibonacci(nummber - 2) + Fibonacci(nummber - 1);
        }

        static int FindNummerIFibonacci(int nummber)
        {

            return 0;
        }
    }
}
