// Namespace: 
public static class NarrowChecks.LinecastBody // TypeDefIndex: 11868
{
	// Methods

	// RVA: 0x226F2C0 Offset: 0x226D8C0 VA: 0x18226F2C0
	public static bool Check(AssetGuid mapGuid, Entry3D* b, ref FPVector3 start, ref FPVector3 end, bool computeNormal, out Hit3D hit) { }

	// RVA: 0x226F940 Offset: 0x226DF40 VA: 0x18226F940
	public static bool RaySphereProjection(ref FPVector3 center, FP radius, ref FPVector3 start, ref FPVector3 end, out FPVector3 intersection, out FP normalizedDist) { }

	// RVA: 0x2269BF0 Offset: 0x22681F0 VA: 0x182269BF0
	private static bool HitBoundingBox(ref FPVector3 minB, ref FPVector3 maxB, ref FPVector3 origin, ref FPVector3 dir, out FPVector3 coord, long maxDistanceRaw, out FPVector3 normal, out FP normalizedDist) { }
}
