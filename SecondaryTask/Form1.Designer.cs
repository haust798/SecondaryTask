namespace SecondaryTask
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
            this.components = new System.ComponentModel.Container();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // txtLetter
            // 
            this.txtLetter.BackColor = System.Drawing.SystemColors.Control;
            this.txtLetter.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLetter.Location = new System.Drawing.Point(25, 36);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.ReadOnly = true;
            this.txtLetter.Size = new System.Drawing.Size(198, 158);
            this.txtLetter.TabIndex = 1;
            this.txtLetter.TabStop = false;
            this.txtLetter.Text = "A";
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter.Click += new System.EventHandler(this.txtLetter_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 229);
            this.Controls.Add(this.txtLetter);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLetter;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

