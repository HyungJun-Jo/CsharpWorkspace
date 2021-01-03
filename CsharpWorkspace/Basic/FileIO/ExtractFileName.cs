using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic.FileIO
{
    public class ExtractFileName
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                string extension = ".txt";
                List<string> fileNameList = null;
                List<string> filePathList = null;

                // 폴더,파일정보 가져오기
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = openFolderDialog.SelectedPath;
                    // fileNameList = FileIO.ExtractFIleNameList(folderPath, extension);     // 파일명
                    filePathList = FileIO.ExtractFIlePathList(folderPath, extension);     // 파일경로
                }

                // 출력
                if (null != filePathList)
                {
                    foreach (string fp in filePathList)
                    {
                        Console.WriteLine(fp);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
