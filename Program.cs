using System;

// initialize variables
int currentAssignments = 5;
int sophiaSum = 0, andrewSum = 0, emmaSum = 0, loganSum = 0;
decimal sophiaScore, andrewScore, emmaScore, loganScore;

// array to store students
string[] studentNames = { "sophia", "andrew", "emma", "logan" };

// arrays storing grades of students
int[] sophiaGrades = { 90, 86, 87, 98, 100 };
int[] andrewGrades = { 92, 89, 81, 96, 90 };
int[] emmaGrades = { 90, 85, 87, 98, 68 };
int[] loganGrades = { 90, 95, 87, 88, 96 };

/* 
loop through students and loop through scores
in student adding them to get sum for that student
*/
foreach (string currentStudent in studentNames)
{
  // initialise variables
  if (currentStudent == "sophia")
  {
    foreach (int currentGrade in sophiaGrades)
    {
      sophiaSum += currentGrade;
    }
  }
  else if (currentStudent == "andrew")
  {
    foreach (int currentGrade in andrewGrades)
    {
      andrewSum += currentGrade;
    }
  }
  else if (currentStudent == "emma")
  {
    foreach (int currentGrade in emmaGrades)
    {
      emmaSum += currentGrade;
    }
  }
  else if (currentStudent == "logan")
  {
    foreach (int currentGrade in loganGrades)
    {
      loganSum += currentGrade;
    }
  }
}

// assign the average scores to variable
sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

// assign the letter grades to variable
string sophiaLetterGrade = LetterGrade(sophiaScore);
string andrewLetterGrade = LetterGrade(andrewScore);
string emmaLetterGrade = LetterGrade(emmaScore);
string loganLetterGrade = LetterGrade(loganScore);

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t {sophiaScore} \t{sophiaLetterGrade}");
Console.WriteLine($"Andrew:\t\t {andrewScore} \t{andrewLetterGrade}");
Console.WriteLine($"Emma:\t\t {emmaScore} \t{emmaLetterGrade}");
Console.WriteLine($"Logan:\t\t {loganScore} \t{loganLetterGrade}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

// method to return a grade for students average score
static string LetterGrade(decimal currentStudentGrade)
{
  if (currentStudentGrade >= 97)
  {
    return "A+";
  }
  else if (currentStudentGrade >= 93)
  {
    return "A";
  }
  else if (currentStudentGrade >= 90)
  {
    return "A-";
  }
  else if (currentStudentGrade >= 87)
  {
    return "B+";
  }
  else if (currentStudentGrade >= 83)
  {
    return "B";
  }
  else if (currentStudentGrade >= 80)
  {
    return "B-";
  }
  else if (currentStudentGrade >= 77)
  {
    return "C+";
  }
  else if (currentStudentGrade >= 73)
  {
    return "C";
  }
  else if (currentStudentGrade >= 70)
  {
    return "C-";
  }
  else if (currentStudentGrade >= 67)
  {
    return "D+";
  }
  else if (currentStudentGrade >= 63)
  {
    return "D";
  }
  else if (currentStudentGrade >= 60)
  {
    return "D-";
  }
  else
  {
    return "F";
  }
}