namespace Jeslc
{
	public static partial class Parser
	{
		public static Program Run(List<Lexer.Token> tokens)
		{
			Program program = new();

			// Program
			// | function: Function (name: "main")
			// | | body: StatementReturn
			// | | | expression: LiteralInteger (value: 2)

			return program;
		}
	}
}
