using System;

class ClubMembers
{
    public const int Size = 15;
    private string[] Members = new string[Size];
    public string ClubType { get; set; }
    public string ClubLocation { get; set; }
    public string MeetingDate { get; set; }

    // default constructor
    public ClubMembers() { }

    // indexer get and set methods
    public string this[int index]
    {
        get { return Members[index]; }
        set { Members[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create a new ClubMembers object
        ClubMembers club = new ClubMembers();

        // add multiple values to the Members indexer
        club[0] = "John";
        club[1] = "Jane";
        club[2] = "Bob";
        club[3] = "Sue";

        // add values to the ClubType, ClubLocation, and MeetingDate properties
        club.ClubType = "Book Club";
        club.ClubLocation = "Library";
        club.MeetingDate = "Every other Tuesday";

        // display the club information
        Console.WriteLine("Club Type: {0}", club.ClubType);
        Console.WriteLine("Club Location: {0}", club.ClubLocation);
        Console.WriteLine("Meeting Date: {0}", club.MeetingDate);
        Console.WriteLine("Members:");
        for (int i = 0; i < ClubMembers.Size; i++)
        {
            if (!string.IsNullOrEmpty(club[i]))
            {
                Console.WriteLine("- {0}", club[i]);
            }
        }
    }
}
