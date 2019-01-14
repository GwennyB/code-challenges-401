# data-structures-and-algorithms
CF 401 .NET - Code Challenge 5 - Linked Lists

# Create new classes for linked lists and nodes
Create classes for linked lists and nodes. Classes contain methods to facilitate common actions for lists and nodes.

## Challenge
Create a Node class with the following properties and methods:
 - Value: integer value contained in the node (required)
 - Next: Node object that references the next node in the same list (null ref at instantiation)
 - Node (constructor): requires int input to assign initial value of node object
Create a LinkedList class with the following properties and methods:
 - Head: Node object that references the list's 'head' node
 - Current: Node object that references the node currently selected for work/manipulation/etc.
 - Insert (method): Instantiates and inserts a new node (of specified value) into the list, and points 'head' at it.
 - Includes (method): Checks list for the first node that contains the passed-in value - returns 'true'. If none, returns 'false'.
 - Print (method): Console prints the value of the passed-in nodel
  *** default constructor only - no custom constructor defined ***

## Approach & Efficiency
LinkedList.Insert adds a new node, points it to the previous 'Head' as 'Next', and makes it the new 'Head' in just 3 steps. Time complexity is O(1) (since it performs this set of operations just once regardless of the size of the linked list).
LinkedList.Includes starts at 'Head' and compares the passed-in value to each node in turn. Time complexity is O(n) (since - at worst, when the matching value is the tail node - it performs this operation for every node in the linked list).

## Solution
This challenge included a set of unit tests verifying that:
 - Includes returns 'false' when the checked value isn't present in the linked list
 - Includes returns 'true' when a multi-node list contains the checked value ***
 - Includes returns 'true' when a single node list contains the checked value
 - Insert adds new nodes ***
 - Insert assigns the correct value of 'Next' when instantiating new 'Head'
 - Node constructor properly creates new nodes ***

   *** checked 0, positive integers of multiple orders, negative values of multiple orders, positive double converted to int

 ![unit tests](assets/unit-tests-all-pass.PNG)