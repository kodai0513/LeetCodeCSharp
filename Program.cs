using System.Text.Json;
using LeetCodeCSharp.Problems.Array;
using LeetCodeCSharp.Problems.String;

var ans = new Q118().Generate(5);
// Console.WriteLine(ans);

string json = JsonSerializer.Serialize(ans, new JsonSerializerOptions());
Console.WriteLine(json);