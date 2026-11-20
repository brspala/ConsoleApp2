using System;

class Course
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

class Program
{
    static void Main(string[] args)
    {
        Course[] courses = new Course[5];
        courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
        courses[1] = new Course("CENG201", "Digital Logic", 3);
        courses[2] = new Course("EEE203", "Circuit Analysis", 4);
        courses[3] = new Course("MATH201", "Linear Algebra", 3);
        courses[4] = new Course("PHYS102", "Physics II", 4);

        foreach (Course course in courses)
        {
            Console.WriteLine(course.Info());
        }

        int totalCredits = 0;
        foreach (Course course in courses)
        {
            totalCredits += course.Credits;
        }
        Console.WriteLine();
        Console.WriteLine($"Total credits: {totalCredits}");

        string[] names = new string[courses.Length];
        for (int i = 0; i < courses.Length; i++)
        {
            names[i] = courses[i].Name;
        }
        Array.Sort(names);

        Console.WriteLine();
        Console.WriteLine("Course names (alphabetical):");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}