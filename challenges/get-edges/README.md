# data-structures-and-algorithms
CF 401 .NET - Code Challenge - Graphs as Flight Maps

## Challenge
Given a graph of valid flight segments with costs (ie - flight paths map) and an array of cities (ie - desired itinerary), determine whether the itinerary is valid, and the associated cost if valid.

## Approach
For each city in the array (except the last), locate the city in the graph. Locate the next city in its list of neighbors. (If either doesn't exist, return 'false, 0'.) Add the weight of the connection to an accumulator, and move to the next city. Return 'true' and the accumulator if all cities are successfully visited.

![whiteboard](assets/whiteboard.jpg)

## Efficiency
All nodes must be visited in order to satisfy a busy itinerary (some repetitive itineraries can force worst), so time complexity is O(n) typically (where 'n' is # cities in the graph). No new memory allocation or recursive calls enables O(n) space complexity.

## Solution
This challenge included a set of unit tests verifying the following itineraries:  
  - valid, single-leg
  - valid, multi-leg
  - invalid, single-leg
  - invalid, multi-leg
![unit tests](assets/unit-tests.PNG)
