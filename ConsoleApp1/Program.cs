using System;

public class Course
{
    private int _credits;

    public string Code { get; init; }
    public string Name { get; set; }

    public int Credits
    {
        get { return _credits; }
        set
        {
            if (value < 1 || value > 10)
                throw new ArgumentException("Credits must be between 1 and 10.");
            _credits = value;
        }
    }

    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public string Info()
    {
        return $"{Code} {Name} ({Credits} cr)";
    }
}