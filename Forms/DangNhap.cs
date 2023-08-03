using ManageSystem.Forms;
using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using Emgu.CV.Shape;
using MainMenu = ManageSystem.Forms.MainMenu;
using System.IO;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Threading;

namespace ManageSystem
{
    public partial class DangNhap : Form
    {
        #region LoginFaces
        private Capture videoCapture = null;
        private Image<Bgr, Byte> curFrame = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();
        CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Mat frame = new Mat();
        static bool checkOK = false;
        #endregion
        Model1 db = new Model1();
        public static string currAccount = "";
        public DangNhap()
        {
            InitializeComponent();
       

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ?", "EXIT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Thoát thành công !");
                this.Close();
            }
        }
  
       

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //Utils hashPass = new Utils();
                string temp = Utils.HashPassword(txt_Password.Text);
                var check = db.ACCOUNTs.Where(s => s.USERNAME == txt_UserName.Text && s.PASSWORD == temp).ToList();
                if (check.Count > 0)
                {
                    int? takeRole = -1;
                    foreach(var item in check)
                    {
                        takeRole = item.ROLE;
                    }
                    if (takeRole == 1)
                    {
                        currAccount = txt_UserName.Text;
                        MainMenu main = new MainMenu(this);
                        LoadForm lf = new LoadForm();
                        this.Hide();
                        lf.Show();
                        while (!lf.IsDisposed)
                        {
                            Application.DoEvents();
                        }
                        main.Show();
                        
                    }
                    else
                    {
                        currAccount = txt_UserName.Text;
                        NhanVienMenu nv = new NhanVienMenu(this);
                        LoadForm lf = new LoadForm();
                        this.Hide();
                        lf.Show();
                        while (!lf.IsDisposed)
                        {
                            Application.DoEvents();
                        }
                        nv.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai ten tai khoan hoac mat khau");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainImageFromDir();
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += Device_NewFrame;
            videoCapture.Start();
        }
        private void Device_NewFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                curFrame = frame.ToImage<Bgr, Byte>().Resize(pictureBox3.Width, pictureBox3.Height, Inter.Cubic);
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(curFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);
                Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                if (faces.Length > 0)
                {
                    foreach (var item in faces)
                    {
                        Image<Bgr, Byte> resultImage = curFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = item;
                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var result = recognizer.Predict(grayFaceResult);
                            if (result.Label != -1)
                            {
                                CvInvoke.Rectangle(curFrame, item, new Bgr(Color.Green).MCvScalar, 2);
                                pictureBox3.Invoke(new MethodInvoker(delegate
                                {
                                    MainMenu mn = new MainMenu(this);
                                    LoadForm lf = new LoadForm();
                                    this.Hide();
                                    videoCapture.Stop();
                                    lf.Show();
                                    while (!lf.IsDisposed)
                                    {
                                        Application.DoEvents();
                                    }
                                    mn.Show();
                                    pictureBox3.Image = null;
                                }));
                            }
                            else
                            {
                                CvInvoke.Rectangle(curFrame, item, new Bgr(Color.Red).MCvScalar, 2);
                                videoCapture.Stop();
                                checkOK = false;
                            }
                        }
                    }
                }
                pictureBox3.Image = curFrame.Bitmap;
            }
        }
        private bool TrainImageFromDir()
        {
            int imgCount = 0;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\FaceToTrain";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, Byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(imgCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    imgCount++;
                    Debug.WriteLine(imgCount + ". " + name);
                }
                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(imgCount);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());
                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
