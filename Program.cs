
using TicTacToe;

Board board = new Board();

// Array to keep track of the board
char[,] bigArray = new char[3, 3] {
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

// Array to keep track of valid move options
int[] moveOptions = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Declare variables
bool playerOneTurn = true;
bool gameOn = true;
char gameWon = '\0';
string winner = "";
int moves = 0;

// Welcome the user to the game
Console.WriteLine("Welcome to our game of tic-tac-toe");

// Collect player's names
Console.WriteLine("What is player one's name?");
string playerOne = Console.ReadLine();

Console.WriteLine("What is player two's name?");
string playerTwo = Console.ReadLine();

// Give instructions on how to play
Console.WriteLine("Make your move by typing 1 for the top left square, 2 for the top middle square, 3 for the top right, 4 for middle left, 5 for the center square, 6 for middle right, 7 for bottom left, 8 for the bottom middle, or 9 for the bottom right.");
board.Print(bigArray);

do
{
    // Check if it's player one's turn
    if (playerOneTurn == true)
    {
        // Ask the player what their move is and record that
        Console.WriteLine($"{playerOne}, what is your move?");
        string playerOneMoveInput = Console.ReadLine();

        if (int.TryParse(playerOneMoveInput, out int playerOneMove))
        {
            if (moveOptions.Contains(playerOneMove))
            {
                // Calculate which square player one took
                int row = (playerOneMove - 1) / 3;
                int col = (playerOneMove - 1) % 3;

                bigArray[row, col] = 'X';
                moveOptions[playerOneMove - 1] = '\0';
                moves++;

                // Change to player two's turn
                playerOneTurn = false;
            }
            else
            {
                Console.WriteLine("That space is already taken. Try again.");
            }
        }
        else
        {
            Console.WriteLine("That's an invalid move. Try again.");
        }
    }
    // Check if it's player two's turn
    else if (playerOneTurn == false)
    {
        // Ask the player what their move is and record that
        Console.WriteLine($"{playerTwo}, what is your move?");
        string playerTwoMoveInput = Console.ReadLine();

        if (int.TryParse(playerTwoMoveInput, out int playerTwoMove))
        {
            if (moveOptions.Contains(playerTwoMove))
            {
                // Calculate which square player two took
                int row = (playerTwoMove - 1) / 3;
                int col = (playerTwoMove - 1) % 3;

                bigArray[row, col] = 'O';
                moveOptions[playerTwoMove - 1] = '\0';
                moves++;

                // Change to player one's turn
                playerOneTurn = true;
            }
            else
            {
                Console.WriteLine("That space is already taken. Try again.");
            }
        }
        else
        {
            Console.WriteLine("That's an invalid move. Try again.");
        }
    }
    // Check if the game has been won or if the board is full without a winner
    gameWon = board.CheckForWinner(bigArray);
    if (gameWon != '\0')
    {
        gameOn = false;
    }
    else if (moves >= 9)
    {
        gameOn = false;
    }

    board.Print(bigArray);
}
// Continue looping until someone wins or all the squares are filled
while (gameOn == true);

// Check if the game was a tie, if not check who won and print out a winning statement
if (moves >= 9 && gameWon == '\0')
{
    Console.WriteLine("Tie!");
}
else if (playerOneTurn == true)
{
    winner = playerTwo;
    Console.WriteLine($"Congratulations, {winner}! You won!");
}
else if (playerOneTurn == false)
{
    winner = playerOne;
    Console.WriteLine($"Congratulations, {winner}! You won!");
}