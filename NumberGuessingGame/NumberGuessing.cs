using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        private int numberToGuess;
        private int minimum;
        private int maximum;

        public NumberGuessing(int minimum, int maximum)
        {
            GenerateRandomNumber(minimum,maximum);
        }

        public void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);

            this.minimum = minimum;
            this.maximum = maximum;
        }

        public GuessResult MakeGuess(int guess)
        {
            if (guess > maximum)
            {
                return GuessResult.OutOfLimits;
            }
            else if (guess < minimum)
            {
                return GuessResult.OutOfLimits;

            }
            else
                if (guess == numberToGuess)
                {
                    return GuessResult.Correct;
                }
                else if (guess < numberToGuess)
                {
                    return GuessResult.TooLow;
                }
                else
                {
                    return GuessResult.TooHigh;
                }
        }
    }
}
