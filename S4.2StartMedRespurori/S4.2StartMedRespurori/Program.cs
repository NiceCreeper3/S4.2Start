using System;

namespace S4._2StartMedRespurori
{
    class Program
    {
        // values
        #region
        static int inputNummber;

        static short whatTheUserWantsToDo;

        static bool isRunning = true;
        #endregion

        // the main program 
        #region
        // startes the progarm
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
                    // hte place werer the user sase what there want to do
                    #region
                    // viser hvad du kan i programt
                    Console.WriteLine(
                        "\n Tipe the nummber of the thing you want to do" +
                        "\n (1):Factorial" +
                        "\n (2):finder dit tal i fabonacci " +
                        "\n (3):Recursion" +
                        "\n (0):Quit");
                    // indtar brugerens walge
                    whatTheUserWantsToDo = short.Parse(Console.ReadLine());

                    // fjerner text så det ikke fylder skerm op
                    Console.Clear();
                    #endregion

                    switch (whatTheUserWantsToDo)
                    {
                        // Reacurson
                        case 1:
                            Console.WriteLine("Hello here we will take a nummber you write and times it with it self -1 and reapit ontil we get to 0");
                                

                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine($"\nThe number you get is: {Factorial(inputNummber)}");
                            break;

                        // Fibonacci
                        case 2:
                            Console.WriteLine("Rite a nummber and i wil check what nummber you getind a Fibonacci Shekvinse \n huske at Fibonathi gøre sårdan til at starte med 0 1 1 2 3 5 8 13 21 34" +
                                "\n(User warning do not write a nummmber above 40)");
                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine($" the nummber you get is: {Fibonacci(inputNummber)} \n if you go {inputNummber} rows fruge it");

                            // Tak til freija og philip
                            for (int i = 1; i <= inputNummber; i++)
                            {
                                Console.Write(Fibonacci(i) + " " );
                            }
                            break;

                        case 3:
                            Console.WriteLine("Write the path of a fille and i will print it out");
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
        #endregion

        // the things the program can do
        #region
        // Makes a Recursion on the nummber the user inputted
        static int Factorial(int nummber)
        {
            if (nummber < 2)  //returns vendon   
                return nummber;
            else // Recursive case 
            {
                return nummber * Factorial(nummber - 1);
            }
        }

        static int Fibonacci(int nummber)
        {
            //Checks if the base state has been reached,
            if (nummber < 2)
                return nummber;
            else
                return Fibonacci(nummber - 1) + Fibonacci(nummber - 2);
        }

        static int FindNummerIFibonacci(int nummber)
        {

            return 0;
        }
        #endregion
    }
}
