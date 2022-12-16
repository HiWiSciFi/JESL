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

// TODO

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

// TODO

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
