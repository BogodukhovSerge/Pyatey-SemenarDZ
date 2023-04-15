// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int MetodSum(int[] array)
{
    int sum = 0;
    for ( int i = 0; i <= array.Lenght; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya leapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya leapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
System.Console.WriteLine($"otrecat chisel {array} = {MetodSum(sum)}");

