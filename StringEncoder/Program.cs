using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "the quick and brown fox jumps over the lazy dog";
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            try
            {
                foreach (var ele in word)
                {

                    int countSpace = 0;
                    int pos = 0;
                    for (int i = 0; i < alpha.Length; i++)
                    {

                        if (alpha[i] == ele)
                        {
                            if (countSpace == 0)
                            {
                                Console.Write($"{countSpace} {pos} , ");
                            }
                            else
                            {
                                Console.Write($"{countSpace} {pos - 1} , ");
                            }


                            break;
                        }
                        if (alpha[i] == ' ')
                        {
                            countSpace++; pos = 0;

                        }
                        pos++;

                    }
                }
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}


