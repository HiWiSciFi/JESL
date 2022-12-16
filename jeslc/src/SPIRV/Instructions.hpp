#include <cinttypes>

// MISC

constexpr uint32_t OpNop                                                   = 0x0000;
constexpr uint32_t OpUndef                                                 = 0x0001;
constexpr uint32_t OpSizeOf                                                = 0x0141;
constexpr uint32_t OpAssumeTrueKHR                                         = 0x15FE;
constexpr uint32_t OpExpectKHR                                             = 0x15FF;

// DEBUG

constexpr uint32_t OpSourceContinued                                       = 0x0002;
constexpr uint32_t OpSource                                                = 0x0003;
constexpr uint32_t OpSourceExtension                                       = 0x0004;
constexpr uint32_t OpName                                                  = 0x0005;
constexpr uint32_t OpMemberName                                            = 0x0006;
constexpr uint32_t OpString                                                = 0x0007;
constexpr uint32_t OpLine                                                  = 0x0008;
constexpr uint32_t OpNoLine                                                = 0x013D;
constexpr uint32_t OpModuleProcessed                                       = 0x014A;

// ANNOTATION

constexpr uint32_t OpDecorate                                              = 0x0047;
constexpr uint32_t OpMemberDecorate                                        = 0x0048;
constexpr uint32_t OpDecorationGroup                                       = 0x0049;
constexpr uint32_t OpGroupDecorate                                         = 0x004A;
constexpr uint32_t OpGroupMemberDecorate                                   = 0x004B;
constexpr uint32_t OpDecorateId                                            = 0x014C;
constexpr uint32_t OpDecorateString                                        = 0x1600;
constexpr uint32_t OpDecorateStringGOOGLE                                  = 0x1600;
constexpr uint32_t OpMemberDecorateString                                  = 0x1601;
constexpr uint32_t OpMemberDecorateStringGOOGLE                            = 0x1601;

// EXTENSION

constexpr uint32_t OpExtension                                             = 0x000A;
constexpr uint32_t OpExtInstImport                                         = 0x000B;
constexpr uint32_t OpExtInst                                               = 0x000C;

// MODE SETTING

constexpr uint32_t OpMemoryModel                                           = 0x000E;
constexpr uint32_t OpEntryPoint                                            = 0x000F;
constexpr uint32_t OpExecutionMode                                         = 0x0010;
constexpr uint32_t OpCapability                                            = 0x0011;
constexpr uint32_t OpExecutionModeId                                       = 0x014B;

// TYPE DECLARATION

constexpr uint32_t OpTypeVoid                                              = 0x0013;
constexpr uint32_t OpTypeBool                                              = 0x0014;
constexpr uint32_t OpTypeInt                                               = 0x0015;
constexpr uint32_t OpTypeFloat                                             = 0x0016;
constexpr uint32_t OpTypeVector                                            = 0x0017;
constexpr uint32_t OpTypeMatrix                                            = 0x0018;
constexpr uint32_t OpTypeImage                                             = 0x0019;
constexpr uint32_t OpTypeSampler                                           = 0x001A;
constexpr uint32_t OpTypeSampledImage                                      = 0x001B;
constexpr uint32_t OpTypeArray                                             = 0x001C;
constexpr uint32_t OpTypeRuntimeArray                                      = 0x001D;
constexpr uint32_t OpTypeStruct                                            = 0x001E;
constexpr uint32_t OpTypeOpaque                                            = 0x001F;
constexpr uint32_t OpTypePointer                                           = 0x0020;
constexpr uint32_t OpTypeFunction                                          = 0x0021;
constexpr uint32_t OpTypeEvent                                             = 0x0022;
constexpr uint32_t OpTypeDeviceEvent                                       = 0x0023;
constexpr uint32_t OpTypeReserveId                                         = 0x0024;
constexpr uint32_t OpTypeQueue                                             = 0x0025;
constexpr uint32_t OpTypePipe                                              = 0x0026;
constexpr uint32_t OpTypeForwardPointer                                    = 0x0027;
constexpr uint32_t OpTypePipeStorage                                       = 0x0142;
constexpr uint32_t OpTypeNamedBarrier                                      = 0x0147;
constexpr uint32_t OpTypeBufferSurfaceINTEL                                = 0x17C6;
constexpr uint32_t OpTypeStructContinuedINTEL                              = 0x17CA;

// CONSTANT CREATION

constexpr uint32_t OpConstantTrue                                          = 0x0029;
constexpr uint32_t OpConstantFalse                                         = 0x002A;
constexpr uint32_t OpConstant                                              = 0x002B;
constexpr uint32_t OpConstantComposite                                     = 0x002C;
constexpr uint32_t OpConstantSampler                                       = 0x002D;
constexpr uint32_t OpConstantNull                                          = 0x002E;
constexpr uint32_t OpSpecConstantTrue                                      = 0x0030;
constexpr uint32_t OpSpecConstantFalse                                     = 0x0031;
constexpr uint32_t OpSpecConstant                                          = 0x0032;
constexpr uint32_t OpSpecConstantComposite                                 = 0x0033;
constexpr uint32_t OpSpecConstantOp                                        = 0x0034;
constexpr uint32_t OpConstantCompositeContinuedINTEL                       = 0x17CB;
constexpr uint32_t OpSpecConstantCompositeContinuedINTEL                   = 0x17CC;

