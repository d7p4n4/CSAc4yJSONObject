using CSNeedToSerializeAttributeLib;
using CSPersistentAttributeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4yJSONObject.Class
{
    [NeedToSerialize]
    [Persistent]
    class Ac4yJSONObject
    {
        public int id { get; set; }
        public string GUID { get; set; }
        public string serialization { get; set; }
    }
}
