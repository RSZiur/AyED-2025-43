using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO (version simplificada) ===\n");

        string[] mano = GenerarManoAleatoria();

        string tipo = TipoDeMano(mano);

        int basePts = PuntajeBase(mano);

        double mult = Multiplicador(tipo);

        double total = basePts * mult;

        bool jokerX2 = true;
        bool jokerMas10 = true;
        total = AplicarJokers(total, jokerX2, jokerMas10);


        MostrarResumen(mano, tipo, basePts, mult, total);

        Console.ReadKey();
    }

    // 1_ Generar mano aleatoria
    static string[] GenerarManoAleatoria()
    {
        string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] palos = { "H", "D", "C", "S" };
        string[] mano = new string[5];

        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            string carta = rangos[rnd.Next(rangos.Length)] + palos[rnd.Next(palos.Length)];
            mano[i] = carta;
        }
        return mano;
    }

    // 2_ Tipo de mano
    static string TipoDeMano(string[] mano)
    {
        var rangos = mano.Select(c => c[0].ToString()).ToArray();
        var grupos = rangos.GroupBy(r => r).Select(g => g.Count()).OrderByDescending(c => c).ToList();

        if (grupos.Contains(4)) return "Poker";
        if (grupos.Contains(3) && grupos.Contains(2)) return "Full";
        if (grupos.Contains(3)) return "Trio";
        if (grupos.Contains(2)) return "Par";
        return "Nada";
    }

    // 3_ Puntaje base
    static int PuntajeBase(string[] mano)
    {
        int total = 0;
        foreach (var carta in mano)
        {
            char rango = carta[0];
            switch (rango)
            {
                case 'A': total += 14; break;
                case 'K': total += 13; break;
                case 'Q': total += 12; break;
                case 'J': total += 11; break;
                case 'T': total += 10; break;
                default: total += int.Parse(rango.ToString()); break;
            }
        }
        return total;
    }

    // 4_ Multiplicador
    static double Multiplicador(string tipo)
    {
        switch (tipo)
        {
            case "Par": return 1.5;
            case "Trio": return 2.5;
            case "Full": return 3.5;
            case "Poker": return 4.0;
            default: return 1.0;
        }
    }

    // 5_ Aplicar jokers
    static double AplicarJokers(double puntaje, bool x2, bool mas10)
    {
        if (x2) puntaje *= 2;
        if (mas10) puntaje += 10;
        return puntaje;
    }

    // 6_ Mostrar resumen
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.WriteLine("Mano: " + string.Join(" ", mano));
        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Puntaje base: " + basePts);
        Console.WriteLine("Multiplicador: x" + mult);
        Console.WriteLine("Total (con Jokers): " + total);
    }
}