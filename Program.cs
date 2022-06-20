// Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символам
string[] text = { "Моя", "первая", "контрольная", "работа", "в", "GeekBrains" };
string f;
Console.WriteLine("Исходный массив строк: ");
for (int i = 0; i < text.Length; i++)
{
    f = text[i];
    Console.WriteLine(" " + " " + " " + f + " ");
}
Console.WriteLine("_______");
Console.WriteLine();
Console.Write("Сформированный массив строк: ");
void Sort(string[] text)
{
    string k;
    for (int i = 0; i < text.Length; i++)
    {
        k = text[i];

        if (k.Length > 3)
        {
            k = " ";
        }
        Console.Write(k + " ");
    }
}

Sort(text);
