
namespace Task
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
            this.TimeShowLbl = new System.Windows.Forms.Label();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeShowLbl
            // 
            this.TimeShowLbl.AutoSize = true;
            this.TimeShowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeShowLbl.Location = new System.Drawing.Point(348, 36);
            this.TimeShowLbl.Name = "TimeShowLbl";
            this.TimeShowLbl.Size = new System.Drawing.Size(0, 33);
            this.TimeShowLbl.TabIndex = 0;
            // 
            // BakuBtn
            // 
            this.BakuBtn.AutoSize = true;
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BakuBtn.Location = new System.Drawing.Point(64, 213);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(122, 41);
            this.BakuBtn.TabIndex = 1;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = true;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // LondonBtn
            // 
            this.LondonBtn.AutoSize = true;
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LondonBtn.Location = new System.Drawing.Point(555, 213);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(122, 41);
            this.LondonBtn.TabIndex = 2;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task.Properties.Resources.Baku;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Controls.Add(this.TimeShowLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeShowLbl;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

