namespace Day250328;

public class Team
{
    public int Yosepus(int n, int k)
    {
        Queue<int> queue = new Queue<int>(n);
        for (int i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        int count = 0;
        while (queue.Count > 1)
        {
            count++;
            if (count % k == 0)
            {
                queue.Dequeue();
            }
            else
            {
                int value = queue.Dequeue();
                queue.Enqueue(value);
            }
        }

        return queue.Dequeue();
    }

    public bool IsCorrectBracket(string str)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            switch (c)
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(c);
                    break;

                case ')':
                    if (stack.Count == 0)
                        return false;

                    if (stack.Peek() != '(')
                        return false;

                    stack.Pop();
                    break;

                case '}':
                    if (stack.Count == 0)
                        return false;

                    if (stack.Peek() != '{')
                        return false;

                    stack.Pop();
                    break;

                case ']':
                    if (stack.Count == 0)
                        return false;

                    if (stack.Peek() != '[')
                        return false;

                    stack.Pop();
                    break;
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}