# Задача: Найти такие элементы у которых длина меньше либо равна 3

## 1. Решение через массивы: 
#### В данном решении будем использовать цикл [for](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements) для прохода по всем элементам с длиной меньше либо равных 3 и таким образом запоминаем сколько у нас таких элементов в переменной resulArrayLength.


    int resultArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
            resultArrayLength++;
    }

#### Создаем массив с размером запомненных элементов и проходимся еще раз по исходному массиву, где уже пушим наши элементы в результирующий массив.

    string[] resultArray = new string resultArray[resultArrayLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }      
    }
####  Выводим наш массив
    Console.Write("[" + string.Join(",", resultArray) + "]");
    
## 2. Решение через Linq:
#### В данном решении мы будем использовать [Linq](https://learn.microsoft.com/en-us/dotnet/standard/linq/), а точнее метод [Where](https://learn.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.where?view=netframework-4.8), где будем искать элементы, которые меньше или равны 3 и пушить их в результирующую коллекцию. Выводим наш массив.

    using System.Linq;

    string[] array = new string[]{"hello", "2", "world", ":-)"};
     var result = array.Where(x => x.Length <= 3);
     Console.Write("[" + string.Join(",", result) + "]");