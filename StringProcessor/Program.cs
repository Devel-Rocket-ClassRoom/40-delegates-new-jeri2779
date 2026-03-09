using System;

// README.md를 읽고 코드를 작성하세요.

delegate string StringProcessor(string input);

string ToUpperCase(string s) => s.ToUpper();
string ToLowerCase(string s) => s.ToLower();
string AddBrackets(string s) => $"[{s}]"; 

string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

void ProcessAndPrint(string input, StringProcessor processor)
{
    string result = processor(input);
    Console.WriteLine($"결과: {result}");
}

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();
Console.WriteLine("원본: Hello World");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
ProcessAndPrint("Hello World", ToUpperCase);
Console.WriteLine();

Console.WriteLine("[소문자 변환]");
ProcessAndPrint("Hello World", ToLowerCase);
Console.WriteLine();

Console.WriteLine("[괄호 추가]");
ProcessAndPrint("Hello World", AddBrackets);
Console.WriteLine();

Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint("Hello World", Reverse);

