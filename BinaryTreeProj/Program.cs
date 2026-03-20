using MyBinaryTreeProj;

MyBinaryTree<int> tree = new MyBinaryTree<int>();

// You'll need an Add method for this to work — do you have one?
// Assuming you do:
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(1);
tree.Add(4);

//       5
//      / \
//     3   7
//    / \
//   1   4

Console.WriteLine("Count: " + tree.Count);
Console.WriteLine("Contains 4: " + tree.Contains(4));
Console.WriteLine("Contains 9: " + tree.Contains(9));

Console.WriteLine("Post-order:");
foreach (var item in tree.PostOrderTraversal())
{
    Console.Write(item + " ");
}
// Expected: 1 4 3 7 5
Console.WriteLine();

tree.Clear();
Console.WriteLine("After Clear, Count: " + tree.Count);