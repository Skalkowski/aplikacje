namespace projekt
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
            this.polacz = new System.Windows.Forms.Button();
            this.bez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(23, 46);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(99, 22);
            this.polacz.TabIndex = 0;
            this.polacz.Text = "Połączeniowy";
            this.polacz.UseVisualStyleBackColor = true;
            this.polacz.Click += new System.EventHandler(this.polacz_Click);
            // 
            // bez
            // 
            this.bez.Location = new System.Drawing.Point(182, 46);
            this.bez.Name = "bez";
            this.bez.Size = new System.Drawing.Size(75, 23);
            this.bez.TabIndex = 1;
            this.bez.Text = "bez";
            this.bez.UseVisualStyleBackColor = true;
            this.bez.Click += new System.EventHandler(this.bez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bez);
            this.Controls.Add(this.polacz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button polacz;
        private System.Windows.Forms.Button bez;
    }
}

