// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Bass(string sms)
{
    System.Console.WriteLine(sms);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result; 
}


float[] GeneratorArray(float Lenght, float minValui, float maxValua)
{
    float[] array = new float[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValui, maxValua + 1);
    }
    return array;

}  

void MetodRazneca(int[] array)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i > Lenght; i++)
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
}

int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya leapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya leapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
System.Console.WriteLine($"Разница между мин и макс = {MetodRazneca(maxA) - (minA)}");
