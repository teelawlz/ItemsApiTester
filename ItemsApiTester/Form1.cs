using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
//using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsApiTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Setting defaults
            this.baseurl = "http://us.battle.net";
            this.apitype = "/api/wow";
            this.locale = "";
            this.itemtype = "/item";
            this.itemid = "/0";
            RegionSelector.Text = "US";
            JsonOutput.Text = AssembleUrl();
        }

        private string baseurl;
        private string apitype;
        private string locale;
        private string itemtype;
        private string itemid;


        #region ItemTypeControl
        private void itemRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            
            if (rb.Checked)
            {
                itemtype = rb.Text;
                JsonOutput.Text = AssembleUrl();
                JsonOutput.Update();
            }
        }
        #endregion

        #region LocaleControl
        private string[] UsLocales = new string[] {
            "",
            "en_US",
            "es_MX",
            "pt_BR"
        };
        private string[] EuLocales = new string[] {
            "",
            "en_GB",
            "es_ES",
            "fr_FR",
            "ru_RU",
            "de_DE",
            "pt_PT",
            "it_IT"
        };
        private string[] KrLocales = new string[] {
            "",
            "ko_KR"
        };
        private string[] TwLocales = new string[] {
            "",
            "zh_TW"
        };
        private string[] CnLocales = new string[] {
            "",
            "zh_CN"
        };

        private void LocaleSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Text != "")
            {
                locale = "?locale=" + cb.Text;
            }
            else
            {
                locale = null;
            }
            JsonOutput.Text = AssembleUrl();
        }
        #endregion

        #region RegionControl
        private void RegionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RegionSelector.Text)
            {
                case "US":
                    baseurl = "http://us.battle.net";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(UsLocales);
                    break;
                case "Europe":
                    baseurl = "http://eu.battle.net";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(EuLocales);
                    break;
                case "Korea":
                    baseurl = "http://kr.battle.net";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(KrLocales);
                    break;
                case "China":
                    baseurl = "http://www.battlenet.com.cn";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(CnLocales);
                    break;
                case "Taiwan":
                    baseurl = "http://eu.battle.net";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(TwLocales);
                    break;
                default:
                    baseurl = "http://us.battle.net";
                    LocaleSelector.Items.Clear();
                    LocaleSelector.Items.AddRange(UsLocales);
                    break;
            }
            JsonOutput.Text = AssembleUrl();
        }
        #endregion

        #region ItemIdControl
        private void IdField_Click(object sender, EventArgs e)
        {
            IdField.SelectAll();
        }

        private void IdField_TextChanged(object sender, EventArgs e)
        {
            if (IdField.Text.Length > 0)
            {
                try
                {
                    Convert.ToInt64(IdField.Text);
                }
                catch
                {
                    //MessageBox.Show("Invalid entry. Must be a whole number. Re-enter value. " + IdField.Text.Length.ToString(), "Fail");
                    IdField.Text = new String(IdField.Text.Where(c => c >= '0' && c <= '9').ToArray());
                    IdField.SelectionStart = IdField.TextLength;
                }
            }
            itemid = "/" + IdField.Text;
            JsonOutput.Text = AssembleUrl();
        }
        #endregion

        private string AssembleUrl()
        {
            return baseurl + apitype + itemtype + itemid + locale;
        }
        
        // Sets off API call
        private void Request_Click(object sender, EventArgs e)
        {
            MakeRequest();            
        }

        private void IdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                MakeRequest();
            }
        }

        private void MakeRequest()
        {
            JsonOutput.Text = AssembleUrl();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AssembleUrl());
            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception m)
            {
                JsonOutput.AppendText(Environment.NewLine + m.ToString());
                return;
            }


            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();

                //var jsonresult = Newtonsoft.Json.Linq.JObject.Parse(result);
                ItemJson jsonresult = JsonConvert.DeserializeObject<ItemJson>(result);
                string jsonresultserialized = JsonConvert.SerializeObject(jsonresult, Formatting.Indented);
                //JsonSerializer jsonresult = JsonSerializer.Create();

                JsonOutput.AppendText(Environment.NewLine + jsonresultserialized);

            }
        }
    }
}
