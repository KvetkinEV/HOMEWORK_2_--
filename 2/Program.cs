Console.Write("Введи число: ");
int tri = Convert.ToInt32(Console.ReadLine());
string triPROVERKA = Convert.ToString(tri);
if (triPROVERKA.Length > 2)
{
Console.WriteLine("третья цифра =  " + triPROVERKA[2]);
}
else
{
Console.WriteLine("третьей цифры нет");
}
Console.ReadLine();
