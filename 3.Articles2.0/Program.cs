﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace _3.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            List<string> articleArr = new List<string>();
            for (int i = 0; i < countOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ");
                var newArticle = new Article(title: currentArticle[0], content: currentArticle[1], author: currentArticle[2]);
                Console.WriteLine(newArticle);
            }
            string word = Console.ReadLine();
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Rename(string title) => Title = title;
        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
