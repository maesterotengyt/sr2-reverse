// Namespace: Quantum
public class FramePrinter // TypeDefIndex: 11624
{
	// Fields
	private int _scope; // 0x10
	private string _scopeString; // 0x18
	private FrameBase _frame; // 0x20
	private readonly StringBuilder _sb; // 0x28
	private readonly MethodInfo _primitivePrinter; // 0x30
	private readonly Dictionary<Type, FramePrinter.ReflectObjectType> _reflectObjectLookup; // 0x38
	private readonly Dictionary<Type, FramePrinter.ReflectStructType> _reflectStructLookup; // 0x40
	private readonly HashSet<string> _prettyPrintAlwaysTypes; // 0x48
	private readonly HashSet<string> _prettyPrintTypes; // 0x50
	[CompilerGenerated]
	private bool <IsRawPrintEnabled>k__BackingField; // 0x58

	// Properties
	public FrameBase Frame { get; }
	public bool IsRawPrintEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static void EnsurePrimitiveNotStripped<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB535B0 Offset: 0xB51BB0 VA: 0x180B535B0
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRef>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefCharacterController2DConfig>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefCharacterController3DConfig>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefEntityPrototype>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefEntityView>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefMap>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefNavMesh>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefNavMeshAgentConfig>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefPhysicsMaterial>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefPolygonCollider>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefTerrainCollider>
	|
	|-RVA: 0xB53530 Offset: 0xB51B30 VA: 0x180B53530
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefAnimationBakedJointsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefAnimationClipData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefAnimationsPoolData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefApplyImpulse_Behaviour>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefAttackDatasPool>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefBaseGameMode>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefCameraManagerData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefCombatData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefCombatSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefGameEntityData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefGameSpeedModifiersData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefGameplayInputSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefGlobalCameraSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefGrabData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefInputCheck_Behaviour>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefItemsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefJumpSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefMovesetLimiterData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefNPCSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefPhysicsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefPickupItemUsageData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefPlayerSettings>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefRoomConfig>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefSpeedRunnersSettingsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefState>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefStateBehaviour>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefStateMachineData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefStatusEffectBase>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefStatusEffectsData>
	|-FramePrinter.EnsurePrimitiveNotStripped<AssetRefTransformKeyFramesData>
	|
	|-RVA: 0xB53630 Offset: 0xB51C30 VA: 0x180B53630
	|-FramePrinter.EnsurePrimitiveNotStripped<bool>
	|
	|-RVA: 0xB536C0 Offset: 0xB51CC0 VA: 0x180B536C0
	|-FramePrinter.EnsurePrimitiveNotStripped<Button>
	|
	|-RVA: 0xB537E0 Offset: 0xB51DE0 VA: 0x180B537E0
	|-FramePrinter.EnsurePrimitiveNotStripped<byte>
	|
	|-RVA: 0xB53740 Offset: 0xB51D40 VA: 0x180B53740
	|-FramePrinter.EnsurePrimitiveNotStripped<ByteEnum>
	|
	|-RVA: 0xB53860 Offset: 0xB51E60 VA: 0x180B53860
	|-FramePrinter.EnsurePrimitiveNotStripped<char>
	|
	|-RVA: 0xB538F0 Offset: 0xB51EF0 VA: 0x180B538F0
	|-FramePrinter.EnsurePrimitiveNotStripped<double>
	|
	|-RVA: 0xB53970 Offset: 0xB51F70 VA: 0x180B53970
	|-FramePrinter.EnsurePrimitiveNotStripped<EntityRef>
	|
	|-RVA: 0xB53C10 Offset: 0xB52210 VA: 0x180B53C10
	|-FramePrinter.EnsurePrimitiveNotStripped<FP>
	|
	|-RVA: 0xB539F0 Offset: 0xB51FF0 VA: 0x180B539F0
	|-FramePrinter.EnsurePrimitiveNotStripped<FPBounds2>
	|-FramePrinter.EnsurePrimitiveNotStripped<NullableFPVector3>
	|
	|-RVA: 0xB53A90 Offset: 0xB52090 VA: 0x180B53A90
	|-FramePrinter.EnsurePrimitiveNotStripped<FPQuaternion>
	|
	|-RVA: 0xB53B10 Offset: 0xB52110 VA: 0x180B53B10
	|-FramePrinter.EnsurePrimitiveNotStripped<FPVector2>
	|
	|-RVA: 0xB53B90 Offset: 0xB52190 VA: 0x180B53B90
	|-FramePrinter.EnsurePrimitiveNotStripped<FPVector3>
	|
	|-RVA: 0xB53CC0 Offset: 0xB522C0 VA: 0x180B53CC0
	|-FramePrinter.EnsurePrimitiveNotStripped<short>
	|
	|-RVA: 0xB53DE0 Offset: 0xB523E0 VA: 0x180B53DE0
	|-FramePrinter.EnsurePrimitiveNotStripped<int>
	|
	|-RVA: 0xB53D40 Offset: 0xB52340 VA: 0x180B53D40
	|-FramePrinter.EnsurePrimitiveNotStripped<Int32Enum>
	|
	|-RVA: 0xB53E60 Offset: 0xB52460 VA: 0x180B53E60
	|-FramePrinter.EnsurePrimitiveNotStripped<long>
	|
	|-RVA: 0xB53EE0 Offset: 0xB524E0 VA: 0x180B53EE0
	|-FramePrinter.EnsurePrimitiveNotStripped<IntPtr>
	|
	|-RVA: 0xB54000 Offset: 0xB52600 VA: 0x180B54000
	|-FramePrinter.EnsurePrimitiveNotStripped<NullableFP>
	|
	|-RVA: 0xB53F60 Offset: 0xB52560 VA: 0x180B53F60
	|-FramePrinter.EnsurePrimitiveNotStripped<NullableFPVector2>
	|
	|-RVA: 0xB540A0 Offset: 0xB526A0 VA: 0x180B540A0
	|-FramePrinter.EnsurePrimitiveNotStripped<NullableNonNegativeFP>
	|
	|-RVA: 0xB54120 Offset: 0xB52720 VA: 0x180B54120
	|-FramePrinter.EnsurePrimitiveNotStripped<PlayerRef>
	|
	|-RVA: 0xB541A0 Offset: 0xB527A0 VA: 0x180B541A0
	|-FramePrinter.EnsurePrimitiveNotStripped<QBoolean>
	|
	|-RVA: 0xB54220 Offset: 0xB52820 VA: 0x180B54220
	|-FramePrinter.EnsurePrimitiveNotStripped<QString128>
	|
	|-RVA: 0xB542E0 Offset: 0xB528E0 VA: 0x180B542E0
	|-FramePrinter.EnsurePrimitiveNotStripped<QString256>
	|
	|-RVA: 0xB543B0 Offset: 0xB529B0 VA: 0x180B543B0
	|-FramePrinter.EnsurePrimitiveNotStripped<QString64>
	|
	|-RVA: 0xB54440 Offset: 0xB52A40 VA: 0x180B54440
	|-FramePrinter.EnsurePrimitiveNotStripped<QStringUtf8_64>
	|
	|-RVA: 0xB544D0 Offset: 0xB52AD0 VA: 0x180B544D0
	|-FramePrinter.EnsurePrimitiveNotStripped<RNGSession>
	|
	|-RVA: 0xB54550 Offset: 0xB52B50 VA: 0x180B54550
	|-FramePrinter.EnsurePrimitiveNotStripped<sbyte>
	|
	|-RVA: 0xB545D0 Offset: 0xB52BD0 VA: 0x180B545D0
	|-FramePrinter.EnsurePrimitiveNotStripped<float>
	|
	|-RVA: 0xB546F0 Offset: 0xB52CF0 VA: 0x180B546F0
	|-FramePrinter.EnsurePrimitiveNotStripped<ushort>
	|
	|-RVA: 0xB54650 Offset: 0xB52C50 VA: 0x180B54650
	|-FramePrinter.EnsurePrimitiveNotStripped<UInt16Enum>
	|
	|-RVA: 0xB54770 Offset: 0xB52D70 VA: 0x180B54770
	|-FramePrinter.EnsurePrimitiveNotStripped<uint>
	|
	|-RVA: 0xB547F0 Offset: 0xB52DF0 VA: 0x180B547F0
	|-FramePrinter.EnsurePrimitiveNotStripped<ulong>
	|
	|-RVA: 0xB54870 Offset: 0xB52E70 VA: 0x180B54870
	|-FramePrinter.EnsurePrimitiveNotStripped<UIntPtr>
	|
	|-RVA: 0xB53C90 Offset: 0xB52290 VA: 0x180B53C90
	|-FramePrinter.EnsurePrimitiveNotStripped<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21CF9F0 Offset: 0x21CDFF0 VA: 0x1821CF9F0
	public static void EnsureNotStripped() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public FrameBase get_Frame() { }

