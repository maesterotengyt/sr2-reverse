// Namespace: Quantum
public struct NavMeshSteeringAgent : IComponent // TypeDefIndex: 11693
{
	// Fields
	public const int SIZE = 40;
	internal NullableNonNegativeFP _maxSpeed; // 0x0
	internal NullableNonNegativeFP _acceleration; // 0x8
	internal FPVector2 _velocity; // 0x18

	// Properties
	public FP Acceleration { get; set; }
	public FP CurrentSpeed { get; }
	public FP MaxSpeed { get; set; }
	public FPVector2 Velocity { get; }

	// Methods

	// RVA: 0x221C340 Offset: 0x221A940 VA: 0x18221C340
	public FP get_Acceleration() { }

	// RVA: 0x221C390 Offset: 0x221A990 VA: 0x18221C390
	public void set_Acceleration(FP value) { }

	// RVA: 0x221C360 Offset: 0x221A960 VA: 0x18221C360
	public FP get_CurrentSpeed() { }

	// RVA: 0x20AB210 Offset: 0x20A9810 VA: 0x1820AB210
	public FP get_MaxSpeed() { }

	// RVA: 0x221C3B0 Offset: 0x221A9B0 VA: 0x18221C3B0
	public void set_MaxSpeed(FP value) { }

	// RVA: 0xD11670 Offset: 0xD0FC70 VA: 0x180D11670
	public FPVector2 get_Velocity() { }

	// RVA: 0x221C250 Offset: 0x221A850 VA: 0x18221C250
	internal void SetConfig(FrameBase f, NavMeshAgentConfig config, bool overwrite) { }

	// RVA: 0x221C020 Offset: 0x221A620 VA: 0x18221C020
	internal void Clear(FrameBase f, Navigation.Entry* e) { }

	// RVA: 0x221C200 Offset: 0x221A800 VA: 0x18221C200
	public static void Serialize(void* p, FrameSerializer serializer) { }

	// RVA: 0x221C030 Offset: 0x221A630 VA: 0x18221C030
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
