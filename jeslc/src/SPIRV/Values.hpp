#pragma once

#include <cinttypes>

constexpr uint32_t MagicNumber = 0x07230203;

// Source Language

constexpr uint32_t SourceLanguage_Unknown        = 0;
constexpr uint32_t SourceLanguage_ESSL           = 1;
constexpr uint32_t SourceLanguage_GLSL           = 2;
constexpr uint32_t SourceLanguage_OpenCL_C       = 3;
constexpr uint32_t SourceLanguage_OpenCL_CPP     = 4;
constexpr uint32_t SourceLanguage_HLSL           = 5;
constexpr uint32_t SourceLanguage_CPP_for_OpenCL = 6;
constexpr uint32_t SourceLanguage_SYCL           = 7;

// Execution Model

constexpr uint32_t ExecutionModel_Vertex                 =    0;
constexpr uint32_t ExecutionModel_TessellationControl    =    1;
constexpr uint32_t ExecutionModel_TessellationEvaluation =    2;
constexpr uint32_t ExecutionModel_Geometry               =    3;
constexpr uint32_t ExecutionModel_Fragment               =    4;
constexpr uint32_t ExecutionModel_GLCompute              =    5;
constexpr uint32_t ExecutionModel_Kernel                 =    6;
constexpr uint32_t ExecutionModel_TaskNV                 = 5267;
constexpr uint32_t ExecutionModel_MeshNV                 = 5268;
constexpr uint32_t ExecutionModel_RayGenerationNV        = 5313;
constexpr uint32_t ExecutionModel_RayGenerationKHR       = 5313;
constexpr uint32_t ExecutionModel_IntersectionNV         = 5314;
constexpr uint32_t ExecutionModel_IntersectionKHR        = 5314;
constexpr uint32_t ExecutionModel_AnyHitNV               = 5315;
constexpr uint32_t ExecutionModel_AnyHitKHR              = 5315;
constexpr uint32_t ExecutionModel_ClosestHitNV           = 5316;
constexpr uint32_t ExecutionModel_ClosestHitKHR          = 5316;
constexpr uint32_t ExecutionModel_MissNV                 = 5317;
constexpr uint32_t ExecutionModel_MissKHR                = 5317;
constexpr uint32_t ExecutionModel_CallableNV             = 5318;
constexpr uint32_t ExecutionModel_CallableKHR            = 5318;

// Addressing Model

constexpr uint32_t AddressingModel_Logical                    =    0;
constexpr uint32_t AddressingModel_Physical32                 =    1;
constexpr uint32_t AddressingModel_Physical64                 =    2;
constexpr uint32_t AddressingModel_PhysicalStorageBuffer64    = 5348;
constexpr uint32_t AddressingModel_PhysicalStorageBuffer64EXT = 5348;

// Memory Model

constexpr uint32_t MemoryModel_Simple    = 0;
constexpr uint32_t MemoryModel_GLSL450   = 1;
constexpr uint32_t MemoryModel_OpenCL    = 2;
constexpr uint32_t MemoryModel_Vulkan    = 3;
constexpr uint32_t MemoryModel_VulkanKHR = 3;

// Execution Mode

constexpr uint32_t ExecutionMode_Invocations                      =    0;
constexpr uint32_t ExecutionMode_SpacingEqual                     =    1;
constexpr uint32_t ExecutionMode_SpacingFractionalEven            =    2;
constexpr uint32_t ExecutionMode_SpacingFractionalOdd             =    3;
constexpr uint32_t ExecutionMode_VertexOrderCw                    =    4;
constexpr uint32_t ExecutionMode_VertexOrderCcw                   =    5;
constexpr uint32_t ExecutionMode_PixelCenterInteger               =    6;
constexpr uint32_t ExecutionMode_OriginUpperLeft                  =    7;
constexpr uint32_t ExecutionMode_OriginLowerLeft                  =    8;
constexpr uint32_t ExecutionMode_EarlyFragmentTests               =    9;
constexpr uint32_t ExecutionMode_PointMode                        =   10;
constexpr uint32_t ExecutionMode_Xfb                              =   11;
constexpr uint32_t ExecutionMode_DepthReplacing                   =   12;
constexpr uint32_t ExecutionMode_DepthGreater                     =   14;
constexpr uint32_t ExecutionMode_DepthLess                        =   15;
constexpr uint32_t ExecutionMode_DepthUnchanged                   =   16;
constexpr uint32_t ExecutionMode_LocalSize                        =   17;
constexpr uint32_t ExecutionMode_LocalSizeHint                    =   18;
constexpr uint32_t ExecutionMode_InputPoints                      =   19;
constexpr uint32_t ExecutionMode_InputLines                       =   20;
constexpr uint32_t ExecutionMode_InputLinesAdjacency              =   21;
constexpr uint32_t ExecutionMode_Triangles                        =   22;
constexpr uint32_t ExecutionMode_InputTrianglesAdjacency          =   23;
constexpr uint32_t ExecutionMode_Quads                            =   24;
constexpr uint32_t ExecutionMode_Isolines                         =   25;
constexpr uint32_t ExecutionMode_OutputVertices                   =   26;
constexpr uint32_t ExecutionMode_OutputPoints                     =   27;
constexpr uint32_t ExecutionMode_OutputLineStrip                  =   28;
constexpr uint32_t ExecutionMode_OutputTriangleStrip              =   29;
constexpr uint32_t ExecutionMode_VecTypeHint                      =   30;
constexpr uint32_t ExecutionMode_ContractionOff                   =   31;
constexpr uint32_t ExecutionMode_Initializer                      =   33;
constexpr uint32_t ExecutionMode_Finalizer                        =   34;
constexpr uint32_t ExecutionMode_SubgroupSize                     =   35;
constexpr uint32_t ExecutionMode_SubgroupsPerWorkgroup            =   36;
constexpr uint32_t ExecutionMode_SubgroupsPerWorkgroupId          =   37;
constexpr uint32_t ExecutionMode_LocalSizeId                      =   38;
constexpr uint32_t ExecutionMode_LocalSizeHintId                  =   39;
constexpr uint32_t ExecutionMode_SubgroupUniformControlFlowKHR    = 4421;
constexpr uint32_t ExecutionMode_PostDepthCoverage                = 4446;
constexpr uint32_t ExecutionMode_DenormPreserve                   = 4459;
constexpr uint32_t ExecutionMode_DenormFlushToZero                = 4460;
constexpr uint32_t ExecutionMode_SignedZeroInfNanPreserve         = 4461;
constexpr uint32_t ExecutionMode_RoundingModeRTE                  = 4462;
constexpr uint32_t ExecutionMode_RoundingModeRTZ                  = 4463;
constexpr uint32_t ExecutionMode_EarlyAndLateFragmentTestsAMD     = 5017;
constexpr uint32_t ExecutionMode_StencilRefReplacingEXT           = 5027;
constexpr uint32_t ExecutionMode_StencilRefUnchangedFrontAMD      = 5079;
constexpr uint32_t ExecutionMode_StencilRefGreaterFrontAMD        = 5080;
constexpr uint32_t ExecutionMode_StencilRefLessFrontAMD           = 5081;
constexpr uint32_t ExecutionMode_StencilRefUnchangedBackAMD       = 5082;
constexpr uint32_t ExecutionMode_StencilRefGreaterBackAMD         = 5083;
constexpr uint32_t ExecutionMode_StencilRefLessBackAMD            = 5084;
constexpr uint32_t ExecutionMode_OutputLinesNV                    = 5269;
constexpr uint32_t ExecutionMode_OutputPrimitivesNV               = 5270;
constexpr uint32_t ExecutionMode_DerivativeGroupQuadsNV           = 5289;
constexpr uint32_t ExecutionMode_DerivativeGroupLinearNV          = 5290;
constexpr uint32_t ExecutionMode_OutputTrianglesNV                = 5298;
constexpr uint32_t ExecutionMode_PixelInterlockOrderedEXT         = 5366;
constexpr uint32_t ExecutionMode_PixelInterlockUnorderedEXT       = 5367;
constexpr uint32_t ExecutionMode_SampleInterlockOrderedEXT        = 5368;
constexpr uint32_t ExecutionMode_SampleInterlockUnorderedEXT      = 5369;
constexpr uint32_t ExecutionMode_ShadingRateInterlockOrderedEXT   = 5370;
constexpr uint32_t ExecutionMode_ShadingRateInterlockUnorderedEXT = 5371;
constexpr uint32_t ExecutionMode_SharedLocalMemorySizeINTEL       = 5618;
constexpr uint32_t ExecutionMode_RoundingModeRTPINTEL             = 5620;
constexpr uint32_t ExecutionMode_RoundingModeRTNINTEL             = 5621;
constexpr uint32_t ExecutionMode_FloatingPointModeALTINTEL        = 5622;
constexpr uint32_t ExecutionMode_FloatingPointModeIEEEINTEL       = 5623;
constexpr uint32_t ExecutionMode_MaxWorkgroupSizeINTEL            = 5893;
constexpr uint32_t ExecutionMode_MaxWorkDimINTEL                  = 5894;
constexpr uint32_t ExecutionMode_NoGlobalOffsetINTEL              = 5895;
constexpr uint32_t ExecutionMode_NumSIMDWorkitemsINTEL            = 5896;
constexpr uint32_t ExecutionMode_SchedulerTargetFmaxMhzINTEL      = 5903;
constexpr uint32_t ExecutionMode_NamedBarrierCountINTEL           = 6417;