// MEMORY

constexpr uint32_t OpVariable                                              = 0x003B;
constexpr uint32_t OpImageTexelPointer                                     = 0x003C;
constexpr uint32_t OpLoad                                                  = 0x003D;
constexpr uint32_t OpStore                                                 = 0x003E;
constexpr uint32_t OpCopyMemory                                            = 0x003F;
constexpr uint32_t OpCopyMemorySized                                       = 0x0040;
constexpr uint32_t OpAccessChain                                           = 0x0041;
constexpr uint32_t OpInBoundsAccessChain                                   = 0x0042;
constexpr uint32_t OpPtrAccessChain                                        = 0x0043;
constexpr uint32_t OpArrayLength                                           = 0x0044;
constexpr uint32_t OpGenericPtrMemSemantics                                = 0x0045;
constexpr uint32_t OpInBoundsPtrAccessChain                                = 0x0046;
constexpr uint32_t OpPtrEqual                                              = 0x0191;
constexpr uint32_t OpPtrNotEqual                                           = 0x0192;
constexpr uint32_t OpPtrDiff                                               = 0x0193;

// FUNCTION

constexpr uint32_t OpFunction                                              = 0x0036;
constexpr uint32_t OpFunctionParameter                                     = 0x0037;
constexpr uint32_t OpFunctionEnd                                           = 0x0038;
constexpr uint32_t OpFunctionCall                                          = 0x0039;

// IMAGE

constexpr uint32_t OpSampledImage                                          = 0x0056;
constexpr uint32_t OpImageSampleImplicitLod                                = 0x0057;
constexpr uint32_t OpImageSampleExplicitLod                                = 0x0058;
constexpr uint32_t OpImageSampleDrefImplicitLod                            = 0x0059;
constexpr uint32_t OpImageSampleDrefExplicitLod                            = 0x005A;
constexpr uint32_t OpImageSampleProjImplicitLod                            = 0x005B;
constexpr uint32_t OpImageSampleProjExplicitLod                            = 0x005C;
constexpr uint32_t OpImageSampleProjDrefImplicitLod                        = 0x005D;
constexpr uint32_t OpImageSampleProjDrefExplicitLod                        = 0x005E;
constexpr uint32_t OpImageFetch                                            = 0x005F;
constexpr uint32_t OpImageGather                                           = 0x0060;
constexpr uint32_t OpImageDrefGather                                       = 0x0061;
constexpr uint32_t OpImageRead                                             = 0x0062;
constexpr uint32_t OpImageWrite                                            = 0x0063;
constexpr uint32_t OpImage                                                 = 0x0064;
constexpr uint32_t OpImageQueryFormat                                      = 0x0065;
constexpr uint32_t OpImageQueryOrder                                       = 0x0066;
constexpr uint32_t OpImageQuerySizeLod                                     = 0x0067;
constexpr uint32_t OpImageQuerySize                                        = 0x0068;
constexpr uint32_t OpImageQueryLod                                         = 0x0069;
constexpr uint32_t OpImageQueryLevels                                      = 0x006A;
constexpr uint32_t OpImageQuerySamples                                     = 0x006B;
constexpr uint32_t OpImageSparseSampleImplicitLod                          = 0x0131;
constexpr uint32_t OpImageSparseSampleExplicitLod                          = 0x0132;
constexpr uint32_t OpImageSparseSampleDrefImplicitLod                      = 0x0133;
constexpr uint32_t OpImageSparseSampleDrefExplicitLod                      = 0x0134;
constexpr uint32_t OpImageSparseSampleProjImplicitLod                      = 0x0135;
constexpr uint32_t OpImageSparseSampleProjExplicitLod                      = 0x0136;
constexpr uint32_t OpImageSparseSampleProjDrefImplicitLod                  = 0x0137;
constexpr uint32_t OpImageSparseSampleProjDrefExplicitLod                  = 0x0138;
constexpr uint32_t OpImageSparseFetch                                      = 0x0139;
constexpr uint32_t OpImageSparseGather                                     = 0x013A;
constexpr uint32_t OpImageSparseDrefGather                                 = 0x013B;
constexpr uint32_t OpImageSparseTexelsResident                             = 0x013C;
constexpr uint32_t OpImageSparseRead                                       = 0x0140;
constexpr uint32_t OpImageSampleFootprintNV                                = 0x14A3;

// CONVERSION

