using System.Text.Json;

string JsonString = """
  [
    {
      "Name": "⚾ Baseball",
      "Posts": [
        { "Title": "Pitchers", "Description": "Tobias Myers is my favorite pitcher" },
        { "Title": "Outfielders", "Description": "Jackson Chourio is my favorite outfielder" }
      ]
    },
    {
      "Name": "😳 Exercise",
      "Posts": [
        { "Title": "Yoga", "Description": "Yoga is a wonderful exercise - Namaste" },
        { "Title": "Cycling", "Description": "is FUN" },
        { "Title": "Weight Training", "Description": "Builds more muscle" }
      ]
    }
  ]
""";
// Console.WriteLine(JsonString);

List<Blog> blogs = JsonSerializer.Deserialize<List<Blog>>(JsonString)!;
foreach (Blog blog in blogs)
{
  Console.WriteLine(blog.Name);
  foreach (Post post in blog.Posts)
  {
    Console.WriteLine($"\t{post.Title} - {post.Description}");
  }
}
