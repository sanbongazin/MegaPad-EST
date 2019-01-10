namespace WindowsFormsApplication1
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.Toot_Input = new System.Windows.Forms.RichTextBox();
            this.LastTextNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公開トゥートCtrlEnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非公開トゥートAltEnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォローのみトゥートWinEnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了AltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常に最前面に表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントサイズの変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(22, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(23, 326);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 18);
            this.link.TabIndex = 10;
            // 
            // Toot_Input
            // 
            this.Toot_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Toot_Input.CausesValidation = false;
            this.Toot_Input.Location = new System.Drawing.Point(12, 36);
            this.Toot_Input.Name = "Toot_Input";
            this.Toot_Input.Size = new System.Drawing.Size(466, 202);
            this.Toot_Input.TabIndex = 12;
            this.Toot_Input.Text = "";
            this.Toot_Input.TextChanged += new System.EventHandler(this.Toot_Input_TextChanged);
            this.Toot_Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Toot_Input_KeyUp);
            // 
            // LastTextNumber
            // 
            this.LastTextNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastTextNumber.AutoSize = true;
            this.LastTextNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastTextNumber.Location = new System.Drawing.Point(439, 9);
            this.LastTextNumber.Name = "LastTextNumber";
            this.LastTextNumber.Size = new System.Drawing.Size(35, 18);
            this.LastTextNumber.TabIndex = 16;
            this.LastTextNumber.Text = "500";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.表示EToolStripMenuItem,
            this.ツールTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公開トゥートCtrlEnterToolStripMenuItem,
            this.非公開トゥートAltEnterToolStripMenuItem,
            this.フォローのみトゥートWinEnterToolStripMenuItem,
            this.終了AltF4ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.ファイルFToolStripMenuItem.Text = "ファイル（&F）";
            // 
            // 公開トゥートCtrlEnterToolStripMenuItem
            // 
            this.公開トゥートCtrlEnterToolStripMenuItem.Name = "公開トゥートCtrlEnterToolStripMenuItem";
            this.公開トゥートCtrlEnterToolStripMenuItem.Size = new System.Drawing.Size(330, 30);
            this.公開トゥートCtrlEnterToolStripMenuItem.Text = "公開トゥート　Ctrl+Enter";
            this.公開トゥートCtrlEnterToolStripMenuItem.Click += new System.EventHandler(this.公開トゥートCtrlEnterToolStripMenuItem_Click);
            // 
            // 非公開トゥートAltEnterToolStripMenuItem
            // 
            this.非公開トゥートAltEnterToolStripMenuItem.Name = "非公開トゥートAltEnterToolStripMenuItem";
            this.非公開トゥートAltEnterToolStripMenuItem.Size = new System.Drawing.Size(360, 30);
            this.非公開トゥートAltEnterToolStripMenuItem.Text = "非公開トゥート　Shift+Enter";
            this.非公開トゥートAltEnterToolStripMenuItem.Click += new System.EventHandler(this.非公開トゥートAltEnterToolStripMenuItem_Click);
            // 
            // フォローのみトゥートWinEnterToolStripMenuItem
            // 
            this.フォローのみトゥートWinEnterToolStripMenuItem.Name = "フォローのみトゥートWinEnterToolStripMenuItem";
            this.フォローのみトゥートWinEnterToolStripMenuItem.Size = new System.Drawing.Size(360, 30);
            this.フォローのみトゥートWinEnterToolStripMenuItem.Text = "フォローのみトゥート　Alt+Ctrl＋Enter";
            this.フォローのみトゥートWinEnterToolStripMenuItem.Click += new System.EventHandler(this.フォローのみトゥートWinEnterToolStripMenuItem_Click);
            // 
            // 終了AltF4ToolStripMenuItem
            // 
            this.終了AltF4ToolStripMenuItem.Name = "終了AltF4ToolStripMenuItem";
            this.終了AltF4ToolStripMenuItem.Size = new System.Drawing.Size(330, 30);
            this.終了AltF4ToolStripMenuItem.Text = "終了　Alt+F4";
            // 
            // 表示EToolStripMenuItem
            // 
            this.表示EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常に最前面に表示ToolStripMenuItem});
            this.表示EToolStripMenuItem.Name = "表示EToolStripMenuItem";
            this.表示EToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.表示EToolStripMenuItem.Text = "表示（&E）";
            // 
            // 常に最前面に表示ToolStripMenuItem
            // 
            this.常に最前面に表示ToolStripMenuItem.Checked = true;
            this.常に最前面に表示ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.常に最前面に表示ToolStripMenuItem.Name = "常に最前面に表示ToolStripMenuItem";
            this.常に最前面に表示ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.常に最前面に表示ToolStripMenuItem.Text = "常に最前面に表示";
            this.常に最前面に表示ToolStripMenuItem.Click += new System.EventHandler(this.常に最前面に表示ToolStripMenuItem_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントサイズの変更ToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.ツールTToolStripMenuItem.Text = "ツール（&T）";
            // 
            // フォントサイズの変更ToolStripMenuItem
            // 
            this.フォントサイズの変更ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.大ToolStripMenuItem});
            this.フォントサイズの変更ToolStripMenuItem.Name = "フォントサイズの変更ToolStripMenuItem";
            this.フォントサイズの変更ToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.フォントサイズの変更ToolStripMenuItem.Text = "フォントサイズの変更";
            // 
            // 小ToolStripMenuItem
            // 
            this.小ToolStripMenuItem.Name = "小ToolStripMenuItem";
            this.小ToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.小ToolStripMenuItem.Text = "小";
            this.小ToolStripMenuItem.Click += new System.EventHandler(this.小ToolStripMenuItem_Click);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.中ToolStripMenuItem.Text = "中";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.中ToolStripMenuItem_Click);
            // 
            // 大ToolStripMenuItem
            // 
            this.大ToolStripMenuItem.Name = "大ToolStripMenuItem";
            this.大ToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.大ToolStripMenuItem.Text = "大";
            this.大ToolStripMenuItem.Click += new System.EventHandler(this.大ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.Toot_Input);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LastTextNumber);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.RichTextBox Toot_Input;
        private System.Windows.Forms.Label LastTextNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公開トゥートCtrlEnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非公開トゥートAltEnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォローのみトゥートWinEnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了AltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常に最前面に表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントサイズの変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

