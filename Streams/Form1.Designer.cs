namespace Streams
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.nudInput = new System.Windows.Forms.NumericUpDown();
            this.txtCharInput = new System.Windows.Forms.TextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(73, 66);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // nudInput
            // 
            this.nudInput.DecimalPlaces = 5;
            this.nudInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudInput.Location = new System.Drawing.Point(73, 135);
            this.nudInput.Name = "nudInput";
            this.nudInput.Size = new System.Drawing.Size(120, 20);
            this.nudInput.TabIndex = 1;
            this.nudInput.ThousandsSeparator = true;
            // 
            // txtCharInput
            // 
            this.txtCharInput.Location = new System.Drawing.Point(73, 201);
            this.txtCharInput.MaxLength = 1;
            this.txtCharInput.Name = "txtCharInput";
            this.txtCharInput.Size = new System.Drawing.Size(21, 20);
            this.txtCharInput.TabIndex = 2;
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(306, 125);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWriteFile_MouseClick);
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.Location = new System.Drawing.Point(488, 149);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(120, 95);
            this.lbxData.TabIndex = 4;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(306, 167);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRead_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 563);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtCharInput);
            this.Controls.Add(this.nudInput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Streams";
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.NumericUpDown nudInput;
        private System.Windows.Forms.TextBox txtCharInput;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Button btnRead;
    }
}

