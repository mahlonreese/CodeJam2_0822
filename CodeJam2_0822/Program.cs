using Spectre.Console;

namespace CodeJam2_0822
{
    internal class Program
    {
        /*
         
        Ran Out of time to implement guessing game
         
         */


        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to pixel gallery! \n");

            //Console.WriteLine("Guess the random artwork");

            // Load an image
            var image = new CanvasImage("C:\\Users\\jmficde\\source\\repos\\CodeJam2_0822\\CodeJam2_0822\\starryNight.png");
            image.MaxWidth(20);

            var image2 = new CanvasImage("C:\\Users\\jmficde\\source\\repos\\CodeJam2_0822\\CodeJam2_0822\\americanGothic.png");
            image2.MaxWidth(20);

            var image3 = new CanvasImage("C:\\Users\\jmficde\\source\\repos\\CodeJam2_0822\\CodeJam2_0822\\FridaKahlo.png");
            image3.MaxWidth(20);

            var image4 = new CanvasImage("C:\\Users\\jmficde\\source\\repos\\CodeJam2_0822\\CodeJam2_0822\\UntitledBasquiat.jpg");
            image4.MaxWidth(20);

            var image5 = new CanvasImage("C:\\Users\\jmficde\\source\\repos\\CodeJam2_0822\\CodeJam2_0822\\soupCan.jpg");
            image5.MaxWidth(20);


            // Render the image to the console

            Console.WriteLine("Starry Night - Vincent Van Gogh ");
            AnsiConsole.Write(image);

            Console.WriteLine(" \n American Gothic - Grant Wood");
            AnsiConsole.Write(image2);

            Console.WriteLine(" \n Self-Portrait With Thron Necklace and HummingBird - Frida Kahlo");
            AnsiConsole.Write(image3);

            Console.WriteLine(" \n Untitled (Fishing) - Jean-Michel Basquiat");
            AnsiConsole.Write(image4);

            Console.WriteLine(" \n Large Campbell's Soup Can - Andy Warhol");
            AnsiConsole.Write(image5);

            //while (true) 
            //{



            //    string? input = GetUserGuess("Guess the painting or Artist:");
            //    if (input is null)
            //    {
            //        Console.WriteLine("Please enter a guess");
            //        continue;
            //    }

            //    string[] guess = input.Split(' ');

            //    string operatorSymbol = guess[0];
            //    if (operatorSymbol.ToLower().Equals("q"))
            //    {
            //        Console.WriteLine("Quitting the program. Goodbye!");
            //        break;
            //    }


            //}


        }



        //static string? GetUserGuess(string prompt)
        //{

        //    Console.Write(prompt + "");
        //    string? inputLine = Console.ReadLine();
        //    return string.IsNullOrEmpty(inputLine) ? null: inputLine ;

        //}



    }


}
