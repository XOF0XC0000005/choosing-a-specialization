string[] array = new string[]{"hello", "2", "world", ":-)"};
int resultArrayLength = 0;
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
        resultArrayLength++;
}

string[] resultArray = new string[resultArrayLength];

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        resultArray[j] = array[i];
        j++;
    }
        
}

Console.Write("[" + string.Join(",", resultArray) + "]");

// using System.Linq;

// string[] array = new string[]{"hello", "2", "world", ":-)"};
// var result = array.Where(x => x.Length <= 3);
// Console.Write("[" + string.Join(",", result) + "]");
