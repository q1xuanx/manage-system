using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;

namespace ManageSystem.Forms
{
    public partial class FaceRecog : Form
    {
        Model1 db = new Model1();
        #region Facereconize
        private Capture videoCapture = null;
        private Image<Bgr, Byte> curFrame = null;
        Mat frame = new Mat();
        CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        bool saveMode = true;
        #endregion
        public FaceRecog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên !");
                return;
            }
            var find = db.ACCOUNTs.FirstOrDefault(s => s.NHANVIEN.MANV == txtMNV.Text && s.ROLE == 1);
            if (find != null)
            {
                videoCapture = new Capture();
                videoCapture.ImageGrabbed += Device_NewFrame;
                videoCapture.Start();
            }else
            {
                MessageBox.Show("Nhân viên không có quyền quản lý không thể thêm chức năng đăng nhập bằng khuôn mặt !");
            }
        }

        private void Device_NewFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                curFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);
                //Nhan dien face 
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(curFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);
                Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                if (faces.Length > 0)
                {
                    foreach (var item in faces)
                    {
                        CvInvoke.Rectangle(curFrame, item, new Bgr(Color.Red).MCvScalar, 2);
                        if (saveMode)
                        {
                            Image<Bgr, Byte> resultImg = curFrame.Convert<Bgr, Byte>();
                            resultImg.ROI = item;
                            string path = Directory.GetCurrentDirectory() + @"\FaceToTrain";
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            Task.Factory.StartNew(() =>
                            {
                                for (int i = 0; i < 50; i++)
                                {
                                    resultImg.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtMNV.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                                MessageBox.Show("Bạn có thể tắt ứng dụng hình đã được lưu thành công !");
                            });
                        }
                        saveMode = false;
                    }
                }
                //Hien thi picturbox
                picCapture.Image = curFrame.Bitmap;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
