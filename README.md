# Lab 3: Functions

## Task

In this lab, you will use functions to create a simple unit converter. Most of the world uses metric (or
“SI”) units of measurement such as kilograms, meters, and degrees Celsius. However, there are still a few
places that use “US customary” units such as pounds, feet, and degrees Fahrenheit. Our converter should be
able to convert between customary units and SI units.

- 1 *inch* is 25.4 millimeters. There are 12 inches in a *foot*. There are 3 feet in a *yard*. There are 1760 yards in a *mile*.

- 1 *ounce* is 28.349523125 grams. 1 ounce is 16 of a *pound*. There are 2000 pounds in a *short ton*.

Write unit conversion function using piping, composition and currying.

<span style="font-weight:bold"><span style="color:red">Warning:</span> Do not change signatures of the provided function definitions!</span>

## Test

Press **Run** button to execute and test your program.

- Or run `make test` command in the command line to verify the correctness of your program.

## Submission

- Commit & push all changes that to the corresponding assignment repository on GitHub, using the **Repl.it** interface - **Version control** tab.
  - Make sure that you committed changes to following files:
    - ...
- Submit the link of the assignment GitHub repository in the corresponding assignment submission the Blackboard.
  - Open corresponding assignment on the Blackboard
  - In **Assignment Submission** section, press **Write Submission** button
  - Paste your assignment repository link in the **Text Submission** box
  - Submit the assignment

### Before You Submit

You are required to test that your submission works properly before submission. Make sure that your program compiles without errors. Once you have verified that the submission is correct, you can submit your work.

### Coding Style

In any programming project, matching the existing coding style is important. Having different coding styles intermixed leads to confusion and bugs. Students are required to follow the particular existing coding style that maintains the indentation style in `.fs` and `.fsx` files using spaces, not tabs.

In particular, pay close attention to function declarations and how the function name begins the line after the function return type. For helper functions which are limited in scope to a specific file, you must declare the function as `static` in the same file in which it is used.

*Indentation*: The indentation style for your work have to be 4 spaces. Many students are taught to use tabs for indentation, which can make code very hard to read, especially when there are several levels of indentation.

For additional information, see [F# style guide](https://docs.microsoft.com/en-us/dotnet/fsharp/style-guide/) or [A comprehensive guide to F# Formatting Conventions](https://github.com/fsprojects/fantomas/blob/master/docs/FormattingConventions.md)
