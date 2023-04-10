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

int MetodNum(int sum)
{
    int[] numA = new int[0];
    
    for ( int i = 0; i <= ; i++)
    {
        if (numA[] > 99 || numA[] < 1000)
        {
            
        }
        else if (numA[i] % 2 != 0)
            {
                sum += numA[i];
            }
            
        }
    }
    return sum;
}



int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya leapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya leapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
