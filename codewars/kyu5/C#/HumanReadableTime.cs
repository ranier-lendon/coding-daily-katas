// Link: https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int h = seconds/3600;
        int m = (seconds/60)%60;
        int s = seconds%60;
        return $"{h:00}:{m:00}:{s:00}";
    }
}