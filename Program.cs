﻿using System;

namespace VariablesCS
{
  class Program
  {
    static void Main(string[] args)
    {
        // Practicing Creating Variables
        var numberOfCupsOfCoffee = 0;
        var fullName = "Amanda Fox";
        var rightNow = DateTime.Now;

        Console.WriteLine($"I {fullName} drank {numberOfCupsOfCoffee} cups of coffee on {rightNow}");

        // Getting Input from User
        Console.Write("What is your name? ");
        var userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}! Have a great day!");

        // Practice getting different types of inputs
        Console.Write("Give me a number: ");
        string firstNumberAsString = Console.ReadLine();
        Console.WriteLine($"You picked: {firstNumberAsString}");
        
        Console.Write("Give me a number: ");
        string secondNumberAsString = Console.ReadLine();
        Console.WriteLine($"You picked: {secondNumberAsString}");


        // Operand
        var firstOperand = double.Parse(secondNumberAsString);
        var secondOperand = double.Parse(secondNumberAsString);

        // Sum
        var sum = (firstOperand+secondOperand);
        // Difference
        var difference = (secondOperand-firstOperand);
        // Product
        var product=(secondOperand*firstOperand);
        // Quotient
        var quotient=(firstOperand/secondOperand);
        // Remainder
        var remainder=(firstOperand%secondOperand);
        
        Console.WriteLine($"The sum of your numbers is: {sum}.\nThe difference of your numbers is: {difference}.\nThe quotient of your numbers is: {quotient}.\nThe product of your numbers is: {product}.\nThe remainder of your numbers is: {remainder}. ");



        


        


    }
  }
}
