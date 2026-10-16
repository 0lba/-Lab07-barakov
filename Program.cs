//задание 1.1
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = days.Length - 1; i != -1; i--){
//     Console.WriteLine($"{i + 1}: {days[i]}");
// }
//задание 1.2
// double[] temps = {12.2, -1.3, -30.5, 20.3, 21.3, 32.3, 41.6};
// foreach (double i in temps){
//     Console.Write($"{i} ");
// }
//задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int c = 0;
// foreach (int i in prices){
//     sum += i;
//     if (i > 100){
//         c++;
//     }
// }
// Console.WriteLine(sum);
// Console.WriteLine((double)sum / prices.Length);
// Console.WriteLine(c);
//задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int index = 0;
// int max = 0;
// for (int i = 0; i < prices.Length; i++){
//     if (prices[i] < min){
//         min = prices[i];
//     }else if (prices[i] > max){
//         index = i;
//         max = prices[i];
//     }
// }
// Console.WriteLine(min);
// Console.WriteLine(index);
//задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++){
//     if (balance[i] < 0){
//         balance[i] = 0;
//     }
// }
// foreach (int i in balance){
//     Console.WriteLine(i);
// }
//задание 5
// int[] q = new int[5];
// int ch = 0;
// for (int i = 0; i < q.Length; i++){
//     int a = int.Parse(Console.ReadLine());
//     q[i] = a;
//     if (a % 2 == 0){
//         ch++;
//     }
// }
// for (int i = q.Length - 1; i != -1; i--){
//     Console.Write($"{q[i]} ");
// }
// Console.WriteLine("");
// Console.WriteLine(ch);
//задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// string a = Console.ReadLine();
// int index = -1;
// for (int i = 0; i < names.Length; i++){
//     if (a == names[i]){
//         index = i;
//         break;
//     }
// }
// if (index > -1){
//     Console.WriteLine(index);
// }else{
//     Console.WriteLine("Не найдено");
// }
//задание 7
int[] grades = { 2, 3, 4, 5, 2, 3, 2, 4 };
int sum = 0;
int max = grades[0];
int min = grades[0];
int c2 = 0;
int c5 = 0;
foreach (int i in grades)
{
    Console.Write($"{i} ");
    sum += i;
    if (i > max) max = i;
    if (i < min) min = i;
    if (i == 2) c2++;
    else if (i == 5) c5++;
}
Console.WriteLine();
double average = (double)sum / grades.Length;
Console.WriteLine($"Средняя оценка: {average}");
Console.WriteLine($"Наибольшая: {max}, наименьшая: {min}");
Console.WriteLine($"Двоек: {c2}, пятёрок: {c5}");
if (average >= 4.5)
    Console.WriteLine("Отличник");
else if (average >= 3.5)
    Console.WriteLine("Хорошист");
else
    Console.WriteLine("Есть над чем поработать");
//задание 8
// int[] arr = { 1, 2, 3, 4, 5, 6 };
// foreach (int i in arr) Console.Write($"{i}");
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int a = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = a;
// }
// Console.WriteLine();
// foreach (int i in arr) Console.Write($"{i}");