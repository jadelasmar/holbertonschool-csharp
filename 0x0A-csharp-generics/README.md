# 0x0A. C# - Generics

# Learning Objectives
* What are generics and what are their purpose
* What common generic classes and interfaces are provided in the .NET class library
* When and how to create generic classes
* When and how to create generic methods
* How access modifiers affect a class and its members
* What is the default(T) expression used for
* What is covariance and contravariance

# Tasks

## 0. Queue 
Create a new class called ```Queue<T>```.

* ```Queue<T>``` should not inherit from other classes or interfaces.
* Within ```Queue<T>```, create a new method ```CheckType()``` that returns the Queue’s type.
* You are **not** allowed to use ```System.Collections``` or ```System.Collections.Generic``` for this project.

## 1. Enqueue
Based on ```0-queue```, within ```Queue<T>```, create a public class called Node with the following properties:

* ```value```: can be of any type, set its initial value to ```null```
* ```next```: must be an object of type ```Node```, set its initial value to ```null```
* Define a constructor that takes a ```value``` for a new ```Node``` as its only parameter and sets it

Within ```Queue<T>```, add the following properties:

* ```head```: must be an object of type ```Node```
* ```tail```: must be an object of type ```Node```
* ```count```: type ```int```

## 2. Dequeue 
Based on ```1-enqueue```, add a new method ```Dequeue()``` to the class ```Queue<T>``` that removes the first node in the queue and returns its value.

* If the queue is empty, the method should write ```Queue is empty``` to the console and return the default value of the parameter’s type

## 3. Peek 
Based on ```2-dequeue```, add a new method Peek() to the class ```Queue<T>``` that returns the value of the first node of the queue without removing the node.

## 4. Print
Based on ```3-peek```, add a new method ```Print()``` to the class ```Queue<T>``` that prints the queue, starting from the head.

## 5. Concatenate 
Based on ```4-print```, create a method ```Concatenate()``` that concatenates all values in the queue only if the queue is of type ```String``` or ```Char```.