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
    public partial class InputPlusOption : Form
    {
        public List<string> InputPlusList = new List<string>();
        //public MainWindow main = new MainWindow();
        public string SelectedPlus;

        public InputPlusOption()
        {
            InitializeComponent();

        }

        private void InputPlusOption_Load(object sender, EventArgs e)
        {
            try
            {
                //"C:\test\1.txt"をShift-JISコードとして開く
                System.IO.StreamReader sr = new System.IO.StreamReader(
                    @"InputPlus.txt",
                    System.Text.Encoding.GetEncoding("utf-8"));
                //内容を一行ずつ読み込む
                while (sr.Peek() > -1)
                {
                    string temp = sr.ReadLine();
                    PlusOptionList.Items.Add(temp);
                    InputPlusList.Add(temp);
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                PlusOptionList.Items.Clear();
                //ファイルを上書きし、Shift JISで書き込む
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    @"InputPlus.txt",
                    false,
                    System.Text.Encoding.GetEncoding("utf-8"));
                //TextBox1.Textの内容を1行ずつ書き込む
                sw.WriteLine("```"+"複数行"+"```");
                sw.WriteLine("**太字**");
                sw.WriteLine("'code'");
                sw.WriteLine("[](https://)");
                sw.WriteLine("?[](https://)");
                sw.WriteLine("\"\""+"複数行"+"\"\"");
                sw.WriteLine("【見出し】");
                sw.WriteLine("***びよーん***");
                sw.WriteLine("文字列　検索");
                //閉じる
                sw.Close();
                InputPlusOption_Load(sender, e);
            }
            //閉じる

        }



        private void OKButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedPlus = PlusOptionList.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("タグを選択してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            Close();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (OptionInput.Text == "")
            {
                MessageBox.Show("文字が空です",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else
            {
                InputPlusList.Add(OptionInput.Text);
            }
            //ファイルを上書きし、Shift JISで書き込む
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"InputPlus.txt",
                false,
                System.Text.Encoding.GetEncoding("utf-8"));

            PlusOptionList.Items.Clear();
            //TextBox1.Textの内容を1行ずつ書き込む
            foreach (string line in InputPlusList)
            {
                sw.WriteLine(line);
                PlusOptionList.Items.Add(line);
            }
            //閉じる
            sw.Close();
            OptionInput.Clear();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            PlusOptionList.Items.RemoveAt(PlusOptionList.SelectedIndex);
            InputPlusList = this.PlusOptionList.Items.Cast<string>().ToList<string>();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
            @"InputPlus.txt",
            false,
            System.Text.Encoding.GetEncoding("utf-8"));

            PlusOptionList.Items.Clear();
            //TextBox1.Textの内容を1行ずつ書き込む
            foreach (string line in InputPlusList)
            {
                sw.WriteLine(line);
                PlusOptionList.Items.Add(line);
            }
            //閉じる
            sw.Close();
        }
    }
}
