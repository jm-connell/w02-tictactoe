// Jon Connell, CSE210 Section 3
// Unit01 Prove - Tic Tac Toe

using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables for gameplay
            char current_turn = 'x';
            bool game_over = false;
            int tie_counter = 0;

            // Create and display starting game board
            List<char> board = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            DisplayBoard(board);

            // Loop through game until there is a winner or tie
            while (game_over != true)
            {
                // Display whose turn it is
                Console.Write($"\n{current_turn}'s turn to choose a square (1-9): ");

                // Get input from user
                int num_input = Int32.Parse(Console.ReadLine());

                // Update board
                board[num_input-1] = current_turn;
                Console.Write("\n\n");
                DisplayBoard(board);

                // Check for winner
                game_over = isWinner(board, current_turn);

                // If game is not over, change turn
                if (game_over == false)
                {
                    // Count number of turns to check for tie
                    tie_counter++;
                    if (tie_counter == 9)
                    {
                        game_over = true;
                        Console.WriteLine("\nGame tied! Thanks for playing.\n");
                    }
                    if (current_turn == 'x')
                    {
                        current_turn = 'o';
                    }
                    else if (current_turn == 'o')
                    {
                        current_turn = 'x';
                    }
                }

            }

        }

        static void DisplayBoard(List<char> board)
        {
            // Display game board using current values from 'board' list
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}\n-+-+-\n{board[3]}|{board[4]}|{board[5]}\n-+-+-\n{board[6]}|{board[7]}|{board[8]}");
        }

        static bool isWinner(List<char> board, char current_turn)
        {
            bool game_over = false;

            // Look for win on horizontal lines
            if ((board[0] == board[1] && board[1] == board[2]) || (board[3] == board[4] && board[4] == board[5]))
            {
                Console.WriteLine("\nGood game. Thanks for playing!\n");
                game_over = true;
                return game_over;
            }
            // Look for win on vertical lines
            else if ((board[0] == board[3] && board[3] == board[6]) || (board[1] == board[4] && board[4] == board[7]) || (board[2] == board[5] && board[5] == board[8]))
            {
                Console.WriteLine("\nGood game. Thanks for playing!\n");
                game_over = true;
                return game_over;
            }
            // Look for win on diagonal lines
            else if ((board[0] == board[4] && board[4] == board[8]) || (board[2] == board[4] && board[4] == board[6]))
            {
                Console.WriteLine("\nGood game. Thanks for playing!\n");
                game_over = true;
                return game_over;
            }
            // If no winner is found, return game_over as false to continue playing
            else
            {
                return game_over;
            }

        }
    }
}