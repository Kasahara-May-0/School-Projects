using System;
class Prgm
{
    public static void Main(string[] args)
    {
        int[] ar = new int[10]; Random rnd = new Random(); var txt = "I said that's a lie that I am racist";
        for (int i = 0; i < ar.Length; i++) { ar[i] = rnd.Next(0, 100); }
        Console.WriteLine($"{string.Join(",", ar)} | result: {txt} -> {string.Join("",Sub(txt.ToCharArray(), 26))}");
        
    }
    static T[] Sub<T>(T[] ar, int offset = 0, int length = -1)
    { // -1 means 'to the end'
        length = length == -1 ? ar.Length - (offset) : length;
        List<T> list = new List<T>();
        for (int i = offset-1; i < length+offset; i++)
        {
            list.Add(ar[i]);
        }
        return list.ToArray();
    }
}