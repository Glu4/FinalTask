    //Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
    // длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
    // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


{
        // Запрос пользователю на ввод исходного массива строк.
        Console.WriteLine("Введите строки через запятую (без пробелов):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        // Создаем массив для хранения строк меньше или равных 3 символам.
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат на экран.
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0; // Счетчик строк, удовлетворяющих условию.
        
        // Сначала подсчитаем, сколько строк соответствует условию.
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с размером, равным количеству строк, удовлетворяющих условию.
        string[] resultArray = new string[count];
        int resultIndex = 0;

        // Заполняем новый массив строками, удовлетворяющими условию.
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        return resultArray;
    }