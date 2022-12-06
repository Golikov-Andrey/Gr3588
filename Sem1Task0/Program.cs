
// //Считываем данные с консоли
// string? inputLine = Console.ReadLine();

// //Проверяем, чтобы данные были не пустыми
// if(inputLine!=null)
// {
//    //Парсим введенное число
//    int inputNumber = int.Parse(inputLine);

//    //Находим квадрат числа
//    int outNumber = inputNumber*inputNumber;
//    //int outNumber = (int)Math.Pow(inputNumber,2);


//    // Выводим данные в консоль 
//    Console.WriteLine(outNumber);
//    //Console.WriteLine(Math.Pow(int.Parse(inputLine),2));
// }

//Считываем данные с консоли
// string? num1Line = Console.ReadLine();

//  //Парсим введенные числа
// int startNumber = int.Parse(num1Line);

// int num2 = 2;

//  //Выходное значение
// string outLine = string.Empty;

// while (num2 <= startNumber)
// {
//     outLine = outLine + num2 + ", ";
//     num2 = num2 + 2;
// }
// Console.WriteLine(outLine);

Console.WriteLine("Введите координаты X");
int coordX = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите координаты Y");
int coordY = int.Parse(Console.ReadLine()??"0");

// (2 этап) Решение
if(coordX>0&&coordY>0)  Console.WriteLine("Точка в Четверти 1");

if(coordX>0&&coordY<0)  Console.WriteLine("Точка в Четверти 1");

if(coordX<0&&coordY<0)  Console.WriteLine("Точка в Четверти 1");

if(coordX<0&&coordY>0)  Console.WriteLine("Точка в Четверти 1");

