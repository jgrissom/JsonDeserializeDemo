using System.Text.Json;

string JsonString = """
  {
    "Name": "Baseball"
  }
""";
// Console.WriteLine(JsonString);

Blog? blog = JsonSerializer.Deserialize<Blog>(JsonString)!;
Console.WriteLine(blog.Name);
