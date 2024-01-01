void GenericsMethod<T>(T[] input)
{
    T[] array = new T[1];
    foreach (var VARIABLE in input)
    {
        array[0] = VARIABLE;
    }
}
Dictionary<int,string> dictionary = new Dictionary<int,string>();
dictionary.Add(0,"s"); 
