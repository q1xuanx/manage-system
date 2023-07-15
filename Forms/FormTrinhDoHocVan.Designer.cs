namespace ManageSystem.Forms
{
    partial class FormTrinhDoHocVan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenTrinhDo = new System.Windows.Forms.TextBox();
            this.txt_ChuyenNganh = new System.Windows.Forms.TextBox();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên trình độ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TRÌNH ĐỘ HỌC VẤN";
            // 
            // txt_TenTrinhDo
            // 
            this.txt_TenTrinhDo.Location = new System.Drawing.Point(293, 144);
            this.txt_TenTrinhDo.Name = "txt_TenTrinhDo";
            this.txt_TenTrinhDo.Size = new System.Drawing.Size(229, 22);
            this.txt_TenTrinhDo.TabIndex = 3;
            // 
            // txt_ChuyenNganh
            // 
            this.txt_ChuyenNganh.Location = new System.Drawing.Point(293, 199);
            this.txt_ChuyenNganh.Name = "txt_ChuyenNganh";
            this.txt_ChuyenNganh.Size = new System.Drawing.Size(229, 22);
            this.txt_ChuyenNganh.TabIndex = 4;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(243, 287);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(85, 49);
            this.btn_HoanTat.TabIndex = 5;
            this.btn_HoanTat.Text = "HOÀN TẤT";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(394, 287);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(84, 49);
            this.btn_Dong.TabIndex = 6;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // FormTrinhDoHocVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.txt_ChuyenNganh);
            this.Controls.Add(this.txt_TenTrinhDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTrinhDoHocVan";
            this.Text = "FormTrinhDoHocVan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenTrinhDo;
        private System.Windows.Forms.TextBox txt_ChuyenNganh;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_Dong;
    }
}