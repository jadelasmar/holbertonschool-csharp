# 0x0C. C# - Delegates, Events

# Learning Objectives

* What are delegates and how to use them
* What are anonymous methods and how to use them
* What is multicasting
* What is the difference between delegates and interfaces
* What is a callback
* What are events and how to use them
* What is asynchronous programming


# Tasks

## 0. Universal health 
Create a public class called ```Player``` with the following:

* Properties:
    * ```name```: string
    * ```maxHp```: float
    * ```hp```: float
    * You should not be able to change or access the Player’s properties directly from the main file.
* Constructor:
    * Prototype: ```public Player(string name, float maxHp)```
    * Assign parameters to properties accordingly
        * Default ```name```: ```Player```
        * Default ```maxHp```: ```100f```
    * ```maxHp``` must be greater than 0, otherwise, set ```maxHp``` to the default value of ```100f``` and print ```maxHp must be greater than 0. maxHp set to 100f by default.```.
    * ```hp``` should be the same value as maxHp
* Method:
    * Prototype: ```public void PrintHealth()```
    * Format: ```<name> has <hp> / <maxHp> health.```

## 1. Damage delegation
Based on ```0-universal_health```, create a delegate ```CalculateHealth``` that takes a float amount. Write two methods that follow the prototype of the ```CalculateHealth``` delegate:

## 2. Validation
Based on ```1-damage_delegation```, inside the ```TakeDamage()``` and ```HealDamage()``` methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods.

* If damage is taken, subtract ```damage``` from ```hp```
* If health is healed, add ```heal``` to ```hp```

## 3. Modified behavior 
Based on ```2-validation```, outside of the ```Player``` class, create an enum ```Modifier``` with the values ```Weak```, ```Base```, ```Strong```.

Outside of the Player class, create a delegate ```CalculateModifier```:

* Prototype: ```public delegate float CalculateModifier(float baseValue, Modifier modifier)```

## 4. Check yourself 
Based on ```3-modified_behavior```, outside of the ```Player``` class, create a new class ```CurrentHPArgs``` that inherits from ```EventArgs``` with the following:

* Properties:
    * ```currentHp```: public float that cannot be modified
* Constructor:
    * Takes a float ```newHp``` and sets it as ```currentHp```‘s value

## 5. Eventful
Based on ```4-check_yourself```, create a new method ```HPValueWarning``` inside the ```Player``` class:

* Prototype: ```private void HPValueWarning(object sender, CurrentHPArgs e)```
* If the value of ```e```‘s ```currentHp``` is 0, print ```Health has reached zero!```
* Otherwise, print ```Health is low!```
* Optionally, change the colors of the console font or background when the warnings are printed: