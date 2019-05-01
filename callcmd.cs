using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextDetection
{
    public class Callcmd
    {
        private string filepath;
        private string filename;

        static private string cdopencv = "cd opencv";
        public Callcmd(string filepath)
        {
            this.filepath = filepath;
            this.filename = Path.GetFileName(filepath);
        }
        public string getFilename()
        {
            return this.filename;
        }

        public string callpython(int mode) //0: text detection; 1: text recognition; 2 or other: text video detection
        {
            string filename_return;
            string python;

            if (mode == 0) //text detection 
            {
                python = "python text_detection.py --east frozen_east_text_detection.pb --image ";
                python = python + "\"" + filepath + "\"";
                filename_return = "[d]-" + this.filename;
            }
            else if (mode == 1) //text recognition 
            {
                python = "python text_recognition.py --east frozen_east_text_detection.pb --image ";
                python = python + "\"" + filepath + "\"";
                filename_return = "[r]-" + this.filename;
            }
            else //text video detection
            {
                python = "python text_detection_video.py --east frozen_east_text_detection.pb -v";
                python = python + "\"" + filepath + "\"";
                filename_return = "[v]-" + this.filename;
            }

            //open cmd
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            //
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            //get path of .py
            cmd.StandardInput.WriteLine(cdopencv);
            cmd.StandardInput.Flush();
            //call python
            cmd.StandardInput.WriteLine(python);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            //Console.WriteLine(cmd.StandardOutput.ReadToEnd());


            return filename_return;
        }

        public string calltextdetection()
        {
            return callpython(0);
        }
        public string calltextrecognition() 
        {
            return callpython(1);
        }
        public string calltextvideodetection()
        {
            return callpython(2);
        }

        static public void calltextvideodetection_stream()
        {
            string python = "python text_detection_video.py --east frozen_east_text_detection.pb";

            //open cmd
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            //
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            //get path of .py
            cmd.StandardInput.WriteLine(cdopencv);
            cmd.StandardInput.Flush();
            //call python
            cmd.StandardInput.WriteLine(python);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            //Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        public void SaveInformation(int mode)
        {
            string time, filename, Mode = "";
            if (mode == 0)
            {
                Mode = "Mode: Detection";
            }
            else if (mode == 1)
            {
                Mode = "Mode: Recognition";
            }
            else
            {
                Mode = "Mode: Video";
            }

            DateTime now = DateTime.Now;
            time = "Time: " + now.ToString();
            if (mode == 0 || mode == 1) filename = "Image name: " + this.filename;
            else filename = "Video name: " + this.filename;
            StreamWriter sw = new StreamWriter(@"History.txt", true);
            sw.WriteLine(time);
            sw.WriteLine(filename);
            sw.WriteLine(Mode);
            sw.Close();
        }
    }
}
