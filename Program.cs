/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/

string []  userDigits (int size)
{
    string [] userDigits= new string [size];
    Console.WriteLine("Введите числа: ");
    for(int i=0; i < size; i++)
    {
        Console.Write($"Введите число {i+1}>>> ");
        userDigits[i] = Console.ReadLine();
    }
    return userDigits;
}

void showArray (string [] array)
{
    Console.Write ($"Получившийся массив -> ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
    Console.WriteLine();
}

string []  checkThree (string [] array)
{
    string [] newArray = new string [array.Length];
    int count = 0;
    for (int i=0; i < array.Length; i++)
    
    {
        if (array[i].Length<4)
        {
            newArray [count]=array[i]; 
            count++;
        }
    }
    return newArray;

}



Console.Write("Введите число элементов массива  >>> ");
int size = Convert.ToInt16(Console.ReadLine());
string [] myArray = userDigits (size);
showArray(myArray);

Console.WriteLine("Проверим элементы на 3 символа и создадим новый массив");
string [] newArray = checkThree(myArray);

showArray(newArray);

