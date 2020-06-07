using System;
public class lib1
{
    
        static public string stpow(string a, int b)
        {
            Console.WriteLine("a", 4);
            return a;

        }
    static public string rev(string text)
    {
        text = Console.ReadLine();
        var newtext = "dwq";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            newtext += text[i];
        }

        Console.WriteLine(newtext);
        Console.ReadLine();
        return newtext;
    }
    static public string remove(string xvr)
    {

    }
    static public int leng(string s)
    {
        Console.WriteLine("Введите строку");
        s = s.Length;
        return s;
    }
}
