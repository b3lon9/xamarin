// See https://aka.ms/new-console-template for more information
using ArrayPjt;
using System.IO.Pipes;

/*
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
*/

Student[] students = new Student[5];
students[0] = new Student("박찬호", 20, "baseball", 2);
students[1] = new Student("손흥민", 19, "soccer", 1);
students[2] = new Student("김연경", 21, "Volleyball", 3);
students[3] = new Student("서장훈", 22, "basketball", 4);
students[4] = new Student("박태환", 22, "swimming", 4);

Console.WriteLine($"Students Size : {students.Length}");
students[0].PrintStudentInfo();

foreach(Student student in students)
{
    student.PrintStudentInfo();
}