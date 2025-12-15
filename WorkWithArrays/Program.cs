// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Input a count of elements in array");
Int64.TryParse(Console.ReadLine(), out var nElems);
var iArray = new int[nElems];
for (int i = 0; i < nElems; i++)
{
    Console.WriteLine("Input an element N {0}", i + 1);
    int.TryParse(Console.ReadLine(), out iArray[i]);
}
Console.WriteLine("Inputed array:");
for (int i = 0;i < nElems; i++)
{
    Console.Write(iArray[i] + " ");
}
Console.Read();