string[] massiv = new string[] { "Hello", "2", "world", ":-)" };
string[] result = new string[massiv.Length];
int count = 0;
for (int i = 0; i < massiv.Length; i++)
{
    string value = massiv[i];
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(" ", result));