namespace Jeslc
{
	public static partial class SPIRV
	{
		// MISC

		public const UInt16 OpNop           = 0x0000;
		public const UInt16 OpUndef         = 0x0001;
		public const UInt16 OpSizeOf        = 0x0141;
		public const UInt16 OpAssumeTrueKHR = 0x15FE;
		public const UInt16 OpExpectKHR     = 0x15FF;

		// DEBUG

		public const UInt16 OpSourceContinued = 0x0002;
		public const UInt16 OpSource          = 0x0003;
		public const UInt16 OpSourceExtension = 0x0004;
		public const UInt16 OpName            = 0x0005;
		public const UInt16 OpMemberName      = 0x0006;
		public const UInt16 OpString          = 0x0007;
		public const UInt16 OpLine            = 0x0008;
		public const UInt16 OpNoLine          = 0x013D;
		public const UInt16 OpModuleProcessed = 0x014A;

		// ANNOTATION

		public const UInt16 OpDecorate                   = 0x0047;
		public const UInt16 OpMemberDecorate             = 0x0048;
		public const UInt16 OpDecorationGroup            = 0x0049;
		public const UInt16 OpGroupDecorate              = 0x004A;
		public const UInt16 OpGroupMemberDecorate        = 0x004B;
		public const UInt16 OpDecorateId                 = 0x014C;
		public const UInt16 OpDecorateString             = 0x1600;
		public const UInt16 OpDecorateStringGOOGLE       = 0x1600;
		public const UInt16 OpMemberDecorateString       = 0x1601;
		public const UInt16 OpMemberDecorateStringGOOGLE = 0x1601;

		// EXTENSION

		public const UInt16 OpExtension     = 0x000A;
		public const UInt16 OpExtInstImport = 0x000B;
		public const UInt16 OpExtInst       = 0x000C;

		// MODE SETTING

		public const UInt16 OpMemoryModel     = 0x000E;
		public const UInt16 OpEntryPoint      = 0x000F;
		public const UInt16 OpExecutionMode   = 0x0010;
		public const UInt16 OpCapability      = 0x0011;
		public const UInt16 OpExecutionModeId = 0x014B;

		// TYPE DECLARATION

		public const UInt16 OpTypeVoid                 = 0x0013;
		public const UInt16 OpTypeBool                 = 0x0014;
		public const UInt16 OpTypeInt                  = 0x0015;
		public const UInt16 OpTypeFloat                = 0x0016;
		public const UInt16 OpTypeVector               = 0x0017;
		public const UInt16 OpTypeMatrix               = 0x0018;
		public const UInt16 OpTypeImage                = 0x0019;
		public const UInt16 OpTypeSampler              = 0x001A;
		public const UInt16 OpTypeSampledImage         = 0x001B;
		public const UInt16 OpTypeArray                = 0x001C;
		public const UInt16 OpTypeRuntimeArray         = 0x001D;
		public const UInt16 OpTypeStruct               = 0x001E;
		public const UInt16 OpTypeOpaque               = 0x001F;
		public const UInt16 OpTypePointer              = 0x0020;
		public const UInt16 OpTypeFunction             = 0x0021;
		public const UInt16 OpTypeEvent                = 0x0022;
		public const UInt16 OpTypeDeviceEvent          = 0x0023;
		public const UInt16 OpTypeReserveId            = 0x0024;
		public const UInt16 OpTypeQueue                = 0x0025;
		public const UInt16 OpTypePipe                 = 0x0026;
		public const UInt16 OpTypeForwardPointer       = 0x0027;
		public const UInt16 OpTypePipeStorage          = 0x0142;
		public const UInt16 OpTypeNamedBarrier         = 0x0147;
		public const UInt16 OpTypeBufferSurfaceINTEL   = 0x17C6;
		public const UInt16 OpTypeStructContinuedINTEL = 0x17CA;

		// CONSTANT CREATION

		public const UInt16 OpConstantTrue                        = 0x0029;
		public const UInt16 OpConstantFalse                       = 0x002A;
		public const UInt16 OpConstant                            = 0x002B;
		public const UInt16 OpConstantComposite                   = 0x002C;
		public const UInt16 OpConstantSampler                     = 0x002D;
		public const UInt16 OpConstantNull                        = 0x002E;
		public const UInt16 OpSpecConstantTrue                    = 0x0030;
		public const UInt16 OpSpecConstantFalse                   = 0x0031;
		public const UInt16 OpSpecConstant                        = 0x0032;
		public const UInt16 OpSpecConstantComposite               = 0x0033;
		public const UInt16 OpSpecConstantOp                      = 0x0034;
		public const UInt16 OpConstantCompositeContinuedINTEL     = 0x17CB;
		public const UInt16 OpSpecConstantCompositeContinuedINTEL = 0x17CC;

