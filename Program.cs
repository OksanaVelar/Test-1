// Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк,
// формирует массив из строк, длина которых меньше или равна 3 символам
string text = "Моя первая контрольная в GeekBrains";
string[] subs = text.Split(" ");
foreach (var sub in subs)
{
    Console.WriteLine($"Длина элемента массива {sub} = {sub.Length}");
    //Console.WriteLine(sub.Length);
    
}
// text = text.Replace ("первая", " ");
// text = text.Replace ("контрольная", " ");
// text = text.Replace ("GeekBrains", " ");
// Console.WriteLine(text);

