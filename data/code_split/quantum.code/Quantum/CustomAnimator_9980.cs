// Namespace: Quantum
public struct CustomAnimator : IComponent // TypeDefIndex: 9980
{
	// Fields
	public QBoolean Active; // 0x4
	public AssetRefAnimationsPoolData AnimationsPool; // 0x48
	public AssetRefAnimationBakedJointsData BakedJointsData; // 0x40
	[HideInInspector]
	public QBoolean Blend1DActive; // 0x8
	[HideInInspector]
	public QBoolean Blend2DActive; // 0xC
	[HideInInspector]
	public FP CurrentBlendX; // 0x58
	[HideInInspector]
	public FP CurrentBlendY; // 0x60
	[FixedBuffer(typeof(byte), 360)]
	[HideInInspector]
	[FixedArray(typeof(CustomAnimatorPlayableClipInfo), 5)]
	private CustomAnimator.<_CurrentClips_>e__FixedBuffer _CurrentClips_; // 0x88
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr CurrentSpeedData0Ptr; // 0x10
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr CurrentSpeedData1Ptr; // 0x14
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr CurrentSpeedData2Ptr; // 0x18
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr CurrentSpeedData3Ptr; // 0x1C
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr CurrentSpeedData4Ptr; // 0x20
	public EntityRef Entity; // 0x50
	[HideInInspector]
	public int HighestWeightClipIndex; // 0x0
	[HideInInspector]
	public FP HighestWeightClipTime; // 0x68
	[FixedBuffer(typeof(byte), 360)]
	[HideInInspector]
	[FixedArray(typeof(CustomAnimatorPlayableClipInfo), 5)]
	private CustomAnimator.<_PreviousClips_>e__FixedBuffer _PreviousClips_; // 0x1F0
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr PreviousSpeedData0Ptr; // 0x24
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr PreviousSpeedData1Ptr; // 0x28
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr PreviousSpeedData2Ptr; // 0x2C
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr PreviousSpeedData3Ptr; // 0x30
	[HideInInspector]
	[PtrQList(typeof(AnimationSpeedElement))]
	private Ptr PreviousSpeedData4Ptr; // 0x34
	[HideInInspector]
	public FP Speed; // 0x70
	[PtrQDictionary(typeof(int), typeof(CustomSubAnimatorPlayableClipInfo))]
	private Ptr SubAnimatorClipPtr; // 0x38
	[HideInInspector]
	public FP TransitionDuration; // 0x78
	[HideInInspector]
	public FP TransitionTime; // 0x80

	// Properties
	public FixedArray<CustomAnimatorPlayableClipInfo> CurrentClips { get; }
	public QListPtr<AnimationSpeedElement> CurrentSpeedData0 { get; set; }
	public QListPtr<AnimationSpeedElement> CurrentSpeedData1 { get; set; }
	public QListPtr<AnimationSpeedElement> CurrentSpeedData2 { get; set; }
	public QListPtr<AnimationSpeedElement> CurrentSpeedData3 { get; set; }
	public QListPtr<AnimationSpeedElement> CurrentSpeedData4 { get; set; }
	public FixedArray<CustomAnimatorPlayableClipInfo> PreviousClips { get; }
	public QListPtr<AnimationSpeedElement> PreviousSpeedData0 { get; set; }
	public QListPtr<AnimationSpeedElement> PreviousSpeedData1 { get; set; }
	public QListPtr<AnimationSpeedElement> PreviousSpeedData2 { get; set; }
	public QListPtr<AnimationSpeedElement> PreviousSpeedData3 { get; set; }
	public QListPtr<AnimationSpeedElement> PreviousSpeedData4 { get; set; }
	public QDictionaryPtr<int, CustomSubAnimatorPlayableClipInfo> SubAnimatorClip { get; set; }
	public int ActiveClipsNumber { get; }
	public int HighestWeightClipFrame { get; }

	// Methods

	// RVA: 0x20E0060 Offset: 0x20DE660 VA: 0x1820E0060
	public FixedArray<CustomAnimatorPlayableClipInfo> get_CurrentClips() { }

