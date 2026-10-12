// Namespace: 
private static class QuantumUnityNativeUtility.ObjectPinner // TypeDefIndex: 2471
{
	// Fields
	private static object _pinLock; // 0x0
	public static object _pinnedObject; // 0x8
	public static ulong _pinnedHandle; // 0x10

	// Methods

	// RVA: 0x62F5E0 Offset: 0x62DBE0 VA: 0x18062F5E0
	private static void VerifyHandle(Native.ObjectHandle handle) { }

	// RVA: 0x62F110 Offset: 0x62D710 VA: 0x18062F110
	public static Native.ObjectHandle HandleAcquire(object obj) { }

	// RVA: 0x62F310 Offset: 0x62D910 VA: 0x18062F310
	public static void HandleRelease(Native.ObjectHandle handle) { }

	// RVA: 0x62EE50 Offset: 0x62D450 VA: 0x18062EE50
	public static object GetObjectForHandle(Native.ObjectHandle handle) { }

	// RVA: 0x62F690 Offset: 0x62DC90 VA: 0x18062F690
	private static void .cctor() { }
}
