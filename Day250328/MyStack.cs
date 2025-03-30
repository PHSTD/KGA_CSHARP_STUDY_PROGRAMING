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
    
    
    public T[] stringT
    {
        get { return arrStacks; }
    }
    
}
