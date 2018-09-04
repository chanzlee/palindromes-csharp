using System;

namespace PalindromeChecker
{
	public class Program
	{
		public static void Main()
		{
			Console.Write("Enter word: ");
			var wordInput = Console.ReadLine();
			var wordLen = wordInput.Length;

      char[] wordArray = wordInput.ToCharArray();
      Array.Reverse(wordArray);
      var stringReversed = String.Join("", wordArray);
      Console.WriteLine(stringReversed);

      if (wordInput == stringReversed)
      {
        Console.WriteLine("It's a palindrome!");
      }
      else
      {
        Console.WriteLine("Uh... This is not a palindrome");
      }
    }
	}
}
