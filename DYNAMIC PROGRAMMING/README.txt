__________________________________________________________________________________________
-------------------------------   DYNAMIC PROGRAMMING   ----------------------------------

3 Approaches For Algorithms:
1. Recursive (Inefficient - O(2ⁿ))
2. Memoization (BETTER - O(2N + 1) or O(N))
3. Bottom-Up (BEST - O(N))

FIB SEQUENCE WITH THE 3 APPROACHES:
n = the nth-value of the sequence

RECURSIVE >>-----------------------------------------------------------------------------------------
function fib(n):
  if n == 1 or n == 2:
    result = 1
  else:
    result = fib(n - 1) + fib(n - 2)
  return result

But why is it INEFFICIENT?
- Usually, the values for fib(1) and fib(2) has to recomputed, creating repetitive operations
// fib(5) requires fib(2) to be computed 3 times while for fib(3) 2 times
- To find fib(100), recomputation of identical values can cause a problem

HOWEVER!
- DP suggests that all computed values can be stored and reused when needed, avoiding recomputation
- This is why the next approach is more efficient. Moving on...

MEMOIZATION >>----------------------------------------------------------------------------------------
- In this approach, we will use an array of n + 1 (ignoring the first element because of 0th index)
        1 1 2 3 5 8
  memo: 1 1 
- When values are computed, they will be stored in the array

function fib(n, memo):
  if memo[n] != null: //is this value computed yet?
    return memo[n] //if true, immediately return the stored value, else we continue with computation
  
  //The rest of the algorithm
  if n == 1 or n == 2:
    result = 1;
  else:
    result = fib(n - 1, memo) + fib(n - 2, memo)
  memo[n] = result
  return result

// In fact, we are actually building the array from left to right, so why not build it explicitly instead of recursively?
// This algorithm can be optimized to handle LARGER Nth NUMBERS, lets move on...

Bottom-Up >>---------------------------------------------------------------------------------------
function fib_bottom_up(n):
  if n == 1 or n == 2
    return 1
  
  bottom_up = new int[n + 1]
  bottom_up[1] = 1
  bottom_up[2] = 1
  for i from 3 upto n:
    bottom_up[i] = bottom_up[i - 1] + bottom_up[i - 2]
  return buttom_up[n] //return the last value of the array

// For this case, there are no recursive calls on the call stack

HOW TO SOLVE DYNAMIC PROGRAMMING PROBLEMS
1. Define subproblems
   Subproblems can sometimes have the same form as the actual problem
2. Determine the base case
3. Form a recursive formula that solves a generic case
4. VISUALIZE!