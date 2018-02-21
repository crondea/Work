namespace WorkTesting
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
            this.buttonMSN = new System.Windows.Forms.Button();
            this.buttonMBSN = new System.Windows.Forms.Button();
            this.buttonPSN = new System.Windows.Forms.Button();
            this.labelMSN = new System.Windows.Forms.Label();
            this.labelMBSN = new System.Windows.Forms.Label();
            this.labelPSN = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelUUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMSN
            // 
            this.buttonMSN.Location = new System.Drawing.Point(12, 39);
            this.buttonMSN.Name = "buttonMSN";
            this.buttonMSN.Size = new System.Drawing.Size(105, 38);
            this.buttonMSN.TabIndex = 0;
            this.buttonMSN.Text = "Machine Serial Number";
            this.buttonMSN.UseVisualStyleBackColor = true;
            this.buttonMSN.Click += new System.EventHandler(this.buttonMSN_Click);
            // 
            // buttonMBSN
            // 
            this.buttonMBSN.Location = new System.Drawing.Point(12, 94);
            this.buttonMBSN.Name = "buttonMBSN";
            this.buttonMBSN.Size = new System.Drawing.Size(105, 38);
            this.buttonMBSN.TabIndex = 1;
            this.buttonMBSN.Text = "MB Serial Number";
            this.buttonMBSN.UseVisualStyleBackColor = true;
            this.buttonMBSN.Click += new System.EventHandler(this.buttonMBSN_Click);
            // 
            // buttonPSN
            // 
            this.buttonPSN.Location = new System.Drawing.Point(12, 147);
            this.buttonPSN.Name = "buttonPSN";
            this.buttonPSN.Size = new System.Drawing.Size(105, 38);
            this.buttonPSN.TabIndex = 2;
            this.buttonPSN.Text = "Processor Serial Number";
            this.buttonPSN.UseVisualStyleBackColor = true;
            this.buttonPSN.Click += new System.EventHandler(this.buttonPSN_Click);
            // 
            // labelMSN
            // 
            this.labelMSN.AutoSize = true;
            this.labelMSN.Location = new System.Drawing.Point(173, 52);
            this.labelMSN.Name = "labelMSN";
            this.labelMSN.Size = new System.Drawing.Size(0, 13);
            this.labelMSN.TabIndex = 3;
            // 
            // labelMBSN
            // 
            this.labelMBSN.AutoSize = true;
            this.labelMBSN.Location = new System.Drawing.Point(173, 119);
            this.labelMBSN.Name = "labelMBSN";
            this.labelMBSN.Size = new System.Drawing.Size(0, 13);
            this.labelMBSN.TabIndex = 4;
            // 
            // labelPSN
            // 
            this.labelPSN.AutoSize = true;
            this.labelPSN.Location = new System.Drawing.Point(173, 160);
            this.labelPSN.Name = "labelPSN";
            this.labelPSN.Size = new System.Drawing.Size(0, 13);
            this.labelPSN.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 200);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(105, 38);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate UUID";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(173, 213);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(0, 13);
            this.labelUUID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 259);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelPSN);
            this.Controls.Add(this.labelMBSN);
            this.Controls.Add(this.labelMSN);
            this.Controls.Add(this.buttonPSN);
            this.Controls.Add(this.buttonMBSN);
            this.Controls.Add(this.buttonMSN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMSN;
        private System.Windows.Forms.Button buttonMBSN;
        private System.Windows.Forms.Button buttonPSN;
        private System.Windows.Forms.Label labelMSN;
        private System.Windows.Forms.Label labelMBSN;
        private System.Windows.Forms.Label labelPSN;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelUUID;
    }
}

