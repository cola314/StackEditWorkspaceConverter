using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.Util
{
    public static class Json
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
