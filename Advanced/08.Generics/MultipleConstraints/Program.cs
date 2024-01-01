using System.Text;

//Stack<StringBuilder> stack;

//class Stack<T> where T : class
//{

//}

Console.WriteLine(SpawnEnemies<Enemy>());
T SpawnEnemies<T>() where T : new()
{
    T enemyy = new T();
    return enemyy;
}

class Enemy
{
    public string name { get; set; }
    

}