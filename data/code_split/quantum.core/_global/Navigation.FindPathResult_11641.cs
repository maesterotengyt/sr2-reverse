// Namespace: 
public struct Navigation.FindPathResult // TypeDefIndex: 11641
{
	// Fields
	public Navigation.FindPathResult.Code Result; // 0x0
	public FPVector3 CorrectedStartPosition; // 0x8
	public FPVector3 CorrectedEndPosition; // 0x20
	private Navigation.IPathFinderData _pathFinderData; // 0x38

	// Methods

	// RVA: 0x21DC5C0 Offset: 0x21DABC0 VA: 0x1821DC5C0
	public static Navigation.FindPathResult CreateSuccess(FPVector3 correctedStartPosition, FPVector3 correctedEndPosition) { }

	// RVA: 0x21DC560 Offset: 0x21DAB60 VA: 0x1821DC560
	public static Navigation.FindPathResult CreateError(Navigation.FindPathResult.Code errorCode) { }
}
