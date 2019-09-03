using Mirror;
using Unity.Mathematics;

public static class MirrorUnityMathematicsReaderWriterExtensions
{
    public static void WriteFloat3(this NetworkWriter writer, float3 float3)
    {
        writer.WriteSingle(float3.x);
        writer.WriteSingle(float3.y);
        writer.WriteSingle(float3.z);
    }

    public static float3 ReadFloat3(this NetworkReader reader)
    {
        return new float3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
    }

    public static void WriteInt3(this NetworkWriter writer, int3 int3)
    {
        writer.WritePackedInt32(int3.x);
        writer.WritePackedInt32(int3.y);
        writer.WritePackedInt32(int3.z);
    }

    public static int3 ReadInt3(this NetworkReader reader)
    {
        return new int3(reader.ReadPackedInt32(), reader.ReadPackedInt32(), reader.ReadPackedInt32());
    }

    public static void WriteFloat2(this NetworkWriter writer, float2 float2)
    {
        writer.WriteSingle(float2.x);
        writer.WriteSingle(float2.y);
    }

    public static float2 ReadFloat2(this NetworkReader reader)
    {
        return new float2(reader.ReadSingle(), reader.ReadSingle());
    }

    public static void WriteInt2(this NetworkWriter writer, int2 int2)
    {
        writer.WritePackedInt32(int2.x);
        writer.WritePackedInt32(int2.y);
    }

    public static int2 ReadInt2(this NetworkReader reader)
    {
        return new int2(reader.ReadPackedInt32(), reader.ReadPackedInt32());
    }
}
