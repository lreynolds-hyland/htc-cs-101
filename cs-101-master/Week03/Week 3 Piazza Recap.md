# Week 3 Piazza Message:

Week 3 Recap / Homework
User Input using Console.ReadLine and Convert.ToInt32 (and others)

string userResponse = Console.ReadLine();
The computer waits until the user has type in any text and an enter key. Console.ReadLine will then return the text provided, as a string value.

In this example, we choose to store the string as the value of the variable userResponse. 

We also learned that if we want to store the data returned as a variable who's datatype is not a string, then we need to convert it the desired datatype, using Convert.To... 

Here are some examples:

```C#
Console.WriteLine("What is your Age?");	
string ageResponse = Console.ReadLine();
int myAge = Convert.ToInt32(ageResponse);

// the double and bool converts works the same			
double battingAverage = Convert.ToDouble(baResponse);
bool isSnowing = Convert.ToBoolean(snowingResponse);
In the int example, we have a string variable, ageResponse, that we need to convert to an integer. Suppose we want to do math with the value, we will need a datatype, like an int, to be able to do it. So we pass the string to Convert.ToInt32, and it returns an integer value if it can. Above we can see, the returned int is stored in a new variable, myAge. We have to use a different variable, because the datatype is not string!
```


If, else if and else!

We use conditional statements in code to help us make decisions if a condition is true or false.
The section in the parentheses is what we're evaluating to either true or false. If the value we evaluate is true, we'll do the section inside the if block. 
We also looked at else statements which allow us to run another section of code if the condition we're checking is false.

Example:

```C#
Console.WriteLine("What percent did you get on your test??"); 
string testResult = Console.ReadLine();
int myScore = Convert.ToInt32(testResult);
if(myScore >= 90)
{
 	Console.WriteLine("Awesome! You got an A.");
}
else if(myScore >= 80)
{
 	Console.WriteLine("Good job, you got a B.");
}
else
{
 	Console.WriteLine("You should keep studying.");
}
```

In this example, if the user enters an test score greater than or equal to 90, then the section inside the parenthesis evaluates to true, and the first block of code is run.

If we don’t enter the first code block because our score is say, 85, we would then evaluate the 2nd block, (myScore >= 80). This expression would equate to true so we would then write to the console “Good job, you got a B”.

If the test score is 79 or less the code inside the else block runs!
