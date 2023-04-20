using System;

namespace Constructors_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //makes a game object called myGame with a custom value set for title and genre
            Game myGame = new Game("CS;GO", "FPS");
            
            //prints text with title and genre that was set
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            //makes a game object called myotherGame with a default value set for title and genre
            Game myOtherGame = new Game();

            //prints text with title and genre that was set
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
