namespace AdventOfCode2024._02;

public static class Saviour
{
    public static int SafeReports()
    {
        var reports = ReadReportsData();
        return AnalyzeReports(reports);
    }

    private static int AnalyzeReports(int[][] reports)
        => reports.Count(IsSafe);

    private static bool IsSafe(int[] report)
    {
        var initialDirection = Math.Sign(report[0] - report[1]);
        
        for (var i = 0; i < report.Length - 1; i++)
        {
            var difference = report[i] - report[i + 1];
            var levelDirection = Math.Sign(difference);
            var diffValue = Math.Abs(difference);

            if (levelDirection != initialDirection
                || diffValue is < 1 or > 3)
            {
                return false;
            }
        }

        return true;
    }
    
    private static int[][] ReadReportsData()
    {
        var readReports = new List<int[]>();
        using (var sr = new StreamReader(Path.Combine("02","Reports.input")))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split(' ', StringSplitOptions.TrimEntries);
                var reportLevels = parts.Select(int.Parse);
                readReports.Add(reportLevels.ToArray());
            }
        }

        return readReports.ToArray();
    }
}