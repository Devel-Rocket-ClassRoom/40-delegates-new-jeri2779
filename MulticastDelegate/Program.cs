using System;

// README.md를 읽고 아래에 코드를 작성하세요.
 
string input = "Hello World";

Action<string> PrintOriginal  = s => Console.WriteLine($"원본: {s}");
Action<string> PrintUpperCase = s => Console.WriteLine($"대문자: {s.ToUpper()}");
Action<string> PrintLowerCase = s => Console.WriteLine($"소문자: {s.ToLower()}");
Action<string> PrintLength   = s => Console.WriteLine($"길이: {s.Length}");
Console.WriteLine("=== 문자열 처리 파이프라인 ===");
Console.WriteLine();
Console.WriteLine("--- 단계 1: 원본 출력만 ---");
Console.Write("원본: ");
Action<string> pipeline = PrintOriginal;
pipeline(input);

pipeline += PrintUpperCase;
Console.WriteLine();
Console.WriteLine("--- 단계 2: 대문자 추가 ---");
pipeline(input);

pipeline += PrintLowerCase;
pipeline += PrintLength;
Console.WriteLine();
Console.WriteLine("--- 단계 3: 소문자, 길이 추가 ---");
pipeline(input);

pipeline -= PrintUpperCase;
Console.WriteLine();
Console.WriteLine("--- 단계 4: 대문자 제거 ---");
pipeline(input);

 