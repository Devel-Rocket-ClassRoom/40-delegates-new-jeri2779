using System;

// README.md를 읽고 코드를 작성하세요.


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
string input = "Hello World";
Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();
Console.WriteLine($"원본: {input}");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
ProcessAndPrint(input, ToUpperCase);
Console.WriteLine();

Console.WriteLine("[소문자 변환]");
ProcessAndPrint(input, ToLowerCase);
Console.WriteLine();

Console.WriteLine("[괄호 추가]");
ProcessAndPrint(input, AddBrackets);
Console.WriteLine();

Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint(input, Reverse);


delegate string StringProcessor(string input);