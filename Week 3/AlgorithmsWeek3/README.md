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
