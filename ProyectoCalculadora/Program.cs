using NCalc;

namespace Calculator
{
    class Calculadora
    {

        //This variable controls the result of any operation
        double resultado;

        //This variable ask if an operation was realized 
        bool addedQuestion = false;

        //This variable controls the exit of the iteration to input numbers
        string? exitIteration;

        //This variable is for the numbers that i add to make operations
        double tempNumber;

        string text = @" 

            ▄████▄   ▄▄▄       ██▓     ▄████▄   █    ██  ██▓    ▄▄▄     ▄▄▄█████▓ ▒█████   ██▀███  
            ▒██▀ ▀█  ▒████▄    ▓██▒    ▒██▀ ▀█   ██  ▓██▒▓██▒   ▒████▄   ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒
            ▒▓█    ▄ ▒██  ▀█▄  ▒██░    ▒▓█    ▄ ▓██  ▒██░▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒
            ▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██░    ▒▓▓▄ ▄██▒▓▓█  ░██░▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄  
            ▒ ▓███▀ ░ ▓█   ▓██▒░██████▒▒ ▓███▀ ░▒▒█████▓ ░██████▒▓█   ▓██▒ ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒
            ░ ░▒ ▒  ░ ▒▒   ▓▒█░░ ▒░▓  ░░ ░▒ ▒  ░░▒▓▒ ▒ ▒ ░ ▒░▓  ░▒▒   ▓▒█░ ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░
            ░  ▒     ▒   ▒▒ ░░ ░ ▒  ░  ░  ▒   ░░▒░ ░ ░ ░ ░ ▒  ░ ▒   ▒▒ ░   ░      ░ ▒ ▒░   ░▒ ░ ▒░
            ░          ░   ▒     ░ ░   ░         ░░░ ░ ░   ░ ░    ░   ▒    ░      ░ ░ ░ ▒    ░░   ░ 
            ░ ░            ░  ░    ░  ░░ ░         ░         ░  ░     ░  ░            ░ ░     ░             
            ░                          ░                                                            

";

        static void Main()
        {
            Calculadora calc = new();
            calc.Menu();
        }


