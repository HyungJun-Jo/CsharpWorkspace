using System.Collections.Generic;
using System.Linq;

namespace Basic.FileIO
{
    public static class FileIO
    {
        #region public method
        public static List<string> ExtractFIleNameList(string folderPath, string extension)
        {
            List<string> fileNameList = new List<string>();
            List<System.IO.FileInfo> fileList = GetFileList(folderPath, extension);

            foreach (System.IO.FileInfo file in fileList)
            {
                if (file.Extension.ToLower().CompareTo(extension) == 0)
                {
                    string FileNameOnly = file.Name;
                    fileNameList.Add(FileNameOnly);
                }
            }

            return fileNameList;
        }

        public static List<string> ExtractFIlePathList(string folderPath, string extension)
        {
            List<string> fileNameList = new List<string>();
            List<System.IO.FileInfo> fileList = GetFileList(folderPath, extension);

            foreach (System.IO.FileInfo file in fileList)
            {
                if (file.Extension.ToLower().CompareTo(extension) == 0)
                {
                    string FullFileName = file.FullName;
                    fileNameList.Add(FullFileName);
                }
            }

            return fileNameList;
        }

        public static string GetFileName(string filePath, string extension)
        {
            string fileName = "";

            System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
            if (fi.Extension.ToLower().CompareTo(extension) == 0)
            {
                fileName = fi.Name;
            }

            return fileName;
        }

        public static void SetFileName(string filePath, string newFileName)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
            if (fi.Exists)
            {
                string diPath = fi.DirectoryName;
                string newFilePath = diPath + @"\" + newFileName;
                fi.MoveTo(newFilePath);
            }
        }
        #endregion


        #region private method
        private static List<System.IO.FileInfo> GetFileList(string folderPath, string extension)
        {
            List<System.IO.FileInfo> fileList = new List<System.IO.FileInfo>();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(folderPath);
            if (0 == di.GetDirectories().Count())
            {
                foreach (System.IO.FileInfo file in di.GetFiles())
                {
                    if (file.Extension.ToLower().CompareTo(extension) == 0)
                    {
                        fileList.Add(file);
                    }
                }
            }
            else
            {
                // 하위 폴더가 있을 경우 전부 탐색
                foreach (System.IO.DirectoryInfo directory in di.GetDirectories())
                {
                    List<System.IO.FileInfo> subFoloderFileList = GetFileList(directory.FullName, extension);
                    fileList.AddRange(subFoloderFileList);
                }
            }

            return fileList;
        }
        #endregion

    }
}