constexpr uint32_t OpConvertFToU                                           = 0x006D;
constexpr uint32_t OpConvertFToS                                           = 0x006E;
constexpr uint32_t OpConvertSToF                                           = 0x006F;
constexpr uint32_t OpConvertUToF                                           = 0x0070;
constexpr uint32_t OpUConvert                                              = 0x0071;
constexpr uint32_t OpSConvert                                              = 0x0072;
constexpr uint32_t OpFConvert                                              = 0x0073;
constexpr uint32_t OpQuantizeToF16                                         = 0x0074;
constexpr uint32_t OpConvertPtrToU                                         = 0x0075;
constexpr uint32_t OpSatConvertSToU                                        = 0x0076;
constexpr uint32_t OpSatConvertUToS                                        = 0x0077;
constexpr uint32_t OpConvertUToPtr                                         = 0x0078;
constexpr uint32_t OpPtrCastToGeneric                                      = 0x0079;
constexpr uint32_t OpGenericCastToPtr                                      = 0x007A;
constexpr uint32_t OpGenericCastToPtrExplicit                              = 0x007B;
constexpr uint32_t OpBitcast                                               = 0x007C;

// COMPOSITE

constexpr uint32_t OpVectorExtractDynamic                                  = 0x004D;
constexpr uint32_t OpVectorInsertDynamic                                   = 0x004E;
constexpr uint32_t OpVectorShuffle                                         = 0x004F;
constexpr uint32_t OpCompositeConstruct                                    = 0x0050;
constexpr uint32_t OpCompositeExtract                                      = 0x0051;
constexpr uint32_t OpCompositeInsert                                       = 0x0052;
constexpr uint32_t OpCopyObject                                            = 0x0053;
constexpr uint32_t OpTranspose                                             = 0x0054;
constexpr uint32_t OpCopyLogical                                           = 0x0190;

// ARITHMETIC

constexpr uint32_t OpSNegate                                               = 0x007E;
constexpr uint32_t OpFNegate                                               = 0x007F;
constexpr uint32_t OpIAdd                                                  = 0x0080;
constexpr uint32_t OpFAdd                                                  = 0x0081;
constexpr uint32_t OpISub                                                  = 0x0082;
constexpr uint32_t OpFSub                                                  = 0x0083;
constexpr uint32_t OpIMul                                                  = 0x0084;
constexpr uint32_t OpFMul                                                  = 0x0085;
constexpr uint32_t OpUDiv                                                  = 0x0086;
constexpr uint32_t OpSDiv                                                  = 0x0087;
constexpr uint32_t OpFDiv                                                  = 0x0088;
constexpr uint32_t OpUMod                                                  = 0x0089;
constexpr uint32_t OpSRem                                                  = 0x008A;
constexpr uint32_t OpSMod                                                  = 0x008B;
constexpr uint32_t OpFRem                                                  = 0x008C;
constexpr uint32_t OpFMod                                                  = 0x008D;
constexpr uint32_t OpVectorTimesScalar                                     = 0x008E;
constexpr uint32_t OpMatrixTimesScalar                                     = 0x008F;
constexpr uint32_t OpVectorTimesMatrix                                     = 0x0090;
constexpr uint32_t OpMatrixTimesVector                                     = 0x0091;
constexpr uint32_t OpMatrixTimesMatrix                                     = 0x0092;
constexpr uint32_t OpOuterProduct                                          = 0x0093;
constexpr uint32_t OpDot                                                   = 0x0094;
constexpr uint32_t OpIAddCarry                                             = 0x0095;
constexpr uint32_t OpISubBorrow                                            = 0x0096;
constexpr uint32_t OpUMulExtended                                          = 0x0097;
constexpr uint32_t OpSMulExtended                                          = 0x0098;
constexpr uint32_t OpSDot                                                  = 0x1162;
constexpr uint32_t OpSDotKHR                                               = 0x1162;
constexpr uint32_t OpUDot                                                  = 0x1163;
constexpr uint32_t OpUDotKHR                                               = 0x1163;
constexpr uint32_t OpSUDot                                                 = 0x1164;
constexpr uint32_t OpSUDotKHR                                              = 0x1164;
constexpr uint32_t OpSDotAccSat                                            = 0x1165;
constexpr uint32_t OpSDotAccSatKHR                                         = 0x1165;
constexpr uint32_t OpUDotAccSat                                            = 0x1166;
constexpr uint32_t OpUDotAccSatKHR                                         = 0x1166;
constexpr uint32_t OpSUDotAccSat                                           = 0x1167;
constexpr uint32_t OpSUDotAccSatKHR                                        = 0x1167;

// BIT

