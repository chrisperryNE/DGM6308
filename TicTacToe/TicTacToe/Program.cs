using System;

namespace TicTacToe
{
    class program
    {
        static char[,] playarea =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            char player = 'O';
            int input = 0;

            bool correct = true;

            SetField();

            do
            {
                if (player == 'O')
                {
                    
                    EnterValue(player, input);
                    player = 'X';
                }
                else if (player == 'X')
                {
                    
                    EnterValue(player, input);
                    player = 'O';
                }

                SetField();

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playarea[0, 0] == playerChar) && (playarea[0, 1] == playerChar) && (playarea[0, 2] == playerChar))
                        || ((playarea[1, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[1, 2] == playerChar))
                        || ((playarea[2, 0] == playerChar) && (playarea[2, 1] == playerChar) && (playarea[2, 2] == playerChar))
                        || ((playarea[0, 0] == playerChar) && (playarea[1, 0] == playerChar) && (playarea[2, 0] == playerChar))
                        || ((playarea[0, 1] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[2, 1] == playerChar))
                        || ((playarea[0, 2] == playerChar) && (playarea[1, 2] == playerChar) && (playarea[2, 2] == playerChar))
                        || ((playarea[0, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[2, 2] == playerChar))
                        || ((playarea[2, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[0, 2] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player X has won!");

                        }
                        else
                        {
                            Console.WriteLine("Player O has won!");
                        }

                        Console.WriteLine("Press a key to play again");
                        Console.ReadKey();

                        Reset();
                        break;

                    }
                    else if (turns == 9)
                    {
                        Console.WriteLine("No winner!");
                        Console.WriteLine("Press a key to play again");
                        Console.ReadKey();

                        Reset();
                        break;
                    }
                }
                do
                {
                    Console.Write("\nPlayer {0}: Choose a Spot! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number between 1 ann 9");
                    }

                    if ((input == 1) && (playarea[0, 0] == '1'))
                        correct = true;
                    else if ((input == 2) && (playarea[0, 1] == '2'))
                        correct = true;
                    else if ((input == 3) && (playarea[0, 2] == '3'))
                        correct = true;
                    else if ((input == 4) && (playarea[1, 0] == '4'))
                        correct = true;
                    else if ((input == 5) && (playarea[1, 1] == '5'))
                        correct = true;
                    else if ((input == 6) && (playarea[1, 2] == '6'))
                        correct = true;
                    else if ((input == 7) && (playarea[2, 0] == '7'))
                        correct = true;
                    else if ((input == 8) && (playarea[2, 1] == '8'))
                        correct = true;
                    else if ((input == 9) && (playarea[2, 2] == '9'))
                        correct = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input!");
                        correct = false;
                    }

                        // readkey 
                        // if user puts in #1-#9, correct = true
                        // if user puts anything else, correct = false
                        // console writeline please enter number 1-9



                    } while (!correct);

            }
            while (true);

        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playarea[0,0], playarea[0,1], playarea[0,2]);
            Console.WriteLine("___________");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playarea[1, 0], playarea[1, 1], playarea[1, 2]);
            Console.WriteLine("___________");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playarea[2, 0], playarea[2, 1], playarea[2, 2]);
            Console.WriteLine("   |   |   ");
            turns++;
        }

        public static void EnterValue(char player, int input)
        {
            switch (input)
            {
                case 1:
                    playarea[0, 0] = player; break;
                case 2:
                    playarea[0, 1] = player; break;
                case 3:
                    playarea[0, 2] = player; break;
                case 4:
                    playarea[1, 0] = player; break;
                case 5:
                    playarea[1, 1] = player; break;
                case 6:
                    playarea[1, 2] = player; break;
                case 7:
                    playarea[2, 0] = player; break;
                case 8:
                    playarea[2, 1] = player; break;
                case 9:
                    playarea[2, 2] = player; break;
            }
        }

        public static void Reset()
        {
            char[,] playStart =
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            playarea = playStart;
            SetField();
            turns = 0;
        }


    }


}

