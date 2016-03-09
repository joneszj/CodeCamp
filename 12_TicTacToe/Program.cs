using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Char Reference: 0=48, 1=49, 2=50 
            char[,] grid = new char[3, 3] { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };
            char humanId = 'X', computerId = 'O';
            bool gameOver = false;
            string winner = "";
            bool humanTurn = true;

            Random r = new Random();

            Console.WriteLine("Tic-Tac-Toe: HumanId: {0}, ComputerId: {1}", humanId, computerId);

            do
            {
                //check for winner
                //rows
                if (grid[0, 0] == humanId && grid[0, 1] == humanId && grid[0, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[1, 0] == humanId && grid[1, 1] == humanId && grid[1, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[2, 0] == humanId && grid[2, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 0] == computerId && grid[0, 1] == computerId && grid[0, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                if (grid[1, 0] == computerId && grid[1, 1] == computerId && grid[1, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                if (grid[2, 0] == computerId && grid[2, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                //cols
                if (grid[0, 0] == humanId && grid[1, 0] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 1] == humanId && grid[1, 1] == humanId && grid[2, 1] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 2] == humanId && grid[1, 2] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 0] == computerId && grid[1, 0] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }
                if (grid[0, 1] == computerId && grid[1, 1] == computerId && grid[2, 1] == computerId) { gameOver = true; winner = computerId.ToString(); }
                if (grid[0, 2] == computerId && grid[1, 2] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                //diag
                if (grid[0, 0] == humanId && grid[1, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 2] == humanId && grid[1, 1] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                if (grid[0, 0] == computerId && grid[1, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                if (grid[0, 2] == computerId && grid[1, 1] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }

                if (humanTurn)
                {
                    //instantiating variables here means they will be new variables in each loop
                    char userInputRow;
                    char userInputCol;

                    //print available slots
                    for (int i = 0; i < grid.GetLength(0); i++)
                    {
                        Console.WriteLine("|R{0}C0={1}|R{0}C1={2}|R{0}C2={3}|", i, grid[i, 0], grid[i, 1], grid[i, 2]);
                    }

                    //get user position
                    //Row
                    Console.WriteLine("\nSelect a row (0,1,2): ");
                    userInputRow = Console.ReadKey().KeyChar;
                    if (userInputRow == 48 || userInputRow == 49 || userInputRow == 50)
                    {
                        //Column
                        Console.WriteLine("\nSelect a column (0,1,2): ");
                        userInputCol = Console.ReadKey().KeyChar;
                        if (userInputCol == 48 || userInputCol == 49 || userInputCol == 50)
                        {
                            //fill position
                            //check is already filled
                            //parse input chars and cast as an int
                            int rowIndex = (int)char.GetNumericValue(userInputRow);
                            int colIndex = (int)char.GetNumericValue(userInputCol);
                            if (grid[rowIndex, colIndex] != '_')
                            {
                                Console.WriteLine("\nThat position is already taken");
                            }
                            else
                            {
                            //available, assign it
                                grid[rowIndex, colIndex] = humanId;
                                humanTurn = false;
                            }

                            //check for winner
                            //rows
                            if (grid[0, 0] == humanId && grid[0, 1] == humanId && grid[0, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[1, 0] == humanId && grid[1, 1] == humanId && grid[1, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[2, 0] == humanId && grid[2, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 0] == computerId && grid[0, 1] == computerId && grid[0, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            if (grid[1, 0] == computerId && grid[1, 1] == computerId && grid[1, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            if (grid[2, 0] == computerId && grid[2, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            //cols
                            if (grid[0, 0] == humanId && grid[1, 0] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 1] == humanId && grid[1, 1] == humanId && grid[2, 1] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 2] == humanId && grid[1, 2] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 0] == computerId && grid[1, 0] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            if (grid[0, 1] == computerId && grid[1, 1] == computerId && grid[2, 1] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            if (grid[0, 2] == computerId && grid[1, 2] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            //diag
                            if (grid[0, 0] == humanId && grid[1, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 2] == humanId && grid[1, 1] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                            if (grid[0, 0] == computerId && grid[1, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                            if (grid[0, 2] == computerId && grid[1, 1] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Column");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Row");
                    }
                    //human fail... clear console and redisplay
                    if (humanTurn)
                    {
                        Console.WriteLine("\nPlease Try Again.");
                    }
                }
                else
                {
                    //computer turn
                    Console.WriteLine("Computer turn");
                    //random row
                    int row = r.Next(0, 2);
                    //random col
                    int col = r.Next(0, 2);

                    //check if taken, if not, simply let comp take a new turn
                    if (grid[row, col] == '_')
                    {
                        //available, assign it
                        grid[row, col] = computerId;
                        //computer turn done
                        humanTurn = true;

                        //check for winner
                        //rows
                        if (grid[0, 0] == humanId && grid[0, 1] == humanId && grid[0, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[1, 0] == humanId && grid[1, 1] == humanId && grid[1, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[2, 0] == humanId && grid[2, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 0] == computerId && grid[0, 1] == computerId && grid[0, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        if (grid[1, 0] == computerId && grid[1, 1] == computerId && grid[1, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        if (grid[2, 0] == computerId && grid[2, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        //cols
                        if (grid[0, 0] == humanId && grid[1, 0] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 1] == humanId && grid[1, 1] == humanId && grid[2, 1] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 2] == humanId && grid[1, 2] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 0] == computerId && grid[1, 0] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        if (grid[0, 1] == computerId && grid[1, 1] == computerId && grid[2, 1] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        if (grid[0, 2] == computerId && grid[1, 2] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        //diag
                        if (grid[0, 0] == humanId && grid[1, 1] == humanId && grid[2, 2] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 2] == humanId && grid[1, 1] == humanId && grid[2, 0] == humanId) { gameOver = true; winner = humanId.ToString(); }
                        if (grid[0, 0] == computerId && grid[1, 1] == computerId && grid[2, 2] == computerId) { gameOver = true; winner = computerId.ToString(); }
                        if (grid[0, 2] == computerId && grid[1, 1] == computerId && grid[2, 0] == computerId) { gameOver = true; winner = computerId.ToString(); }
                    }
                }

            } while (!gameOver);
            Console.WriteLine("Winner: {0}", winner);
            Console.ReadKey();
        }
    }
}
