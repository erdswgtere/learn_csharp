﻿/*****************************************************
******************************************************
**                                                  **
**  Программа проверка разряда числа, является ли   **
**  первая цифра разряда меньше 6                   **
**                                                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т. **
**                                                  **
******************************************************
*****************************************************/
ulong a;
Console.Write("a = ");
a = Convert.ToUInt64(Console.ReadLine());
while (a > 9){
    a = a / 10;
    
}
if(a <= 6){
    Console.WriteLine("Верно");

} else{
    Console.WriteLine("Неверно");
}