        public void Menu()
        {
            // This variable controls the Menu
            int op = 1;

            Calculadora calc = new();
           

            while (op != 0)
            {
                //Si el numero elegido es 0, pido que introduzca un numero

                //Change the color of the console letters
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("What would you like to do? \n | 0-Exit \n | 1-Sum \n | 2-Multiplication \n | 3-Division \n | 4-Substract \n | 5-Result \n | 6-Operation \n | 7-Square \n");
                //Controls the Menu
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    op = 0;
                    Menu();
                }



                switch (op)
                {

                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@"
  ▄████  ▒█████   ▒█████  ▓█████▄  ▄▄▄▄ ▓██   ██▓▓█████  ▐██▌ 
 ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌▓█████▄▒██  ██▒▓█   ▀  ▐██▌ 
▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░██   █▌▒██▒ ▄██▒██ ██░▒███    ▐██▌ 
░▓█  ██▓▒██   ██░▒██   ██░░▓█▄   ▌▒██░█▀  ░ ▐██▓░▒▓█  ▄  ▓██▒ 
░▒▓███▀▒░ ████▓▒░░ ████▓▒░░▒████▓ ░▓█  ▀█▓░ ██▒▓░░▒████▒ ▒▄▄  
 ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓███▀▒ ██▒▒▒ ░░ ▒░ ░ ░▀▀▒ 
  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒ ▒░▒   ░▓██ ░▒░  ░ ░  ░ ░  ░ 
░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░  ░    ░▒ ▒ ░░     ░       ░ 
      ░     ░ ░      ░ ░     ░     ░     ░ ░        ░  ░ ░    
                           ░            ░░ ░                  
");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Designed by dest92");
                        break;

                    case 1:

                        Console.Clear();
                        calc.Sum();
                        break;


                    case 2:

                        calc.Multiplication();

                        break;

                    case 3:
                        calc.Division();
                        break;


                    case 4:
                        calc.Substract();
                        break;

                    case 5:
                        Console.Clear();
                        calc.Solve();
                        break;

                    case 6:
                        calc.CalcReal();
                        break;

                    case 7:
                        calc.squareRoot();
                        break;
                }
            }

        }

        public void Sum()
        {


            Console.WriteLine("Input numbers to sum: ");
            Console.WriteLine("To back to the menu, input F");


            do
            {
                exitIteration = Console.ReadLine();
                try
                {


                    tempNumber = double.Parse(exitIteration);

                    if (tempNumber is double)
                    {
                        resultado += tempNumber;

                    }

                }
                catch (FormatException e)
                {
                    if (exitIteration != "F" && exitIteration != "f")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                }


            } while (exitIteration != "F" && exitIteration is not "f");

            Console.Clear();
        }



        public void Substract()
        {

            Console.WriteLine("Input numbers to substract: ");
            Console.WriteLine("Input F to exit");


            do
            {

                exitIteration = Console.ReadLine();
                try
                {
                    tempNumber = double.Parse(exitIteration);

                    if (addedQuestion == false && tempNumber is double)
                    {
                        resultado += tempNumber;
                    }

                    if (addedQuestion == true && tempNumber is double)
                    {
                        resultado -= tempNumber;
                    }


                }
                catch (Exception e)
                {
                    if (exitIteration != "F" && exitIteration != "f")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }

                addedQuestion = true;


            } while (exitIteration is not "F" && exitIteration is not "f");
            Console.Clear();

        }

        public void Multiplication()
        {
            Console.WriteLine("Input numbers to multiply");
            Console.WriteLine("Input F to exit");

            do
            {
                exitIteration = Console.ReadLine();
                try
                {
                    tempNumber = double.Parse(exitIteration);
                    if (addedQuestion == false && tempNumber is double)
                    {
                        resultado += tempNumber;
                    }


                    if (addedQuestion == true && tempNumber is double)
                    {

                        resultado *= tempNumber;
                    }

                }
                catch (Exception e)
                {
                    if (exitIteration != "F" && exitIteration != "f")
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }

                addedQuestion = true;
            } while(exitIteration is not "F" && exitIteration is not "f");
            Console.Clear();

        }

        public void Division()
        {
            Console.WriteLine("Input numbers to divide");
            Console.WriteLine("Input F to exit");

            do
            {
                exitIteration = Console.ReadLine();
                try
                {
                    tempNumber = double.Parse(exitIteration);

                    if(addedQuestion == false)
                    {
                        resultado += tempNumber;
                    }
                   
                    if (addedQuestion == true && tempNumber is double)
                    {

                        resultado /= tempNumber;
                    }

                }
                catch (Exception e)
                {
                    if (exitIteration != "F" && exitIteration != "f")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message + "\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }

                addedQuestion = true;
            } while (exitIteration is not "F" && exitIteration is not "f");
            Console.Clear();
        }

        public void Solve()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(String.Concat("\n", $"El resultado es: {resultado}", "\n"));
            Console.ForegroundColor = ConsoleColor.Cyan;
            resultado = 0;
            //numerosElegidos = 0;
            addedQuestion = false;

        }


        public void CalcReal()
        {

            Console.Clear();

            //Pedir la operación
            Console.WriteLine("Input the operation");

            //Variable thats ward the operation
            string operacion = Console.ReadLine();

            Expression e = new(operacion);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Result of {0}: " + e.Evaluate(),operacion);
            Console.ForegroundColor = ConsoleColor.Cyan;
        
        }


        public void squareRoot()
        {

            Console.WriteLine("Input the numbers or operation to solve square root");


            string operacion = Console.ReadLine();
            string square;
            try
            {
                square = "Sqrt(" + operacion + ")";
                Expression e = new(square);
                Console.Clear();
                Console.WriteLine("Root of {0}: " + e.Evaluate() + "\n",operacion);

                

            }
            catch (Exception d)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error:" + d.Message);
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
    }
}