	// RVA: 0x20E00D0 Offset: 0x20DE6D0 VA: 0x1820E00D0
	public QListPtr<AnimationSpeedElement> get_CurrentSpeedData0() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	public void set_CurrentSpeedData0(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0110 Offset: 0x20DE710 VA: 0x1820E0110
	public QListPtr<AnimationSpeedElement> get_CurrentSpeedData1() { }

	// RVA: 0x873D00 Offset: 0x872300 VA: 0x180873D00
	public void set_CurrentSpeedData1(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0150 Offset: 0x20DE750 VA: 0x1820E0150
	public QListPtr<AnimationSpeedElement> get_CurrentSpeedData2() { }

	// RVA: 0x6A4F50 Offset: 0x6A3550 VA: 0x1806A4F50
	public void set_CurrentSpeedData2(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0190 Offset: 0x20DE790 VA: 0x1820E0190
	public QListPtr<AnimationSpeedElement> get_CurrentSpeedData3() { }

	// RVA: 0x667A40 Offset: 0x666040 VA: 0x180667A40
	public void set_CurrentSpeedData3(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E01D0 Offset: 0x20DE7D0 VA: 0x1820E01D0
	public QListPtr<AnimationSpeedElement> get_CurrentSpeedData4() { }

	// RVA: 0x667A20 Offset: 0x666020 VA: 0x180667A20
	public void set_CurrentSpeedData4(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0240 Offset: 0x20DE840 VA: 0x1820E0240
	public FixedArray<CustomAnimatorPlayableClipInfo> get_PreviousClips() { }

	// RVA: 0x20E02B0 Offset: 0x20DE8B0 VA: 0x1820E02B0
	public QListPtr<AnimationSpeedElement> get_PreviousSpeedData0() { }

	// RVA: 0x847EC0 Offset: 0x8464C0 VA: 0x180847EC0
	public void set_PreviousSpeedData0(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E02F0 Offset: 0x20DE8F0 VA: 0x1820E02F0
	public QListPtr<AnimationSpeedElement> get_PreviousSpeedData1() { }

	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_PreviousSpeedData1(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0330 Offset: 0x20DE930 VA: 0x1820E0330
	public QListPtr<AnimationSpeedElement> get_PreviousSpeedData2() { }

	// RVA: 0x11DAC00 Offset: 0x11D9200 VA: 0x1811DAC00
	public void set_PreviousSpeedData2(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E0370 Offset: 0x20DE970 VA: 0x1820E0370
	public QListPtr<AnimationSpeedElement> get_PreviousSpeedData3() { }

	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	public void set_PreviousSpeedData3(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E03B0 Offset: 0x20DE9B0 VA: 0x1820E03B0
	public QListPtr<AnimationSpeedElement> get_PreviousSpeedData4() { }

	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	public void set_PreviousSpeedData4(QListPtr<AnimationSpeedElement> value) { }

	// RVA: 0x20E03F0 Offset: 0x20DE9F0 VA: 0x1820E03F0
	public QDictionaryPtr<int, CustomSubAnimatorPlayableClipInfo> get_SubAnimatorClip() { }

	// RVA: 0x8757D0 Offset: 0x873DD0 VA: 0x1808757D0
	public void set_SubAnimatorClip(QDictionaryPtr<int, CustomSubAnimatorPlayableClipInfo> value) { }

	// RVA: 0x20DC8C0 Offset: 0x20DAEC0 VA: 0x1820DC8C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20DC1A0 Offset: 0x20DA7A0 VA: 0x1820DC1A0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20DD760 Offset: 0x20DBD60 VA: 0x1820DD760
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20DDE00 Offset: 0x20DC400 VA: 0x1820DDE00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20DFE30 Offset: 0x20DE430 VA: 0x1820DFE30
	public int get_ActiveClipsNumber() { }

	// RVA: 0x20E0210 Offset: 0x20DE810 VA: 0x1820E0210
	public int get_HighestWeightClipFrame() { }

	// RVA: 0x20DD3D0 Offset: 0x20DB9D0 VA: 0x1820DD3D0
	public void Initialize(Frame frame, EntityRef entity, AssetRefAnimationsPoolData animationsPoolData, AssetRefAnimationBakedJointsData bakedJointsData) { }

	// RVA: 0x20DC590 Offset: 0x20DAB90 VA: 0x1820DC590
	public void ForceUpdate(Frame frame) { }

	// RVA: 0x20DEDD0 Offset: 0x20DD3D0 VA: 0x1820DEDD0
	public void Update(Frame frame, FP deltaTime) { }

	// RVA: 0x20DD7F0 Offset: 0x20DBDF0 VA: 0x1820DD7F0
	public void PlayClip(Frame frame, int clipHash, int channel, int startFrame, int endFrame, FP speed, FP weight, bool loop, int groupToExecute, StateGroupExecutionMode groupExecutionMode) { }

	// RVA: 0x20DDA90 Offset: 0x20DC090 VA: 0x1820DDA90
	public void PlaySubAnimationClip(Frame frame, int subAnimatorHash, int clipHash, int startFrame, int endFrame, FP speed, FP weight, bool loop) { }

	// RVA: 0x20DE5E0 Offset: 0x20DCBE0 VA: 0x1820DE5E0
	internal void SetClipSpeed(int channel, FP speed) { }

	// RVA: 0x20DE700 Offset: 0x20DCD00 VA: 0x1820DE700
	public void SetClipWeight(int channel, FP weight) { }

	// RVA: 0x20DCB70 Offset: 0x20DB170 VA: 0x1820DCB70
	public CustomAnimatorPlayableClipInfo GetHighestWeightClip(out int channelIndex) { }

	// RVA: 0x20DE420 Offset: 0x20DCA20 VA: 0x1820DE420
	public void SetAnimationSpeedData(Frame frame, AnimationSpeedElement[] newAnimationSpeedData, int channel) { }

	// RVA: 0x20DBA00 Offset: 0x20DA000 VA: 0x1820DBA00
	public void AddAnimationSpeedData(Frame frame, AnimationSpeedElement animationSpeedData, int channel) { }

	// RVA: 0x20DEBE0 Offset: 0x20DD1E0 VA: 0x1820DEBE0
	public bool TryGetCurrentJointsKeyFrame(Frame frame, out JointKeyFrame keyFrame) { }

	// RVA: 0x20DECD0 Offset: 0x20DD2D0 VA: 0x1820DECD0
	public bool TryGetKinematicMotion(Frame frame, out FPVector2 kinematicMotionDiff) { }

	// RVA: 0x20DE830 Offset: 0x20DCE30 VA: 0x1820DE830
	public void StartTransitionBlend(Frame frame, FP transitionFrames) { }

	// RVA: 0x20DC1C0 Offset: 0x20DA7C0 VA: 0x1820DC1C0
	public void ClearTransitionBlend() { }

	// RVA: 0x20DBF20 Offset: 0x20DA520 VA: 0x1820DBF20
	public void ClearClipChannel(int channel) { }

	// RVA: 0x20DBBA0 Offset: 0x20DA1A0 VA: 0x1820DBBA0
	public void ClearAllClips() { }

	// RVA: 0x20DCDB0 Offset: 0x20DB3B0 VA: 0x1820DCDB0
	public void InitCurrentModifiers(Frame frame, int channel) { }

	// RVA: 0x20DD0C0 Offset: 0x20DB6C0 VA: 0x1820DD0C0
	public void InitPreviousModifiers(Frame frame, int channel) { }

	// RVA: 0x20DC330 Offset: 0x20DA930 VA: 0x1820DC330
	public void DestroyModifiers(Frame frame) { }

	// RVA: 0x20DC5A0 Offset: 0x20DABA0 VA: 0x1820DC5A0
	private FP GetAnimationSpeedModifier(Frame frame, int channel, int currentFrame, bool previous = False) { }

	// RVA: 0x20DC020 Offset: 0x20DA620 VA: 0x1820DC020
	private void ClearModifiers(Frame frame, int channel) { }

	// RVA: 0x20DD410 Offset: 0x20DBA10 VA: 0x1820DD410
	private void MigrateModifiers(Frame frame, int channel) { }

	// RVA: 0x20DBB80 Offset: 0x20DA180 VA: 0x1820DBB80
	private void CheckForHighestWeight(FP runtimeWeight, int clipIndex, FP clipTime, ref FP highestWeight, ref int highestWeightClipIndex, ref FP highestWeightClipTime) { }

	// RVA: 0x20DBDE0 Offset: 0x20DA3E0 VA: 0x1820DBDE0
	internal void ClearAnimationFinishEvents(Frame frame) { }
}
