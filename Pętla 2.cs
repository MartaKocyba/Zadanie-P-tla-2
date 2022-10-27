
int liczba = 0;
bool sukces;
int silnia = 1;


do
{
    Console.Write("Podaj całkowitą liczbę dodatnią: ");
    sukces = int.TryParse(Console.ReadLine(), out liczba);
}
while ((!sukces)||(liczba<0));

for (int i = 2; i <= liczba; i++)
{
    silnia = silnia * i;

}
Console.WriteLine($"Silnia z {liczba} wynosi {silnia}");
Console.ReadKey();
