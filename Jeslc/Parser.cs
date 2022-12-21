using static Jeslc.Parser;

namespace Jeslc
{
	public static partial class Parser
	{
		// <program>    ::= <function>
		// <function>   ::= "int" <identifier> "(" ")" "{" <statement "}"
		// <statement>  ::= "return" <expression> ";"
		// <expression> ::= <int>
		// <int>        ::= <digit> | <digit> <int>
		// <digit>      ::= "0" | "1" | "2" | "3" | "4" | "5" | "6" | "7" | "8" | "9"
		// <letter>     ::= "A" | "B" | "C" | "D" | "E" | "F" | "G" | "H" | "I" | "J" | "K" | "L" | "M" | "N" | "O"
		//                | "P" | "Q" | "R" | "S" | "T" | "U" | "V" | "W" | "X" | "Y" | "Z" | "a" | "b" | "c" | "d"
		//                | "e" | "f" | "g" | "h" | "i" | "j" | "k" | "l" | "m" | "n" | "o" | "p" | "q" | "r" | "s"
		//                | "t" | "u" | "v" | "w" | "x" | "y" | "z" | "_"

		public static Program Run(List<Lexer.Token> tokens)
		{
			Program program = new();
			if (tokens.Count <= 0) return program;

			// Program
			// | function: Function (name: "main")
			// | | body: StatementReturn
			// | | | expression: LiteralInteger (value: 2)

			for (int i = 0; i < tokens.Count; i++)
			{
				program.AddFunction(ParseFunction(tokens, ref i));
			}

			return program;
		}

		public static Function ParseFunction(in List<Lexer.Token> tokens, ref int i)
		{
			if (tokens[i].type != Lexer.TokenType.KeywordInt) Error($"Expected function return type, found \"{tokens[i].value}\" instead");

			i++;
			if (tokens[i].type != Lexer.TokenType.Identifier) Error($"Expected function identifier, found \"{tokens[i].value}\" instead");
			string? identifier = tokens[i].value;

			i++;
			if (tokens[i].type != Lexer.TokenType.OpenParenthesis) Error($"Expected \"(\", found \"{tokens[i].value}\" instead");

			i++;
			if (tokens[i].type != Lexer.TokenType.CloseParenthesis) Error($"Expected \")\", found \"{tokens[i].value}\" instead");

			i++;
			if (tokens[i].type != Lexer.TokenType.OpenBrace) Error($"Expected \"{"{"}\", found \"{tokens[i].value}\" instead");

			i++;
			Statement statement = ParseStatement(tokens, ref i);

			i++;
			if (tokens[i].type != Lexer.TokenType.CloseBrace) Error($"Expected \"{"}"}\", found \"{tokens[i].value}\" instead");

			return new Function(identifier, statement);
		}

		public static Statement ParseStatement(in List<Lexer.Token> tokens, ref int i)
		{
			Statement statement = new StatementReturn();

			if (tokens[i].type != Lexer.TokenType.KeywordReturn) Error($"Expected \"return\", found \"{tokens[i].value}\" instead");

			i++;
			Expression expression = ParseExpression(tokens, ref i);

			return new StatementReturn(expression);
		}

		public static Expression ParseExpression(in List<Lexer.Token> tokens, ref int i)
		{
			if (tokens[i].type != Lexer.TokenType.LiteralInteger) Error($"Expected Integer, found \"{tokens[i].value}\" instead");

			Int32 val = Int32.Parse(tokens[i].value);

			i++;
			if (tokens[i].type != Lexer.TokenType.Semicolon) Error($"Expected \";\", found \"{tokens[i].value}\" instead");

			return new LiteralInt(val);
		}

		private static void Error(string msg)
		{
			Console.Error.WriteLine("PARSER ERROR: " + msg);
			Environment.Exit(-1);
		}
	}
}
