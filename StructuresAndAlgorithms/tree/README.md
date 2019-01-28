# data-structures-and-algorithms
CF 401 .NET - Lab 10 - Stacks and Queues

# Create new classes for Trees
'Classes' contains classes for Tree, BinaryTree, BinarySearchTree, and Node. Classes contain methods to facilitate traversal, adding, and locating nodes.

## Challenge
Create a Node class with the following properties and methods:
 - Value: integer value contained in the node (required)
 - Left: Node object that references the left child
 - Right: Node object that references the right child
 - Node (constructor): requires int input to assign initial value of node object
Create a Tree class with the following properties and methods:
 - Root: reference to tree's root node, or null if empty
 - constructor (empty)
Create a BinaryTree class (derived from Tree) with the following:
 - PreOrder: returns array of tree's values in PreOrder ordering (ie - left, right, root)
 - InOrder: returns array of tree's values in InOrder ordering (ie - left, root, right)
 - PostOrder: returns array of tree's values in PostOrder ordering (ie - root, left, right)
Create a BinarySearchTree class (derived from BinaryTree) with the following:
 - Add: adds a new node of specified value into the correctly sorted location in the tree
 - Contains: finds a value in a tree if it exists (returns true if present and false if not present)

## Approach & Efficiency
BinaryTree traversals use recursion, so time efficiency is O(n) and space is O(H) (height of tree). BinarySearchTree operations require less because they are ordered and predictable - time complexity is O(log n), and space is O(1).
