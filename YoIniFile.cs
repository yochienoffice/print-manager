using System.Runtime.InteropServices;
using System.Text;

public class YoIniFile
{
    private string path;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

    public YoIniFile(string path)
    {
        this.path = path;
    }

    public void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, this.path);
    }

    public string Read(string section, string key, string defaultValue = "")
    {
        StringBuilder retVal = new StringBuilder(255);
        GetPrivateProfileString(section, key, defaultValue, retVal, 255, this.path);
        return retVal.ToString();
    }
}
