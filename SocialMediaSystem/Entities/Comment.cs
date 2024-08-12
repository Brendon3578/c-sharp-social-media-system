using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSystem.Entities
{
    class Comment
    {

        public int Id { get; set; }
        public string Text {  get; set; }
        public int AuthorId {  get; set; }

        public Comment()
        {
        }

        public Comment(int id, string text, int authorId)
        {
            Id = id;
            Text = text;
            AuthorId = authorId;
        }

        public override string ToString()
        {
            return $"ID: {Id}, AuthorId: {AuthorId} Text: {Text}";
        }
    }
}
