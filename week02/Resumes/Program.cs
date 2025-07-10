using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
         Resume resume = new Resume
        {
            FullName = "Godfred Aboagye Sefa",
            Headline = "Creative Graphic Designer & Ethical Hacking Enthusiast",
            Summary = "Innovative and detail-oriented designer with experience in branding, UI/UX, and web design. Passionate about cybersecurity and ethical hacking. Proven ability to transform ideas into visually appealing and secure digital products."
        };

        resume.Skills.AddRange(new List<string>
        {
            "Graphic Design (Photoshop, Illustrator, Figma)",
            "UI/UX Design",
            "Web Development (HTML, CSS, JavaScript)",
            "Python & C# Programming",
            "Ethical Hacking & Cybersecurity Basics",
            "Creative Problem Solving"
        });

        resume.EducationList.Add(new Education
        {
            CertificateTitle = "Web and Computer Programming Certificate",
            Institution = "BYU-Pathway Worldwide",
            DateAwarded = "Anticipated: Dec 2027",
            Competencies = new List<string>
            {
                "Develop dynamic websites using HTML, CSS, JavaScript",
                "Design responsive layouts",
                "Create secure applications",
                "Use GitHub for version control"
            }
        });

        resume.Experiences.AddRange(new List<Experience>
        {
            new Experience
            {
                JobTitle = "Freelance Graphic Designer",
                Company = "Self-Employed",
                StartYear = 2022,
                EndYear = 2024,
                Highlights = new List<string>
                {
                    "Created branding materials for 15+ clients",
                    "Designed UI layouts for 10+ mobile apps"
                }
            },
            new Experience
            {
                JobTitle = "Ethical Hacking Intern",
                Company = "CyberTech Ghana",
                StartYear = 2023,
                EndYear = 2024,
                Highlights = new List<string>
                {
                    "Assisted in penetration testing assignments",
                    "Monitored network security for SMEs"
                }
            }
        });

        resume.Display();

        Console.Write("\nDo you want to save the resume to a file? (yes/no): ");
        if (Console.ReadLine().Trim().ToLower() == "yes")
        {
            File.WriteAllText("GodfredAboagyeSefa_Resume.txt", resume.GetFormattedText());
            Console.WriteLine("Resume saved as 'GodfredAboagyeSefa_Resume.txt'.");
        }
    }
}

class Resume
{
    public string FullName { get; set; }
    public string Headline { get; set; }
    public string Summary { get; set; }
    public List<string> Skills { get; set; } = new();
    public List<Experience> Experiences { get; set; } = new();
    public List<Education> EducationList { get; set; } = new();

    public void Display()
    {
        Console.WriteLine($"\nName: {FullName}");
        Console.WriteLine($"Headline: {Headline}\n");
        Console.WriteLine("Summary:");
        Console.WriteLine(Summary + "\n");

        Console.WriteLine("Skills:");
        foreach (var skill in Skills)
            Console.WriteLine("- " + skill);

        Console.WriteLine("\nExperience:");
        foreach (var exp in Experiences)
            exp.Display();

        Console.WriteLine("\nEducation:");
        foreach (var edu in EducationList)
            edu.Display();
    }

    public string GetFormattedText()
    {
        using StringWriter writer = new();

        writer.WriteLine($"Name: {FullName}");
        writer.WriteLine($"Headline: {Headline}\n");
        writer.WriteLine("Summary:");
        writer.WriteLine(Summary + "\n");

        writer.WriteLine("Skills:");
        foreach (var skill in Skills)
            writer.WriteLine("- " + skill);

        writer.WriteLine("\nExperience:");
        foreach (var exp in Experiences)
            writer.WriteLine(exp.GetFormatted());

        writer.WriteLine("\nEducation:");
        foreach (var edu in EducationList)
            writer.WriteLine(edu.GetFormatted());

        return writer.ToString();
    }
}

class Experience
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }
    public List<string> Highlights { get; set; } = new();

    public void Display()
    {
        Console.WriteLine($"{JobTitle} at {Company} ({StartYear}-{EndYear})");
        foreach (var item in Highlights)
            Console.WriteLine("  - " + item);
    }

    public string GetFormatted()
    {
        using StringWriter writer = new();
        writer.WriteLine($"{JobTitle} at {Company} ({StartYear}-{EndYear})");
        foreach (var item in Highlights)
            writer.WriteLine("  - " + item);
        return writer.ToString();
    }
}

class Education
{
    public string CertificateTitle { get; set; }
    public string Institution { get; set; }
    public string DateAwarded { get; set; }
    public List<string> Competencies { get; set; } = new();

    public void Display()
    {
        Console.WriteLine($"{CertificateTitle} | {Institution} | {DateAwarded}");
        foreach (var comp in Competencies)
            Console.WriteLine("  - " + comp);
    }

    public string GetFormatted()
    {
        using StringWriter writer = new();
        writer.WriteLine($"{CertificateTitle} | {Institution} | {DateAwarded}");
        foreach (var comp in Competencies)
            writer.WriteLine("  - " + comp);
        return writer.ToString();
    
    }
}