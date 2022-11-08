using System;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] Array = original.ToCharArray();
            string reverse = String.Empty;
            for (int i = Array.Length - 1; i > -1; i--)
            {
                reverse += Array[i];
            }
            return reverse;
        }
    }
}
