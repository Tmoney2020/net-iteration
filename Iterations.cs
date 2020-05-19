using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var toYell = words.Select(yelling => yelling.ToUpper());

            return toYell;
        }


        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.


        // P - We want to take in a list of numbers and return that list but with all the numbers doubled 
        // E - List 1 [1, 2, 3,] and we want it returned as List 2 [2, 4, 6]
        // D - We have a List of numbers [1, 2, 2] and we are returning a list of numbers 
        // A - Step 1 create a list of numbers 
        //      step 2 individually go through each number and multipy it by 2 
        //      step 3 put those numbers back into a list 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var doubleTheNumbers = numbers.Select(number => number * 2);

            return doubleTheNumbers;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.


        // P - We want to take in a list of strings and return a list of strings with the index of each element of the string. 
        // E - String 1 = [Trent, Gavin, Kento] and we want the new string to be [Trent is at index [0], Gavin is at index[1], Kento is at index [2]]
        // D - Inital List, Final list, index number, 
        // A - Step 1 find out the index of where each element is on the list. 
        //      Step 2. create a list that adds "is at index X to each element of the list 
        //      step 3. print out the list
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var indexString = data.Select((data, indexOfWord) => $"{data} is at index {indexOfWord}");

            return indexString;
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var evenNumbers = data.Where(data => (data % 2 == 0));

            return evenNumbers;
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            var evenIndex = data.Where((data, indexOfData) => indexOfData % 2 == 0);

            return evenIndex;
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.




        //P - The problem is we have a list of a bunch of objects that are movies.
        // IN the movie they have a name, year, and score. We want to return all the movies that 
        // are from a certain year and have a score of at least 90

        //E - Movie 1: 
        //            Name: titanic 
        //            Year: 2017
        //            score 90
        //     Movie 2: 
        //              Name: Sleepless in Seattle 
        //              Year: 1975
        //              score: 50
        //  Return Titanic 
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            return data.Where(movie => movie.Year == year && movie.Score > 90).Select(movie => movie.Name);

            // var theOldMovies = movies.Where(movie => movie.ReleasedDate.Year < 1965);
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            var oddNumbers = data.All(data => (data % 2 == 1));

            return oddNumbers;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            var titles = data.Single(data => data.Contains("needle"));

            return titles;
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            var needleFound = data.FindIndex(data => data.Contains("needle"));

            return needleFound;

        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            var foundLove = data.Any(data => data.Count() == 4);

            return foundLove;
        }
    }
}