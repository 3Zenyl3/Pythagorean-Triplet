public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> res = new List<(int a, int b, int c)>();
        for (int a = 1; a < sum; a++)
        {
            for (int b = a+1; b < sum; b++)
            {
                int c = sum - b-a;
                {
                    if (c>b && a * a + b * b == c * c)
                    {
                        res.Add((a, b, c));
                    }
                }
            }
        }
        return res;
    }
}
