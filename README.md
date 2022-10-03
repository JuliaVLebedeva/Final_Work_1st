Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:

Создать репозиторий на GitHub

Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
Написать программу, решающую поставленную задачу
Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []


Описание алгоритма решения:
1. Просим пользователя задать количество элементов массива. Сохраняем это количество в переменную-счетчик, которую далеее мы используем для того, чтобы задать длину первоначального массива.
2. Задаем первоначальный массив.
3. Перебираем первоначальный массив.
* Внутри цикла предусматриваем проверку условия длины элемента (<=3 ).
* Если условие выполняется, переменную-счетчик увеличиваем.
4. Создаем второй массив, длина которого будет соответствовать переменной-счетчику. Во второй массив сохраняем все элементы, удовлетворяющие условию проверки длины элемента (<=3 ).
5. Создаем метод PrintArray, с помощью которого выводим на экран соответствующий условию сортировки второй массив, либо выводим сообщение для пользователя, что элементы, соответствующие условию поиска, среди введенных им значений нами не найдены.