// Storage Class

constexpr uint32_t StorageClass_UniformConstant          =    0;
constexpr uint32_t StorageClass_Input                    =    1;
constexpr uint32_t StorageClass_Uniform                  =    2;
constexpr uint32_t StorageClass_Output                   =    3;
constexpr uint32_t StorageClass_Workgroup                =    4;
constexpr uint32_t StorageClass_CrossWorkgroup           =    5;
constexpr uint32_t StorageClass_Private                  =    6;
constexpr uint32_t StorageClass_Function                 =    7;
constexpr uint32_t StorageClass_Generic                  =    8;
constexpr uint32_t StorageClass_PushConstant             =    9;
constexpr uint32_t StorageClass_AtomicCounter            =   10;
constexpr uint32_t StorageClass_Image                    =   11;
constexpr uint32_t StorageClass_StorageBuffer            =   12;
constexpr uint32_t StorageClass_CallableDataNV           = 5328;
constexpr uint32_t StorageClass_CallableDataKHR          = 5328;
constexpr uint32_t StorageClass_IncomingCallableDataNV   = 5329;
constexpr uint32_t StorageClass_IncomingCallableDataKHR  = 5329;
constexpr uint32_t StorageClass_RayPayloadNV             = 5338;
constexpr uint32_t StorageClass_RayPayloadKHR            = 5338;
constexpr uint32_t StorageClass_HitAttributeNV           = 5339;
constexpr uint32_t StorageClass_HitAttributeKHR          = 5339;
constexpr uint32_t StorageClass_IncomingRayPayloadNV     = 5342;
constexpr uint32_t StorageClass_IncomingRayPayloadKHR    = 5342;
constexpr uint32_t StorageClass_ShaderRecordBufferNV     = 5343;
constexpr uint32_t StorageClass_ShaderRecordBufferKHR    = 5343;
constexpr uint32_t StorageClass_PhysicalStorageBuffer    = 5349;
constexpr uint32_t StorageClass_PhysicalStorageBufferEXT = 5349;
constexpr uint32_t StorageClass_CodeSectionINTEL         = 5605;
constexpr uint32_t StorageClass_DeviceOnlyINTEL          = 5936;
constexpr uint32_t StorageClass_HostOnlyINTEL            = 5937;

// Dim

constexpr uint32_t Dim_1D          = 0;
constexpr uint32_t Dim_2D          = 1;
constexpr uint32_t Dim_3D          = 2;
constexpr uint32_t Dim_Cube        = 3;
constexpr uint32_t Dim_Rect        = 4;
constexpr uint32_t Dim_Buffer      = 5;
constexpr uint32_t Dim_SubpassData = 6;

// Sampler Addressing Mode

constexpr uint32_t SamplerAddressingMode_None           = 0;
constexpr uint32_t SamplerAddressingMode_ClampToEdge    = 1;
constexpr uint32_t SamplerAddressingMode_Clamp          = 2;
constexpr uint32_t SamplerAddressingMode_Repeat         = 3;
constexpr uint32_t SamplerAddressingMode_RepeatMirrored = 4;

// Sampler Filter Mode

constexpr uint32_t SamplerFilterMode_Nearest = 0;
constexpr uint32_t SamplerFilterMode_Linear  = 1;

// Image Format

constexpr uint32_t ImageFormat_Unknown      =  0;
constexpr uint32_t ImageFormat_Rgba32f      =  1;
constexpr uint32_t ImageFormat_Rgba16f      =  2;
constexpr uint32_t ImageFormat_R32f         =  3;
constexpr uint32_t ImageFormat_Rgba8        =  4;
constexpr uint32_t ImageFormat_Rgba8Snorm   =  5;
constexpr uint32_t ImageFormat_Rg32f        =  6;
constexpr uint32_t ImageFormat_Rg16f        =  7;
constexpr uint32_t ImageFormat_R11fG11fB10f =  8;
constexpr uint32_t ImageFormat_R16f         =  9;
constexpr uint32_t ImageFormat_Rgba16       = 10;
constexpr uint32_t ImageFormat_Rgb10A2      = 11;
constexpr uint32_t ImageFormat_Rg16         = 12;
constexpr uint32_t ImageFormat_Rg8          = 13;
constexpr uint32_t ImageFormat_R16          = 14;
constexpr uint32_t ImageFormat_R8           = 15;
constexpr uint32_t ImageFormat_Rgba16Snorm  = 16;
constexpr uint32_t ImageFormat_Rg16Snorm    = 17;
constexpr uint32_t ImageFormat_Rg8Snorm     = 18;
constexpr uint32_t ImageFormat_R16Snorm     = 19;
constexpr uint32_t ImageFormat_R8Snorm      = 20;
constexpr uint32_t ImageFormat_Rgba32i      = 21;
constexpr uint32_t ImageFormat_Rgba16i      = 22;
constexpr uint32_t ImageFormat_Rgba8i       = 23;
constexpr uint32_t ImageFormat_R32i         = 24;
constexpr uint32_t ImageFormat_Rg32i        = 25;
constexpr uint32_t ImageFormat_Rg16i        = 26;
constexpr uint32_t ImageFormat_Rg8i         = 27;
constexpr uint32_t ImageFormat_R16i         = 28;
constexpr uint32_t ImageFormat_R8i          = 29;
constexpr uint32_t ImageFormat_Rgba32ui     = 30;
constexpr uint32_t ImageFormat_Rgba16ui     = 31;
constexpr uint32_t ImageFormat_Rgba8ui      = 32;
constexpr uint32_t ImageFormat_R32ui        = 33;
constexpr uint32_t ImageFormat_Rgb10a2ui    = 34;
constexpr uint32_t ImageFormat_Rg32ui       = 35;
constexpr uint32_t ImageFormat_Rg16ui       = 36;
constexpr uint32_t ImageFormat_Rg8ui        = 37;
constexpr uint32_t ImageFormat_R16ui        = 38;
constexpr uint32_t ImageFormat_R8ui         = 39;
constexpr uint32_t ImageFormat_R64ui        = 40;
constexpr uint32_t ImageFormat_R64i         = 41;

// Image Channel Order

constexpr uint32_t ImageChannelOrder_R            =  0;
constexpr uint32_t ImageChannelOrder_A            =  1;
constexpr uint32_t ImageChannelOrder_RG           =  2;
constexpr uint32_t ImageChannelOrder_RA           =  3;
constexpr uint32_t ImageChannelOrder_RGB          =  4;
constexpr uint32_t ImageChannelOrder_RGBA         =  5;
constexpr uint32_t ImageChannelOrder_BGRA         =  6;
constexpr uint32_t ImageChannelOrder_ARGB         =  7;
constexpr uint32_t ImageChannelOrder_Intensity    =  8;
constexpr uint32_t ImageChannelOrder_Luminance    =  9;
constexpr uint32_t ImageChannelOrder_Rx           = 10;
constexpr uint32_t ImageChannelOrder_RGx          = 11;
constexpr uint32_t ImageChannelOrder_RGBx         = 12;
constexpr uint32_t ImageChannelOrder_Depth        = 13;
constexpr uint32_t ImageChannelOrder_DepthStencil = 14;
constexpr uint32_t ImageChannelOrder_sRGB         = 15;
constexpr uint32_t ImageChannelOrder_sRGBx        = 16;
constexpr uint32_t ImageChannelOrder_sRGBA        = 17;
constexpr uint32_t ImageChannelOrder_sBGRA        = 18;
constexpr uint32_t ImageChannelOrder_ABGR         = 19;

// Image Channel Data Type

