using System.Text.Json;
using LeetCodeCSharp.Problems.Array;
using LeetCodeCSharp.Problems.String;

var ans = new Q20().IsValid("]");
Console.WriteLine(ans);

// string json = JsonSerializer.Serialize(ans, new JsonSerializerOptions());
// Console.WriteLine(json);