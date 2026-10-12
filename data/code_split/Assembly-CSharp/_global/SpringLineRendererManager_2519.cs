// Namespace: 
public class SpringLineRendererManager : SimpleLineRendererManager // TypeDefIndex: 2519
{
	// Fields
	[Header("Spring Options")]
	public int Quality; // 0x78
	public float Damper; // 0x7C
	public float Strength; // 0x80
	public float Velocity; // 0x84
	public float WaveCount; // 0x88
	public float WaveHeight; // 0x8C
	public AnimationCurve SpringCurve; // 0x90
	private Spring spring; // 0x98
	private Vector3 currentLinePosition; // 0xA0

	// Methods

	// RVA: 0x63B2A0 Offset: 0x6398A0 VA: 0x18063B2A0
	private void Awake() { }

	// RVA: 0x63B310 Offset: 0x639910 VA: 0x18063B310 Slot: 4
	protected override void OnUpdate() { }

	// RVA: 0x63BC60 Offset: 0x63A260 VA: 0x18063BC60
	public void .ctor() { }
}
