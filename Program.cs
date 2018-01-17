using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
/// TEHTÄVÄ 1

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give a number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
/// TEHTÄVÄ 2
/// Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
/// Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä. 
namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Please give 5 integers");
            arr[0] = int.Parse(Console.ReadLine());
            arr[1] = int.Parse(Console.ReadLine());
            arr[2] = int.Parse(Console.ReadLine());
            arr[3] = int.Parse(Console.ReadLine());
            arr[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Integers are " + arr[4]+", " + arr[3]+", " + arr[2]+", " + arr[1]+", " + arr[0]+", ");
        }
    }
}
/// TEHTÄVÄ 3
/// Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle 
/// ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int[] pts = new int[5];
            Console.Write("Give points: ");
            pts[0] = int.TryParse(Console.ReadLine());
            Console.Write("Give points: ");
            pts[1] = int.TryParse(Console.ReadLine());
            Console.Write("Give points: ");
            pts[2] = int.TryParse(Console.ReadLine());
            Console.Write("Give points: ");
            pts[3] = int.TryParse(Console.ReadLine());
            Console.Write("Give points: ");
            pts[4] = int.TryParse(Console.ReadLine());
            int ttl = pts[0] + pts[1] + pts[2] + pts[3] + pts[4] - pts.Max() - pts.Min();
            Console.WriteLine("Total points are: " + ttl);
        }
    }
/// TEHTÄVÄ 4
///  Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
///  Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
/// Arvosanajakauma:
/// 0:
/// 1:****
/// 2:**
/// 3:******
/// 4:*****
/// 5:**
namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int[] grds = new int[6];
            int tmp = 0;
            bool yn = true;
            Console.WriteLine("Enter grades until number 6 or higher is entered");

            do
            {
                Console.WriteLine("Please enter your grades: ");
                tmp = int.Parse(Console.ReadLine());

                if (tmp == 0)
                    grds[0]++;

                if (tmp == 1)
                    grds[1]++;

                if (tmp == 2)
                    grds[2]++;

                if (tmp == 3)
                    grds[3]++;

                if (tmp == 4)
                    grds[4]++;

                if (tmp == 5)
                    grds[5]++;


            } while (tmp < 6);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your grades are as follows:");
            Console.Write("0: ");
            for (int i = 0; i < grds[0]; i++)
                 Console.Write("*");
            Console.WriteLine();
            Console.Write("1: ");
            for (int i = 0; i < grds[1]; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("2: ");
            for (int i = 0; i < grds[2]; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("3: ");
            for (int i = 0; i < grds[3]; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("4: ");
            for (int i = 0; i < grds[4]; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("5: ");
            for (int i = 0; i < grds[5]; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.WriteLine();

            if (grds[5] >= 5)
                Console.WriteLine("Good boy!");

        }
    }
}
/// TEHTÄVÄ 5
/// Tee ohjelma, joka tulostaa seuraavanlaisen kuvion.Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
///  Give a number: 7 [Enter]
///        *
///       ***
///      *****
///     *******
///    *********
///        *
///        *

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int hght, starNumber, spaceNumber;
            int hghtCount, spaceCount, starCount, trTrnkCount, trTrnkSpaceCount;

            Console.WriteLine("Enter tree height: ");
            hght = int.Parse(Console.ReadLine());

            for (hghtCount = 1; hghtCount <= hght; hghtCount++)
            {
                starNumber = hghtCount * 2 - 1;
                spaceNumber = hghtCount + hght - starNumber;

                for (spaceCount = 0; spaceCount < spaceNumber; spaceCount++)
                    Console.Write(" ");

                for (starCount = 0; starCount < starNumber; starCount++)
                    Console.Write("*");

                Console.Write("\n");
            }

            for (trTrnkCount = 0; trTrnkCount < 2; trTrnkCount++)
            {
                for (trTrnkSpaceCount = 0; trTrnkSpaceCount < (hght * 2 + 1) / 2; trTrnkSpaceCount++)
                    Console.Write(" ");

                Console.WriteLine("*");
            }
        }
    }
}
/// TEHTÄVÄ 6
/// Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
/// Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
/// Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienempi vai suurempi. 
/// Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int gs;
            int trs = 0;
            Console.WriteLine(randomNumber);
            Console.WriteLine("A random number has been generated between 1 and 100.");
            Console.WriteLine("Try to guess the number. Get it right on the first try and I'll give you candy.");
            do
            {
                gs = int.Parse(Console.ReadLine());
                trs++;

                if (gs == randomNumber && trs == 1)
                    Console.WriteLine("Nice! Here's some candy! >OO< ");
                if (gs > randomNumber)
                    Console.WriteLine("Too high, try again!");
                if (gs < randomNumber)
                    Console.WriteLine("Too low, try again!");
            } while (gs != randomNumber);
            Console.WriteLine();
            Console.WriteLine("Not bad. It took you " + trs + " tries.");
        }
    }
}
/// TEHTÄVÄ 7
/// Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
/// Tulosta lopuksi lajitellun taulukon sisältö.
/// Esimerkkitoiminta:
/// Numbers in an array 1: 10,20,30,40,50
/// Numbers in an array 2: 5,15,25,35,45
/// Numbers in the combined array: 5,10,15,20,25,30,35,40,45,50
namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 5, 15, 25, 35, 45 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, arr3, arr1.Length);
            Array.Copy(arr2, 0, arr3, arr1.Length, arr2.Length);
            Array.Sort(arr3);
            Console.WriteLine(string.Join(", ", arr3));
        }
    }
}
/// TEHTÄVÄ 8
/// Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a word. I'll check if it's a palindrome.");
            var str = (Console.ReadLine());
            var reversed = string.Concat(str.Reverse());
            if (str != null && str == string.Concat(str.Reverse()))
            {
                Console.WriteLine();
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The word is not a palindrome");
            }
        }
    }
}
/// TEHTÄVÄ 9
/// Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi, jossa käyttäjältä kysytään seuraavaa kirjainta. 
/// Muista näyttää aina kirjaimen jälkeen oikein arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla). Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. 
/// Päätä itse milloin pelaaja joutuu hirteen. 

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string[] wordBank = { "Hangman", "Dogs", "Categorize", "Treasure", "Oxymoronic", "Purple" };

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append(' ');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 6;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char guess;
            Console.WriteLine("Let's play hangman!");
            Console.WriteLine("You have six tries to guess the word.");

            while (!won && lives > 0)
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == wordToGuess.Length)
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                    lives--;
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", wordToGuess);

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
} */
/// TEHTÄVÄ 10
/// Toteuta jokin oma villi ideasi ja yllätä opettaja toteutuksellasi.

namespace Harjoitukset2
{
    class Program
    {
        static void Main()
        {
            int yesno = 0;
            Random random = new Random();
            int toss = random.Next(2);
            Console.WriteLine();
            Console.WriteLine("It's like 12pm and as the last excercise you want me to 'surprise you with a wild idea of my own?'");
            Console.ReadKey();
            Console.WriteLine("Dude.");
            Console.ReadKey();
            Console.WriteLine("No.");
            Console.ReadKey();
            Console.WriteLine("Toss a coin or something.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Toss a coin?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            yesno = int.Parse(Console.ReadLine());
            if (yesno == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Coin toss it is.");
                Console.WriteLine("*FLIP*");
                Console.WriteLine();
                if (toss == 1)
                {
                    Console.WriteLine("Heads. Yay.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Tails. You suck.");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Then stop bothering me.");
        }
    }
}