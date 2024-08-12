using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSystem.Entities
{
    internal class Post
    {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long AuthorId { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string description, long authorId, int likes)
        {
            Moment = moment;
            Title = title;
            Description = description;
            AuthorId = authorId;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveCommentById(int id)
        {
            var commentToRemove = Comments.FirstOrDefault(c => c.Id == id);
            if (commentToRemove != null)
            {
                Comments.Remove(commentToRemove);
            }
            else
            {
                Console.WriteLine($"Comment with ID {id} not exists!");
            }
        }

        public List<Comment> FindCommentsByAuthorId(int authorId)
        {
            if (Comments == null)
            {
                return new List<Comment>(); // Retorna uma lista vazia se Comments for null
            }
            return Comments.Where(c => c.AuthorId  == authorId).ToList();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine(Description);
            sb.AppendLine("Comments: ");
            sb.AppendLine(string.Join(Environment.NewLine, Comments.Select(c => c.Text)));
            return sb.ToString();
        }
    }
}
