// Можно обойтись без создания класса и статического метода Main в версии C# 10.0 
//class NewProgram
//{
    //static void Main()
    //{
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine(); // ? указывает на то, что может передаваться значение null, то есть ничего
        Console.WriteLine($"Hello, {name}!"); // $ нужен переде строкой, чтобы сделать вставку {name}, как format в питоне
//    }
//}
