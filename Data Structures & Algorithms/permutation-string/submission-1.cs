public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        return false;

        // Frequency arrays for letters a–z
        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        // Fill the count for s1
        for (int i = 0; i < s1.Length; i++)
        {
            char c1 = s1[i];
            s1Count[c1 - 'a']++;

            char c2 = s2[i];
            windowCount[c2 - 'a']++;
        }

        // Manually compare the two arrays
        if (AreCountsEqual(s1Count, windowCount))
            return true;

        // Start sliding the window over s2
        for (int i = s1.Length; i < s2.Length; i++)
        {
            // Add the new character to the window
            char newChar = s2[i];
            windowCount[newChar - 'a']++;

            // Remove the character that moved out of the window
            char oldChar = s2[i - s1.Length];
            windowCount[oldChar - 'a']--;

            // Compare again
            if (AreCountsEqual(s1Count, windowCount))
                return true;
        }

        return false;
    }
    private bool AreCountsEqual(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
}
