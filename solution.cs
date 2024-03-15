rl.question('Enter an arithmetic expression: ', (input) => {
    const operator = input.match(/[\+\-\*\/]/)[0];
    const operands = input.split(operator).map(Number);