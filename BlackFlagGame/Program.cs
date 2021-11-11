using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace BlackFlagGame
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();
        }

        public static void gameTitle()
        {
            string title = @"     ~~~             |
~~~~     ~~~~      -----                    |
     ~~~           )___(                  -----
                     |                    )___(
                 ---------                  |
                /         \              -------
               /___________\            /       \
                     |                 /_________\
              ---------------               |
             /               \        -------------
            /                 \      /             \
           /___________________\    /_______________\
         ____________|______________________|__________
          \_                                        _/
            \______________________________________/
     ~~..             ...~~~.           ....~~~...     ..~";

            Console.WriteLine(title);
            string titleWelcomeText = @"
__________.__                 __   ___________.__                  
\______   \  | _____    ____ |  | _\_   _____/|  | _____     ____  
 |    |  _/  | \__  \ _/ ___\|  |/ /|    __)  |  | \__  \   / ___\ 
 |    |   \  |__/ __ \\  \___|    < |     \   |  |__/ __ \_/ /_/  >
 |______  /____(____  /\___  >__|_ \\___  /   |____(____  /\___  / 
        \/          \/     \/     \/    \/              \//_____/ ";
            Console.WriteLine(titleWelcomeText);
            Console.WriteLine("A project by Justin Long");
            Thread.Sleep(2000);
            string enterText = "PRESS ANY BUTTON TO BEGIN.. IF YE DARE!!";
            Console.WriteLine(enterText);

            //while (true)
            //{
            //    WriteBlinkingText(enterText, 500, true);
            //    WriteBlinkingText(enterText, 500, false);
            //}
            //static void WriteBlinkingText(string text, int delay, bool visible)
            //{
            //    if (visible)
            //        Console.Write(text);
            //    else
            //        for (int i = 0; i < text.Length; i++)
            //            Console.Write("");
            //    Console.CursorLeft -= text.Length;
            //    System.Threading.Thread.Sleep(delay);

                Console.ReadKey();
            Console.Clear();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine($"Welcome to a life on the open seas!");
            //Thread.Sleep(2000);
            Console.WriteLine($"Being a pirate is tough but it could reward you more than you could ever imagine!");
            //Thread.Sleep(2000);
            Console.WriteLine($"Before we get started on our adventure...");
            //Thread.Sleep(2000);
            Console.WriteLine($"I must know the name of the person who is CRAZY enough to call themselves a pirate!");
            //Thread.Sleep(2000);
            Console.WriteLine($"Please enter your first name:");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello Captin {userName}! My name is Nubbs.. Dont ask..");
            //Thread.Sleep(3000);
            Console.WriteLine($"We have a grand adventure ahead of us full of danger and rewards!");
            //Thread.Sleep(3000);
            Console.WriteLine($"As we depart from the port, Which direction should I point our ship?");
            //Thread.Sleep(3000);
            Console.WriteLine("  ");
            Console.WriteLine("Choices:  ");
            Console.WriteLine("  ");
            Console.WriteLine("North");
            Console.WriteLine("South");
            Console.WriteLine("East");
            Console.WriteLine("West");
            Console.WriteLine("  ");
            Console.Write($"Where will it be!? :");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "N":
                case "North":
                case "north":
                case "n":
                    {
                        Console.WriteLine($"If Captain {userName} says North, then we will go North!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"...Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    }
                case "E":
                case "East":
                case "east":
                case "e":
                    {
                        Console.WriteLine($"If Captain {userName} says East, then we will go East!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                    }
                case "West":
                case "west":
                case "W":
                case "w":
                    {
                        Console.WriteLine($"If Captain {userName} says West, then we will go West!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                    }
                case "South":
                case "south":
                case "S":
                case "s":
                    {
                        Console.WriteLine($"If Captain {userName} says South, then we will go South!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                    }

            }
        }

        public static void second()
        {
            string choice2;
            Console.WriteLine($"Nubbs is delighted that the wind is at our backs and clear skies are ahead of us.");
            //Thread.Sleep(2000);
            Console.WriteLine($"Your crew find a small island to explore and come back with $100,000 worth of treasure!");
            //Thread.Sleep(2000);
            Console.WriteLine($"Nubbs is overjoyed but he wants to know if it was beginners luck.");
            //Thread.Sleep(2000);
            Console.WriteLine($"Which direction shall i take her now, Captain?");
            //Thread.Sleep(3000);
            Console.WriteLine("  ");
            Console.WriteLine("Choices:  ");
            Console.WriteLine("  ");
            Console.WriteLine("North");
            Console.WriteLine("South");
            Console.WriteLine("East");
            Console.WriteLine("West");
            Console.WriteLine("  ");
            Console.Write($"Where will it be!? :");

            //Console.ReadKey();

            choice2 = Console.ReadLine();
            Console.Clear();

            switch (choice2)
            {
                case "N":
                case "North":
                case "north":
                case "n":
                    {
                        Console.WriteLine($"If the Captain says North, then we will go North!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"...Hoping you made the right choice, you watch your crew lower the sails...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        third();
                        break;
                    }
                case "E":
                case "East":
                case "east":
                case "e":
                    {
                        Console.WriteLine($"If the Captain says East, then we will go East!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOverTwo();
                        break;
                    }
                case "West":
                case "west":
                case "W":
                case "w":
                    {
                        Console.WriteLine($"If the Captain says West, then we will go West!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOverTwo();
                        break;
                    }
                case "South":
                case "south":
                case "S":
                case "s":
                    {
                        Console.WriteLine($"If the Captain says South, then we will go South!");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"... Hoping you made the right choice, you watch the dock distance itself from you and your crew...");
                        //Thread.Sleep(2000);
                        Console.WriteLine($"Press any button to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOverTwo();
                        break;
                    }
            }
        }
        public static void third()
        {
            Console.WriteLine($"Nubbs is stoked to see that the weather is clear and the wind is at our backs.");
            //Thread.Sleep(2000);
            Console.WriteLine($"Your crew find a huge ship wreckage with another $100,000 worth of treasure on it");
            //Thread.Sleep(2000);
            Console.WriteLine($"In the distance you see a nearby port. Your crew decide to dock and sell everything.");
            //Thread.Sleep(2000);
            Console.WriteLine($"After selling the loot, you and your crew split the $200,000. YOU WIN!");

            Console.Clear();
        }
        public static void gameOver()
        {
            Console.WriteLine($"In the distance you hear something loud..");
            //Thread.Sleep(2000);
            Console.WriteLine($"...    BOOM!");
            //Thread.Sleep(2000);
            Console.WriteLine($"...    BOOM!");
            //Thread.Sleep(2000);
            Console.WriteLine($"...    BOOOOOOOOOOM!");
            //Thread.Sleep(2000);
            Console.WriteLine($"Your ship was hit with devestaing cannonfire!");
            //Thread.Sleep(2000);
            Console.WriteLine($"You and your crew were destoryed and never saw again...");
            //Thread.Sleep(2000);
            Console.WriteLine($"GAME OVER!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void gameOverTwo()
        {
            Console.WriteLine($"You and your crew feel something pulling under the ship..");
            //Thread.Sleep(2000);
            Console.WriteLine($"... A huge tentacle come out from the ocean. ");
            //Thread.Sleep(2000);
            Console.WriteLine($"... A second tentacle come out on the other side of your ship");
            //Thread.Sleep(2000);
            Console.WriteLine($"... Even more tentacles come out of the ocean and surround your ship.");
            //Thread.Sleep(2000);
            Console.WriteLine($"Your ship has been caught by a Kraken!!");
            //Thread.Sleep(2000);
            Console.WriteLine($"You and your crew were destoryed and never saw again...");
            //Thread.Sleep(2000);
            Console.WriteLine($"GAME OVER!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void youWin()
        {

        }
    }
}
