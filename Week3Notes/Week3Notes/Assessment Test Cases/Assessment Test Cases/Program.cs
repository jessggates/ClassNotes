
double grade = 95;
Console.WriteLine(isPassing(grade));
grade = 64;
Console.WriteLine(isPassing(grade));

double grade1 = 100;
double grade2 = 50;
double grade3 = 65;
Console.WriteLine(AverageGrades(grade1, grade2, grade3));

grade = 95;
Console.WriteLine(OddOrEvenAndPassing(grade));
grade = 61;
Console.WriteLine(OddOrEvenAndPassing(grade));
grade = 90;
Console.WriteLine(OddOrEvenAndPassing(grade));
grade = 60;
Console.WriteLine(OddOrEvenAndPassing(grade));



bool isPassing(double grade)
{
    if (grade > 65)
        return true;
    else if (grade <= 65)
        return false;
    else return false;
}

double AverageGrades(double grade1, double grade2, double grade3)
{
    double average = (grade1 + grade2 + grade3) / 3;
    return average;
}

string OddOrEvenAndPassing(double grade)
{
    Convert.ToInt32(grade);
    bool evenGrade = grade % 2 == 0;
    {
        if (isPassing(grade) == true && evenGrade == false)
            return "passing and odd";
        else if (isPassing(grade) == false && evenGrade == false)
            return "failing and odd";
        else if (isPassing(grade) == true && evenGrade == true)
            return "passing and even";
        else if (isPassing(grade) == false && evenGrade == true)
            return "failing and even";
        else return " ";
    }
}

Console.ReadKey();