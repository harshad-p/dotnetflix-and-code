// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input; 

Console.WriteLine("Enter an integer.");
input = Console.ReadLine();
if(!int.TryParse(input, out int _))
{
    Console.WriteLine($"{input} is not a valid integer");
    return;
}

Console.WriteLine($"Unpacking {input}...");

for(int i = 0; i < input.Length; i++){
    var num = int.Parse(input[i].ToString());
    var unpacked = num * Math.Pow(10, input.Length - i - 1);
    Console.Write(unpacked + " ");
}

Console.WriteLine();
