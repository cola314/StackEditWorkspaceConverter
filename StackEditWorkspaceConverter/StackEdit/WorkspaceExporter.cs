using StackEditWorkspaceConverter.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StackEditWorkspaceConverter.StackEdit
{
    public class WorkspaceExporter
    {
        private WorkspaceBuilder workspaceHandler = new WorkspaceBuilder();

        private string rootFolderPath;

        public WorkspaceExporter(string rootFolderPath)
        {
            this.rootFolderPath = rootFolderPath;
        }

        public string Export()
        {
            if (!Directory.Exists(rootFolderPath))
            {
                throw new DirectoryNotFoundException($"Can not find directory : {rootFolderPath}");
            }

            foreach (var folder in Directory.GetDirectories(rootFolderPath))
            {
                AddFolderRecursively(folder, null);
            }

            foreach (var file in Directory.GetFiles(rootFolderPath))
            {
                AddFile(file, null);
            }

            return workspaceHandler.Build();
        }

        private void AddFolderRecursively(string path, string parentId)
        {
            //폴더 경로를 폴더 이름으로 변환
            string name = Path.GetFileName(path);
            var currentFolder = workspaceHandler.AddFolder(name, parentId);

            foreach (var folder in Directory.GetDirectories(path))
            {
                AddFolderRecursively(folder, currentFolder.Id);
            }

            foreach (var file in Directory.GetFiles(path))
            {
                AddFile(file, currentFolder.Id);
            }
        }

        private void AddFile(string path, string parentId)
        {
            string name = Path.GetFileNameWithoutExtension(path);
            string text = File.ReadAllText(path);

            workspaceHandler.AddFile(name, text, parentId);
        }
    }
}
