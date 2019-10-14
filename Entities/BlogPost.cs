using System;

namespace Blog.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
        public string Summary => Content.Substring(0, 50); // todo: replace last character by ...
    }
}
