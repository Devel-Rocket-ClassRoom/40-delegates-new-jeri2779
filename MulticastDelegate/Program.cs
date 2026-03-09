using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 문자열 처리 파이프라인 ===");
Action origin = () => Console.WriteLine($"원본: Hello World");
Console.WriteLine("--- 단계 1: 원본 출력만 ---");

Action<string> PrintOriginal  = s => Console.WriteLine($"원본: {s}");
Action<string> PrintUpperCase = s => Console.WriteLine($"대문자: {s.ToUpper()}");
Action<string> PrintLowerCase = s => Console.WriteLine($"소문자: {s.ToLower()}");
Action<string> PrintLength   = s => Console.WriteLine($"길이: {s.Length}");
PrintOriginal("Hello World!");
PrintUpperCase("Hello World!");
PrintLowerCase("Hello World!");
PrintLength("Hello World!");


//static void PrintOriginal(string s) => Console.WriteLine($"원본: {s}");
//static void PrintUpperCase(string s) => Console.WriteLine($"대문자: {s.ToUpper()}");
//static void PrintLowerCase(string s) => Console.WriteLine($"소문자: {s.ToLower()}");
//static void PrintLength(string s) => Console.WriteLine($"길이: {s.Length}");
