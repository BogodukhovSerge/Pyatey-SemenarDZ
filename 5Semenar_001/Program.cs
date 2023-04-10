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

void MetodNum(int num)
{
    int count = 0;
    int numA = 0;
    for ( int i = 0; i <= array.Lenght; count = i % 2 == 0)
    {

        if (num > 99 || num < 1000)

        {
            System.Console.WriteLine("Выполняются условия: ");
        }
    }
    Console.Write("-");

}



int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya leapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya leapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
