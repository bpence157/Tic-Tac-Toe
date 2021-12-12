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
        while(turnNumber < 10)
        {
            if (turnNumber % 2 == 0)
            {
                player2.PlayerMakesMove();
                turnNumber++;
            }
            else
            {
                player1.PlayerMakesMove();
                turnNumber++;
            }
        }
    }
}

public class Board
{
    public static Square[] createBoard()
    {
        return new Square[]
        {
            new Square(0, 0, Contents.Empty),
            new Square(1, 0, Contents.Empty),
            new Square(2, 0, Contents.Empty),
            new Square(0, 1, Contents.Empty),
            new Square(1, 1, Contents.Empty),
            new Square(2, 1, Contents.Empty),
            new Square(0, 2, Contents.Empty),
            new Square(1, 2, Contents.Empty),
            new Square(2, 2, Contents.Empty),
        };
    } 
   
}

public class BoardRenderer
{

}

public class Player
{
    public int PlayerNumber { get; }

    public Player(int playerNumber)
    {
        PlayerNumber = playerNumber;
    }

    public void PlayerMakesMove()
    {
        Console.WriteLine($"It is Player {this.PlayerNumber}'s turn.");
        Console.WriteLine("What move would you like to make? (User num pad keys for selection)");

    }
   
}

public class Square
{
    int Row;
    int Column;
    Contents Contents { get; set; }
    public Square(int row, int column, Contents contents)
    {
        Row = row;
        Column = column;
        Contents = contents;
    }
}

public enum Contents
{
    XSymbol,
    CircleSymbol,
    Empty
}