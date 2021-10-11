﻿#pragma warning disable RCS1163 // Unused parameter.
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable RCS1118 // Mark local variable as const.
namespace CSharpRepetition.Net20.MarcusMedina
{
    using CSharpRepetition.MarcusKod;

    /// <summary>
    /// Testa dina grundkunskaper i C#.
    /// </summary>
    public class CSRepGrund
    {
        /// <summary>
        /// Du kommer att få ett obestämt antal tal som funktionen ska
        /// returnera medelvärde på
        /// (Linq Average räknas som fusk).
        /// </summary>
        /// <param name="tal">Alla tal som ska behandlas.</param>
        /// <returns>Medelvärdet av talen.</returns>
        public int Medelvärde(params int[] tal)
        {
            int medelvärde = 0;
            int summa = 0;
            foreach (var siffra in tal)
            {
                summa += siffra;
            }
            medelvärde = summa / tal.Length;
            NiceDebug.DebugThis("Medelvärdet är : " + medelvärde);
            return medelvärde;
        }

        /// <summary>
        /// Du kommer att få ett obestämt antal tal som funktionen ska
        /// returnera lägsta och högsta värdet av de talen
        /// (Linq Max/Min räknas som fusk).
        /// </summary>
        /// <param name="tal">Talen som ska kontrolleras.</param>
        /// <returns>Max och Minimivärden.</returns>
        public (int, int) MinimiOchMaximiVärde(params int[] tal)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var number in tal)
            {
                if (number > max) { max = number; }
                if (number < min) { min = number; }
            }
            NiceDebug.DebugThis("Min och Max    : " + (min, max));
            return (min, max);
        }

        /// <summary>
        /// Skapa en loop som går igenom alla siffror i en sträng
        /// och adderar dem, när den är klar ska den returnera
        /// summan, exempelvis "552" ska ge svaret "12" alla andra
        /// tecken ska ignoreras "54.3" ska bli 12.
        /// </summary>
        /// <param name="nummer">Sträng med nummeriska värden<see cref="string"/>.</param>
        /// <returns>Summan av alla tal i strängen.</returns>
        public int SummeraText(string nummer)
        {
            int summa = 0;

            for (int i = 0; i < nummer.Length; i++)
            {
                int.TryParse(nummer[i].ToString(), out int sum);
                summa += sum;
            }
            NiceDebug.DebugThis("Summa          : " + summa);
            return summa;
        }
    }
}
#pragma warning restore RCS1118 // Mark local variable as const.
#pragma warning restore IDE0060 // Remove unused parameter
#pragma warning restore RCS1163 // Unused parameter.
