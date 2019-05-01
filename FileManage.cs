using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextDetection
{
    public class FileManage
    {
        private string filename;
        private string sourcePath = @"opencv";
        private string targetPath = @"result";

        public FileManage(string filename)
        {
            this.filename = filename;
        }

        public void CopyToResult()
        {
            string sourceFile = Path.Combine(sourcePath, this.filename);
            string destFile = Path.Combine(targetPath, this.filename);

            File.Copy(sourceFile, destFile, true);
        }
        public void MoveToResult()
        {
            string sourceFile = Path.Combine(sourcePath, this.filename);
            string destFile = Path.Combine(targetPath, this.filename);
            if (!File.Exists(destFile)) File.Move(sourceFile, destFile);

        }
    }
}
