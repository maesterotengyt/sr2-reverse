// Namespace: 
public sealed class StellarFileLoadingSystem.OnSpriteLoaded : MulticastDelegate // TypeDefIndex: 3556
{
	// Methods

	// RVA: 0x5E98B0 Offset: 0x5E7EB0 VA: 0x1805E98B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(Sprite result, AssetReference assetReference) { }

	// RVA: 0x5E9870 Offset: 0x5E7E70 VA: 0x1805E9870 Slot: 14
	public virtual IAsyncResult BeginInvoke(Sprite result, AssetReference assetReference, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
