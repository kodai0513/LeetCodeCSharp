using System.Text.Json;
using LeetCodeCSharp.Problems.Array;
using LeetCodeCSharp.Problems.String;

var rows = new Q119().GetRow(4);
foreach(var row in rows)
{
    Console.Write(row);
}