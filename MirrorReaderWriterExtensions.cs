using Mirror;

public static class MirrorReaderWriterExtensions
{
    public static void WriteIpAddress(this NetworkWriter writer, System.Net.IPAddress ipAddress)
    {
        var ipBuffer = ipAddress.GetAddressBytes();
        writer.WritePackedInt32(ipBuffer.Length);
        writer.WriteBytes(ipBuffer, 0, ipBuffer.Length);
    }

    public static System.Net.IPAddress ReadIpAddress(this NetworkReader reader)
    {
        var count = reader.ReadPackedInt32();
        return new System.Net.IPAddress(reader.ReadBytes(count));
    }

    public static void WriteDateTime(this NetworkWriter writer, System.DateTime dateTime)
    {
        writer.WriteInt64(dateTime.Ticks);
    }

    public static System.DateTime ReadDateTime(this NetworkReader reader)
    {
        return new System.DateTime(reader.ReadInt64());
    }
}
