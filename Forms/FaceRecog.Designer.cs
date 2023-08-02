namespace ManageSystem.Forms
{
    partial class FaceRecog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btn_opencamera = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCapture.Location = new System.Drawing.Point(102, 53);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(603, 508);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btn_opencamera
            // 
            this.btn_opencamera.Location = new System.Drawing.Point(765, 111);
            this.btn_opencamera.Name = "btn_opencamera";
            this.btn_opencamera.Size = new System.Drawing.Size(182, 74);
            this.btn_opencamera.TabIndex = 1;
            this.btn_opencamera.Text = "Thêm khuôn mặt";
            this.btn_opencamera.UseVisualStyleBackColor = true;
            this.btn_opencamera.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 601);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FaceRecog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG2;
            this.ClientSize = new System.Drawing.Size(1036, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_opencamera);
            this.Controls.Add(this.picCapture);
            this.Name = "FaceRecog";
            this.Text = "FaceRecog";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btn_opencamera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}