namespace WindowsFormsApplication1
{
    partial class Oauth
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
            System.Windows.Forms.Label OAuthMessege;
            this.Instance = new System.Windows.Forms.Label();
            this.InstanceInput = new System.Windows.Forms.TextBox();
            this.OAuthlink = new System.Windows.Forms.LinkLabel();
            this.OAuthAccessTokenMessege = new System.Windows.Forms.Label();
            this.OAuthInput = new System.Windows.Forms.TextBox();
            this.OAuthButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            OAuthMessege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OAuthMessege
            // 
            OAuthMessege.AutoSize = true;
            OAuthMessege.Location = new System.Drawing.Point(12, 136);
            OAuthMessege.Name = "OAuthMessege";
            OAuthMessege.Size = new System.Drawing.Size(405, 18);
            OAuthMessege.TabIndex = 3;
            OAuthMessege.Text = "正常に認証されると以下のリンクが認証のリンクになります";
            // 
            // Instance
            // 
            this.Instance.AutoSize = true;
            this.Instance.Location = new System.Drawing.Point(13, 13);
            this.Instance.Name = "Instance";
            this.Instance.Size = new System.Drawing.Size(420, 18);
            this.Instance.TabIndex = 0;
            this.Instance.Text = "インスタンスを入力してください(Ex.pawoo.net,qiitadon.com)";
            // 
            // InstanceInput
            // 
            this.InstanceInput.Location = new System.Drawing.Point(25, 55);
            this.InstanceInput.Name = "InstanceInput";
            this.InstanceInput.Size = new System.Drawing.Size(477, 25);
            this.InstanceInput.TabIndex = 1;
            // 
            // OAuthlink
            // 
            this.OAuthlink.AutoSize = true;
            this.OAuthlink.Location = new System.Drawing.Point(22, 178);
            this.OAuthlink.Name = "OAuthlink";
            this.OAuthlink.Size = new System.Drawing.Size(317, 18);
            this.OAuthlink.TabIndex = 2;
            this.OAuthlink.TabStop = true;
            this.OAuthlink.Text = "正常に認証されると、こちらがリンクになります";
            this.OAuthlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OAuthlink_LinkClicked);
            // 
            // OAuthAccessTokenMessege
            // 
            this.OAuthAccessTokenMessege.AutoSize = true;
            this.OAuthAccessTokenMessege.Location = new System.Drawing.Point(12, 222);
            this.OAuthAccessTokenMessege.Name = "OAuthAccessTokenMessege";
            this.OAuthAccessTokenMessege.Size = new System.Drawing.Size(308, 18);
            this.OAuthAccessTokenMessege.TabIndex = 4;
            this.OAuthAccessTokenMessege.Text = "こちらにコピーした文字列を入力してください";
            // 
            // OAuthInput
            // 
            this.OAuthInput.Location = new System.Drawing.Point(25, 262);
            this.OAuthInput.Name = "OAuthInput";
            this.OAuthInput.Size = new System.Drawing.Size(477, 25);
            this.OAuthInput.TabIndex = 5;
            // 
            // OAuthButton
            // 
            this.OAuthButton.Location = new System.Drawing.Point(60, 307);
            this.OAuthButton.Name = "OAuthButton";
            this.OAuthButton.Size = new System.Drawing.Size(127, 29);
            this.OAuthButton.TabIndex = 6;
            this.OAuthButton.Text = "認証";
            this.OAuthButton.UseVisualStyleBackColor = true;
            this.OAuthButton.Click += new System.EventHandler(this.OAuthButton_ClickAsync);
            // 
            // GenerateButton
            // 
            this.GenerateButton.AutoSize = true;
            this.GenerateButton.Location = new System.Drawing.Point(198, 86);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(141, 30);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "リンク生成";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.AutoSize = true;
            this.Cancel_Button.Location = new System.Drawing.Point(329, 308);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(88, 28);
            this.Cancel_Button.TabIndex = 8;
            this.Cancel_Button.Text = "キャンセル";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Oauth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OAuthButton);
            this.Controls.Add(this.OAuthInput);
            this.Controls.Add(this.OAuthAccessTokenMessege);
            this.Controls.Add(OAuthMessege);
            this.Controls.Add(this.OAuthlink);
            this.Controls.Add(this.InstanceInput);
            this.Controls.Add(this.Instance);
            this.Name = "Oauth";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Oauth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instance;
        private System.Windows.Forms.TextBox InstanceInput;
        private System.Windows.Forms.LinkLabel OAuthlink;
        private System.Windows.Forms.Label OAuthAccessTokenMessege;
        private System.Windows.Forms.TextBox OAuthInput;
        private System.Windows.Forms.Button OAuthButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button Cancel_Button;
    }
}