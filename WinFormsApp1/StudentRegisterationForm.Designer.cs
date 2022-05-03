namespace WinFormsApp1
{
    partial class StudentRegisterationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_studentId = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtBox_studentId = new System.Windows.Forms.TextBox();
            this.txtBox_studentName = new System.Windows.Forms.TextBox();
            this.txtBox_address = new System.Windows.Forms.TextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_studentId
            // 
            this.lbl_studentId.AutoSize = true;
            this.lbl_studentId.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_studentId.Location = new System.Drawing.Point(75, 54);
            this.lbl_studentId.Name = "lbl_studentId";
            this.lbl_studentId.Size = new System.Drawing.Size(125, 30);
            this.lbl_studentId.TabIndex = 0;
            this.lbl_studentId.Text = "Student ID :";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_studentName.Location = new System.Drawing.Point(39, 112);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(161, 30);
            this.lbl_studentName.TabIndex = 1;
            this.lbl_studentName.Text = "Student Name :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.Location = new System.Drawing.Point(93, 180);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(107, 30);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address : ";
            // 
            // txtBox_studentId
            // 
            this.txtBox_studentId.Location = new System.Drawing.Point(206, 61);
            this.txtBox_studentId.Name = "txtBox_studentId";
            this.txtBox_studentId.Size = new System.Drawing.Size(241, 23);
            this.txtBox_studentId.TabIndex = 3;
            // 
            // txtBox_studentName
            // 
            this.txtBox_studentName.Location = new System.Drawing.Point(206, 121);
            this.txtBox_studentName.Name = "txtBox_studentName";
            this.txtBox_studentName.Size = new System.Drawing.Size(241, 23);
            this.txtBox_studentName.TabIndex = 4;
            // 
            // txtBox_address
            // 
            this.txtBox_address.Location = new System.Drawing.Point(206, 180);
            this.txtBox_address.Name = "txtBox_address";
            this.txtBox_address.Size = new System.Drawing.Size(241, 23);
            this.txtBox_address.TabIndex = 5;
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_display.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_display.Location = new System.Drawing.Point(39, 310);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(91, 47);
            this.btn_display.TabIndex = 6;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(196, 310);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 47);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.Location = new System.Drawing.Point(356, 310);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 47);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 405);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.txtBox_address);
            this.Controls.Add(this.txtBox_studentName);
            this.Controls.Add(this.txtBox_studentId);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_studentName);
            this.Controls.Add(this.lbl_studentId);
            this.Name = "Form1";
            this.Text = "Student Registeration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_studentId;
        private Label lbl_studentName;
        private Label lbl_address;
        private TextBox txtBox_studentId;
        private TextBox txtBox_studentName;
        private TextBox txtBox_address;
        private Button btn_display;
        private Button btn_clear;
        private Button btn_close;
    }
}