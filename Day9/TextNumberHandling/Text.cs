namespace TextLibrary;
static class Text
{
    public static string Lowercase(string text)
    {
        return text.ToLower();
    }

    public static string Uppercase(string text)
    {
        return text.ToUpper();
    }

    public static string Join(string textA, string textB )
    {
        return textA + textB;
    }
}