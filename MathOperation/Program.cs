using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 사칙연산 대리자 ===");
MathOp mathAdd = Add;
Console.WriteLine($"[덧셈]\n 20 + 4 = {mathAdd(20, 4)}");
MathOp mathSubtract = Subtract;
Console.WriteLine($"[뺄셈]\n 20 - 4 = {mathSubtract(20, 4)}");
MathOp mathMultiply = Multiply;
Console.WriteLine($"[곱셈]\n 20 * 4 = {mathMultiply(20, 4)}");
MathOp mathDivide = Divide;
Console.WriteLine($"[나눗셈] \n 20 / 4 = {mathDivide(20, 4)}");
//하드 코딩 요소 다분히 있음 추가 개선 




int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => a / b;

delegate int MathOp(int a, int b);