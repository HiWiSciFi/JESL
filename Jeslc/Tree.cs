namespace Jeslc
{
	public static partial class Parser
	{
		public enum NodeType
		{
			None,

			Program,
			Function,

			IntegerLiteral,

			ReturnStatement
		}

		public abstract class Tree : IDisposable
		{
			public Tree? parent = null;
			public NodeType type = NodeType.None;

			protected static void AddIndent(int indent)
			{
				for (int i = 0; i < indent; i++) Console.Write("|  ");
			}

			public virtual void Dispose()
			{
				GC.SuppressFinalize(this);
			}

			public virtual void Print(int indent = 0)
			{
				AddIndent(indent);
				Console.WriteLine($"NodeType: {type}");
			}
		}

		public class Program : Tree
		{
			public List<Function> functions = new();

			public Program()
			{
				type = NodeType.Program;
			}

			public Program(Function function)
			{
				type = NodeType.Program;
				AddFunction(function);
			}

			public Program(List<Function> functions)
			{
				type = NodeType.Program;
				AddFunctions(functions);
			}

			public override void Dispose()
			{
				base.Dispose();
				for (int i = 0; i < functions.Count; i++) functions[i].Dispose();
				GC.SuppressFinalize(this);
			}

			public void AddFunction(Function function)
			{
				function.parent = this;
				functions.Add(function);
			}

			public void AddFunctions(IEnumerable<Function> functions)
			{
				foreach (Function f in functions)
				{
					f.parent = this;
					this.functions.Add(f);
				}
			}

			public override void Print(int indent = 0)
			{
				AddIndent(indent);
				Console.WriteLine("Program");
				for (int i = 0; i < functions.Count; i++) functions[i].Print(indent + 1);
			}
		}

		public class Function : Tree
		{
			public string identifier = string.Empty;
			public Statement? body = null;

			public Function()
			{
				type = NodeType.Function;
			}

			public Function(string? identifier)
			{
				type = NodeType.Function;
				this.identifier = identifier;
			}

			public Function(string? identifier, Statement? body)
			{
				type = NodeType.Function;
				this.identifier = identifier;
				if (body is not null) body.parent = this;
				this.body = body;
			}

			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}

			public void SetBody(Statement body)
			{
				this.body?.Dispose();
				body.parent = this;
				this.body = body;
			}

			public override void Print(int indent = 0)
			{
				AddIndent(indent);
				Console.WriteLine($"Function \"{identifier}\"");
				AddIndent(indent);
				Console.WriteLine("- Body:");
				body?.Print(indent + 1);
			}
		}

// ---------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------- Expressions ----------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------

		public abstract class Expression : Tree
		{
			//public Expression? body = null;

			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}

			//public void SetBody(Expression body)
			//{
			//	this.body?.Dispose();
			//	body.parent = this;
			//	this.body = body;
			//}
		}

// ---------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------ Literals -----------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------

		public abstract class Literal : Expression
		{
			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}
		}

		public class LiteralInt : Literal
		{
			public Int32? value = null;

			public LiteralInt()
			{
				type = NodeType.IntegerLiteral;
			}

			public LiteralInt(Int32 value)
			{
				type = NodeType.IntegerLiteral;
				this.value = value;
			}

			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}

			public override void Print(int indent = 0)
			{
				AddIndent(indent);
				Console.WriteLine($"Int Literal: {value}");
			}
		}

// ---------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------- Statements ----------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------

		public abstract class Statement : Tree
		{
			public override void Dispose()
			{
				base.Dispose();
				GC.SuppressFinalize(this);
			}
		}

		public class StatementReturn : Statement
		{
			public Expression? value = null;

			public StatementReturn()
			{
				type = NodeType.ReturnStatement;
			}

			public StatementReturn(Expression? value)
			{
				type = NodeType.ReturnStatement;
				this.value = value;
			}

			public override void Dispose()
			{
				base.Dispose();
				value?.Dispose();
				GC.SuppressFinalize(this);
			}

			public override void Print(int indent = 0)
			{
				AddIndent(indent);
				Console.WriteLine("Return");
				value?.Print(indent+1);
			}
		}
	}
}
