namespace RgCore_CallsQueue_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CallsCountLabel = new System.Windows.Forms.Label();
            this.totalCountLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CallsCountLabel
            // 
            this.CallsCountLabel.AutoSize = true;
            this.CallsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallsCountLabel.Location = new System.Drawing.Point(81, 73);
            this.CallsCountLabel.Name = "CallsCountLabel";
            this.CallsCountLabel.Size = new System.Drawing.Size(92, 91);
            this.CallsCountLabel.TabIndex = 0;
            this.CallsCountLabel.Text = "X";
            this.CallsCountLabel.Click += new System.EventHandler(this.CallsCountLabel_Click);
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCountLabel.Location = new System.Drawing.Point(87, 38);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(82, 20);
            this.totalCountLabel.TabIndex = 1;
            this.totalCountLabel.Text = "Total Calls";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(89, 38);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(72, 24);
            this.status.TabIndex = 2;
            this.status.Text = "Starting";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(264, 216);
            this.Controls.Add(this.status);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.CallsCountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label CallsCountLabel;
        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.Label status;
    }
}

