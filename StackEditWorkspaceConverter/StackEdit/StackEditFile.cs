using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.StackEdit
{
    public class StackEditFile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type => "file";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        public static StackEditFile Create(string id, string name, string parentId)
        {
            return new StackEditFile()
            {
                Id = id,
                Name = name,
                ParentId = parentId
            };
        }
    }
}
