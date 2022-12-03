using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // 추가
using System.Net; // 추가
using System.Net.Sockets; // 추가
using System.IO; // 추가
using System.Drawing.Text;
using System.Net.Http;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.VisualBasic.FileIO;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;



namespace My_Server
{
    public partial class Form1 : Form
    {
        List<string> csvList = null;
        public Form1()
        {
            InitializeComponent();
            uiBtn_Read.Click += uiBtn_Read_Click;
        }

        StreamReader streamReader1;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter1;  // 데이타 쓰기 위한 스트림라이터    

        public void uiBtn_Read_Click(object sender, EventArgs e)
        {

            try
            {
                GetCSVData(Map_grid);
            }
            catch { }
           /* FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] fileName = Directory.GetFiles(fbd.SelectedPath);
                csvList = fileName.Where(x => x.IndexOf(".csv",
                    StringComparison.OrdinalIgnoreCase) >= 0)
                    .Select(x => x).ToList();

                string result = string.Empty;

                try
                {
                    GetCSVData(Map_grid);
                }
                catch { }
            }*/
        }
        string[] Map_grid; // image로 만들  2차원 array

        public void GetCSVData(string[] result_array)
        {
            // map_grid_csv 파일을 image로 만들기 위해 2차원 array로 만들어줌
            /*for (int idx = 0; idx < csvList.Count; idx++)
            {
                using (var sr = new System.IO.StreamReader(csvList[idx]))
                {
                    int r_idx = 0; // 행 숫자
                    uint[,] arr = new uint[84, 53];
                    while (!sr.EndOfStream)
                    {
                        string array = sr.ReadLine();

                        string[] values = array.Split(',');


                        for (int i = 0; i < values.Length; i++)
                        {
                            result += "" + values[i];
                            arr[r_idx, i] = Convert.ToUInt32(values[i]);

                        }
                        r_idx += 1; // 행 숫자 증가
                    }
                }

                textBox_csv.Text = result;
            }*/
            
            var path = @"C:\CSV\Grid_2f_fix.csv"; // image로 만들어줘야하는 csv 파일 호출하기
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    Map_grid = csvParser.ReadFields();
                    string Name = Map_grid[0];
                    string Address = Map_grid[1];

                    foreach (var word in Map_grid)
                    {
                        Debug.WriteLine($"{word}");
                        writeTextbox_csv(word);
                    }
                }
            }
        }

        public void btn_Receive_data_Click(object sender, EventArgs e)  
            // '연결하기' 버튼이 클릭되면
        {
            Thread thread1 = new Thread(connect); 
            // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; 
            // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.
        }

        

        private void connect()  
            // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text)); 
            // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpListener1.Start();  // 서버 시작
            writeRichTextbox("서버 준비...클라이언트 기다리는 중...");

            TcpClient tcpClient1 = tcpListener1.AcceptTcpClient(); 
            // 클라이언트 접속 확인
            writeRichTextbox("클라이언트 연결됨...");

            streamReader1 = new StreamReader(tcpClient1.GetStream(), Encoding.UTF8);  
            // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream(), Encoding.UTF8);  
            // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            try
            {
                while (tcpClient1.Connected)
                // 클라이언트가 연결되어 있는 동안
                {
                    string receiveData1 = streamReader1.ReadLine();
                    // 수신 데이타를 읽어서 receiveData1 변수에 저장
                    writetextBox3(receiveData1);
                    // 데이타를 수신창에 쓰기
                    Arraysplitstr = receiveData1.Split(new string[] { "[", "{\"SSID\":\"", "\",\"level\":", "},", "}]" }, StringSplitOptions.RemoveEmptyEntries);

                    btdisconnect.Enabled = true;
                    btdisconnect.Click += btdisconnect_Click;
                    void btdisconnect_Click(object sender, EventArgs e)
                    {
                        streamReader1.Close();
                        streamWriter1.Close();
                        tcpClient1.Close();   
                    }
                }
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                writeRichTextbox("클라이언트 연결해제됨...");
            }
        }

        private void writeRichTextbox(string str)  // richTextbox1 에 쓰기 함수
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(str + "\r\n"); }); 
            // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });  
            // 스크롤을 젤 밑으로.
        }
        private void writetextBox3(string str)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { textBox3.AppendText(str + "\r\n"); });
            // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { textBox3.ScrollToCaret(); });
            // 스크롤을 젤 밑으로.
        }
        private void writeTextbox_csv(string str)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { textBox_csv.AppendText(str + "\r\n"); });
            // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { textBox_csv.ScrollToCaret(); });
            // 스크롤을 젤 밑으로.
        }
        private void writeTextbox_array(string[] str)
        {
            richTextBox1.Invoke((MethodInvoker)delegate { textBox_csv.AppendText(str + "\r\n"); });
            // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { textBox_csv.ScrollToCaret(); });
            // 스크롤을 젤 밑으로.
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\CSV\Test_image.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //  맵 이미지로 불러오기, 패널 만들기 위한 보여주기

        }

        public void PC_connect_Click(object sender, EventArgs e)
        // '연결하기' 버튼이 클릭되면
        {
            Thread thread2 = new Thread(pcconnect);
            // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread2.IsBackground = true;
            // Form이 종료되면 thread1도 종료.
            thread2.Start(); // thread1 시작.
        }

        StreamReader streamReader2;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter2;  // 데이타 쓰기 위한 스트림라이터 

            private void pcconnect()
        // thread2에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpClient tcpClient2 = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(textBox4.Text), int.Parse(textBox5.Text));
            // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpClient2.Connect(ipEnd); ;  // 서버 시작
            writeRichTextbox("서버 연결됨...");

            streamReader2 = new StreamReader(tcpClient2.GetStream(), Encoding.UTF8);
            // 읽기 스트림 연결
            streamWriter2 = new StreamWriter(tcpClient2.GetStream(), Encoding.UTF8);
            // 쓰기 스트림 연결.
            streamWriter2.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..
        }

        private void button2_Click(object sender, EventArgs e)
        // '보내기' 버튼이 클릭되면
        {
            string sendData1 = textBox3.Text;
            // testBox3 의 내용을 sendData1 변수에 저장
            streamWriter2.WriteLine(sendData1);
            // 스트림라이터를 통해 데이타를 전송
        }
        string[] Arraysplitstr;//핸드폰에서 불러온 데이터
        string[] ArrayApname;
        string[] ArrayLevel;

        private void button1_Click(object sender, EventArgs e)
        {
            //핸드폰에서 불러온 데이터 array로 만들기, 
            //getcsvdata 공간이랑 다른 방법을 사용해서 array 만들었음
            //1차원 array 2개 생성
            // 무슨 방법이 더 좋은지를 모르겠으무ㅜ
            Array.Resize(ref ArrayApname, Arraysplitstr.Length / 2);
            Array.Resize(ref ArrayLevel, Arraysplitstr.Length / 2);

            int cnt_odd = 0;
            int cnt_even = 0;

            for (int i = 0; i < Arraysplitstr.Length; i++)
            {

                if (i % 2 == 1)
                {
                    ArrayApname[cnt_odd] = Arraysplitstr[i];
                    cnt_odd++;
                }
                else if (i % 2 == 0)
                {
                    ArrayLevel[cnt_even] = Arraysplitstr[i];
                    cnt_even++;
                }
            }
            foreach (var word in ArrayApname)
            {
                Debug.WriteLine($"{word}");
                writeTextbox_csv(word);
            }

            foreach (var word in ArrayLevel)
            {
                Debug.WriteLine($"{word}");
                writeTextbox_csv(word);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 유클리드 계산을 돌려서 나온 좌표값을 이미지 위에 점으로 찍어주기 위한 공간
            // 지금은 패널 만들기 위한 보여주기
            Graphics drawString;
            drawString = pictureBox1.CreateGraphics();
            drawString.DrawString("●", new Font("Arial", 40), Brushes.Red, 210, 100);
 
        }

        static void calcEuclidDistance(string[,] vector1, string[,] vector2)
        {// 유클리드 계산 돌릴 공간
            
            if (vector1.Rank != 1 && vector2.Rank != 2)
            {
                throw new ArgumentException();
            }

            else if (vector1.Rank > vector2.Rank)
            {
                string[,] temp;
                temp = vector1;
                vector1 = vector2;
                vector2 = temp;
            }

            if (vector1.GetLength(1)  == vector2.GetLength(1)) 
            {
                int distance;

            }
        }

    }
}
