// Namespace: Photon.Deterministic
public interface IBitStream // TypeDefIndex: 17488
{
	// Properties
	public abstract int BytesRequired { get; }
	public abstract byte[] Data { get; }
	public abstract bool Writing { get; set; }
	public abstract bool Reading { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_BytesRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_Data();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Writing();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Writing(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Reading();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Reading(bool value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Serialize(ref long value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Serialize(ref uint value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Serialize(ref int value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Serialize(byte* v);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Serialize(sbyte* v);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Serialize(short* v);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Serialize(ushort* v);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Serialize(int* v);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Serialize(uint* v);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Serialize(long* v);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Serialize(ulong* v);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Serialize(int* v, int bits);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Serialize(uint* v, int bits);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SerializeBuffer(byte* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SerializeBuffer(short* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SerializeBuffer(ulong* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool Condition(bool condition);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool ReadBool();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool WriteBool(bool b);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int ReadInt();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void WriteInt(int v);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void WriteUInt(uint v);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract uint ReadUInt();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CopyFromArray(byte[] data);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract byte[] ToArray();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void Reset();
}
