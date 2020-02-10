namespace _16
{
    public class Stack<T>
    {
        Element<T> first;

        //add element to stack at the first place
        public void Push(Element<T> listElement)
        {

            if (first == null)
            {
                first = listElement;
            }

            else
            {
                listElement.Next = first;
                first = listElement;
            }
        }

        public Element<T> Pop()
        {

            if (first == null)
            {
                return null;
            }

            else
            {
                var result = first;
                first = first.Next;
                return result;
            }
        }

        public Element<T> Peek()
        {

            if (first == null)
            {
                return null;
            }

            else
            {
                return first;
            }
        }
    }
}