	[CompilerGenerated]
	// RVA: 0x5818C0 Offset: 0x57FEC0 VA: 0x1805818C0
	public bool get_IsRawPrintEnabled() { }

	[CompilerGenerated]
	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	public void set_IsRawPrintEnabled(bool value) { }

	// RVA: 0x21D1A20 Offset: 0x21D0020 VA: 0x1821D1A20
	public void .ctor() { }

	// RVA: 0x21D18E0 Offset: 0x21CFEE0 VA: 0x1821D18E0
	public void Reset(FrameBase frame) { }

	// RVA: 0x21D15E0 Offset: 0x21CFBE0 VA: 0x1821D15E0
	public void LineBegin() { }

	// RVA: 0x21D15A0 Offset: 0x21CFBA0 VA: 0x1821D15A0
	public void LineBegin(string text) { }

	// RVA: 0x21D1630 Offset: 0x21CFC30 VA: 0x1821D1630
	public void LineWrite(string text) { }

	// RVA: 0x21CE7A0 Offset: 0x21CCDA0 VA: 0x1821CE7A0
	public void LineEnd() { }

	// RVA: 0x21D1610 Offset: 0x21CFC10 VA: 0x1821D1610
	public void LineEnd(string text) { }

	// RVA: 0x21CE7A0 Offset: 0x21CCDA0 VA: 0x1821CE7A0
	public void AddLine() { }

