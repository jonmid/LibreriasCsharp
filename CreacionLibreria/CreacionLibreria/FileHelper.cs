using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionLibreria
{
    public class FileHelper
    {
        public List<FileObjectInfo> GetFileSystemObjects(string path)
        {
            var di = new DirectoryInfo(path);
            var listaInfo = di.EnumerateFileSystemInfos();

            var fileObjects = new List<FileObjectInfo>();

            foreach (var item in listaInfo)
            {
                FileObjectType tipo = FileObjectType.Directory;

                if (item.Attributes == FileAttributes.Archive)
                {
                    tipo = FileObjectType.File;
                }

                fileObjects.Add(new FileObjectInfo() {
                    Path = item.FullName,
                    Name = item.Name,
                    FileType = tipo
                });
            }

            return fileObjects;
        }
    }
}
