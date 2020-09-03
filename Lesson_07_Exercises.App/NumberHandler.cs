using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class NumberHandler : INumberHandler
    {
        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = number - 1; i >= 2 ; i--)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {  
            IEnumerable<int> evenNumbers = numbers
                .Where(n => n % 2 == 0);
            return evenNumbers;
        }

        public IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            IEnumerable<int> oddNumbers = numbers
                .Where(n => n % 2 - 1 == 0);
            return oddNumbers;
        }

        public IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            var numbersDivisibleByAllDivisors = numbers
                .Where(n => (n > 0) && divisors.All(d => n % d == 0));
            return numbersDivisibleByAllDivisors;

        }

        public IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            var numbersDivisibleByAtLeastOneDivisor = numbers
                .Where(n => (n > 0) && divisors.Any(d => n % d == 0));
            return numbersDivisibleByAtLeastOneDivisor;
        }

        public IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {            
            var numbersNotDivisibleByAnyDivisor = numbers
                .Where(n => (n > 0) && divisors.All(d => n % d != 0));
            return numbersNotDivisibleByAnyDivisor;
        }

        public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
        {
            var primeNumbers = numbers
                .Where(n => (IsPrime(n)));
            return primeNumbers;
        }
    }
}
