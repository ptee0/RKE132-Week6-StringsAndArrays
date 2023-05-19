int[] numbers = new int[10]; //see lõpp osa on tühi massiv vahemälus, mis on valmis salvestama 10 väärtust täisnumbri formaadis
Random rnd = new Random();

int sum = 0;

//populating the array
for (int i = 0;i < numbers.Length; i++)//selle for loopiga täidame massiivi
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];//liidab kokku
}

foreach(int number in numbers)//foreachiga kuvame väärtused, mis sinna tulid
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");//kuvab kogu summa