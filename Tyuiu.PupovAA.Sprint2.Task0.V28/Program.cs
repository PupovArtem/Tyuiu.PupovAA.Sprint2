using Tyuiu.PupovAA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 111;
        int y = 735;
        bool[] b = new bool[6];
        b = ds.GetCompareOperations(x, y);
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);

        }
        Console.ReadLine(); 
    }
}