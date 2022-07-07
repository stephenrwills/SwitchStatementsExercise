Console.WriteLine("What is your favorite subject in school?");

string favSubject = Console.ReadLine();

switch (favSubject)
{
    case "Math":
    Console.WriteLine("Math is hard");
    break;

    case "English":
        Console.WriteLine("English is boring");
        break;

    case "Science":
        Console.WriteLine("Science is for dorks");
        break;

    case "History":
        Console.WriteLine("History rules");
        break;

    case "Foreign Language":
        Console.WriteLine("Foreign Language is interesting");
        break;

    default:
        Console.WriteLine("This is not a required subject, Try Again");
        break;

}