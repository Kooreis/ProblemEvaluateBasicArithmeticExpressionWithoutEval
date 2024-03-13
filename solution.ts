Here is a TypeScript console application that evaluates a basic arithmetic expression without using eval:

```typescript
class Calculator {
    private operators = {
        '+': (a: number, b: number) => a + b,
        '-': (a: number, b: number) => a - b,
        '*': (a: number, b: number) => a * b,
        '/': (a: number, b: number) => a / b
    };

    public evaluate(expression: string): number {
        let stack = [];
        let tokens = expression.split(' ');

        for (let token of tokens) {
            if (token in this.operators) {
                let [b, a] = [stack.pop(), stack.pop()];
                stack.push(this.operators[token](a, b));
            } else {
                stack.push(parseFloat(token));
            }
        }

        return stack.pop();
    }
}

let calculator = new Calculator();
console.log(calculator.evaluate('3 4 + 2 * 1 +'));
```

This application defines a Calculator class with a method to evaluate an arithmetic expression. The expression is expected to be in Reverse Polish Notation (RPN), where operators follow their operands. For example, the expression "2 + 3" would be written as "2 3 +" in RPN.

The `evaluate` method splits the expression into tokens, then processes each token. If the token is an operator, it pops two numbers from the stack, performs the operation, and pushes the result back onto the stack. If the token is a number, it pushes it onto the stack. When all tokens have been processed, the result is the last number left on the stack.