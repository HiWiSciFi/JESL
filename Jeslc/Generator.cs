namespace Jeslc
{
	public static class Generator
	{
		private static FileStream? s = null;

		private static readonly byte[] zeroWord = { 0, 0, 0, 0 };

		public static void WriteWord(Enum value) => WriteWord(Convert.ToUInt32(value));

		public static void WriteWord(UInt32 value)
		{
			s?.WriteByte((byte)(value & 0x000000FF));
			s?.WriteByte((byte)((value & 0x0000FF00) >> 8));
			s?.WriteByte((byte)((value & 0x00FF0000) >> 16));
			s?.WriteByte((byte)((value & 0xFF000000) >> 24));
		}

		public static void WriteInstruction(UInt16 opcode, params object[] list)
		{
			s?.WriteByte((byte)( opcode & 0x00FF)      );
			s?.WriteByte((byte)((opcode & 0xFF00) >> 8));

			UInt32 words = 1;
			for (int i = 0; i < list.Length; i++)
			{
				if (list[i] is string str) words += (UInt32)(str.Length + (str.Length % 4 == 0 ? 0 : 4 - (str.Length % 4)) + 1);
				else words++;
			}

			s?.WriteByte((byte)( words & 0x00FF)      );
			s?.WriteByte((byte)((words & 0xFF00) >> 8));

			for (int i = 0; i < list.Length; i++)
			{
				switch (list[i])
				{
					case UInt32 val: WriteWord(val);                   break;
					case Enum   val: WriteWord(Convert.ToUInt32(val)); break;
					case string val: WriteString(val);                 break;
					default: break;
				}
			}
		}

		public static void WriteString(String value)
		{
			byte[] buffer = System.Text.Encoding.UTF8.GetBytes(value);
			s?.Write(buffer, 0, buffer.Length);
			if (buffer.Length % 4 != 0) for (int i = 0; i < 4 - (buffer.Length % 4); i++) s?.WriteByte(0);
			s?.Write(zeroWord, 0, zeroWord.Length);
		}

		public static void Run(Parser.Program program, FileStream stream)
		{
			s = stream;

			UInt32 bound = 0;

			WriteWord(SPIRV.Magic); // Magic Number
			WriteWord(0x00010000);  // SPIRV Version 1.0
			WriteWord(0);           // Generator
			WriteWord(bound);       // bound
			WriteWord(0);           // Schema

			// OpCapability Instructions
			WriteInstruction(
				SPIRV.OpCapability,
				SPIRV.Capability.Shader);

			// OpExtension Instructions

			// OpEXtInstImport Instructions
			WriteInstruction(
				SPIRV.OpExtInstImport,
				"GLSL.std.450");

			// OpMemoryModel Instruction
			WriteInstruction(
				SPIRV.OpMemoryModel,
				SPIRV.AddressingModel.Logical,
				SPIRV.MemoryModel.GLSL450);

			// OpEntryPoint Instructions

			// OpExecutionMode | OpExecutionModeId Instructions

			// ------- DEBUG --------

			// OpString | OpSourceExtension | OpSource | OpSourceContinued | Instructions

			// OpName | OpMemberName Instructions

			// OpModuleProcessed Instructions

			// ------- END ----------

			// Annotation / Decoration Instructions

			// OpTypeXXX Instructions

			//
		}
	}
}
