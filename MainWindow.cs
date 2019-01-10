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

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        static Oauth form2 =   new Oauth();
        public static Mastodot.Entities.RegisteredApp registeredApp;
        private static string host;
        private static string AccessToken;
        public static  string [] TodoList;
        public static MainWindow main = new MainWindow();
        private string UserName;

        public MainWindow()
        {

            //var p = new Form1();
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
                Toot(a);
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



        public void Form2_FormClosed(object sender, FormClosedEventArgs e) {


            Oauth f2 = (Oauth)sender;
            this.TopMost = true;
            //main.OAuth();
        }

        public void Toot(string mode) {
            registeredApp = ApplicaionManager.RegistApp(host, "ExtremeSimpleTooter", Scope.Read | Scope.Write | Scope.Follow).Result;
            var client = new MastodonClient(host, AccessToken);

            
            string TootMessage = Toot_Input.Text+ Environment.NewLine;
            if (TootMessage == "") {
                return;
            }
            if (mode == "公開")
            {
                client.PostNewStatus(status: TootMessage +"#On_MegaPad_EST", visibility: Mastodot.Enums.Visibility.Public);
            }
            else if (mode == "非公開")
            {
                client.PostNewStatus(status: TootMessage + "#On_MegaPad_EST", visibility: Mastodot.Enums.Visibility.Unlisted);
            }
            else {
                client.PostNewStatus(status: TootMessage  + "#On_MegaPad_EST", visibility: Mastodot.Enums.Visibility.Private);
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
            if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                OAuth("公開");
            }
            else if (e.KeyCode == Keys.Enter && e.Shift == true)
            {
                OAuth("非公開");
            }
            else if (e.KeyCode == Keys.Enter && e.Alt == true && e.Control == true) {
                OAuth("フォローのみ");
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
    }
}
