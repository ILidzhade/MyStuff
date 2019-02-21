using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
		
		static string Prefix(string in_string)
		{
			if(String.IsNullOrWhiteSpace(in_string)) return null;
			
			int length = in_string.Length;
			int word_count = in_string.Split().Length;
			return Convert.ToString(length) + ',' + Convert.ToString(word_count) + ':' + in_string;
		}
    }
}
