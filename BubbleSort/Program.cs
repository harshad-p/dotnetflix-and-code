// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n***Bubble Sort***");

var list = new List<int>
{
    200, 0, 2000, -10, -1, 0, 2, 5, 3, 10, 100, 1000
};
Console.WriteLine("List: \n" + string.Join(", ", list));

for (int i = 0; i < list.Count; i++)
{
    for(int j = i + 1; j < list.Count; j++)
    {
        if (list[i] > list[j])
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}

Console.WriteLine("Sorted List: \n" + string.Join(", ", list));