//läser in namet
String Way = "";

while(Way !="Vänster" && Way !="Höger" && Way!="Frammåt")
{
    Console.WriteLine("Vilket väg kommer du ta");

Way = Console.ReadLine();

Console.WriteLine($"Ok, du väljer att gå åt {Way}!");

    if(Way == "Vänster")
    {
        Console.WriteLine("Du hamnar till en ny korsning var kommer du gå!");
    }
    else if(Way=="Högrer"){
        Console.WriteLine("du väljer att gå åt höger och hamnar i en ny korsning");
    }
    else if(Way=="Frammåt"){
    Console.WriteLine("Du väljer att gå frammåt rätt genom mörkret tills du kommer till en liten större korsning");
    Console.WriteLine("Vart ska du gå nu?");
    }
    

    if(Way == "Frammåt")
    {
      Console.WriteLine("Du vandrar genom mörkret innan du kommer till en ny korsning");
    }




    }




Console.ReadLine();





















