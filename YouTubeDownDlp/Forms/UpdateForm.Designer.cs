namespace YouTubeDownDlp
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.updatelog_richTextBox = new System.Windows.Forms.RichTextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "yt-dlpを更新しています　しばらくお待ち下さい";
            // 
            // updatelog_richTextBox
            // 
            this.updatelog_richTextBox.Location = new System.Drawing.Point(0, 30);
            this.updatelog_richTextBox.Name = "updatelog_richTextBox";
            this.updatelog_richTextBox.ReadOnly = true;
            this.updatelog_richTextBox.Size = new System.Drawing.Size(442, 135);
            this.updatelog_richTextBox.TabIndex = 1;
            this.updatelog_richTextBox.Text = "";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(341, 171);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(90, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "終了";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 206);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.updatelog_richTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox updatelog_richTextBox;
        private Button close_button;
    }
}