		// MEMORY

		public const UInt16 OpVariable               = 0x003B;
		public const UInt16 OpImageTexelPointer      = 0x003C;
		public const UInt16 OpLoad                   = 0x003D;
		public const UInt16 OpStore                  = 0x003E;
		public const UInt16 OpCopyMemory             = 0x003F;
		public const UInt16 OpCopyMemorySized        = 0x0040;
		public const UInt16 OpAccessChain            = 0x0041;
		public const UInt16 OpInBoundsAccessChain    = 0x0042;
		public const UInt16 OpPtrAccessChain         = 0x0043;
		public const UInt16 OpArrayLength            = 0x0044;
		public const UInt16 OpGenericPtrMemSemantics = 0x0045;
		public const UInt16 OpInBoundsPtrAccessChain = 0x0046;
		public const UInt16 OpPtrEqual               = 0x0191;
		public const UInt16 OpPtrNotEqual            = 0x0192;
		public const UInt16 OpPtrDiff                = 0x0193;

		// FUNCTION

		public const UInt16 OpFunction          = 0x0036;
		public const UInt16 OpFunctionParameter = 0x0037;
		public const UInt16 OpFunctionEnd       = 0x0038;
		public const UInt16 OpFunctionCall      = 0x0039;

		// IMAGE

		public const UInt16 OpSampledImage                         = 0x0056;
		public const UInt16 OpImageSampleImplicitLod               = 0x0057;
		public const UInt16 OpImageSampleExplicitLod               = 0x0058;
		public const UInt16 OpImageSampleDrefImplicitLod           = 0x0059;
		public const UInt16 OpImageSampleDrefExplicitLod           = 0x005A;
		public const UInt16 OpImageSampleProjImplicitLod           = 0x005B;
		public const UInt16 OpImageSampleProjExplicitLod           = 0x005C;
		public const UInt16 OpImageSampleProjDrefImplicitLod       = 0x005D;
		public const UInt16 OpImageSampleProjDrefExplicitLod       = 0x005E;
		public const UInt16 OpImageFetch                           = 0x005F;
		public const UInt16 OpImageGather                          = 0x0060;
		public const UInt16 OpImageDrefGather                      = 0x0061;
		public const UInt16 OpImageRead                            = 0x0062;
		public const UInt16 OpImageWrite                           = 0x0063;
		public const UInt16 OpImage                                = 0x0064;
		public const UInt16 OpImageQueryFormat                     = 0x0065;
		public const UInt16 OpImageQueryOrder                      = 0x0066;
		public const UInt16 OpImageQuerySizeLod                    = 0x0067;
		public const UInt16 OpImageQuerySize                       = 0x0068;
		public const UInt16 OpImageQueryLod                        = 0x0069;
		public const UInt16 OpImageQueryLevels                     = 0x006A;
		public const UInt16 OpImageQuerySamples                    = 0x006B;
		public const UInt16 OpImageSparseSampleImplicitLod         = 0x0131;
		public const UInt16 OpImageSparseSampleExplicitLod         = 0x0132;
		public const UInt16 OpImageSparseSampleDrefImplicitLod     = 0x0133;
		public const UInt16 OpImageSparseSampleDrefExplicitLod     = 0x0134;
		public const UInt16 OpImageSparseSampleProjImplicitLod     = 0x0135;
		public const UInt16 OpImageSparseSampleProjExplicitLod     = 0x0136;
		public const UInt16 OpImageSparseSampleProjDrefImplicitLod = 0x0137;
		public const UInt16 OpImageSparseSampleProjDrefExplicitLod = 0x0138;
		public const UInt16 OpImageSparseFetch                     = 0x0139;
		public const UInt16 OpImageSparseGather                    = 0x013A;
		public const UInt16 OpImageSparseDrefGather                = 0x013B;
		public const UInt16 OpImageSparseTexelsResident            = 0x013C;
		public const UInt16 OpImageSparseRead                      = 0x0140;
		public const UInt16 OpImageSampleFootprintNV               = 0x14A3;

		// CONVERSION

