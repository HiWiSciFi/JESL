namespace Jeslc
{
	public static partial class Lexer
	{
		public static List<Token> Run(string[] inputProgram)
		{
			List<Token> tokens = new();
			for (int lineNr = 0; lineNr < inputProgram.Length; lineNr++)
			{
				string currToken = string.Empty;
				for (int i = 0; i < inputProgram[lineNr].Length; i++)
				{
					char c = inputProgram[lineNr][i];
					// identifier / literal / keyword
					if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
					{
						currToken += c;
					}
					// standalone characters
					else if (c == '{' || c == '}' || c == '(' || c == ')' || c == ';')
					{
						if (currToken != string.Empty)
						{
							tokens.Add(new Token(currToken));
							currToken = string.Empty;
						}
						tokens.Add(new Token(c.ToString()));
					}
					// whitespace
					else if (c == ' ' || c == '\t' || c == '\r' || c == '\n' || c == '\v' || c == '\f')
					{
						if (currToken != string.Empty) tokens.Add(new Token(currToken));
						currToken = string.Empty;
					}
				}
			}
			return tokens;
		}
	}
}
