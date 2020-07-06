using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SouthReplace
{
    public class Deform
    {
        public static bool Deformer(string str, out string text)
        {
            try
            {
                if (IfStrNullOrEmptyOrSpace(str))
                {
                    goto Finish;
                }

                string[] term = str.Split(" ");

                StringBuilder stb1 = new StringBuilder();

                for (var i = 0; i < term.Length; i++)
                {

                    if (Regex.IsMatch(term[i], (@"[^a-zA-Z]")))
                    {
                        goto Finish;
                    }

                    StringBuilder stb = new StringBuilder();

                    for (var x = 1; x <= term[i].Length; x++)
                    {
                        string part = term[i].Substring(x - 1, 1);

                        char deformer = FindAndReplace(part);

                        if (IsVowel(deformer))
                        {
                            stb.Append(deformer.ToString().ToUpper());
                        }
                        else
                        {
                            stb.Append(deformer.ToString().ToLower());
                        }
                    }

                    stb1.Append(stb.ToString().Substring(0, 1).ToUpper() + stb.ToString().Substring(1) + " ");
                }

                text = stb1.ToString();
                return true;

            Finish:
                {
                    text = null;
                    return false;
                }
            }
            catch (Exception)
            {            

                throw;
            }
       
        }

        static char FindAndReplace(string v1)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int pos = alphabet.IndexOf(v1.ToUpper());

            if (pos == (alphabet.Length - 1)) //Caso a letra testada seja a última do alfabeto, irá pegar a primeira letra do alfabeto
            {
                pos -= (alphabet.Length - 1);
            }
            else
            {
                pos++;
            }

            return Convert.ToChar(alphabet[pos]);
        }

        public static bool IfStrNullOrEmptyOrSpace(string value)
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            return false;

        }

        static bool IsVowel(char character)
        {
            return new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(char.ToLower(character));
        }



    }
}
