using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

// Arrays storing grades of students
int[] sophiaGrades = {90, 86, 87, 98, 100};
int[] andrewGrades = {92, 89, 81, 96, 90};
int[] emmaGrades = {90, 85, 87, 98, 68};
int[] loganGrades = {90, 95, 87, 88, 96};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

// foreach loop to add grades to make sum
foreach (int grade in sophiaGrades)
{
  sophiaSum += grade;
}
foreach (int grade in andrewGrades)
{
  andrewSum += grade;
}
foreach (int grade in emmaGrades)
{
  emmaSum += grade;
}
foreach (int grade in loganGrades)
{
  loganSum += grade;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
