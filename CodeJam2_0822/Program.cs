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

            //Gave image variables meaningful names cooresponding with the name of the painting
            var starryNight = new CanvasImage("C:\\Users\\jmffhrf\\OneDrive - JM Family Enterprises\\Documents\\ITS Academy Projects\\Code Jam Reviews\\Mahlon-Code-Jam\\CodeJam2_0822\\starryNight.png");
            starryNight.MaxWidth(20);

            var americanGothic = new CanvasImage("C:\\Users\\jmffhrf\\OneDrive - JM Family Enterprises\\Documents\\ITS Academy Projects\\Code Jam Reviews\\Mahlon-Code-Jam\\CodeJam2_0822\\americanGothic.png");
            americanGothic.MaxWidth(20);

            var fridaKahlo = new CanvasImage("C:\\Users\\jmffhrf\\OneDrive - JM Family Enterprises\\Documents\\ITS Academy Projects\\Code Jam Reviews\\Mahlon-Code-Jam\\CodeJam2_0822\\FridaKahlo.png");
            fridaKahlo.MaxWidth(20);

            var untitledBasquiat = new CanvasImage("C:\\Users\\jmffhrf\\OneDrive - JM Family Enterprises\\Documents\\ITS Academy Projects\\Code Jam Reviews\\Mahlon-Code-Jam\\CodeJam2_0822\\UntitledBasquiat.jpg");
            untitledBasquiat.MaxWidth(20);

            var soupCan = new CanvasImage("C:\\Users\\jmffhrf\\OneDrive - JM Family Enterprises\\Documents\\ITS Academy Projects\\Code Jam Reviews\\Mahlon-Code-Jam\\CodeJam2_0822\\soupCan.jpg");
            soupCan.MaxWidth(20);


            // Render the image to the console

            System.Threading.Thread.Sleep(3000); Console.WriteLine("Starry Night - Vincent Van Gogh "); //Used threading to delay printing
            AnsiConsole.Write(starryNight);

            System.Threading.Thread.Sleep(3000); Console.WriteLine(" \n American Gothic - Grant Wood"); //Used threading to delay printing
            AnsiConsole.Write(americanGothic);

            System.Threading.Thread.Sleep(3000); Console.WriteLine(" \n Self-Portrait With Thron Necklace and HummingBird - Frida Kahlo"); //Used threading to delay printing
            AnsiConsole.Write(fridaKahlo);

            System.Threading.Thread.Sleep(3000); Console.WriteLine(" \n Untitled (Fishing) - Jean-Michel Basquiat"); //Used threading to delay printing
            AnsiConsole.Write(untitledBasquiat);

            System.Threading.Thread.Sleep(3000); Console.WriteLine(" \n Large Campbell's Soup Can - Andy Warhol"); //Used threading to delay printing
            AnsiConsole.Write(soupCan);

            endofProgram();
            
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
       /// Added method that allows user to exit the program and console with a keystroke
        public static void endofProgram()
        {
            Console.WriteLine("Enter q to quit!");
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'q')
            {
                System.Environment.Exit(0);
            }
      
        }



        //static string? GetUserGuess(string prompt)
        //{

        //    Console.Write(prompt + "");
        //    string? inputLine = Console.ReadLine();
        //    return string.IsNullOrEmpty(inputLine) ? null: inputLine ;

        //}



    }


}
