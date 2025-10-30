namespace fattorialedecrescente
{
    internal class Program
    {
        static int Fattoriale(int n)
        {
            int risultato = 1;
            for (int i = 1; i <= n; i++)
            {
                risultato = risultato * i;
            }
            return risultato;
        }

        static int SommaFattoriali(int n)
        {
            int somma = 0;
            for (int i = n; i >= 1; i--)
            {
                somma = somma + Fattoriale(i);
            }
            return somma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero positivo:");
            int numeroUtente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La somma dei fattoriali da " + numeroUtente + " a 1 è: " + SommaFattoriali(numeroUtente));
        }

    }
}

