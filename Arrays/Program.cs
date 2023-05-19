//massiivid on selleks, et säilitada teatud andmed ühes kohas. Ühes massiivis tohivad olla vaid ühte tüüpi andmed.
//string[] fruit = {"apples", "bananas", "oranges"} //aga ei saaks panna juurde 3 või true, sest need pole stringid, vaid teist tüüpi andmed.

string[] fruit = new string[3];//määratud et peab olema 3 elementi, nt fruit[0] <-- fruit kohal 0, fruit [1] jne. Neile saab ka väärtused anda

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}"); //aga kui on nt 100 puuvilja, siis ei hakka nii käsitsi kirjutama.
                                                            //massiivil on ka olemas omadus Length
int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array.");

//for ( int i = 0;i < fruitArrayLength; i++)
//{
//    Console.WriteLine(fruit[i]);
//}

//foreach(string element in fruit) //alternatiiv eelmisele for'ile. Võib lugeda kui "iga sõne fruit massiivis"; element tähendab kõiki neid fruit [0], [1], [2]
//{
//    Console.WriteLine(element);
//}

//väikese algustähe suureks muutmine. Suur erinevus massiivi ja sõne vahel on, et massiivides olevaid väärtuseid võib ümber kirjutada
for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}
foreach (string element in fruit)
{
    Console.WriteLine(element);
}