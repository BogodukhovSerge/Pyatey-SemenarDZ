// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
    int Lenght = 0;
    for ( int i = 0; i <= Lenght; i++)
    {
        if (array[i] % 2 == 0)
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