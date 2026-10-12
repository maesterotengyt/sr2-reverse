// Namespace: Quantum.Prototypes
[Prototype(typeof(CustomAnimator))]
[Serializable]
public sealed class CustomAnimator_Prototype : ComponentPrototype<CustomAnimator> // TypeDefIndex: 10783
{
	// Fields
	public QBoolean Active; // 0x18
	public MapEntityId Entity; // 0x1C
	public AssetRefAnimationsPoolData AnimationsPool; // 0x20
	public AssetRefAnimationBakedJointsData BakedJointsData; // 0x28
	[HideInInspector]
	public int HighestWeightClipIndex; // 0x30
	[HideInInspector]
	public FP HighestWeightClipTime; // 0x38
	[HideInInspector]
	[ArrayLength(5)]
	public CustomAnimatorPlayableClipInfo_Prototype[] CurrentClips; // 0x40
	[HideInInspector]
	[ArrayLength(5)]
	public CustomAnimatorPlayableClipInfo_Prototype[] PreviousClips; // 0x48
	[HideInInspector]
	public FP TransitionDuration; // 0x50
	[HideInInspector]
	public FP TransitionTime; // 0x58
	[HideInInspector]
	public QBoolean Blend1DActive; // 0x60
	[HideInInspector]
	public QBoolean Blend2DActive; // 0x64
	[HideInInspector]
	public FP CurrentBlendX; // 0x68
	[HideInInspector]
	public FP CurrentBlendY; // 0x70
	[HideInInspector]
	public FP Speed; // 0x78
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData0; // 0x80
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData1; // 0x88
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData2; // 0x90
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData3; // 0x98
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData4; // 0xA0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData0; // 0xA8
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData1; // 0xB0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData2; // 0xB8
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData3; // 0xC0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData4; // 0xC8
	[Dictionary]
	[DynamicCollection]
	public DictionaryEntry_Int32_CustomSubAnimatorPlayableClipInfo_Prototype[] SubAnimatorClip; // 0xD0

	// Methods

	// RVA: 0x2101350 Offset: 0x20FF950 VA: 0x182101350 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2101610 Offset: 0x20FFC10 VA: 0x182101610
	public void Materialize(Frame frame, ref CustomAnimator result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2101580 Offset: 0x20FFB80 VA: 0x182101580 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2102680 Offset: 0x2100C80 VA: 0x182102680
	public void .ctor() { }
}
