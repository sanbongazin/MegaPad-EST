namespace WindowsFormsApplication1
{
    partial class HashTagSelecter
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
            this.HashTagOption = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.HashTagInput = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HashTagOption
            // 
            this.HashTagOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HashTagOption.FormattingEnabled = true;
            this.HashTagOption.ItemHeight = 18;
            this.HashTagOption.Location = new System.Drawing.Point(12, 61);
            this.HashTagOption.Name = "HashTagOption";
            this.HashTagOption.Size = new System.Drawing.Size(638, 292);
            this.HashTagOption.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(667, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 33);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(667, 322);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(119, 31);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // HashTagInput
            // 
            this.HashTagInput.Location = new System.Drawing.Point(13, 25);
            this.HashTagInput.Name = "HashTagInput";
            this.HashTagInput.Size = new System.Drawing.Size(637, 25);
            this.HashTagInput.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(667, 136);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HashTagSelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 376);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HashTagInput);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HashTagOption);
            this.Name = "HashTagSelecter";
            this.Text = "ハッシュタグオプション";
            this.Load += new System.EventHandler(this.HashTagSelecter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HashTagOption;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox HashTagInput;
        private System.Windows.Forms.Button DeleteButton;
    }
}