constexpr uint32_t OpShiftRightLogical                                     = 0x00C2;
constexpr uint32_t OpShiftRightArithmetic                                  = 0x00C3;
constexpr uint32_t OpShiftLeftLogical                                      = 0x00C4;
constexpr uint32_t OpBitwiseOr                                             = 0x00C5;
constexpr uint32_t OpBitwiseXor                                            = 0x00C6;
constexpr uint32_t OpBitwiseAnd                                            = 0x00C7;
constexpr uint32_t OpNot                                                   = 0x00C8;
constexpr uint32_t OpBitFieldInsert                                        = 0x00C9;
constexpr uint32_t OpBitFieldSExtract                                      = 0x00CA;
constexpr uint32_t OpBitFieldUExtract                                      = 0x00CB;
constexpr uint32_t OpBitReverse                                            = 0x00CC;
constexpr uint32_t OpBitCount                                              = 0x00CD;

// RELATIONAL AND LOGICAL

constexpr uint32_t OpAny                                                   = 0x009A;
constexpr uint32_t OpAll                                                   = 0x009B;
constexpr uint32_t OpIsNan                                                 = 0x009C;
constexpr uint32_t OpIsInf                                                 = 0x009D;
constexpr uint32_t OpIsFinite                                              = 0x009E;
constexpr uint32_t OpIsNormal                                              = 0x009F;
constexpr uint32_t OpSignBitSet                                            = 0x00A0;
constexpr uint32_t OpLessOrGreater                                         = 0x00A1;
constexpr uint32_t OpOrdered                                               = 0x00A2;
constexpr uint32_t OpUnordered                                             = 0x00A3;
constexpr uint32_t OpLogicalEqual                                          = 0x00A4;
constexpr uint32_t OpLogicalNotEqual                                       = 0x00A5;
constexpr uint32_t OpLogicalOr                                             = 0x00A6;
constexpr uint32_t OpLogicalAnd                                            = 0x00A7;
constexpr uint32_t OpLogicalNot                                            = 0x00A8;
constexpr uint32_t OpSelect                                                = 0x00A9;
constexpr uint32_t OpIEqual                                                = 0x00AA;
constexpr uint32_t OpINotEqual                                             = 0x00AB;
constexpr uint32_t OpUGreaterThan                                          = 0x00AC;
constexpr uint32_t OpSGreaterThan                                          = 0x00AD;
constexpr uint32_t OpUGreaterThanEqual                                     = 0x00AE;
constexpr uint32_t OpSGreaterThanEqual                                     = 0x00AF;
constexpr uint32_t OpULessThan                                             = 0x00B0;
constexpr uint32_t OpSLessThan                                             = 0x00B1;
constexpr uint32_t OpULessThanEqual                                        = 0x00B2;
constexpr uint32_t OpSLessThanEqual                                        = 0x00B3;
constexpr uint32_t OpFOrdEqual                                             = 0x00B4;
constexpr uint32_t OpFUnordEqual                                           = 0x00B5;
constexpr uint32_t OpFOrdNotEqual                                          = 0x00B6;
constexpr uint32_t OpFUnordNotEqual                                        = 0x00B7;
constexpr uint32_t OpFOrdLessThan                                          = 0x00B8;
constexpr uint32_t OpFUnordLessThan                                        = 0x00B9;
constexpr uint32_t OpFOrdGreaterThan                                       = 0x00BA;
constexpr uint32_t OpFUnordGreaterThan                                     = 0x00BB;
constexpr uint32_t OpFOrdLessThanEqual                                     = 0x00BC;
constexpr uint32_t OpFUnordLessThanEqual                                   = 0x00BD;
constexpr uint32_t OpFOrdGreaterThanEqual                                  = 0x00BE;
constexpr uint32_t OpFUnordGreaterThanEqual                                = 0x00BF;

// DERIVATIVE

constexpr uint32_t OpDPdx                                                  = 0x00CF;
constexpr uint32_t OpDPdy                                                  = 0x00D0;
constexpr uint32_t OpFwidth                                                = 0x00D1;
constexpr uint32_t OpDPdxFine                                              = 0x00D2;
constexpr uint32_t OpDPdyFine                                              = 0x00D3;
constexpr uint32_t OpFwidthFine                                            = 0x00D4;
constexpr uint32_t OpDPdxCoarse                                            = 0x00D5;
constexpr uint32_t OpDPdyCoarse                                            = 0x00D6;
constexpr uint32_t OpFwidthCoarse                                          = 0x00D7;

// CONTROL FLOW

constexpr uint32_t OpPhi                                                   = 0x00F5;
constexpr uint32_t OpLoopMerge                                             = 0x00F6;
constexpr uint32_t OpSelectionMerge                                        = 0x00F7;
constexpr uint32_t OpLabel                                                 = 0x00F8;
constexpr uint32_t OpBranch                                                = 0x00F9;
constexpr uint32_t OpBranchConditional                                     = 0x00FA;
constexpr uint32_t OpSwitch                                                = 0x00FB;
constexpr uint32_t OpKill                                                  = 0x00FC;
constexpr uint32_t OpReturn                                                = 0x00FD;
constexpr uint32_t OpReturnValue                                           = 0x00FE;
constexpr uint32_t OpUnreachable                                           = 0x00FF;
constexpr uint32_t OpLifetimeStart                                         = 0x0100;
constexpr uint32_t OpLifetimeStop                                          = 0x0101;
constexpr uint32_t OpTerminateInvocation                                   = 0x1140;
constexpr uint32_t OpDemoteToHelperInvocation                              = 0x1504;
constexpr uint32_t OpDemoteToHelperInvocationEXT                           = 0x1504;

