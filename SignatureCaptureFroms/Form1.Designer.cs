namespace SignatureCaptureFroms
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
            this.areaSignature = new System.Windows.Forms.Panel();
            this.butNew = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areaSignature
            // 
            this.areaSignature.BackColor = System.Drawing.Color.Gainsboro;
            this.areaSignature.Location = new System.Drawing.Point(191, 98);
            this.areaSignature.Name = "areaSignature";
            this.areaSignature.Size = new System.Drawing.Size(356, 142);
            this.areaSignature.TabIndex = 0;
            this.areaSignature.Visible = false;
            this.areaSignature.Paint += new System.Windows.Forms.PaintEventHandler(this.areaSignature_Paint);
            // 
            // butNew
            // 
            this.butNew.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.butNew.Location = new System.Drawing.Point(204, 297);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(75, 23);
            this.butNew.TabIndex = 1;
            this.butNew.Text = "butNew";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Load.Location = new System.Drawing.Point(485, 297);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Save.Location = new System.Drawing.Point(348, 297);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 486);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.areaSignature);
            this.Name = "Form1";
            this.Text = "PocketSignature";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel areaSignature;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
    }
}

