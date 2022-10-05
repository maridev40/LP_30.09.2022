Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckingNumber(int num1, int num2){
  int min = num1;
  int max = num2;
  if (min > max) {
     min = num2;
   max = num1;
  }
  return max == min * min;
}

bool res = CheckingNumber(num1, num2);
if (res){
    Console.WriteLine("Да");
}
else  Console.WriteLine("Нет");