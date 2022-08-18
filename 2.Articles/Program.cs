using System;

namespace _2.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currArticle = Console.ReadLine().Split(", ");
            var article = new Article(title: currArticle[0], content: currArticle[1], author: currArticle[2]);
            int countOfChanges = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfChanges; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string command = lines[0];
                string argument = lines[1];
                switch (command)
                {
                    case "Edit":
                        article.Edit(content: argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(author: argument);
                        break;
                    case "Rename":
                        article.Rename(title: argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
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
    public void Edit(string content) => Content = content;
    public void Rename(string title) => Title = title;
    public void ChangeAuthor(string author) => Author = author;
    public override string ToString() => $"{Title} - {Content}: {Author}";
}

