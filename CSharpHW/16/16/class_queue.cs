namespace _16
{


    public class Queue<T>
    {
        Element<T> front;
        Element<T> back;

        //add element to the back of collection
        public void Enqueue(Element<T> listElement)
        {

            if (front == null)
            {
                front = listElement;
                front.Next = null;
            }
            else if (back == null)
            {
                back = listElement;
                front.Next = back;
            }
            else
            {
                back.Next = listElement;
                back = listElement;
                back.Next = null;
            }
        }

        //return front element and delete it
        public Element<T> Dequeue()
        {
            if (front == null)
            {
                return null;
            }

            else if (front.Next == null)
            {
                var result = front;
                front = null;
                return result;
            }

            else if (front.Next == back)
            {
                var result = front;
                front = back;
                front.Next = null;
                back = null;
                return result;
            }

            else
            {
                var result = front;
                front = front.Next;
                return result;
            }
        }
        //return front element and dont delete it
        public Element<T> Peek()
        {
            if (front == null)
            {
                return null;
            }
            else
            {
                return front;
            }
        }
    }
}

