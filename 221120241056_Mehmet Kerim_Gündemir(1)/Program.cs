// See https://aka.ms/new-console-template for more information
Console.WriteLine("3 dersin ortalaması");
int lesson1;
int lesson2;
int lesson3;


Console.Write("Ders 1 notunu girin -> ");
lesson1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ders 2 notunu girin -> ");
lesson2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ders 3 notunu girin ->");
lesson3 = Convert.ToInt32(Console.ReadLine());

int average = (lesson1 + lesson2 + lesson3) / 3;

Console.WriteLine($"Ortalamanız -> {average}");
if (average >= 50)
{     
    Console.WriteLine("Başarıyla Geçtiniz"); 
}
else
{
    Console.WriteLine("Kaldınız");
}
Console.ReadLine();



