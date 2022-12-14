# anton-stecko-calculator

## What is calculator?
A calculator is a device that performs arithmetic operations on numbers. Basic calculators can do only addition, subtraction, multiplication and division mathematical calculations.

## Usage
Entering the digit of the highest operand begins with the rightmost digit and follows the rules for working with a digital display and scoreboard.

To perform arithmetic operations, you must enter the first operation, enter the sign of the arithmetic operation, enter the second operation and use the opportunity to get the result or continue execution, identify the sign of the arithmetic operation to continue calculations.

## Calculator view
![image](https://user-images.githubusercontent.com/87601057/202111021-8f0bb5b0-85db-46bb-b6af-278d72a48461.png)

## Functional
`+` -> Addition operator;<br/>
`-` -> Subtraction operator;<br/>
`*` -> Multiplication operator;<br/>
`/` -> division operator;<br/>
`+/-` -> Change number to positive/negative;<br/>
`=` -> Display the result of the calculation;<br/>
`c` -> Deletes the entered value/result.<br/>

## Architecture
### MainWindow class contains 6 methods:<br/>
`RefreshOutputField` -> refreshing result string;<br/>
`NumberButton_Click` -> inserting number;<br/>
`OperationButton_Click` -> inserting operation;<br/>
`EqualsButton_Click` -> displaing result;<br/>
`ClearButton_Click` -> clearing result string;<br/>
`ButtonNegation_Click` -> changes the sign of a number;<br/>

### CalculationService class contains realisation of methods from MainWindow class:<br/>
`GetResultString` -> getting the result string after any action;<br/>
`GetResult` -> getting the final result;<br/>
`CalculateArithmeticExpression` - calculating the operation;<br/>
`ClearOutputField` -> clearing the output field;<br/>
`NumberButtonPressed` -> input the number;<br/>
`OperationButtonPressed` -> input the operation;<br/>
`NegateNubmer` -> changes the sign of a number;
