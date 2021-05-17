using StackEditWorkspaceConverter.StackEdit;
using System;
using System.IO;

namespace StackEditWorkspaceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("StackEditWorkspaceConverter.exe <target directory> <export file>");
            }
            else
            {
                try
                {
                    string targetDirectory = args[0];
                    string exportFile = args[1];

                    WorkspaceExporter exporter = new WorkspaceExporter(targetDirectory);

                    File.WriteAllText(exportFile, exporter.Export());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
