## Задача:
  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения задачи:
Блок-схема алгоритма решения задачи находится в папке DIAGRAM. Именно по данной схеме и решалась задача.
 
 То есть: объявляем два массива, одинаковой длины. Далее идет цикл, в котором мы проходим по всей длине массива.Также внутри этого цикла у нас происходит проверка условия (в нашем случае <= 3). Если условие выполняется, то элемент из первого массива "переносится" во второй, и происходит проверка следующего элемента. Если же условие не выполняется, то мы сразу проверяем следующий элемент массива. Так происходит до конца цикла. С помощью функции void выводим массив, удовлетворяющий нашему условию. 

Программа, решающая поставленную задачу находится в папке TASK.
