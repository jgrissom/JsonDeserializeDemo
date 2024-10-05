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
Console.WriteLine(JsonString);
