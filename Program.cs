// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

//initialize variables
int numberOfSandwhiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwhichCost;
double totalToppingCost;
double baseCost;
double orderCost;

//initialize constants
const double COST_OF_SANDWHICH = 4.75;
const double COST_OF_TOPPING = 0.15;
const double DISCOUNT_AMOUNT = 0.1;

//prompt the user for # of sandwhiches
System.Console.WriteLine("How many sandwhiches?");
numberOfSandwhiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwhiches: "+numberOfSandwhiches);

//prompt user for # of toppings
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings: "+numberOfToppings);

//prompt user for tip amount
System.Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine("Tip amount: "+tip);

//final output calculations for overall price
totalSandwhichCost = COST_OF_SANDWHICH*numberOfSandwhiches;
totalToppingCost = COST_OF_TOPPING*numberOfToppings;
baseCost = totalSandwhichCost+totalToppingCost;
orderCost = tip + baseCost*(1-DISCOUNT_AMOUNT);

//display final output 
System.Console.WriteLine("Total Amount: "+orderCost);