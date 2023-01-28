using System;

class Program
{
    static void Main(string[] args) {
        Job job1 = new Job();
        job1._company = "Evil.inc";
        job1._jobTitle = "henchman";
        job1._startYear = 1800;
        job1._endYear = 1900;

        Job job2 = new Job();
        job2._company = "Heros.co";
        job2._jobTitle = "sidekick";
        job2._startYear = 1911;
        job2._endYear = 2019;
        
        Job job3 = new Job();
        job3._company = "Plague.inc";
        job3._jobTitle = "Successful Variant";
        job3._startYear = 2020;
        job3._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Minion #23";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.Display();
    }
}