// ATOMIC

constexpr uint32_t OpAtomicLoad                                            = 0x00E3;
constexpr uint32_t OpAtomicStore                                           = 0x00E4;
constexpr uint32_t OpAtomicExchange                                        = 0x00E5;
constexpr uint32_t OpAtomicCompareExchange                                 = 0x00E6;
constexpr uint32_t OpAtomicCompareExchangeWeak                             = 0x00E7;
constexpr uint32_t OpAtomicIIncrement                                      = 0x00E8;
constexpr uint32_t OpAtomicIDecrement                                      = 0x00E9;
constexpr uint32_t OpAtomicIAdd                                            = 0x00EA;
constexpr uint32_t OpAtomicISub                                            = 0x00EB;
constexpr uint32_t OpAtomicSMin                                            = 0x00EC;
constexpr uint32_t OpAtomicUMin                                            = 0x00ED;
constexpr uint32_t OpAtomicSMax                                            = 0x00EE;
constexpr uint32_t OpAtomicUMax                                            = 0x00EF;
constexpr uint32_t OpAtomicAnd                                             = 0x00F0;
constexpr uint32_t OpAtomicOr                                              = 0x00F1;
constexpr uint32_t OpAtomicXor                                             = 0x00F2;
constexpr uint32_t OpAtomicFlagTestAndSet                                  = 0x013E;
constexpr uint32_t OpAtomicFlagClear                                       = 0x013F;
constexpr uint32_t OpAtomicFMinEXT                                         = 0x15EE;
constexpr uint32_t OpAtomicFMaxEXT                                         = 0x15EF;
constexpr uint32_t OpAtomicFAddEXT                                         = 0x1793;

// PRIMITIVE

constexpr uint32_t OpEmitVertex                                            = 0x00DA;
constexpr uint32_t OpEndPrimitive                                          = 0x00DB;
constexpr uint32_t OpEmitStreamVertex                                      = 0x00DC;
constexpr uint32_t OpEndStreamPrimitive                                    = 0x00DD;

// Barrier

constexpr uint32_t OpControlBarrier                                        = 0x00E0;
constexpr uint32_t OpMemoryBarrier                                         = 0x00E1;
constexpr uint32_t OpNamedBarrierInitialize                                = 0x0148;
constexpr uint32_t OpMemoryNamedBarrier                                    = 0x0149;
constexpr uint32_t OpControlBarrierArriveINTEL                             = 0x17FE;
constexpr uint32_t OpControlBarrierWaitINTEL                               = 0x17FF;

// GROUP AND SUBGROUP

