using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize and assign the job class
        Job job1 = new Job();
        job1._company = "Church of Jesus Christ";
        job1._jobTitle = "Counselor";
        job1._startYear = "2024";
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._company = "Cold Stone";
        job2._jobTitle = "Shift Lead";
        job2._startYear = "2019";
        job2._endYear = "2021";

        // Initialize and assign the Resume class
        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Johnathan Larson";

        // Call the display function to display the resume
        resume1.Display();
    }
}