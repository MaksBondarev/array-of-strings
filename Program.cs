Console.Clear();

string[] array = new string[] { "12", "324", "325", ":-)", "Hello", "MIR", "1", "world", "23654", "yes", "56123" };
string count = string.Empty;

for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length <= 3)
    {
        count = array[i];
        Console.Write($"{count}, ");
    }

}
