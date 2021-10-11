#pragma warning disable RCS1163 // Unused parameter.
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable RCS1118 // Mark local variable as const.
namespace CSharpRepetition.Net20.MarcusMedina
{
    using CSharpRepetition.MarcusKod;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Testa dina kodninjakunskaper.
    /// </summary>
    public class CSRepNinja
    {
        /// <summary>
        /// Den här metoden krypterar en textsträng enligt Caesarchiffer,
        /// enbart åäö, bokstäver, siffror, punkt, komma och mellanslag är godkända
        /// för input, övrigt ska ignoreras
        /// Nyckeln talar om hur många positioner en bokstav eller ett nummer ska flyttas
        /// nyckel:3 --> a=c, b=d, c=e.
        /// </summary>
        /// <param name="code">Text som ska krypteras.</param>
        /// <param name="key">Nyckel som ska användas till kryptering.</param>
        /// <returns>Krypterad sträng.</returns>
        public string Caesarchiffer(string code, int key)
        {
            string resultat = "";
            // ---------------------------------------------------------------------------------
            // Skriv din kod nedan
            // ---------------------------------------------------------------------------------
            Regex regex = new Regex(@"[A-zåäöÅÄÖ\d\.,\x20]");
            
            for (int i = 0; i < code.Length; i++)
            {
                if (regex.IsMatch(code[i].ToString()))
                {
                    resultat += (char)((int)code[i] + key);
                }

            }
            
            

            // ---------------------------------------------------------------------------------
            NiceDebug.DebugThis("Caesar :" + resultat);
            return resultat;
        }

        /// <summary>
        /// Dechifrerar text.
        /// </summary>
        /// <param name="code">Texten.</param>
        /// <param name="key">Nyckel.</param>
        /// <returns>Dechifrerad text.</returns>
        public string Caesardechiffer(string code, int key)
        {
            string resultat = "";
            // ---------------------------------------------------------------------------------
            // Skriv din kod nedan
            // ---------------------------------------------------------------------------------
            for (int i = 0; i < code.Length; i++)
            {
                resultat += (char)((int)code[i] - key);
            }
            
            // ---------------------------------------------------------------------------------
            return resultat;
        }
    }
}
#pragma warning restore RCS1118 // Mark local variable as const.
#pragma warning restore IDE0060 // Remove unused parameter
#pragma warning restore RCS1163 // Unused parameter.
