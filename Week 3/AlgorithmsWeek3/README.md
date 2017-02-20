#Week 3

##Datastructures and sorting
###1. Explain why the algorithm in 1.3.5 converts a decimal number to a binary
Binary numbers increment on a 2^0, 2^1, 2^2, 2^3 and so on.

That means the last number in a binary number will determine if the number is even or uneven.

In the excersize 1.3.5 the first number will be n%2 which will either return 0 or 1. After that n is devided by two and its repeated.

If we take 50 as an example we would get

50%2 = 0, 25%2 = 1, 12%2 = 0, 6%2 = 0, 3%2 = 1, 1%2 = 1.

All thoose values are pushed and we end up with 110010

Which is: 32 * 1 + 16 * 1 + 8 * 0 + 4 * 0 + 2 * 1 + 1 * 0 = 50

Code for the algorithm can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%203/AlgorithmsWeek3/AlgorithmsWeek3/BinaryRepresentation.cs)

###2. Dutch national flag
Given an array of n buckets, each containing a red, white, or blue pebble, sort them by color.The allowed operations are:•swap(i,j): swap the pebble in bucket i with the pebble in bucket j.•color(i): color of pebble in bucket i.The performance requirements are as follows:•At most n calls to color().•At most n calls to swap().Constant extra space

Code can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%203/AlgorithmsWeek3/AlgorithmsWeek3/DutchFlag.cs)

##Tasks from "Algorithm Book"
### 1.3.27 && 1.3.28
Write a method max() that takes a reference to the first node in a linked list as
argument and returns the value of the maximum key in the list. Assume that all keys are
positive integers, and return 0 if the list is empty.

Develop a recursive solution to the previous question.

The linked list and the two different max methods can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%203/AlgorithmsWeek3/AlgorithmsWeek3/LinkedList.cs)

###2.1.14
Dequeue sort. Explain how you would sort a deck of cards, with the restriction
that the only allowed operations are to look at the values of the top two cards, to
exchange the top two cards, and to move the top card to the bottom of the deck.

- I would put the first card to the back of the deck until I found my number one card.
- When that card is found I would swap it and put the new first card to the backuntil my number 2 card was right after the first card. 
- Both thoose cards would then go to the back, and I would look for my third card. 
- When third card is found I would swap and put the new first card behind the deck until The 3 card is after the second card. 
- Then put both in the back and continue until all cards are ordered.

Check solution [here](https://github.com/Ebski/Algorithms/blob/master/Week%203/AlgorithmsWeek3/AlgorithmsWeek3/DequeSort.cs)
