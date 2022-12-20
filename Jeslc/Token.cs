namespace Jeslc
{
	public static partial class Lexer
	{
		public enum TokenType
		{
			None,

			OpenBrace,
			CloseBrace,
			OpenParenthesis,
			CloseParenthesis,
			Semicolon,

			Identifier,

			// Literals
			LiteralInteger,

			// Keywords
			KeywordInt,
			KeywordReturn
		}

		public struct Token
		{
			public TokenType type = TokenType.None;
			public string? value = null;

			public Token()
			{ }

			public Token(string value)
			{
				this.value = value;
				this.type = DetermineType();
			}

			public Token(TokenType type, string value)
			{
				this.type = type;
				this.value = value;
			}

			public TokenType DetermineType()
			{
				if (value is null || value.Length == 0) return TokenType.None;

				if (value.Length == 1)
				{
					switch (value[0])
					{
						case '(': return TokenType.OpenParenthesis;
						case ')': return TokenType.CloseParenthesis;
						case '{': return TokenType.OpenBrace;
						case '}': return TokenType.CloseBrace;
						case ';': return TokenType.Semicolon;
						default: break;
					}
				}

				switch (value)
				{
					case "return": return TokenType.KeywordReturn;
					case "int": return TokenType.KeywordInt;
					default: break;
				}

				TokenType determinedType = TokenType.None;

				for (int i = 0; i < value.Length; i++)
				{
					char c = value[i];
					if (c >= '0' && c <= '9')
					{
						if (determinedType == TokenType.None) determinedType = TokenType.LiteralInteger;
					}
					else if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
					{
						if (determinedType != TokenType.Identifier) determinedType = TokenType.Identifier;
					}
				}

				return determinedType;
			}
		}
	}
}
