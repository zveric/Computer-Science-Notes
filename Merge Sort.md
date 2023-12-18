## Overview  
Merge Sort is a divide-and-conquer algorithm used for sorting a collection of elements. It follows the divide-and-conquer paradigm by recursively breaking down the array into smaller sub-arrays, sorting them, and then merging them back together.  
## Algorithm Steps  
1. **Divide:** Divide the unsorted array into two halves. 
2. **Conquer:** Recursively sort each half. 
3. **Merge:** Combine the sorted halves to produce a single sorted array. 
## Time Complexity

- Best Case: O(n log n)
- Average Case: O(n log n)
- Worst Case: O(n log n)

### Space Complexity

Merge Sort has a space complexity of O(n) due to the additional space required for the temporary arrays during the merge phase.

## Advantages

1. **Stable Sorting:** Maintains the relative order of equal elements.
2. **Predictable Performance:** Consistent time complexity, regardless of input distribution.
3. **Parallelizable:** Suitable for parallel processing.

## Disadvantages

1. **Space Complexity:** Requires additional memory for temporary arrays.
2. **Not In-Place:** Inefficient for large datasets due to space requirements.
