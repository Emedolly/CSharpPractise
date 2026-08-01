// See https://aka.ms/new-console-template for more information

using BasicPrograms.Topic1;
using CSharpPractise.DotnetLogicLab;
using CSharpPractise.DotnetLogicLab.Day02;
using CSharpPractise.DotnetLogicLab.Day03;
using CSharpPractise.DotnetLogicLab.Day04;

//Console.WriteLine("Hello, World!this is eme");

//TwoIntegers t = new TwoIntegers();
//t.AddTwoIntegers();
// SwapValues s = new SwapValues();
// s.SwapTwoValues();
//EvenOrOdd eo = new EvenOrOdd();
//eo.CheckEvenOrOdd();
//PrintOddNum PON = new PrintOddNum();
//PON.PrintOddNumbers();
//PositiveOrNot positiveOrNot = new PositiveOrNot();
//positiveOrNot.CheckNumberIsPositiveOrNot();
//LargetNumAmongTwo largest = new LargetNumAmongTwo();
//largest.FindLargetNumAmongTwo();
//PrintMultiples PM = new PrintMultiples();
//PM.PrintMultiplesOfNumber();
//PrintMultiplesWithCond printMultiplesWithCond = new PrintMultiplesWithCond();
//printMultiplesWithCond.PrintMultiplesOfNumber();
// SumUsingRecursion sumUsingRecursion = new SumUsingRecursion();
// // sumUsingRecursion.SumUsingRecursion1();
// Calculator calculator = new Calculator();
// calculator.EnterDigitsAndOperator(10,5,"+");
// MultiplicationtTable multiplication = new MultiplicationtTable();
// multiplication.Multiply(5);
// SumOfDigits sum = new SumOfDigits();
// sum.Sum(12345);
// ReverseNumber reverseNumber = new ReverseNumber();
// reverseNumber.reverse(123);
// PrimeNumber P = new PrimeNumber();
// P.VerifyPrimeNumber(6);
// FizzBuzz check = new FizzBuzz();
// check.FizzBuzzPrint();
// SquarePrint square = new SquarePrint();
// square.Square(5,5);
// RightTriangle rightTriangle = new RightTriangle();
// rightTriangle.RightTrianglePrint(5);
// InvertedTriangle invertedTriangle = new InvertedTriangle();
// invertedTriangle.InvertedTrianglePrint(5);
// SumArray temp = new SumArray();
// temp.SumAndAverageOfArray();
// ArrayMinMax array = new ArrayMinMax();
// array.MinAndMaxOfArray();
// ReverseArray reverseArray = new ReverseArray();
// reverseArray.ReverseOfAnArray();
// EvenOdd evenOdd = new EvenOdd();
// evenOdd.EvenOrOddInArray();
// SecondLargestNumber secondLargestNumber = new SecondLargestNumber();
// secondLargestNumber.SecondLargestNumberMethod();
// ReverseString reverseString = new ReverseString();
// reverseString.ReverseOfAString();
// PalindromeCheck palindromeCheck = new PalindromeCheck();
// palindromeCheck.PalindromeNumber();
// StringPalindrome strPalindrome = new StringPalindrome();
// strPalindrome.PalindromeCheck();
// CountVowels countVowels = new CountVowels();
// countVowels.countVowelsAndConsonants();
// CountOccurance count = new CountOccurance();
// count.CountOccuranceOfACharacter("Programming","g");
// StringAnagram stringAnagram = new StringAnagram();
// stringAnagram.StringAnagrams("silent", "listen");
// CharacterFrequency characterFrequency = new CharacterFrequency();
// characterFrequency.CountCharacters();
// RemoveDuplicates removeDuplicates = new RemoveDuplicates();
// removeDuplicates.RemoveDuplicatesCharacters();
// ArrayProgramMatrix arrayProgramMatrix = new ArrayProgramMatrix();
// arrayProgramMatrix.ArrayPrint();
// TransposeOfMatrix transpose = new TransposeOfMatrix();
// transpose.Transpose();
// CheckEvenorOdd checkEvenorOdd = new CheckEvenorOdd();
// bool result = checkEvenorOdd.IsEven(14);
// if (result)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }
// MethodOverloading method = new MethodOverloading();
// var result = method.Add(1.5, 2);
// Console.WriteLine($"Result is: {result}");
FactorialRecursion factorialRecursion = new FactorialRecursion();
// factorialRecursion.FactorialNumber(5);
int result = factorialRecursion.FactorialNumberRecursion(5);
Console.WriteLine(result);
Console.ReadLine();