constexpr uint32_t OpGroupAsyncCopy                                        = 0x0103;
constexpr uint32_t OpGroupWaitEvents                                       = 0x0104;
constexpr uint32_t OpGroupAll                                              = 0x0105;
constexpr uint32_t OpGroupAny                                              = 0x0106;
constexpr uint32_t OpGroupBroadcast                                        = 0x0107;
constexpr uint32_t OpGroupIAdd                                             = 0x0108;
constexpr uint32_t OpGroupFAdd                                             = 0x0109;
constexpr uint32_t OpGroupFMin                                             = 0x010A;
constexpr uint32_t OpGroupUMin                                             = 0x010B;
constexpr uint32_t OpGroupSMin                                             = 0x010C;
constexpr uint32_t OpGroupFMax                                             = 0x010D;
constexpr uint32_t OpGroupUMax                                             = 0x010E;
constexpr uint32_t OpGroupSMax                                             = 0x010F;
constexpr uint32_t OpSubgroupBallotKHR                                     = 0x1145;
constexpr uint32_t OpSubgroupFirstInvocationKHR                            = 0x1146;
constexpr uint32_t OpSubgroupAllKHR                                        = 0x114C;
constexpr uint32_t OpSubgroupAnyKHR                                        = 0x114D;
constexpr uint32_t OpSubgroupAllEqualKHR                                   = 0x114E;
constexpr uint32_t OpGroupNonUniformRotateKHR                              = 0x114F;
constexpr uint32_t OpSubgroupReadInvocationKHR                             = 0x1150;
constexpr uint32_t OpGroupIAddNonUniformAMD                                = 0x1388;
constexpr uint32_t OpGroupFAddNonUniformAMD                                = 0x1389;
constexpr uint32_t OpGroupFMinNonUniformAMD                                = 0x138A;
constexpr uint32_t OpGroupUMinNonUniformAMD                                = 0x138B;
constexpr uint32_t OpGroupSMinNonUniformAMD                                = 0x138C;
constexpr uint32_t OpGroupFMaxNonUniformAMD                                = 0x138D;
constexpr uint32_t OpGroupUMaxNonUniformAMD                                = 0x138E;
constexpr uint32_t OpGroupSMaxNonUniformAMD                                = 0x138F;
constexpr uint32_t OpSubgroupShuffleINTEL                                  = 0x15C3;
constexpr uint32_t OpSubgroupShuffleDownINTEL                              = 0x15C4;
constexpr uint32_t OpSubgroupShuffleUpINTEL                                = 0x15C5;
constexpr uint32_t OpSubgroupShuffleXorINTEL                               = 0x15C6;
constexpr uint32_t OpSubgroupBlockReadINTEL                                = 0x15C7;
constexpr uint32_t OpSubgroupBlockWriteINTEL                               = 0x15C8;
constexpr uint32_t OpSubgroupImageBlockReadINTEL                           = 0x15C9;
constexpr uint32_t OpSubgroupImageBlockWriteINTEL                          = 0x15CA;
constexpr uint32_t OpSubgroupImageMediaBlockReadINTEL                      = 0x15CC;
constexpr uint32_t OpSubgroupImageMediaBlockWriteINTEL                     = 0x15CD;
constexpr uint32_t OpGroupIMulKHR                                          = 0x1901;
constexpr uint32_t OpGoupFMulKHR                                           = 0x1902;
constexpr uint32_t OpGroupBitwiseAndKHR                                    = 0x1903;
constexpr uint32_t OpGroupBitwiseOrKHR                                     = 0x1904;
constexpr uint32_t OpGroupBitwiseXorKHR                                    = 0x1905;
constexpr uint32_t OpGroupLogicalAndKHR                                    = 0x1906;
constexpr uint32_t OpGroupLogicalOrKHR                                     = 0x1907;
constexpr uint32_t OpGroupLogicalXorKHR                                    = 0x1908;

// DEVICE-SIDE ENQUEUE

constexpr uint32_t OpEnqueueMarker                                         = 0x0123;
constexpr uint32_t OpEnqueueKernel                                         = 0x0124;
constexpr uint32_t OpGetKernelINDrangeSubGroupCount                        = 0x0125;
constexpr uint32_t OpGetKernelINDrangeMaxSubGroupSize                      = 0x0126;
constexpr uint32_t OpGetKernelWorkGroupSize                                = 0x0127;
constexpr uint32_t OpGetKernelPreferredWorkGroupSizeMultiple               = 0x0128;
constexpr uint32_t OpRetainEvent                                           = 0x0129;
constexpr uint32_t OpReleaseEvent                                          = 0x012A;
constexpr uint32_t OpCreateUserEvent                                       = 0x012B;
constexpr uint32_t OpIsValidEvent                                          = 0x012C;
constexpr uint32_t OpSetUserEventStatus                                    = 0x012D;
constexpr uint32_t OpCaptureEventProfilingInfo                             = 0x012E;
constexpr uint32_t OpGetDefaultQueue                                       = 0x012F;
constexpr uint32_t OpBuildNDRange                                          = 0x0130;
constexpr uint32_t OpGetKernelLocalSizeForSubgroupCount                    = 0x0145;
constexpr uint32_t OpGetKernelMaxNumSubgroups                              = 0x0146;

// PIPE

constexpr uint32_t OpReadPipe                                              = 0x0112;
constexpr uint32_t OpWritePipe                                             = 0x0113;
constexpr uint32_t OpReservedReadPipe                                      = 0x0114;
constexpr uint32_t OpReservedWritePipe                                     = 0x0115;
constexpr uint32_t OpReserveReadPipePackets                                = 0x0116;
constexpr uint32_t OpReserveWritePipePackets                               = 0x0117;
constexpr uint32_t OpCommitReadPipe                                        = 0x0118;
constexpr uint32_t OpCommitWritePipe                                       = 0x0119;
constexpr uint32_t OpIsValidReserveId                                      = 0x011A;
constexpr uint32_t OpGetNumPipePackets                                     = 0x011B;
constexpr uint32_t OpGetMaxPipePackets                                     = 0x011C;
constexpr uint32_t OpGroupReserveReadPipePackets                           = 0x011D;
constexpr uint32_t OpGroupReserveWritePipePackets                          = 0x011E;
constexpr uint32_t OpGroupCommitReadPipe                                   = 0x011F;
constexpr uint32_t OpGroupCommitWritePipe                                  = 0x0120;
constexpr uint32_t OpConstantPipeStorage                                   = 0x0143;
constexpr uint32_t OpCreatePipeFromPipeStorage                             = 0x0144;
constexpr uint32_t OpReadPipeBlockingINTEL                                 = 0x173A;
constexpr uint32_t OpWritePipeBlockingINTEL                                = 0x173B;

