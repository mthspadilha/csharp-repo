using System;
using System.Collections.Generic;
using System.Text;

namespace PostProgram.entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        //O atributo list<comments> não entra no construtor geralmenteo por ser um pra muitos 
        public Post(DateTime moment, string tittle, string content, int likes)
        {
            Moment = moment;
            Tittle = tittle;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
