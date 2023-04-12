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

int MetodNum(int count)
{
    int[] numA = new int[0];
    int lenght = 0;
    for ( int i = 0; i <= lenght; i++)
    {
        if (numA[] > 99 || numA[] < 1000 ? numA[i] % 2 == 0 : (0))
        {
            count += numA[i];
        }
    }
    return count;
}



int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya deapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya deapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
MetodNum(count);