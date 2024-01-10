Student student1 = new Student();
student1.Name = " Shahrom Sharipov";
student1.GradeLevel = 10;
student1.TestScores = new List<double> { 80, 100, 87, 99, 94 };

Student student2 = new Student();
student2.Name = " Nurullo Sulaymonov";
student2.GradeLevel = 11;
student2.TestScores = new List<double> { 80, 40, 87, 92, 91 };

Student student3 = new Student();
student3.Name = " Olimjon Tojiev";
student3.GradeLevel = 9;
student3.TestScores = new List<double> { 63, 40, 87, 90, 81 };

Student student4 = new Student();
student4.Name = " Abdulloh Abdulloev";
student4.GradeLevel = 8;
student4.TestScores = new List<double> { 88, 100, 98, 99, 100 };

Student student5 = new Student();
student5.Name = " Hasan Madudov";
student5.GradeLevel = 9;
student5.TestScores = new List<double> { 30, 40, 47, 22, 73 };

var students = new List<Student>();
students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);
students.Add(student5);


foreach (var std in students)
{
    double TotalAverage = std.GetAverage();

    if (TotalAverage < 70)
    {
        System.Console.WriteLine(std.Name + ", if you're having difficulties with your studies, you can say to somebody help you.");
        System.Console.WriteLine("Your current average score is " + TotalAverage + " in grade " + std.GradeLevel);
    }
    else if (TotalAverage > 70 && TotalAverage < 85)
    {
        System.Console.WriteLine("Congratulations" + std.Name + " on achieving above average scores (" + TotalAverage + ") in grade " + std.GradeLevel);
        System.Console.WriteLine("Keep working hard for even better results!");
    }
    else if (TotalAverage > 85)
    {
        System.Console.WriteLine("My own congratulations" + std.Name + " on achieving above average scores (" + TotalAverage + ") in grade " + std.GradeLevel);
        System.Console.WriteLine("Well down, Keep up the good work!");
    }
}