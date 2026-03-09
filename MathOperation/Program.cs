using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 사칙연산 대리자 ===");
Console.WriteLine();
MathOp mathAdd = Add;
Console.WriteLine("[덧셈]");
processAndPrint("+", 20, 4, mathAdd);
Console.WriteLine();

MathOp mathSubtract = Subtract;
Console.WriteLine("[뺄셈]");
processAndPrint("-", 20, 4, mathSubtract);
Console.WriteLine();

MathOp mathMultiply = Multiply;
Console.WriteLine("[곱셈]");
processAndPrint("*", 20, 4, mathMultiply);
Console.WriteLine();

MathOp mathDivide = Divide;
Console.WriteLine("[나눗셈]");
processAndPrint("/", 20, 4, mathDivide);    
//하드 코딩 요소 다분히 있음 추가 개선 


//연산자 기호도 매개변수로 받아서 출력하는 방향 고려
void processAndPrint(string sign, int a, int b, MathOp operation)
{
    int result = operation(a, b);
    Console.WriteLine($"{a} {sign} {b} = {result}");
}   



int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => a / b;

delegate int MathOp(int a, int b);