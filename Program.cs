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

            // Create and display starting game board
            List<char> board = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            DisplayBoard(board);

            // Loop through game until there is a winner or tie
            while (game_over != true)
            {
                // Display whose turn it is
                Console.Write($"{current_turn}'s turn to choose a square (1-9): ");

                // Get input from user
                string player_input = Console.ReadLine();
                int num_input = Int32.Parse(player_input);

                // Update board
                board[num_input-1] = current_turn;
                DisplayBoard(board);

                // Check for winner (change turn)

            }

        }

        static void DisplayBoard(List<char> board)
        {
            // Display game board using current values from 'board' list
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}\n-+-+-\n{board[3]}|{board[4]}|{board[5]}\n-+-+-\n{board[6]}|{board[7]}|{board[8]}");
        }
    }
}