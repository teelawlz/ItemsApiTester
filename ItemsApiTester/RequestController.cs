using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsApiTester
{
    public class RequestController
    {
        public RequestController()
        {
            // Setting defaults
            this.baseurl = "http://us.battle.net";
            this.apitype = "api/wow";
            this.locale = "";
            this.itemtype = "item";
            this.itemid = "0";            
        }

        public string assembledurl;
        public string baseurl;
        public string itemid;
        private string apitype;
        private string locale;
        private string itemtype;
        

        // Main function for assembling API request location
        public string AssembleUrl()
        {
            assembledurl = String.Format("{0}/{1}/{2}/{3}{4}", baseurl, apitype, itemtype, itemid, locale);
            //assembledurl = baseurl + apitype + itemtype + itemid + locale;
            return assembledurl;
        }

        #region LocalesAndRegions
        public LocaleInfo SetRegionLocaleContext(string selection)
        {
            LocaleInfo li = new LocaleInfo();

            switch (selection)
            {
                case "US":
                    baseurl = "http://us.battle.net";
                    li.locales = UsLocales;
                    break;
                case "Europe":
                    baseurl = "http://eu.battle.net";
                    li.locales = EuLocales;
                    break;
                case "Korea":
                    baseurl = "http://kr.battle.net";
                    li.locales = KrLocales;
                    break;
                case "China":
                    baseurl = "http://www.battlenet.com.cn";
                    li.locales = CnLocales;
                    break;
                case "Taiwan":
                    baseurl = "http://tw.battle.net";
                    li.locales = TwLocales;
                    break;
                default:
                    baseurl = "http://us.battle.net";
                    li.locales = UsLocales;
                    break;
            }
            locale = null;
            AssembleUrl();
            return li;
        }

        public void SetLocale(string selection)
        {
            if (selection != "")
            {
                locale = "?locale=" + selection;
            }
            else
            {
                locale = null;
            }
            AssembleUrl();
        }
        #endregion

        public void SetItemType(RadioButton rb)
        {
            if (rb.Checked)
            {
                itemtype = rb.Text;
            }
            AssembleUrl();
        }

        public int SetItemId(string id)
        {
            int i = 0;
            
            if (id.Length > 0)
            {
                try
                {
                    Convert.ToInt64(id);
                }
                catch
                {
                    //MessageBox.Show("Invalid entry. Must be a whole number. Re-enter value. " + IdField.Text.Length.ToString(), "Fail");
                    id = new String(id.Where(c => c >= '0' && c <= '9').ToArray());
                    i = 1;
                    itemid = id;
                    return i;
                    //IdField.SelectionStart = IdField.TextLength;
                }
            }
            else
            {
                id = "0";
            }
            itemid = id;
            AssembleUrl();
            return i;
        }

        public string MakeRequest()
        {
            string output;
            AssembleUrl();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(assembledurl);
            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception m)
            {
                output = Environment.NewLine + m.ToString();
                return output;
            }


            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();

                ItemJson jsonresult = JsonConvert.DeserializeObject<ItemJson>(result);
                output = JsonConvert.SerializeObject(jsonresult, Formatting.Indented);
                

                // Still here because there's some stuff about this API that is not accounted for in 
                //output = Environment.NewLine + result;
                return output;

            }
        }

        #region LocaleSets
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

        private string[] regions = new string[] {
            "US",
            "EU"
        };
        #endregion

    }

    // Data package for Region and Locale portions of url construction
    public class LocaleInfo
    {
        //public string baseurl { get; set; }
        public string[] locales { get; set; }
    }

    // Regions class
    public class Regions
    {
        public string[] regions = { "US", "Europe" };
    }
}
