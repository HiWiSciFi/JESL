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
			RayGenerationKHR       = RayGenerationNV,
			IntersectionNV         = 5314,
			IntersectionKHR        = IntersectionNV,
			AnyHitNV               = 5315,
			AnyHitKHR              = AnyHitNV,
			ClosestHitNV           = 5316,
			ClosestHitKHR          = ClosestHitNV,
			MissNV                 = 5317,
			MissKHR                = MissNV,
			CallableNV             = 5318,
			CallableKHR            = CallableNV
		}

		public enum AddressingModel : UInt32
		{
			Logical                    =    0,
			Physical32                 =    1,
			Physical64                 =    2,
			PhysicalStorageBuffer64    = 5348,
			PhysicalStorageBuffer64EXT = PhysicalStorageBuffer64
		}

		public enum MemoryModel : UInt32
		{
			Simple    = 0,
			GLSL450   = 1,
			OpenCL    = 2,
			Vulkan    = 3,
			VulkanKHR = Vulkan
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
			CallableDataKHR          = CallableDataNV,
			IncomingCallableDataNV   = 5329,
			IncomingCallableDataKHR  = IncomingCallableDataNV,
			RayPayloadNV             = 5338,
			RayPayloadKHR            = RayPayloadNV,
			HitAttributeNV           = 5339,
			HitAttributeKHR          = HitAttributeNV,
			IncomingRayPayloadNV     = 5342,
			IncomingRayPayloadKHR    = IncomingRayPayloadNV,
			ShaderRecordBufferNV     = 5343,
			ShaderRecordBufferKHR    = ShaderRecordBufferNV,
			PhysicalStorageBuffer    = 5349,
			PhysicalStorageBufferEXT = PhysicalStorageBuffer,
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
			MakeTexelAvailableKHR = MakeTexelAvailable,
			MakeTexelVisible      = 0x00200,
			MakeTexelVisibleKHR   = MakeTexelVisible,
			NonPrivateTexel       = 0x00400,
			NonPrivateTexelKHR    = NonPrivateTexel,
			VolatileTexel         = 0x00800,
			VolatileTexelKHR      = VolatileTexel,
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
			PerVertexNV                        = PerVertexKHR,
			NonUniform                         = 5300,
			NonUniformEXT                      = NonUniform,
			RestrictPointer                    = 5355,
			RestrictPointerEXT                 = RestrictPointer,
			AliasedPointer                     = 5356,
			AliasedPointerEXT                  = AliasedPointer,
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
			HlslCounterBufferGOOGLE            = CounterBuffer,
			UserSemantic                       = 5635,
			HlslSemanticGOOGLE                 = UserSemantic,
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
			SubgroupEqMaskKHR           = SubgroupEqMask,
			SubgroupGeMask              = 4417,
			SubgroupGeMaskKHR           = SubgroupGeMask,
			SubgroupGtMask              = 4418,
			SubgroupGtMaskKHR           = SubgroupGtMask,
			SubgroupLeMask              = 4419,
			SubgroupLeMaskKHR           = SubgroupLeMask,
			SubgroupLtMask              = 4420,
			SubgroupLtMaskKHR           = SubgroupLtMask,
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
			BaryCoordNV                 = BaryCoordKHR,
			BaryCoordNoPerspKHR         = 5287,
			BaryCoordNoPerspNV          = BaryCoordNoPerspKHR,
			FragSizeEXT                 = 5292,
			FragmentSizeNV              = FragSizeEXT,
			FragInvocationCountEXT      = 5293,
			InvocationsPerPixelNV       = FragInvocationCountEXT,
			LaunchIdNV                  = 5319,
			LaunchIdKHR                 = LaunchIdNV,
			LaunchSizeNV                = 5320,
			LaunchSizeKHR               = LaunchSizeNV,
			WorldRayOriginNV            = 5321,
			WorldRayOriginKHR           = WorldRayOriginNV,
			WorldRayDirectionNV         = 5322,
			WorldRayDirectionKHR        = WorldRayDirectionNV,
			ObjectRayOriginNV           = 5323,
			ObjectRayOriginKHR          = ObjectRayOriginNV,
			ObjectRayDirectionNV        = 5324,
			ObjectrayDirectionKHR       = ObjectRayDirectionNV,
			RayTminNV                   = 5325,
			RayTminKHR                  = RayTminNV,
			RayTmaxNV                   = 5326,
			RayTmaxKHR                  = RayTmaxNV,
			InstanceCustomIndexNV       = 5327,
			InstanceCustomIndexKHR      = InstanceCustomIndexNV,
			ObjectToWorldNV             = 5330,
			ObjectToWorldKHR            = ObjectToWorldNV,
			WorldToObjectNV             = 5331,
			WorldToObjectKHR            = WorldToObjectNV,
			HitTNV                      = 5332,
			HitKindNV                   = 5333,
			HitKindKHR                  = HitKindNV,
			CurrentRayTimeNV            = 5334,
			IncomingRayFlagsNV          = 5351,
			IncomingRayFlagsKHR         = IncomingRayFlagsNV,
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
			Relaxed                = None,
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
			OutputMemoryKHR        = OutputMemory,
			MakeAvailable          = 0x2000,
			MakeAvailableKHR       = MakeAvailable,
			MakeVisible            = 0x4000,
			MakeVisibleKHR         = MakeVisible,
			Volatile               = 0x8000
		}

		public enum MemoryOperands : UInt32
		{
			None                    = 0x00000,
			Volatile                = 0x00001,
			Aligned                 = 0x00002,
			Nontemporal             = 0x00004,
			MakePointerAvailable    = 0x00008,
			MakePointerAvailableKHR = MakePointerAvailable,
			MakePointerVisible      = 0x00010,
			MakePointerVisibleKHR   = MakePointerVisible,
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
			StorageUniformBufferBlock16                  = StorageBuffer16BitAccess,
			UniformAndStorageBuffer16BitAccess           = 4434,
			StorageUniform16                             = UniformAndStorageBuffer16BitAccess,
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
			ShaderViewportIndexLayerNV                   = ShaderViewportIndexLayerEXT,
			ShaderViewportMaskNV                         = 5255,
			ShaderStereoViewNV                           = 5259,
			PerViewAttributesNV                          = 5260,
			FragmentFullyCoveredEXT                      = 5265,
			MeshShadingNV                                = 5266,
			ImageFootprintNV                             = 5282,
			FragmentBarycentricKHR                       = 5284,
			FragmentBarycentricNV                        = FragmentBarycentricKHR,
			ComputeDerivativeGroupQuadsNV                = 5288,
			FragmentDensityEXT                           = 5291,
			ShadingRateNV                                = FragmentDensityEXT,
			GroupNonUniformPartitionedNV                 = 5297,
			ShaderNonUniform                             = 5301,
			ShaderNonUniformEXT                          = ShaderNonUniform,
			RuntimeDescriptorArray                       = 5302,
			RuntimeDescriptorArrayEXT                    = RuntimeDescriptorArray,
			InputAttachmentArrayDynamicIndexing          = 5303,
			InputAttachmentArrayDynamicIndexingEXT       = InputAttachmentArrayDynamicIndexing,
			UniformTexelBufferArrayDynamicIndexing       = 5304,
			UniformTexelBufferArrayDynamicIndexingEXT    = UniformTexelBufferArrayDynamicIndexing,
			StorageTexelBufferArrayDynamicIndexing       = 5305,
			StorageTexelBufferArrayDynamicIndexingEXT    = StorageTexelBufferArrayDynamicIndexing,
			UniformBufferArrayNonUniformIndexingBlock    = 5306,
			UniformBufferArrayNonUniformIndexingEXT      = UniformBufferArrayNonUniformIndexingBlock,
			SampledImageArrayNonUniformIndexing          = 5307,
			SampledImageArrayNonUniformIndexingEXT       = SampledImageArrayNonUniformIndexing,
			StorageBufferArrayNonUniformIndexing         = 5308,
			StorageBufferArrayNonUniformIndexingEXT      = StorageBufferArrayNonUniformIndexing,
			StorageImageArrayNonUniformIndexing          = 5309,
			StorageImageArrayNonUniformIndexingEXT       = StorageImageArrayNonUniformIndexing,
			InputAttachmentArrayNonUniformIndexing       = 5310,
			InputAttachmentArrayNonUniformIndexingEXT    = InputAttachmentArrayNonUniformIndexing,
			UniformTexelBufferArrayNonUniformIndexing    = 5311,
			UniformTexelBufferArrayNonUniformIndexingEXT = UniformTexelBufferArrayNonUniformIndexing,
			StorageTexelBufferArrayNonUniformIndexing    = 5312,
			StorageTexelBufferArrayNonUniformIndexingEXT = StorageTexelBufferArrayNonUniformIndexing,
			RayTracingNV                                 = 5340,
			RayTracingMotionBlurNV                       = 5341,
			VulkanMemoryModel                            = 5345,
			VulkanMemoryModelKHR                         = VulkanMemoryModel,
			VulkanMemoryModelDeviceScope                 = 5346,
			VulkanMemoryModelDeviceScopeKHR              = VulkanMemoryModelDeviceScope,
			PhysicalStorageBufferAddresses               = 5347,
			PhysicalStorageBufferAddressesEXT            = PhysicalStorageBufferAddresses,
			ComputeDerivativeGroupLinearNV               = 5350,
			RayTracingProvisionalKHR                     = 5353,
			CooperativeMatrixNV                          = 5357,
			FragmentShaderSampleInterlockEXT             = 5363,
			FragmentShaderShadingRateInterlockEXT        = 5372,
			ShaderSMBuiltinsNV                           = 5373,
			FragmentShaderPixelInterlockEXT              = 5378,
			DemoteToHelperInvocation                     = 5379,
			DemoteToHelperInvocationEXT                  = DemoteToHelperInvocation,
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
			DotProductInputAllKHR                        = DotProductInputAll,
			DotProductInput4x8Bit                        = 6017,
			DotProductInput4x8BitKHR                     = DotProductInput4x8Bit,
			DotProductInput4x8BitPacked                  = 6018,
			DotProductInput4x8BitPackedKHR               = DotProductInput4x8BitPacked,
			DotProduct                                   = 6019,
			DotProductKHR                                = DotProduct,
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
			PackedVectorFormat4x8BitKHR = PackedVectorFormat4x8Bit
		}
	}
}
