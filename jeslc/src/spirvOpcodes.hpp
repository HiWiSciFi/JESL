// MISC

#define OpNop 0x0
#define OpUndef 0x1
#define OpSizeOf 0x141
#define OpAssumeTrueKHR 0x15FE
#define OpExpectKHR 0x15FF

// DEBUG

#define OpSourceContinued 0x2
#define OpSource 0x3
#define OpSourceExtension 0x4
#define OpName 0x5
#define OpMemberName 0x6
#define OpString 0x7
#define OpLine 0x8
#define OpNoLine 0x13D
#define OpModuleProcessed 0x14A

// ANNOTATION

#define OpDecorate 0x47
#define OpMemberDecorate 0x48
#define OpDecorationGroup 0x49
#define OpGroupDecorate 0x4A
#define OpGroupMemberDecorate 0x4B
#define OpDecorateId 0x14C
#define OpDecorateString 0x1600
#define OpMemberDecorateString 0x1601

// EXTENSION

#define OpExtension 0xA
#define OpExtInstImport 0xB
#define OpExtInst 0xC

// MODE SETTING

#define OpMemoryModel 0xE
#define OpEntryPoint 0xF
#define OpExecutionMode 0x10
#define OpCapability 0x11
#define OpExecutionModeId 0x14B

// TYPE DECLARATION

#define OpTypeVoid 0x13
#define OpTypeBool 0x14
#define OpTypeInt 0x15
#define OpTypeFloat 0x16
#define OpTypeVector 0x17
#define OpTypeMatrix 0x18
#define OpTypeImage 0x19
#define OpTypeSampler 0x1A
#define OpTypeSampledImage 0x1B
#define OpTypeArray 0x1C
#define OpTypeRuntimeArray 0x1D
#define OpTypeStruct 0x1E
#define OpTypeOpaque 0x1F
#define OpTypePointer 0x20
#define OpTypeFunction 0x21
#define OpTypeEvent 0x22
#define OpTypeDeviceEvent 0x23
#define OpTypeReserveId 0x24
#define OpTypeQueue 0x25
#define OpTypePipe 0x26
#define OpTypeForwardPointer 0x27
#define OpTypePipeStorage 0x142
#define OpTypeNamedBarrier 0x147
#define OpTypeBufferSurfaceINTEL 0x17C6
#define OpTypeStructContinuedINTEL 0x17CA

// CONSTANT CREATION

#define OpConstantTrue 0x29
#define OpConstantFalse 0x2A
#define OpConstant 0x2B
#define OpConstantComposite 0x2C
#define OpConstantSampler 0x2D
#define OpConstantNull 0x2E
#define OpSpecConstantTrue 0x30
#define OpSpecConstantFalse 0x31
#define OpSpecConstant 0x32
#define OpSpecConstantComposite 0x33
#define OpSpecConstantOp 0x34
#define OpConstantCompositeContinuedINTEL 0x17CB
#define OpSpecConstantCompositeContinuedINTEL 0x17CC

// MEMORY

#define OpVariable 0x3B
#define OpImageTexelPointer 0x3C
#define OpLoad 0x3D
#define OpStore 0x3E
#define OpCopyMemory 0x3F
#define OpCopyMemorySized 0x40
#define OpAccessChain 0x41
#define OpInBoundsAccessChain 0x42
#define OpPtrAccessChain 0x43
#define OpArrayLength 0x44
#define OpGenericPtrMemSemantics 0x45
#define OpInBoundsPtrAccessChain 0x46
#define OpPtrEqual 0x191
#define OpPtrNotEqual 0x192
#define OpPtrDiff 0x193

// FUNCTION

#define OpFunction 0x36
#define OpFunctionParameter 0x37
#define OpFunctionEnd 0x38
#define OpFunctionCall 0x39

// IMAGE

#define OpSampledImage 0x56
#define OpImageSampleImplicitLod 0x57
#define OpImageSampleExplicitLod 0x58
#define OpImageSampleDrefImplicitLod 0x59
#define OpImageSampleDrefExplicitLod 0x5A
#define OpImageSampleProjImplicitLod 0x5B
#define OpImageSampleProjExplicitLod 0x5C
#define OpImageSampleProjDrefImplicitLod 0x5D
#define OpImageSampleProjDrefExplicitLod 0x5E
#define OpImageFetch 0x5F
#define OpImageGather 0x60
#define OpImageDrefGather
