using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Anna Apricot","Composition");
        assign1.GetSummary();

        MathAssignment assign2 = new MathAssignment("Bobby Baxter","Fractions","7.2","8-13");
        assign2.GetHomeworkList();

        WritingAssignment assign3 = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        assign3.GetWritingInformation();
    }
}