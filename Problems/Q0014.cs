namespace LeetCodeProject.Problems;

public class Q0014 {
    public string LongestCommonPrefix(string[] strs)
    {
        var latestPrefix = strs[0];

        foreach (var str in strs)
        {
            if (latestPrefix == "" || str == "")
            {
                return "";
            }

            var count = 0;
            for (var i = 0; i < str.Length && i < latestPrefix.Length; i++)
            {
                if (latestPrefix[i] != str[i])
                {
                    break;
                }
                count++;
            }
            latestPrefix = latestPrefix.Substring(0, count);
        }

        return latestPrefix;
    }
}