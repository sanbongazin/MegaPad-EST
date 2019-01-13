using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastodot.Enums;
using Mastodot.Utils;
using Mastodot.Entities;
using Mastodot.Exceptions;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Oauth : Form
    {
        public string host;
        public Mastodot.Entities.RegisteredApp registeredApp;
        public string code;
        private MainWindow main = new MainWindow();

        public Oauth()
        {
            InitializeComponent();
        }

        public void GenerateButton_Click(object sender, EventArgs e)
        {
            host = InstanceInput.Text;
            try
            {
                registeredApp = ApplicaionManager.RegistApp(host, "MegaPad", Scope.Read | Scope.Write | Scope.Follow).Result;
            }
           catch (AggregateException) {
                MessageBox.Show("インスタンスを取得できませんでした。正しいインスタンスの名前か確認してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            var url = ApplicaionManager.GetOAuthUrl(registeredApp);

            OAuthlink.Text = url;
        }

        private void OAuthlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            OAuthlink.LinkVisited = true;
            //ブラウザで開く
            System.Diagnostics.Process.Start(OAuthlink.Text);
        }

        private async void OAuthButton_ClickAsync(object sender, EventArgs e)
        {

            // 操作するレジストリ・キーの名前
            string registryKeyName = @"Software\MegaPad\Sub";
            // 取得処理を行う対象となるレジストリの値の名前
            string registryValueName = "hostname";

            //キー（HKEY_CURRENT_USER\Software\Sample）を開く
            using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(registryKeyName))
            {
                // レジストリの値を設定
                registryKey.SetValue(registryValueName, host);
            }


            code = OAuthInput.Text;
            var tokens = await ApplicaionManager.GetAccessTokenByCode(registeredApp, code);



            // 取得処理を行う対象となるレジストリの値の名前
            registryValueName = "AccessToken";

            //キー（HKEY_CURRENT_USER\Software\Sample）を開く
            using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(registryKeyName))
            {
                // レジストリの値を設定
                registryKey.SetValue(registryValueName, tokens.AccessToken);
            }

            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Oauth_Load(object sender, EventArgs e)
        {

        }
    }
}