constexpr uint32_t ImageChannelDataType_SnormInt8        =  0;
constexpr uint32_t ImageChannelDataType_SnormInt16       =  1;
constexpr uint32_t ImageChannelDataType_UnormInt8        =  2;
constexpr uint32_t ImageChannelDataType_UnormInt16       =  3;
constexpr uint32_t ImageChannelDataType_UnormShort565    =  4;
constexpr uint32_t ImageChannelDataType_UnormShort555    =  5;
constexpr uint32_t ImageChannelDataType_UnormInt101010   =  6;
constexpr uint32_t ImageChannelDataType_SignedInt8       =  7;
constexpr uint32_t ImageChannelDataType_SignedInt16      =  8;
constexpr uint32_t ImageChannelDataType_SignedInt32      =  9;
constexpr uint32_t ImageChannelDataType_UnsignedInt8     = 10;
constexpr uint32_t ImageChannelDataType_UnsignedInt16    = 11;
constexpr uint32_t ImageChannelDataType_UnsignedInt32    = 12;
constexpr uint32_t ImageChannelDataType_HalfFloat        = 13;
constexpr uint32_t ImageChannelDataType_Float            = 14;
constexpr uint32_t ImageChannelDataType_UnormInt24       = 15;
constexpr uint32_t ImageChannelDataType_UnormInt101010_2 = 16;

// Image Operands

constexpr uint32_t ImageOperands_None                  = 0x00000;
constexpr uint32_t ImageOperands_Bias                  = 0x00001;
constexpr uint32_t ImageOperands_Lod                   = 0x00002;
constexpr uint32_t ImageOperands_Grad                  = 0x00004;
constexpr uint32_t ImageOperands_ConstOffset           = 0x00008;
constexpr uint32_t ImageOperands_Offset                = 0x00010;
constexpr uint32_t ImageOperands_ConstOffsets          = 0x00020;
constexpr uint32_t ImageOperands_Sample                = 0x00040;
constexpr uint32_t ImageOperands_MinLod                = 0x00080;
constexpr uint32_t ImageOperands_MakeTexelAvailable    = 0x00100;
constexpr uint32_t ImageOperands_MakeTexelAvailableKHR = 0x00100;
constexpr uint32_t ImageOperands_MakeTexelVisible      = 0x00200;
constexpr uint32_t ImageOperands_MakeTexelVisibleKHR   = 0x00200;
constexpr uint32_t ImageOperands_NonPrivateTexel       = 0x00400;
constexpr uint32_t ImageOperands_NonPrivateTexelKHR    = 0x00400;
constexpr uint32_t ImageOperands_VolatileTexel         = 0x00800;
constexpr uint32_t ImageOperands_VolatileTexelKHR      = 0x00800;
constexpr uint32_t ImageOperands_SignExtend            = 0x01000;
constexpr uint32_t ImageOperands_ZeroExtend            = 0x02000;
constexpr uint32_t ImageOperands_Nontemporal           = 0x04000;
constexpr uint32_t ImageOperands_Offsets               = 0x10000;

// FP Fast Math Mode

constexpr uint32_t FPFastMathMode_None                   = 0x00000;
constexpr uint32_t FPFastMathMode_NotNaN                 = 0x00001;
constexpr uint32_t FPFastMathMode_NotInf                 = 0x00002;
constexpr uint32_t FPFastMathMode_NSZ                    = 0x00004;
constexpr uint32_t FPFastMathMode_AllowRecip             = 0x00008;
constexpr uint32_t FPFastMathMode_Fast                   = 0x00010;
constexpr uint32_t FPFastMathMode_AllowContractFastINTEL = 0x10000;
constexpr uint32_t FPFastMathMode_AllowReassocINTEL      = 0x20000;

// FP Rounding Mode

constexpr uint32_t FPRoundingMode_RTE = 0;
constexpr uint32_t FPRoundingMode_RTZ = 1;
constexpr uint32_t FPRoundingMode_RTP = 2;
constexpr uint32_t FPRoundingMode_RTN = 3;

// Linkage Type

constexpr uint32_t LinkageType_Export      = 0;
constexpr uint32_t LinkageType_Import      = 1;
constexpr uint32_t LinkageType_LinkOnceODR = 2;

// Access Qualifier

constexpr uint32_t AccessQualifier_ReadOnly  = 0;
constexpr uint32_t AccessQualifier_WriteOnly = 1;
constexpr uint32_t AccessQualifier_ReadWrite = 2;

// Function Parameter Attribute

constexpr uint32_t FunctionParameterAttribute_Zext        = 0;
constexpr uint32_t FunctionParameterAttribute_Sext        = 1;
constexpr uint32_t FunctionParameterAttribute_ByVal       = 2;
constexpr uint32_t FunctionParameterAttribute_Sret        = 3;
constexpr uint32_t FunctionParameterAttribute_NoAlias     = 4;
constexpr uint32_t FunctionParameterAttribute_NoCapture   = 5;
constexpr uint32_t FunctionParameterAttribute_NoWrite     = 6;
constexpr uint32_t FunctionParameterAttribute_NoReadWrite = 7;

// Decoration

