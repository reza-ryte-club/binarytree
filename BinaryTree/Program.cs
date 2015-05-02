using System;

namespace BinaryTree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			BinaryTree btree = new BinaryTree();
			btree.Root = new Node (1);
			btree.Root.Value = 3;
			Console.WriteLine (btree.Root.Value);
			btree.Root.Left = new Node (2);
			btree.Root.Right = new Node (3);


			btree.Root.Left.Left = new Node (4);
			btree.Root.Right.Right = new Node (5);

		}
	}
}
