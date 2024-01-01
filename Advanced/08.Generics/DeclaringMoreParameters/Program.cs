KeyValuePair<TKey,TValue> CreateKeyValuePair<TKey,TValue>(TKey key, TValue value)
{
    Console.WriteLine(key);
    Console.WriteLine(value);
    return new KeyValuePair<TKey, TValue>(key, value);
}

