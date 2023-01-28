using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2) {
                sb.Append(input[i]);
            }
            
            for (int i = 1; i < input.Length; i += 2)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();

        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input != null && input.Trim().Length > 0) return false;
            else return true;


        }

        public static string MixString(string a, string b)
        {
            string result = "";
            int maxLen = Math.Max(a.Length, b.Length);
            for (int i = 0; i < maxLen; i++)
            {
                if (i < a.Length)
                {
                    result += a[i];
                }
                if (i < b.Length)
                {
                    result += b[i];
                }
                if ( !IsNullEmptyOrWhiteSpace(a) || !IsNullEmptyOrWhiteSpace(b) || a == null || b == null ) throw new ArgumentException();
                
                
            }
            return result;

        }

        public static string Reverse(string a)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sb.Append(a[i]);
            }
            return sb.ToString(); /*Il y avait un missclick dans le expected du test "dlrorWolleH" au lieu de "dlroWolleH" 
        * (un r en trop) Je me suis permis de le corriger*/
            }

        public static string ToCesarCode(string input, int offset)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                char letter = inputArray[i];
                if (!char.IsWhiteSpace(letter))
                {
                    letter = (char)(letter + offset);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                }
                inputArray[i] = letter;
            }
            return new string(inputArray);
        }

        public static string ToLowerCase(string a)
        {
            char[] chars = a.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + ('a' - 'A'));
                }
                else if (chars[i] >= 'À' && chars[i] <= 'Ö')
                {
                    chars[i] = (char)(chars[i] + ('a' - 'A'));
                }
                else if (chars[i] >= 'Ø' && chars[i] <= 'ÿ')
                {
                    chars[i] = (char)(chars[i] + ('a' - 'A'));
                }
            }
            return new string(chars);
        }

        public static string UnBazardString(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2)
            {
                sb.Append(input[i]);
            }
            StringBuilder sb2 = new StringBuilder();
            for (int i = 1; i < input.Length; i += 2)
            {
                sb2.Append(input[i]);
            }
            return sb.ToString() + sb2.ToString();
        }

        public static string Voyelles(string a)
        {
            string vowels = "aeiouy";
            HashSet<char> seenVowels = new HashSet<char>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }
                if (!vowels.Contains(c))
                {
                    continue;
                }
                if (seenVowels.Contains(c))
                {
                    continue;
                }
                seenVowels.Add(c);
                sb.Append(c);
            }
            return sb.ToString().ToLower();
        }
    }
}
