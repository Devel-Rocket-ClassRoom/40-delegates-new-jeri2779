using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("## 1. 대리자를 통한 메서드 호출");

SayDelegate sayPointer = new SayDelegate(Hello);

// 방법 1: 대리자 변수에 괄호를 붙여 호출
sayPointer();

// 방법 2: Invoke() 메서드를 명시적으로 호출
sayPointer.Invoke();


static void Hello() => Console.WriteLine("Hello Delegate");

Console.WriteLine();
Console.WriteLine("## 2. 대리자 인스턴스 생성 방법");
static void Hi() => Console.WriteLine("안녕하세요");

SayDelegate say = Hi;
say();

var hi = new SayDelegate(Hi);
hi();

Console.WriteLine();
Console.WriteLine("## 3. 매개변수와 반환값이 있는 대리자");
GetAreaDelegate pointer = GetArea;

// 호출
Console.WriteLine(pointer.Invoke(10));
Console.WriteLine(pointer(10));
static double GetArea(int r) => 3.14 * r * r;

Console.WriteLine();
Console.WriteLine("## 4. 강력한 형식의 대리자");
MathOperation pow = Math.Pow;
double result = pow(2, 10);
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine("## 5. 정적 메서드 참조");

Transformer t = Calculator.Square;
Console.WriteLine(t(5));


Console.WriteLine();
Console.WriteLine("## 6. 멀티캐스트 대리자: 진행률 보고");

ProgressReporter reporter = WriteToConsole;
reporter += WriteToFile;
static void  WriteToConsole(int percent)
{
    Console.WriteLine($"진행률: {percent}%");
}
static void WriteToFile(int percent)
{
     
    Console.WriteLine($"[파일 기록]: {percent}%");
}


Console.WriteLine();
Console.WriteLine("## 7. 대리자를 매개변수로 전달");

runnerCall(Go);
Console.WriteLine();
runnerCall(Back);
static void Go() => Console.WriteLine("직진");
static void Back() => Console.WriteLine("후진");  
static void runnerCall(Runner runner)
{
    Console.WriteLine("실행 시작");
    runner();
    Console.WriteLine("실행 종료");

}

Console.WriteLine();
Console.WriteLine("## 8. Action 대리자");

Action greet = () => Console.WriteLine("안녕하세요!");
greet();

Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action!");

Action<string, int> PrintRepeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
PrintRepeat("반복", 3);

Console.WriteLine();
Console.WriteLine("## 9. Func 대리자");

Func<int> getNumber = () => 42;
Console.WriteLine(getNumber());

Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 7));

Func<int, int, string> addToString = (a,b) => (a + b).ToString();
Console.WriteLine(addToString(3, 5));

Console.WriteLine();
Console.WriteLine("## 10. Predicate 대리자");

Predicate<int> isEven = x => x % 2 == 0;
Predicate<int> isPositive = x => x > 0;
Console.WriteLine(isEven(4));
Console.WriteLine(isEven(5));
Console.WriteLine(isPositive(5));
Console.WriteLine(isPositive(-3));

Console.WriteLine();
Console.WriteLine("## 11. 익명 메서드");

SayDelegate say1 = delegate ()
{
    Console.WriteLine("반갑습니다.");
};
say1();

delegate void Runner(); // 7
delegate void ProgressReporter(int percent);//6
delegate int Transformer(int x);
delegate double MathOperation(double x, double y);
delegate double GetAreaDelegate(int r);
delegate void SayDelegate();