constexpr uint32_t Decoration_RelaxedPrecision                   =    0;
constexpr uint32_t Decoration_SpecId                             =    1;
constexpr uint32_t Decoration_Block                              =    2;
constexpr uint32_t Decoration_BufferBlock                        =    3;
constexpr uint32_t Decoration_RowMajor                           =    4;
constexpr uint32_t Decoration_ColMajor                           =    5;
constexpr uint32_t Decoration_ArrayStride                        =    6;
constexpr uint32_t Decoration_MatrixStride                       =    7;
constexpr uint32_t Decoration_GLSLShared                         =    8;
constexpr uint32_t Decoration_GLSLPacked                         =    9;
constexpr uint32_t Decoration_CPacked                            =   10;
constexpr uint32_t Decoration_BuiltIn                            =   11;
constexpr uint32_t Decoration_NoPerspective                      =   13;
constexpr uint32_t Decoration_Flat                               =   14;
constexpr uint32_t Decoration_Patch                              =   15;
constexpr uint32_t Decoration_Centroid                           =   16;
constexpr uint32_t Decoration_Sample                             =   17;
constexpr uint32_t Decoration_Invariant                          =   18;
constexpr uint32_t Decoration_Restrict                           =   19;
constexpr uint32_t Decoration_Aliased                            =   20;
constexpr uint32_t Decoration_Volatile                           =   21;
constexpr uint32_t Decoration_Constant                           =   22;
constexpr uint32_t Decoration_Coherent                           =   23;
constexpr uint32_t Decoration_NonWritable                        =   24;
constexpr uint32_t Decoration_NonReadable                        =   25;
constexpr uint32_t Decoration_Uniform                            =   26;
constexpr uint32_t Decoration_UniformId                          =   27;
constexpr uint32_t Decoration_SaturatedConversion                =   28;
constexpr uint32_t Decoration_Stream                             =   29;
constexpr uint32_t Decoration_Location                           =   30;
constexpr uint32_t Decoration_Component                          =   31;
constexpr uint32_t Decoration_Index                              =   32;
constexpr uint32_t Decoration_Binding                            =   33;
constexpr uint32_t Decoration_DescriptorSet                      =   34;
constexpr uint32_t Decoration_Offset                             =   35;
constexpr uint32_t Decoration_XfbBuffer                          =   36;
constexpr uint32_t Decoration_XfbStride                          =   37;
constexpr uint32_t Decoration_FuncParamAttr                      =   38;
constexpr uint32_t Decoration_FPRoundingMode                     =   39;
constexpr uint32_t Decoration_FPFastMode                         =   40;
constexpr uint32_t Decoration_LinkageAttributes                  =   41;
constexpr uint32_t Decoration_NoContraction                      =   42;
constexpr uint32_t Decoration_InputAttachmentIndex               =   43;
constexpr uint32_t Decoration_Alignment                          =   44;
constexpr uint32_t Decoration_MaxByteOffset                      =   45;
constexpr uint32_t Decoration_AlignmentId                        =   46;
constexpr uint32_t Decoration_MaxByteOffsetId                    =   47;
constexpr uint32_t Decoration_NoSignedWrap                       = 4469;
constexpr uint32_t Decoration_NoUnsignedWrap                     = 4470;
constexpr uint32_t Decoration_ExplicitInterpAMD                  = 4999;
constexpr uint32_t Decoration_OverrideCoverageNV                 = 5248;
constexpr uint32_t Decoration_PassthroughNV                      = 5250;
constexpr uint32_t Decoration_ViewportRelativeNV                 = 5252;
constexpr uint32_t Decoration_SecondaryViewportRelativeNV        = 5256;
constexpr uint32_t Decoration_PerPrimitiveNV                     = 5271;
constexpr uint32_t Decoration_PerViewNV                          = 5272;
constexpr uint32_t Decoration_PerTaskNV                          = 5273;
constexpr uint32_t Decoration_PerVertexKHR                       = 5285;
constexpr uint32_t Decoration_PerVertexNV                        = 5285;
constexpr uint32_t Decoration_NonUniform                         = 5300;
constexpr uint32_t Decoration_NonUniformEXT                      = 5300;
constexpr uint32_t Decoration_RestrictPointer                    = 5355;
constexpr uint32_t Decoration_RestrictPointerEXT                 = 5355;
constexpr uint32_t Decoration_AliasedPointer                     = 5356;
constexpr uint32_t Decoration_AliasedPointerEXT                  = 5356;
constexpr uint32_t Decoration_BindlessSamplerNV                  = 5398;
constexpr uint32_t Decoration_BindlessImageNV                    = 5399;
constexpr uint32_t Decoration_BoundSamplerNV                     = 5400;
constexpr uint32_t Decoration_BoundImageNV                       = 5401;
constexpr uint32_t Decoration_SIMTCallINTEL                      = 5599;
constexpr uint32_t Decoration_ReferencedIndirectlyINTEL          = 5602;
constexpr uint32_t Decoration_ClobberINTEL                       = 5607;
constexpr uint32_t Decoration_SideEffectsINTEL                   = 5608;
constexpr uint32_t Decoration_VectorComputeVariableINTEL         = 5624;
constexpr uint32_t Decoration_FuncParamIOKindINTEL               = 5625;
constexpr uint32_t Decoration_VectorComputeFunctionINTEL         = 5626;
constexpr uint32_t Decoration_StackCallINTEL                     = 5627;
constexpr uint32_t Decoration_GlobalVariableOffsetINTEL          = 5628;
constexpr uint32_t Decoration_CounterBuffer                      = 5634;
constexpr uint32_t Decoration_HlslCounterBufferGOOGLE            = 5634;
constexpr uint32_t Decoration_UserSemantic                       = 5635;
constexpr uint32_t Decoration_HlslSemanticGOOGLE                 = 5635;
constexpr uint32_t Decoration_UserTypeGOOGLE                     = 5636;
constexpr uint32_t Decoration_FunctionRoundingModeINTEL          = 5822;
constexpr uint32_t Decoration_FunctionDenormModeINTEL            = 5823;
constexpr uint32_t Decoration_RegisterINTEL                      = 5825;
constexpr uint32_t Decoration_MemoryINTEL                        = 5826;
constexpr uint32_t Decoration_NumbanksINTEL                      = 5827;
constexpr uint32_t Decoration_BankwidthINTEL                     = 5828;
constexpr uint32_t Decoration_MaxPrivateCopiesINTEL              = 5829;
constexpr uint32_t Decoration_SinglepumpINTEL                    = 5830;
constexpr uint32_t Decoration_DoublepumpINTEL                    = 5831;
constexpr uint32_t Decoration_MaxReplicatesINTEL                 = 5832;
constexpr uint32_t Decoration_SimpleDualPortINTEL                = 5833;
constexpr uint32_t Decoration_MergeINTEL                         = 5834;
constexpr uint32_t Decoration_BankBitsINTEL                      = 5835;
constexpr uint32_t Decoration_ForcePow2DepthINTEL                = 5836;
constexpr uint32_t Decoration_BurstCoalescelINTEL                = 5899;
constexpr uint32_t Decoration_CacheSizeINTEL                     = 5900;
constexpr uint32_t Decoration_DontStaticallyCoalescelINTEL       = 5901;
constexpr uint32_t Decoration_PrefetchINTEL                      = 5902;
constexpr uint32_t Decoration_StallEnableINTEL                   = 5905;
constexpr uint32_t Decoration_FuseLoopsInFunctionINTEL           = 5907;
constexpr uint32_t Decoration_AliasScopeINTEL                    = 5914;
constexpr uint32_t Decoration_NoAliasINTEL                       = 5915;
constexpr uint32_t Decoration_BufferLocationINTEL                = 5921;
constexpr uint32_t Decoration_IOPipeStorageINTEL                 = 5944;
constexpr uint32_t Decoration_FunctionFloatingPointModeINTEL     = 6080;
constexpr uint32_t Decoration_SingleElementVectorINTEL           = 6085;
constexpr uint32_t Decoration_VectorComputeCallableFunctionINTEL = 6087;
constexpr uint32_t Decoration_MediaBlockIOINTEL                  = 6140;

// BuiltIn

