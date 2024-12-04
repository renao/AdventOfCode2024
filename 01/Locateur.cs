namespace AdventOfCode2024._01;

public static class Locateur
{
    public static int TotalDistance()
    {
        int[] left, right;
        ReadLocationData(out left, out right);

        var totalDistance = 0;
        for (int i = 0; i < left.Length; i++)
        {
            totalDistance += SingleDistance(left[i], right[i]);
        }

        return totalDistance;
    }

    public static int SimilarityScore()
    {
        int[] left, right;
        ReadLocationData(out left, out right);

        var similarityScore = 0;
        
        for (int i = 0; i < left.Length; i++)
        {
            similarityScore += SingleSimilarity(left[i], right);
        }
        
        return similarityScore;
    }

    private static int SingleDistance(int left, int right) 
        => Math.Abs(left - right);

    private static int SingleSimilarity(int left, int[] right)
    {
        var count = right.Count(i => left == i);
        return count * left;
    }


    private static void ReadLocationData(out int[] left, out int[] right)
    {
        var readLeft = new List<int>();
        var readRight = new List<int>();
        using (var sr = new StreamReader(Path.Combine("01","Locations.input")))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split(' ', StringSplitOptions.TrimEntries);
                readLeft.Add(int.Parse(parts.First()));
                readRight.Add(int.Parse(parts.Last()));
            }
        }

        left = readLeft.Order().ToArray();
        right = readRight.Order().ToArray();
    }
}