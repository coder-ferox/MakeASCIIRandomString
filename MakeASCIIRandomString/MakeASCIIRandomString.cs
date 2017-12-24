using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRandomString
{
    class MakeASCIIRandomString
    {
        

        Random r = new Random();


        private string MakeRandomLowerCaseLetter()
        {
            Char c = (Char)(r.Next(97, 123));
            return c.ToString();
        }

        private string MakeRandomUpperCaseLetter()
        {
            Char c = (Char)(r.Next(65, 91));
            return c.ToString();
        }

        private string MakeRandomSymbol()
        {
            Char[] c = new Char[4];
            c[0] = (Char)(r.Next(33, 48));
            c[1] = (Char)(r.Next(58, 65));
            c[2] = (Char)(r.Next(91, 97));
            c[3] = (Char)(r.Next(123, 127));

            int cFinal = r.Next(0, 4);

            return c[cFinal].ToString();
        }

        private string MakeRandomNumber()
        {
            Char c = (Char)(r.Next(48, 58));
            return c.ToString();
        }

       
        /// <summary>
        /// Get only random lower case letters
        /// </summary>
        /// <param name="length">How many letters do you want ?</param>
        /// <returns>A string</returns>
        public string LowerCaseLetters(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(MakeRandomLowerCaseLetter());
            return sb.ToString();
        }

        /// <summary>
        /// Get only random upper case letters
        /// </summary>
        /// <param name="length">How many letters do you want ?</param>
        /// <returns>A string</returns>
        public string UpperCaseLetters(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(MakeRandomUpperCaseLetter());
            return sb.ToString();
        }

        /// <summary>
        /// Get only random symbols
        /// </summary>
        /// <param name="length">How many symbols do you want ?</param>
        /// <returns>A string</returns>
        public string Symbols(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(MakeRandomSymbol());
            return sb.ToString();
        }

        /// <summary>
        /// Get only random numbers
        /// </summary>
        /// <param name="length">How many letters do you want ?</param>
        /// <returns>A string</returns>
        public string Numbers(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(MakeRandomNumber());
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of lower case and upper case letters
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixLetters(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomLowerCaseLetter());
                else
                    sb.Append(MakeRandomUpperCaseLetter());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of lower case letter and symbols
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixLowerCaseLettersAndSymbols(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomLowerCaseLetter());
                else
                    sb.Append(MakeRandomSymbol());

            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of upper case letters and symbols
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixUpperCaseLettersAndSymbols(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomUpperCaseLetter());
                else
                    sb.Append(MakeRandomSymbol());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of lower case letters and numbers
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixNumbersAndLowerCaseLetters(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomNumber());
                else
                    sb.Append(MakeRandomLowerCaseLetter());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of upper case and numbers
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixNumbersAndUpperCaseLetters(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomNumber());
                else
                    sb.Append(MakeRandomUpperCaseLetter());
            }
            return sb.ToString();
        }


        /// <summary>
        /// Get a mixed string of numbers and symbols
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixNumbersAndSymbols(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 2);
                if (v == 0)
                    sb.Append(MakeRandomNumber());
                else
                    sb.Append(MakeRandomSymbol());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of letters (all kind of) and symbols
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixAllKindOfLettersAndSymbols(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 3);
                if (v == 0)
                    sb.Append(MakeRandomLowerCaseLetter());
                else if (v == 1)
                    sb.Append(MakeRandomUpperCaseLetter());
                else
                    sb.Append(MakeRandomSymbol());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of letters (all kind of) and numbers
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixAllKindOfLettersAndNumbers(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 3);
                if (v == 0)
                    sb.Append(MakeRandomLowerCaseLetter());
                else if (v == 1)
                    sb.Append(MakeRandomUpperCaseLetter());
                else
                    sb.Append(MakeRandomNumber());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a mixed string of anything
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string MixAll(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int v = r.Next(0, 4);
                if (v == 0)
                    sb.Append(MakeRandomLowerCaseLetter());
                else if (v == 1)
                    sb.Append(MakeRandomUpperCaseLetter());
                else if (v == 2)
                    sb.Append(MakeRandomSymbol());
                else
                    sb.Append(MakeRandomNumber());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Get a pattern based mixed string, use l -> lower case letter, u -> upper case letter, s -> symbol, n -> number
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string MixByPattern(string pattern)
        {

            //OPTIONS: l -> lower case, u -> upper case, s -> symbol, n -> number

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < pattern.Length; i++)
            {
                switch (pattern[i])
                {
                    case 'l':
                    {
                        sb.Append(MakeRandomLowerCaseLetter());
                        break;
                    }
                    case 'u':
                    {
                        sb.Append(MakeRandomUpperCaseLetter());
                        break;
                    }
                    case 's':
                    {
                        sb.Append(MakeRandomSymbol());
                        break;
                    }
                    case 'n':
                    {
                        sb.Append(MakeRandomNumber());
                        break;
                    }
                    default:
                        throw new Exception("Pattern Error");


                }
            }

            return sb.ToString();
        }

        

    }
}