constexpr uint32_t BuiltIn_Position                    =    0;
constexpr uint32_t BuiltIn_PointSize                   =    1;
constexpr uint32_t BuiltIn_ClipDistance                =    3;
constexpr uint32_t BuiltIn_CullDistance                =    4;
constexpr uint32_t BuiltIn_VertexId                    =    5;
constexpr uint32_t BuiltIn_InstanceId                  =    6;
constexpr uint32_t BuiltIn_PrimitiveId                 =    7;
constexpr uint32_t BuiltIn_InvocationId                =    8;
constexpr uint32_t BuiltIn_Layer                       =    9;
constexpr uint32_t BuiltIn_ViewportIndex               =   10;
constexpr uint32_t BuiltIn_TessLevelOuter              =   11;
constexpr uint32_t BuiltIn_TessLevelInner              =   12;
constexpr uint32_t BuiltIn_TessCoord                   =   13;
constexpr uint32_t BuiltIn_PatchVertices               =   14;
constexpr uint32_t BuiltIn_FragCoord                   =   15;
constexpr uint32_t BuiltIn_PointCoord                  =   16;
constexpr uint32_t BuiltIn_FrontFacing                 =   17;
constexpr uint32_t BuiltIn_SampleId                    =   18;
constexpr uint32_t BuiltIn_SamplePosition              =   19;
constexpr uint32_t BuiltIn_SampleMask                  =   20;
constexpr uint32_t BuiltIn_FragDepth                   =   22;
constexpr uint32_t BuiltIn_HelperInvocation            =   23;
constexpr uint32_t BuiltIn_NumWorkgroups               =   24;
constexpr uint32_t BuiltIn_WorkgroupSize               =   25;
constexpr uint32_t BuiltIn_WorkgroupId                 =   26;
constexpr uint32_t BuiltIn_LocalInvocationId           =   27;
constexpr uint32_t BuiltIn_GlobalInvocationId          =   28;
constexpr uint32_t BuiltIn_LocalInvocationIndex        =   29;
constexpr uint32_t BuiltIn_WorkDim                     =   30;
constexpr uint32_t BuiltIn_GlobalSize                  =   31;
constexpr uint32_t BuiltIn_EnqueuedWorkgroupSize       =   32;
constexpr uint32_t BuiltIn_GlobalOffset                =   33;
constexpr uint32_t BuiltIn_GlobalLinearId              =   34;
constexpr uint32_t BuiltIn_SubgroupSize                =   36;
constexpr uint32_t BuiltIn_SubgroupMaxSize             =   37;
constexpr uint32_t BuiltIn_NumSubgroups                =   38;
constexpr uint32_t BuiltIn_NumEnqueuedSubgroups        =   39;
constexpr uint32_t BuiltIn_SubgroupId                  =   40;
constexpr uint32_t BuiltIn_SubgroupLocalInvocationId   =   41;
constexpr uint32_t BuiltIn_VertexIndex                 =   42;
constexpr uint32_t BuiltIn_InstanceIndex               =   43;
constexpr uint32_t BuiltIn_SubgroupEqMask              = 4416;
constexpr uint32_t BuiltIn_SubgroupEqMaskKHR           = 4416;
constexpr uint32_t BuiltIn_SubgroupGeMask              = 4417;
constexpr uint32_t BuiltIn_SubgroupGeMaskKHR           = 4417;
constexpr uint32_t BuiltIn_SubgroupGtMask              = 4418;
constexpr uint32_t BuiltIn_SubgroupGtMaskKHR           = 4418;
constexpr uint32_t BuiltIn_SubgroupLeMask              = 4419;
constexpr uint32_t BuiltIn_SubgroupLeMaskKHR           = 4419;
constexpr uint32_t BuiltIn_SubgroupLtMask              = 4420;
constexpr uint32_t BuiltIn_SubgroupLtMaskKHR           = 4420;
constexpr uint32_t BuiltIn_BaseVertex                  = 4424;
constexpr uint32_t BuiltIn_BaseInstance                = 4425;
constexpr uint32_t BuiltIn_DrawIndex                   = 4426;
constexpr uint32_t BuiltIn_PrimitiveShadingRateKHR     = 4432;
constexpr uint32_t BuiltIn_DeviceIndex                 = 4438;
constexpr uint32_t BuiltIn_ViewIndex                   = 4440;
constexpr uint32_t BuiltIn_ShadingRateKHR              = 4444;
constexpr uint32_t BuiltIn_BaryCoordNoPerspAMD         = 4992;
constexpr uint32_t BuiltIn_BaryCoordNoPerspCentroidAMD = 4993;
constexpr uint32_t BuiltIn_BaryCoordNoPerspSampleAMD   = 4994;
constexpr uint32_t BuiltIn_BaryCoordSmoothAMD          = 4995;
constexpr uint32_t BuiltIn_BaryCoordSmoothCentroidAMD  = 4996;
constexpr uint32_t BuiltIn_BaryCoordSmoothSampleAMD    = 4997;
constexpr uint32_t BuiltIn_BaryCoordPullModelAMD       = 4998;
constexpr uint32_t BuiltIn_FragStencilRefEXT           = 5014;
constexpr uint32_t BuiltIn_ViewportMaskNV              = 5253;
constexpr uint32_t BuiltIn_SecondaryPositionNV         = 5257;
constexpr uint32_t BuiltIn_SecondaryViewportMaskNV     = 5258;
constexpr uint32_t BuiltIn_PositionPerViewNV           = 5261;
constexpr uint32_t BuiltIn_ViewportMaskPerViewNV       = 5262;
constexpr uint32_t BuiltIn_FullyCoveredEXT             = 5264;
constexpr uint32_t BuiltIn_TaskCountNV                 = 5274;
constexpr uint32_t BuiltIn_PrimitiveCountNV            = 5275;
constexpr uint32_t BuiltIn_PrimitiveIndicesNV          = 5276;
constexpr uint32_t BuiltIn_ClipDistancePerViewNV       = 5277;
constexpr uint32_t BuiltIn_CullDistancePerViewNV       = 5278;
constexpr uint32_t BuiltIn_LayerPerViewNV              = 5279;
constexpr uint32_t BuiltIn_MeshViewCountNV             = 5280;
constexpr uint32_t BuiltIn_MeshViewIndicesNV           = 5281;
constexpr uint32_t BuiltIn_BaryCoordKHR                = 5286;
constexpr uint32_t BuiltIn_BaryCoordNV                 = 5286;
constexpr uint32_t BuiltIn_BaryCoordNoPerspKHR         = 5287;
constexpr uint32_t BuiltIn_BaryCoordNoPerspNV          = 5287;
constexpr uint32_t BuiltIn_FragSizeEXT                 = 5292;
constexpr uint32_t BuiltIn_FragmentSizeNV              = 5292;
constexpr uint32_t BuiltIn_FragInvocationCountEXT      = 5293;
constexpr uint32_t BuiltIn_InvocationsPerPixelNV       = 5293;
constexpr uint32_t BuiltIn_LaunchIdNV                  = 5319;
constexpr uint32_t BuiltIn_LaunchIdKHR                 = 5319;
constexpr uint32_t BuiltIn_LaunchSizeNV                = 5320;
constexpr uint32_t BuiltIn_LaunchSizeKHR               = 5320;
constexpr uint32_t BuiltIn_WorldRayOriginNV            = 5321;
constexpr uint32_t BuiltIn_WorldRayOriginKHR           = 5321;
constexpr uint32_t BuiltIn_WorldRayDirectionNV         = 5322;
constexpr uint32_t BuiltIn_WorldRayDirectionKHR        = 5322;
constexpr uint32_t BuiltIn_ObjectRayOriginNV           = 5323;
constexpr uint32_t BuiltIn_ObjectRayOriginKHR          = 5323;
constexpr uint32_t BuiltIn_ObjectRayDirectionNV        = 5324;
constexpr uint32_t BuiltIn_ObjectrayDirectionKHR       = 5324;
constexpr uint32_t BuiltIn_RayTminNV                   = 5325;
constexpr uint32_t BuiltIn_RayTminKHR                  = 5325;
constexpr uint32_t BuiltIn_RayTmaxNV                   = 5326;
constexpr uint32_t BuiltIn_RayTmaxKHR                  = 5326;
constexpr uint32_t BuiltIn_InstanceCustomIndexNV       = 5327;
constexpr uint32_t BuiltIn_InstanceCustomIndexKHR      = 5327;
constexpr uint32_t BuiltIn_ObjectToWorldNV             = 5330;
constexpr uint32_t BuiltIn_ObjectToWorldKHR            = 5330;
constexpr uint32_t BuiltIn_WorldToObjectNV             = 5331;
constexpr uint32_t BuiltIn_WorldToObjectKHR            = 5331;
constexpr uint32_t BuiltIn_HitTNV                      = 5332;
constexpr uint32_t BuiltIn_HitKindNV                   = 5333;
constexpr uint32_t BuiltIn_HitKindKHR                  = 5333;
constexpr uint32_t BuiltIn_CurrentRayTimeNV            = 5334;
constexpr uint32_t BuiltIn_IncomingRayFlagsNV          = 5351;
constexpr uint32_t BuiltIn_IncomingRayFlagsKHR         = 5351;
constexpr uint32_t BuiltIn_RayGeometryIndexKHR         = 5352;
constexpr uint32_t BuiltIn_WarpsPerSMNV                = 5374;
constexpr uint32_t BuiltIn_SMCountNV                   = 5375;
constexpr uint32_t BuiltIn_WarpIDNV                    = 5376;
constexpr uint32_t BuiltIn_SMIDNV                      = 5377;
constexpr uint32_t BuiltIn_CullMaskKHR                 = 6021;

// Selection Control

constexpr uint32_t SelectionControl_None        = 0x0;
constexpr uint32_t SelectionControl_Flatten     = 0x1;
constexpr uint32_t SelectionControl_DontFlatten = 0x2;

// Loop Control

constexpr uint32_t LoopControl_None                      = 0x000000;
constexpr uint32_t LoopControl_Unroll                    = 0x000001;
constexpr uint32_t LoopControl_DontUnroll                = 0x000002;
constexpr uint32_t LoopControl_DependencyInfinite        = 0x000004;
constexpr uint32_t LoopControl_DependencyLength          = 0x000008;
constexpr uint32_t LoopControl_MinIterations             = 0x000010;
constexpr uint32_t LoopControl_MaxIterations             = 0x000020;
constexpr uint32_t LoopControl_IterationMultiple         = 0x000040;
constexpr uint32_t LoopControl_PeelCount                 = 0x000080;
constexpr uint32_t LoopControl_PartialCount              = 0x000100;
constexpr uint32_t LoopControl_InitiationIntervalINTEL   = 0x010000;
constexpr uint32_t LoopControl_MaxConcurrencyINTEL       = 0x020000;
constexpr uint32_t LoopControl_DependencyArrayINTEL      = 0x040000;
constexpr uint32_t LoopControl_PipelineEnableINTEL       = 0x080000;
constexpr uint32_t LoopControl_LoopCoalesceINTEL         = 0x100000;
constexpr uint32_t LoopControl_MaxInterleavingINTEL      = 0x200000;
constexpr uint32_t LoopControl_SpeculatedIterationsINTEL = 0x400000;
constexpr uint32_t LoopControl_NoFusionINTEL             = 0x800000;

// Function Control

constexpr uint32_t FunctionControl_None         = 0x00000;
constexpr uint32_t FunctionControl_Inline       = 0x00001;
constexpr uint32_t FunctionControl_DontInline   = 0x00002;
constexpr uint32_t FunctionControl_Pure         = 0x00004;
constexpr uint32_t FunctionControl_Const        = 0x00008;
constexpr uint32_t FunctionControl_OptNoneINTEL = 0x10000;

// Memory Semantics

