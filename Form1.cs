using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isContainUnicode = false;
        public string filepath;

        private void btnBr_Click(object sender, EventArgs e)
        {
            //tạo form duyệt chọn file khả thi cần chạy
            OpenFileDialog dlg = new OpenFileDialog();
            //hiển thị form duyệt chọn file khả thi cần chạy
            DialogResult ret = dlg.ShowDialog();
            //kiểm tra quyết ₫ịnh của người dùng, nếu người dùng chọn OK thì ghi nhận tên file
            if (ret == DialogResult.OK)
            {
                textPath.Text = dlg.FileName;
                filepath = dlg.FileName;
                string sOutput = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(filepath));
                bool isQuestion = sOutput.Contains("?");
                if (isQuestion)
                {
                    txtConsole.AppendText("Path or file name cannot contain unicode character!!!\n");
                    isContainUnicode = true;
                }
                else
                {
                    isContainUnicode = false;
                }
            }
        }

        private void textPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textPath.Text != "" && isContainUnicode == false)
            {
                string Mode = "";
                if (rDec.Checked == true)
                {
                    Callcmd calldec = new Callcmd(filepath);

                    string filename_return;
                    filename_return = calldec.calltextdetection();

                    Mode = "Mode: Text Detection.\n";
                    DateTime now = DateTime.Now;
                    calldec.SaveInformation(0);

                    txtConsole.Clear();
                    txtConsole.AppendText(Mode);
                    txtConsole.AppendText("Time: " + now.ToString() + "\n");
                    txtConsole.AppendText("Image name: " + filename_return + "\n");

                    FileManage resultfile = new FileManage(filename_return);
                    resultfile.MoveToResult();

                }
                else if (rRec.Checked == true)
                {
                    Callcmd callreg = new Callcmd(filepath);

                    string filename_return;
                    filename_return = callreg.calltextrecognition();

                    Mode = "Mode: Text Recognition.\n";
                    DateTime now = DateTime.Now;
                    callreg.SaveInformation(1);

                    txtConsole.Clear();
                    txtConsole.AppendText(Mode);
                    txtConsole.AppendText("Time: " + now.ToString() + "\n");
                    txtConsole.AppendText("Image name: " + filename_return + "\n");

                    FileManage resultfile = new FileManage(filename_return);
                    resultfile.MoveToResult();
                }
                else if (rVid.Checked == true)
                {

                    Callcmd callreg = new Callcmd(filepath);

                    string filename_return;
                    filename_return = callreg.calltextvideodetection();


                    Mode = "Mode: Text video detection.\n";
                    DateTime now = DateTime.Now;
                    callreg.SaveInformation(2);

                    txtConsole.Clear();
                    txtConsole.AppendText(Mode);
                    txtConsole.AppendText("Time: " + now.ToString() + "\n");
                    txtConsole.AppendText("Video name: " + filename_return + "\n");
                }
            }
            else if (textPath.Text == "")
            {
                if (rVid.Checked == true)
                {
                    Callcmd.calltextvideodetection_stream();

                    DateTime now = DateTime.Now;
                    txtConsole.Clear();
                    txtConsole.AppendText("Mode: Text Video Detection on Camera.\n");
                    txtConsole.AppendText("Time: " + now.ToString() + "\n");
                }
                else
                {
                    txtConsole.Clear();
                    txtConsole.AppendText("PLEASE INPUT IMAGE!!!\n");
                }
            }
            else
            {
                txtConsole.AppendText("Wrong format input path\n");
            }
        }


        private void btnHis_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("History.txt");


            txtConsole.Clear();
            line = sr.ReadLine();
            while (line != null)
            {
                line = sr.ReadLine();
                string time = line;
                line = sr.ReadLine();
                string name = line;
                line = sr.ReadLine();
                string mode = line;
                line = sr.ReadLine();

                if (time != null && name != null && mode != null)
                {
                    txtConsole.AppendText(time + "\n");
                    txtConsole.AppendText(name + "\n");
                    txtConsole.AppendText(mode + "\n");
                    txtConsole.AppendText("\n");
                }
            }

            sr.Close();
        }

        private void rDec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