// NON-UNIFORM

constexpr uint32_t OpGroupNonUniformElect                                  = 0x014D;
constexpr uint32_t OpGroupNonUniformAll                                    = 0x014E;
constexpr uint32_t OpGroupNonUniformAny                                    = 0x014F;
constexpr uint32_t OpGroupNonUniformAllEqual                               = 0x0150;
constexpr uint32_t OpGroupNonUniformBroadcast                              = 0x0151;
constexpr uint32_t OpGroupNonUniformBroadcastFirst                         = 0x0152;
constexpr uint32_t OpGroupNonUniformBallot                                 = 0x0153;
constexpr uint32_t OpGroupNonUniformInverseBallot                          = 0x0154;
constexpr uint32_t OpGroupNonUniformBallotBitExtract                       = 0x0155;
constexpr uint32_t OpGroupNonUniformBallotBitCount                         = 0x0156;
constexpr uint32_t OpGroupNonUniformBallotFindLSB                          = 0x0157;
constexpr uint32_t OpGroupNonUniformBallotFindMSB                          = 0x0158;
constexpr uint32_t OpGroupNonUniformShuffle                                = 0x0159;
constexpr uint32_t OpGroupNonUniformShuffleXor                             = 0x015A;
constexpr uint32_t OpGroupNonUniformShuffleUp                              = 0x015B;
constexpr uint32_t OpGroupNonUniformShuffleDown                            = 0x015C;
constexpr uint32_t OpGroupNonUniformIAdd                                   = 0x015D;
constexpr uint32_t OpGroupNonUniformFAdd                                   = 0x015E;
constexpr uint32_t OpGroupNonUniformIMul                                   = 0x015F;
constexpr uint32_t OpGroupNonUniformFMul                                   = 0x0160;
constexpr uint32_t OpGroupNonUniformSMin                                   = 0x0161;
constexpr uint32_t OpGroupNonUniformUMin                                   = 0x0162;
constexpr uint32_t OpGroupNonUniformFMin                                   = 0x0163;
constexpr uint32_t OpGroupNonUniformSMax                                   = 0x0164;
constexpr uint32_t OpGroupNonUniformUMax                                   = 0x0165;
constexpr uint32_t OpGroupNonUniformFMax                                   = 0x0166;
constexpr uint32_t OpGroupNonUniformBitwiseAnd                             = 0x0167;
constexpr uint32_t OpGroupNonUniformBitwiseOr                              = 0x0168;
constexpr uint32_t OpGroupNonUniformBitwiseXor                             = 0x0169;
constexpr uint32_t OpGroupNonUniformLogicalAnd                             = 0x016A;
constexpr uint32_t OpGroupNonUniformLogicalOr                              = 0x016B;
constexpr uint32_t OpGroupNonUniformLogicalXor                             = 0x016C;
constexpr uint32_t OpGroupNonUniformQuadBroadcast                          = 0x016D;
constexpr uint32_t OpGroupNonUniformQuadSwap                               = 0x016E;
constexpr uint32_t OpGroupNonUniformPartitionNV                            = 0x14B0;

// Reserved

