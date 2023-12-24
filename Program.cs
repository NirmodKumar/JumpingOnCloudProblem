// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var c = new List<int> { 0, 0, 0, 0, 1, 0 };

var response = JumpingOnClouds(c);

Console.WriteLine(response);

static int JumpingOnClouds(List<int> c)
{
    var jumpCounter = 0;

    if (c == null || !c.Any())
    {
        return jumpCounter;
    }
    int i = 0;
    while (i < c.Count)
    {
        if (i < c.Count - 2 && c[i] == 0 && c[i + 2] == 0)
        {
            jumpCounter = jumpCounter + 1;
            i = i + 2;
        }
        else if (i < c.Count - 1 && c[i] == 0 && c[i + 1] == 0)
        {
            jumpCounter = jumpCounter + 1;
            i = i + 1;
        }
        else
        {
            i++;
        }
    }

    return jumpCounter;
}

Console.ReadLine();