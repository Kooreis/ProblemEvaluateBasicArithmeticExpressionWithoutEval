Here is a simple console application in JavaScript that evaluates a basic arithmetic expression without using eval:

```javascript
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Enter an arithmetic expression: ', (input) => {
    const operator = input.match(/[\+\-\*\/]/)[0];
    const operands = input.split(operator).map(Number);

    let result;
    switch (operator) {
        case '+':
            result = operands[0] + operands[1];
            break;
        case '-':
            result = operands[0] - operands[1];
            break;
        case '*':
            result = operands[0] * operands[1];
            break;
        case '/':
            if (operands[1] === 0) {
                console.log('Error: Division by zero is not allowed.');
                rl.close();
                return;
            }
            result = operands[0] / operands[1];
            break;
    }

    console.log(`Result: ${result}`);
    rl.close();
});
```

This application uses the readline module to read the arithmetic expression from the console. It then uses a regular expression to find the operator and splits the input string into operands. It then performs the appropriate arithmetic operation based on the operator and prints the result. If the operator is division and the second operand is zero, it prints an error message and exits.