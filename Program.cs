//У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
//Необходимо составить код, который находит их пересечение. 
//Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего 
//С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков,
// общую точку или «не пересекаются»
int x1, x2, x3, x4;
Console.Write("Введитe x1: ");
x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe x2: ");
x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe x3: ");
x3=Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe x4: ");
x4=Convert.ToInt32(Console.ReadLine());
if (x1>x2)
{ int temp1=x1;
      x1=x2;
      x2=temp1;
}
if (x3>x4)
{ int temp2=x3;
      x3=x4;
      x4=temp2;}
if (x2<x3)
   {Console.Write("Не пересекаются");}
if (x2==x3)
   {Console.Write($"Пересекаются в точке {x3} ");}
if (x2>x3)
   {Console.Write($"Пересекаются в отрезке {x3}, {x2}");}



