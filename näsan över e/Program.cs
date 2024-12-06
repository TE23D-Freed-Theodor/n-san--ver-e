Console.WriteLine("Vad ska din MaxHP vara?");
string MaxHP_string = Console.ReadLine();
int MaxHP_num;
bool check = int.TryParse(MaxHP_string, out MaxHP_num);

while (check == false || MaxHP_num < 1 || MaxHP_num > 20) {
    if (check == true) {
        Console.WriteLine("Ditt tal måste vara mellan 1 och 20! Försök igen!");
        MaxHP_string = Console.ReadLine();
        check = int.TryParse(MaxHP_string, out MaxHP_num);
    }
    else {
        Console.WriteLine("Nu skrev du inte ett heltal mellan 1-20! Försök igen!");
        MaxHP_string = Console.ReadLine();
        check = int.TryParse(MaxHP_string, out MaxHP_num);
    }
}

int x = MaxHP_num;

while (x > 0) {
    Console.Write("[");

    for (int y = x; y > 0; y--) {
        Console.Write("=");
    }

    Console.Write($"]\n");

    x -= 1;
}


Console.ReadLine();