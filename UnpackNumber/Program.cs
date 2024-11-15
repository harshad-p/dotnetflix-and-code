// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string input; 

Console.WriteLine("Enter an integer.");
input = Console.ReadLine();

Console.WriteLine($"You entered: " + input);

for(int i = input.Length - 1; i >= 0 ; i--){
    var num = int.Parse(input[i].ToString());
    var unpacked = num * Math.Pow(10, i);
    //Console.Write(unpacked + " ");
}

for(int i = 0; i < input.Length; i++){
    var num = int.Parse(input[i].ToString());
    var unpacked = num * Math.Pow(10, input.Length - i - 1);
    Console.Write(unpacked + " ");
}