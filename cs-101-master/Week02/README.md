# Week 2: Console.WriteLine() && Variables

## Overview

As an introductory to the class, expose students to the Console Application. With this first step into C# students will need to learn the basic operations to use within a Console Application such as WriteLine(). 
Students will also need to become familiar with the concept of a Variable, a named location in memory used to store data. In order to use variables students will need know the different datatypes that we will be associating with variables, int, long, bool, double and string. Students should develop an understanding of what each datatype is and how to use them appropriately. 

Recommended: In the past, we have always introduced methods as the last topic and we always wished we had more time with them. To gain more exposure it may be worth talking about methods at the most basic level at the start and maybe use simple methods to write messages to the console window. As the class progresses introduce return types and parameters as it becomes appropriate, (recommended lessons to introduce these topics are in later lesson plans)


## Class Objective

* Create a ‘About me' Program
    - Use a series of datatypes to output information like age, name, number of pets, ect..
* Explain what a variable is
    - A named location in memory
* Declare each of the following variables and assign appropriate values to each:
    - int (1)
    - bool (true/false)
    - string (“Random Text”)
    - double (1.234)
* Show students how to save their work

## Lecture
* Lecture/guided lesson with ‘2 Variables & Data Types’
* Code along – ‘About me’ program & declaring and assigning variables of different datatypes

```CS
string userName = "Jordan Conrad";
int userAge = 26;
int numberOfPets = 2;
string schoolAttended = "Medina High School && Baldwin Wallace University!";


Console.WriteLine("Hello! My name is " + userName);
//Hello! My name is Jordan Conrad

Console.WriteLine(String.Format("I am {0} years old and have {1} pets!", userAge, numberOfPets));
// I am 26 years old and have 2 pets!

Console.WriteLine($"I went to school at {schoolAttended}!");
//I went to school at Medina High School && Baldwin Wallace University!

```

## Kahoot
Using Kahoot as an Exit evaluation: [Data Types](https://create.kahoot.it/#quiz/1f90d1ad-60b6-4536-a9fd-1987dda96f62)


## Individual Exercises
[InClassWork.md](InClassWork.md)


## Wrap-Up Message (Piazza)
Items to cover in Piazza message:
1.	Define a Variable
2.	Recap each datatype and give an example of each
3.	Recap Console.WriteLine() is how we write to console window
4.	Review format of a simple method to write to console window
