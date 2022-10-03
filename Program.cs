/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void Test()
            {
                Console.WriteLine("Пожалуйста, введите число элементов массива и нажмите Enter");
                int countArray1 = int.Parse(Console.ReadLine());

                string[] initialArray = new string[countArray1];

                string[] FillArray(string[] array)
                {
                    for (int i = 0; i < countArray1; i++)
                    {
                        Console.WriteLine($"Введите {i}-е значение и нажмите Enter:");
                        array[i] = Console.ReadLine();
                    }
                    return array;
                }

                string[] SortArray(string[] array)
                {
                    int countArray2 = 0;
                    string arrayValue = string.Empty;
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayValue = array[i];
                        if (arrayValue.Length <= 3) countArray2++;
                    }

                    string[] sortedArray = new string[countArray2];
                    int index = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayValue = array[i];
                        if (arrayValue.Length <= 3)
                        {
                            sortedArray[index] = array[i];
                            index++;
                        }
                    }
                    return sortedArray;

                }

                void PrintArray(string[] array)
                {
                    if (array.Length == 0) Console.WriteLine("Отсутствуют элементы, длина которых меньше либо равна 3 символам");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"  {array[i]}");
                    }
                }

                FillArray(initialArray);

                string[] finalArray = SortArray(initialArray);

                Console.WriteLine("\n Первоначальный массив:");
                PrintArray(initialArray);

                Console.WriteLine("\n Массив элементов, длина которых меньше либо равна 3 символам:");
                PrintArray(finalArray);
                Console.ReadKey();
            }
            Test();