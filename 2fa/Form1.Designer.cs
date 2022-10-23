namespace _2fa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Copy2fa = new System.Windows.Forms.Button();
            this.txt2fa = new System.Windows.Forms.TextBox();
            this.printcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Copy2fa
            // 
            this.Copy2fa.Location = new System.Drawing.Point(207, 24);
            this.Copy2fa.Name = "Copy2fa";
            this.Copy2fa.Size = new System.Drawing.Size(88, 38);
            this.Copy2fa.TabIndex = 0;
            this.Copy2fa.Text = "copy";
            this.Copy2fa.UseVisualStyleBackColor = true;
            this.Copy2fa.Click += new System.EventHandler(this.Copy2fa_Click);
            // 
            // txt2fa
            // 
            this.txt2fa.Location = new System.Drawing.Point(48, 34);
            this.txt2fa.Name = "txt2fa";
            this.txt2fa.Size = new System.Drawing.Size(140, 20);
            this.txt2fa.TabIndex = 1;
            // 
            // printcode
            // 
            this.printcode.Location = new System.Drawing.Point(49, 81);
            this.printcode.Name = "printcode";
            this.printcode.Size = new System.Drawing.Size(140, 20);
            this.printcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "2FA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "code";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(207, 82);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 28);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 142);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printcode);
            this.Controls.Add(this.txt2fa);
            this.Controls.Add(this.Copy2fa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Get_2FA by @huyxuanvu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Copy2fa;
        private System.Windows.Forms.TextBox txt2fa;
        private System.Windows.Forms.TextBox printcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
    }
}