		public const UInt16 OpConvertFToU              = 0x006D;
		public const UInt16 OpConvertFToS              = 0x006E;
		public const UInt16 OpConvertSToF              = 0x006F;
		public const UInt16 OpConvertUToF              = 0x0070;
		public const UInt16 OpUConvert                 = 0x0071;
		public const UInt16 OpSConvert                 = 0x0072;
		public const UInt16 OpFConvert                 = 0x0073;
		public const UInt16 OpQuantizeToF16            = 0x0074;
		public const UInt16 OpConvertPtrToU            = 0x0075;
		public const UInt16 OpSatConvertSToU           = 0x0076;
		public const UInt16 OpSatConvertUToS           = 0x0077;
		public const UInt16 OpConvertUToPtr            = 0x0078;
		public const UInt16 OpPtrCastToGeneric         = 0x0079;
		public const UInt16 OpGenericCastToPtr         = 0x007A;
		public const UInt16 OpGenericCastToPtrExplicit = 0x007B;
		public const UInt16 OpBitcast                  = 0x007C;

		// COMPOSITE

		public const UInt16 OpVectorExtractDynamic = 0x004D;
		public const UInt16 OpVectorInsertDynamic  = 0x004E;
		public const UInt16 OpVectorShuffle        = 0x004F;
		public const UInt16 OpCompositeConstruct   = 0x0050;
		public const UInt16 OpCompositeExtract     = 0x0051;
		public const UInt16 OpCompositeInsert      = 0x0052;
		public const UInt16 OpCopyObject           = 0x0053;
		public const UInt16 OpTranspose            = 0x0054;
		public const UInt16 OpCopyLogical          = 0x0190;

		// ARITHMETIC

		public const UInt16 OpSNegate           = 0x007E;
		public const UInt16 OpFNegate           = 0x007F;
		public const UInt16 OpIAdd              = 0x0080;
		public const UInt16 OpFAdd              = 0x0081;
		public const UInt16 OpISub              = 0x0082;
		public const UInt16 OpFSub              = 0x0083;
		public const UInt16 OpIMul              = 0x0084;
		public const UInt16 OpFMul              = 0x0085;
		public const UInt16 OpUDiv              = 0x0086;
		public const UInt16 OpSDiv              = 0x0087;
		public const UInt16 OpFDiv              = 0x0088;
		public const UInt16 OpUMod              = 0x0089;
		public const UInt16 OpSRem              = 0x008A;
		public const UInt16 OpSMod              = 0x008B;
		public const UInt16 OpFRem              = 0x008C;
		public const UInt16 OpFMod              = 0x008D;
		public const UInt16 OpVectorTimesScalar = 0x008E;
		public const UInt16 OpMatrixTimesScalar = 0x008F;
		public const UInt16 OpVectorTimesMatrix = 0x0090;
		public const UInt16 OpMatrixTimesVector = 0x0091;
		public const UInt16 OpMatrixTimesMatrix = 0x0092;
		public const UInt16 OpOuterProduct      = 0x0093;
		public const UInt16 OpDot               = 0x0094;
		public const UInt16 OpIAddCarry         = 0x0095;
		public const UInt16 OpISubBorrow        = 0x0096;
		public const UInt16 OpUMulExtended      = 0x0097;
		public const UInt16 OpSMulExtended      = 0x0098;
		public const UInt16 OpSDot              = 0x1162;
		public const UInt16 OpSDotKHR           = 0x1162;
		public const UInt16 OpUDot              = 0x1163;
		public const UInt16 OpUDotKHR           = 0x1163;
		public const UInt16 OpSUDot             = 0x1164;
		public const UInt16 OpSUDotKHR          = 0x1164;
		public const UInt16 OpSDotAccSat        = 0x1165;
		public const UInt16 OpSDotAccSatKHR     = 0x1165;
		public const UInt16 OpUDotAccSat        = 0x1166;
		public const UInt16 OpUDotAccSatKHR     = 0x1166;
		public const UInt16 OpSUDotAccSat       = 0x1167;
		public const UInt16 OpSUDotAccSatKHR    = 0x1167;

		// BIT

		public const UInt16 OpShiftRightLogical    = 0x00C2;
		public const UInt16 OpShiftRightArithmetic = 0x00C3;
		public const UInt16 OpShiftLeftLogical     = 0x00C4;
		public const UInt16 OpBitwiseOr            = 0x00C5;
		public const UInt16 OpBitwiseXor           = 0x00C6;
		public const UInt16 OpBitwiseAnd           = 0x00C7;
		public const UInt16 OpNot                  = 0x00C8;
		public const UInt16 OpBitFieldInsert       = 0x00C9;
		public const UInt16 OpBitFieldSExtract     = 0x00CA;
		public const UInt16 OpBitFieldUExtract     = 0x00CB;
		public const UInt16 OpBitReverse           = 0x00CC;
		public const UInt16 OpBitCount             = 0x00CD;

