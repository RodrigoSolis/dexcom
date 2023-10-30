# Fullstack engineer test

Code developed in C# and tests were created in xunit
Tests in Dexcom.Test, ProblemsTests folder

## Problem 1
Given a list nums of n integers where nums[i] is in the range [1, list length], write a function
that solves the following problem; return a list of all the integers in the range [1, list length]
that do not appear in nums.

### Solution
A single for loop from number 1 to the size of the array. 
And the current number is added to a list if it is not contained in the array.
At the end just returns that list with the missing numbers

## Problem 2
Given a list of integers nums and an integer target, write a function that solves the following
problem; return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the
same element twice.
You can return the answer in any order.

### Solution
A dictionary is created to store the index and its value.

A simple for loop is created that iterates from 0 to the size of the array.
Inside the array the necessary number is defined which is the one that added to the current number in the array is equal to the target.
The current index and the current value are stored in the dictionary as long as they do not exist.

If the value of the required number exists as a key in the dictionary
an array with the value of the current index and the value of the required number in the dictionary is returned.
