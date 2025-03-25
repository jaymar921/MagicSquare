# College Programming: CESAFI Computer Quiz Bowl (2025)

### Challenge:

Given a 2D array, check if it is a magic square. A magic square is one where the sum of all rows, columns, and diagonals are the same.

### Expected Skills:

Matrix manipulation, summation, logical checks.

### Problem Statement:

A magic square is a square matrix where the sum of the elements in each row, each column, and both diagonals are the same. Given an NxN 2D array (matrix), your task is to write a program that checks whether the given matrix forms a magic square.

### Requirements:

1. Your program should take in a 2D array (matrix) of integers as input.
2. It should check if the sum of each row, each column, and both diagonals are equal.
3. If all sums match, the matrix is a magic square. Otherwise, it is not.

### Input:

- A square matrix of size N x N (where N is a positive integer greater than 1). The matrix elements can be any integers (positive, negative, or zero).

### Output:

- TRUE if the matrix is a magic square.
- FALSE if the matrix is not a magic square.

### Example:

### Input:

|     |            |     |
| --- | ---------- | --- |
| [   |            |     |
|     | [8, 1, 6], |
|     | [3, 5, 7], |
|     | [4, 9, 2]  |
| ]   |            |     |

### Output: TRUE

### Explanation:

The sum of each row, each column, and both diagonals is 15. Hence, it forms a magic square.

# Constraints:

- The size of the matrix (N) should be at least 2 (N >= 2).
- he matrix elements can be any integers, including negative numbers or zero.

# Evaluation Criteria:

- Correctness: The program must correctly identify whether the matrix is a magic square.
- Efficiency: The solution should be efficient with respect to time complexity, ideally O(N^2), where N is the size of the matrix.
- Edge Cases: The program should handle edge cases like matrices containing negative numbers or zeros, and very small matrices (e.g., 2x2).

| TEST CASE    | INPUT                                                        | EXPECTED RESULT | EXPLANATION                                                                                                      |
| ------------ | ------------------------------------------------------------ | --------------- | ---------------------------------------------------------------------------------------------------------------- |
| Test Case 1  | [[8, 1, 6],[3, 5, 7],[4, 9, 2]]                              | TRUE            | This is a classic 3x3 magic square where the sum of each row, column, and diagonal is 15.                        |
| Test Case 2  | [[4, 9, 2],[3, 5, 7],[8, 1, 6]]                              | TRUE            | This is another valid 3x3 magic square, where the sum of each row, column, and diagonal is 15.                   |
| Test Case 3  | [[1, 2, 3],[4, 5, 6],[7, 8, 9]]                              | FALSE           | This matrix does not satisfy the magic square condition. The sums of rows, columns, and diagonals are different. |
| Test Case 4  | [[1, 1],[1, 1]]                                              | TRUE            | For a 2x2 matrix, this is a magic square because both rows, columns, and diagonals all sum to 2.                 |
| Test Case 5  | [[1, 2, 3, 4],[5, 6, 7, 8],[9, 10, 11, 12],[13, 14, 15, 16]] | FALSE           | This matrix is not a magic square because the sums of rows, columns, and diagonals do not match.                 |
| Test Case 6  | [[16, 2, 3, 13],[5, 11, 10, 8],[9, 7, 6, 12],[4, 14, 15, 1]] | TRUE            | This is a 4x4 magic square where the sum of each row, column, and diagonal is 34.                                |
| Test Case 7  | [[6, 1, 8],[7, 5, 3],[2, 9, 4]]                              | TRUE            | This is a 3x3 magic square with the sum of each row, column, and diagonal equal to 15.                           |
| Test Case 8  | [[4, 9, 2],[3, 5, 7],[6, 5, 6]]                              | FALSE           | This is not a magic square because the last row (6 + 5 + 6 = 17) doesn't match the sum of other rows (15).       |
| Test Case 9  | [[2, 9, 4],[7, 5, 3],[6, 1, 8]]                              | TRUE            | This is another 3x3 magic square with the sum of each row, column, and diagonal equal to 15.                     |
| Test Case 10 | [[10, 2, 3, 4],[1, 11, 5, 6],[7, 8, 12, 13],[14, 15, 16, 9]] | FALSE           | This is not a magic square as the sums of the rows, columns, and diagonals do not match.                         |