		// RELATIONAL AND LOGICAL

		public const UInt16 OpAny                    = 0x009A;
		public const UInt16 OpAll                    = 0x009B;
		public const UInt16 OpIsNan                  = 0x009C;
		public const UInt16 OpIsInf                  = 0x009D;
		public const UInt16 OpIsFinite               = 0x009E;
		public const UInt16 OpIsNormal               = 0x009F;
		public const UInt16 OpSignBitSet             = 0x00A0;
		public const UInt16 OpLessOrGreater          = 0x00A1;
		public const UInt16 OpOrdered                = 0x00A2;
		public const UInt16 OpUnordered              = 0x00A3;
		public const UInt16 OpLogicalEqual           = 0x00A4;
		public const UInt16 OpLogicalNotEqual        = 0x00A5;
		public const UInt16 OpLogicalOr              = 0x00A6;
		public const UInt16 OpLogicalAnd             = 0x00A7;
		public const UInt16 OpLogicalNot             = 0x00A8;
		public const UInt16 OpSelect                 = 0x00A9;
		public const UInt16 OpIEqual                 = 0x00AA;
		public const UInt16 OpINotEqual              = 0x00AB;
		public const UInt16 OpUGreaterThan           = 0x00AC;
		public const UInt16 OpSGreaterThan           = 0x00AD;
		public const UInt16 OpUGreaterThanEqual      = 0x00AE;
		public const UInt16 OpSGreaterThanEqual      = 0x00AF;
		public const UInt16 OpULessThan              = 0x00B0;
		public const UInt16 OpSLessThan              = 0x00B1;
		public const UInt16 OpULessThanEqual         = 0x00B2;
		public const UInt16 OpSLessThanEqual         = 0x00B3;
		public const UInt16 OpFOrdEqual              = 0x00B4;
		public const UInt16 OpFUnordEqual            = 0x00B5;
		public const UInt16 OpFOrdNotEqual           = 0x00B6;
		public const UInt16 OpFUnordNotEqual         = 0x00B7;
		public const UInt16 OpFOrdLessThan           = 0x00B8;
		public const UInt16 OpFUnordLessThan         = 0x00B9;
		public const UInt16 OpFOrdGreaterThan        = 0x00BA;
		public const UInt16 OpFUnordGreaterThan      = 0x00BB;
		public const UInt16 OpFOrdLessThanEqual      = 0x00BC;
		public const UInt16 OpFUnordLessThanEqual    = 0x00BD;
		public const UInt16 OpFOrdGreaterThanEqual   = 0x00BE;
		public const UInt16 OpFUnordGreaterThanEqual = 0x00BF;

		// DERIVATIVE

		public const UInt16 OpDPdx         = 0x00CF;
		public const UInt16 OpDPdy         = 0x00D0;
		public const UInt16 OpFwidth       = 0x00D1;
		public const UInt16 OpDPdxFine     = 0x00D2;
		public const UInt16 OpDPdyFine     = 0x00D3;
		public const UInt16 OpFwidthFine   = 0x00D4;
		public const UInt16 OpDPdxCoarse   = 0x00D5;
		public const UInt16 OpDPdyCoarse   = 0x00D6;
		public const UInt16 OpFwidthCoarse = 0x00D7;

		// CONTROL FLOW

		public const UInt16 OpPhi                         = 0x00F5;
		public const UInt16 OpLoopMerge                   = 0x00F6;
		public const UInt16 OpSelectionMerge              = 0x00F7;
		public const UInt16 OpLabel                       = 0x00F8;
		public const UInt16 OpBranch                      = 0x00F9;
		public const UInt16 OpBranchConditional           = 0x00FA;
		public const UInt16 OpSwitch                      = 0x00FB;
		public const UInt16 OpKill                        = 0x00FC;
		public const UInt16 OpReturn                      = 0x00FD;
		public const UInt16 OpReturnValue                 = 0x00FE;
		public const UInt16 OpUnreachable                 = 0x00FF;
		public const UInt16 OpLifetimeStart               = 0x0100;
		public const UInt16 OpLifetimeStop                = 0x0101;
		public const UInt16 OpTerminateInvocation         = 0x1140;
		public const UInt16 OpDemoteToHelperInvocation    = 0x1504;
		public const UInt16 OpDemoteToHelperInvocationEXT = 0x1504;

