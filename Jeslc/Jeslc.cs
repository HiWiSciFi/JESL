namespace Jeslc
{
	internal class Jeslc
	{
		const string VERSION = "1.0.0";

		static void PrintUsage(in TextWriter writer)
		{
			writer.WriteLine("Usage: jeslc [--version] [-o <file> | --output <file>] <infile>");
		}

		static void Main(string[] args)
		{
			if (args.Length <= 0)
			{
				Console.Error.WriteLine("ERROR: Please specify an input file!");
				PrintUsage(Console.Error);
				Environment.Exit(-1);
			}

			bool versionPrinted = false;
			string? outputFilePath = null;
			string? inputFilePath = null;

			for (int i = 0; i < args.Length; i++)
			{
				switch(args[i])
				{
				case "-?":
				case "--help":
					PrintUsage(Console.Out);
					Console.WriteLine();
					Console.WriteLine("<infile> is the file to compile");
					Console.WriteLine();
					Console.WriteLine("options:");
					Console.WriteLine("  -?");
					Console.WriteLine("  --help           show this help message");
					Console.WriteLine();
					Console.WriteLine($"  --version        print jeslc version (\"{VERSION}\")");
					Console.WriteLine();
					Console.WriteLine("  -o <file>");
					Console.WriteLine("  --output <file>  output to file <file>");
					Environment.Exit(0);
					break;
				case "--version":
					if (versionPrinted)
					{
						Console.WriteLine($"WARN: Ignoring redundant parameter: {args[i]}");
						continue;
					}
					Console.WriteLine($"INFO: jeslc version {VERSION}");
					versionPrinted = true;
					break;

				case "-o":
				case "--output":
					if (i + 1 >= args.Length)
					{
						Console.Error.WriteLine($"ERROR: Missing file parameter for {args[i]} flag.");
						PrintUsage(Console.Error);
						Environment.Exit(-1);
					}
					if (outputFilePath != null)
					{
						Console.WriteLine($"WARN: Ignoring redundant parameter: {args[i]} {args[i + 1]}");
						i++;
						continue;
					}
					outputFilePath = args[i + 1];
					i++;
					break;

				default:
					if (inputFilePath != null)
					{
						Console.Error.WriteLine("ERROR: Only one input file allowed");
						Console.Error.WriteLine($"Tried adding {args[i]} after {inputFilePath} had already been added!");
						PrintUsage(Console.Error);
						Environment.Exit(-1);
					}
					inputFilePath = args[i];
					break;
				}
			}

			if (inputFilePath is null)
			{
				Console.Error.WriteLine("ERROR: No input file specified");
				PrintUsage(Console.Error);
				Environment.Exit(-1);
			}

			if (outputFilePath is null)
			{
				int dotIndex = inputFilePath.LastIndexOf('.');
				if (dotIndex == -1) outputFilePath = inputFilePath + ".spv";
				else outputFilePath = inputFilePath[..dotIndex] + ".spv";
				Console.WriteLine($"INFO: Output file not specified... Defaulting to \"{outputFilePath}\"");
			}

			if (!File.Exists(inputFilePath))
			{
				Console.Error.WriteLine($"Could not open file at \"{inputFilePath}\"");
				Environment.Exit(-1);
			}

			string[] inputCode = File.ReadAllLines(inputFilePath, System.Text.Encoding.ASCII);
			List<Lexer.Token> codeTokens = Lexer.Run(inputCode);
			Parser.Program ast = Parser.Run(codeTokens);

   // ------------------------------------------------------------------------------------------------------------------
			for (int i = 0; i < codeTokens.Count; i++)
			{
				Console.Write(codeTokens[i].type.ToString());
				Console.CursorLeft = 17;
				Console.Write(": ");
				Console.WriteLine(codeTokens[i].value);
			}
   // ------------------------------------------------------------------------------------------------------------------

			FileStream outStream = File.OpenWrite(outputFilePath);

			outStream.WriteByte(0);
			outStream.WriteByte(1);
			outStream.WriteByte(0);
			outStream.WriteByte(1);

			Generator.Run(ast, outStream);

			outStream.Flush();
			outStream.Close();
			outStream.Dispose();
		}
	}
}
