using System;



Console.Write("What is your name: ");
string? name = Console.ReadLine();

Console.Write("Whats your math score: ");
int math = Convert.ToInt32(Console.ReadLine());

Console.Write("Whats your science score: ");
int science = Convert.ToInt32(Console.ReadLine());


Console.Write("Whats your english score: ");
int english = Convert.ToInt32(Console.ReadLine());

name ??= "Unknown";

StudentGrade studentGrade = new(name, math, science, english);

studentGrade.GetAverage();


public class StudentGrade
{

    private readonly string name;

    private readonly int math;

    private readonly int science;

    private readonly int English;


    public StudentGrade(string name, int math, int science, int English)

    {
        this.name = name;
        this.math = math;
        this.science = science;
        this.English = English;
    }

    public string GetAverage()
    {

        int passMark = 70;

        int total = this.math + this.science + this.English;
        float avgGrade = total / 3;


        if (avgGrade >= passMark)
        {
            return $"{this.name} passed with an average of {avgGrade}";
        }

        return $"{this.name} failed with an average of {avgGrade}";
    }

}