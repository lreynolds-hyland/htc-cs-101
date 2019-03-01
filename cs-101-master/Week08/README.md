# Content week 8: Collections (Arrays & Lists)

## Overview
Collections allow users to store multiple like values within a single object. Two common types of collections will be discussed, Arrays and Lists. Think of arrays has like items in a 1 by x size container, you as the user have the ability to place an object in one of the containers and at any given time be able to return to a specific spot and retrieve or replace an object in a specific slot. In programing, arrays store multiple values of the same data type, so an array can store multiple integers or multiple strings (or any data type for that matter!). The size of the array (or how many items it can hold) must be determined at creation and unfortunately, we are unable to modify its size after creation. 
However, that is where Lists become useful. While the syntax is slightly different, Lists have many of the same advantages as Arrays but we can modify how many items the list can hold at any given time. In order to access a specific item in a list you must address it by using its index value.  

## Pre-Work
Students should complete the provided bell work as they enter the classroom

## Lecture
Guided lesson: PowerPoint ‘9 Basic Collections - Arrays & Lists'	
 
### Arrays:

* Declaration: `string[] name = new string[5];` 

1. long[] numArray = new long[10]; Each index set to default value for the data type, we don’t know what we want the values to be, but we know we need to hold 10 items. 

2. long[] numArray = new long[] { 0, 1, 1, 2, 3, 5, 8 }; we know exactly what values we need to store! Since we are supplying what we want the values to be we do not need to declare the size of the array, it will figure that out on its own!

How do we set and access values? Remember, collections are zero bases, so the first item in the array is actually index 0!

Set:		 	
Set index 3 (really the 4th item in the list) equal to 25.

```C#
int[] intArray = new int[5];
intArray[3] = 25;
```
Retrieve:  
		 
We have set values to the array during declaration, so get the value of index 2 (really the 3rd item in the array), that value would be 65.

```C#
int[] intArray = new int[5];
intArray[2] = 65;

for(int i = 0; i >= intArray.Length; i++ )
{
	Console.WriteLine(i);
}
// 0, 0, 65, 0, 0
```


### Lists:
* Declaration: `List<string> listName = new List<string>();`

1. `List<string> listName = new List<string>();` 
This is fine! Lists don’t need to be told how big they need to be, we can add and remove items any time we want!

2. `List<string> listName = new List<string>() { "random", "text", "goes", "here" };` 
	* If we know exactly what values we need we can just add  them! 

Retrieve:		 
We have set values to the array during declaration, so get the value of index 3 (really the 4th item in the array), that value would be "Joe".

```C#
List<string> listOfNames = new List<string>() {"Jordan", "Ehab", "Matt", "Joe", "Caitlin"};
Console.WriteLine(listOfNames[3]); // Joe
```

Set:  
How do we set/add and access values? Remember, collections are zero bases, so the first item in the array is actually index 0!

To change the value of an already existing slot, just do as you would an array, index 2 (which is really the 3rd item in the collection) now equals "Jacob"

```C#
List<string> listOfNames = new List<string>() {"Jordan", "Ehab", "Matt", "Joe", "Caitlin"};

listOfNames[2] = "Jacob";

Console.WriteLine(listOfNames[2]); //Jacob

```

## Individual Exercises
Week 8 Challenge work 

## Post-Work
To students: Write any outstanding questions to Piazza


## Wrap-Up Message (Piazza)
Items to cover in Piazza message:
1. What are the two ways we can declare an array?
2. How about a List?
3. Arrays cannot grow in size, but a List can 
4. Collections start at index 0!