		// ATOMIC

		public const UInt16 OpAtomicLoad                = 0x00E3;
		public const UInt16 OpAtomicStore               = 0x00E4;
		public const UInt16 OpAtomicExchange            = 0x00E5;
		public const UInt16 OpAtomicCompareExchange     = 0x00E6;
		public const UInt16 OpAtomicCompareExchangeWeak = 0x00E7;
		public const UInt16 OpAtomicIIncrement          = 0x00E8;
		public const UInt16 OpAtomicIDecrement          = 0x00E9;
		public const UInt16 OpAtomicIAdd                = 0x00EA;
		public const UInt16 OpAtomicISub                = 0x00EB;
		public const UInt16 OpAtomicSMin                = 0x00EC;
		public const UInt16 OpAtomicUMin                = 0x00ED;
		public const UInt16 OpAtomicSMax                = 0x00EE;
		public const UInt16 OpAtomicUMax                = 0x00EF;
		public const UInt16 OpAtomicAnd                 = 0x00F0;
		public const UInt16 OpAtomicOr                  = 0x00F1;
		public const UInt16 OpAtomicXor                 = 0x00F2;
		public const UInt16 OpAtomicFlagTestAndSet      = 0x013E;
		public const UInt16 OpAtomicFlagClear           = 0x013F;
		public const UInt16 OpAtomicFMinEXT             = 0x15EE;
		public const UInt16 OpAtomicFMaxEXT             = 0x15EF;
		public const UInt16 OpAtomicFAddEXT             = 0x1793;

		// PRIMITIVE

		public const UInt16 OpEmitVertex         = 0x00DA;
		public const UInt16 OpEndPrimitive       = 0x00DB;
		public const UInt16 OpEmitStreamVertex   = 0x00DC;
		public const UInt16 OpEndStreamPrimitive = 0x00DD;

		// Barrier

		public const UInt16 OpControlBarrier            = 0x00E0;
		public const UInt16 OpMemoryBarrier             = 0x00E1;
		public const UInt16 OpNamedBarrierInitialize    = 0x0148;
		public const UInt16 OpMemoryNamedBarrier        = 0x0149;
		public const UInt16 OpControlBarrierArriveINTEL = 0x17FE;
		public const UInt16 OpControlBarrierWaitINTEL   = 0x17FF;

		// GROUP AND SUBGROUP

		public const UInt16 OpGroupAsyncCopy                    = 0x0103;
		public const UInt16 OpGroupWaitEvents                   = 0x0104;
		public const UInt16 OpGroupAll                          = 0x0105;
		public const UInt16 OpGroupAny                          = 0x0106;
		public const UInt16 OpGroupBroadcast                    = 0x0107;
		public const UInt16 OpGroupIAdd                         = 0x0108;
		public const UInt16 OpGroupFAdd                         = 0x0109;
		public const UInt16 OpGroupFMin                         = 0x010A;
		public const UInt16 OpGroupUMin                         = 0x010B;
		public const UInt16 OpGroupSMin                         = 0x010C;
		public const UInt16 OpGroupFMax                         = 0x010D;
		public const UInt16 OpGroupUMax                         = 0x010E;
		public const UInt16 OpGroupSMax                         = 0x010F;
		public const UInt16 OpSubgroupBallotKHR                 = 0x1145;
		public const UInt16 OpSubgroupFirstInvocationKHR        = 0x1146;
		public const UInt16 OpSubgroupAllKHR                    = 0x114C;
		public const UInt16 OpSubgroupAnyKHR                    = 0x114D;
		public const UInt16 OpSubgroupAllEqualKHR               = 0x114E;
		public const UInt16 OpGroupNonUniformRotateKHR          = 0x114F;
		public const UInt16 OpSubgroupReadInvocationKHR         = 0x1150;
		public const UInt16 OpGroupIAddNonUniformAMD            = 0x1388;
		public const UInt16 OpGroupFAddNonUniformAMD            = 0x1389;
		public const UInt16 OpGroupFMinNonUniformAMD            = 0x138A;
		public const UInt16 OpGroupUMinNonUniformAMD            = 0x138B;
		public const UInt16 OpGroupSMinNonUniformAMD            = 0x138C;
		public const UInt16 OpGroupFMaxNonUniformAMD            = 0x138D;
		public const UInt16 OpGroupUMaxNonUniformAMD            = 0x138E;
		public const UInt16 OpGroupSMaxNonUniformAMD            = 0x138F;
		public const UInt16 OpSubgroupShuffleINTEL              = 0x15C3;
		public const UInt16 OpSubgroupShuffleDownINTEL          = 0x15C4;
		public const UInt16 OpSubgroupShuffleUpINTEL            = 0x15C5;
		public const UInt16 OpSubgroupShuffleXorINTEL           = 0x15C6;
		public const UInt16 OpSubgroupBlockReadINTEL            = 0x15C7;
		public const UInt16 OpSubgroupBlockWriteINTEL           = 0x15C8;
		public const UInt16 OpSubgroupImageBlockReadINTEL       = 0x15C9;
		public const UInt16 OpSubgroupImageBlockWriteINTEL      = 0x15CA;
		public const UInt16 OpSubgroupImageMediaBlockReadINTEL  = 0x15CC;
		public const UInt16 OpSubgroupImageMediaBlockWriteINTEL = 0x15CD;
		public const UInt16 OpGroupIMulKHR                      = 0x1901;
		public const UInt16 OpGoupFMulKHR                       = 0x1902;
		public const UInt16 OpGroupBitwiseAndKHR                = 0x1903;
		public const UInt16 OpGroupBitwiseOrKHR                 = 0x1904;
		public const UInt16 OpGroupBitwiseXorKHR                = 0x1905;
		public const UInt16 OpGroupLogicalAndKHR                = 0x1906;
		public const UInt16 OpGroupLogicalOrKHR                 = 0x1907;
		public const UInt16 OpGroupLogicalXorKHR                = 0x1908;

