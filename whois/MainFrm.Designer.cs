
namespace whois
{
    partial class MainFrm
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
            this.Search_btn = new System.Windows.Forms.Button();
            this.Domain_tb = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.ListBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(485, 9);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 0;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Domain_tb
            // 
            this.Domain_tb.Location = new System.Drawing.Point(12, 12);
            this.Domain_tb.Name = "Domain_tb";
            this.Domain_tb.Size = new System.Drawing.Size(467, 20);
            this.Domain_tb.TabIndex = 1;
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(12, 38);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(548, 251);
            this.output.TabIndex = 2;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(485, 295);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_btn.TabIndex = 3;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 327);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Domain_tb);
            this.Controls.Add(this.Search_btn);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "whois";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Domain_tb;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button Clear_btn;
    }
}

