using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_MovieList
{
    class Movie
    {
        
        private string _title;
        private string _category;

        public string Title
        {
            get { return _title; }
            set { _title = value;  }
        }

        public string Category 
        {
            get { return _category; }
            set { _category = value; }
        }

        public Movie() { }

        public Movie(string Title, string Category)
        {
            _title = Title;
            _category = Category;

        }

        public void PrintMovie()
        {
            Console.WriteLine($"The movie title is {_title} and the category is {_category}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"The movie title is: {_title}");
        }

        public void PrintCategory()
        {
            Console.WriteLine($"The movie category is: {_category}");
        }


    }
}
