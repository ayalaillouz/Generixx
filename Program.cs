
// See https://aka.ms/new-console-template for more information
using Generix;

Console.WriteLine("Hello, World!");
static void PrintTheObj<T>(T obj)
{
    Console.WriteLine(obj);
}
PrintTheObj<int>(1);
PrintTheObj<string>("aysls");

SwapList<int> swapList = new SwapList<int>();
swapList.Add(1);
swapList.Add(2);
swapList.Add(3);
swapList.Add(4);
swapList.Add(5);
Console.WriteLine("x:" + swapList[0] + "y:" + swapList[1]);
swapList.swaper(0, 1);
Console.WriteLine("x:" + swapList[0] + "y:" + swapList[1]);