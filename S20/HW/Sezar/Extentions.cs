using System.IO.Pipelines;
using System.Text;

public static  class Ext
{
    public static string Decoder(this string str)
    {
        string result = "";
        int start = 0;
        if (str == null)
        {
            throw new InvalidDataException();
        }
        foreach (var c in str)
        {
            if (char.IsLetter(c)){
            if (char.IsUpper(c))
            {
                start = 65;
            }
            else if (char.IsLower(c))
            {
                start = 97;
            }
            result +=(char)((c+3-start)%26+start);
            }
            else 
            {
                result+=c;
            }

        }
        return result;

    }


    public static string Encoder(this string str)
    {
        string result = "";
        int start = 0;
        if (str == null)
        {
            throw new InvalidDataException();
        }
        foreach (var c in str)
        {
            if (char.IsLetter(c)){
            if (char.IsUpper(c))
            {
                start = 65;
            }
            else if (char.IsLower(c))
            {
                start = 97;
            }
            result +=(char)((c-3-start)%26+start);
            }
            else 
            {
                result+=c;
            }

        }
        return result;

    }

}