		// DEVICE-SIDE ENQUEUE

		public const UInt16 OpEnqueueMarker                           = 0x0123;
		public const UInt16 OpEnqueueKernel                           = 0x0124;
		public const UInt16 OpGetKernelINDrangeSubGroupCount          = 0x0125;
		public const UInt16 OpGetKernelINDrangeMaxSubGroupSize        = 0x0126;
		public const UInt16 OpGetKernelWorkGroupSize                  = 0x0127;
		public const UInt16 OpGetKernelPreferredWorkGroupSizeMultiple = 0x0128;
		public const UInt16 OpRetainEvent                             = 0x0129;
		public const UInt16 OpReleaseEvent                            = 0x012A;
		public const UInt16 OpCreateUserEvent                         = 0x012B;
		public const UInt16 OpIsValidEvent                            = 0x012C;
		public const UInt16 OpSetUserEventStatus                      = 0x012D;
		public const UInt16 OpCaptureEventProfilingInfo               = 0x012E;
		public const UInt16 OpGetDefaultQueue                         = 0x012F;
		public const UInt16 OpBuildNDRange                            = 0x0130;
		public const UInt16 OpGetKernelLocalSizeForSubgroupCount      = 0x0145;
		public const UInt16 OpGetKernelMaxNumSubgroups                = 0x0146;

		// PIPE

		public const UInt16 OpReadPipe                     = 0x0112;
		public const UInt16 OpWritePipe                    = 0x0113;
		public const UInt16 OpReservedReadPipe             = 0x0114;
		public const UInt16 OpReservedWritePipe            = 0x0115;
		public const UInt16 OpReserveReadPipePackets       = 0x0116;
		public const UInt16 OpReserveWritePipePackets      = 0x0117;
		public const UInt16 OpCommitReadPipe               = 0x0118;
		public const UInt16 OpCommitWritePipe              = 0x0119;
		public const UInt16 OpIsValidReserveId             = 0x011A;
		public const UInt16 OpGetNumPipePackets            = 0x011B;
		public const UInt16 OpGetMaxPipePackets            = 0x011C;
		public const UInt16 OpGroupReserveReadPipePackets  = 0x011D;
		public const UInt16 OpGroupReserveWritePipePackets = 0x011E;
		public const UInt16 OpGroupCommitReadPipe          = 0x011F;
		public const UInt16 OpGroupCommitWritePipe         = 0x0120;
		public const UInt16 OpConstantPipeStorage          = 0x0143;
		public const UInt16 OpCreatePipeFromPipeStorage    = 0x0144;
		public const UInt16 OpReadPipeBlockingINTEL        = 0x173A;
		public const UInt16 OpWritePipeBlockingINTEL       = 0x173B;

		// NON-UNIFORM

