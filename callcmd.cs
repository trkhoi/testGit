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


        public void callcommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            cmd.StandardInput.WriteLine(cdopencv);
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }
        public abstract class Detection
        {
            // abstract method 'callTextDetection()' 
            public abstract void callTextDetection(string python, string filepath);
        }

        public class ImageDeAdapter : Detection
        {
            public override void callTextDetection(string python, string filepath)
            {
                ImageDetection temp = new ImageDetection();
                temp.callTextDetectionFromImage(python, filepath);
            }
        }

        public class VideoDeAdapter : Detection
        {
            public override void callTextDetection(string python, string filepath)
            {
                VideoDetection temp = new VideoDetection();
                temp.callTextDetectionFromVideo(python, filepath);
            }
        }

        public class StreamDeAdapter : Detection
        {
            public override void callTextDetection(string python, string filepath)
            {
                StreamDetection temp = new StreamDetection();
                temp.callTextDetectionFromStream(python, filepath);
            }
        }

        public class ImageDetection
        {
            public void callTextDetectionFromImage(string python, string filepath)
            {
                python = "python text_detection.py --east frozen_east_text_detection.pb --image ";
                python = python + "\"" + filepath + "\"";
            }
        }
        public class VideoDetection
        {
            public void callTextDetectionFromVideo(string python, string filepath)
            {
                python = "python text_detection_video.py --east frozen_east_text_detection.pb -v ";
                python = python + "\"" + filepath + "\"";
            }
        }
        public class StreamDetection
        {
            public void callTextDetectionFromStream(string python, string filepath = "")
            {
                python = "python text_detection_video.py --east frozen_east_text_detection.pb ";
                python = python + "\"" + filepath + "\"";
            }

        }

        public Detection FindModeDec(string filetype, string filename)
        {
            if (filetype == "Image")
            {
                ImageDeAdapter mode = new ImageDeAdapter();
                filename = "[d]-" + this.filename;
                return mode;
            }
            else if (filetype == "Video")
            {
                VideoDeAdapter mode = new VideoDeAdapter();
                filename = "[v]-" + this.filename;
                return mode;
            }
            else if (filetype == "Stream")
            {
                StreamDeAdapter mode = new StreamDeAdapter();
                filename = "Stream";
                return mode;
            }
            else
            {
                StreamDeAdapter mode = new StreamDeAdapter();
                return mode;
            }

        }

        public abstract class Recognition
        {
            // abstract method 'callTextDetection()' 
            public abstract void callTextRecognition(string python, string filepath);
        }

        public class ImageReAdapter : Recognition
        {
            public override void callTextRecognition(string python, string filepath)
            {
                ImageRecognition temp = new ImageRecognition();
                temp.callTextRecognitionFromImage(python, filepath);
            }
        }
        public class ImageRecognition
        {
            public void callTextRecognitionFromImage(string python, string filepath)
            {
                python = "python text_recognition.py --east frozen_east_text_detection.pb --image ";
                python = python + "\"" + filepath + "\"";
            }
        }

        public Recognition FindModeRec(string filetype, string filename)
        {
            if (filetype == "Image")
            {
                ImageReAdapter mode = new ImageReAdapter();
                filename = "[r]-" + this.filename;
                return mode;
            }
            else
            {
                ImageReAdapter mode = new ImageReAdapter();
                return mode;
            }

        }

        public string callpy(int mode,string typefile)
        {
            string filename_return = "";
            string python = "";

            if (mode == 0)
            {
                Detection callpython = FindModeDec(typefile, filename_return);
                callpython.callTextDetection(python, filepath);
            }
            else if (mode == 1)
            {
                Recognition callpython = FindModeRec(typefile, filename_return);
                callpython.callTextRecognition(python, filepath);
            }

            callcommand(python);
            return filename_return;
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

            string test = cmd.StandardOutput.ReadLine();

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
