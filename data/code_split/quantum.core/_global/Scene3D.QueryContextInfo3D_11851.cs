// Namespace: 
private struct Scene3D.QueryContextInfo3D // TypeDefIndex: 11851
{
	// Fields
	public FrameThreadSafe Frame; // 0x0
	public Scene3D* Scene; // 0x10
	public TriangleMesh SceneMesh; // 0x18
	public HitCollection3D* HitCollection; // 0x20
	public Tls* CurrentTls; // 0x28
	public Query3D* Query; // 0x30
	public bool ComputeDetailedInfo; // 0x38
	public Entry3D* QueryEntry; // 0x40
	public Entry3D* MeshEntry; // 0x48
	public TriangleCCW* Tri; // 0x50
	public int TriIndex; // 0x58
	public GJKSettings* GjkSettings; // 0x60
	public int BroadphaseBucketIndex; // 0x68
	public Bucket3D* BroadphaseBucket; // 0x70
	public int* BroadphaseQueryBucketManifold; // 0x78
}
