string[] array = new string[] {"hello", "swift", "C#", "box", "google", "gb", "Apple"};
int index = 0;
string[] newArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    string element = array[i];
    if (element.Length <= 3) 
    {
        newArray[index] = element;
        index++;
}
}
Console.WriteLine(string.Join(Environment.NewLine, newArray));
Console.ReadKey(true);
