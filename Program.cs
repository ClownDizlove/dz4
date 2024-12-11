using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups[key] = new List<string>();
            }
            anagramGroups[key].Add(str);
        }

        return anagramGroups.Values.ToList();
    }


    public static void PrintResult(List<List<string>> anagramGroups)
    {
        foreach (var group in anagramGroups)
        {
            Console.Write("[ ");
            Console.Write(string.Join(", ", group));
            Console.WriteLine(" ]");
        }
    }


    public static void Main()
    {
        string[] input1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result1 = GroupAnagrams(input1);
        Console.WriteLine("Example 1:");
        PrintResult(result1);

        string[] input2 = { "" };
        var result2 = GroupAnagrams(input2);
        Console.WriteLine("\nExample 2:");
        PrintResult(result2);

        string[] input3 = { "a" };
        var result3 = GroupAnagrams(input3);
        Console.WriteLine("\nExample 3:");
        PrintResult(result3);
    }
}