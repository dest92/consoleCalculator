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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("What would you like to do? \n | 0. Exit \n | 1. Sum \n | 2. Multiplication \n | 3. Division \n | 4. Substract \n | 5. Result \n | 6. Operation \n | 7. Square \n | 8. Matrix Calculator");
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


                    case 8:
                        Console.Clear();
                        calc.matrixCalculator();
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




        public void matrixCalculator()
        {



            int[] matrix;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                            ███▄ ▄███▓ ▄▄▄     ▄▄▄█████▓ ██▀███   ██▓▒██   ██▒
                            ▓██▒▀█▀ ██▒▒████▄   ▓  ██▒ ▓▒▓██ ▒ ██▒▓██▒▒▒ █ █ ▒░
                            ▓██    ▓██░▒██  ▀█▄ ▒ ▓██░ ▒░▓██ ░▄█ ▒▒██▒░░  █   ░ 
                            ▒██    ▒██ ░██▄▄▄▄██░ ▓██▓ ░ ▒██▀▀█▄  ░██░ ░ █ █ ▒ 
                            ▒██▒   ░██▒ ▓█   ▓██▒ ▒██▒ ░ ░██▓ ▒██▒░██░▒██▒ ▒██▒
                            ░ ▒░   ░  ░ ▒▒   ▓▒█░ ▒ ░░   ░ ▒▓ ░▒▓░░▓  ▒▒ ░ ░▓ ░
                                                                        
                                                   
");
            Console.WriteLine(@"
            ▄████▄   ▄▄▄       ██▓     ▄████▄   █    ██  ██▓    ▄▄▄     ▄▄▄█████▓ ▒█████   ██▀███  
           ▒██▀ ▀█  ▒████▄    ▓██▒    ▒██▀ ▀█   ██  ▓██▒▓██▒   ▒████▄   ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒
           ▒▓█    ▄ ▒██  ▀█▄  ▒██░    ▒▓█    ▄ ▓██  ▒██░▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒    
           ▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██░    ▒▓▓▄ ▄██▒▓▓█  ░██░▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄  
           ▒ ▓███▀ ░ ▓█   ▓██▒░██████▒▒ ▓███▀ ░▒▒█████▓ ░██████▒▓█   ▓██▒ ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒
     
 

                                                        
");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n" + "Input the total rows of the matrix");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the total columns of the matrix");
            int columns = int.Parse(Console.ReadLine());

            matrix = new int[rows * columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Input the number of the row {0} and column {1}", i, j);
                    matrix[i * columns + j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i * columns + j] + " ");
                }
                Console.WriteLine();
                
            }

            int option = 0;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Input the operation to do with the matrix");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Sum");
                Console.WriteLine("2. Substract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Transpose");
                Console.WriteLine("6. Determinant");
                Console.WriteLine("7. Inverse");



                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 0:

                        
                        break;


                        
                    case 1:
                        Console.WriteLine("Input the number to sum");
                        int number = int.Parse(Console.ReadLine());
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                matrix[i * columns + j] += number;
                            }
                        }
                        break;
                   
                    
                    case 2:
                        Console.WriteLine("Input the number to substract");
                        number = int.Parse(Console.ReadLine());
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                matrix[i * columns + j] -= number;
                            }
                        }
                        break;
                   
                    
                    case 3:
                        Console.WriteLine("Input the number to multiply");
                        number = int.Parse(Console.ReadLine());
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                matrix[i * columns + j] *= number;
                            }
                        }
                        break;
                  
                    
                    case 4:
                        Console.WriteLine("Input the number to divide");
                        number = int.Parse(Console.ReadLine());
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                matrix[i * columns + j] /= number;
                            }
                        }
                        break;
                   
               


                    case 5:
                        int[] matrix2 = new int[rows * columns];
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                matrix2[j * rows + i] = matrix[i * columns + j];
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("The matrix transposed is: \n");
                        
                        for (int i = 0; i < columns; i++)
                        {
                            for (int j = 0; j < rows; j++)
                            {
                                Console.Write(matrix2[i * rows + j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        int determinant = 0;

                        


                        Console.WriteLine("Coming soon");
                        
                        // Console.WriteLine("The determinant is: " + determinant);
                        break;


                    case 7:
                        Console.WriteLine("Coming soon... ");
                        
                        break;


                    case 8:
                        Console.WriteLine("The matrix is: ");
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(matrix[i * columns + j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (option != 0);
            //Console.WriteLine("Input the operation to do with the matrix");
            //string operacion = Console.ReadLine();


        }
    
    }
 
}