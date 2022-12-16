#include "jeslc.hpp"

#include <iostream>

#include "SPIRV/Instructions.hpp"
#include "SPIRV/Values.hpp"

int main(int argc, char** argv)
{
	uint32_t program[] = {
		MagicNumber, 0x00010000, 0x00000000, 63, 0,
		OpCapability, 1 /*Capability_Shader*/,
		1, OpExtInstImport, 0x0,
		OpMemoryModel, AddressingModel_Logical, MemoryModel_GLSL450,
		OpEntryPoint, ExecutionModel_Fragment, 4, 0x0, 31, 33, 42, 57,
		OpExecutionMode, 4, ExecutionMode_OriginLowerLeft
	};

	return 0;
}
