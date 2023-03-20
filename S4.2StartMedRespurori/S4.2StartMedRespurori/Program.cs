using System;

namespace S4._2StartMedRespurori
{
    class Program
    {
        static void Main(string[] args)
        {
            programMenu();

        }

        static void programMenu()
        {
            // values
            int inputNummber;
            short whatTheUserWantsToDo;
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine(
                        "\n Tipe the nummber of the thing you want to do" +
                        "\n (1):Recursion" +
                        "\n (2):finder dit tal i fatrorios " +
                        "\n (3):Recursion" +
                        "\n (0):Quit");

                    whatTheUserWantsToDo = short.Parse(Console.ReadLine());

                    switch (whatTheUserWantsToDo)
                    {
                        // Reacurson
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Rite a nummber and i wil make a Recursion on it");
                            inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine(SimpleRecursion(inputNummber));
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Rite a nummber and i wil fun a Recursion on it");
                            inputNummber = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Rite a nummber and i wil fun a Recursion on it");
                            inputNummber = int.Parse(Console.ReadLine());
                            break;

                        case 0:
                            isRunning = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Somthing vent wrong did you forget to put ind a nummber");
                }

            }
        }

        // Makes a Recursion on the nummber the user inputted
        static int SimpleRecursion(int n)
        {
            try
            {
                if (n < 3)  //returns vendon     
                    return Math.Max(n, 1);
                else // Recursive case 
                {
                    return n * SimpleRecursion(n - 1);
                }
            }
            catch (Exception) // theks if som thing goes wrong
            {

                throw;
            }
        }


    }
}
