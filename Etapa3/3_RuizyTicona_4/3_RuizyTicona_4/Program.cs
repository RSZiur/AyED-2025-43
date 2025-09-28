
class Program
{
    static void Main(string[] args)
    {
        // ===== Nivel 1 =====
        string key = "WD-700000";
        bool nivel1 = ValidateAccessKey(key);
        Console.WriteLine("Nivel 1: " + (nivel1 ? "UNLOCK → Fragmento: CT" : "LOCK"));

        // ===== Nivel 2 =====
        int[] pings = new int[] { 13, 250, -5, 40, 40, 40, 100, 205, 100 };
        int nivel2 = SumValidEveryThird(pings);
        Console.WriteLine("Nivel 2: " + (nivel2 == 153 ? "UNLOCK → Fragmento: -ACCESS" : "LOCK"));

        // ===== Nivel 3 =====
        int[,] grid = new int[,] {
                {0,1,0},
                {1,0,1},
                {0,1,0}
            };
        int c1 = CountAdjacent(grid, 1, 1);
        int c2 = CountAdjacent(grid, 0, 0);
        Console.WriteLine("Nivel 3: " + ((c1 == 4 && c2 == 2) ? "UNLOCK → Fragmento: -OK" : "LOCK"));

        // ===== Nivel 4 =====
        string mensaje = "ctOS";
        string cifrado = CaesarPlusOne(mensaje);
        Console.WriteLine("Nivel 4: " + (cifrado == "duPT" ? "UNLOCK" : "LOCK"));

        // ===== Código final =====
        if (nivel1 && nivel2 == 153 && c1 == 4 && c2 == 2 && cifrado == "duPT")
        {
            Console.WriteLine("UNLOCK → Código final: CT-ACCESS-OK");
        }
        else
        {
            Console.WriteLine("Algún nivel falló, revisá el código.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    // ===== Nivel 1 =====
    static bool ValidateAccessKey(string key)
    {
        if (key.Length != 9)
            return false;
        if (key.Substring(0, 3) != "WD-")
            return false;

        int suma = 0;
        for (int i = 3; i < 9; i++)
        {
            char c = key[i];
            if (!Char.IsDigit(c))
                return false;
            suma += c - '0';
        }
        return suma % 7 == 0;
    }

    // ===== Nivel 2 =====
    static int SumValidEveryThird(int[] p)
    {
        int suma = 0;
        for (int i = 0; i < p.Length; i += 3)
        {
            if (p[i] >= 0 && p[i] <= 200)
                suma += p[i];
        }
        return suma;
    }

    // ===== Nivel 3 =====
    static int CountAdjacent(int[,] grid, int row, int col)
    {
        int count = 0;
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int[] dr = new int[] { -1, 1, 0, 0 };
        int[] dc = new int[] { 0, 0, -1, 1 };

        for (int i = 0; i < 4; i++)
        {
            int r = row + dr[i];
            int c = col + dc[i];

            if (r >= 0 && r < rows && c >= 0 && c < cols)
            {
                if (grid[r, c] == 1)
                    count++;
            }
        }

        return count;
    }

    // ===== Nivel 4 =====
    static string CaesarPlusOne(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c >= 'a' && c <= 'z')
            {
                result[i] = (c == 'z') ? 'a' : (char)(c + 1);
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result[i] = (c == 'Z') ? 'A' : (char)(c + 1);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}
