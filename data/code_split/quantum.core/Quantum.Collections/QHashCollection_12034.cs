// Namespace: Quantum.Collections
internal struct QHashCollection // TypeDefIndex: 12034
{
	// Fields
	public Ptr Buckets; // 0x0
	public Ptr FreeHead; // 0x4
	public int UsedCount; // 0x8
	public int FreeCount; // 0xC
	public int KeyOffset; // 0x10
	public QBuffer Entries; // 0x14

	// Methods

	// RVA: -1 Offset: -1
	private static Ptr* GetBuckets<THeap>(THeap heap, QHashCollection* collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC171B0 Offset: 0xC157B0 VA: 0x180C171B0
	|-QHashCollection.GetBuckets<object>
	|
	|-RVA: 0xC170C0 Offset: 0xC156C0 VA: 0x180C170C0
	|-QHashCollection.GetBuckets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static QHashCollection.Entry* GetFreeHead<THeap>(THeap heap, QHashCollection* collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC174B0 Offset: 0xC15AB0 VA: 0x180C174B0
	|-QHashCollection.GetFreeHead<object>
	|
	|-RVA: 0xC173A0 Offset: 0xC159A0 VA: 0x180C173A0
	|-QHashCollection.GetFreeHead<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2213540 Offset: 0x2211B40 VA: 0x182213540
	private static void CalculateStrides(ref int keyStride, out int entryStride) { }

	// RVA: -1 Offset: -1
	public static QHashCollection.Entry* GetEntry<THeap>(THeap heap, QHashCollection* collection, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC17320 Offset: 0xC15920 VA: 0x180C17320
	|-QHashCollection.GetEntry<object>
	|
	|-RVA: 0xC17210 Offset: 0xC15810 VA: 0x180C17210
	|-QHashCollection.GetEntry<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T GetKey<T>(QHashCollection* collection, QHashCollection.Entry* entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC17530 Offset: 0xC15B30 VA: 0x180C17530
	|-QHashCollection.GetKey<ComponentReference>
	|
	|-RVA: 0xC17560 Offset: 0xC15B60 VA: 0x180C17560
	|-QHashCollection.GetKey<EntityRef>
	|
	|-RVA: 0xC17580 Offset: 0xC15B80 VA: 0x180C17580
	|-QHashCollection.GetKey<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Clear<THeap>(THeap heap, QHashCollection* collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC15A40 Offset: 0xC14040 VA: 0x180C15A40
	|-QHashCollection.Clear<object>
	|
	|-RVA: 0xC15850 Offset: 0xC13E50 VA: 0x180C15850
	|-QHashCollection.Clear<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QHashCollection.Entry* Find<T, THeap>(THeap heap, QHashCollection* collection, T value, uint valueHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC16690 Offset: 0xC14C90 VA: 0x180C16690
	|-QHashCollection.Find<AssetGuid, object>
	|-QHashCollection.Find<EntityRef, object>
	|
	|-RVA: 0xC167B0 Offset: 0xC14DB0 VA: 0x180C167B0
	|-QHashCollection.Find<ComponentReference, object>
	|
	|-RVA: 0xC16BA0 Offset: 0xC151A0 VA: 0x180C16BA0
	|-QHashCollection.Find<int, object>
	|
	|-RVA: 0xC16CC0 Offset: 0xC152C0 VA: 0x180C16CC0
	|-QHashCollection.Find<QString128, object>
	|
	|-RVA: 0xC168E0 Offset: 0xC14EE0 VA: 0x180C168E0
	|-QHashCollection.Find<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Add<T, THeap>(THeap heap, QHashCollection* collection, T key, uint keyHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC14910 Offset: 0xC12F10 VA: 0x180C14910
	|-QHashCollection.Add<ComponentReference, object>
	|
	|-RVA: 0xC14A80 Offset: 0xC13080 VA: 0x180C14A80
	|-QHashCollection.Add<EntityRef, object>
	|
	|-RVA: 0xC14BE0 Offset: 0xC131E0 VA: 0x180C14BE0
	|-QHashCollection.Add<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QHashCollection.Entry* Insert<T, THeap>(THeap heap, QHashCollection* collection, T key, uint keyHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC17620 Offset: 0xC15C20 VA: 0x180C17620
	|-QHashCollection.Insert<AssetGuid, object>
	|-QHashCollection.Insert<EntityRef, object>
	|
	|-RVA: 0xC17830 Offset: 0xC15E30 VA: 0x180C17830
	|-QHashCollection.Insert<ComponentReference, object>
	|
	|-RVA: 0xC17F80 Offset: 0xC16580 VA: 0x180C17F80
	|-QHashCollection.Insert<int, object>
	|
	|-RVA: 0xC18190 Offset: 0xC16790 VA: 0x180C18190
	|-QHashCollection.Insert<QString128, object>
	|
	|-RVA: 0xC17A50 Offset: 0xC16050 VA: 0x180C17A50
	|-QHashCollection.Insert<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<T>(Ptr* ptr, FrameSerializer serializer, FrameSerializer.Delegate keySerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC183F0 Offset: 0xC169F0 VA: 0x180C183F0
	|-QHashCollection.Serialize<AssetGuid>
	|
	|-RVA: 0xC19170 Offset: 0xC17770 VA: 0x180C19170
	|-QHashCollection.Serialize<int>
	|
	|-RVA: 0xC18DB0 Offset: 0xC173B0 VA: 0x180C18DB0
	|-QHashCollection.Serialize<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<T>(QHashCollection* qHash, FrameSerializer serializer, FrameSerializer.Delegate keySerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC18480 Offset: 0xC16A80 VA: 0x180C18480
	|-QHashCollection.Serialize<AssetGuid>
	|
	|-RVA: 0xC18790 Offset: 0xC16D90 VA: 0x180C18790
	|-QHashCollection.Serialize<ComponentReference>
	|
	|-RVA: 0xC18AA0 Offset: 0xC170A0 VA: 0x180C18AA0
	|-QHashCollection.Serialize<EntityRef>
	|
	|-RVA: 0xC19200 Offset: 0xC17800 VA: 0x180C19200
	|-QHashCollection.Serialize<int>
	|
	|-RVA: 0xC18E40 Offset: 0xC17440 VA: 0x180C18E40
	|-QHashCollection.Serialize<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Allocate<T, THeap>(THeap heap, QHashCollection* qHash, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC14DD0 Offset: 0xC133D0 VA: 0x180C14DD0
	|-QHashCollection.Allocate<AssetGuid, object>
	|-QHashCollection.Allocate<EntityRef, object>
	|
	|-RVA: 0xC15080 Offset: 0xC13680 VA: 0x180C15080
	|-QHashCollection.Allocate<ComponentReference, object>
	|
	|-RVA: 0xC155A0 Offset: 0xC13BA0 VA: 0x180C155A0
	|-QHashCollection.Allocate<int, object>
	|
	|-RVA: 0xC151B0 Offset: 0xC137B0 VA: 0x180C151B0
	|-QHashCollection.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QHashCollection* Allocate<T, THeap>(THeap heap, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC14F00 Offset: 0xC13500 VA: 0x180C14F00
	|-QHashCollection.Allocate<AssetGuid, object>
	|
	|-RVA: 0xC156D0 Offset: 0xC13CD0 VA: 0x180C156D0
	|-QHashCollection.Allocate<int, object>
	|
	|-RVA: 0xC15400 Offset: 0xC13A00 VA: 0x180C15400
	|-QHashCollection.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Free<THeap>(THeap heap, QHashCollection* qHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC17000 Offset: 0xC15600 VA: 0x180C17000
	|-QHashCollection.Free<object>
	|
	|-RVA: 0xC16E60 Offset: 0xC15460 VA: 0x180C16E60
	|-QHashCollection.Free<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void Expand<THeap>(THeap heap, QHashCollection* collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC16350 Offset: 0xC14950 VA: 0x180C16350
	|-QHashCollection.Expand<object>
	|
	|-RVA: 0xC15B90 Offset: 0xC14190 VA: 0x180C15B90
	|-QHashCollection.Expand<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22135E0 Offset: 0x2211BE0 VA: 0x1822135E0
	public static void Print(Ptr ptr, FramePrinter printer, Type valueType) { }
}
