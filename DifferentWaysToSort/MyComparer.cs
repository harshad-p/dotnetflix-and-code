// See https://aka.ms/new-console-template for more information
class MyComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x - y;
    }
}
