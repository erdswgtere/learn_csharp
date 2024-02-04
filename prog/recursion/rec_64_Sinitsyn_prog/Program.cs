/*****************************************************
******************************************************
**                                                  **
**  Алгоритм вычисления функции F(n) задан          **
** следующими соотношениями:                        **
** F(n) =  n + 3, при n  18                        **
** F(n) = (n // 3) · F(n // 3) + n – 12, при n > 18,**
**  кратных 3                                       **
** F(n) = F(n–1) + n · n + 5, при n > 18,           **
**  не кратных 3                                    **
** Определите количество натуральных значений n из  **
** отрезка [1; 800], для которых                    **
** все цифры значения F(n) чётные.                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
Stopwatch stopWatch = new Stopwatch();
static long F(long x){
    if(x <= 18)
    return x + 3;
    else if(x > 18 && x % 3 == 0)
       return x / 3 * F(x / 3) + x - 12;
    else
       return F(x - 1) + x * x + 5;
}
// int[] nech = { 1, 3, 5, 7, 9}; //
stopWatch.Start();
int k = 0;
for(int i = 1; i <= 800; i++ ){
    bool ch = true;
    long a = F(i);
    while(a != 0){
        if(a % 2 == 0){
            a /= 10;
        } else{
            ch = false;
            break;
        }
    }
    if(ch == true) k++;
}
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine($"Количество натуральных значений n из отрезка, для которых все значения F(n) чётные: {k}");
Console.WriteLine($"Прошло времени: {ts.Milliseconds} мс");
