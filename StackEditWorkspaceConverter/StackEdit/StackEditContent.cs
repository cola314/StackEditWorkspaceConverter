using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.StackEdit
{
    public class StackEditContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type => "content";

        [JsonProperty("text")]
        public string Text { get; set; }

        public static StackEditContent Create(string fileId, string text)
        {
            return new StackEditContent()
            {
                Id = $"{fileId}/content",
                Text = text
            };
        }
    }
}
