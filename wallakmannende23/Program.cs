string currentRoom = "Hall";

string direction = "";

while (currentRoom != "end")
{
    if (currentRoom == "Hall")
    {
        Console.WriteLine("Du är i hallen");

        direction = Console.ReadLine();

        if (direction == "Vänster")
        {
            currentRoom = "Toaletten";
        }
        else if (direction == "Höger")
        {
            currentRoom = "Köket";
        }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
    }
    
    else if (currentRoom == "Köket")
    {
        Console.WriteLine("Du är i köket");

        direction = Console.ReadLine();

        if (direction == "Vänster")
        {
            currentRoom = "Kontoret";
        }
        else if (direction == "quickwayout")
        {
            currentRoom = "end";
            Console.WriteLine("du har lyckats fly");
        }
        else if(direction=="backa")
        {
            currentRoom = "hall";  
        }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
    }
       else if (currentRoom == "Toaletten")
    {
        Console.WriteLine("Du är i inne på toaletten");

        direction = Console.ReadLine();

        if (direction == "backa")
        {
            currentRoom = "hall";
        }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
    }
        else if(currentRoom == "Kontoret")
        {
            if(direction == "Vänster")
            {
                Console.WriteLine("du går genom en nödutgång och kommer ut ur huset");
                currentRoom = "end";
            }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
        }
        







}




/*

//läser in namet
String Way = "";



{
    while (Way != "Vänster" && Way != "Höger" && Way != "Frammåt")
    {
        Console.WriteLine("Vilket väg kommer du ta");

        Way = Console.ReadLine();

        Console.WriteLine($"Ok, du väljer att gå åt {Way}!");

        if (Way == "Vänster")
        {
            Console.WriteLine("Du hamnar till en ny korsning var kommer du gå!");

        }
        else if (Way == "Högrer")
        {
            Console.WriteLine("du väljer att gå åt höger och hamnar i en ny korsning");

        }
        else if (Way == "Frammåt")
        {
            Console.WriteLine("Du väljer att gå frammåt rätt genom mörkret tills du kommer till en liten större korsning");
            Console.WriteLine("Vart ska du gå nu?");

        }



    }
}


*/





















