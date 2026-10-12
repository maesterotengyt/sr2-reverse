// Namespace: Quantum
public struct CharacterController3DMovement // TypeDefIndex: 11716
{
	// Fields
	public CharacterMovementType Type; // 0x0
	public FPVector3 NearestNormal; // 0x8
	public FPVector3 AvgNormal; // 0x20
	public FPVector3 GroundNormal; // 0x38
	public FPVector3 Tangent; // 0x50
	public FPVector3 SlopeTangent; // 0x68
	public FPVector3 Correction; // 0x80
	public FP Penetration; // 0x98
	public bool Grounded; // 0xA0
	public int Contacts; // 0xA4
}
