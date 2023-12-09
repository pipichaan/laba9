Person tom = new Person("Obama", "Tom", "Vavilovich", "Penza", "Vysshee", 1879);
Person rita = new Person("Prikolova", "Rita", "Prikolovna", "Tokio", "Srednee", 1999);
Person nikolya = new Person("Zyazyacov", "Nikolya", "Ivanovich", "Gorod", "Vysshee", 2020);
Person[] mass = new Person[3] {tom, rita, nikolya};
Console.WriteLine("Введите год");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
    if (mass[i].god > a)
    {
        Console.WriteLine($" а. {mass[i].familiya} {mass[i].name} {mass[i].otchestvo}");
    }
}
for (int i = 0;i < 3; i++)
{
    if (mass[i].obrazovanie == "Vysshee")
    {
        Console.WriteLine($" б. {mass[i].familiya} {mass[i].name} {mass[i].otchestvo}");
    }
}
class Person
{
    public string familiya;
    public string name;
    public string otchestvo;
    public string adress;
    public string obrazovanie;
    public int god;
    public Person(string familiya, string name, string otchestvo, string adress, string obrazovanie, int god)
    {
        this.familiya = familiya;
        this.name = name;
        this.otchestvo = otchestvo;
        this.adress = adress;
        this.obrazovanie = obrazovanie;
        this.god = god;
    }
}

