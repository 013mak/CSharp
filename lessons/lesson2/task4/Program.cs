int n = 5;
int[] array = {1, 444, 5, 6, 67};
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i]>max) {max = array[i];}
    i++;
}
Console.WriteLine(max);
