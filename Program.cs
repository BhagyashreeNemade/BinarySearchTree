namespace BinarySearchTree
{
    class Program
    {
        /// <summary>
        /// ----------------->Welcome to Binary Search Tree<--------------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----------->Welcome to Binary Search Tree<----------------");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            Console.WriteLine("InOrder Traversal For Given Is BST ");
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}