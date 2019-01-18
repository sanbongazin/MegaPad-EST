using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastodot;
using Mastodot.Enums;
using Mastodot.Utils;
using Mastodot.Entities;
using System.Drawing;
using Misq;
using Misq.Entities;
using System.Collections.Generic;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        static Oauth form2 =   new Oauth();
        public static Mastodot.Entities.RegisteredApp registeredApp;
        private static string host;
        private static string AccessToken;
        public static  string [] TodoList;
        //public static MainWindow main = new MainWindow();
        private App app = new Misq.App("https://misskey.xyz", "gKC6a0wxLS1YQwiTOxAPr95x1R7qzkHV");
        private Me user;
        private int i = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.TopMost = true;
        }


        public void OAuth(string a)
        {
            this.TopMost = false;
            try
            {
                //"C:\test\1.txt"をShift-JISコードとして開く
                Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\MegaPad\sub", false);
                //内容を一行ずつ読み込む
                AccessToken = (string)regkey.GetValue("AccessToken");
                host = (string)regkey.GetValue("hostname");
                if (host == "misskey.xyz")
                {
                    OAuthMisskeyAsync();
                }
                else
                {
                    Toot(a);
                }
            }
            catch (NullReferenceException)
            {
                    form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                    try
                    {
                        form2.ShowDialog();
                    }
                    catch (Exception)
                    {
                        form2.Visible = false;
                    }
            }
            this.TopMost = true;
        }

        public async void OAuthMisskeyAsync() {


            if (AccessToken == "misskey is not need token" && i ==0) {
                user = await app.Authorize();
                i++;
            }
           
            string TootMessage = Toot_Input.Text;

            if (TootMessage.Length > 500)
            {
                MessageBox.Show("文字数超過です。減らしてください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            // Let's post a message to Misskey
            await user.Request("notes/create", new Dictionary<string, object> {
                { "text", TootMessage }
            });

            Toot_Input.Clear();
        }






        public void Form2_FormClosed(object sender, FormClosedEventArgs e) {


            Oauth f2 = (Oauth)sender;
            this.TopMost = true;
            //main.OAuth();
        }

        public void Toot(string mode) {
            registeredApp = ApplicaionManager.RegistApp(host, "MegaPad", Scope.Read | Scope.Write | Scope.Follow).Result;
            var client = new MastodonClient(host, AccessToken);

            
            string TootMessage = Toot_Input.Text;

            if (TootMessage.Length > 500) {
                MessageBox.Show("文字数超過です。減らしてください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }


            if (TootMessage == "") {
                return;
            }
            if (mode == "公開")
            {
                client.PostNewStatus(status: TootMessage , visibility: Mastodot.Enums.Visibility.Public);
            }
            else if (mode == "非公開")
            {
                client.PostNewStatus(status: TootMessage , visibility: Mastodot.Enums.Visibility.Unlisted);
            }
            else {
                client.PostNewStatus(status: TootMessage  , visibility: Mastodot.Enums.Visibility.Private);
            }

            Toot_Input.Clear();
        }
        


        private void Toot_Input_TextChanged(object sender, EventArgs e)
        {
            LastTextNumber.Text = (500 - Toot_Input.Text.Length).ToString();
            if (int.Parse(LastTextNumber.Text)<0) {
                LastTextNumber.ForeColor = Color.Red;
            }
        }


        private void Toot_Input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift == true && e.Control == true)
            {
                OAuth("フォローのみ");
            }
            else if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                OAuth("公開");
            }
            else if (e.KeyCode == Keys.Enter && e.Shift == true)
            {
                OAuth("非公開");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void 公開トゥートCtrlEnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OAuth("公開");
        }

        private void 非公開トゥートAltEnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OAuth("非公開");
        }

        private void フォローのみトゥートWinEnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OAuth("フォローのみ");
        }

        private void 小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toot_Input.SelectAll();
            Toot_Input.SelectionFont = new Font("MS UI Gothic", 7);
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toot_Input.SelectAll();
            Toot_Input.SelectionFont = new Font("MS UI Gothic", 9);
        }

        private void 大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toot_Input.SelectAll();
            Toot_Input.SelectionFont = new Font("MS UI Gothic", 12);
        }

        private void 常に最前面に表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            if (item.Checked == false) {
                this.TopMost = false;
            }
            else {
                this.TopMost = true;
            }

        }


        private void ライトToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Toot_Input.BackColor = Color.White;
            Toot_Input.ForeColor = Color.Black;
            MainMenuStrip.BackColor = Color.White;
            MainMenuStrip.ForeColor = Color.Black;
            LastTextNumber.ForeColor = Color.Black;

            ToolStripMenuItem[] groupMenuItems = new ToolStripMenuItem[]
                {
                this.ライトToolStripMenuItem,
                this.ダークToolStripMenuItem,
                this.brewToolStripMenuItem,
                //this.オリジナルToolStripMenuItem
                };

            foreach (ToolStripMenuItem item in groupMenuItems)
            {
                if (object.ReferenceEquals(item, sender))
                {
                    //ClickされたToolStripMenuItemならば、Indeterminateにする
                    item.CheckState = CheckState.Checked;
                }
                else
                {
                    //ClickされたToolStripMenuItemでなければ、Uncheckedにする
                    item.CheckState = CheckState.Unchecked;
                }

            }
        }

        private void ダークToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Toot_Input.BackColor = Color.Black;
            Toot_Input.ForeColor = Color.White;
            MainMenuStrip.BackColor = Color.Black;
            MainMenuStrip.ForeColor = Color.White;
            LastTextNumber.ForeColor = Color.White;
            LastTextNumber.BackColor = Color.Black;


            ToolStripMenuItem[] groupMenuItems = new ToolStripMenuItem[]
                {
                this.ライトToolStripMenuItem,
                this.ダークToolStripMenuItem,
                this.brewToolStripMenuItem,
                //this.オリジナルToolStripMenuItem
                };

            foreach (ToolStripMenuItem item in groupMenuItems)
            {
                if (object.ReferenceEquals(item, sender))
                {
                    //ClickされたToolStripMenuItemならば、Indeterminateにする
                    item.CheckState = CheckState.Checked;
                }
                else
                {
                    //ClickされたToolStripMenuItemでなければ、Uncheckedにする
                    item.CheckState = CheckState.Unchecked;
                }

            }
        }

        private void brewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Toot_Input.BackColor = Color.Black;
            Toot_Input.ForeColor = Color.GreenYellow;
            MainMenuStrip.BackColor = Color.Black;
            MainMenuStrip.ForeColor = Color.GreenYellow;
            LastTextNumber.ForeColor = Color.GreenYellow;
            LastTextNumber.BackColor = Color.Black;


            ToolStripMenuItem[] groupMenuItems = new ToolStripMenuItem[]
                {
                this.ライトToolStripMenuItem,
                this.ダークToolStripMenuItem,
                this.brewToolStripMenuItem,
                //this.オリジナルToolStripMenuItem
                };

            foreach (ToolStripMenuItem item in groupMenuItems)
            {
                if (object.ReferenceEquals(item, sender))
                {
                    //ClickされたToolStripMenuItemならば、Indeterminateにする
                    item.CheckState = CheckState.Checked;
                }
                else
                {
                    //ClickされたToolStripMenuItemでなければ、Uncheckedにする
                    item.CheckState = CheckState.Unchecked;
                }

            }
        }

        private void ハッシュタグオプションToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashTagSelecter tagselector = new HashTagSelecter();
            this.TopMost = false;
            tagselector.ShowDialog();
            this.TopMost = true;

            if (tagselector.SelectedTag == null)
            {
                Toot_Input.Text = Toot_Input.Text;
            }
            else {
                Toot_Input.Text = Toot_Input.Text + Environment.NewLine + "#" + tagselector.SelectedTag;
            }
        }

        private void 文字修飾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPlusOption input = new InputPlusOption();
            this.TopMost = false;
            input.ShowDialog();
            this.TopMost = true;
            if (input.SelectedPlus == null)
            {
                Toot_Input.Text = Toot_Input.Text;
            }
            else
            {
                Toot_Input.Text = Toot_Input.Text + input.SelectedPlus;
            }
        }
    }
}
