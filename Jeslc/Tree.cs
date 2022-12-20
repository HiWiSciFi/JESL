namespace Jeslc
{
	public static partial class Parser
	{
		public enum NodeType
		{
			None,
			Program
		}

		public abstract class Tree : IDisposable
		{
			public Tree? parent = null;
			public NodeType type = NodeType.None;

			public Tree() { }

			private static void AddIndent(int indent)
			{
				for (int i = 0; i < indent; i++) Console.Write("|  ");
			}

			public virtual void Dispose()
			{
				GC.SuppressFinalize(this);
			}

			public virtual void Print(int indent)
			{
				AddIndent(indent);
				Console.WriteLine($"NodeType: {type}");
			}
		}

		public class Program : Tree
		{
			public Tree? child = null;

			public Program()
			{
				type = NodeType.Program;
			}

			public Program(Tree? child)
			{
				this.child = child;
				type = NodeType.Program;
			}

			public override void Dispose()
			{
				child?.Dispose();
				GC.SuppressFinalize(this);
			}

			public void SetChild(Tree? child)
			{
				if (this.child != child) this.child?.Dispose();
				this.child = child;
				if (child != null) child.parent = this;
			}
		}
	}
}
