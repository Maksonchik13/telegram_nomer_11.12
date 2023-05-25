// дз телеграм

//1)
int[] mas = new int[20];
int sum = 299;
int i = 0;
while (mas[19] == 0)
{
    sum += 1;
    if (sum % 17 == 0 || sum % 13 == 0)
    {
        mas[i] = sum; 
        i++;
    }
}

foreach (int a in mas)
{
    Console.Write(a+" ");
}
Console.WriteLine();
Console.WriteLine();

//2)
int[] massiv = new int[30];
int count = 1;
int index = 0;
while (massiv[29] == 0)
{
    int error = 0;
    int a = count;
    while (a > 0)
    {
        if (count % a == 0)
        {
            error++;
        }
        a--;
    }
    if (error <=2) 
    { 
        massiv[index] = count; 
        index++; 
    }
    count++;
}
foreach (int b in massiv)
{
    Console.Write(b+" ");
}