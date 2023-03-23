using Pastel;
using System;
using System.IO;

namespace S4._2StartMedRespurori
{
    class Program
    {
        // values
        #region
        static int _inputNummber;

        static short _whatTheUserWantsToDo;

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
                        "\n (3):Reads the name of evrithing ind the file" +
                        "\n (0):Quit");
                    // indtar brugerens walge
                    _whatTheUserWantsToDo = short.Parse(Console.ReadLine());

                    // fjerner text så det ikke fylder skerm op
                    Console.Clear();
                    #endregion

                    switch (_whatTheUserWantsToDo)
                    {
                        // Reacurson
                        case 1:
                            Console.WriteLine("Hello here we will take a nummber you write and times it with it self -1 and reapit ontil we get to 0");
                                

                            _inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine($"\nThe number you get is: {Factorial(_inputNummber)}");
                            break;

                        // Fibonacci
                        case 2:
                            Console.WriteLine("Rite a nummber and i wil check what nummber you getind a Fibonacci Shekvinse \n huske at Fibonathi gøre sårdan til at starte med 0 1 1 2 3 5 8 13 21 34" +
                                "\n(User warning do not write a nummmber above 40)");
                            _inputNummber = int.Parse(Console.ReadLine());

                            Console.WriteLine($" the nummber you get is: {Fibonacci(_inputNummber)} \n if you go {_inputNummber} rows fruge it");

                            // Tak til freija og philip
                            for (int i = 1; i <= _inputNummber; i++)
                            {
                                Console.Write(Fibonacci(i) + " " );
                            }
                            break;

                        case 3:
                            ReadFile(@"C:\Users\alex407b\Desktop\S\S4.2\S4.2Start");   
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dir"></param>
        private static void ReadFile(string dir)
        {
            Console.WriteLine(dir.Pastel("#0098c4"));
            // Sages the name of alle the filles ind the folder
            string[] files = Directory.GetFiles(dir);
            foreach (string f in files)
            {
                // removes the linke we usede to finde the fille so it lookes better
                string removeUslesExtra = f.Remove(0, dir.Length);
                Console.WriteLine("\t" +removeUslesExtra.Pastel("#91e6ff"));
            }

            /// <summary>
            /// takes all folderes/Directories if there are eni. 
            /// and if there is it runs this methoed Agien and keaps doving it over and over agien ontel therer are no more folderes/Directories
            /// </summary>
            string[] dirs = Directory.GetDirectories(dir);
            foreach (string d in dirs)
            {
                Console.WriteLine();
                ReadFile(d);
            }

        }
        #endregion
    }
}
