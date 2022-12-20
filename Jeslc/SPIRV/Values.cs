namespace Jeslc
{
	public static partial class SPIRV
	{
		public const UInt32 Magic = 0x07230203;

		public enum SourceLanguage : UInt32
		{
			Unknown        = 0,
			ESSL           = 1,
			GLSL           = 2,
			OpenCL_C       = 3,
			OpenCL_CPP     = 4,
			HLSL           = 5,
			CPP_for_OpenCL = 6,
			SYCL           = 7
		}

		public enum ExecutionModel : UInt32
		{
			Vertex                 =    0,
			TessellationControl    =    1,
			TessellationEvaluation =    2,
			Geometry               =    3,
			Fragment               =    4,
			GLCompute              =    5,
			Kernel                 =    6,
			TaskNV                 = 5267,
			MeshNV                 = 5268,
			RayGenerationNV        = 5313,
			RayGenerationKHR       = 5313,
			IntersectionNV         = 5314,
			IntersectionKHR        = 5314,
			AnyHitNV               = 5315,
			AnyHitKHR              = 5315,
			ClosestHitNV           = 5316,
			ClosestHitKHR          = 5316,
			MissNV                 = 5317,
			MissKHR                = 5317,
			CallableNV             = 5318,
			CallableKHR            = 5318
		}

		public enum AddressingModel : UInt32
		{
			Logical                    =    0,
			Physical32                 =    1,
			Physical64                 =    2,
			PhysicalStorageBuffer64    = 5348,
			PhysicalStorageBuffer64EXT = 5348
		}

		public enum MemoryModel : UInt32
		{
			Simple    = 0,
			GLSL450   = 1,
			OpenCL    = 2,
			Vulkan    = 3,
			VulkanKHR = 3
		}

		public enum ExecutionMode : UInt32
		{
			Invocations                      =    0,
			SpacingEqual                     =    1,
			SpacingFractionalEven            =    2,
			SpacingFractionalOdd             =    3,
			VertexOrderCw                    =    4,
			VertexOrderCcw                   =    5,
			PixelCenterInteger               =    6,
			OriginUpperLeft                  =    7,
			OriginLowerLeft                  =    8,
			EarlyFragmentTests               =    9,
			PointMode                        =   10,
			Xfb                              =   11,
			DepthReplacing                   =   12,
			DepthGreater                     =   14,
			DepthLess                        =   15,
			DepthUnchanged                   =   16,
			LocalSize                        =   17,
			LocalSizeHint                    =   18,
			InputPoints                      =   19,
			InputLines                       =   20,
			InputLinesAdjacency              =   21,
			Triangles                        =   22,
			InputTrianglesAdjacency          =   23,
			Quads                            =   24,
			Isolines                         =   25,
			OutputVertices                   =   26,
			OutputPoints                     =   27,
			OutputLineStrip                  =   28,
			OutputTriangleStrip              =   29,
			VecTypeHint                      =   30,
			ContractionOff                   =   31,
			Initializer                      =   33,
			Finalizer                        =   34,
			SubgroupSize                     =   35,
			SubgroupsPerWorkgroup            =   36,
			SubgroupsPerWorkgroupId          =   37,
			LocalSizeId                      =   38,
			LocalSizeHintId                  =   39,
			SubgroupUniformControlFlowKHR    = 4421,
			PostDepthCoverage                = 4446,
			DenormPreserve                   = 4459,
			DenormFlushToZero                = 4460,
			SignedZeroInfNanPreserve         = 4461,
			RoundingModeRTE                  = 4462,
			RoundingModeRTZ                  = 4463,
			EarlyAndLateFragmentTestsAMD     = 5017,
			StencilRefReplacingEXT           = 5027,
			StencilRefUnchangedFrontAMD      = 5079,
			StencilRefGreaterFrontAMD        = 5080,
			StencilRefLessFrontAMD           = 5081,
			StencilRefUnchangedBackAMD       = 5082,
			StencilRefGreaterBackAMD         = 5083,
			StencilRefLessBackAMD            = 5084,
			OutputLinesNV                    = 5269,
			OutputPrimitivesNV               = 5270,
			DerivativeGroupQuadsNV           = 5289,
			DerivativeGroupLinearNV          = 5290,
			OutputTrianglesNV                = 5298,
			PixelInterlockOrderedEXT         = 5366,
			PixelInterlockUnorderedEXT       = 5367,
			SampleInterlockOrderedEXT        = 5368,
			SampleInterlockUnorderedEXT      = 5369,
			ShadingRateInterlockOrderedEXT   = 5370,
			ShadingRateInterlockUnorderedEXT = 5371,
			SharedLocalMemorySizeINTEL       = 5618,
			RoundingModeRTPINTEL             = 5620,
			RoundingModeRTNINTEL             = 5621,
			FloatingPointModeALTINTEL        = 5622,
			FloatingPointModeIEEEINTEL       = 5623,
			MaxWorkgroupSizeINTEL            = 5893,
			MaxWorkDimINTEL                  = 5894,
			NoGlobalOffsetINTEL              = 5895,
			NumSIMDWorkitemsINTEL            = 5896,
			SchedulerTargetFmaxMhzINTEL      = 5903,
			NamedBarrierCountINTEL           = 6417
		}



		public enum StorageClass : UInt32
		{
			UniformConstant          =    0,
			Input                    =    1,
			Uniform                  =    2,
			Output                   =    3,
			Workgroup                =    4,
			CrossWorkgroup           =    5,
			Private                  =    6,
			Function                 =    7,
			Generic                  =    8,
			PushConstant             =    9,
			AtomicCounter            =   10,
			Image                    =   11,
			StorageBuffer            =   12,
			CallableDataNV           = 5328,
			CallableDataKHR          = 5328,
			IncomingCallableDataNV   = 5329,
			IncomingCallableDataKHR  = 5329,
			RayPayloadNV             = 5338,
			RayPayloadKHR            = 5338,
			HitAttributeNV           = 5339,
			HitAttributeKHR          = 5339,
			IncomingRayPayloadNV     = 5342,
			IncomingRayPayloadKHR    = 5342,
			ShaderRecordBufferNV     = 5343,
			ShaderRecordBufferKHR    = 5343,
			PhysicalStorageBuffer    = 5349,
			PhysicalStorageBufferEXT = 5349,
			CodeSectionINTEL         = 5605,
			DeviceOnlyINTEL          = 5936,
			HostOnlyINTEL            = 5937
		}

		public enum Dim : UInt32
		{
			_1D          = 0,
			_2D          = 1,
			_3D          = 2,
			Cube         = 3,
			Rect         = 4,
			Buffer       = 5,
			SubpassData  = 6
		}

		public enum SamplerAddressingMode : UInt32
		{
			None           = 0,
			ClampToEdge    = 1,
			Clamp          = 2,
			Repeat         = 3,
			RepeatMirrored = 4
		}

		public enum SamplerFilterMode : UInt32
		{
			Nearest = 0,
			Linear  = 1
		}

		public enum ImageFormat : UInt32
		{
			Unknown      =  0,
			Rgba32f      =  1,
			Rgba16f      =  2,
			R32f         =  3,
			Rgba8        =  4,
			Rgba8Snorm   =  5,
			Rg32f        =  6,
			Rg16f        =  7,
			R11fG11fB10f =  8,
			R16f         =  9,
			Rgba16       = 10,
			Rgb10A2      = 11,
			Rg16         = 12,
			Rg8          = 13,
			R16          = 14,
			R8           = 15,
			Rgba16Snorm  = 16,
			Rg16Snorm    = 17,
			Rg8Snorm     = 18,
			R16Snorm     = 19,
			R8Snorm      = 20,
			Rgba32i      = 21,
			Rgba16i      = 22,
			Rgba8i       = 23,
			R32i         = 24,
			Rg32i        = 25,
			Rg16i        = 26,
			Rg8i         = 27,
			R16i         = 28,
			R8i          = 29,
			Rgba32ui     = 30,
			Rgba16ui     = 31,
			Rgba8ui      = 32,
			R32ui        = 33,
			Rgb10a2ui    = 34,
			Rg32ui       = 35,
			Rg16ui       = 36,
			Rg8ui        = 37,
			R16ui        = 38,
			R8ui         = 39,
			R64ui        = 40,
			R64i         = 41
		}

		public enum ImageChannelOrder : UInt32
		{
			R            =  0,
			A            =  1,
			RG           =  2,
			RA           =  3,
			RGB          =  4,
			RGBA         =  5,
			BGRA         =  6,
			ARGB         =  7,
			Intensity    =  8,
			Luminance    =  9,
			Rx           = 10,
			RGx          = 11,
			RGBx         = 12,
			Depth        = 13,
			DepthStencil = 14,
			sRGB         = 15,
			sRGBx        = 16,
			sRGBA        = 17,
			sBGRA        = 18,
			ABGR         = 19
		}

		public enum ImageChannelDataType : UInt32
		{
			SnormInt8        =  0,
			SnormInt16       =  1,
			UnormInt8        =  2,
			UnormInt16       =  3,
			UnormShort565    =  4,
			UnormShort555    =  5,
			UnormInt101010   =  6,
			SignedInt8       =  7,
			SignedInt16      =  8,
			SignedInt32      =  9,
			UnsignedInt8     = 10,
			UnsignedInt16    = 11,
			UnsignedInt32    = 12,
			HalfFloat        = 13,
			Float            = 14,
			UnormInt24       = 15,
			UnormInt101010_2 = 16
		}

		public enum ImageOperands : UInt32
		{
			None                  = 0x00000,
			Bias                  = 0x00001,
			Lod                   = 0x00002,
			Grad                  = 0x00004,
			ConstOffset           = 0x00008,
			Offset                = 0x00010,
			ConstOffsets          = 0x00020,
			Sample                = 0x00040,
			MinLod                = 0x00080,
			MakeTexelAvailable    = 0x00100,
			MakeTexelAvailableKHR = 0x00100,
			MakeTexelVisible      = 0x00200,
			MakeTexelVisibleKHR   = 0x00200,
			NonPrivateTexel       = 0x00400,
			NonPrivateTexelKHR    = 0x00400,
			VolatileTexel         = 0x00800,
			VolatileTexelKHR      = 0x00800,
			SignExtend            = 0x01000,
			ZeroExtend            = 0x02000,
			Nontemporal           = 0x04000,
			Offsets               = 0x10000
		}

		public enum FPFastMathMode : UInt32
		{
			None                   = 0x00000,
			NotNaN                 = 0x00001,
			NotInf                 = 0x00002,
			NSZ                    = 0x00004,
			AllowRecip             = 0x00008,
			Fast                   = 0x00010,
			AllowContractFastINTEL = 0x10000,
			AllowReassocINTEL      = 0x20000
		}

		public enum FPRoundingMode : UInt32
		{
			RTE = 0,
			RTZ = 1,
			RTP = 2,
			RTN = 3
		}

		public enum LinkageType : UInt32
		{
			Export      = 0,
			Import      = 1,
			LinkOnceODR = 2
		}

		public enum AccessQualifier : UInt32
		{
			ReadOnly  = 0,
			WriteOnly = 1,
			ReadWrite = 2
		}

		public enum FunctionParameterAttribute : UInt32
		{
			Zext        = 0,
			Sext        = 1,
			ByVal       = 2,
			Sret        = 3,
			NoAlias     = 4,
			NoCapture   = 5,
			NoWrite     = 6,
			NoReadWrite = 7
		}

		public enum Decoration : UInt32
		{
			RelaxedPrecision                   =    0,
			SpecId                             =    1,
			Block                              =    2,
			BufferBlock                        =    3,
			RowMajor                           =    4,
			ColMajor                           =    5,
			ArrayStride                        =    6,
			MatrixStride                       =    7,
			GLSLShared                         =    8,
			GLSLPacked                         =    9,
			CPacked                            =   10,
			BuiltIn                            =   11,
			NoPerspective                      =   13,
			Flat                               =   14,
			Patch                              =   15,
			Centroid                           =   16,
			Sample                             =   17,
			Invariant                          =   18,
			Restrict                           =   19,
			Aliased                            =   20,
			Volatile                           =   21,
			Constant                           =   22,
			Coherent                           =   23,
			NonWritable                        =   24,
			NonReadable                        =   25,
			Uniform                            =   26,
			UniformId                          =   27,
			SaturatedConversion                =   28,
			Stream                             =   29,
			Location                           =   30,
			Component                          =   31,
			Index                              =   32,
			Binding                            =   33,
			DescriptorSet                      =   34,
			Offset                             =   35,
			XfbBuffer                          =   36,
			XfbStride                          =   37,
			FuncParamAttr                      =   38,
			FPRoundingMode                     =   39,
			FPFastMode                         =   40,
			LinkageAttributes                  =   41,
			NoContraction                      =   42,
			InputAttachmentIndex               =   43,
			Alignment                          =   44,
			MaxByteOffset                      =   45,
			AlignmentId                        =   46,
			MaxByteOffsetId                    =   47,
			NoSignedWrap                       = 4469,
			NoUnsignedWrap                     = 4470,
			ExplicitInterpAMD                  = 4999,
			OverrideCoverageNV                 = 5248,
			PassthroughNV                      = 5250,
			ViewportRelativeNV                 = 5252,
			SecondaryViewportRelativeNV        = 5256,
			PerPrimitiveNV                     = 5271,
			PerViewNV                          = 5272,
			PerTaskNV                          = 5273,
			PerVertexKHR                       = 5285,
			PerVertexNV                        = 5285,
			NonUniform                         = 5300,
			NonUniformEXT                      = 5300,
			RestrictPointer                    = 5355,
			RestrictPointerEXT                 = 5355,
			AliasedPointer                     = 5356,
			AliasedPointerEXT                  = 5356,
			BindlessSamplerNV                  = 5398,
			BindlessImageNV                    = 5399,
			BoundSamplerNV                     = 5400,
			BoundImageNV                       = 5401,
			SIMTCallINTEL                      = 5599,
			ReferencedIndirectlyINTEL          = 5602,
			ClobberINTEL                       = 5607,
			SideEffectsINTEL                   = 5608,
			VectorComputeVariableINTEL         = 5624,
			FuncParamIOKindINTEL               = 5625,
			VectorComputeFunctionINTEL         = 5626,
			StackCallINTEL                     = 5627,
			GlobalVariableOffsetINTEL          = 5628,
			CounterBuffer                      = 5634,
			HlslCounterBufferGOOGLE            = 5634,
			UserSemantic                       = 5635,
			HlslSemanticGOOGLE                 = 5635,
			UserTypeGOOGLE                     = 5636,
			FunctionRoundingModeINTEL          = 5822,
			FunctionDenormModeINTEL            = 5823,
			RegisterINTEL                      = 5825,
			MemoryINTEL                        = 5826,
			NumbanksINTEL                      = 5827,
			BankwidthINTEL                     = 5828,
			MaxPrivateCopiesINTEL              = 5829,
			SinglepumpINTEL                    = 5830,
			DoublepumpINTEL                    = 5831,
			MaxReplicatesINTEL                 = 5832,
			SimpleDualPortINTEL                = 5833,
			MergeINTEL                         = 5834,
			BankBitsINTEL                      = 5835,
			ForcePow2DepthINTEL                = 5836,
			BurstCoalescelINTEL                = 5899,
			CacheSizeINTEL                     = 5900,
			DontStaticallyCoalescelINTEL       = 5901,
			PrefetchINTEL                      = 5902,
			StallEnableINTEL                   = 5905,
			FuseLoopsInFunctionINTEL           = 5907,
			AliasScopeINTEL                    = 5914,
			NoAliasINTEL                       = 5915,
			BufferLocationINTEL                = 5921,
			IOPipeStorageINTEL                 = 5944,
			FunctionFloatingPointModeINTEL     = 6080,
			SingleElementVectorINTEL           = 6085,
			VectorComputeCallableFunctionINTEL = 6087,
			MediaBlockIOINTEL                  = 6140
		}

		public enum BuiltIn : UInt32
		{
			Position                    =    0,
			PointSize                   =    1,
			ClipDistance                =    3,
			CullDistance                =    4,
			VertexId                    =    5,
			InstanceId                  =    6,
			PrimitiveId                 =    7,
			InvocationId                =    8,
			Layer                       =    9,
			ViewportIndex               =   10,
			TessLevelOuter              =   11,
			TessLevelInner              =   12,
			TessCoord                   =   13,
			PatchVertices               =   14,
			FragCoord                   =   15,
			PointCoord                  =   16,
			FrontFacing                 =   17,
			SampleId                    =   18,
			SamplePosition              =   19,
			SampleMask                  =   20,
			FragDepth                   =   22,
			HelperInvocation            =   23,
			NumWorkgroups               =   24,
			WorkgroupSize               =   25,
			WorkgroupId                 =   26,
			LocalInvocationId           =   27,
			GlobalInvocationId          =   28,
			LocalInvocationIndex        =   29,
			WorkDim                     =   30,
			GlobalSize                  =   31,
			EnqueuedWorkgroupSize       =   32,
			GlobalOffset                =   33,
			GlobalLinearId              =   34,
			SubgroupSize                =   36,
			SubgroupMaxSize             =   37,
			NumSubgroups                =   38,
			NumEnqueuedSubgroups        =   39,
			SubgroupId                  =   40,
			SubgroupLocalInvocationId   =   41,
			VertexIndex                 =   42,
			InstanceIndex               =   43,
			SubgroupEqMask              = 4416,
			SubgroupEqMaskKHR           = 4416,
			SubgroupGeMask              = 4417,
			SubgroupGeMaskKHR           = 4417,
			SubgroupGtMask              = 4418,
			SubgroupGtMaskKHR           = 4418,
			SubgroupLeMask              = 4419,
			SubgroupLeMaskKHR           = 4419,
			SubgroupLtMask              = 4420,
			SubgroupLtMaskKHR           = 4420,
			BaseVertex                  = 4424,
			BaseInstance                = 4425,
			DrawIndex                   = 4426,
			PrimitiveShadingRateKHR     = 4432,
			DeviceIndex                 = 4438,
			ViewIndex                   = 4440,
			ShadingRateKHR              = 4444,
			BaryCoordNoPerspAMD         = 4992,
			BaryCoordNoPerspCentroidAMD = 4993,
			BaryCoordNoPerspSampleAMD   = 4994,
			BaryCoordSmoothAMD          = 4995,
			BaryCoordSmoothCentroidAMD  = 4996,
			BaryCoordSmoothSampleAMD    = 4997,
			BaryCoordPullModelAMD       = 4998,
			FragStencilRefEXT           = 5014,
			ViewportMaskNV              = 5253,
			SecondaryPositionNV         = 5257,
			SecondaryViewportMaskNV     = 5258,
			PositionPerViewNV           = 5261,
			ViewportMaskPerViewNV       = 5262,
			FullyCoveredEXT             = 5264,
			TaskCountNV                 = 5274,
			PrimitiveCountNV            = 5275,
			PrimitiveIndicesNV          = 5276,
			ClipDistancePerViewNV       = 5277,
			CullDistancePerViewNV       = 5278,
			LayerPerViewNV              = 5279,
			MeshViewCountNV             = 5280,
			MeshViewIndicesNV           = 5281,
			BaryCoordKHR                = 5286,
			BaryCoordNV                 = 5286,
			BaryCoordNoPerspKHR         = 5287,
			BaryCoordNoPerspNV          = 5287,
			FragSizeEXT                 = 5292,
			FragmentSizeNV              = 5292,
			FragInvocationCountEXT      = 5293,
			InvocationsPerPixelNV       = 5293,
			LaunchIdNV                  = 5319,
			LaunchIdKHR                 = 5319,
			LaunchSizeNV                = 5320,
			LaunchSizeKHR               = 5320,
			WorldRayOriginNV            = 5321,
			WorldRayOriginKHR           = 5321,
			WorldRayDirectionNV         = 5322,
			WorldRayDirectionKHR        = 5322,
			ObjectRayOriginNV           = 5323,
			ObjectRayOriginKHR          = 5323,
			ObjectRayDirectionNV        = 5324,
			ObjectrayDirectionKHR       = 5324,
			RayTminNV                   = 5325,
			RayTminKHR                  = 5325,
			RayTmaxNV                   = 5326,
			RayTmaxKHR                  = 5326,
			InstanceCustomIndexNV       = 5327,
			InstanceCustomIndexKHR      = 5327,
			ObjectToWorldNV             = 5330,
			ObjectToWorldKHR            = 5330,
			WorldToObjectNV             = 5331,
			WorldToObjectKHR            = 5331,
			HitTNV                      = 5332,
			HitKindNV                   = 5333,
			HitKindKHR                  = 5333,
			CurrentRayTimeNV            = 5334,
			IncomingRayFlagsNV          = 5351,
			IncomingRayFlagsKHR         = 5351,
			RayGeometryIndexKHR         = 5352,
			WarpsPerSMNV                = 5374,
			SMCountNV                   = 5375,
			WarpIDNV                    = 5376,
			SMIDNV                      = 5377,
			CullMaskKHR                 = 6021
		}

		public enum SelectionControl : UInt32
		{
			None        = 0x0,
			Flatten     = 0x1,
			DontFlatten = 0x2
		}

		public enum LoopControl : UInt32
		{
			None                      = 0x000000,
			Unroll                    = 0x000001,
			DontUnroll                = 0x000002,
			DependencyInfinite        = 0x000004,
			DependencyLength          = 0x000008,
			MinIterations             = 0x000010,
			MaxIterations             = 0x000020,
			IterationMultiple         = 0x000040,
			PeelCount                 = 0x000080,
			PartialCount              = 0x000100,
			InitiationIntervalINTEL   = 0x010000,
			MaxConcurrencyINTEL       = 0x020000,
			DependencyArrayINTEL      = 0x040000,
			PipelineEnableINTEL       = 0x080000,
			LoopCoalesceINTEL         = 0x100000,
			MaxInterleavingINTEL      = 0x200000,
			SpeculatedIterationsINTEL = 0x400000,
			NoFusionINTEL             = 0x800000
		}

		public enum FunctionControl : UInt32
		{
			None         = 0x00000,
			Inline       = 0x00001,
			DontInline   = 0x00002,
			Pure         = 0x00004,
			Const        = 0x00008,
			OptNoneINTEL = 0x10000
		}

		public enum MemorySemantics : UInt32
		{
			None                   = 0x0000,
			Relaxed                = 0x0000,
			Acquire                = 0x0002,
			Release                = 0x0004,
			AcquireRelease         = 0x0008,
			SequentiallyConsistent = 0x0010,
			UniformMemory          = 0x0040,
			SubgroupMemory         = 0x0080,
			WorkgroupMemory        = 0x0100,
			CrossWorkgroupMemory   = 0x0200,
			AtomicCounterMemory    = 0x0400,
			IamgeMemory            = 0x0800,
			OutputMemory           = 0x1000,
			OutputMemoryKHR        = 0x1000,
			MakeAvailable          = 0x2000,
			MakeAvailableKHR       = 0x2000,
			MakeVisible            = 0x4000,
			MakeVisibleKHR         = 0x4000,
			Volatile               = 0x8000
		}

		public enum MemoryOperands : UInt32
		{
			None                    = 0x00000,
			Volatile                = 0x00001,
			Aligned                 = 0x00002,
			Nontemporal             = 0x00004,
			MakePointerAvailable    = 0x00008,
			MakePointerAvailableKHR = 0x00008,
			MakePointerVisible      = 0x00010,
			MakePointerVisibleKHR   = 0x00010,
			NonPrivatePointer       = 0x00020,
			NonPrivatePointerKHR    = 0x00030,
			AliasScopeINTELMask     = 0x10000,
			NoAliasINTELMask        = 0x20000
		}

		public enum Scope : UInt32
		{
			CrossDevice   = 0,
			Device        = 1,
			Workgroup     = 2,
			Subgroup      = 3,
			Invocation    = 4,
			QueueFamily   = 5,
			ShaderCallKHR = 6
		}

		public enum GroupOperation : UInt32
		{
			Reduce                     = 0,
			InclusiveScan              = 1,
			ExclusiveScan              = 2,
			ClusteredReduce            = 3,
			PartitionedReduceNV        = 6,
			PartitionedInclusiveScanNV = 7,
			PartitionedExclusiveScanNV = 8
		}

		public enum KernelEnqueueFlags : UInt32
		{
			NoWait        = 0,
			WaitKernel    = 1,
			WaitWorkGroup = 2
		}

		public enum KernelProfilingInfo : UInt32
		{
			None        = 0x0,
			CmdExecTime = 0x1
		}

		public enum Capability : UInt32
		{
			Matrix                                       =    0,
			Shader                                       =    1,
			Geometry                                     =    2,
			Tessellation                                 =    3,
			Addresses                                    =    4,
			Linkage                                      =    5,
			Kernel                                       =    6,
			Vector16                                     =    7,
			Float16Buffer                                =    8,
			Float16                                      =    9,
			Float64                                      =   10,
			Int64                                        =   11,
			Int64Atomics                                 =   12,
			ImageBasic                                   =   13,
			ImageReadWrite                               =   14,
			ImageMipmap                                  =   15,
			Pipes                                        =   17,
			Groups                                       =   18,
			DeviceEnqueue                                =   19,
			LiteralSampler                               =   20,
			AtomicStorage                                =   21,
			Int16                                        =   22,
			TessellationPointSize                        =   23,
			GeometryPointSize                            =   24,
			ImageGatherExtended                          =   25,
			SorageImageMultisample                       =   27,
			UniformBufferArrayDynamicIndexingBlock       =   28,
			SampledImageArrayDynamicIndexing             =   29,
			StorageBufferArrayDynamicIndexing            =   30,
			StorageImageArrayDynamicIndexing             =   31,
			ClipDistance                                 =   32,
			CullDistance                                 =   33,
			ImageCubeArray                               =   34,
			SampleRateShading                            =   35,
			ImageRect                                    =   36,
			SampledRect                                  =   37,
			GenericPointer                               =   38,
			Int8                                         =   39,
			InputAttachment                              =   40,
			SparseResidency                              =   41,
			MinLod                                       =   42,
			Sampled1D                                    =   43,
			Image1D                                      =   44,
			SampledCubeArray                             =   45,
			SampledBuffer                                =   46,
			ImageBuffer                                  =   47,
			ImageMSArray                                 =   48,
			StorageImageExtendedFormats                  =   49,
			ImageQuery                                   =   50,
			DerivativeControl                            =   51,
			InterpolationFunction                        =   52,
			TransformFeedback                            =   53,
			GeometryStreams                              =   54,
			StorageImageReadWithoutFormat                =   55,
			StorageImageWriteWithoutFormat               =   56,
			MultiViewport                                =   57,
			SubgroupDispatch                             =   58,
			NamedBarrier                                 =   59,
			PipeStorage                                  =   60,
			GroupNonUniform                              =   61,
			GroupNonUniformVote                          =   62,
			GroupNonUniformArithmetic                    =   63,
			GroupNonUniformBallot                        =   64,
			GroupNonUniformShuffle                       =   65,
			GroupNonUniformShuffleRelative               =   66,
			GroupNonUniformClustered                     =   67,
			GroupNonUniformQuad                          =   68,
			ShaderLayer                                  =   69,
			ShaderViewportIndex                          =   70,
			UniformDecoration                            =   71,
			FragmentShadingRateKHR                       = 4422,
			SubgroupBallotKHR                            = 4423,
			DrawParameters                               = 4427,
			WorkgroupMemoryExplicitLayoutKHR             = 4428,
			WorkgroupMemoryExplicitLayout8BitAccessKHR   = 4429,
			WorkgroupMemoryExplicitLayout16BitAccessKHR  = 4430,
			SubgroupVoteKHR                              = 4431,
			StorageBuffer16BitAccess                     = 4433,
			StorageUniformBufferBlock16                  = 4433,
			UniformAndStorageBuffer16BitAccess           = 4434,
			StorageUniform16                             = 4434,
			StoragePushConstant16                        = 4435,
			StorageInputOutput16                         = 4436,
			DeviceGroup                                  = 4437,
			MultiView                                    = 4439,
			VariablePointersStorageBuffer                = 4441,
			VariablePointers                             = 4442,
			AtomicStorageOps                             = 4445,
			SampleMaskPostDepthCoverage                  = 4447,
			StorageBuffer8BitAccess                      = 4448,
			UniformAndStorageBuffer8BitAccess            = 4449,
			StoragePushConstant8                         = 4450,
			DenormPreserve                               = 4464,
			DenormFlushToZero                            = 4465,
			SignedZeroInfNanPreserve                     = 4466,
			RoundingModeRTE                              = 4467,
			RoundingModeRTZ                              = 4468,
			RayQueryProvisionalKHR                       = 4471,
			RayQueryKHR                                  = 4472,
			RayTraversalPrimitiveCullingKHR              = 4478,
			RayTracingKHR                                = 4479,
			Float16ImageAMD                              = 5008,
			ImageGatherBiasLodAMD                        = 5009,
			FragmentMaskAMD                              = 5010,
			StencilExportEXT                             = 5013,
			ImageReadWriteLodAMD                         = 5015,
			Int64ImageEXT                                = 5016,
			ShaderClockKHR                               = 5055,
			SampleMaskOverrideCoverageNV                 = 5249,
			GeometryShaderPassthroughNV                  = 5251,
			ShaderViewportIndexLayerEXT                  = 5254,
			ShaderViewportIndexLayerNV                   = 5254,
			ShaderViewportMaskNV                         = 5255,
			ShaderStereoViewNV                           = 5259,
			PerViewAttributesNV                          = 5260,
			FragmentFullyCoveredEXT                      = 5265,
			MeshShadingNV                                = 5266,
			ImageFootprintNV                             = 5282,
			FragmentBarycentricKHR                       = 5284,
			FragmentBarycentricNV                        = 5284,
			ComputeDerivativeGroupQuadsNV                = 5288,
			FragmentDensityEXT                           = 5291,
			ShadingRateNV                                = 5291,
			GroupNonUniformPartitionedNV                 = 5297,
			ShaderNonUniform                             = 5301,
			ShaderNonUniformEXT                          = 5301,
			RuntimeDescriptorArray                       = 5302,
			RuntimeDescriptorArrayEXT                    = 5302,
			InputAttachmentArrayDynamicIndexing          = 5303,
			InputAttachmentArrayDynamicIndexingEXT       = 5303,
			UniformTexelBufferArrayDynamicIndexing       = 5304,
			UniformTexelBufferArrayDynamicIndexingEXT    = 5304,
			StorageTexelBufferArrayDynamicIndexing       = 5305,
			StorageTexelBufferArrayDynamicIndexingEXT    = 5305,
			UniformBufferArrayNonUniformIndexingBlock    = 5306,
			UniformBufferArrayNonUniformIndexingEXT      = 5306,
			SampledImageArrayNonUniformIndexing          = 5307,
			SampledImageArrayNonUniformIndexingEXT       = 5307,
			StorageBufferArrayNonUniformIndexing         = 5308,
			StorageBufferArrayNonUniformIndexingEXT      = 5308,
			StorageImageArrayNonUniformIndexing          = 5309,
			StorageImageArrayNonUniformIndexingEXT       = 5309,
			InputAttachmentArrayNonUniformIndexing       = 5310,
			InputAttachmentArrayNonUniformIndexingEXT    = 5310,
			UniformTexelBufferArrayNonUniformIndexing    = 5311,
			UniformTexelBufferArrayNonUniformIndexingEXT = 5311,
			StorageTexelBufferArrayNonUniformIndexing    = 5312,
			StorageTexelBufferArrayNonUniformIndexingEXT = 5312,
			RayTracingNV                                 = 5340,
			RayTracingMotionBlurNV                       = 5341,
			VulkanMemoryModel                            = 5345,
			VulkanMemoryModelKHR                         = 5345,
			VulkanMemoryModelDeviceScope                 = 5346,
			VulkanMemoryModelDeviceScopeKHR              = 5346,
			PhysicalStorageBufferAddresses               = 5347,
			PhysicalStorageBufferAddressesEXT            = 5347,
			ComputeDerivativeGroupLinearNV               = 5350,
			RayTracingProvisionalKHR                     = 5353,
			CooperativeMatrixNV                          = 5357,
			FragmentShaderSampleInterlockEXT             = 5363,
			FragmentShaderShadingRateInterlockEXT        = 5372,
			ShaderSMBuiltinsNV                           = 5373,
			FragmentShaderPixelInterlockEXT              = 5378,
			DemoteToHelperInvocation                     = 5379,
			DemoteToHelperInvocationEXT                  = 5379,
			BindlessTextureNV                            = 5390,
			SubgroupShuffleINTEL                         = 5568,
			SubgroupBufferBlockIOINTEL                   = 5569,
			SubgroupImageBlockIOINTEL                    = 5570,
			SubgroupImageMediaBlockIOINTEL               = 5579,
			RoundToInfinityINTEL                         = 5582,
			FloatingPointModeINTEL                       = 5583,
			IntegerFunctions2INTEL                       = 5584,
			FunctionPointersINTEL                        = 5603,
			IndirectReferencesINTEL                      = 5604,
			AsmINTEL                                     = 5606,
			AtomicFloat32MinMaxEXT                       = 5612,
			AtomicFloat64MinMaxEXT                       = 5613,
			AtomicFloat16MinMaxEXT                       = 5616,
			VectorComputeINTEL                           = 5617,
			VectorAnyINTEL                               = 5619,
			ExpectAssumeKHR                              = 5629,
			SubgroupAvcMotionEstimationINTEL             = 5696,
			SubgroupAvcMotionEstimationIntralINTEL       = 5697,
			SubgroupAvcMotionEstimationChromaINTEL       = 5698,
			VariableLengthArrayINTEL                     = 5817,
			FunctionFloatControlINTEL                    = 5821,
			FPGAMemoryAttributesINTEL                    = 5824,
			FPFastMathModeINTEL                          = 5837,
			ArbitraryPrecisionIntegersINTEL              = 5844,
			ArbitraryPrecisionFloatingPointINTEL         = 5845,
			UnstructuredLoopControlsINTEL                = 5886,
			FPGALoopControlsINTEL                        = 5888,
			KernelAttributesINTEL                        = 5892,
			FPGAKernelAttributesINTEL                    = 5897,
			FPGAMemoryAccessesINTEL                      = 5898,
			FPGAClusterAttributesINTEL                   = 5904,
			LoopFuseINTEL                                = 5906,
			MemoryAccessAliasingINTEL                    = 5910,
			FPGABufferLocationINTEL                      = 5920,
			ArbitraryPrecisionFixedPointINTEL            = 5922,
			USMStorageClassesINTEL                       = 5935,
			IOPipesINTEL                                 = 5943,
			BlockingPipesINTEL                           = 5945,
			FPGARegINTEL                                 = 5948,
			DotProductInputAll                           = 6016,
			DotProductInputAllKHR                        = 6016,
			DotProductInput4x8Bit                        = 6017,
			DotProductInput4x8BitKHR                     = 6017,
			DotProductInput4x8BitPacked                  = 6018,
			DotProductInput4x8BitPackedKHR               = 6018,
			DotProduct                                   = 6019,
			DotProductKHR                                = 6019,
			RayCullMaskKHR                               = 6020,
			BitInstructions                              = 6025,
			GroupNonUniformRotateKHR                     = 6026,
			AtomicFloat32AddEXT                          = 6033,
			AtomicFloat64AddEXT                          = 6034,
			LongConstantCompositeINTEL                   = 6089,
			OptNoneINTEL                                 = 6094,
			AtomicFloat16AddEXT                          = 6095,
			DebugInfoModuleINTEL                         = 6114,
			SplitBarrierINTEL                            = 6141,
			GroupUniformArithmeticKHR                    = 6400
		}

		public enum ReservedRayFlags : UInt32
		{
			None                        = 0x000,
			OpaqueKHR                   = 0x001,
			NoOpaqueKHR                 = 0x002,
			TerminateOnFirstHitKHR      = 0x004,
			SkipClosestHitShaderKHR     = 0x008,
			CullBackFacingTrianglesKHR  = 0x010,
			CullFrontFacingTrianglesKHR = 0x020,
			CullOpaqueKHR               = 0x040,
			CullNoOpqueKHR              = 0x080,
			SkipTrianglesKHR            = 0x100,
			SkipAABBsKHR                = 0x200
		}

		public enum ReservedRayQueryIntersection : UInt32
		{
			RayQueryCandidateIntersectionKHR = 0,
			RayQueryCommittedIntersectionKHR = 1
		}

		public enum ReservedRayQueryCommittedType : UInt32
		{
			RayQueryCommittedIntersectionNoneKHR      = 0,
			RayQueryCommittedIntersectionTriangleKHR  = 1,
			RayQueryCommittedIntersectionGeneratedKHR = 2
		}

		public enum ReservedRayQueryCandidateType : UInt32
		{
			RayQueryCandidateIntersectionTriangleKHR = 0,
			RayQueryCandidateIntersectionAABBKHR     = 1
		}

		public enum ReservedFragmentShadingRate : UInt32
		{
			None              = 0x0,
			Vertical2Pixels   = 0x1,
			Vertical4Pixels   = 0x2,
			Horizontal2Pixels = 0x4,
			Horizontal4Pixels = 0x8
		}

		public enum ReservedFPDenormMode : UInt32
		{
			Preserve    = 0,
			FlushToZero = 1
		}

		public enum ReservedFPOperationMode : UInt32
		{
			IEEE = 0,
			ALT  = 1
		}

		public enum QuantizationMode : UInt32
		{
			TRN          = 0,
			TRN_ZERO     = 1,
			RND          = 2,
			RND_ZERO     = 3,
			RND_INF      = 4,
			RND_MIN_INF  = 5,
			RND_CONV     = 6,
			RND_CONV_ODD = 7
		}

		public enum OverflowMode : UInt32
		{
			WRAP     = 0,
			SAT      = 1,
			SAT_ZERO = 2,
			SAT_SYM  = 3
		}

		public enum PackedVectorFormat : UInt32
		{
			PackedVectorFormat4x8Bit    = 0,
			PackedVectorFormat4x8BitKHR = 0
		}

		// --------------------------------------------------------

		//public const UInt32 MagicNumber = 0x07230203;

		//// Source Language

		//public const UInt32 SourceLanguage_Unknown        = 0;
		//public const UInt32 SourceLanguage_ESSL           = 1;
		//public const UInt32 SourceLanguage_GLSL           = 2;
		//public const UInt32 SourceLanguage_OpenCL_C       = 3;
		//public const UInt32 SourceLanguage_OpenCL_CPP     = 4;
		//public const UInt32 SourceLanguage_HLSL           = 5;
		//public const UInt32 SourceLanguage_CPP_for_OpenCL = 6;
		//public const UInt32 SourceLanguage_SYCL           = 7;

		//// Execution Model

		//public const UInt32 ExecutionModel_Vertex                 =    0;
		//public const UInt32 ExecutionModel_TessellationControl    =    1;
		//public const UInt32 ExecutionModel_TessellationEvaluation =    2;
		//public const UInt32 ExecutionModel_Geometry               =    3;
		//public const UInt32 ExecutionModel_Fragment               =    4;
		//public const UInt32 ExecutionModel_GLCompute              =    5;
		//public const UInt32 ExecutionModel_Kernel                 =    6;
		//public const UInt32 ExecutionModel_TaskNV                 = 5267;
		//public const UInt32 ExecutionModel_MeshNV                 = 5268;
		//public const UInt32 ExecutionModel_RayGenerationNV        = 5313;
		//public const UInt32 ExecutionModel_RayGenerationKHR       = 5313;
		//public const UInt32 ExecutionModel_IntersectionNV         = 5314;
		//public const UInt32 ExecutionModel_IntersectionKHR        = 5314;
		//public const UInt32 ExecutionModel_AnyHitNV               = 5315;
		//public const UInt32 ExecutionModel_AnyHitKHR              = 5315;
		//public const UInt32 ExecutionModel_ClosestHitNV           = 5316;
		//public const UInt32 ExecutionModel_ClosestHitKHR          = 5316;
		//public const UInt32 ExecutionModel_MissNV                 = 5317;
		//public const UInt32 ExecutionModel_MissKHR                = 5317;
		//public const UInt32 ExecutionModel_CallableNV             = 5318;
		//public const UInt32 ExecutionModel_CallableKHR            = 5318;

		//// Addressing Model

		//public const UInt32 AddressingModel_Logical                    =    0;
		//public const UInt32 AddressingModel_Physical32                 =    1;
		//public const UInt32 AddressingModel_Physical64                 =    2;
		//public const UInt32 AddressingModel_PhysicalStorageBuffer64    = 5348;
		//public const UInt32 AddressingModel_PhysicalStorageBuffer64EXT = 5348;

		//// Memory Model

		//public const UInt32 MemoryModel_Simple    = 0;
		//public const UInt32 MemoryModel_GLSL450   = 1;
		//public const UInt32 MemoryModel_OpenCL    = 2;
		//public const UInt32 MemoryModel_Vulkan    = 3;
		//public const UInt32 MemoryModel_VulkanKHR = 3;

		//// Execution Mode

		//public const UInt32 ExecutionMode_Invocations                      =    0;
		//public const UInt32 ExecutionMode_SpacingEqual                     =    1;
		//public const UInt32 ExecutionMode_SpacingFractionalEven            =    2;
		//public const UInt32 ExecutionMode_SpacingFractionalOdd             =    3;
		//public const UInt32 ExecutionMode_VertexOrderCw                    =    4;
		//public const UInt32 ExecutionMode_VertexOrderCcw                   =    5;
		//public const UInt32 ExecutionMode_PixelCenterInteger               =    6;
		//public const UInt32 ExecutionMode_OriginUpperLeft                  =    7;
		//public const UInt32 ExecutionMode_OriginLowerLeft                  =    8;
		//public const UInt32 ExecutionMode_EarlyFragmentTests               =    9;
		//public const UInt32 ExecutionMode_PointMode                        =   10;
		//public const UInt32 ExecutionMode_Xfb                              =   11;
		//public const UInt32 ExecutionMode_DepthReplacing                   =   12;
		//public const UInt32 ExecutionMode_DepthGreater                     =   14;
		//public const UInt32 ExecutionMode_DepthLess                        =   15;
		//public const UInt32 ExecutionMode_DepthUnchanged                   =   16;
		//public const UInt32 ExecutionMode_LocalSize                        =   17;
		//public const UInt32 ExecutionMode_LocalSizeHint                    =   18;
		//public const UInt32 ExecutionMode_InputPoints                      =   19;
		//public const UInt32 ExecutionMode_InputLines                       =   20;
		//public const UInt32 ExecutionMode_InputLinesAdjacency              =   21;
		//public const UInt32 ExecutionMode_Triangles                        =   22;
		//public const UInt32 ExecutionMode_InputTrianglesAdjacency          =   23;
		//public const UInt32 ExecutionMode_Quads                            =   24;
		//public const UInt32 ExecutionMode_Isolines                         =   25;
		//public const UInt32 ExecutionMode_OutputVertices                   =   26;
		//public const UInt32 ExecutionMode_OutputPoints                     =   27;
		//public const UInt32 ExecutionMode_OutputLineStrip                  =   28;
		//public const UInt32 ExecutionMode_OutputTriangleStrip              =   29;
		//public const UInt32 ExecutionMode_VecTypeHint                      =   30;
		//public const UInt32 ExecutionMode_ContractionOff                   =   31;
		//public const UInt32 ExecutionMode_Initializer                      =   33;
		//public const UInt32 ExecutionMode_Finalizer                        =   34;
		//public const UInt32 ExecutionMode_SubgroupSize                     =   35;
		//public const UInt32 ExecutionMode_SubgroupsPerWorkgroup            =   36;
		//public const UInt32 ExecutionMode_SubgroupsPerWorkgroupId          =   37;
		//public const UInt32 ExecutionMode_LocalSizeId                      =   38;
		//public const UInt32 ExecutionMode_LocalSizeHintId                  =   39;
		//public const UInt32 ExecutionMode_SubgroupUniformControlFlowKHR    = 4421;
		//public const UInt32 ExecutionMode_PostDepthCoverage                = 4446;
		//public const UInt32 ExecutionMode_DenormPreserve                   = 4459;
		//public const UInt32 ExecutionMode_DenormFlushToZero                = 4460;
		//public const UInt32 ExecutionMode_SignedZeroInfNanPreserve         = 4461;
		//public const UInt32 ExecutionMode_RoundingModeRTE                  = 4462;
		//public const UInt32 ExecutionMode_RoundingModeRTZ                  = 4463;
		//public const UInt32 ExecutionMode_EarlyAndLateFragmentTestsAMD     = 5017;
		//public const UInt32 ExecutionMode_StencilRefReplacingEXT           = 5027;
		//public const UInt32 ExecutionMode_StencilRefUnchangedFrontAMD      = 5079;
		//public const UInt32 ExecutionMode_StencilRefGreaterFrontAMD        = 5080;
		//public const UInt32 ExecutionMode_StencilRefLessFrontAMD           = 5081;
		//public const UInt32 ExecutionMode_StencilRefUnchangedBackAMD       = 5082;
		//public const UInt32 ExecutionMode_StencilRefGreaterBackAMD         = 5083;
		//public const UInt32 ExecutionMode_StencilRefLessBackAMD            = 5084;
		//public const UInt32 ExecutionMode_OutputLinesNV                    = 5269;
		//public const UInt32 ExecutionMode_OutputPrimitivesNV               = 5270;
		//public const UInt32 ExecutionMode_DerivativeGroupQuadsNV           = 5289;
		//public const UInt32 ExecutionMode_DerivativeGroupLinearNV          = 5290;
		//public const UInt32 ExecutionMode_OutputTrianglesNV                = 5298;
		//public const UInt32 ExecutionMode_PixelInterlockOrderedEXT         = 5366;
		//public const UInt32 ExecutionMode_PixelInterlockUnorderedEXT       = 5367;
		//public const UInt32 ExecutionMode_SampleInterlockOrderedEXT        = 5368;
		//public const UInt32 ExecutionMode_SampleInterlockUnorderedEXT      = 5369;
		//public const UInt32 ExecutionMode_ShadingRateInterlockOrderedEXT   = 5370;
		//public const UInt32 ExecutionMode_ShadingRateInterlockUnorderedEXT = 5371;
		//public const UInt32 ExecutionMode_SharedLocalMemorySizeINTEL       = 5618;
		//public const UInt32 ExecutionMode_RoundingModeRTPINTEL             = 5620;
		//public const UInt32 ExecutionMode_RoundingModeRTNINTEL             = 5621;
		//public const UInt32 ExecutionMode_FloatingPointModeALTINTEL        = 5622;
		//public const UInt32 ExecutionMode_FloatingPointModeIEEEINTEL       = 5623;
		//public const UInt32 ExecutionMode_MaxWorkgroupSizeINTEL            = 5893;
		//public const UInt32 ExecutionMode_MaxWorkDimINTEL                  = 5894;
		//public const UInt32 ExecutionMode_NoGlobalOffsetINTEL              = 5895;
		//public const UInt32 ExecutionMode_NumSIMDWorkitemsINTEL            = 5896;
		//public const UInt32 ExecutionMode_SchedulerTargetFmaxMhzINTEL      = 5903;
		//public const UInt32 ExecutionMode_NamedBarrierCountINTEL           = 6417;

		//// Storage Class

		//public const UInt32 StorageClass_UniformConstant          =    0;
		//public const UInt32 StorageClass_Input                    =    1;
		//public const UInt32 StorageClass_Uniform                  =    2;
		//public const UInt32 StorageClass_Output                   =    3;
		//public const UInt32 StorageClass_Workgroup                =    4;
		//public const UInt32 StorageClass_CrossWorkgroup           =    5;
		//public const UInt32 StorageClass_Private                  =    6;
		//public const UInt32 StorageClass_Function                 =    7;
		//public const UInt32 StorageClass_Generic                  =    8;
		//public const UInt32 StorageClass_PushConstant             =    9;
		//public const UInt32 StorageClass_AtomicCounter            =   10;
		//public const UInt32 StorageClass_Image                    =   11;
		//public const UInt32 StorageClass_StorageBuffer            =   12;
		//public const UInt32 StorageClass_CallableDataNV           = 5328;
		//public const UInt32 StorageClass_CallableDataKHR          = 5328;
		//public const UInt32 StorageClass_IncomingCallableDataNV   = 5329;
		//public const UInt32 StorageClass_IncomingCallableDataKHR  = 5329;
		//public const UInt32 StorageClass_RayPayloadNV             = 5338;
		//public const UInt32 StorageClass_RayPayloadKHR            = 5338;
		//public const UInt32 StorageClass_HitAttributeNV           = 5339;
		//public const UInt32 StorageClass_HitAttributeKHR          = 5339;
		//public const UInt32 StorageClass_IncomingRayPayloadNV     = 5342;
		//public const UInt32 StorageClass_IncomingRayPayloadKHR    = 5342;
		//public const UInt32 StorageClass_ShaderRecordBufferNV     = 5343;
		//public const UInt32 StorageClass_ShaderRecordBufferKHR    = 5343;
		//public const UInt32 StorageClass_PhysicalStorageBuffer    = 5349;
		//public const UInt32 StorageClass_PhysicalStorageBufferEXT = 5349;
		//public const UInt32 StorageClass_CodeSectionINTEL         = 5605;
		//public const UInt32 StorageClass_DeviceOnlyINTEL          = 5936;
		//public const UInt32 StorageClass_HostOnlyINTEL            = 5937;

		//// Dim

		//public const UInt32 Dim_1D          = 0;
		//public const UInt32 Dim_2D          = 1;
		//public const UInt32 Dim_3D          = 2;
		//public const UInt32 Dim_Cube        = 3;
		//public const UInt32 Dim_Rect        = 4;
		//public const UInt32 Dim_Buffer      = 5;
		//public const UInt32 Dim_SubpassData = 6;

		//// Sampler Addressing Mode

		//public const UInt32 SamplerAddressingMode_None           = 0;
		//public const UInt32 SamplerAddressingMode_ClampToEdge    = 1;
		//public const UInt32 SamplerAddressingMode_Clamp          = 2;
		//public const UInt32 SamplerAddressingMode_Repeat         = 3;
		//public const UInt32 SamplerAddressingMode_RepeatMirrored = 4;

		//// Sampler Filter Mode

		//public const UInt32 SamplerFilterMode_Nearest = 0;
		//public const UInt32 SamplerFilterMode_Linear  = 1;

		//// Image Format

		//public const UInt32 ImageFormat_Unknown      =  0;
		//public const UInt32 ImageFormat_Rgba32f      =  1;
		//public const UInt32 ImageFormat_Rgba16f      =  2;
		//public const UInt32 ImageFormat_R32f         =  3;
		//public const UInt32 ImageFormat_Rgba8        =  4;
		//public const UInt32 ImageFormat_Rgba8Snorm   =  5;
		//public const UInt32 ImageFormat_Rg32f        =  6;
		//public const UInt32 ImageFormat_Rg16f        =  7;
		//public const UInt32 ImageFormat_R11fG11fB10f =  8;
		//public const UInt32 ImageFormat_R16f         =  9;
		//public const UInt32 ImageFormat_Rgba16       = 10;
		//public const UInt32 ImageFormat_Rgb10A2      = 11;
		//public const UInt32 ImageFormat_Rg16         = 12;
		//public const UInt32 ImageFormat_Rg8          = 13;
		//public const UInt32 ImageFormat_R16          = 14;
		//public const UInt32 ImageFormat_R8           = 15;
		//public const UInt32 ImageFormat_Rgba16Snorm  = 16;
		//public const UInt32 ImageFormat_Rg16Snorm    = 17;
		//public const UInt32 ImageFormat_Rg8Snorm     = 18;
		//public const UInt32 ImageFormat_R16Snorm     = 19;
		//public const UInt32 ImageFormat_R8Snorm      = 20;
		//public const UInt32 ImageFormat_Rgba32i      = 21;
		//public const UInt32 ImageFormat_Rgba16i      = 22;
		//public const UInt32 ImageFormat_Rgba8i       = 23;
		//public const UInt32 ImageFormat_R32i         = 24;
		//public const UInt32 ImageFormat_Rg32i        = 25;
		//public const UInt32 ImageFormat_Rg16i        = 26;
		//public const UInt32 ImageFormat_Rg8i         = 27;
		//public const UInt32 ImageFormat_R16i         = 28;
		//public const UInt32 ImageFormat_R8i          = 29;
		//public const UInt32 ImageFormat_Rgba32ui     = 30;
		//public const UInt32 ImageFormat_Rgba16ui     = 31;
		//public const UInt32 ImageFormat_Rgba8ui      = 32;
		//public const UInt32 ImageFormat_R32ui        = 33;
		//public const UInt32 ImageFormat_Rgb10a2ui    = 34;
		//public const UInt32 ImageFormat_Rg32ui       = 35;
		//public const UInt32 ImageFormat_Rg16ui       = 36;
		//public const UInt32 ImageFormat_Rg8ui        = 37;
		//public const UInt32 ImageFormat_R16ui        = 38;
		//public const UInt32 ImageFormat_R8ui         = 39;
		//public const UInt32 ImageFormat_R64ui        = 40;
		//public const UInt32 ImageFormat_R64i         = 41;

		//// Image Channel Order

		//public const UInt32 ImageChannelOrder_R            =  0;
		//public const UInt32 ImageChannelOrder_A            =  1;
		//public const UInt32 ImageChannelOrder_RG           =  2;
		//public const UInt32 ImageChannelOrder_RA           =  3;
		//public const UInt32 ImageChannelOrder_RGB          =  4;
		//public const UInt32 ImageChannelOrder_RGBA         =  5;
		//public const UInt32 ImageChannelOrder_BGRA         =  6;
		//public const UInt32 ImageChannelOrder_ARGB         =  7;
		//public const UInt32 ImageChannelOrder_Intensity    =  8;
		//public const UInt32 ImageChannelOrder_Luminance    =  9;
		//public const UInt32 ImageChannelOrder_Rx           = 10;
		//public const UInt32 ImageChannelOrder_RGx          = 11;
		//public const UInt32 ImageChannelOrder_RGBx         = 12;
		//public const UInt32 ImageChannelOrder_Depth        = 13;
		//public const UInt32 ImageChannelOrder_DepthStencil = 14;
		//public const UInt32 ImageChannelOrder_sRGB         = 15;
		//public const UInt32 ImageChannelOrder_sRGBx        = 16;
		//public const UInt32 ImageChannelOrder_sRGBA        = 17;
		//public const UInt32 ImageChannelOrder_sBGRA        = 18;
		//public const UInt32 ImageChannelOrder_ABGR         = 19;

		//// Image Channel Data Type

		//public const UInt32 ImageChannelDataType_SnormInt8        =  0;
		//public const UInt32 ImageChannelDataType_SnormInt16       =  1;
		//public const UInt32 ImageChannelDataType_UnormInt8        =  2;
		//public const UInt32 ImageChannelDataType_UnormInt16       =  3;
		//public const UInt32 ImageChannelDataType_UnormShort565    =  4;
		//public const UInt32 ImageChannelDataType_UnormShort555    =  5;
		//public const UInt32 ImageChannelDataType_UnormInt101010   =  6;
		//public const UInt32 ImageChannelDataType_SignedInt8       =  7;
		//public const UInt32 ImageChannelDataType_SignedInt16      =  8;
		//public const UInt32 ImageChannelDataType_SignedInt32      =  9;
		//public const UInt32 ImageChannelDataType_UnsignedInt8     = 10;
		//public const UInt32 ImageChannelDataType_UnsignedInt16    = 11;
		//public const UInt32 ImageChannelDataType_UnsignedInt32    = 12;
		//public const UInt32 ImageChannelDataType_HalfFloat        = 13;
		//public const UInt32 ImageChannelDataType_Float            = 14;
		//public const UInt32 ImageChannelDataType_UnormInt24       = 15;
		//public const UInt32 ImageChannelDataType_UnormInt101010_2 = 16;

		//// Image Operands

		//public const UInt32 ImageOperands_None                  = 0x00000;
		//public const UInt32 ImageOperands_Bias                  = 0x00001;
		//public const UInt32 ImageOperands_Lod                   = 0x00002;
		//public const UInt32 ImageOperands_Grad                  = 0x00004;
		//public const UInt32 ImageOperands_ConstOffset           = 0x00008;
		//public const UInt32 ImageOperands_Offset                = 0x00010;
		//public const UInt32 ImageOperands_ConstOffsets          = 0x00020;
		//public const UInt32 ImageOperands_Sample                = 0x00040;
		//public const UInt32 ImageOperands_MinLod                = 0x00080;
		//public const UInt32 ImageOperands_MakeTexelAvailable    = 0x00100;
		//public const UInt32 ImageOperands_MakeTexelAvailableKHR = 0x00100;
		//public const UInt32 ImageOperands_MakeTexelVisible      = 0x00200;
		//public const UInt32 ImageOperands_MakeTexelVisibleKHR   = 0x00200;
		//public const UInt32 ImageOperands_NonPrivateTexel       = 0x00400;
		//public const UInt32 ImageOperands_NonPrivateTexelKHR    = 0x00400;
		//public const UInt32 ImageOperands_VolatileTexel         = 0x00800;
		//public const UInt32 ImageOperands_VolatileTexelKHR      = 0x00800;
		//public const UInt32 ImageOperands_SignExtend            = 0x01000;
		//public const UInt32 ImageOperands_ZeroExtend            = 0x02000;
		//public const UInt32 ImageOperands_Nontemporal           = 0x04000;
		//public const UInt32 ImageOperands_Offsets               = 0x10000;

		//// FP Fast Math Mode

		//public const UInt32 FPFastMathMode_None                   = 0x00000;
		//public const UInt32 FPFastMathMode_NotNaN                 = 0x00001;
		//public const UInt32 FPFastMathMode_NotInf                 = 0x00002;
		//public const UInt32 FPFastMathMode_NSZ                    = 0x00004;
		//public const UInt32 FPFastMathMode_AllowRecip             = 0x00008;
		//public const UInt32 FPFastMathMode_Fast                   = 0x00010;
		//public const UInt32 FPFastMathMode_AllowContractFastINTEL = 0x10000;
		//public const UInt32 FPFastMathMode_AllowReassocINTEL      = 0x20000;

		//// FP Rounding Mode

		//public const UInt32 FPRoundingMode_RTE = 0;
		//public const UInt32 FPRoundingMode_RTZ = 1;
		//public const UInt32 FPRoundingMode_RTP = 2;
		//public const UInt32 FPRoundingMode_RTN = 3;

		//// Linkage Type

		//public const UInt32 LinkageType_Export      = 0;
		//public const UInt32 LinkageType_Import      = 1;
		//public const UInt32 LinkageType_LinkOnceODR = 2;

		//// Access Qualifier

		//public const UInt32 AccessQualifier_ReadOnly  = 0;
		//public const UInt32 AccessQualifier_WriteOnly = 1;
		//public const UInt32 AccessQualifier_ReadWrite = 2;

		//// Function Parameter Attribute

		//public const UInt32 FunctionParameterAttribute_Zext        = 0;
		//public const UInt32 FunctionParameterAttribute_Sext        = 1;
		//public const UInt32 FunctionParameterAttribute_ByVal       = 2;
		//public const UInt32 FunctionParameterAttribute_Sret        = 3;
		//public const UInt32 FunctionParameterAttribute_NoAlias     = 4;
		//public const UInt32 FunctionParameterAttribute_NoCapture   = 5;
		//public const UInt32 FunctionParameterAttribute_NoWrite     = 6;
		//public const UInt32 FunctionParameterAttribute_NoReadWrite = 7;

		//// Decoration

		//public const UInt32 Decoration_RelaxedPrecision                   =    0;
		//public const UInt32 Decoration_SpecId                             =    1;
		//public const UInt32 Decoration_Block                              =    2;
		//public const UInt32 Decoration_BufferBlock                        =    3;
		//public const UInt32 Decoration_RowMajor                           =    4;
		//public const UInt32 Decoration_ColMajor                           =    5;
		//public const UInt32 Decoration_ArrayStride                        =    6;
		//public const UInt32 Decoration_MatrixStride                       =    7;
		//public const UInt32 Decoration_GLSLShared                         =    8;
		//public const UInt32 Decoration_GLSLPacked                         =    9;
		//public const UInt32 Decoration_CPacked                            =   10;
		//public const UInt32 Decoration_BuiltIn                            =   11;
		//public const UInt32 Decoration_NoPerspective                      =   13;
		//public const UInt32 Decoration_Flat                               =   14;
		//public const UInt32 Decoration_Patch                              =   15;
		//public const UInt32 Decoration_Centroid                           =   16;
		//public const UInt32 Decoration_Sample                             =   17;
		//public const UInt32 Decoration_Invariant                          =   18;
		//public const UInt32 Decoration_Restrict                           =   19;
		//public const UInt32 Decoration_Aliased                            =   20;
		//public const UInt32 Decoration_Volatile                           =   21;
		//public const UInt32 Decoration_Constant                           =   22;
		//public const UInt32 Decoration_Coherent                           =   23;
		//public const UInt32 Decoration_NonWritable                        =   24;
		//public const UInt32 Decoration_NonReadable                        =   25;
		//public const UInt32 Decoration_Uniform                            =   26;
		//public const UInt32 Decoration_UniformId                          =   27;
		//public const UInt32 Decoration_SaturatedConversion                =   28;
		//public const UInt32 Decoration_Stream                             =   29;
		//public const UInt32 Decoration_Location                           =   30;
		//public const UInt32 Decoration_Component                          =   31;
		//public const UInt32 Decoration_Index                              =   32;
		//public const UInt32 Decoration_Binding                            =   33;
		//public const UInt32 Decoration_DescriptorSet                      =   34;
		//public const UInt32 Decoration_Offset                             =   35;
		//public const UInt32 Decoration_XfbBuffer                          =   36;
		//public const UInt32 Decoration_XfbStride                          =   37;
		//public const UInt32 Decoration_FuncParamAttr                      =   38;
		//public const UInt32 Decoration_FPRoundingMode                     =   39;
		//public const UInt32 Decoration_FPFastMode                         =   40;
		//public const UInt32 Decoration_LinkageAttributes                  =   41;
		//public const UInt32 Decoration_NoContraction                      =   42;
		//public const UInt32 Decoration_InputAttachmentIndex               =   43;
		//public const UInt32 Decoration_Alignment                          =   44;
		//public const UInt32 Decoration_MaxByteOffset                      =   45;
		//public const UInt32 Decoration_AlignmentId                        =   46;
		//public const UInt32 Decoration_MaxByteOffsetId                    =   47;
		//public const UInt32 Decoration_NoSignedWrap                       = 4469;
		//public const UInt32 Decoration_NoUnsignedWrap                     = 4470;
		//public const UInt32 Decoration_ExplicitInterpAMD                  = 4999;
		//public const UInt32 Decoration_OverrideCoverageNV                 = 5248;
		//public const UInt32 Decoration_PassthroughNV                      = 5250;
		//public const UInt32 Decoration_ViewportRelativeNV                 = 5252;
		//public const UInt32 Decoration_SecondaryViewportRelativeNV        = 5256;
		//public const UInt32 Decoration_PerPrimitiveNV                     = 5271;
		//public const UInt32 Decoration_PerViewNV                          = 5272;
		//public const UInt32 Decoration_PerTaskNV                          = 5273;
		//public const UInt32 Decoration_PerVertexKHR                       = 5285;
		//public const UInt32 Decoration_PerVertexNV                        = 5285;
		//public const UInt32 Decoration_NonUniform                         = 5300;
		//public const UInt32 Decoration_NonUniformEXT                      = 5300;
		//public const UInt32 Decoration_RestrictPointer                    = 5355;
		//public const UInt32 Decoration_RestrictPointerEXT                 = 5355;
		//public const UInt32 Decoration_AliasedPointer                     = 5356;
		//public const UInt32 Decoration_AliasedPointerEXT                  = 5356;
		//public const UInt32 Decoration_BindlessSamplerNV                  = 5398;
		//public const UInt32 Decoration_BindlessImageNV                    = 5399;
		//public const UInt32 Decoration_BoundSamplerNV                     = 5400;
		//public const UInt32 Decoration_BoundImageNV                       = 5401;
		//public const UInt32 Decoration_SIMTCallINTEL                      = 5599;
		//public const UInt32 Decoration_ReferencedIndirectlyINTEL          = 5602;
		//public const UInt32 Decoration_ClobberINTEL                       = 5607;
		//public const UInt32 Decoration_SideEffectsINTEL                   = 5608;
		//public const UInt32 Decoration_VectorComputeVariableINTEL         = 5624;
		//public const UInt32 Decoration_FuncParamIOKindINTEL               = 5625;
		//public const UInt32 Decoration_VectorComputeFunctionINTEL         = 5626;
		//public const UInt32 Decoration_StackCallINTEL                     = 5627;
		//public const UInt32 Decoration_GlobalVariableOffsetINTEL          = 5628;
		//public const UInt32 Decoration_CounterBuffer                      = 5634;
		//public const UInt32 Decoration_HlslCounterBufferGOOGLE            = 5634;
		//public const UInt32 Decoration_UserSemantic                       = 5635;
		//public const UInt32 Decoration_HlslSemanticGOOGLE                 = 5635;
		//public const UInt32 Decoration_UserTypeGOOGLE                     = 5636;
		//public const UInt32 Decoration_FunctionRoundingModeINTEL          = 5822;
		//public const UInt32 Decoration_FunctionDenormModeINTEL            = 5823;
		//public const UInt32 Decoration_RegisterINTEL                      = 5825;
		//public const UInt32 Decoration_MemoryINTEL                        = 5826;
		//public const UInt32 Decoration_NumbanksINTEL                      = 5827;
		//public const UInt32 Decoration_BankwidthINTEL                     = 5828;
		//public const UInt32 Decoration_MaxPrivateCopiesINTEL              = 5829;
		//public const UInt32 Decoration_SinglepumpINTEL                    = 5830;
		//public const UInt32 Decoration_DoublepumpINTEL                    = 5831;
		//public const UInt32 Decoration_MaxReplicatesINTEL                 = 5832;
		//public const UInt32 Decoration_SimpleDualPortINTEL                = 5833;
		//public const UInt32 Decoration_MergeINTEL                         = 5834;
		//public const UInt32 Decoration_BankBitsINTEL                      = 5835;
		//public const UInt32 Decoration_ForcePow2DepthINTEL                = 5836;
		//public const UInt32 Decoration_BurstCoalescelINTEL                = 5899;
		//public const UInt32 Decoration_CacheSizeINTEL                     = 5900;
		//public const UInt32 Decoration_DontStaticallyCoalescelINTEL       = 5901;
		//public const UInt32 Decoration_PrefetchINTEL                      = 5902;
		//public const UInt32 Decoration_StallEnableINTEL                   = 5905;
		//public const UInt32 Decoration_FuseLoopsInFunctionINTEL           = 5907;
		//public const UInt32 Decoration_AliasScopeINTEL                    = 5914;
		//public const UInt32 Decoration_NoAliasINTEL                       = 5915;
		//public const UInt32 Decoration_BufferLocationINTEL                = 5921;
		//public const UInt32 Decoration_IOPipeStorageINTEL                 = 5944;
		//public const UInt32 Decoration_FunctionFloatingPointModeINTEL     = 6080;
		//public const UInt32 Decoration_SingleElementVectorINTEL           = 6085;
		//public const UInt32 Decoration_VectorComputeCallableFunctionINTEL = 6087;
		//public const UInt32 Decoration_MediaBlockIOINTEL                  = 6140;

		//// BuiltIn

		//public const UInt32 BuiltIn_Position                    =    0;
		//public const UInt32 BuiltIn_PointSize                   =    1;
		//public const UInt32 BuiltIn_ClipDistance                =    3;
		//public const UInt32 BuiltIn_CullDistance                =    4;
		//public const UInt32 BuiltIn_VertexId                    =    5;
		//public const UInt32 BuiltIn_InstanceId                  =    6;
		//public const UInt32 BuiltIn_PrimitiveId                 =    7;
		//public const UInt32 BuiltIn_InvocationId                =    8;
		//public const UInt32 BuiltIn_Layer                       =    9;
		//public const UInt32 BuiltIn_ViewportIndex               =   10;
		//public const UInt32 BuiltIn_TessLevelOuter              =   11;
		//public const UInt32 BuiltIn_TessLevelInner              =   12;
		//public const UInt32 BuiltIn_TessCoord                   =   13;
		//public const UInt32 BuiltIn_PatchVertices               =   14;
		//public const UInt32 BuiltIn_FragCoord                   =   15;
		//public const UInt32 BuiltIn_PointCoord                  =   16;
		//public const UInt32 BuiltIn_FrontFacing                 =   17;
		//public const UInt32 BuiltIn_SampleId                    =   18;
		//public const UInt32 BuiltIn_SamplePosition              =   19;
		//public const UInt32 BuiltIn_SampleMask                  =   20;
		//public const UInt32 BuiltIn_FragDepth                   =   22;
		//public const UInt32 BuiltIn_HelperInvocation            =   23;
		//public const UInt32 BuiltIn_NumWorkgroups               =   24;
		//public const UInt32 BuiltIn_WorkgroupSize               =   25;
		//public const UInt32 BuiltIn_WorkgroupId                 =   26;
		//public const UInt32 BuiltIn_LocalInvocationId           =   27;
		//public const UInt32 BuiltIn_GlobalInvocationId          =   28;
		//public const UInt32 BuiltIn_LocalInvocationIndex        =   29;
		//public const UInt32 BuiltIn_WorkDim                     =   30;
		//public const UInt32 BuiltIn_GlobalSize                  =   31;
		//public const UInt32 BuiltIn_EnqueuedWorkgroupSize       =   32;
		//public const UInt32 BuiltIn_GlobalOffset                =   33;
		//public const UInt32 BuiltIn_GlobalLinearId              =   34;
		//public const UInt32 BuiltIn_SubgroupSize                =   36;
		//public const UInt32 BuiltIn_SubgroupMaxSize             =   37;
		//public const UInt32 BuiltIn_NumSubgroups                =   38;
		//public const UInt32 BuiltIn_NumEnqueuedSubgroups        =   39;
		//public const UInt32 BuiltIn_SubgroupId                  =   40;
		//public const UInt32 BuiltIn_SubgroupLocalInvocationId   =   41;
		//public const UInt32 BuiltIn_VertexIndex                 =   42;
		//public const UInt32 BuiltIn_InstanceIndex               =   43;
		//public const UInt32 BuiltIn_SubgroupEqMask              = 4416;
		//public const UInt32 BuiltIn_SubgroupEqMaskKHR           = 4416;
		//public const UInt32 BuiltIn_SubgroupGeMask              = 4417;
		//public const UInt32 BuiltIn_SubgroupGeMaskKHR           = 4417;
		//public const UInt32 BuiltIn_SubgroupGtMask              = 4418;
		//public const UInt32 BuiltIn_SubgroupGtMaskKHR           = 4418;
		//public const UInt32 BuiltIn_SubgroupLeMask              = 4419;
		//public const UInt32 BuiltIn_SubgroupLeMaskKHR           = 4419;
		//public const UInt32 BuiltIn_SubgroupLtMask              = 4420;
		//public const UInt32 BuiltIn_SubgroupLtMaskKHR           = 4420;
		//public const UInt32 BuiltIn_BaseVertex                  = 4424;
		//public const UInt32 BuiltIn_BaseInstance                = 4425;
		//public const UInt32 BuiltIn_DrawIndex                   = 4426;
		//public const UInt32 BuiltIn_PrimitiveShadingRateKHR     = 4432;
		//public const UInt32 BuiltIn_DeviceIndex                 = 4438;
		//public const UInt32 BuiltIn_ViewIndex                   = 4440;
		//public const UInt32 BuiltIn_ShadingRateKHR              = 4444;
		//public const UInt32 BuiltIn_BaryCoordNoPerspAMD         = 4992;
		//public const UInt32 BuiltIn_BaryCoordNoPerspCentroidAMD = 4993;
		//public const UInt32 BuiltIn_BaryCoordNoPerspSampleAMD   = 4994;
		//public const UInt32 BuiltIn_BaryCoordSmoothAMD          = 4995;
		//public const UInt32 BuiltIn_BaryCoordSmoothCentroidAMD  = 4996;
		//public const UInt32 BuiltIn_BaryCoordSmoothSampleAMD    = 4997;
		//public const UInt32 BuiltIn_BaryCoordPullModelAMD       = 4998;
		//public const UInt32 BuiltIn_FragStencilRefEXT           = 5014;
		//public const UInt32 BuiltIn_ViewportMaskNV              = 5253;
		//public const UInt32 BuiltIn_SecondaryPositionNV         = 5257;
		//public const UInt32 BuiltIn_SecondaryViewportMaskNV     = 5258;
		//public const UInt32 BuiltIn_PositionPerViewNV           = 5261;
		//public const UInt32 BuiltIn_ViewportMaskPerViewNV       = 5262;
		//public const UInt32 BuiltIn_FullyCoveredEXT             = 5264;
		//public const UInt32 BuiltIn_TaskCountNV                 = 5274;
		//public const UInt32 BuiltIn_PrimitiveCountNV            = 5275;
		//public const UInt32 BuiltIn_PrimitiveIndicesNV          = 5276;
		//public const UInt32 BuiltIn_ClipDistancePerViewNV       = 5277;
		//public const UInt32 BuiltIn_CullDistancePerViewNV       = 5278;
		//public const UInt32 BuiltIn_LayerPerViewNV              = 5279;
		//public const UInt32 BuiltIn_MeshViewCountNV             = 5280;
		//public const UInt32 BuiltIn_MeshViewIndicesNV           = 5281;
		//public const UInt32 BuiltIn_BaryCoordKHR                = 5286;
		//public const UInt32 BuiltIn_BaryCoordNV                 = 5286;
		//public const UInt32 BuiltIn_BaryCoordNoPerspKHR         = 5287;
		//public const UInt32 BuiltIn_BaryCoordNoPerspNV          = 5287;
		//public const UInt32 BuiltIn_FragSizeEXT                 = 5292;
		//public const UInt32 BuiltIn_FragmentSizeNV              = 5292;
		//public const UInt32 BuiltIn_FragInvocationCountEXT      = 5293;
		//public const UInt32 BuiltIn_InvocationsPerPixelNV       = 5293;
		//public const UInt32 BuiltIn_LaunchIdNV                  = 5319;
		//public const UInt32 BuiltIn_LaunchIdKHR                 = 5319;
		//public const UInt32 BuiltIn_LaunchSizeNV                = 5320;
		//public const UInt32 BuiltIn_LaunchSizeKHR               = 5320;
		//public const UInt32 BuiltIn_WorldRayOriginNV            = 5321;
		//public const UInt32 BuiltIn_WorldRayOriginKHR           = 5321;
		//public const UInt32 BuiltIn_WorldRayDirectionNV         = 5322;
		//public const UInt32 BuiltIn_WorldRayDirectionKHR        = 5322;
		//public const UInt32 BuiltIn_ObjectRayOriginNV           = 5323;
		//public const UInt32 BuiltIn_ObjectRayOriginKHR          = 5323;
		//public const UInt32 BuiltIn_ObjectRayDirectionNV        = 5324;
		//public const UInt32 BuiltIn_ObjectrayDirectionKHR       = 5324;
		//public const UInt32 BuiltIn_RayTminNV                   = 5325;
		//public const UInt32 BuiltIn_RayTminKHR                  = 5325;
		//public const UInt32 BuiltIn_RayTmaxNV                   = 5326;
		//public const UInt32 BuiltIn_RayTmaxKHR                  = 5326;
		//public const UInt32 BuiltIn_InstanceCustomIndexNV       = 5327;
		//public const UInt32 BuiltIn_InstanceCustomIndexKHR      = 5327;
		//public const UInt32 BuiltIn_ObjectToWorldNV             = 5330;
		//public const UInt32 BuiltIn_ObjectToWorldKHR            = 5330;
		//public const UInt32 BuiltIn_WorldToObjectNV             = 5331;
		//public const UInt32 BuiltIn_WorldToObjectKHR            = 5331;
		//public const UInt32 BuiltIn_HitTNV                      = 5332;
		//public const UInt32 BuiltIn_HitKindNV                   = 5333;
		//public const UInt32 BuiltIn_HitKindKHR                  = 5333;
		//public const UInt32 BuiltIn_CurrentRayTimeNV            = 5334;
		//public const UInt32 BuiltIn_IncomingRayFlagsNV          = 5351;
		//public const UInt32 BuiltIn_IncomingRayFlagsKHR         = 5351;
		//public const UInt32 BuiltIn_RayGeometryIndexKHR         = 5352;
		//public const UInt32 BuiltIn_WarpsPerSMNV                = 5374;
		//public const UInt32 BuiltIn_SMCountNV                   = 5375;
		//public const UInt32 BuiltIn_WarpIDNV                    = 5376;
		//public const UInt32 BuiltIn_SMIDNV                      = 5377;
		//public const UInt32 BuiltIn_CullMaskKHR                 = 6021;

		//// Selection Control

		//public const UInt32 SelectionControl_None        = 0x0;
		//public const UInt32 SelectionControl_Flatten     = 0x1;
		//public const UInt32 SelectionControl_DontFlatten = 0x2;

		//// Loop Control

		//public const UInt32 LoopControl_None                      = 0x000000;
		//public const UInt32 LoopControl_Unroll                    = 0x000001;
		//public const UInt32 LoopControl_DontUnroll                = 0x000002;
		//public const UInt32 LoopControl_DependencyInfinite        = 0x000004;
		//public const UInt32 LoopControl_DependencyLength          = 0x000008;
		//public const UInt32 LoopControl_MinIterations             = 0x000010;
		//public const UInt32 LoopControl_MaxIterations             = 0x000020;
		//public const UInt32 LoopControl_IterationMultiple         = 0x000040;
		//public const UInt32 LoopControl_PeelCount                 = 0x000080;
		//public const UInt32 LoopControl_PartialCount              = 0x000100;
		//public const UInt32 LoopControl_InitiationIntervalINTEL   = 0x010000;
		//public const UInt32 LoopControl_MaxConcurrencyINTEL       = 0x020000;
		//public const UInt32 LoopControl_DependencyArrayINTEL      = 0x040000;
		//public const UInt32 LoopControl_PipelineEnableINTEL       = 0x080000;
		//public const UInt32 LoopControl_LoopCoalesceINTEL         = 0x100000;
		//public const UInt32 LoopControl_MaxInterleavingINTEL      = 0x200000;
		//public const UInt32 LoopControl_SpeculatedIterationsINTEL = 0x400000;
		//public const UInt32 LoopControl_NoFusionINTEL             = 0x800000;

		//// Function Control

		//public const UInt32 FunctionControl_None         = 0x00000;
		//public const UInt32 FunctionControl_Inline       = 0x00001;
		//public const UInt32 FunctionControl_DontInline   = 0x00002;
		//public const UInt32 FunctionControl_Pure         = 0x00004;
		//public const UInt32 FunctionControl_Const        = 0x00008;
		//public const UInt32 FunctionControl_OptNoneINTEL = 0x10000;

		//// Memory Semantics

		//public const UInt32 MemorySemantics_None                   = 0x0000;
		//public const UInt32 MemorySemantics_Relaxed                = 0x0000;
		//public const UInt32 MemorySemantics_Acquire                = 0x0002;
		//public const UInt32 MemorySemantics_Release                = 0x0004;
		//public const UInt32 MemorySemantics_AcquireRelease         = 0x0008;
		//public const UInt32 MemorySemantics_SequentiallyConsistent = 0x0010;
		//public const UInt32 MemorySemantics_UniformMemory          = 0x0040;
		//public const UInt32 MemorySemantics_SubgroupMemory         = 0x0080;
		//public const UInt32 MemorySemantics_WorkgroupMemory        = 0x0100;
		//public const UInt32 MemorySemantics_CrossWorkgroupMemory   = 0x0200;
		//public const UInt32 MemorySemantics_AtomicCounterMemory    = 0x0400;
		//public const UInt32 MemorySemantics_IamgeMemory            = 0x0800;
		//public const UInt32 MemorySemantics_OutputMemory           = 0x1000;
		//public const UInt32 MemorySemantics_OutputMemoryKHR        = 0x1000;
		//public const UInt32 MemorySemantics_MakeAvailable          = 0x2000;
		//public const UInt32 MemorySemantics_MakeAvailableKHR       = 0x2000;
		//public const UInt32 MemorySemantics_MakeVisible            = 0x4000;
		//public const UInt32 MemorySemantics_MakeVisibleKHR         = 0x4000;
		//public const UInt32 MemorySemantics_Volatile               = 0x8000;

		//// Memory Operands

		//public const UInt32 MemoryOperands_None                    = 0x00000;
		//public const UInt32 MemoryOperands_Volatile                = 0x00001;
		//public const UInt32 MemoryOperands_Aligned                 = 0x00002;
		//public const UInt32 MemoryOperands_Nontemporal             = 0x00004;
		//public const UInt32 MemoryOperands_MakePointerAvailable    = 0x00008;
		//public const UInt32 MemoryOperands_MakePointerAvailableKHR = 0x00008;
		//public const UInt32 MemoryOperands_MakePointerVisible      = 0x00010;
		//public const UInt32 MemoryOperands_MakePointerVisibleKHR   = 0x00010;
		//public const UInt32 MemoryOperands_NonPrivatePointer       = 0x00020;
		//public const UInt32 MemoryOperands_NonPrivatePointerKHR    = 0x00030;
		//public const UInt32 MemoryOperands_AliasScopeINTELMask     = 0x10000;
		//public const UInt32 MemoryOperands_NoAliasINTELMask        = 0x20000;

		//// Scope

		//public const UInt32 Scope_CrossDevice   = 0;
		//public const UInt32 Scope_Device        = 1;
		//public const UInt32 Scope_Workgroup     = 2;
		//public const UInt32 Scope_Subgroup      = 3;
		//public const UInt32 Scope_Invocation    = 4;
		//public const UInt32 Scope_QueueFamily   = 5;
		//public const UInt32 Scope_ShaderCallKHR = 6;

		//// Group Operation

		//public const UInt32 GroupOperation_Reduce                     = 0;
		//public const UInt32 GroupOperation_InclusiveScan              = 1;
		//public const UInt32 GroupOperation_ExclusiveScan              = 2;
		//public const UInt32 GroupOperation_ClusteredReduce            = 3;
		//public const UInt32 GroupOperation_PartitionedReduceNV        = 6;
		//public const UInt32 GroupOperation_PartitionedInclusiveScanNV = 7;
		//public const UInt32 GroupOperation_PartitionedExclusiveScanNV = 8;

		//// Kernel Enqueue Flags

		//public const UInt32 KernelEnqueueFlags_NoWait        = 0;
		//public const UInt32 KernelEnqueueFlags_WaitKernel    = 1;
		//public const UInt32 KernelEnqueueFlags_WaitWorkGroup = 2;

		//// Kernel Profiling Info

		//public const UInt32 KernelProfilingInfo_None        = 0x0;
		//public const UInt32 KernelProfilingInfo_CmdExecTime = 0x1;

		//// Capability

		//public const UInt32 Capability_Matrix                                       =    0;
		//public const UInt32 Capability_Shader                                       =    1;
		//public const UInt32 Capability_Geometry                                     =    2;
		//public const UInt32 Capability_Tessellation                                 =    3;
		//public const UInt32 Capability_Addresses                                    =    4;
		//public const UInt32 Capability_Linkage                                      =    5;
		//public const UInt32 Capability_Kernel                                       =    6;
		//public const UInt32 Capability_Vector16                                     =    7;
		//public const UInt32 Capability_Float16Buffer                                =    8;
		//public const UInt32 Capability_Float16                                      =    9;
		//public const UInt32 Capability_Float64                                      =   10;
		//public const UInt32 Capability_Int64                                        =   11;
		//public const UInt32 Capability_Int64Atomics                                 =   12;
		//public const UInt32 Capability_ImageBasic                                   =   13;
		//public const UInt32 Capability_ImageReadWrite                               =   14;
		//public const UInt32 Capability_ImageMipmap                                  =   15;
		//public const UInt32 Capability_Pipes                                        =   17;
		//public const UInt32 Capability_Groups                                       =   18;
		//public const UInt32 Capability_DeviceEnqueue                                =   19;
		//public const UInt32 Capability_LiteralSampler                               =   20;
		//public const UInt32 Capability_AtomicStorage                                =   21;
		//public const UInt32 Capability_Int16                                        =   22;
		//public const UInt32 Capability_TessellationPointSize                        =   23;
		//public const UInt32 Capability_GeometryPointSize                            =   24;
		//public const UInt32 Capability_ImageGatherExtended                          =   25;
		//public const UInt32 Capability_SorageImageMultisample                       =   27;
		//public const UInt32 Capability_UniformBufferArrayDynamicIndexingBlock       =   28;
		//public const UInt32 Capability_SampledImageArrayDynamicIndexing             =   29;
		//public const UInt32 Capability_StorageBufferArrayDynamicIndexing            =   30;
		//public const UInt32 Capability_StorageImageArrayDynamicIndexing             =   31;
		//public const UInt32 Capability_ClipDistance                                 =   32;
		//public const UInt32 Capability_CullDistance                                 =   33;
		//public const UInt32 Capability_ImageCubeArray                               =   34;
		//public const UInt32 Capability_SampleRateShading                            =   35;
		//public const UInt32 Capability_ImageRect                                    =   36;
		//public const UInt32 Capability_SampledRect                                  =   37;
		//public const UInt32 Capability_GenericPointer                               =   38;
		//public const UInt32 Capability_Int8                                         =   39;
		//public const UInt32 Capability_InputAttachment                              =   40;
		//public const UInt32 Capability_SparseResidency                              =   41;
		//public const UInt32 Capability_MinLod                                       =   42;
		//public const UInt32 Capability_Sampled1D                                    =   43;
		//public const UInt32 Capability_Image1D                                      =   44;
		//public const UInt32 Capability_SampledCubeArray                             =   45;
		//public const UInt32 Capability_SampledBuffer                                =   46;
		//public const UInt32 Capability_ImageBuffer                                  =   47;
		//public const UInt32 Capability_ImageMSArray                                 =   48;
		//public const UInt32 Capability_StorageImageExtendedFormats                  =   49;
		//public const UInt32 Capability_ImageQuery                                   =   50;
		//public const UInt32 Capability_DerivativeControl                            =   51;
		//public const UInt32 Capability_InterpolationFunction                        =   52;
		//public const UInt32 Capability_TransformFeedback                            =   53;
		//public const UInt32 Capability_GeometryStreams                              =   54;
		//public const UInt32 Capability_StorageImageReadWithoutFormat                =   55;
		//public const UInt32 Capability_StorageImageWriteWithoutFormat               =   56;
		//public const UInt32 Capability_MultiViewport                                =   57;
		//public const UInt32 Capability_SubgroupDispatch                             =   58;
		//public const UInt32 Capability_NamedBarrier                                 =   59;
		//public const UInt32 Capability_PipeStorage                                  =   60;
		//public const UInt32 Capability_GroupNonUniform                              =   61;
		//public const UInt32 Capability_GroupNonUniformVote                          =   62;
		//public const UInt32 Capability_GroupNonUniformArithmetic                    =   63;
		//public const UInt32 Capability_GroupNonUniformBallot                        =   64;
		//public const UInt32 Capability_GroupNonUniformShuffle                       =   65;
		//public const UInt32 Capability_GroupNonUniformShuffleRelative               =   66;
		//public const UInt32 Capability_GroupNonUniformClustered                     =   67;
		//public const UInt32 Capability_GroupNonUniformQuad                          =   68;
		//public const UInt32 Capability_ShaderLayer                                  =   69;
		//public const UInt32 Capability_ShaderViewportIndex                          =   70;
		//public const UInt32 Capability_UniformDecoration                            =   71;
		//public const UInt32 Capability_FragmentShadingRateKHR                       = 4422;
		//public const UInt32 Capability_SubgroupBallotKHR                            = 4423;
		//public const UInt32 Capability_DrawParameters                               = 4427;
		//public const UInt32 Capability_WorkgroupMemoryExplicitLayoutKHR             = 4428;
		//public const UInt32 Capability_WorkgroupMemoryExplicitLayout8BitAccessKHR   = 4429;
		//public const UInt32 Capability_WorkgroupMemoryExplicitLayout16BitAccessKHR  = 4430;
		//public const UInt32 Capability_SubgroupVoteKHR                              = 4431;
		//public const UInt32 Capability_StorageBuffer16BitAccess                     = 4433;
		//public const UInt32 Capability_StorageUniformBufferBlock16                  = 4433;
		//public const UInt32 Capability_UniformAndStorageBuffer16BitAccess           = 4434;
		//public const UInt32 Capability_StorageUniform16                             = 4434;
		//public const UInt32 Capability_StoragePushConstant16                        = 4435;
		//public const UInt32 Capability_StorageInputOutput16                         = 4436;
		//public const UInt32 Capability_DeviceGroup                                  = 4437;
		//public const UInt32 Capability_MultiView                                    = 4439;
		//public const UInt32 Capability_VariablePointersStorageBuffer                = 4441;
		//public const UInt32 Capability_VariablePointers                             = 4442;
		//public const UInt32 Capability_AtomicStorageOps                             = 4445;
		//public const UInt32 Capability_SampleMaskPostDepthCoverage                  = 4447;
		//public const UInt32 Capability_StorageBuffer8BitAccess                      = 4448;
		//public const UInt32 Capability_UniformAndStorageBuffer8BitAccess            = 4449;
		//public const UInt32 Capability_StoragePushConstant8                         = 4450;
		//public const UInt32 Capability_DenormPreserve                               = 4464;
		//public const UInt32 Capability_DenormFlushToZero                            = 4465;
		//public const UInt32 Capability_SignedZeroInfNanPreserve                     = 4466;
		//public const UInt32 Capability_RoundingModeRTE                              = 4467;
		//public const UInt32 Capability_RoundingModeRTZ                              = 4468;
		//public const UInt32 Capability_RayQueryProvisionalKHR                       = 4471;
		//public const UInt32 Capability_RayQueryKHR                                  = 4472;
		//public const UInt32 Capability_RayTraversalPrimitiveCullingKHR              = 4478;
		//public const UInt32 Capability_RayTracingKHR                                = 4479;
		//public const UInt32 Capability_Float16ImageAMD                              = 5008;
		//public const UInt32 Capability_ImageGatherBiasLodAMD                        = 5009;
		//public const UInt32 Capability_FragmentMaskAMD                              = 5010;
		//public const UInt32 Capability_StencilExportEXT                             = 5013;
		//public const UInt32 Capability_ImageReadWriteLodAMD                         = 5015;
		//public const UInt32 Capability_Int64ImageEXT                                = 5016;
		//public const UInt32 Capability_ShaderClockKHR                               = 5055;
		//public const UInt32 Capability_SampleMaskOverrideCoverageNV                 = 5249;
		//public const UInt32 Capability_GeometryShaderPassthroughNV                  = 5251;
		//public const UInt32 Capability_ShaderViewportIndexLayerEXT                  = 5254;
		//public const UInt32 Capability_ShaderViewportIndexLayerNV                   = 5254;
		//public const UInt32 Capability_ShaderViewportMaskNV                         = 5255;
		//public const UInt32 Capability_ShaderStereoViewNV                           = 5259;
		//public const UInt32 Capability_PerViewAttributesNV                          = 5260;
		//public const UInt32 Capability_FragmentFullyCoveredEXT                      = 5265;
		//public const UInt32 Capability_MeshShadingNV                                = 5266;
		//public const UInt32 Capability_ImageFootprintNV                             = 5282;
		//public const UInt32 Capability_FragmentBarycentricKHR                       = 5284;
		//public const UInt32 Capability_FragmentBarycentricNV                        = 5284;
		//public const UInt32 Capability_ComputeDerivativeGroupQuadsNV                = 5288;
		//public const UInt32 Capability_FragmentDensityEXT                           = 5291;
		//public const UInt32 Capability_ShadingRateNV                                = 5291;
		//public const UInt32 Capability_GroupNonUniformPartitionedNV                 = 5297;
		//public const UInt32 Capability_ShaderNonUniform                             = 5301;
		//public const UInt32 Capability_ShaderNonUniformEXT                          = 5301;
		//public const UInt32 Capability_RuntimeDescriptorArray                       = 5302;
		//public const UInt32 Capability_RuntimeDescriptorArrayEXT                    = 5302;
		//public const UInt32 Capability_InputAttachmentArrayDynamicIndexing          = 5303;
		//public const UInt32 Capability_InputAttachmentArrayDynamicIndexingEXT       = 5303;
		//public const UInt32 Capability_UniformTexelBufferArrayDynamicIndexing       = 5304;
		//public const UInt32 Capability_UniformTexelBufferArrayDynamicIndexingEXT    = 5304;
		//public const UInt32 Capability_StorageTexelBufferArrayDynamicIndexing       = 5305;
		//public const UInt32 Capability_StorageTexelBufferArrayDynamicIndexingEXT    = 5305;
		//public const UInt32 Capability_UniformBufferArrayNonUniformIndexingBlock    = 5306;
		//public const UInt32 Capability_UniformBufferArrayNonUniformIndexingEXT      = 5306;
		//public const UInt32 Capability_SampledImageArrayNonUniformIndexing          = 5307;
		//public const UInt32 Capability_SampledImageArrayNonUniformIndexingEXT       = 5307;
		//public const UInt32 Capability_StorageBufferArrayNonUniformIndexing         = 5308;
		//public const UInt32 Capability_StorageBufferArrayNonUniformIndexingEXT      = 5308;
		//public const UInt32 Capability_StorageImageArrayNonUniformIndexing          = 5309;
		//public const UInt32 Capability_StorageImageArrayNonUniformIndexingEXT       = 5309;
		//public const UInt32 Capability_InputAttachmentArrayNonUniformIndexing       = 5310;
		//public const UInt32 Capability_InputAttachmentArrayNonUniformIndexingEXT    = 5310;
		//public const UInt32 Capability_UniformTexelBufferArrayNonUniformIndexing    = 5311;
		//public const UInt32 Capability_UniformTexelBufferArrayNonUniformIndexingEXT = 5311;
		//public const UInt32 Capability_StorageTexelBufferArrayNonUniformIndexing    = 5312;
		//public const UInt32 Capability_StorageTexelBufferArrayNonUniformIndexingEXT = 5312;
		//public const UInt32 Capability_RayTracingNV                                 = 5340;
		//public const UInt32 Capability_RayTracingMotionBlurNV                       = 5341;
		//public const UInt32 Capability_VulkanMemoryModel                            = 5345;
		//public const UInt32 Capability_VulkanMemoryModelKHR                         = 5345;
		//public const UInt32 Capability_VulkanMemoryModelDeviceScope                 = 5346;
		//public const UInt32 Capability_VulkanMemoryModelDeviceScopeKHR              = 5346;
		//public const UInt32 Capability_PhysicalStorageBufferAddresses               = 5347;
		//public const UInt32 Capability_PhysicalStorageBufferAddressesEXT            = 5347;
		//public const UInt32 Capability_ComputeDerivativeGroupLinearNV               = 5350;
		//public const UInt32 Capability_RayTracingProvisionalKHR                     = 5353;
		//public const UInt32 Capability_CooperativeMatrixNV                          = 5357;
		//public const UInt32 Capability_FragmentShaderSampleInterlockEXT             = 5363;
		//public const UInt32 Capability_FragmentShaderShadingRateInterlockEXT        = 5372;
		//public const UInt32 Capability_ShaderSMBuiltinsNV                           = 5373;
		//public const UInt32 Capability_FragmentShaderPixelInterlockEXT              = 5378;
		//public const UInt32 Capability_DemoteToHelperInvocation                     = 5379;
		//public const UInt32 Capability_DemoteToHelperInvocationEXT                  = 5379;
		//public const UInt32 Capability_BindlessTextureNV                            = 5390;
		//public const UInt32 Capability_SubgroupShuffleINTEL                         = 5568;
		//public const UInt32 Capability_SubgroupBufferBlockIOINTEL                   = 5569;
		//public const UInt32 Capability_SubgroupImageBlockIOINTEL                    = 5570;
		//public const UInt32 Capability_SubgroupImageMediaBlockIOINTEL               = 5579;
		//public const UInt32 Capability_RoundToInfinityINTEL                         = 5582;
		//public const UInt32 Capability_FloatingPointModeINTEL                       = 5583;
		//public const UInt32 Capability_IntegerFunctions2INTEL                       = 5584;
		//public const UInt32 Capability_FunctionPointersINTEL                        = 5603;
		//public const UInt32 Capability_IndirectReferencesINTEL                      = 5604;
		//public const UInt32 Capability_AsmINTEL                                     = 5606;
		//public const UInt32 Capability_AtomicFloat32MinMaxEXT                       = 5612;
		//public const UInt32 Capability_AtomicFloat64MinMaxEXT                       = 5613;
		//public const UInt32 Capability_AtomicFloat16MinMaxEXT                       = 5616;
		//public const UInt32 Capability_VectorComputeINTEL                           = 5617;
		//public const UInt32 Capability_VectorAnyINTEL                               = 5619;
		//public const UInt32 Capability_ExpectAssumeKHR                              = 5629;
		//public const UInt32 Capability_SubgroupAvcMotionEstimationINTEL             = 5696;
		//public const UInt32 Capability_SubgroupAvcMotionEstimationIntralINTEL       = 5697;
		//public const UInt32 Capability_SubgroupAvcMotionEstimationChromaINTEL       = 5698;
		//public const UInt32 Capability_VariableLengthArrayINTEL                     = 5817;
		//public const UInt32 Capability_FunctionFloatControlINTEL                    = 5821;
		//public const UInt32 Capability_FPGAMemoryAttributesINTEL                    = 5824;
		//public const UInt32 Capability_FPFastMathModeINTEL                          = 5837;
		//public const UInt32 Capability_ArbitraryPrecisionIntegersINTEL              = 5844;
		//public const UInt32 Capability_ArbitraryPrecisionFloatingPointINTEL         = 5845;
		//public const UInt32 Capability_UnstructuredLoopControlsINTEL                = 5886;
		//public const UInt32 Capability_FPGALoopControlsINTEL                        = 5888;
		//public const UInt32 Capability_KernelAttributesINTEL                        = 5892;
		//public const UInt32 Capability_FPGAKernelAttributesINTEL                    = 5897;
		//public const UInt32 Capability_FPGAMemoryAccessesINTEL                      = 5898;
		//public const UInt32 Capability_FPGAClusterAttributesINTEL                   = 5904;
		//public const UInt32 Capability_LoopFuseINTEL                                = 5906;
		//public const UInt32 Capability_MemoryAccessAliasingINTEL                    = 5910;
		//public const UInt32 Capability_FPGABufferLocationINTEL                      = 5920;
		//public const UInt32 Capability_ArbitraryPrecisionFixedPointINTEL            = 5922;
		//public const UInt32 Capability_USMStorageClassesINTEL                       = 5935;
		//public const UInt32 Capability_IOPipesINTEL                                 = 5943;
		//public const UInt32 Capability_BlockingPipesINTEL                           = 5945;
		//public const UInt32 Capability_FPGARegINTEL                                 = 5948;
		//public const UInt32 Capability_DotProductInputAll                           = 6016;
		//public const UInt32 Capability_DotProductInputAllKHR                        = 6016;
		//public const UInt32 Capability_DotProductInput4x8Bit                        = 6017;
		//public const UInt32 Capability_DotProductInput4x8BitKHR                     = 6017;
		//public const UInt32 Capability_DotProductInput4x8BitPacked                  = 6018;
		//public const UInt32 Capability_DotProductInput4x8BitPackedKHR               = 6018;
		//public const UInt32 Capability_DotProduct                                   = 6019;
		//public const UInt32 Capability_DotProductKHR                                = 6019;
		//public const UInt32 Capability_RayCullMaskKHR                               = 6020;
		//public const UInt32 Capability_BitInstructions                              = 6025;
		//public const UInt32 Capability_GroupNonUniformRotateKHR                     = 6026;
		//public const UInt32 Capability_AtomicFloat32AddEXT                          = 6033;
		//public const UInt32 Capability_AtomicFloat64AddEXT                          = 6034;
		//public const UInt32 Capability_LongConstantCompositeINTEL                   = 6089;
		//public const UInt32 Capability_OptNoneINTEL                                 = 6094;
		//public const UInt32 Capability_AtomicFloat16AddEXT                          = 6095;
		//public const UInt32 Capability_DebugInfoModuleINTEL                         = 6114;
		//public const UInt32 Capability_SplitBarrierINTEL                            = 6141;
		//public const UInt32 Capability_GroupUniformArithmeticKHR                    = 6400;

		//// Reserved Ray Flags

		//public const UInt32 ReservedRayFlags_None                        = 0x000;
		//public const UInt32 ReservedRayFlags_OpaqueKHR                   = 0x001;
		//public const UInt32 ReservedRayFlags_NoOpaqueKHR                 = 0x002;
		//public const UInt32 ReservedRayFlags_TerminateOnFirstHitKHR      = 0x004;
		//public const UInt32 ReservedRayFlags_SkipClosestHitShaderKHR     = 0x008;
		//public const UInt32 ReservedRayFlags_CullBackFacingTrianglesKHR  = 0x010;
		//public const UInt32 ReservedRayFlags_CullFrontFacingTrianglesKHR = 0x020;
		//public const UInt32 ReservedRayFlags_CullOpaqueKHR               = 0x040;
		//public const UInt32 ReservedRayFlags_CullNoOpqueKHR              = 0x080;
		//public const UInt32 ReservedRayFlags_SkipTrianglesKHR            = 0x100;
		//public const UInt32 ReservedRayFlags_SkipAABBsKHR                = 0x200;

		//// Reserved Ray Query Intersection

		//public const UInt32 ReservedRayQueryIntersection_RayQueryCandidateIntersectionKHR = 0;
		//public const UInt32 ReservedRayQueryIntersection_RayQueryCommittedIntersectionKHR = 1;

		//// Reserved Ray Query Committed Type

		//public const UInt32 ReservedRayQueryCommittedType_RayQueryCommittedIntersectionNoneKHR      = 0;
		//public const UInt32 ReservedRayQueryCommittedType_RayQueryCommittedIntersectionTriangleKHR  = 1;
		//public const UInt32 ReservedRayQueryCommittedType_RayQueryCommittedIntersectionGeneratedKHR = 2;

		//// Reserved Ray Query Candidate Type

		//public const UInt32 ReservedRayQueryCandidateType_RayQueryCandidateIntersectionTriangleKHR = 0;
		//public const UInt32 ReservedRayQueryCandidateType_RayQueryCandidateIntersectionAABBKHR     = 1;

		//// Reserved Fragment Shading Rate

		//public const UInt32 ReservedFragmentShadingRate_None              = 0x0;
		//public const UInt32 ReservedFragmentShadingRate_Vertical2Pixels   = 0x1;
		//public const UInt32 ReservedFragmentShadingRate_Vertical4Pixels   = 0x2;
		//public const UInt32 ReservedFragmentShadingRate_Horizontal2Pixels = 0x4;
		//public const UInt32 ReservedFragmentShadingRate_Horizontal4Pixels = 0x8;

		//// Reserved FP Denorm Mode

		//public const UInt32 ReservedFPDenormMode_Preserve    = 0;
		//public const UInt32 ReservedFPDenormMode_FlushToZero = 1;

		//// Reserved FP Operation Mode

		//public const UInt32 ReservedFPOperationMode_IEEE = 0;
		//public const UInt32 ReservedFPOperationMode_ALT  = 1;

		//// Quantization Mode

		//public const UInt32 QuantizationMode_TRN          = 0;
		//public const UInt32 QuantizationMode_TRN_ZERO     = 1;
		//public const UInt32 QuantizationMode_RND          = 2;
		//public const UInt32 QuantizationMode_RND_ZERO     = 3;
		//public const UInt32 QuantizationMode_RND_INF      = 4;
		//public const UInt32 QuantizationMode_RND_MIN_INF  = 5;
		//public const UInt32 QuantizationMode_RND_CONV     = 6;
		//public const UInt32 QuantizationMode_RND_CONV_ODD = 7;

		//// Overflow Mode

		//public const UInt32 OverflowMode_WRAP     = 0;
		//public const UInt32 OverflowMode_SAT      = 1;
		//public const UInt32 OverflowMode_SAT_ZERO = 2;
		//public const UInt32 OverflowMode_SAT_SYM  = 3;

		//// Packed Vector Format

		//public const UInt32 PackedVectorFormat4x8Bit    = 0;
		//public const UInt32 PackedVectorFormat4x8BitKHR = 0;

	}
}
