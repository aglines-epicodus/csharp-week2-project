# Test title

#### Weekly project for C Sharp

#### **By Andrew Glines**

## Description

This application will count the number of times a specified word appears in a string.
The user will supply both the specified word and the string to be searched.
The application will not search substrings; only full-word matches will count.
In order to handle more types of text, the application will convert all input to lower case.

A 'word' is defined as any set of characters separated by one or more whitespace characters.
Numbers, punctuation, and symbols should all count as matchable words.


## Behavior, Inputs, and Reasoning

|  behavior | input  | output  |
|---|---|---|
| If the user enters "a" and searches for "a", the app should count one | "a", "a" | 1 |
| Reason for this input: simplest test is using a one-letter word | | |
| If the user enters "a a" and searches for "a", the app should count two | "a a", "a" | 2 |
| Reasoning: any string separated by space counts as a word  | | |
| If the user enters "aa" and searches for "a", the app should count zero | "aa", "a" | 0 |
| Reasoning: substrings are not to be counted | | |
| Numbers, punctuation, and symbols will count the same as letters | "11 !!", "11" | 1 |
| Reasoning: numbers will also count as a word | | |




## Setup/Installation Requirements

Go to Github repository page at (insert link here)
Click the "download or clone" button and copy the link.
In your computers terminal type "git clone" & paste the copied link.
Once downloaded you can open the index.html file in the browser of your choice.
You can view the code using the text editor of your choice as well.

## Known Bugs

* No known bugs

## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact any of the contributors through Github.

## Technologies Used

* HTML
* CSS
* Javascript
* Bootstrap
* JSON
* xUnit
* C#

### License
This software is licensed under the MIT license.
