using PickSomeCards;


    Console.WriteLine("Enter the number of cards to pick:");
    string line = Console.ReadLine();
    if (int.TryParse(line, out int numberOfCards))
    {
        foreach (string card in CardPicker.PickSomeCards(numberOfCards))
        {
            Console.WriteLine(card);
        }
    }
    else
    {
        Console.WriteLine("The input is not a valid number");
    }

