
int t = 1;
List<int> digits = new List<int>();
digits.Add(1);
digits.Add(4);
digits.Add(3);
digits.Add(12);
digits.Add(123);
t = digits.ToArray().Aggregate((acc,x) => acc*x);