constexpr uint32_t MemorySemantics_None                   = 0x0000;
constexpr uint32_t MemorySemantics_Relaxed                = 0x0000;
constexpr uint32_t MemorySemantics_Acquire                = 0x0002;
constexpr uint32_t MemorySemantics_Release                = 0x0004;
constexpr uint32_t MemorySemantics_AcquireRelease         = 0x0008;
constexpr uint32_t MemorySemantics_SequentiallyConsistent = 0x0010;
constexpr uint32_t MemorySemantics_UniformMemory          = 0x0040;
constexpr uint32_t MemorySemantics_SubgroupMemory         = 0x0080;
constexpr uint32_t MemorySemantics_WorkgroupMemory        = 0x0100;
constexpr uint32_t MemorySemantics_CrossWorkgroupMemory   = 0x0200;
constexpr uint32_t MemorySemantics_AtomicCounterMemory    = 0x0400;
constexpr uint32_t MemorySemantics_IamgeMemory            = 0x0800;
constexpr uint32_t MemorySemantics_OutputMemory           = 0x1000;
constexpr uint32_t MemorySemantics_OutputMemoryKHR        = 0x1000;
constexpr uint32_t MemorySemantics_MakeAvailable          = 0x2000;
constexpr uint32_t MemorySemantics_MakeAvailableKHR       = 0x2000;
constexpr uint32_t MemorySemantics_MakeVisible            = 0x4000;
constexpr uint32_t MemorySemantics_MakeVisibleKHR         = 0x4000;
constexpr uint32_t MemorySemantics_Volatile               = 0x8000;

// Memory Operands

constexpr uint32_t MemoryOperands_None                    = 0x00000;
constexpr uint32_t MemoryOperands_Volatile                = 0x00001;
constexpr uint32_t MemoryOperands_Aligned                 = 0x00002;
constexpr uint32_t MemoryOperands_Nontemporal             = 0x00004;
constexpr uint32_t MemoryOperands_MakePointerAvailable    = 0x00008;
constexpr uint32_t MemoryOperands_MakePointerAvailableKHR = 0x00008;
constexpr uint32_t MemoryOperands_MakePointerVisible      = 0x00010;
constexpr uint32_t MemoryOperands_MakePointerVisibleKHR   = 0x00010;
constexpr uint32_t MemoryOperands_NonPrivatePointer       = 0x00020;
constexpr uint32_t MemoryOperands_NonPrivatePointerKHR    = 0x00030;
constexpr uint32_t MemoryOperands_AliasScopeINTELMask     = 0x10000;
constexpr uint32_t MemoryOperands_NoAliasINTELMask        = 0x20000;

// Scope

constexpr uint32_t Scope_CrossDevice   = 0;
constexpr uint32_t Scope_Device        = 1;
constexpr uint32_t Scope_Workgroup     = 2;
constexpr uint32_t Scope_Subgroup      = 3;
constexpr uint32_t Scope_Invocation    = 4;
constexpr uint32_t Scope_QueueFamily   = 5;
constexpr uint32_t Scope_ShaderCallKHR = 6;

// Group Operation

constexpr uint32_t GroupOperation_Reduce                     = 0;
constexpr uint32_t GroupOperation_InclusiveScan              = 1;
constexpr uint32_t GroupOperation_ExclusiveScan              = 2;
constexpr uint32_t GroupOperation_ClusteredReduce            = 3;
constexpr uint32_t GroupOperation_PartitionedReduceNV        = 6;
constexpr uint32_t GroupOperation_PartitionedInclusiveScanNV = 7;
constexpr uint32_t GroupOperation_PartitionedExclusiveScanNV = 8;

// Kernel Enqueue Flags

constexpr uint32_t KernelEnqueueFlags_NoWait        = 0;
constexpr uint32_t KernelEnqueueFlags_WaitKernel    = 1;
constexpr uint32_t KernelEnqueueFlags_WaitWorkGroup = 2;

// Kernel Profiling Info

constexpr uint32_t KernelProfilingInfo_None        = 0x0;
constexpr uint32_t KernelProfilingInfo_CmdExecTime = 0x1;

// Capability

