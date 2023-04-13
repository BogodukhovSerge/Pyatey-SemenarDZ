// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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

int MetodSum(int Sum)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i > Lenght; i++)
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
}
int [] array = GeneratorArray(Lenght, minValui, maxValua);
System.Console.WriteLine($"Разница между мин и макс = {MetodSum(max) - (min)}");
