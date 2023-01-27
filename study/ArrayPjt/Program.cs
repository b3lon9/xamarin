// See https://aka.ms/new-console-template for more information
using System.IO.Pipes;

Console.WriteLine("Hello, World!");



string[] names = new string[5] {"정우땡", "홍상땡", "송수땡", "황승땡", "이대땡"}; // 배열 선언
int len = names.Length;
Console.WriteLine("names len : {0}", len);

int index = Array.IndexOf(names, "송수땡");
Console.WriteLine("IndexOf 송수땡 : {0}", index);

// 틀려보자
int indexEr = Array.IndexOf(names, "에러");
Console.WriteLine("IndexOf Er : " + indexEr);

Array.Reverse(names);
foreach(string name in names)
{
    Console.Write($"{name} ");
}

// Clear
Array.Clear(names, 0, names.Length-2);

foreach(string name in names) Console.Write($"clear name : {name}");