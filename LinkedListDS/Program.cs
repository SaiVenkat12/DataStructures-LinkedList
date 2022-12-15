
namespace LinkedListDS
{
    class program
    {
        public static void Main(string[] args)
        {
            linkedlist LinkedList = new linkedlist();
            LinkedList.Append(56);
            LinkedList.Append(70);
            //LinkedList.Append(30);

            LinkedList.InsertAtParticularPoistion(2, 30);
            
            LinkedList.Display();
            //LinkedList.RemoveFirst();
            //LinkedList.Display();
            LinkedList.RemoveLast();
            LinkedList.Display();

        }
    }
}