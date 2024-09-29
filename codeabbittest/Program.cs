// See https://aka.ms/new-console-template for more information

bool featureflag = true;

Console.WriteLine("Hello, World!");
Console.WriteLine("Review this!");
Console.WriteLine("Review this!");
Console.WriteLine("Review this!");

if (featureflag)
{
    Console.WriteLine("This code seems to be hidden behind a faked featureflag");
}
else
{
    Console.WriteLine("This code seems to be hidden behind a faked featureflag");
}

Console.WriteLine("HOW ABOUNT THIS CODE");