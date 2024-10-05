using System.Text.Json;

string JsonString = """
  {
    "Name": "⚾ Baseball",
    "Posts": [
      { "Title": "Pitchers", "Description": "Tobias Myers is my favorite pitcher" },
      { "Title": "Outfielders", "Description": "Jackson Chourio is my favorite outfielder" }
    ]
  }
""";
// Console.WriteLine(JsonString);

Blog? blog = JsonSerializer.Deserialize<Blog>(JsonString)!;
Console.WriteLine(blog.Name);
foreach (Post post in blog.Posts)
{
  Console.WriteLine($"\t{post.Title} - {post.Description}");
}
