// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int MetodNum(int sum)
{
    int[] numA = new int[i];
    int lenght = 0;
    for ( int i = 0; i <= lenght; i++)
    {
        if (i % 2 != 0 ? sum += numA[i] : 0);
    }
    return sum;
}

int [] array = GeneratorArray(Lenght, min, max);
MetodNum(sum);
