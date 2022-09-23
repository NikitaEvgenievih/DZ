using ConsoleApp2309dz;
using File = ConsoleApp2309dz.File;

File[] files = new File[]
{
    new File ("nikita", ".txt", 954, DateTime.Now),
    new File ("436.ua", ".json", 47295301954, DateTime.Now),
    new File ("Files Sonia", ".json", 95425094, DateTime.Now),
    new File ("rabota", ".txt", 954654, new DateTime(2015, 7, 20)),
    new File ("refetat math", ".doxs", 96546735665, DateTime.Now),
};

foreach (File item in files)
{
    if(item.Tip == ".txt")
    {
        Console.WriteLine(item.Name);
    }
}

foreach (File item in files)
{
    if (item.Name.EndsWith("ua"))
    {
        Console.WriteLine(item.Name);
    }
}

foreach (File item in files)
{
    DateTime OurDate = new DateTime(2022, 9, 17);
    if (item.Date < OurDate)
    {
        Console.WriteLine(item.Name);
    }
}
