using System;//NE RAZBIRAM USLOVIETO!!!!!!
class Program
{
    static void Main()
    {
        const string coin = "$";
        //layout of a board
        char[][] matrix = new char[4][];

        for (int i = 0; i < 4; i++)
        {
            string inputLine = Console.ReadLine();

            matrix[i] = inputLine.ToCharArray();
        }
        string commands = Console.ReadLine();
        int row = 0;
        int col = 0;
        int wallsHit = 0;
        int coins = 0;
        foreach (var direction in commands)
        {
            switch (direction)
            {
                case '<':
                    col--;
                    if (matrix[row][col] == ' ')
                    {

                    }
                    break;
                case '>':
                    col++;
                    break;
                case 'v':
                    row++;
                    break;
                case '^':
                    row--;
                    break;
            }
        }

        if(matrix[row][col]=='$')
        {
            coins++;
        }
        
    }
}

