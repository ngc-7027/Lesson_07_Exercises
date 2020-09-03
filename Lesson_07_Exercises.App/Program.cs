using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ChessPlayersParser chessPlayersParser = new ChessPlayersParser();

            var age = 30;
            var eloRatingMin = 1500;
            var eloRatingMax = 5500;
            var country = Country.China;

            // ======================================================================================================================================================

            var playersOlderThanSpecifiedAge = chessPlayersParser.GetChessPlayersOlderThanSpecifiedAge(age);

            Console.WriteLine("Chess players older than {0}:", age);
            foreach (var chessPlayer in playersOlderThanSpecifiedAge)
            {
                Console.WriteLine("{0} {1}, {2}", chessPlayer.FirstName, chessPlayer.LastName, chessPlayer.AgeInYears);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var playersInEloRatingRange = chessPlayersParser.GetChessPlayersInEloRatingRange(eloRatingMin, eloRatingMax);

            Console.WriteLine("Chess players in elo rating from {0} to {1}:", eloRatingMin, eloRatingMax);
            foreach (var chessPlayer in playersInEloRatingRange)
            {
                Console.WriteLine("{0} {1}, {2}", chessPlayer.FirstName, chessPlayer.LastName, chessPlayer.EloRating);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var playersOlderThanSpecifiedAgeFromSpecifiedCoutry = chessPlayersParser.GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(age, country);

            Console.WriteLine("Chess players older than {0} from {1}:", age, country);
            foreach (var chessPlayer in playersOlderThanSpecifiedAgeFromSpecifiedCoutry)
            {
                Console.WriteLine("{0} {1}, {2}, {3}", chessPlayer.FirstName, chessPlayer.LastName, chessPlayer.AgeInYears, chessPlayer.Country);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var playersWithHigherOrEqualEloRatingGroupedByCountry = chessPlayersParser.GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(eloRatingMin, country);

            Console.WriteLine("Chess players with elo rating higher or equal to {0} grouped by country:", eloRatingMin);
            foreach (var group in playersWithHigherOrEqualEloRatingGroupedByCountry)
            {
                foreach (var chessPlayer in group)
                {
                    Console.WriteLine("{0} {1}, {2}, {3}", chessPlayer.FirstName, chessPlayer.LastName, group.Key, chessPlayer.EloRating);
                }
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            // ======================================================================================================================================================

            // ======================================================================================================================================================

            var numberHandler = new NumberHandler();

            var listOfNumbers = new List<int>();

            var maxValueOfListOfNumbers = 100;

            var divisors = new List<int> { 2, 3, 5 };

            for (int i = 0; i < maxValueOfListOfNumbers; i++)
            {
                listOfNumbers.Add(i);
            }

            // ======================================================================================================================================================

            var evenNumbers = numberHandler.GetEvenNumbers(listOfNumbers);

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var oddNumbers = numberHandler.GetOddNumbers(listOfNumbers);

            Console.WriteLine("Odd numbers:");
            foreach (var number in oddNumbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var numbersDivisibleByAllDivisors = numberHandler.GetNumbersDivisibleByAllDivisors(listOfNumbers, divisors);

            Console.WriteLine("Numbers divisible by all divisors:");
            foreach (var number in numbersDivisibleByAllDivisors)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var numbersDivisibleByAtLeastOneDivisor = numberHandler.GetNumbersDivisibleByAtLeastOneDivisor(listOfNumbers, new List<int> { 2, 3, 5 });

            Console.WriteLine("Numbers divisible by at least one divisor:");
            foreach (var number in numbersDivisibleByAtLeastOneDivisor)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var numbersNotDivisibleByAnyDivisor = numberHandler.GetNumbersNotDivisibleByAnyDivisor(listOfNumbers, divisors);

            Console.WriteLine("Numbers not divisible by any divisors:");
            foreach (var number in numbersNotDivisibleByAnyDivisor)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            // ======================================================================================================================================================

            var primeNumbers = numberHandler.GetPrimeNumbers(listOfNumbers);

            Console.WriteLine("Prime numbers:");
            foreach (var number in primeNumbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