constexpr uint32_t Capability_Matrix                                       =    0;
constexpr uint32_t Capability_Shader                                       =    1;
constexpr uint32_t Capability_Geometry                                     =    2;
constexpr uint32_t Capability_Tessellation                                 =    3;
constexpr uint32_t Capability_Addresses                                    =    4;
constexpr uint32_t Capability_Linkage                                      =    5;
constexpr uint32_t Capability_Kernel                                       =    6;
constexpr uint32_t Capability_Vector16                                     =    7;
constexpr uint32_t Capability_Float16Buffer                                =    8;
constexpr uint32_t Capability_Float16                                      =    9;
constexpr uint32_t Capability_Float64                                      =   10;
constexpr uint32_t Capability_Int64                                        =   11;
constexpr uint32_t Capability_Int64Atomics                                 =   12;
constexpr uint32_t Capability_ImageBasic                                   =   13;
constexpr uint32_t Capability_ImageReadWrite                               =   14;
constexpr uint32_t Capability_ImageMipmap                                  =   15;
constexpr uint32_t Capability_Pipes                                        =   17;
constexpr uint32_t Capability_Groups                                       =   18;
constexpr uint32_t Capability_DeviceEnqueue                                =   19;
constexpr uint32_t Capability_LiteralSampler                               =   20;
constexpr uint32_t Capability_AtomicStorage                                =   21;
constexpr uint32_t Capability_Int16                                        =   22;
constexpr uint32_t Capability_TessellationPointSize                        =   23;
constexpr uint32_t Capability_GeometryPointSize                            =   24;
constexpr uint32_t Capability_ImageGatherExtended                          =   25;
constexpr uint32_t Capability_SorageImageMultisample                       =   27;
constexpr uint32_t Capability_UniformBufferArrayDynamicIndexingBlock       =   28;
constexpr uint32_t Capability_SampledImageArrayDynamicIndexing             =   29;
constexpr uint32_t Capability_StorageBufferArrayDynamicIndexing            =   30;
constexpr uint32_t Capability_StorageImageArrayDynamicIndexing             =   31;
constexpr uint32_t Capability_ClipDistance                                 =   32;
constexpr uint32_t Capability_CullDistance                                 =   33;
constexpr uint32_t Capability_ImageCubeArray                               =   34;
constexpr uint32_t Capability_SampleRateShading                            =   35;
constexpr uint32_t Capability_ImageRect                                    =   36;
constexpr uint32_t Capability_SampledRect                                  =   37;
constexpr uint32_t Capability_GenericPointer                               =   38;
constexpr uint32_t Capability_Int8                                         =   39;
constexpr uint32_t Capability_InputAttachment                              =   40;
constexpr uint32_t Capability_SparseResidency                              =   41;
constexpr uint32_t Capability_MinLod                                       =   42;
constexpr uint32_t Capability_Sampled1D                                    =   43;
constexpr uint32_t Capability_Image1D                                      =   44;
constexpr uint32_t Capability_SampledCubeArray                             =   45;
constexpr uint32_t Capability_SampledBuffer                                =   46;
constexpr uint32_t Capability_ImageBuffer                                  =   47;
constexpr uint32_t Capability_ImageMSArray                                 =   48;
constexpr uint32_t Capability_StorageImageExtendedFormats                  =   49;
constexpr uint32_t Capability_ImageQuery                                   =   50;
constexpr uint32_t Capability_DerivativeControl                            =   51;
constexpr uint32_t Capability_InterpolationFunction                        =   52;
constexpr uint32_t Capability_TransformFeedback                            =   53;
constexpr uint32_t Capability_GeometryStreams                              =   54;
constexpr uint32_t Capability_StorageImageReadWithoutFormat                =   55;
constexpr uint32_t Capability_StorageImageWriteWithoutFormat               =   56;
constexpr uint32_t Capability_MultiViewport                                =   57;
constexpr uint32_t Capability_SubgroupDispatch                             =   58;
constexpr uint32_t Capability_NamedBarrier                                 =   59;
constexpr uint32_t Capability_PipeStorage                                  =   60;
constexpr uint32_t Capability_GroupNonUniform                              =   61;
constexpr uint32_t Capability_GroupNonUniformVote                          =   62;
constexpr uint32_t Capability_GroupNonUniformArithmetic                    =   63;
constexpr uint32_t Capability_GroupNonUniformBallot                        =   64;
constexpr uint32_t Capability_GroupNonUniformShuffle                       =   65;
constexpr uint32_t Capability_GroupNonUniformShuffleRelative               =   66;
constexpr uint32_t Capability_GroupNonUniformClustered                     =   67;
constexpr uint32_t Capability_GroupNonUniformQuad                          =   68;
constexpr uint32_t Capability_ShaderLayer                                  =   69;
constexpr uint32_t Capability_ShaderViewportIndex                          =   70;
constexpr uint32_t Capability_UniformDecoration                            =   71;
constexpr uint32_t Capability_FragmentShadingRateKHR                       = 4422;
constexpr uint32_t Capability_SubgroupBallotKHR                            = 4423;
constexpr uint32_t Capability_DrawParameters                               = 4427;
constexpr uint32_t Capability_WorkgroupMemoryExplicitLayoutKHR             = 4428;
constexpr uint32_t Capability_WorkgroupMemoryExplicitLayout8BitAccessKHR   = 4429;
constexpr uint32_t Capability_WorkgroupMemoryExplicitLayout16BitAccessKHR  = 4430;
constexpr uint32_t Capability_SubgroupVoteKHR                              = 4431;
constexpr uint32_t Capability_StorageBuffer16BitAccess                     = 4433;
constexpr uint32_t Capability_StorageUniformBufferBlock16                  = 4433;
constexpr uint32_t Capability_UniformAndStorageBuffer16BitAccess           = 4434;
constexpr uint32_t Capability_StorageUniform16                             = 4434;
constexpr uint32_t Capability_StoragePushConstant16                        = 4435;
constexpr uint32_t Capability_StorageInputOutput16                         = 4436;
constexpr uint32_t Capability_DeviceGroup                                  = 4437;
constexpr uint32_t Capability_MultiView                                    = 4439;
constexpr uint32_t Capability_VariablePointersStorageBuffer                = 4441;
constexpr uint32_t Capability_VariablePointers                             = 4442;
constexpr uint32_t Capability_AtomicStorageOps                             = 4445;
constexpr uint32_t Capability_SampleMaskPostDepthCoverage                  = 4447;
constexpr uint32_t Capability_StorageBuffer8BitAccess                      = 4448;
constexpr uint32_t Capability_UniformAndStorageBuffer8BitAccess            = 4449;
constexpr uint32_t Capability_StoragePushConstant8                         = 4450;
constexpr uint32_t Capability_DenormPreserve                               = 4464;
constexpr uint32_t Capability_DenormFlushToZero                            = 4465;
constexpr uint32_t Capability_SignedZeroInfNanPreserve                     = 4466;
constexpr uint32_t Capability_RoundingModeRTE                              = 4467;
constexpr uint32_t Capability_RoundingModeRTZ                              = 4468;
constexpr uint32_t Capability_RayQueryProvisionalKHR                       = 4471;
constexpr uint32_t Capability_RayQueryKHR                                  = 4472;
constexpr uint32_t Capability_RayTraversalPrimitiveCullingKHR              = 4478;
constexpr uint32_t Capability_RayTracingKHR                                = 4479;
constexpr uint32_t Capability_Float16ImageAMD                              = 5008;
constexpr uint32_t Capability_ImageGatherBiasLodAMD                        = 5009;
constexpr uint32_t Capability_FragmentMaskAMD                              = 5010;
constexpr uint32_t Capability_StencilExportEXT                             = 5013;
constexpr uint32_t Capability_ImageReadWriteLodAMD                         = 5015;
constexpr uint32_t Capability_Int64ImageEXT                                = 5016;
constexpr uint32_t Capability_ShaderClockKHR                               = 5055;
constexpr uint32_t Capability_SampleMaskOverrideCoverageNV                 = 5249;
constexpr uint32_t Capability_GeometryShaderPassthroughNV                  = 5251;
constexpr uint32_t Capability_ShaderViewportIndexLayerEXT                  = 5254;
constexpr uint32_t Capability_ShaderViewportIndexLayerNV                   = 5254;
constexpr uint32_t Capability_ShaderViewportMaskNV                         = 5255;
constexpr uint32_t Capability_ShaderStereoViewNV                           = 5259;
constexpr uint32_t Capability_PerViewAttributesNV                          = 5260;
constexpr uint32_t Capability_FragmentFullyCoveredEXT                      = 5265;
constexpr uint32_t Capability_MeshShadingNV                                = 5266;
constexpr uint32_t Capability_ImageFootprintNV                             = 5282;
constexpr uint32_t Capability_FragmentBarycentricKHR                       = 5284;
constexpr uint32_t Capability_FragmentBarycentricNV                        = 5284;
constexpr uint32_t Capability_ComputeDerivativeGroupQuadsNV                = 5288;
constexpr uint32_t Capability_FragmentDensityEXT                           = 5291;
constexpr uint32_t Capability_ShadingRateNV                                = 5291;
constexpr uint32_t Capability_GroupNonUniformPartitionedNV                 = 5297;
constexpr uint32_t Capability_ShaderNonUniform                             = 5301;
constexpr uint32_t Capability_ShaderNonUniformEXT                          = 5301;
constexpr uint32_t Capability_RuntimeDescriptorArray                       = 5302;
constexpr uint32_t Capability_RuntimeDescriptorArrayEXT                    = 5302;
constexpr uint32_t Capability_InputAttachmentArrayDynamicIndexing          = 5303;
constexpr uint32_t Capability_InputAttachmentArrayDynamicIndexingEXT       = 5303;
constexpr uint32_t Capability_UniformTexelBufferArrayDynamicIndexing       = 5304;
constexpr uint32_t Capability_UniformTexelBufferArrayDynamicIndexingEXT    = 5304;
constexpr uint32_t Capability_StorageTexelBufferArrayDynamicIndexing       = 5305;
constexpr uint32_t Capability_StorageTexelBufferArrayDynamicIndexingEXT    = 5305;
constexpr uint32_t Capability_UniformBufferArrayNonUniformIndexingBlock    = 5306;
constexpr uint32_t Capability_UniformBufferArrayNonUniformIndexingEXT      = 5306;
constexpr uint32_t Capability_SampledImageArrayNonUniformIndexing          = 5307;
constexpr uint32_t Capability_SampledImageArrayNonUniformIndexingEXT       = 5307;
constexpr uint32_t Capability_StorageBufferArrayNonUniformIndexing         = 5308;
constexpr uint32_t Capability_StorageBufferArrayNonUniformIndexingEXT      = 5308;
constexpr uint32_t Capability_StorageImageArrayNonUniformIndexing          = 5309;
constexpr uint32_t Capability_StorageImageArrayNonUniformIndexingEXT       = 5309;
constexpr uint32_t Capability_InputAttachmentArrayNonUniformIndexing       = 5310;
constexpr uint32_t Capability_InputAttachmentArrayNonUniformIndexingEXT    = 5310;
constexpr uint32_t Capability_UniformTexelBufferArrayNonUniformIndexing    = 5311;
constexpr uint32_t Capability_UniformTexelBufferArrayNonUniformIndexingEXT = 5311;
constexpr uint32_t Capability_StorageTexelBufferArrayNonUniformIndexing    = 5312;
constexpr uint32_t Capability_StorageTexelBufferArrayNonUniformIndexingEXT = 5312;
constexpr uint32_t Capability_RayTracingNV                                 = 5340;
constexpr uint32_t Capability_RayTracingMotionBlurNV                       = 5341;
constexpr uint32_t Capability_VulkanMemoryModel                            = 5345;
constexpr uint32_t Capability_VulkanMemoryModelKHR                         = 5345;
constexpr uint32_t Capability_VulkanMemoryModelDeviceScope                 = 5346;
constexpr uint32_t Capability_VulkanMemoryModelDeviceScopeKHR              = 5346;
constexpr uint32_t Capability_PhysicalStorageBufferAddresses               = 5347;
constexpr uint32_t Capability_PhysicalStorageBufferAddressesEXT            = 5347;
constexpr uint32_t Capability_ComputeDerivativeGroupLinearNV               = 5350;
constexpr uint32_t Capability_RayTracingProvisionalKHR                     = 5353;
constexpr uint32_t Capability_CooperativeMatrixNV                          = 5357;
constexpr uint32_t Capability_FragmentShaderSampleInterlockEXT             = 5363;
constexpr uint32_t Capability_FragmentShaderShadingRateInterlockEXT        = 5372;
constexpr uint32_t Capability_ShaderSMBuiltinsNV                           = 5373;
constexpr uint32_t Capability_FragmentShaderPixelInterlockEXT              = 5378;
constexpr uint32_t Capability_DemoteToHelperInvocation                     = 5379;
constexpr uint32_t Capability_DemoteToHelperInvocationEXT                  = 5379;
constexpr uint32_t Capability_BindlessTextureNV                            = 5390;
constexpr uint32_t Capability_SubgroupShuffleINTEL                         = 5568;
constexpr uint32_t Capability_SubgroupBufferBlockIOINTEL                   = 5569;
constexpr uint32_t Capability_SubgroupImageBlockIOINTEL                    = 5570;
constexpr uint32_t Capability_SubgroupImageMediaBlockIOINTEL               = 5579;
constexpr uint32_t Capability_RoundToInfinityINTEL                         = 5582;
constexpr uint32_t Capability_FloatingPointModeINTEL                       = 5583;
constexpr uint32_t Capability_IntegerFunctions2INTEL                       = 5584;
constexpr uint32_t Capability_FunctionPointersINTEL                        = 5603;
constexpr uint32_t Capability_IndirectReferencesINTEL                      = 5604;
constexpr uint32_t Capability_AsmINTEL                                     = 5606;
constexpr uint32_t Capability_AtomicFloat32MinMaxEXT                       = 5612;
constexpr uint32_t Capability_AtomicFloat64MinMaxEXT                       = 5613;
constexpr uint32_t Capability_AtomicFloat16MinMaxEXT                       = 5616;
constexpr uint32_t Capability_VectorComputeINTEL                           = 5617;
constexpr uint32_t Capability_VectorAnyINTEL                               = 5619;
constexpr uint32_t Capability_ExpectAssumeKHR                              = 5629;
constexpr uint32_t Capability_SubgroupAvcMotionEstimationINTEL             = 5696;
constexpr uint32_t Capability_SubgroupAvcMotionEstimationIntralINTEL       = 5697;
constexpr uint32_t Capability_SubgroupAvcMotionEstimationChromaINTEL       = 5698;
constexpr uint32_t Capability_VariableLengthArrayINTEL                     = 5817;
constexpr uint32_t Capability_FunctionFloatControlINTEL                    = 5821;
constexpr uint32_t Capability_FPGAMemoryAttributesINTEL                    = 5824;
constexpr uint32_t Capability_FPFastMathModeINTEL                          = 5837;
constexpr uint32_t Capability_ArbitraryPrecisionIntegersINTEL              = 5844;
constexpr uint32_t Capability_ArbitraryPrecisionFloatingPointINTEL         = 5845;
constexpr uint32_t Capability_UnstructuredLoopControlsINTEL                = 5886;
constexpr uint32_t Capability_FPGALoopControlsINTEL                        = 5888;
constexpr uint32_t Capability_KernelAttributesINTEL                        = 5892;
constexpr uint32_t Capability_FPGAKernelAttributesINTEL                    = 5897;
constexpr uint32_t Capability_FPGAMemoryAccessesINTEL                      = 5898;
constexpr uint32_t Capability_FPGAClusterAttributesINTEL                   = 5904;
constexpr uint32_t Capability_LoopFuseINTEL                                = 5906;
constexpr uint32_t Capability_MemoryAccessAliasingINTEL                    = 5910;
constexpr uint32_t Capability_FPGABufferLocationINTEL                      = 5920;
constexpr uint32_t Capability_ArbitraryPrecisionFixedPointINTEL            = 5922;
constexpr uint32_t Capability_USMStorageClassesINTEL                       = 5935;
constexpr uint32_t Capability_IOPipesINTEL                                 = 5943;
constexpr uint32_t Capability_BlockingPipesINTEL                           = 5945;
constexpr uint32_t Capability_FPGARegINTEL                                 = 5948;
constexpr uint32_t Capability_DotProductInputAll                           = 6016;
constexpr uint32_t Capability_DotProductInputAllKHR                        = 6016;
constexpr uint32_t Capability_DotProductInput4x8Bit                        = 6017;
constexpr uint32_t Capability_DotProductInput4x8BitKHR                     = 6017;
constexpr uint32_t Capability_DotProductInput4x8BitPacked                  = 6018;
constexpr uint32_t Capability_DotProductInput4x8BitPackedKHR               = 6018;
constexpr uint32_t Capability_DotProduct                                   = 6019;
constexpr uint32_t Capability_DotProductKHR                                = 6019;
constexpr uint32_t Capability_RayCullMaskKHR                               = 6020;
constexpr uint32_t Capability_BitInstructions                              = 6025;
constexpr uint32_t Capability_GroupNonUniformRotateKHR                     = 6026;
constexpr uint32_t Capability_AtomicFloat32AddEXT                          = 6033;
constexpr uint32_t Capability_AtomicFloat64AddEXT                          = 6034;
constexpr uint32_t Capability_LongConstantCompositeINTEL                   = 6089;
constexpr uint32_t Capability_OptNoneINTEL                                 = 6094;
constexpr uint32_t Capability_AtomicFloat16AddEXT                          = 6095;
constexpr uint32_t Capability_DebugInfoModuleINTEL                         = 6114;
constexpr uint32_t Capability_SplitBarrierINTEL                            = 6141;
constexpr uint32_t Capability_GroupUniformArithmeticKHR                    = 6400;

