using System;

namespace exo3_mdp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tape un nombre entre 1 et 4");
            Console.WriteLine("1: Minuscules uniquement");
            Console.WriteLine("2: Minuscules et Majuscules");
            Console.WriteLine("3: Minuscules, Majuscules et chiffres");
            Console.WriteLine("4: Lettres, Chiffres et caractères spéciaux");

            string numstr = Console.ReadLine();
            int mdp = 0;

            //voir si la réponse du ReadLine est reconnue
            try
            {
                int num = int.Parse(numstr);
                //tape entre 1 et 4

                /*if 1 --> chara min
                 * if 1 --> char min et maj
                 * if 3 --> char et chiffres
                 * if 4 --> char, chiffres et char spé*/

                if (num == 1)
                {
                    //je n'ai pas réussi a mettre les caractères en 1 seul string
                    while (mdp != 10)
                    {
                        Random rnd = new Random();
                        int ascii_index = rnd.Next(97, 122);
                        char myRandomLowerCase = Convert.ToChar(ascii_index);
                        Console.WriteLine(myRandomLowerCase);
                        mdp = mdp + 1;
                    }
                }

                else if (num == 2)
                {
                    while (mdp != 10)
                    {
                        Random rnd = new Random();
                        //int ascii_index = rnd.Next(65, 90 / 97, 122);
                        //je n'ai pas trouvé sur internet comment exclure des nombre ascii (les spé entre les min et maj par exemple)
                        int ascii_index = rnd.Next(65, 122);
                        char myRandomLowerUpperCase = Convert.ToChar(ascii_index);
                        Console.WriteLine(myRandomLowerUpperCase);
                        mdp = mdp + 1;
                    }
                }

                else if (num == 3)
                {
                    while (mdp != 10)
                    {
                        Random rnd = new Random();
                        //int ascii_index = rnd.Next(48, 57 / 65, 90 / 97, 122);
                        int ascii_index = rnd.Next(48, 122);
                        char myRandomnumCase = Convert.ToChar(ascii_index);
                        Console.WriteLine(myRandomnumCase);
                        mdp = mdp + 1;
                    }
                }

                else if (num == 4)
                {
                    while (mdp != 10)
                    {
                        Random rnd = new Random();
                        int ascii_index = rnd.Next(42, 126);
                        char myRandomanyCase = Convert.ToChar(ascii_index);
                        Console.WriteLine(myRandomanyCase);
                        mdp = mdp + 1;
                    }
                }

                else
                {
                    Console.WriteLine("oops, you might've made a mistake, try again");
                }
            }

            //si la réponse du ReadLine n'est pas reconnue
            catch
            {
                Console.WriteLine("oops, you might've made a mistake, try again");
            }





        }
    }
}

        
    

