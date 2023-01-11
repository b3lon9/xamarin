using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentPath = Directory.GetCurrentDirectory();
            System.Diagnostics.Debug.WriteLine("debug path : {0}", currentPath);
            Console.WriteLine("currentPath : {0}", currentPath);

            currentPath += "\\Save";

            if (Directory.Exists(currentPath))
            {
                Console.WriteLine("경로 존재 ! : {0}", currentPath);
            }
            else
            {
                //디렉토리 생성
                Directory.CreateDirectory(currentPath);
                Console.WriteLine("폴더 생성 ! : " + currentPath);
            }

            string filePath = currentPath + "\\test.txt";

            // 파일스트림 만들기
            FileStream fileStream = new FileStream(
                filePath,   // 저장경로
                FileMode.Create,    // 파일스트림 모드
                FileAccess.Write    // 접근 권한
                );

            string strData = "왕초보 입문용 프로그램 글 써주셔서 감사합니다.\r\n" +
                "잘보고 배우고 있습니다. 재밌네요. 마스터해야겠습니다.";

            StreamWriter streamWriter = new StreamWriter(
                fileStream,     // 사용할 파일스트림
                Encoding.UTF8   // 파일에 인코딩객체 전달
                );

            streamWriter.Write(strData);

            streamWriter.Close();   // 썼으면 닫아야함

            fileStream.Close();
            Console.WriteLine("파일생성 및 덮어쓰기 완료");
        }
    }
}
