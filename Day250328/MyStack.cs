namespace Day250328;

public class MyStack<T>
{
    private int stackLength;
    private T[] arrStacks;

    public MyStack()
    {
        stackLength = 10;
        arrStacks = new T[stackLength];
    }

    public void Push(T str)
    {
        for (int i = 0; i < stackLength; i++)
        {
            if (i == stackLength - 1)
            {
                ReSize();
            }
            
            if (arrStacks[i] == null)
            {
                arrStacks[i] = str;
                break;
            }

        }
    }

    public void ReSize()
    {
        T[] tempStacks = new T[stackLength];
        tempStacks = arrStacks;

        stackLength *= 2;
        arrStacks = new T[stackLength];
        
        for (int i = 0; i < arrStacks.Length; i++)
        {
            if (tempStacks[i] == null)
            {
                break;
            }
            else
            {
                arrStacks[i] = tempStacks[i];
            }
        }
    }

    public T Peek()
    {
        int tail = 0;
        for (int i = 0; i < arrStacks.Length; i++)
        {
            if (arrStacks[i] == null)
            {
                tail = i - 1;

                if (tail < 0)
                {
                    tail = 0;
                }
                break;
            }
        }

        return arrStacks[tail];
    }

    public T Pop()
    {
        int tail = 0;
        for (int i = 0; i < arrStacks.Length; i++)
        {
            if (arrStacks[i] == null)
            {
                tail = i - 1;
                break;
            }
        }

        T tempArr = arrStacks[tail];
        arrStacks[tail] = default(T);
        
        return tempArr;
    }

    public void Clear()
    {
        stackLength = 10;
        arrStacks = new T[stackLength];
        for (int i = 0; i < arrStacks.Length; i++)
        {
            if (typeof(T) == typeof(string))
            {
                arrStacks[i] = (T)(object)string.Empty;
            }
            else
            {
                arrStacks[i] = default(T);
            }
        }
    }
    
    
    public T[] stringT
    {
        get
        {
            return arrStacks;
        }
    }
    
}
