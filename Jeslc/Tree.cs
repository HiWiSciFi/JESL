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
				base.Dispose();
				child?.Dispose();
				GC.SuppressFinalize(this);
			}

			public void SetChild(Tree? child)
			{
				if (this.child != child) this.child?.Dispose();
				this.child = child;
				if (child is not null) child.parent = this;
			}
		}

		public abstract class Statement : Tree
		{
			public Tree? body = null;

			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}
		}

		public abstract class Literal : Tree
		{
			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}
		}
	}
}
