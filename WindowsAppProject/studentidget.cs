using System;

public class StudentIdGetter
{
    private static string studentId;

    public StudentIdGetter(string studentId)
    {
        StudentId = studentId;
    }

    public static string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }
}
