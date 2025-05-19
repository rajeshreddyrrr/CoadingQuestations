// See https://aka.ms/new-console-template for more information
using CoadingQuestations;

Console.WriteLine("Hello, World!");
Palindrome p = new Palindrome();
Console.WriteLine("Palindrome using Reverse Method: "  +p.IsPalindrome("madam1"));
Console.WriteLine("Palindrome without using Reverse Method: " + p.IsPalindromeWithoutUsingReverse("madam1"));
    Console.WriteLine("Palindrome Number: " + p.IsPalindromeInteger(121));

SwapingNumbers s = new SwapingNumbers();
Console.WriteLine(s.SwapNUmberusingtwoVariables(20, 50));
Console.WriteLine(s.SwapNumbersUsingtempVariable(20, 50));

Reverse r = new Reverse();
Console.WriteLine("Reverse Integer: " +r.ReverseInterger(1234));
Console.WriteLine("Reverse String: " + r.ReverseString("1234"));
Console.WriteLine("Reverse Arrat: " + r.ReverseArray(["1","2","3","4"]));

Sum sum = new Sum();
Console.WriteLine("Sum of digits of a number : " +sum.SumOfNumbers(1234));


Duplicates duplicates = new Duplicates();
Console.WriteLine("Duplicate Characters using HAsh Set: " + duplicates.FindDupesIntArrayUsingHashSet([1, 2, 3, 2, 4, 5, 1, 6, 3]));
foreach (int i in duplicates.FindDupesIntArrayUsingHashSet([1, 2, 3, 2, 4, 5, 1, 6, 3]))
{
    Console.WriteLine(i);
}

Console.WriteLine("Duplicate Characters using Linq Query: " + duplicates.FindDupesStringArrayUsingHashSet(["1", "2", "3", "2", "4"," 5", "1","6","3"]));
foreach (int i in duplicates.FindDupesIntArrayUsingHashSet([1, 2, 3, 2, 4, 5, 1, 6, 3]))
{
    Console.WriteLine(i);
}

Console.WriteLine("Duplicate Characters using Linq Query: " + duplicates.FindDupesUsingLinqQuery([1, 2, 3, 2, 4, 5, 1, 6, 3]));
foreach (int i in duplicates.FindDupesIntArrayUsingHashSet([1, 2, 3, 2, 4, 5, 1, 6, 3]))
{
    Console.WriteLine(i);
}

Numbers numbers = new Numbers();
Console.WriteLine("Higest Number in 3 : " + numbers.FindHigestNumbers(10,11,12));
Console.WriteLine("Higest Number in array : " + numbers.FindHigestInArray([1, 2, 3, 2, 4, 5, 1, 6, 3]));
Console.WriteLine("Higest Number in array : " + numbers.FindHigestamdLowestInArray([1, 2, 3, 2, 4, 5, 1, 6, 3]));


StringsManipulation stringsManipulation = new StringsManipulation();
Console.WriteLine("Find Occurrences Of Each Character : " + stringsManipulation.FindOccurrencesOfEachCharacter("Hello World"));
foreach (var item in stringsManipulation.FindOccurrencesOfEachCharacter("Hello World"))
{
    Console.WriteLine(item);
}

Console.WriteLine("Reverse words in Sentense : " + stringsManipulation.ReverseWordsInSentense("Hello World"));
