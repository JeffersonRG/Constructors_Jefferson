using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Jefferson
{
    class Game
    {
        //Backing for title and genre
        public string title, genre;

        /// <summary>
        /// making a default value for title and genre, also a custom value
        /// </summary>
        /// <param name="titleParam">sets the title to the custom value or sets to default value</param>
        /// <param name="genreParam">sets the genre to the custom value or sets to default value</param>
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}
