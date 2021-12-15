using System;

new TicTacToe().run();

public class TicTacToe
{
    //Initialize Board
    public Square[] board = Board.createBoard();
    //Initialize Players
    public Player player1 = new Player(1);
    public Player player2 = new Player(2);
    public int turnNumber = 1;
    public void run()
    {
        Console.WriteLine("Player 1 is X. Player 2 is O.");
        Console.WriteLine();
        RenderBoard();
        Console.WriteLine();

        while (turnNumber < 10)
        {
            if (turnNumber % 2 == 0)
            {
                board = player2.PlayerMakesMove(board);
                Console.Clear();
                Console.WriteLine();
                RenderBoard();
                if (CheckWin(player2))
                {
                    Console.WriteLine("Player 2 has won!");
                    break;
                }
                turnNumber++;
            }
            else
            {
                board = player1.PlayerMakesMove(board);
                Console.Clear();
                Console.WriteLine();
                RenderBoard();
                if (CheckWin(player1))
                {
                    Console.WriteLine("Player 1 has won!");
                    break;
                }
                turnNumber++;
            }
            if (turnNumber == 10)
            {
                Console.WriteLine("Draw!");
            }
        }
    }

    public bool CheckWin(Player player)
    {
        Symbol playerSymbol;

        if(player.PlayerNumber == 1)
        {
            playerSymbol = Symbol.X;
        }
        else
        {
            playerSymbol = Symbol.O;
        }

        if(board[0].Symbol == playerSymbol && board[1].Symbol == playerSymbol && board[2].Symbol == playerSymbol ||
           board[3].Symbol == playerSymbol && board[4].Symbol == playerSymbol && board[5].Symbol == playerSymbol ||
           board[6].Symbol == playerSymbol && board[7].Symbol == playerSymbol && board[8].Symbol == playerSymbol ||
           board[0].Symbol == playerSymbol && board[3].Symbol == playerSymbol && board[6].Symbol == playerSymbol ||
           board[1].Symbol == playerSymbol && board[4].Symbol == playerSymbol && board[5].Symbol == playerSymbol ||
           board[2].Symbol == playerSymbol && board[5].Symbol == playerSymbol && board[8].Symbol == playerSymbol ||
           board[0].Symbol == playerSymbol && board[4].Symbol == playerSymbol && board[8].Symbol == playerSymbol ||
           board[2].Symbol == playerSymbol && board[4].Symbol == playerSymbol && board[6].Symbol == playerSymbol
           )
        {
            return true;
        }
        else
        {
             return false;
        }
    }

    public void RenderBoard()
    {
        Console.WriteLine($" {board[6].Symbol} | {board[7].Symbol} | {board[8].Symbol} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3].Symbol} | {board[4].Symbol} | {board[5].Symbol} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[0].Symbol} | {board[1].Symbol} | {board[2].Symbol} ");
    }
}

public class Board
{
    public static Square[] createBoard()
    {
        return new Square[]
        {
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
            new Square(Symbol._),
        };
    } 
   
}

public class Player
{
    public int PlayerNumber { get; }
    

    public Player(int playerNumber)
    {
        PlayerNumber = playerNumber;
    }

    public Square[] PlayerMakesMove(Square[] board)
    {
        Console.WriteLine();
        Console.WriteLine($"It is Player {this.PlayerNumber}'s turn.");
        Console.WriteLine("What move would you like to make? (Use num pad keys for selection)");
        int userInput;
        while(true)
        {
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput == 1)
            {
                if(this.PlayerNumber == 1 && board[0].Symbol == Symbol._)
                {
                    board[0].Symbol = Symbol.X;
                    return board;
                }
                else if(this.PlayerNumber == 2 && board[0].Symbol == Symbol._)
                {
                    board[0].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 2)
            {
                if (this.PlayerNumber == 1 && board[1].Symbol == Symbol._)
                {
                    board[1].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[1].Symbol == Symbol._)
                {
                    board[1].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 3)
            {
                if (this.PlayerNumber == 1 && board[2].Symbol == Symbol._)
                {
                    board[2].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[2].Symbol == Symbol._)
                {
                    board[2].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 4)
            {
                if (this.PlayerNumber == 1 && board[3].Symbol == Symbol._)
                {
                    board[3].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[3].Symbol == Symbol._)
                {
                    board[3].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 5)
            {
                if (this.PlayerNumber == 1 && board[4].Symbol == Symbol._)
                {
                    board[4].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[4].Symbol == Symbol._)
                {
                    board[4].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 6)
            {
                if (this.PlayerNumber == 1 && board[5].Symbol == Symbol._)
                {
                    board[5].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[5].Symbol == Symbol._)
                {
                    board[5].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 7)
            {
                if (this.PlayerNumber == 1 && board[6].Symbol == Symbol._)
                {
                    board[6].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[6].Symbol == Symbol._)
                {
                    board[6].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 8)
            {
                if (this.PlayerNumber == 1 && board[7].Symbol == Symbol._)
                {
                    board[7].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[7].Symbol == Symbol._)
                {
                    board[7].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else if (userInput == 9)
            {
                if (this.PlayerNumber == 1 && board[8].Symbol == Symbol._)
                {
                    board[8].Symbol = Symbol.X;
                    return board;
                }
                else if (this.PlayerNumber == 2 && board[8].Symbol == Symbol._)
                {
                    board[8].Symbol = Symbol.O;
                    return board;
                }
                else
                {
                    Console.WriteLine("That spot is already taken.");
                }
            }
            else
            {
                Console.WriteLine("That is an incorrect input, please try again.");
            }

        }

    }
   
}

public class Square
{
    public Symbol Symbol { get; set; }
    public Square(Symbol symbol)
    {
        Symbol = symbol;
    }
}

public enum Symbol
{
    X,
    O,
    _
}