using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("## 1. 내장 대리자(Action)로 멀티캐스트");
Action driver = GoForward;
driver += GoLeft;
driver += GoRight;
driver(); // 직진, 좌회전, 우회전

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");


Console.WriteLine();
Console.WriteLine("## 2. 익명 메서드와 멀티캐스트");

Action driver1 = GoForward1;
driver += GoLeft1;

driver1 += delegate ()
{
    Console.WriteLine("우회전");
};
static void GoForward1() => Console.WriteLine("직진");    
static void GoLeft1() => Console.WriteLine("좌회전");