		public const UInt16 OpGroupNonUniformElect            = 0x014D;
		public const UInt16 OpGroupNonUniformAll              = 0x014E;
		public const UInt16 OpGroupNonUniformAny              = 0x014F;
		public const UInt16 OpGroupNonUniformAllEqual         = 0x0150;
		public const UInt16 OpGroupNonUniformBroadcast        = 0x0151;
		public const UInt16 OpGroupNonUniformBroadcastFirst   = 0x0152;
		public const UInt16 OpGroupNonUniformBallot           = 0x0153;
		public const UInt16 OpGroupNonUniformInverseBallot    = 0x0154;
		public const UInt16 OpGroupNonUniformBallotBitExtract = 0x0155;
		public const UInt16 OpGroupNonUniformBallotBitCount   = 0x0156;
		public const UInt16 OpGroupNonUniformBallotFindLSB    = 0x0157;
		public const UInt16 OpGroupNonUniformBallotFindMSB    = 0x0158;
		public const UInt16 OpGroupNonUniformShuffle          = 0x0159;
		public const UInt16 OpGroupNonUniformShuffleXor       = 0x015A;
		public const UInt16 OpGroupNonUniformShuffleUp        = 0x015B;
		public const UInt16 OpGroupNonUniformShuffleDown      = 0x015C;
		public const UInt16 OpGroupNonUniformIAdd             = 0x015D;
		public const UInt16 OpGroupNonUniformFAdd             = 0x015E;
		public const UInt16 OpGroupNonUniformIMul             = 0x015F;
		public const UInt16 OpGroupNonUniformFMul             = 0x0160;
		public const UInt16 OpGroupNonUniformSMin             = 0x0161;
		public const UInt16 OpGroupNonUniformUMin             = 0x0162;
		public const UInt16 OpGroupNonUniformFMin             = 0x0163;
		public const UInt16 OpGroupNonUniformSMax             = 0x0164;
		public const UInt16 OpGroupNonUniformUMax             = 0x0165;
		public const UInt16 OpGroupNonUniformFMax             = 0x0166;
		public const UInt16 OpGroupNonUniformBitwiseAnd       = 0x0167;
		public const UInt16 OpGroupNonUniformBitwiseOr        = 0x0168;
		public const UInt16 OpGroupNonUniformBitwiseXor       = 0x0169;
		public const UInt16 OpGroupNonUniformLogicalAnd       = 0x016A;
		public const UInt16 OpGroupNonUniformLogicalOr        = 0x016B;
		public const UInt16 OpGroupNonUniformLogicalXor       = 0x016C;
		public const UInt16 OpGroupNonUniformQuadBroadcast    = 0x016D;
		public const UInt16 OpGroupNonUniformQuadSwap         = 0x016E;
		public const UInt16 OpGroupNonUniformPartitionNV      = 0x14B0;

		// Reserved

