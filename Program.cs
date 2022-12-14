// Калинин Павел 02.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Домашняя работа

int intN = 0, intN1 = 0, intN2 = 0; 
double doubleN = 0, doubleN1 = 0, doubleN2 = 0, doubleN3 = 0;
bool isRepeat = true; 
string taskName = "";

//if(false) { // выборочно отключить для отладки

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
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    if(intN1%2 == 0) {
        Console.WriteLine("Число "+intN1+" является четным.");
    } else {
        Console.WriteLine("Число "+intN1+" НЕ является четным.");
    }
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №5. Показать числа от -N до N.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Числа от -N до N: ");
    for(int i=(-1)*intN1; i<=intN1; i++) {
        Console.Write(i+" ");
    }
    Console.WriteLine("");
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    

 
taskName = "Задание  №6. Показать четные числа от 1 до N.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Четные числа от 1 до N: ");
    for(int i=1; i<=intN1; i++) {
        if(i%2 == 0)
            Console.Write(i+" ");
    }
    Console.WriteLine("");
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №7. Показать последнюю цифру трёхзначного числа.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое трехзначное число (ххх): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    intN = intN1 - (intN1/10)*10;
    Console.WriteLine("Последняя цифра трехзначного числа (если считать с лева на право) "+intN1+" = "+intN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №8. Показать вторую цифру трёхзначного числа.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое трехзначное число (ххх): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    intN = intN1 - (intN1/100)*100;
    intN = intN/10;
    Console.WriteLine("Вторая цифра (если считать с лева на право) трехзначного числа "+intN1+" = "+intN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №9. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое двузначное число из отрезка [10, 99] (хх): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    intN = (intN1/10 > intN1%10) ? intN1/10 : intN1%10;
    Console.WriteLine("Наибольшая цифра числа "+intN1+" = "+intN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание №10. Удалить вторую цифру трёхзначного числа.";
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите целое трехзначное число (ххх): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    intN = (intN1/100)*10 + intN1%10;
    Console.WriteLine("Число после удаления второй цифры из числа "+intN1+" = "+intN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание №11. Выяснить, кратно ли число заданному, если нет, вывести остаток.";
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите первое целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите второе целое число: ");
    intN2 = int.Parse(Console.ReadLine() ?? "0");
    intN = intN1%intN2;
    if(intN == 0) Console.WriteLine("Число "+intN2+" кратно числу "+intN1);
    else          Console.WriteLine("Число "+intN2+" НЕ кратно числу "+intN1+" и имеет остаток "+intN);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание №12. Найти третью цифру числа или сообщить, что её нет.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("----------------------------\n\r"+taskName);
    Console.Write("Введите действующее число: ");
    string s = Console.ReadLine() ?? "0";
    // оставить в действующем числе только цифры ([0-9])
    string s2 = s.Replace("-","").Replace(".","").Replace(",","");
    if(s2.Length<3) Console.WriteLine("Третья цифра (если считать с лева на право) в числе "+s+" отсутствует.");
    else            Console.WriteLine("Третья цифра (если считать с лева на право) числа "+s+" = "+s2[3-1]);
    Console.Write("Выполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    

