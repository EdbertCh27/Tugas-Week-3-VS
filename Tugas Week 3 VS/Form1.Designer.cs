
namespace Tugas_Week_3_VS
{
    partial class FormPengaturanWarna
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
            this.LblINPUT = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.TBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblINPUT
            // 
            this.LblINPUT.AutoSize = true;
            this.LblINPUT.Location = new System.Drawing.Point(36, 27);
            this.LblINPUT.Name = "LblINPUT";
            this.LblINPUT.Size = new System.Drawing.Size(57, 20);
            this.LblINPUT.TabIndex = 0;
            this.LblINPUT.Text = "INPUT :";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(36, 157);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(58, 20);
            this.LblOutput.TabIndex = 1;
            this.LblOutput.Text = "[.............]";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(36, 103);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(94, 29);
            this.BtnProcess.TabIndex = 2;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // TBoxInput
            // 
            this.TBoxInput.Location = new System.Drawing.Point(36, 50);
            this.TBoxInput.Name = "TBoxInput";
            this.TBoxInput.Size = new System.Drawing.Size(306, 27);
            this.TBoxInput.TabIndex = 3;
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBoxInput);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblINPUT);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblINPUT;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.TextBox TBoxInput;
    }
}

