using Inheritance_Sec10_Lsn1_1._9;

public class SubjectTeacher : Teacher
{
    public string Subject { get; set; }
    // You can add other properties relevant to a subject teacher here

    public SubjectTeacher(string name, string subject)
        : base(name)
    {
        Subject = subject;
    }
}
