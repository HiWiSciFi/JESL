namespace Jeslc
{
	public static class Generator
	{
		private static readonly byte[] zeroWord = { 0, 0, 0, 0 };

		public static void WriteWord(Enum value, FileStream s) => WriteWord(Convert.ToUInt32(value), s);

		public static void WriteWord(UInt32 value, FileStream s)
		{
			s.WriteByte((byte)(value & 0x000000FF));
			s.WriteByte((byte)((value & 0x0000FF00) >> 8));
			s.WriteByte((byte)((value & 0x00FF0000) >> 16));
			s.WriteByte((byte)((value & 0xFF000000) >> 24));
		}


		public static void WriteInstruction(UInt16 operandsLength, UInt16 opcode, FileStream s)
		{
			operandsLength += 1;
			s.WriteByte((byte)( opcode         & 0x00FF)      );
			s.WriteByte((byte)((opcode         & 0xFF00) >> 8));
			s.WriteByte((byte)( operandsLength & 0x00FF)      );
			s.WriteByte((byte)((operandsLength & 0xFF00) >> 8));
		}

		public static void WriteString(String value, FileStream s)
		{
			byte[] buffer = System.Text.Encoding.UTF8.GetBytes(value);
			s.Write(buffer, 0, buffer.Length);
			if (buffer.Length % 4 != 0) for (int i = 0; i < 4 - (buffer.Length % 4); i++) s.WriteByte(0);
			s.Write(zeroWord, 0, zeroWord.Length);
		}

		public static void WriteHeader(UInt32 bound, FileStream s)
		{
			WriteWord(SPIRV.Magic, s); // Magic Number
			WriteWord(0x00010000, s);  // SPIRV Version 1.0
			WriteWord(0, s);           // Generator
			WriteWord(bound, s);       // bound
			WriteWord(0, s);           // Schema

			WriteInstruction(1, SPIRV.OpCapability, s);
			WriteWord(SPIRV.Capability.Shader, s);
		}

		public static void Run(Parser.Program program, FileStream s)
		{
			WriteHeader(0, s);
		}
	}
}