	// RVA: 0x21CE7C0 Offset: 0x21CCDC0 VA: 0x1821CE7C0
	public void AddLine(string line) { }

	// RVA: -1 Offset: -1
	public void AddPointer<T>(string name, T* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB534C0 Offset: 0xB51AC0 VA: 0x180B534C0
	|-FramePrinter.AddPointer<EntityInfo>
	|-FramePrinter.AddPointer<__Il2CppFullySharedGenericStructType>
	|-FramePrinter.AddPointer<_globals_>
	*/

	// RVA: 0x21CEC60 Offset: 0x21CD260 VA: 0x1821CEC60
	public void AddPointer(string name, void* ptr, Type type) { }

	// RVA: 0x21D1310 Offset: 0x21CF910 VA: 0x1821D1310
	public bool IsComplexPointerType(Type type) { }

	// RVA: 0x21CEAD0 Offset: 0x21CD0D0 VA: 0x1821CEAD0
	private void AddPointerInternal(byte* ptr, Type type) { }

	// RVA: 0x21D1930 Offset: 0x21CFF30 VA: 0x1821D1930
	private Ptr ResolvePtrField(byte* ptr, FramePrinter.ReflectStructField rf) { }

	// RVA: 0x21D1690 Offset: 0x21CFC90 VA: 0x1821D1690
	private static int ReadPrimitiveFieldValue(byte* ptr, FramePrinter.ReflectStructField rf) { }

	// RVA: 0x21CED20 Offset: 0x21CD320 VA: 0x1821CED20
	private void AddStructCollection(byte* p, FramePrinter.ReflectStructField rf) { }

	// RVA: 0x21CE840 Offset: 0x21CCE40 VA: 0x1821CE840
	public void AddObject(string name, object value) { }

	// RVA: 0x21D1950 Offset: 0x21CFF50 VA: 0x1821D1950
	public void ScopeBegin() { }

	// RVA: 0x21D1960 Offset: 0x21CFF60 VA: 0x1821D1960
	public void ScopeEnd() { }

	// RVA: 0x21D1970 Offset: 0x21CFF70 VA: 0x1821D1970 Slot: 3
	public override string ToString() { }

	// RVA: 0x21D19A0 Offset: 0x21CFFA0 VA: 0x1821D19A0
	private void UpdateScopeString() { }

	// RVA: -1 Offset: -1
	public static void PrimitivePrinter<T>(string name, void* ptr, FramePrinter printer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB54980 Offset: 0xB52F80 VA: 0x180B54980
	|-FramePrinter.PrimitivePrinter<AssetRef>
	|-FramePrinter.PrimitivePrinter<AssetRefCharacterController2DConfig>
	|-FramePrinter.PrimitivePrinter<AssetRefCharacterController3DConfig>
	|-FramePrinter.PrimitivePrinter<AssetRefEntityPrototype>
	|-FramePrinter.PrimitivePrinter<AssetRefEntityView>
	|-FramePrinter.PrimitivePrinter<AssetRefMap>
	|-FramePrinter.PrimitivePrinter<AssetRefNavMesh>
	|-FramePrinter.PrimitivePrinter<AssetRefNavMeshAgentConfig>
	|-FramePrinter.PrimitivePrinter<AssetRefPhysicsMaterial>
	|-FramePrinter.PrimitivePrinter<AssetRefPolygonCollider>
	|-FramePrinter.PrimitivePrinter<AssetRefTerrainCollider>
	|
	|-RVA: 0xB548F0 Offset: 0xB52EF0 VA: 0x180B548F0
	|-FramePrinter.PrimitivePrinter<AssetRefAnimationBakedJointsData>
	|-FramePrinter.PrimitivePrinter<AssetRefAnimationClipData>
	|-FramePrinter.PrimitivePrinter<AssetRefAnimationsPoolData>
	|-FramePrinter.PrimitivePrinter<AssetRefApplyImpulse_Behaviour>
	|-FramePrinter.PrimitivePrinter<AssetRefAttackDatasPool>
	|-FramePrinter.PrimitivePrinter<AssetRefBaseGameMode>
	|-FramePrinter.PrimitivePrinter<AssetRefCameraManagerData>
	|-FramePrinter.PrimitivePrinter<AssetRefCombatData>
	|-FramePrinter.PrimitivePrinter<AssetRefCombatSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefGameEntityData>
	|-FramePrinter.PrimitivePrinter<AssetRefGameSpeedModifiersData>
	|-FramePrinter.PrimitivePrinter<AssetRefGameplayInputSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefGlobalCameraSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefGrabData>
	|-FramePrinter.PrimitivePrinter<AssetRefInputCheck_Behaviour>
	|-FramePrinter.PrimitivePrinter<AssetRefItemsData>
	|-FramePrinter.PrimitivePrinter<AssetRefJumpSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefMovesetLimiterData>
	|-FramePrinter.PrimitivePrinter<AssetRefNPCSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefPhysicsData>
	|-FramePrinter.PrimitivePrinter<AssetRefPickupItemUsageData>
	|-FramePrinter.PrimitivePrinter<AssetRefPlayerSettings>
	|-FramePrinter.PrimitivePrinter<AssetRefRoomConfig>
	|-FramePrinter.PrimitivePrinter<AssetRefSpeedRunnersSettingsData>
	|-FramePrinter.PrimitivePrinter<AssetRefState>
	|-FramePrinter.PrimitivePrinter<AssetRefStateBehaviour>
	|-FramePrinter.PrimitivePrinter<AssetRefStateMachineData>
	|-FramePrinter.PrimitivePrinter<AssetRefStatusEffectBase>
	|-FramePrinter.PrimitivePrinter<AssetRefStatusEffectsData>
	|-FramePrinter.PrimitivePrinter<AssetRefTransformKeyFramesData>
	|
	|-RVA: 0xB54A10 Offset: 0xB53010 VA: 0x180B54A10
	|-FramePrinter.PrimitivePrinter<bool>
	|
	|-RVA: 0xB54AB0 Offset: 0xB530B0 VA: 0x180B54AB0
	|-FramePrinter.PrimitivePrinter<Button>
	|
	|-RVA: 0xB54C00 Offset: 0xB53200 VA: 0x180B54C00
	|-FramePrinter.PrimitivePrinter<byte>
	|
	|-RVA: 0xB54B50 Offset: 0xB53150 VA: 0x180B54B50
	|-FramePrinter.PrimitivePrinter<ByteEnum>
	|
	|-RVA: 0xB54C90 Offset: 0xB53290 VA: 0x180B54C90
	|-FramePrinter.PrimitivePrinter<char>
	|
	|-RVA: 0xB54D30 Offset: 0xB53330 VA: 0x180B54D30
	|-FramePrinter.PrimitivePrinter<double>
	|
	|-RVA: 0xB54DC0 Offset: 0xB533C0 VA: 0x180B54DC0
	|-FramePrinter.PrimitivePrinter<EntityRef>
	|
	|-RVA: 0xB550F0 Offset: 0xB536F0 VA: 0x180B550F0
	|-FramePrinter.PrimitivePrinter<FP>
	|
	|-RVA: 0xB54E50 Offset: 0xB53450 VA: 0x180B54E50
	|-FramePrinter.PrimitivePrinter<FPBounds2>
	|-FramePrinter.PrimitivePrinter<NullableFPVector3>
	|
	|-RVA: 0xB54F20 Offset: 0xB53520 VA: 0x180B54F20
	|-FramePrinter.PrimitivePrinter<FPQuaternion>
	|
	|-RVA: 0xB54FC0 Offset: 0xB535C0 VA: 0x180B54FC0
	|-FramePrinter.PrimitivePrinter<FPVector2>
	|
	|-RVA: 0xB55050 Offset: 0xB53650 VA: 0x180B55050
	|-FramePrinter.PrimitivePrinter<FPVector3>
	|
	|-RVA: 0xB55370 Offset: 0xB53970 VA: 0x180B55370
	|-FramePrinter.PrimitivePrinter<short>
	|
	|-RVA: 0xB554B0 Offset: 0xB53AB0 VA: 0x180B554B0
	|-FramePrinter.PrimitivePrinter<int>
	|
	|-RVA: 0xB55400 Offset: 0xB53A00 VA: 0x180B55400
	|-FramePrinter.PrimitivePrinter<Int32Enum>
	|
	|-RVA: 0xB55540 Offset: 0xB53B40 VA: 0x180B55540
	|-FramePrinter.PrimitivePrinter<long>
	|
	|-RVA: 0xB555D0 Offset: 0xB53BD0 VA: 0x180B555D0
	|-FramePrinter.PrimitivePrinter<IntPtr>
	|
	|-RVA: 0xB55730 Offset: 0xB53D30 VA: 0x180B55730
	|-FramePrinter.PrimitivePrinter<NullableFP>
	|
	|-RVA: 0xB55660 Offset: 0xB53C60 VA: 0x180B55660
	|-FramePrinter.PrimitivePrinter<NullableFPVector2>
	|
	|-RVA: 0xB557F0 Offset: 0xB53DF0 VA: 0x180B557F0
	|-FramePrinter.PrimitivePrinter<NullableNonNegativeFP>
	|
	|-RVA: 0xB55880 Offset: 0xB53E80 VA: 0x180B55880
	|-FramePrinter.PrimitivePrinter<PlayerRef>
	|
	|-RVA: 0xB55910 Offset: 0xB53F10 VA: 0x180B55910
	|-FramePrinter.PrimitivePrinter<QBoolean>
	|
	|-RVA: 0xB559A0 Offset: 0xB53FA0 VA: 0x180B559A0
	|-FramePrinter.PrimitivePrinter<QString128>
	|
	|-RVA: 0xB55A80 Offset: 0xB54080 VA: 0x180B55A80
	|-FramePrinter.PrimitivePrinter<QString256>
	|
	|-RVA: 0xB55B70 Offset: 0xB54170 VA: 0x180B55B70
	|-FramePrinter.PrimitivePrinter<QString64>
	|
	|-RVA: 0xB55C20 Offset: 0xB54220 VA: 0x180B55C20
	|-FramePrinter.PrimitivePrinter<QStringUtf8_64>
	|
	|-RVA: 0xB55CD0 Offset: 0xB542D0 VA: 0x180B55CD0
	|-FramePrinter.PrimitivePrinter<RNGSession>
	|
	|-RVA: 0xB55D60 Offset: 0xB54360 VA: 0x180B55D60
	|-FramePrinter.PrimitivePrinter<sbyte>
	|
	|-RVA: 0xB55DF0 Offset: 0xB543F0 VA: 0x180B55DF0
	|-FramePrinter.PrimitivePrinter<float>
	|
	|-RVA: 0xB55F30 Offset: 0xB54530 VA: 0x180B55F30
	|-FramePrinter.PrimitivePrinter<ushort>
	|
	|-RVA: 0xB55E80 Offset: 0xB54480 VA: 0x180B55E80
	|-FramePrinter.PrimitivePrinter<UInt16Enum>
	|
	|-RVA: 0xB55FC0 Offset: 0xB545C0 VA: 0x180B55FC0
	|-FramePrinter.PrimitivePrinter<uint>
	|
	|-RVA: 0xB56050 Offset: 0xB54650 VA: 0x180B56050
	|-FramePrinter.PrimitivePrinter<ulong>
	|
	|-RVA: 0xB560E0 Offset: 0xB546E0 VA: 0x180B560E0
	|-FramePrinter.PrimitivePrinter<UIntPtr>
	|
	|-RVA: 0xB55180 Offset: 0xB53780 VA: 0x180B55180
	|-FramePrinter.PrimitivePrinter<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21D1340 Offset: 0x21CF940 VA: 0x1821D1340
	private bool IsPrimitive(Type t) { }

	// RVA: 0x21CFE60 Offset: 0x21CE460 VA: 0x1821CFE60
	private FramePrinter.ReflectObjectType GetReflectObject(Type t) { }

	// RVA: 0x21D0F60 Offset: 0x21CF560 VA: 0x1821D0F60
	public FramePrinter.ReflectStructType GetReflectStruct(Type t) { }

	// RVA: 0x21D0AD0 Offset: 0x21CF0D0 VA: 0x1821D0AD0
	private FramePrinter.ReflectStructField GetReflectStructField(Type type, FieldInfo field) { }

	// RVA: 0x21D00A0 Offset: 0x21CE6A0 VA: 0x1821D00A0
	private FramePrinter.ReflectStructCollection GetReflectStructCollection(Type type, FieldInfo field) { }
}
