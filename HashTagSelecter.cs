using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HashTagSelecter : Form
    {
        public List<string> HashTagList = new List<string>();
        public MainWindow main = new MainWindow();
        public string SelectedTag;

        public HashTagSelecter()
        {
            InitializeComponent();
            
        }

        private void HashTagSelecter_Load(object sender, EventArgs e)
        {
            try
            {
                //"C:\test\1.txt"をShift-JISコードとして開く
                System.IO.StreamReader sr = new System.IO.StreamReader(
                    @"HashTag.txt",
                    System.Text.Encoding.GetEncoding("utf-8"));
                //内容を一行ずつ読み込む
                while (sr.Peek() > -1)
                {
                    string temp = sr.ReadLine();
                    HashTagOption.Items.Add(temp);
                    HashTagList.Add(temp);
                }
                sr.Close();
            }
            catch (FileNotFoundException) {
                HashTagOption.Items.Clear();
                //ファイルを上書きし、Shift JISで書き込む
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    @"HashTag.txt",
                    false,
                    System.Text.Encoding.GetEncoding("utf-8"));
                //TextBox1.Textの内容を1行ずつ書き込む
                sw.WriteLine("MegaPad");
                //閉じる
                sw.Close();
                HashTagSelecter_Load(sender, e);
            }
            //閉じる
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (HashTagInput.Text == "")
            {
                MessageBox.Show("文字が空です",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return; 
            }
            else
            {
                HashTagList.Add(HashTagInput.Text);
            }
            //ファイルを上書きし、Shift JISで書き込む
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"HashTag.txt",
                false,
                System.Text.Encoding.GetEncoding("utf-8"));

            HashTagOption.Items.Clear();
            //TextBox1.Textの内容を1行ずつ書き込む
            foreach (string line in HashTagList)
            {
                sw.WriteLine(line);
                HashTagOption.Items.Add(line);
            }
            //閉じる
            sw.Close();
            HashTagInput.Clear();

           
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedTag = HashTagOption.SelectedItem.ToString();
            }
            catch (NullReferenceException) {
                MessageBox.Show("タグを選択してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HashTagOption.Items.RemoveAt(HashTagOption.SelectedIndex);
            HashTagList = this.HashTagOption.Items.Cast<string>().ToList<string>();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
            @"HashTag.txt",
            false,
            System.Text.Encoding.GetEncoding("utf-8"));

            HashTagOption.Items.Clear();
            //TextBox1.Textの内容を1行ずつ書き込む
            foreach (string line in HashTagList)
            {
                sw.WriteLine(line);
                HashTagOption.Items.Add(line);
            }
            //閉じる
            sw.Close();
        }
    }
}
