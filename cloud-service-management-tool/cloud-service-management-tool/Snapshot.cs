using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using Newtonsoft.Json.Converters;
//using Newtonsoft.Json.Serialization;
//using Newtonsoft.Json.Schema;
//using Newtonsoft.Json.Bson;

namespace cloudservicemanagementtool {
    public class Snapshot {
        public Snapshot(string jsonString) {
            JObject jsonObject = JObject.Parse(jsonString);
            JToken jsonSnapshot = jsonObject["object"];
            Name = (string)jsonSnapshot["name"];
            UUID = (string)jsonSnapshot["uuid"];
            Status = (string)jsonSnapshot["status"];
//            AllocatedSize = (int)jsonSnapshot["allocated_size"];
//            ResourceURI = (string)jsonSnapshot["resource_uri"];
            //Grantees = (string)jsonSnapshot["grantees"];
//            Meta = (string)jsonSnapshot["meta"];
            //Permissions = (string)jsonSnapshot["permissions"];
            //Tags = (string)jsonSnapshot["tags"];
//            Timestamp = (string)jsonSnapshot["timestamp"];
            //Owner = (Owner)jsonSnapshot["owner"];
            //Drive = (Drive)jsonSnapshot["drive"];
        }

        public string Name { get; set; }
        public string UUID { get; set; }
        public string Status { get; set; }
        public int AllocatedSize { get; set; }
        public string ResourceURI { get; set; }
//        public Dictionary<string, string> Owner { get; set; }
//        public Dictionary<string, string> Drive { get; set; }
        public Owner Owner;
        public Drive Drive;
        public string[] Grantees { get; set; }
        public string Meta { get; set; }
        public string[] Permissions { get; set; }
        public string[] Tags { get; set; }
        public string Timestamp { get; set; }
    }
}
