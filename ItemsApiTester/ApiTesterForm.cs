using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsApiTester
{
    public partial class ApiTesterForm : Form
    {
        public ApiTesterForm()
        {
            InitializeComponent();
            
            /* These default settings now blow up after abstracting all methods to a separate controller. Don't know what's up.
            RegionSelector.Text = "US";
            JsonOutput.Text = controller.AssembleUrl(); */
        }

        public RequestController controller;
        private string itemid;


        #region ItemTypeControl
        private void itemRadio_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetItemType((RadioButton)sender);
            JsonOutput.Text = controller.assembledurl;
            JsonOutput.Update();            
        }
        #endregion

        #region LocaleControl
        

        private void LocaleSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetLocale(LocaleSelector.Text);
            JsonOutput.Text = controller.assembledurl;
        }
        #endregion

        #region RegionControl
        private void RegionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocaleInfo localeData = controller.SetRegionLocaleContext(RegionSelector.Text);
            LocaleSelector.Items.Clear();
            LocaleSelector.Items.AddRange(localeData.locales);
            JsonOutput.Text = controller.assembledurl;
        }
        #endregion

        #region ItemIdControl
        private void IdField_Click(object sender, EventArgs e)
        {
            IdField.SelectAll();
        }

        private void IdField_TextChanged(object sender, EventArgs e)
        {
            int check = controller.SetItemId(IdField.Text);
            if (check != 0)
            {
                IdField.Text = controller.itemid;
                IdField.SelectionStart = IdField.TextLength;
            }
            JsonOutput.Text = controller.assembledurl;
        }
        #endregion
        
        // Sets off API call
        private void Request_Click(object sender, EventArgs e)
        {
            StartRequest();            
        }

        private void IdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                StartRequest();
            }
        }

        private void StartRequest()
        {
            string returnedData = controller.MakeRequest();
            JsonOutput.AppendText(Environment.NewLine + returnedData);
        }
    }
}
