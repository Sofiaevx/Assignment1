
namespace Assignment01
{
    partial class fullname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fullname));
            this.txtshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtshow
            // 
            this.txtshow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtshow.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtshow.Location = new System.Drawing.Point(208, 26);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(120, 50);
            this.txtshow.TabIndex = 0;
            this.txtshow.Text = "Show Name";
            this.txtshow.UseVisualStyleBackColor = false;
            this.txtshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(340, 226);
            this.Controls.Add(this.txtshow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fullname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtshow;
    }
}

