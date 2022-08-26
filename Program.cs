using System;

namespace my_own_hangman_game
{
    internal class Program
    {
        /*
         Things to do

        Whats in the hangman game? 
        
        - a score board in the form of a hangmans 
        noose and a body that will add more and more each time you get a 
        letter wronguntil you see the full picture

        - a place for letters already used

        - empty letter spaces for the word you are trying to guess

        The logic needed to make the game work

        - start with an empty game board

        - once the game starts a word will be chosen at random and a series of letter 
        spaces will appear showing how many letters are needed to get the word

        - you guess a letter, the game checks to see if the letter is in the randomised word or not

        - if the letter that you guessed is not in the random word, then part of the hangman 
        drawing will be added to to game display and the letter guessed will be added to the 
        already selected letters list

        - if the letter you chose is right then a letter in the word to guess will appear 
        in its correct place

        - this repeats until the game is won or lost, loosing will have letters in the word to guess 
        missing and a full hangman and body will be shown, if you win, the drawing will be incomplete
        and the word to guess will be completed and you will have a victory message shown to you

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
