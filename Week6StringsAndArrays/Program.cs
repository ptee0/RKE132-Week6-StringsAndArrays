//string hello = " hello, world! Here I am!";
//                                 //"hello" h asub kohal [0], e kohal [1], l [2], l [3], o [4], kokku sõne pikkus 5; viimase sümboli väärtus on alati length -1, sest lugemist alustatakse 0'st.
//int stringLenght = hello.Length; //length näitab, kui pikk string (sõne) on; loeb ka tühikuid ja sümboleid, kõigil neil oma väärtus

////string trimmedString = hello.Trim();                

//hello = hello.Trim();

//int wordCounter = 0;

//for(int i = 0; i < hello.Length ; i++)
//{
//    if(hello[i] == ' ')
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word counter in {hello}: {wordCounter + 1} words.");

//elegantsem lahendus
string hello = " hello, world! Here I am!"; // iga sümbol lauses on char

int stringLenght = hello.Length;  

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('!', '?');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);



//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word counter in {hello}: {wordCounter} words.");