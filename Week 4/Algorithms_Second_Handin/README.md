#Second Hand in
## Creative problem 2.1.14
Dequeue sort. Explain how you would sort a deck of cards, with the restriction
that the only allowed operations are to look at the values of the top two cards, to
exchange the top two cards, and to move the top card to the bottom of the deck.

- To sort the deck of cards I would keep moving the top card to the buttom until I find card #1 or #2. 
- I would then swap the two top cards and move the new top card to the buttom, and continue to do this until Card #1 and #2 are in the top.
- Card #1 and #2 should then be swapped so they are in order and then be moved to the buttom.
- Move top card to the buttom until card #3 is found.
- Swap the two top cards and move the new card to the buttom until the two top cards are card #1 and #3.
- Swap and move card #1 to the buttom.
- Swap and move card #2 to the buttom.
- Move card #3 to the buttom and look for card #4.
- Repeat until all cards are sorted.

If doing this with 5 cards it would look like this:
- 1,4,3,5,2
- 1,3,5,2,4
- 1,5,2,4,3
- 1,2,4,3,5
- 2,4,3,5,1
- 4,3,5,1,2
- 3,5,1,2,4
- 3,1,2,4,5
- 3,2,4,5,1
- 3,4,5,1,2

Code for this can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/2.1.14/DeckOfCards.cs)

## Experiment 2.1.31with merge sort instead of shell sort
Doubling test. Write a client that performs a doubling test for sort algorithms.
Start at N equal to 1000, and print N, the predicted number of seconds, the actual number
of seconds, and the ratio as N doubles. Use your program to validate that insertion
sort and selection sort are quadratic for random inputs, and formulate and test a hypothesis
for shellsort.

InsertionSort function can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/SortingFunctions/InsertionSort.cs)

SelectionSort function can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/SortingFunctions/SelectionSort.cs)

MergeSort function can be found [here](https://github.com/Ebski/Algorithms/blob/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/SortingFunctions/MergeSort.cs)

Code for InsertionSort validation can be found [here](https://github.com/Ebski/Algorithms/tree/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/2.1.31/Insertion)

Code for SelectionSort validation can be found [here](https://github.com/Ebski/Algorithms/tree/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/2.1.31/Selection)

Code for MergeSort hypothesis can be found [here](https://github.com/Ebski/Algorithms/tree/master/Week%204/Algorithms_Second_Handin/Algorithms_Second_Handin/2.1.31/Merge)

###The results
![Results](http://i66.tinypic.com/5tv0k6.png)

It's safe to assume that both InsertionSort and SelectionSort has O(n^2) as a worst case.

As for MergeSort the results show that the time doubles when the number of elements being sorted doubles, the time it takes is abit more than double the previous result.
Therefor MergeSort has O(n * log(n))
