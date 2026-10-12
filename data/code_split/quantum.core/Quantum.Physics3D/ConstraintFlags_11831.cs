// Namespace: Quantum.Physics3D
[Flags]
internal enum ConstraintFlags // TypeDefIndex: 11831
{
	// Fields
	public int value__; // 0x0
	public const ConstraintFlags IgnoreVelocitySolver = 1;
	public const ConstraintFlags IgnorePositionSolver = 2;
	public const ConstraintFlags WasSolved = 4;
	public const ConstraintFlags HasDynamicBodyA = 8;
	public const ConstraintFlags HasDynamicBodyB = 16;
}
