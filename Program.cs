// Калинин Павел 02.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Домашняя работа

int intN1 = 0, intN2 = 0; 
double doubleN = 0, doubleN1 = 0, doubleN2 = 0, doubleN3 = 0;
bool isRepeat = true; 
string taskName = "";

taskName = "Задание  №1. По двум заданным числам проверять является ли первое квадратом второго.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите первое целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите второе целое число: ");
    intN2 = int.Parse(Console.ReadLine() ?? "0");
    if(intN1>=0 && intN1*intN1 == intN2) {
        Console.WriteLine("Число "+intN1+" является квадратом числа "+intN2);
    } else {
        Console.WriteLine("Число "+intN1+" НЕ является квадратом числа "+intN2);
    }
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    

taskName = "Задание  №2. По заданному номеру дня недели вывести его название.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите номер дня недели (1 ... 7): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    string dayOfWeek = "Введен неправильный номер дня недели - ";
    switch (intN1) {
        case 1: dayOfWeek = "1 - Понедельник"; break;
        case 2: dayOfWeek = "2 - Вторник"; break;
        case 3: dayOfWeek = "3 - Среда"; break;
        case 4: dayOfWeek = "4 - Четверг"; break;
        case 5: dayOfWeek = "5 - Пятница"; break;
        case 6: dayOfWeek = "6 - Суббота"; break;
        case 7: dayOfWeek = "7 - Воскресенье"; break;
    }
    Console.WriteLine(dayOfWeek+intN1);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №3. Найти максимальное из трех чисел.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите первое действующее число: ");
    doubleN1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите второе действующее число: ");
    doubleN2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите третье действующее число: ");
    doubleN3 = double.Parse(Console.ReadLine() ?? "0");
    doubleN = doubleN3;
    if(doubleN1 > doubleN2 && doubleN1 > doubleN3) {
        doubleN = doubleN1;
    } else if(doubleN2 > doubleN3) {
        doubleN = doubleN2;
    } 
    Console.WriteLine("Максимальное из трех чисел: "+doubleN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №4. Выяснить является ли число чётным.";


taskName = "Задание  №5. Показать числа от -N до N.";


taskName = "Задание  №6. Показать четные числа от 1 до N.";


taskName = "Задание  №7. Показать последнюю цифру трёхзначного числа.";


taskName = "Задание  №8. Показать вторую цифру трёхзначного числа.";


taskName = "Задание  №9. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.";


taskName = "Задание №10. Удалить вторую цифру трёхзначного числа.";


taskName = "Задание №11. Выяснить, кратно ли число заданному, если нет, вывести остаток.";


taskName = "Задание №12. Найти третью цифру числа или сообщить, что её нет.";