		public const UInt16 OpTraceRayKHR                                                      = 0x115D;
		public const UInt16 OpExecuteCallableKHR                                               = 0x115E;
		public const UInt16 OpConvertUToAccelerationStructureKHR                               = 0x115F;
		public const UInt16 OpIgnoreIntersectionKHR                                            = 0x1160;
		public const UInt16 OpTerminateRayKHR                                                  = 0x1161;
		public const UInt16 OpTypeRayQueryKHR                                                  = 0x1178;
		public const UInt16 OpRayQueryInitializeKHR                                            = 0x1179;
		public const UInt16 OpRayQueryTerminateKHR                                             = 0x117A;
		public const UInt16 OpRayQueryGenerateIntersectionKHR                                  = 0x117B;
		public const UInt16 OpRayQueryConfirmIntersectionKHR                                   = 0x117C;
		public const UInt16 OpRayQueryProceedKHR                                               = 0x117D;
		public const UInt16 OpRayQueryGetIntersectionTypeKHR                                   = 0x117F;
		public const UInt16 OpFragmentMaskFetchAMD                                             = 0x1393;
		public const UInt16 OpFragmentFetchAMD                                                 = 0x1394;
		public const UInt16 OpReadClockKHR                                                     = 0x13C0;
		public const UInt16 OpWritePackedPrimitiveIndices4x8NV                                 = 0x14B3;
		public const UInt16 OpReportIntersectionNV                                             = 0x14D6;
		public const UInt16 OpReportIntersectionKHR                                            = 0x14D6;
		public const UInt16 OpTerminateRayNV                                                   = 0x14D8;
		public const UInt16 OpTraceNV                                                          = 0x14D9;
		public const UInt16 OpTraceMotionNV                                                    = 0x14DA;
		public const UInt16 OpTraceRayMotionNV                                                 = 0x14DB;
		public const UInt16 OpTypeAccelerationStructureNV                                      = 0x14DD;
		public const UInt16 OpTypeAccelerationStructureKHR                                     = 0x14DD;
		public const UInt16 OpExecuteCallableNV                                                = 0x14E0;
		public const UInt16 OpTypeCooperativeMatrixNV                                          = 0x14EE;
		public const UInt16 OpCooperativeMatrixLoadNV                                          = 0x14EF;
		public const UInt16 OpCooperativeMatrixStoreNV                                         = 0x14F0;
		public const UInt16 OpCooperativeMatrixMulAddNV                                        = 0x14F1;
		public const UInt16 OpCooperativeMatrixLengthNV                                        = 0x14F2;
		public const UInt16 OpBeginInvocationInterlockEXT                                      = 0x14F4;
		public const UInt16 OpEndInvocationInterlockEXT                                        = 0x14F5;
		public const UInt16 OpIsHelperInvocationEXT                                            = 0x1505;
		public const UInt16 OpConvertUToImageNV                                                = 0x150F;
		public const UInt16 OpConvertUToSamplerNV                                              = 0x1510;
		public const UInt16 OpConvertImageToUNV                                                = 0x1511;
		public const UInt16 OpConvertSamplerToUNV                                              = 0x1512;
		public const UInt16 OpConvertUToSampledImageNV                                         = 0x1513;
		public const UInt16 OpConvertSampledImageToUNV                                         = 0x1514;
		public const UInt16 OpSamplerImageAddressingModeNV                                     = 0x1515;
		public const UInt16 OpUCountLeadingZerosINTEL                                          = 0x15D1;
		public const UInt16 OpUCountTrailingZerosINTEL                                         = 0x15D2;
		public const UInt16 OpAbsISubINTEL                                                     = 0x15D3;
		public const UInt16 OpAbsUSubINTEL                                                     = 0x15D4;
		public const UInt16 OpIAddSatINTEL                                                     = 0x15D5;
		public const UInt16 OpUAddSatINTEL                                                     = 0x15D6;
		public const UInt16 OpIAverageINTEL                                                    = 0x15D7;
		public const UInt16 OpUAverageINTEL                                                    = 0x15D8;
		public const UInt16 OpIAverageRoundedINTEL                                             = 0x15D9;
		public const UInt16 OpUAverageRoundedINTEL                                             = 0x15DA;
		public const UInt16 OpISubSatINTEL                                                     = 0x15DB;
		public const UInt16 OpUSubSatINTEL                                                     = 0x15DC;
		public const UInt16 OpIMul32x16INTEL                                                   = 0x15DD;
		public const UInt16 OpUMul32x16INTEL                                                   = 0x15DE;
		public const UInt16 OpLoopControlINTEL                                                 = 0x16FF;
		public const UInt16 OpFPGARegINTEL                                                     = 0x173D;
		public const UInt16 OpRayQueryGetRayTMinKHR                                            = 0x1780;
		public const UInt16 OpRayQueryGetRayFlagsKHR                                           = 0x1781;
		public const UInt16 OpRayQueryGetIntersectionTKHR                                      = 0x1782;
		public const UInt16 OpRayQueryGetIntersectionInstanceCustomIndexKHR                    = 0x1783;
		public const UInt16 OpRayQueryGetIntersectionInstanceIdKHR                             = 0x1784;
		public const UInt16 OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR = 0x1785;
		public const UInt16 OpRayQueryGetIntersectionGeometryIndexKHR                          = 0x1786;
		public const UInt16 OpRayQueryGetIntersectionPrimitiveIndexKHR                         = 0x1787;
		public const UInt16 OpRayQueryGetIntersectionBarycentricsKHR                           = 0x1788;
		public const UInt16 OpRayQueryGetIntersectionFrontFaceKHR                              = 0x1789;
		public const UInt16 OpRayQueryGetIntersectionCandidateAABBOpaqueKHR                    = 0x178A;
		public const UInt16 OpRayQueryGetIntersectionObjectRayDirectionKHR                     = 0x178B;
		public const UInt16 OpRayQueryGetIntersectionObjectRayOriginKHR                        = 0x178C;
		public const UInt16 OpRayQueryGetWorldRayDirectionKHR                                  = 0x178D;
		public const UInt16 OpRayQueryGetWorldRayOriginKHR                                     = 0x178E;
		public const UInt16 OpRayQueryGetIntersectionObjectToWorldKHR                          = 0x178F;
		public const UInt16 OpRayQueryGetIntersectionWorldToObjectKHR                          = 0x1790;
	}
}
