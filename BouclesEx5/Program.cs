using System;

class Program
{
    static void Main()
    {
        double consommationInitiale = 1;  
        double consommation = consommationInitiale;
        double taux = 0.08;               
        int annees = 0;

        while (consommation < 2 * consommationInitiale)
        {
            consommation = consommation * (1 + taux);
            annees++;
        }

        Console.WriteLine($"La consommation double au bout de {annees} années.");
    }
}