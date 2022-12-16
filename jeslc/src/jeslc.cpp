#include "jeslc.hpp"

#include <iostream>
#include <vector>

#include "SPIRV/Instructions.hpp"
#include "SPIRV/Values.hpp"

static uint32_t GenOpPrefix(uint16_t wordCount, uint16_t enumerant)
{
	uint32_t toRt = 0;
	toRt |= wordCount;
	toRt <<= 16;
	toRt |= enumerant;
	return toRt;
}

static void PushString(std::vector<uint32_t>& program, const char* str)
{
	uint32_t currStr = 0;
	for (size_t i = 0; i < strlen(str); i++)
	{
		currStr |= str[i];
		currStr <<= 8;
		if (i != 0 && i % 4 == 0)
		{
			program.push_back(currStr);
			currStr = 0;
		}
	}
}

int main(int argc, char** argv)
{
	uint32_t programc[] = {
		MagicNumber, // Magic
		0x00010000,  // Version 1.0 : 0 | Major Number | Minor Number | 0
		0x00000000,  // Generators magic (may be 0)
		63,          // Bound where all <id>s in this module satisfy: 0 < id < Bound
		0,           // Reserved for instruction schema

		OpCapability, Capability_Shader,
		GenOpPrefix(6, 1), OpExtInstImport, 0x0,
		OpMemoryModel, AddressingModel_Logical, MemoryModel_GLSL450,
		OpEntryPoint, ExecutionModel_Fragment, 4, 0x0, 31, 33, 42, 57,
		OpExecutionMode, 4, ExecutionMode_OriginLowerLeft
	};

	std::vector<uint32_t> program{ };
	program.push_back(MagicNumber);
	program.push_back(0x00010000);
	program.push_back(63);
	program.push_back(0);
	program.push_back(OpCapability);
	program.push_back(Capability_Shader);
	program.push_back(GenOpPrefix(6, 1));
	program.push_back(OpExtInstImport);
	PushString(program, "GLSL.std.450");

	return 0;
}
