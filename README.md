# Задача:
 **Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**


*Указанный Репозиторий содержит решение заданной задачи, как и  графическом выражении - изображение алгоритма, так и програмном коде на языке С#
в папке **алгоритм** - изображение алгоритма программы и файл Draw.io
в папке **taskC#** - решение программа  на языке С#*

## Решение задачи

* Сначала создаем строковый массив длиною в заданый
* Затем создаем метод, в который  передаются заданный массив и новый созданный массив. Далее  в теле метода цикл  с условием пока счетчик будет меньше длины массива,
проверяется условие  у ячейки масива с индексом равного счетчику - проверят значение на количество символов, в случае если меньше или равное 3, то данное значение присваивается  значению  нового масива с  такимже индексом. 
* После заверщения  цикла новый массив передается в метод печати масива, где цикл  с условием пока счетчик будет меньше длины массива вывдятся  на экран значения ячеек масива с действующим индексом 
* задача решена 

