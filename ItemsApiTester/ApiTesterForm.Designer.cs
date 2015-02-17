namespace ItemsApiTester
{
    partial class ApiTesterForm
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
            this.components = new System.ComponentModel.Container();
            this.EntryFieldLabel = new System.Windows.Forms.Label();
            this.ItemRadio = new System.Windows.Forms.RadioButton();
            this.ItemSetRadio = new System.Windows.Forms.RadioButton();
            this.ExecuteRequest = new System.Windows.Forms.Button();
            this.UrlSuffixSelection = new System.Windows.Forms.Panel();
            this.RegionSelector = new System.Windows.Forms.ComboBox();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestControllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RegionLabel = new System.Windows.Forms.Label();
            this.LocaleSelector = new System.Windows.Forms.ComboBox();
            this.LocaleSelectorLabel = new System.Windows.Forms.Label();
            this.JsonOutput = new System.Windows.Forms.TextBox();
            this.IdField = new System.Windows.Forms.TextBox();
            this.requestControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UrlSuffixSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestControllerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EntryFieldLabel
            // 
            this.EntryFieldLabel.AutoSize = true;
            this.EntryFieldLabel.Location = new System.Drawing.Point(12, 43);
            this.EntryFieldLabel.Name = "EntryFieldLabel";
            this.EntryFieldLabel.Size = new System.Drawing.Size(151, 13);
            this.EntryFieldLabel.TabIndex = 1;
            this.EntryFieldLabel.Text = "Enter the Item (Group) ID Here";
            // 
            // ItemRadio
            // 
            this.ItemRadio.AutoSize = true;
            this.ItemRadio.Checked = true;
            this.ItemRadio.Location = new System.Drawing.Point(3, 3);
            this.ItemRadio.Name = "ItemRadio";
            this.ItemRadio.Size = new System.Drawing.Size(44, 17);
            this.ItemRadio.TabIndex = 2;
            this.ItemRadio.TabStop = true;
            this.ItemRadio.Tag = "item/";
            this.ItemRadio.Text = "item";
            this.ItemRadio.UseVisualStyleBackColor = true;
            this.ItemRadio.CheckedChanged += new System.EventHandler(this.itemRadio_CheckedChanged);
            this.ItemRadio.Click += new System.EventHandler(this.itemRadio_CheckedChanged);
            // 
            // ItemSetRadio
            // 
            this.ItemSetRadio.AutoSize = true;
            this.ItemSetRadio.Location = new System.Drawing.Point(54, 3);
            this.ItemSetRadio.Name = "ItemSetRadio";
            this.ItemSetRadio.Size = new System.Drawing.Size(63, 17);
            this.ItemSetRadio.TabIndex = 3;
            this.ItemSetRadio.Tag = "item/set/";
            this.ItemSetRadio.Text = "item/set";
            this.ItemSetRadio.UseVisualStyleBackColor = true;
            this.ItemSetRadio.CheckedChanged += new System.EventHandler(this.itemRadio_CheckedChanged);
            // 
            // ExecuteRequest
            // 
            this.ExecuteRequest.Location = new System.Drawing.Point(367, 12);
            this.ExecuteRequest.Name = "ExecuteRequest";
            this.ExecuteRequest.Size = new System.Drawing.Size(125, 23);
            this.ExecuteRequest.TabIndex = 4;
            this.ExecuteRequest.Text = "Make Request";
            this.ExecuteRequest.UseVisualStyleBackColor = true;
            this.ExecuteRequest.Click += new System.EventHandler(this.Request_Click);
            // 
            // UrlSuffixSelection
            // 
            this.UrlSuffixSelection.Controls.Add(this.ItemRadio);
            this.UrlSuffixSelection.Controls.Add(this.ItemSetRadio);
            this.UrlSuffixSelection.Location = new System.Drawing.Point(15, 12);
            this.UrlSuffixSelection.Name = "UrlSuffixSelection";
            this.UrlSuffixSelection.Size = new System.Drawing.Size(148, 23);
            this.UrlSuffixSelection.TabIndex = 6;
            // 
            // RegionSelector
            // 
            this.RegionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionSelector.FormattingEnabled = true;
            this.RegionSelector.Items.AddRange(new object[] {
            "US",
            "Europe",
            "Korea",
            "China",
            "Taiwan"});
            this.RegionSelector.Location = new System.Drawing.Point(186, 59);
            this.RegionSelector.Name = "RegionSelector";
            this.RegionSelector.Size = new System.Drawing.Size(121, 21);
            this.RegionSelector.TabIndex = 7;
            this.RegionSelector.SelectedIndexChanged += new System.EventHandler(this.RegionSelector_SelectedIndexChanged);
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataSource = typeof(ItemsApiTester.Regions);
            // 
            // requestControllerBindingSource1
            // 
            this.requestControllerBindingSource1.DataSource = typeof(ItemsApiTester.RequestController);
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(183, 43);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(80, 13);
            this.RegionLabel.TabIndex = 8;
            this.RegionLabel.Text = "Choose Region";
            // 
            // LocaleSelector
            // 
            this.LocaleSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocaleSelector.FormattingEnabled = true;
            this.LocaleSelector.Location = new System.Drawing.Point(367, 59);
            this.LocaleSelector.Name = "LocaleSelector";
            this.LocaleSelector.Size = new System.Drawing.Size(121, 21);
            this.LocaleSelector.TabIndex = 10;
            this.LocaleSelector.SelectedIndexChanged += new System.EventHandler(this.LocaleSelector_SelectedIndexChanged);
            // 
            // LocaleSelectorLabel
            // 
            this.LocaleSelectorLabel.AutoSize = true;
            this.LocaleSelectorLabel.Location = new System.Drawing.Point(367, 42);
            this.LocaleSelectorLabel.Name = "LocaleSelectorLabel";
            this.LocaleSelectorLabel.Size = new System.Drawing.Size(78, 13);
            this.LocaleSelectorLabel.TabIndex = 11;
            this.LocaleSelectorLabel.Text = "Choose Locale";
            // 
            // JsonOutput
            // 
            this.JsonOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JsonOutput.Location = new System.Drawing.Point(15, 126);
            this.JsonOutput.Multiline = true;
            this.JsonOutput.Name = "JsonOutput";
            this.JsonOutput.ReadOnly = true;
            this.JsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JsonOutput.Size = new System.Drawing.Size(473, 451);
            this.JsonOutput.TabIndex = 12;
            this.JsonOutput.Text = "URL to Hit:";
            // 
            // IdField
            // 
            this.IdField.AcceptsReturn = true;
            this.IdField.Location = new System.Drawing.Point(15, 59);
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(100, 20);
            this.IdField.TabIndex = 13;
            this.IdField.TextChanged += new System.EventHandler(this.IdField_TextChanged);
            this.IdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdField_KeyPress);
            // 
            // requestControllerBindingSource
            // 
            this.requestControllerBindingSource.DataSource = typeof(ItemsApiTester.RequestController);
            // 
            // ApiTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 589);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.JsonOutput);
            this.Controls.Add(this.LocaleSelectorLabel);
            this.Controls.Add(this.LocaleSelector);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.RegionSelector);
            this.Controls.Add(this.UrlSuffixSelection);
            this.Controls.Add(this.ExecuteRequest);
            this.Controls.Add(this.EntryFieldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApiTesterForm";
            this.Text = "WoW Item API Tester";
            this.UrlSuffixSelection.ResumeLayout(false);
            this.UrlSuffixSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestControllerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EntryFieldLabel;
        private System.Windows.Forms.RadioButton ItemRadio;
        private System.Windows.Forms.RadioButton ItemSetRadio;
        private System.Windows.Forms.Button ExecuteRequest;
        private System.Windows.Forms.Panel UrlSuffixSelection;
        private System.Windows.Forms.ComboBox RegionSelector;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.ComboBox LocaleSelector;
        private System.Windows.Forms.Label LocaleSelectorLabel;
        private System.Windows.Forms.TextBox JsonOutput;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.BindingSource requestControllerBindingSource1;
        private System.Windows.Forms.BindingSource requestControllerBindingSource;
        private System.Windows.Forms.BindingSource regionsBindingSource;
    }
}

