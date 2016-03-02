using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;

            Console.WriteLine("## Welcome to Tic Tac Toe - By: Zachary Ballard ##");
            Console.WriteLine("##################################################\n");

            while (Exit == false)
            {
                string UserInput = "";

                bool TwoPlayer = false;
                bool ComSkill = false;

                while (true)
                {
                    Console.WriteLine("\nWould you like a (1) player or (2) player game?");
                    Console.WriteLine("(You can also type EXIT at any time)");
                    UserInput = Console.ReadLine();

                    if (UserInput == "1")
                    {
                        TwoPlayer = false;
                        break;
                    }
                    else if (UserInput == "2")
                    {
                        TwoPlayer = true;
                        break;
                    }
                    else if (UserInput == "EXIT")
                    {
                        Exit = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That option is not valid. Try again.");
                    }
                }

                Console.Clear();

                if (Exit == true)
                {
                    break;
                }

                if (TwoPlayer == false)
                {
                    while (true)
                    {
                        Console.WriteLine("\nWould you like the computer to play (r)andomly or (s)killed?");
                        Console.WriteLine("(You can also type EXIT at any time)");
                        UserInput = Console.ReadLine();

                        if (UserInput == "r")
                        {
                            ComSkill = false;
                            break;
                        }
                        else if (UserInput == "s")
                        {
                            ComSkill = true;
                            break;
                        }
                        else if (UserInput == "EXIT")
                        {
                            Exit = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That option is not valid. Try again.");
                        }
                    }

                    Console.Clear();

                    if (Exit == true)
                    {
                        break;
                    }
                }


                GamePlay(TwoPlayer, ComSkill);
                Exit = PlayAgain();

            }
        }

        static void GamePlay(bool TwoPlayer, bool ComSkill)
        {
            var board = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            Random random = new Random();

            string CurrentPlayer = "X";
            int UserInput = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"{board[0]} | {board[1]} | { board[2]}");
                Console.WriteLine($"------------");
                Console.WriteLine($"{board[3]} | {board[4]} | { board[5]}");
                Console.WriteLine($"------------");
                Console.WriteLine($"{board[6]} | {board[7]} | { board[8]}");


                //Ask for User Input
                //if human turn do this:
                if (TwoPlayer == true || CurrentPlayer == "X")
                {
                    while (true)
                    {
                        Console.WriteLine($"\n{CurrentPlayer}, where would you like to play?\n");
                        //Check if a valid move, if not Ask for input again
                        if (int.TryParse(Console.ReadLine(), out UserInput))
                        {
                            if (UserInput < 0 || UserInput > 8)
                            {
                                Console.WriteLine("Not a valid move");
                                continue;
                            }

                            if (board[UserInput] == "O" || board[UserInput] == "X")
                            {
                                Console.WriteLine("Spot already Taken");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not valid input.");
                        }

                        break;

                    }
                }
                else
                {
                    if (ComSkill == false)
                    {
                        while (true)
                        {
                            UserInput = random.Next(0, 8);

                            if (board[UserInput] == "O" || board[UserInput] == "X")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    //Unfinished AI
                    else
                    {
                        var checkBoard = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                        for (int i = 0; i <= 8; i++)
                        {
                            if (board[i] == "X")
                            {
                                checkBoard[i] = 1;
                            }
                            else if (board[i] == "O")
                            {
                                checkBoard[i] = -1;
                            }
                            else
                            {

                            }
                        }
                        if (board[4] != "X" && board[4] != "O")
                        {
                            UserInput = 4;
                        }
                        else if (checkBoard[0] + checkBoard[1] + checkBoard[2] == 2)
                        {
                            if (board[0] != "O" && board[0] != "X")
                            {
                                UserInput = 0;
                            }
                            else if (board[1] != "O" && board[1] != "X")
                            {
                                UserInput = 1;
                            }
                            else if (board[2] != "O" && board[2] != "X")
                            {
                                UserInput = 2;
                            }
                            else
                            {
                                continue;
                            }

                        }

                        else if (checkBoard[3] + checkBoard[4] + checkBoard[5] == 2)
                        {
                            if (board[3] != "O" && board[3] != "X")
                            {
                                UserInput = 3;
                            }
                            else if (board[4] != "O" && board[4] != "X")
                            {
                                UserInput = 4;
                            }
                            else if (board[5] != "O" && board[5] != "X")
                            {
                                UserInput = 5;
                            }
                            else
                            {
                                continue;
                            }

                        }

                        else if (checkBoard[6] + checkBoard[7] + checkBoard[8] == 2)
                        {
                            if (board[6] != "O" && board[6] != "X")
                            {
                                UserInput = 6;
                            }
                            else if (board[7] != "O" && board[7] != "X")
                            {
                                UserInput = 7;
                            }
                            else if (board[8] != "O" && board[8] != "X")
                            {
                                UserInput = 8;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (checkBoard[0] + checkBoard[3] + checkBoard[6] == 2)
                        {
                            if (board[0] != "O" && board[0] != "X")
                            {
                                UserInput = 0;
                            }
                            else if (board[3] != "O" && board[3] != "X")
                            {
                                UserInput = 3;
                            }
                            else if (board[6] != "O" && board[6] != "X")
                            {
                                UserInput = 6;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        else if (checkBoard[2] + checkBoard[5] + checkBoard[8] == 2)
                        {
                            if (board[2] != "O" && board[2] != "X")
                            {
                                UserInput = 2;
                            }
                            else if (board[5] != "O" && board[5] != "X")
                            {
                                UserInput = 5;
                            }
                            else if (board[8] != "O" && board[8] != "X")
                            {
                                UserInput = 8;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (checkBoard[6] + checkBoard[4] + checkBoard[2] == 2)
                        {
                            if (board[6] != "O" && board[6] != "X")
                            {
                                UserInput = 6;
                            }
                            else if (board[4] != "O" && board[4] != "X")
                            {
                                UserInput = 4;
                            }
                            else if (board[2] != "O" && board[2] != "X")
                            {
                                UserInput = 2;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (checkBoard[0] + checkBoard[4] + checkBoard[8] == 2)
                        {
                            if (board[0] != "O" && board[0] != "X")
                            {
                                UserInput = 0;
                            }
                            else if (board[4] != "O" && board[4] != "X")
                            {
                                UserInput = 4;
                            }
                            else if (board[8] != "O" && board[8] != "X")
                            {
                                UserInput = 8;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (checkBoard[1] + checkBoard[4] + checkBoard[7] == 2)
                        {
                            if (board[1] != "O" && board[1] != "X")
                            {
                                UserInput = 1;
                            }
                            else if (board[4] != "O" && board[4] != "X")
                            {
                                UserInput = 4;
                            }
                            else if (board[7] != "O" && board[7] != "X")
                            {
                                UserInput = 7;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                UserInput = random.Next(0, 8);

                                if (board[UserInput] == "O" || board[UserInput] == "X")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                board[UserInput] = CurrentPlayer;

                if (board[0] == CurrentPlayer && board[1] == CurrentPlayer && board[2] == CurrentPlayer)
                {
                    board[0] = "##";
                    board[1] = "###";
                    board[2] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]}|{board[1]}|{ board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} | {board[4]} | { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]} | {board[7]} | { board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[0] == CurrentPlayer && board[3] == CurrentPlayer && board[6] == CurrentPlayer)
                {
                    board[0] = "##";
                    board[3] = "##";
                    board[6] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]}| {board[1]} | { board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]}| {board[4]} | { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]}| {board[7]} | { board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[0] == CurrentPlayer && board[4] == CurrentPlayer && board[8] == CurrentPlayer)
                {
                    board[0] = "##";
                    board[4] = "###";
                    board[8] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]}| {board[1]} | { board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} |{board[4]}| { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]} | {board[7]} |{ board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[6] == CurrentPlayer && board[4] == CurrentPlayer && board[2] == CurrentPlayer)
                {
                    board[6] = "##";
                    board[4] = "###";
                    board[2] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]} | {board[1]} |{ board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} |{board[4]}| { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]}| {board[7]} | { board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[6] == CurrentPlayer && board[7] == CurrentPlayer && board[8] == CurrentPlayer)
                {
                    board[6] = "##";
                    board[7] = "###";
                    board[8] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]} | {board[1]} | { board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} | {board[4]} | { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]}|{board[7]}|{ board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[2] == CurrentPlayer && board[5] == CurrentPlayer && board[8] == CurrentPlayer)
                {
                    board[2] = "##";
                    board[5] = "##";
                    board[8] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]} | {board[1]} |{ board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} | {board[4]} |{ board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]} | {board[7]} |{ board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[1] == CurrentPlayer && board[4] == CurrentPlayer && board[7] == CurrentPlayer)
                {
                    board[1] = "###";
                    board[4] = "###";
                    board[7] = "###";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]} |{board[1]}| { board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]} |{board[4]}| { board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]} |{board[7]}| { board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else if (board[3] == CurrentPlayer && board[4] == CurrentPlayer && board[5] == CurrentPlayer)
                {
                    board[3] = "##";
                    board[4] = "###";
                    board[5] = "##";

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{board[0]} | {board[1]} | { board[2]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[3]}|{board[4]}|{ board[5]}");
                    Console.WriteLine($"------------");
                    Console.WriteLine($"{board[6]} | {board[7]} | { board[8]}");

                    Console.WriteLine($"\nThe winner is {CurrentPlayer}! ");
                    if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nWere you even trying?");
                    }
                    else if (TwoPlayer == false && ComSkill == true && CurrentPlayer == "X")
                    {
                        Console.WriteLine("\nFantastic work! You beat the computer!");
                    }
                    else if (TwoPlayer == false && CurrentPlayer == "O")
                    {
                        Console.WriteLine("\nBetter luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat Job!");
                    }

                    break;
                }
                else
                {
                    bool X = true;
                    bool O = true;
                    string X2 = "X";
                    string O2 = "O";

                    int i;
                    for (i = 0; i <= 8; i++)
                    {
                        X = (X2 == board[i]);
                        O = (O2 == board[i]);

                        if (X == false && O == false)
                        {
                            break;
                        }
                    }

                    if (X == true || O == true && i == 9)
                    {
                        Console.WriteLine("\nIt is a TIE! ");
                        if (TwoPlayer == false && ComSkill == false && CurrentPlayer == "X")
                        {
                            Console.WriteLine("\nHow is that possible?");
                        }
                        else if (TwoPlayer == false && ComSkill == true && CurrentPlayer == "X")
                        {
                            Console.WriteLine("\nTrust me, it happens. Alot.");
                        }
                        else
                        {
                            Console.WriteLine("\nSo close!");
                        }
                        break;
                    }
                }

                if (CurrentPlayer == "X")
                {
                    CurrentPlayer = "O";
                }
                else
                {
                    CurrentPlayer = "X";
                }
            }

            return;
        }

        private static bool PlayAgain()
        {
            string UserInput = "";

            while (true)
            {
                Console.WriteLine("\nWould you like to play again? (y)es or (n)o");
                UserInput = Console.ReadLine();

                if (UserInput == "y")
                {
                    return (false);
                }
                else if (UserInput == "n")
                {
                    return (true);
                }
                else
                {
                    Console.WriteLine("\nWhoa. Don't get too excited now. I asked:");
                }


            }
        }
    }
}

