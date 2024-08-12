using SocialMediaSystem.Entities;

namespace SocialMediaSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post(DateTime.Now, "First Post", "This is the description of the first post.", 1, 10);

            // Adicionando comentários ao post
            post.AddComment(new Comment { Id = 1, Text = "Great post!", AuthorId = 2 });
            post.AddComment(new Comment { Id = 2, Text = "Very informative.", AuthorId = 3 });
            post.AddComment(new Comment { Id = 3, Text = "Thanks for sharing!", AuthorId = 3 });

            Console.WriteLine("Initial comments:");

            ListAllCommentsInPost(post);

            post.RemoveCommentById(1);

            Console.WriteLine("\nComments after removal:");
            ListAllCommentsInPost(post);

            Console.WriteLine("\nTrying to remove one coment that don't exists:");

            post.RemoveCommentById(5);

            var postsMadeBySpecificAuthor = post.FindCommentsByAuthorId(3);
            postsMadeBySpecificAuthor.ForEach(Console.WriteLine);

            Console.WriteLine("\nPost:");
            Console.WriteLine(post);

        }

        static void ListAllCommentsInPost(Post post)
        {

            post.Comments.ForEach(Console.WriteLine);
        }
    }
}
