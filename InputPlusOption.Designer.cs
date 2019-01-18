namespace WindowsFormsApplication1
{
    partial class InputPlusOption
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
            this.OptionInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.PlusOptionList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OptionInput
            // 
            this.OptionInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionInput.Location = new System.Drawing.Point(12, 35);
            this.OptionInput.Name = "OptionInput";
            this.OptionInput.Size = new System.Drawing.Size(628, 25);
            this.OptionInput.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(676, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 28);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Location = new System.Drawing.Point(676, 120);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 28);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.Location = new System.Drawing.Point(676, 383);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 28);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "これにする";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click_1);
            // 
            // PlusOptionList
            // 
            this.PlusOptionList.FormattingEnabled = true;
            this.PlusOptionList.ItemHeight = 18;
            this.PlusOptionList.Location = new System.Drawing.Point(12, 89);
            this.PlusOptionList.Name = "PlusOptionList";
            this.PlusOptionList.Size = new System.Drawing.Size(628, 328);
            this.PlusOptionList.TabIndex = 5;
            // 
            // InputPlusOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.PlusOptionList);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OptionInput);
            this.Name = "InputPlusOption";
            this.Text = "InputPlusOption";
            this.Load += new System.EventHandler(this.InputPlusOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OptionInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ListBox PlusOptionList;
    }
}