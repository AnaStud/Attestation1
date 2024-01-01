string[] InputArray(int arrayLength) {

    string[] array = new string[arrayLength];

    for (int i = 0; i < arrayLength; i++) {
        Console.Write($"Введите элемент №{i + 1}: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] CreateArrayLength3(string[] array) {

    int count = array.Length;
    string[] arrayNew = new string[count];
    int countNew = 0;

    for (int i = 0; i < count; i++) {
        if (array[i].Length <= 3) {
            arrayNew[countNew] = array[i];
            countNew++;
        }
    }

    return arrayNew;
}

void PrintArray(string[] array) {

    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] array = InputArray(count);

string[] arrayNew = CreateArrayLength3(array);

Console.WriteLine("Новый массив: ");
PrintArray(arrayNew);