public static class Utils
{
    public static string Md5Hash(this string value)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();
        var inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
        var hashBytes = md5.ComputeHash(inputBytes);
        var sb = new System.Text.StringBuilder();
        foreach (var t in hashBytes)
        {
            sb.Append(t.ToString("X2"));
        }
        return sb.ToString();
    }
}