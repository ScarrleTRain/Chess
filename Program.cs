namespace Chess
{
    internal class Program
    {
        // True = White, False = Black
        static bool playerSide = true;
        static Dictionary<string, string> pieceMap = new();
        static int x = 0;
        static int y = 0;

        static void Main(string[] args)
        {

        }

        static void DrawBoard()
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

        static void CreatePieceMap()
        {
            if (playerSide == true)
            {
                pieceMap = new Dictionary<string, string> {
                    {"paw", "a2" },
                    {"pbw", "b2" },
                    {"pcw", "c2" },
                    {"pdw", "d2" },
                    {"pew", "e2" },
                    {"pfw", "f2" },
                    {"pgw", "g2" },
                    {"phw", "h2" },
                    {"rqw", "a1" },
                    {"kqw", "b1" },
                    {"bqw", "c1" },
                    {"quw", "d1" },
                    {"kiw", "e1" },
                    {"kbw", "f1" },
                    {"kkw", "g1" },
                    {"krw", "h1" },
                    {"pab", "a7" },
                    {"pbb", "b7" },
                    {"pcb", "c7" },
                    {"pdb", "d7" },
                    {"peb", "e7" },
                    {"pfb", "f7" },
                    {"pgb", "g7" },
                    {"phb", "h7" },
                    {"rqb", "a8" },
                    {"kqb", "b8" },
                    {"bqb", "c8" },
                    {"qub", "d8" },
                    {"kib", "e8" },
                    {"kbb", "f8" },
                    {"kkb", "g8" },
                    {"krb", "h8" }
                };
            }
            else
            {
                pieceMap = new Dictionary<string, string> {
                    {"pab", "a2" },
                    {"pbb", "b2" },
                    {"pcb", "c2" },
                    {"pdb", "d2" },
                    {"peb", "e2" },
                    {"pfb", "f2" },
                    {"pgb", "g2" },
                    {"phb", "h2" },
                    {"rqb", "a1" },
                    {"kqb", "b1" },
                    {"bqb", "c1" },
                    {"qub", "d1" },
                    {"kib", "e1" },
                    {"kbb", "f1" },
                    {"kkb", "g1" },
                    {"krb", "h1" },
                    {"paw", "a7" },
                    {"pbw", "b7" },
                    {"pcw", "c7" },
                    {"pdw", "d7" },
                    {"pew", "e7" },
                    {"pfw", "f7" },
                    {"pgw", "g7" },
                    {"phw", "h7" },
                    {"rqw", "a8" },
                    {"kqw", "b8" },
                    {"bqw", "c8" },
                    {"quw", "d8" },
                    {"kiw", "e8" },
                    {"kbw", "f8" },
                    {"kkw", "g8" },
                    {"krw", "h8" }
                };
            }
        }
    }
}
