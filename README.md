# _Word Counter_

#### _Independent Project 7, March 2020_

#### By _**Kristina Hengster Tintor**_

## Description
Console application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It checks for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.) 

## Project Specifications

User is prompted to type in the word. First spec will check if object is instantiated. 
* Input: world
* Output: Object Game is instantiated.

User is prompted to type in a sentence.
* Input: "Hello world"
* Output: Applications takes in the sentence so that object Game is instantiated with two properties: "Hello world" and "world".

Application splits the sentence into a string array;
* Input: "Hello world";
* Output: {'Hello', 'world'}

Application takes the previously inputted word and calculates how many times it appears in the newly created string array:
* Input:  {'Hello', 'world'}, 'world'
* Output: "Word "world" appears 1 time in your sentence.


## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/kristinaht/bakery```
* Open file in your preferred text editor

* On Windows: ```cd Bakery```, followed by ```code .```
* Type ``` dotnet build``` followed by ```dotnet run``` to run program.


## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kristinaht/wordcounter) here on GitHub._

## Technologies Used

* Git
* VS Code
* C#
* .NET

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Kristina Hengster Tintor_**