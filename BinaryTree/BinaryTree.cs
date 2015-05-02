using System;

namespace BinaryTree
{
	public class BinaryTree
	{	
		private Node root;
		public BinaryTree(){
			root = null;
		}

		public virtual void Clear(){
			root = null;
		}


		public Node Root{
			get{ return root;}
			set{ root = value;}

		}
	}
}

