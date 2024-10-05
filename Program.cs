using System.Text.Json;

List<Blog> blogs = JsonSerializer.Deserialize<List<Blog>>(File.ReadAllText("blogs.json"))!;
foreach (Blog blog in blogs)
{
  Console.WriteLine(blog.Name);
  foreach (Post post in blog.Posts)
  {
    Console.WriteLine($"\t{post.Title} - {post.Description}");
  }
}
