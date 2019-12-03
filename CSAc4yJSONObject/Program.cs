using System;

namespace CSAc4yJSONObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CSSerializerLib.Serialize _serialize = new CSSerializerLib.Serialize();

            _serialize.SerializeMethod("d:\\Server\\Visual_studio\\output_Xmls\\", typeof(Program));
        }
    }
}
