# NullReferenceException in C# Property Access

This repository demonstrates a common C# error: a `NullReferenceException` caused by accessing a property that hasn't been initialized and could potentially be null. The `Bug.cs` file contains the problematic code, while `BugSolution.cs` provides a solution to handle the null case gracefully.

## Description

A `NullReferenceException` is a runtime exception that occurs when you try to access a member (method, property, or field) of an object that is currently null.  This often happens when a property hasn't been assigned a value before being used.

## How to Reproduce

1. Clone this repository.
2. Compile and run `Bug.cs`.  You'll encounter a `NullReferenceException`.

## Solution

The `BugSolution.cs` file shows how to prevent the exception using null checks. This ensures robust code that doesn't crash unexpectedly when dealing with potentially null properties.