using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("How To Make Ducks Pay", "WilliamCook", 120);
        v1.AddComment("ParagonOfMentalHealth","So disappointed! This video should be banned!");
        v1.AddComment("SawAChanceLOL","I imagine somebody is going to make jokes about that title");
        v1.AddComment("WilliamCook","Look at the comment above yours...please tell me that's what's happening.");
        v1.AddComment("ParagonOfMentalHealth","Making ducks pay is no joke! They know what they did!");
        videos.Add(v1);
        Video v2 = new Video("Duck Book a Scam!!!", "ParagonOfMentalHealth", 10000);
        v2.AddComment("RandomPerson","Wait, was the book supposed to be about duck crimes? What are duck crimes?");
        v2.AddComment("ParagonOfMentalHealth","Do your own research. The truth is out there!");
        v2.AddComment("SawAChanceLOL","I've seen this person other places, too. Maybe they're funny on purpose?");
        videos.Add(v2);
        Video v3 = new Video("Reaction: Book not about making ducks answer for crimes, lol", "SawAChanceLOL", 58);
        v3.AddComment("DuckFarmer","I really appreciated this vid and humorous review!");
        v3.AddComment("ParagonOfMentalHealth", "You are a traitor to mankind! I hope you feel ashamed of yourself");
        v3.AddComment("DuckFarmer","Uh. What?");
        videos.Add(v3);
        Video v4 = new Video("'Make Ducks Pay' means animal husbandry. Most Disappointed...", "ParagonOfMentalHealth", 300);
        v4.AddComment("WilliamCook","I still don't understand what the other option was. I just like ducks.");
        v4.AddComment("ParagonOfMentalHealth","They are PLOTTING to overthrow the world! Why do you think it's called a 'murder' of ducks?!");
        v4.AddComment("SawAChanceLOL","'Murder of ducks'? Thanks, I'm keeping that!");
        v4.AddComment("DuckFarmer","I have never heard that expression in my life... Are we talking about the same animal? Here's a link to see some ducks:");
        v4.AddComment("ParagonOfMentalHealth","Those aren't ducks.");
        videos.Add(v4);
        foreach(Video myVid in videos) {
            Console.WriteLine(myVid.VidToString());
        }
    }
}