// Reserved Ray Flags

constexpr uint32_t ReservedRayFlags_None                        = 0x000;
constexpr uint32_t ReservedRayFlags_OpaqueKHR                   = 0x001;
constexpr uint32_t ReservedRayFlags_NoOpaqueKHR                 = 0x002;
constexpr uint32_t ReservedRayFlags_TerminateOnFirstHitKHR      = 0x004;
constexpr uint32_t ReservedRayFlags_SkipClosestHitShaderKHR     = 0x008;
constexpr uint32_t ReservedRayFlags_CullBackFacingTrianglesKHR  = 0x010;
constexpr uint32_t ReservedRayFlags_CullFrontFacingTrianglesKHR = 0x020;
constexpr uint32_t ReservedRayFlags_CullOpaqueKHR               = 0x040;
constexpr uint32_t ReservedRayFlags_CullNoOpqueKHR              = 0x080;
constexpr uint32_t ReservedRayFlags_SkipTrianglesKHR            = 0x100;
constexpr uint32_t ReservedRayFlags_SkipAABBsKHR                = 0x200;

// Reserved Ray Query Intersection

constexpr uint32_t ReservedRayQueryIntersection_RayQueryCandidateIntersectionKHR = 0;
constexpr uint32_t ReservedRayQueryIntersection_RayQueryCommittedIntersectionKHR = 1;

// Reserved Ray Query Committed Type

constexpr uint32_t ReservedRayQueryCommittedType_RayQueryCommittedIntersectionNoneKHR      = 0;
constexpr uint32_t ReservedRayQueryCommittedType_RayQueryCommittedIntersectionTriangleKHR  = 1;
constexpr uint32_t ReservedRayQueryCommittedType_RayQueryCommittedIntersectionGeneratedKHR = 2;

// Reserved Ray Query Candidate Type

constexpr uint32_t ReservedRayQueryCandidateType_RayQueryCandidateIntersectionTriangleKHR = 0;
constexpr uint32_t ReservedRayQueryCandidateType_RayQueryCandidateIntersectionAABBKHR     = 1;

// Reserved Fragment Shading Rate

constexpr uint32_t ReservedFragmentShadingRate_None              = 0x0;
constexpr uint32_t ReservedFragmentShadingRate_Vertical2Pixels   = 0x1;
constexpr uint32_t ReservedFragmentShadingRate_Vertical4Pixels   = 0x2;
constexpr uint32_t ReservedFragmentShadingRate_Horizontal2Pixels = 0x4;
constexpr uint32_t ReservedFragmentShadingRate_Horizontal4Pixels = 0x8;

// Reserved FP Denorm Mode

constexpr uint32_t ReservedFPDenormMode_Preserve    = 0;
constexpr uint32_t ReservedFPDenormMode_FlushToZero = 1;

// Reserved FP Operation Mode

constexpr uint32_t ReservedFPOperationMode_IEEE = 0;
constexpr uint32_t ReservedFPOperationMode_ALT  = 1;

// Quantization Mode

constexpr uint32_t QuantizationMode_TRN          = 0;
constexpr uint32_t QuantizationMode_TRN_ZERO     = 1;
constexpr uint32_t QuantizationMode_RND          = 2;
constexpr uint32_t QuantizationMode_RND_ZERO     = 3;
constexpr uint32_t QuantizationMode_RND_INF      = 4;
constexpr uint32_t QuantizationMode_RND_MIN_INF  = 5;
constexpr uint32_t QuantizationMode_RND_CONV     = 6;
constexpr uint32_t QuantizationMode_RND_CONV_ODD = 7;

// Overflow Mode

constexpr uint32_t OverflowMode_WRAP     = 0;
constexpr uint32_t OverflowMode_SAT      = 1;
constexpr uint32_t OverflowMode_SAT_ZERO = 2;
constexpr uint32_t OverflowMode_SAT_SYM  = 3;

// Packed Vector Format

constexpr uint32_t PackedVectorFormat4x8Bit    = 0;
constexpr uint32_t PackedVectorFormat4x8BitKHR = 0;
