namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void DrawBoard(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(new string('-', 33));

            for (int i = 0; i < 8; i++)
            {
                int yAdd = 2 * i;

                Console.SetCursorPosition(x, y + 1 + yAdd);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("|   ");
                }
                Console.Write('|');

                if (i == 7) break;

                Console.SetCursorPosition(x, y + 2 + yAdd);
                Console.Write("|---");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("+---");
                }
                Console.Write('|');
            }

            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine(new string('-', 33));
        }
    }
}
