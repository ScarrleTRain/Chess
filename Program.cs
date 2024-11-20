namespace Chess
{
    internal class Program
    {
        // True = White, False = Black
        static bool playerSide = true;
        static Dictionary<string, string> pieceMap = new();
        static string[] pieceList = new string[32];
        static Dictionary<string, string> pieceAvatars = new();
        static Dictionary<string, int[]> placemap = new();
        static int x = 0;
        static int y = 0;

        static void Main(string[] args)
        {
            DrawBoard();
            CreatePieces();
            CreatePlaceMap();
            DrawPieces(true);

            Console.ReadKey(true);
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

        static void CreatePieces()
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
                {"bkw", "f1" },
                {"kkw", "g1" },
                {"rkw", "h1" },
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
                {"bkb", "f8" },
                {"kkb", "g8" },
                {"rkb", "h8" }
            };
            pieceList = ["paw", "pbw", "pcw", "pdw", "pew", "pfw", "pgw", "phw", "rqw", "kqw", "bqw", "quw", "kiw", "bkw", "kkw", "rkw", "pab", "pbb", "pcb", "pdb", "peb", "pfb", "pgb", "phb", "rqb", "kqb", "bqb", "qub", "kib", "bkb", "kkb", "rkb"];
            pieceAvatars = new Dictionary<string, string> {
                {"paw", "P" },
                {"pbw", "P" },
                {"pcw", "P" },
                {"pdw", "P" },
                {"pew", "P" },
                {"pfw", "P" },
                {"pgw", "P" },
                {"phw", "P" },
                {"rqw", "R" },
                {"kqw", "N" },
                {"bqw", "B" },
                {"quw", "Q" },
                {"kiw", "K" },
                {"bkw", "B" },
                {"kkw", "N" },
                {"rkw", "R" },
                {"pab", "P*" },
                {"pbb", "P*" },
                {"pcb", "P*" },
                {"pdb", "P*" },
                {"peb", "P*" },
                {"pfb", "P*" },
                {"pgb", "P*" },
                {"phb", "P*" },
                {"rqb", "R*" },
                {"kqb", "N*" },
                {"bqb", "B*" },
                {"qub", "Q*" },
                {"kib", "K*" },
                {"bkb", "B*" },
                {"kkb", "N*" },
                {"rkb", "R*" }
            };
        }

        static void CreatePlaceMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (playerSide == false)
                    {
                        char col = (char)('a' + j);
                        int row = 1 + i;
                        int[] coord = [2 + (j * 4), (i * 2) + 1];

                        placemap.Add(col.ToString() + row.ToString(), coord);
                    }
                    else
                    {
                        char col = (char)('h' - j);
                        int row = 8 - i;
                        int[] coord = [2 + (j * 4), (i * 2) + 1];

                        placemap.Add(col.ToString() + row.ToString(), coord);
                    }
                }
            }
        }

        static void DrawPieces(bool init = false)
        {
            if (init == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    int yAdd = (i * 2) + 1;

                    for (int j = 0; j < 8; j++)
                    {
                        int xAdd1 = 2 + (j * 4);
                        int xAdd2 = 3 + (j * 4);

                        Console.SetCursorPosition(x + xAdd1, y + yAdd);
                        Console.Write(' ');
                        Console.SetCursorPosition(x + xAdd2, y + yAdd);
                        Console.Write(' ');
                    }
                }
            }

            foreach (string piece in pieceList)
            {
                string coord = pieceMap[piece];
                int[] cursorPosition = placemap[coord];
                string pieceAvatar = pieceAvatars[piece];
                Console.SetCursorPosition(cursorPosition[0], cursorPosition[1]);
                Console.Write(pieceAvatar);
            }
        }
    }
}
