int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int thrownHeads = lostGamesCount / 2;
int thrownMice = lostGamesCount / 3;
int thrownKeyboards = lostGamesCount / 6;
int thrownDisplays = lostGamesCount / 12;

double totalPrice = headsetPrice*thrownHeads + mousePrice*thrownMice + keyboardPrice*thrownKeyboards + displayPrice*thrownDisplays;

Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
