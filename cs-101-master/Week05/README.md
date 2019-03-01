# Week 5:  Basic Arithmetic

## Overview

While arithmetic is not a long topic to cover, it is still an important one and most students will not have much difficult understanding this topic. Start by reviewing the basic operators that students would typically encounter, `+` (addition), `-` (subtraction), `*` (multiplication) and `/` (division). Once students have seen each introduce them to the modulus operator (`%`), a few students in the past have found a practical application for this operator during final projects. Once students have used our basic operators to perform simple operations show them how we can condense these lines buy using `+=`, `-=`, `++`, `--`, ect.. 

If students have been introduced to Functions and Methods (which is highly encouraged) this would be a great time to introduce them to Parameters and Return types. A great in class activity would be some type of simple calculator (Attached as `HytechCalculator.cs`). 

##Lecture
Guided lesson: PowerPoint ‘7 Basic Arithmetic’
* Use arithmetic statements
	* +, -, *, /
	* +=, -=, *=, /=
	* ++, --

Guided lesson: PowerPoint 'Methods'
* Review basic `void` methods that write to console
* Introduce `parameters`
	* Students get caught up on the vaiable name being passed in and the parameter name not matching, stress only the datatypes need to match, name doesnt matter!
* Introduce `return types`
	* Show how methods can return `int`, `bool` or just about anything really!

* Create a simple calculator application
	* Ask user what opperation to run, and ask for 2 numbers to perform that action on. 
	* Work should be done in a method, taking in both numbers as parameters and returning the result of the calculation!
	* Build `+` and `-` with the students, and let them add `*`, `%` and `%` as challenge work


## Individual Exercises
	Expand on the Calculator App (see above) 

## Post-Work
	To students: Write any outstanding questions to Piazza


## Week 6 Recap(Previous Piazza Post)

This week we covered two important concepts, arithmetic, and methods.
 
Arithmetic
 
We first learned how to use the basic mathematics operators in our code.
 
We add two numbers together using the + symbol.
We subtract two numbers together using the - symbol.
We multiply two numbers together using the * symbol.
We divide two numbers by using the / symbol.
int numberOne = 5;
int numberTwo = 5;

//Add two numbers together
int addingTwoNumbers = numberOne + numberTwo;

//Subtract two numbers together
int subtractingTwoNumbers = numberOne - numberTwo;

//Multiply two numbers together
int multiplyTwoNumbers = numberOne * numberTwo;

//Divide two numbers
int divideTwoNumbers = numberOne / numberTwo;
 
We also learned that you can quickly change the value of a variable using special math operators.
++ will increase the value of a variable by one.
+= will increase the value of a variable by whatever number you place on the right side
 
int x = 5;
x++;
//x would equal 6

int y = 2
y += 5;
// y would equal 7
 
Finally we learned about he modulus operation (%).
This special operation gives us the remainder of the division between two numbers.
 
int x = 5 % 3;
// x = 2 because 3 goes into 5, one time with 2 remaining.

int x = 13 % 4;
// x = 1 because 4 goes into 13, three times with 1 remaining.
 
 
 
Methods
We also talked about methods at the end of class this week.
 
Methods are what we use so that we don't have to repeat sections of code. They allow us to reuse the same code over and over again throughout our program.
 
When writing a new method we always have to include certain pieces of information.
We start with
public static
These two words will be at the beginning of all the methods your likely to write in this course. You will learn more about them in the next class.
 
We follow public static with a return type, this tells other people what kind of information you will return. For instance:
public static long
The long above means that this method will return a long, meaning if we want to store the result of the method in a new variable, that variable must be of type long.
Any type we have learned in this class can be a return type but what if I don't want to return anything?
 
Not all methods need to return something in this case we would place the word void where we previously had the word long
public static void
You might recognize the void terminology from the main method in every program you have written thus far.
 
Next is the method name, we want to use descriptive names that tell a user at a glance what the method does.
public static double GetPerimeterOfRectangle
It should be obvious what GetPerimeterOfRectangle will give us a back the perimeter of some rectangle.
How does it know what the dimensions of the Rectangle are?
 
We have to tell it the dimensions, and we do this by defining the Method Parameters
public static double GetPerimeterOfRectangle(double sideA, double sideB, double sideC, double sideD)
Parameters are separated by commas and placed with Parenthesis next to the method name. A method may have any number of parameters including zero. The parameters are the only way to get information from another section of code.
 
Following the parameters we write the code that will run whenever this method is used inside of {}, making sure to use the keyword return before the value we want to return if this method returns a value
public static double GetPerimeterOfRectangle(double sideA, double sideB, double sideC, double sideD)
{
	int perimeter = sideA + sideB + sideC + sided;
	return perimeter;
}
 
Finally when calling a method we have to make sure to place an equal number of values in parenthesis to the number of parameters the method accepts.
static void Main[]()
{
	int rectangleSideOne = 4;
	int rectangleSideTwo = 6;
	int rectangleSideThree = 7;	
	int rectangleSideFour = 8;

	int perimeter = GetPerimeterOfRectangle(rectangleSideOne, rectangleSideTwo, rectangleSideThree, rectangleSideFour);
	
}
 
This is all new and we will cover it more next week but feel free to ask any questions you have here, the more you ask now the easier it will be when we pick this back up.
 
Have a great week!
