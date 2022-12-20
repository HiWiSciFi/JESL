namespace JeslcTests
{
	[TestClass]
	public class LexerTests
	{
		[TestMethod]
		public void Empty()
		{
			string[] input = Array.Empty<string>();
			List<Jeslc.Lexer.Token> result = Jeslc.Lexer.Run(input);
			Assert.IsTrue(result.Count == 0);
		}

		[TestMethod]
		public void SimpleFunction()
		{
			string[] input =
			{
				"int main() {",
				"\treturn 0;",
				"}"
			};
			List<Jeslc.Lexer.Token> result = Jeslc.Lexer.Run(input);
			for (int i = 0; i < result.Count; i++)
			{
				Console.Write(result[i].type.ToString());
				Console.Write(" : ");
				Console.WriteLine(result[i].value);
			}
			Assert.IsTrue(result.Count == 0);
		}
	}
}
