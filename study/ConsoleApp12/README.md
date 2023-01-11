<pre>
GetCurrentDirectory() : 현재 실행파일 경로
Exists([파일경로]) : 파일경로의 존재 유무 bool타입반환
CreateDirectory([파일경로]) : 해당 파일경로 폴더 생성
</pre>

<pre>
// FileModel.Create     : 파일을 만든다, 있으면 덮어 씀
// FileModel.CreateNew  : 파일을 만든다. 있으면 IOException예외 발생
// FileModel.Append     : 파일을 만든다 있으면 뒤에서부터 추가로 작성

// FileModel.Open       : 파일을 연다, 없다면 FileNotFoundException호출
// FileModel.OpenOrCreate : 파일을 연다, 없으면 만듬 (권장X)
// FileModel..Truncate  : 파일은 연다, 없다면 만듬(열든 말든 무조건 빈파일?)
</pre>

```
/*
//
// 방법 2 ( Encoding 을 통해 byte 배열로 쓰는법 )
//

byte[] byteArr = Encoding.UTF8.GetBytes(strData);

//파일 스트림에다가 byte 배열을 직접쓰기.
fileStream.Write(
    byteArr,
    0,
    byteArr.Length);
*/
```

```
static void FileWrite(string filePath, string strData)
    {
        //파일 스트림을 만든다. 
        FileStream fileStream = new FileStream(
            filePath,              //저장경로
            FileMode.Create,       //파일스트림 모드
            FileAccess.Write       //접근 권한
            );

        StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        streamWriter.Write(strData);

        //다쓴 StreamWriter 와 FileStream 닫기
        streamWriter.Close();
        fileStream.Close();
    }
    static void FileRead(string filePath)
    {
        //폴더 경로는 확인하였고 실제 파일이 있는지 유무를 확인
        FileInfo fi = new FileInfo(filePath);
        if(fi.Exists)
        {
            //파일 존재
            //파일 읽어올 스트림 준비
            FileStream fileStream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read);

            //파일스트림을 읽는 Reader 생성
            StreamReader streamReader = new StreamReader(
                fileStream,
                Encoding.UTF8);         //쓰기와 동일하게 UTF8로 읽음.

            //읽어올 파일을 저정할 스트링 빌더 생성
            StringBuilder strBulider = new StringBuilder(1000);  //빌더크기(Capacity) 1000

            //Peek : 파일 끝에 도달하거나 문제가 발생하면 -1을 반환 합니다.
            while (streamReader.Peek() > -1)    //파일의 끝이 아닐동안계속
            {
                string strLine = streamReader.ReadLine();      //파일 한줄 읽어온다.

                //읽어온내용 문자열 추가
                //strBulider.Append(strLine);

                //읽어온내용 문자열로 추가하고 줄바뀜
                strBulider.AppendLine(strLine);

            }

            //스트링 빌더에 있는 내용 출력
            Console.WriteLine(strBulider.ToString());

            //다쓴 StreamReader 와 FileStream 닫기
            streamReader.Close();
            fileStream.Close();

            //추가) 정한 규칙으로 저장된 데이터를 파싱 합니다.
            int hp = 0;
            int mp = 0;

            string strTemp = strBulider.ToString();

            //string의 split메서드를 활용하여 개행문자 '\n' 을 기준으로 기존의 문자열을
            //나누어 3개의 배열로 반환됩니다.
            string[] data = strTemp.Split('\n');        
                
            for (int i = 0; i < data.Length; i++)
            {
                //data[0]는 "hp=10" data[1]는 "mp=20" data[2] = "" 형태의 문자열로 저장되어 있습니다.

                if(data[i].Length > 0)  //반환된 배열중에 데이터가 없는 배열은 제외(data[2])
                {
                    string TempData = data[i];              

                    // 우리는 "데이터 이름=값" 형식으로 저장하였기에 다시한번 split로 문자'=' 를 기준으로 나누면
                    // 0번 배열은 데이터 이름, 1번 배열은 값을 가진다는
                    // 규칙을 이용하여 데이를 파싱 할수 있습니다.
                    string[] result = TempData.Split('='); 

                    if (result[0] == "hp")
                        hp = Convert.ToInt32(result[1]);  // convert 클래스는 문자열을 원하는 형태로 변환합니다.
                    if(result[0] == "mp")
                        mp = Convert.ToInt32(result[1]);
                }
            }
            Console.WriteLine("hp = " + hp.ToString());
            Console.WriteLine("mp = " + mp.ToString());
        }
        else
        {
            //파일 없음
            Console.WriteLine("읽을 파일이 없습니다.");
        }
```