using System;
namespace ObjectVsGenericClass;
public class ObjectList
{
    private object[] elements;
    private int index = 0;
    public ObjectList()
    {
        elements = new object[4];
    }

    public object this[int index]
    {
        get
        {
            return elements[index];
        }
        set
        {
            elements[index] = value;
        }
   
    }

    public void Add(object element)
    {
        elements[index++] = element;

    }

}
public class GenericsList<T>
{
    private T[] elements;
    public GenericsList()
    {
        elements = new T[4];
    }
    private int index = 0;

    public void Add(T element)
    {
        elements[index++] = element;

    }

}
