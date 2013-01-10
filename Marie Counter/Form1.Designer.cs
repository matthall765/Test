namespace Marie_Counter
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
            this.cmdUm = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdUm
            // 
            this.cmdUm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdUm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdUm.FlatAppearance.BorderSize = 3;
            this.cmdUm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cmdUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUm.Location = new System.Drawing.Point(74, 160);
            this.cmdUm.Name = "cmdUm";
            this.cmdUm.Size = new System.Drawing.Size(126, 60);
            this.cmdUm.TabIndex = 0;
            this.cmdUm.Text = "Um";
            this.cmdUm.UseVisualStyleBackColor = false;
            this.cmdUm.Click += new System.EventHandler(this.cmdUm_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(65, 55);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 24);
            this.lblCount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cmdUm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUm;
        private System.Windows.Forms.Label lblCount;
    }
}

