string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" }; //see on nagu massiiv. sushi on [0], pizza [1], jne kokku 5

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length); //tahan genereerida ühte numbrit, et saaks ülevalt nimekirjast ühe väärtuse

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");