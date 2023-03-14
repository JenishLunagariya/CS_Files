using System;
namespace RockPaperScissors{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is Rock, Paper, Scissors game. You pick Rock,Paper or Scissors by typing R,P or S.");
            
            bool Game = true;
            string Human;
            int randomInt;
            string inputCPU;
            string continueGame = "n";
            while (Game){
                Console.Write("Human Input: ");
                Human = Console.ReadLine();
                
                Random rnd = new Random();
                randomInt = rnd.Next(1,4);
                switch (randomInt)
                {
                    case 1:
                        inputCPU = "R";
                        if (Human == "R"){
                            Console.WriteLine("Draw! \n");
                        }else if(Human == "P"){
                            Console.WriteLine("Human wins!\n");
                        }else{
                            Console.WriteLine("CPU wins!\n");
                        }
                        break;
                    case 2:
                        inputCPU = "P";
                        if (Human == "P"){
                            Console.WriteLine("Draw! \n");
                        }else if(Human == "S"){
                            Console.WriteLine("Human wins!\n");
                        }else{
                            Console.WriteLine("CPU wins!\n");
                        }
                        break;
                    case 3:
                        inputCPU = "S";
                        if (Human == "S"){
                            Console.WriteLine("Draw! \n");
                        }else if(Human == "R"){
                            Console.WriteLine("Human wins!\n");
                        }else{
                            Console.WriteLine("CPU wins!\n");
                        }
                        break;
                    default:
                        break;
                }
                Console.Write("Do you want to continue: ");
                continueGame = Console.ReadLine();
                if (continueGame == "y"){
                    continue;
                }else{
                    Game = false;
                    Console.WriteLine("Good game, see you soon!");
                }
            }
        }
    }
}