// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// cколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2a
// 1, -7, 567, 89, 223-> 3


int Bass(string sms)
{
    System.Console.WriteLine(sms);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result; 
}

int[] GeneratorArray(int Lenght, int minValui, int maxValua)
{
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValui, maxValua + 1);
    }
    return array;

}  

int MetodCount(int[] array)
{
    int count = 0;
    for ( int i = 0; i <= array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
} 



int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya deapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya deapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
System.Console.WriteLine($"kolichestvo chet chisel = {MetodCount(array)}");
