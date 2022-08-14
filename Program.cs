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
            Console.WriteLine("InOrder Traversal For Given Is BST ");
            binarySearch.Display();
            Console.ReadLine();
        }
    }
}