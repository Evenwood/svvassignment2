using TicTacToeApp.Logic;

TicTacToeBoard board = new TicTacToeBoard();
Console.WriteLine(board);

char result = 'N';
string? insert;
int rowVal;
int colVal;
bool valueValid;

do
{
    do
    {
        do
        {
            Console.Write("Which row will you insert an X: ");
            insert = Console.ReadLine();
            valueValid = Int32.TryParse(insert, out rowVal);
            if (valueValid != true || rowVal >= 3)
            {
                Console.WriteLine("Invalid row value. Try again.");

            }
        } while (valueValid != true || rowVal >= 3);

        do
        {
            Console.Write("\nAnd which column will you insert the X: ");
            insert = Console.ReadLine();
            valueValid = Int32.TryParse(insert, out colVal);
            if (valueValid != true || colVal >= 3)
            {
                Console.WriteLine("Invalid column value. Try again.");
            }
        } while (valueValid != true || colVal >= 3);

        valueValid = board.InsertX(rowVal, colVal);
        if (valueValid != true)
        {
            Console.WriteLine("Invalid insertion. Try again.");
        }
    } while (valueValid != true);
    

    
    Console.WriteLine("\n" + board);
    result = board.ReportResult();

    if(result != 'N')
    {
        break;
    }

    do
    {
        do
        {
            Console.Write("Which row will you insert an O: ");
            insert = Console.ReadLine();
            valueValid = Int32.TryParse(insert, out rowVal);
            if (valueValid != true || rowVal >= 3)
            {
                Console.WriteLine("Invalid row value. Try again.");

            }
        } while (valueValid != true || rowVal >= 3);

        do
        {
            Console.Write("\nAnd which column will you insert the O: ");
            insert = Console.ReadLine();
            valueValid = Int32.TryParse(insert, out colVal);
            if (valueValid != true || colVal >= 3)
            {
                Console.WriteLine("Invalid column value. Try again.");
            }
        } while (valueValid != true || colVal >= 3);

        valueValid = board.InsertO(rowVal, colVal);
        if (valueValid != true)
        {
            Console.WriteLine("Invalid insertion. Try again.");
        }
    } while (valueValid != true);

    Console.WriteLine("\n" + board);
    result = board.ReportResult();

} while (result == 'N');

switch (result)
{
    case 'X':
        Console.WriteLine("\n" + result + ": X Wins!");
        break;
    case 'O':
        Console.WriteLine("\n" + result + ": O Wins!");
        break;
    case 'D':
        Console.WriteLine("\n" + result + ": A draw.");
        break;
}

Console.WriteLine("Game Over!");
Console.ReadLine();

