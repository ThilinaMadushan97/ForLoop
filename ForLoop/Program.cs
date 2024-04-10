for(int i=0; i<100; i++)
{
   

    if (i % 3 == 0 && i % 5 == 0)
    {

        Console.WriteLine($"{i} = Freez & Burzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} = Freez");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine($"{i} = Burzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
