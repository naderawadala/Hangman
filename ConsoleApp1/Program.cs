using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int lives = 5;

			string[] listOfWords = new string[] { "Apple", "Banana", "Tree", "Juice", "Mandarines", "Vehicle" };

			Random random = new Random();
			int index = random.Next(0, listOfWords.Length);

			string word = listOfWords[index];

			char[] guessedLetters = new char[word.Length];

			for(int i=0; i<word.Length; i++)
			{
				guessedLetters[i] = '-';
			}

			while (lives > 0)
			{
				if (!guessedLetters.Contains('-'))
				{
					Console.WriteLine("You win! ");
					break;
				}

				Console.WriteLine("Please type a letter: ");
				char letter = char.Parse(Console.ReadLine());

				if (guessedLetters.Contains(letter))
				{
					Console.WriteLine("You already guessed this character, try again!");
					continue;
				}
				if (word.Contains(letter))
				{
					Console.WriteLine($"The word contains the letter {letter}, guessed so far: ");
					for(int j=0; j<word.Length; j++)
					{
						if(word[j] == letter)
						{
							guessedLetters[j] = letter;
						}
						Console.Write($"{guessedLetters[j]} ");
					}
					Console.WriteLine();
					continue;
				}
				else
				{
					lives--;
					Console.WriteLine($"You did not guess correctly! You have {lives} lives remaining");
				}
			}
		}
	}
}

