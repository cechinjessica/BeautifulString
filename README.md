# Coding Challenge: Beautiful String

This repository contains a solution to a coding challenge focused on finding the longest "beautiful substring" in a given string. The solution was implemented in C# as part of a technical exercise.

## Problem Description
A string is considered beautiful if it satisfies the following conditions:

Consisting of English vowels only, and each of the 5 English vowels ('a', 'e', 'i', 'o', 'u') must appear at least once in it.

The letters must be sorted in alphabetical order (i.e. all 'a's before 'e's, all 'e's before 'i's, etc.).

For example, strings "aeiou" and "aaaaaaeiiiioou" are considered beautiful, but "uaeio", "aeoiu", "aaaeeeooo" and “aeixyzou” are not beautiful.

Given a string consisting of English Characters and numbers , return the length of the longest beautiful substring in the given string. If no such substring exists, return 0.

A substring is a contiguous sequence of characters in a string.
Examples
Input: "abcdeaeiaaioaaaaeiiiiouuuooaauuaeiu"
Output: 13
Input: "aaaaa"
Output: 0
