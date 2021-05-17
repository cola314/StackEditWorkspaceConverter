using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.StackEdit
{
    public class StackEditFolder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type => "folder";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        public static StackEditFolder Create(string id, string name, string parentId)
        {
            return new StackEditFolder()
            {
                Id = id,
                Name = name,
                ParentId = parentId
            };
        }
    }
}
