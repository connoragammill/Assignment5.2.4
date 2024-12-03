namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if its a palindrome:");
            string word = Console.ReadLine();
            bool isPalindrome = IsPalindrome(word);
			Console.WriteLine("The string is " + (isPalindrome ? "" : "not ") + "a palindrome");//use : for or so it either says its a palindrome or not a aplindrome
		}
        static bool IsPalindrome(string letters)
        {
            int n = letters.Length;
            for (int i = 0; i < n/2; i++)
            {
                if (letters[i] != letters[n-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
