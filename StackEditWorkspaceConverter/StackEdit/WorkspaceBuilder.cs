using StackEditWorkspaceConverter.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.StackEdit
{
    public class WorkspaceBuilder
    {
        private Dictionary<string, object> workspace = new Dictionary<string, object>();

        public StackEditFolder AddFolder(string name, string parentId = null)
        {
            var folder = StackEditFolder.Create(Uid.NewUid(), name, parentId);
            workspace.Add(folder.Id, folder);

            return folder;
        }

        public StackEditFile AddFile(string name, string text, string parentId = null)
        {
            var file = StackEditFile.Create(Uid.NewUid(), name, parentId);
            var content = StackEditContent.Create(file.Id, text);
            workspace.Add(file.Id, file);
            workspace.Add(content.Id, content);

            return file;
        }

        public string Build()
        {
            return workspace.ToJson();
        }
    }
}
