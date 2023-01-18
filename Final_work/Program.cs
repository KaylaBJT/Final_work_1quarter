string[] Rick = new string[] { "Hello", "2", "world", ":-)" };
string[] Morty = new string[Rick.Length];
int count = 0;
for (int i = 0; i < Rick.Length; i++)
{
    string value = Rick[i];
    if (value.Length <= 3)
    {
        Morty[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(" ", Morty));