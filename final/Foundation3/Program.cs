using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> planner = new List<Event>();

        Lecture e1 = new Lecture("Birthday Party","There is food, but the host talks confusingly.", 
            new DateTime(), new Address("Party Tent","Hobbiton","The Shire","Middle Earth"), 
            "Bilbo Baggins", 300);
        planner.Add(e1);

        Outdoor e2 = new Outdoor("Equestrian Activities","Camp Halfblood Pegasus Riding Classes", 
            new DateTime(), new Address("Camp Halfblood","Long Island","New York","US"), 
            "Apocalyptic event");
        planner.Add(e2);

        Reception e3 = new Reception("Coronation Day","Aragorn crowned King of all Men despite lack of politics",
            new DateTime(), new Address("The Citadel","Minas Tirith","The Lands of Men","Middle Earth"), 
            "messenger bird");
        planner.Add(e3);
        foreach(Event myEvent in planner) {
            Console.WriteLine("Standard Details: ");
            Console.WriteLine(myEvent.StandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(myEvent.FullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(myEvent.ShortDescription());
        }
    }
}