constexpr uint32_t OpTraceRayKHR                                                      = 0x115D;
constexpr uint32_t OpExecuteCallableKHR                                               = 0x115E;
constexpr uint32_t OpConvertUToAccelerationStructureKHR                               = 0x115F;
constexpr uint32_t OpIgnoreIntersectionKHR                                            = 0x1160;
constexpr uint32_t OpTerminateRayKHR                                                  = 0x1161;
constexpr uint32_t OpTypeRayQueryKHR                                                  = 0x1178;
constexpr uint32_t OpRayQueryInitializeKHR                                            = 0x1179;
constexpr uint32_t OpRayQueryTerminateKHR                                             = 0x117A;
constexpr uint32_t OpRayQueryGenerateIntersectionKHR                                  = 0x117B;
constexpr uint32_t OpRayQueryConfirmIntersectionKHR                                   = 0x117C;
constexpr uint32_t OpRayQueryProceedKHR                                               = 0x117D;
constexpr uint32_t OpRayQueryGetIntersectionTypeKHR                                   = 0x117F;
constexpr uint32_t OpFragmentMaskFetchAMD                                             = 0x1393;
constexpr uint32_t OpFragmentFetchAMD                                                 = 0x1394;
constexpr uint32_t OpReadClockKHR                                                     = 0x13C0;
constexpr uint32_t OpWritePackedPrimitiveIndices4x8NV                                 = 0x14B3;
constexpr uint32_t OpReportIntersectionNV                                             = 0x14D6;
constexpr uint32_t OpReportIntersectionKHR                                            = 0x14D6;
constexpr uint32_t OpTerminateRayNV                                                   = 0x14D8;
constexpr uint32_t OpTraceNV                                                          = 0x14D9;
constexpr uint32_t OpTraceMotionNV                                                    = 0x14DA;
constexpr uint32_t OpTraceRayMotionNV                                                 = 0x14DB;
constexpr uint32_t OpTypeAccelerationStructureNV                                      = 0x14DD;
constexpr uint32_t OpTypeAccelerationStructureKHR                                     = 0x14DD;
constexpr uint32_t OpExecuteCallableNV                                                = 0x14E0;
constexpr uint32_t OpTypeCooperativeMatrixNV                                          = 0x14EE;
constexpr uint32_t OpCooperativeMatrixLoadNV                                          = 0x14EF;
constexpr uint32_t OpCooperativeMatrixStoreNV                                         = 0x14F0;
constexpr uint32_t OpCooperativeMatrixMulAddNV                                        = 0x14F1;
constexpr uint32_t OpCooperativeMatrixLengthNV                                        = 0x14F2;
constexpr uint32_t OpBeginInvocationInterlockEXT                                      = 0x14F4;
constexpr uint32_t OpEndInvocationInterlockEXT                                        = 0x14F5;
constexpr uint32_t OpIsHelperInvocationEXT                                            = 0x1505;
constexpr uint32_t OpConvertUToImageNV                                                = 0x150F;
constexpr uint32_t OpConvertUToSamplerNV                                              = 0x1510;
constexpr uint32_t OpConvertImageToUNV                                                = 0x1511;
constexpr uint32_t OpConvertSamplerToUNV                                              = 0x1512;
constexpr uint32_t OpConvertUToSampledImageNV                                         = 0x1513;
constexpr uint32_t OpConvertSampledImageToUNV                                         = 0x1514;
constexpr uint32_t OpSamplerImageAddressingModeNV                                     = 0x1515;
constexpr uint32_t OpUCountLeadingZerosINTEL                                          = 0x15D1;
constexpr uint32_t OpUCountTrailingZerosINTEL                                         = 0x15D2;
constexpr uint32_t OpAbsISubINTEL                                                     = 0x15D3;
constexpr uint32_t OpAbsUSubINTEL                                                     = 0x15D4;
constexpr uint32_t OpIAddSatINTEL                                                     = 0x15D5;
constexpr uint32_t OpUAddSatINTEL                                                     = 0x15D6;
constexpr uint32_t OpIAverageINTEL                                                    = 0x15D7;
constexpr uint32_t OpUAverageINTEL                                                    = 0x15D8;
constexpr uint32_t OpIAverageRoundedINTEL                                             = 0x15D9;
constexpr uint32_t OpUAverageRoundedINTEL                                             = 0x15DA;
constexpr uint32_t OpISubSatINTEL                                                     = 0x15DB;
constexpr uint32_t OpUSubSatINTEL                                                     = 0x15DC;
constexpr uint32_t OpIMul32x16INTEL                                                   = 0x15DD;
constexpr uint32_t OpUMul32x16INTEL                                                   = 0x15DE;
constexpr uint32_t OpLoopControlINTEL                                                 = 0x16FF;
constexpr uint32_t OpFPGARegINTEL                                                     = 0x173D;
constexpr uint32_t OpRayQueryGetRayTMinKHR                                            = 0x1780;
constexpr uint32_t OpRayQueryGetRayFlagsKHR                                           = 0x1781;
constexpr uint32_t OpRayQueryGetIntersectionTKHR                                      = 0x1782;
constexpr uint32_t OpRayQueryGetIntersectionInstanceCustomIndexKHR                    = 0x1783;
constexpr uint32_t OpRayQueryGetIntersectionInstanceIdKHR                             = 0x1784;
constexpr uint32_t OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR = 0x1785;
constexpr uint32_t OpRayQueryGetIntersectionGeometryIndexKHR                          = 0x1786;
constexpr uint32_t OpRayQueryGetIntersectionPrimitiveIndexKHR                         = 0x1787;
constexpr uint32_t OpRayQueryGetIntersectionBarycentricsKHR                           = 0x1788;
constexpr uint32_t OpRayQueryGetIntersectionFrontFaceKHR                              = 0x1789;
constexpr uint32_t OpRayQueryGetIntersectionCandidateAABBOpaqueKHR                    = 0x178A;
constexpr uint32_t OpRayQueryGetIntersectionObjectRayDirectionKHR                     = 0x178B;
constexpr uint32_t OpRayQueryGetIntersectionObjectRayOriginKHR                        = 0x178C;
constexpr uint32_t OpRayQueryGetWorldRayDirectionKHR                                  = 0x178D;
constexpr uint32_t OpRayQueryGetWorldRayOriginKHR                                     = 0x178E;
constexpr uint32_t OpRayQueryGetIntersectionObjectToWorldKHR                          = 0x178F;
constexpr uint32_t OpRayQueryGetIntersectionWorldToObjectKHR                          = 0x1790;
