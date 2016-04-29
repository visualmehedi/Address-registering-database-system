namespace Assignment6
{
    partial class ConReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConReg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lName = new System.Windows.Forms.TextBox();
            this._fName = new System.Windows.Forms.TextBox();
            this.labellName = new System.Windows.Forms.Label();
            this.labelfName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._country = new System.Windows.Forms.ComboBox();
            this._zipCode = new System.Windows.Forms.TextBox();
            this._city = new System.Windows.Forms.TextBox();
            this._street = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelRegCon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.listBoxConReg = new System.Windows.Forms.ListBox();
            this._NumofRegCon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this._lName);
            this.groupBox1.Controls.Add(this._fName);
            this.groupBox1.Controls.Add(this.labellName);
            this.groupBox1.Controls.Add(this.labelfName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(740, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // _lName
            // 
            this._lName.Location = new System.Drawing.Point(260, 148);
            this._lName.Margin = new System.Windows.Forms.Padding(6);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(432, 44);
            this._lName.TabIndex = 3;
            // 
            // _fName
            // 
            this._fName.Location = new System.Drawing.Point(260, 58);
            this._fName.Margin = new System.Windows.Forms.Padding(6);
            this._fName.Name = "_fName";
            this._fName.Size = new System.Drawing.Size(432, 44);
            this._fName.TabIndex = 2;
            // 
            // labellName
            // 
            this.labellName.AutoSize = true;
            this.labellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellName.Location = new System.Drawing.Point(46, 160);
            this.labellName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labellName.Name = "labellName";
            this.labellName.Size = new System.Drawing.Size(145, 31);
            this.labellName.TabIndex = 1;
            this.labellName.Text = "Last Name";
            // 
            // labelfName
            // 
            this.labelfName.AutoSize = true;
            this.labelfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfName.Location = new System.Drawing.Point(46, 69);
            this.labelfName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelfName.Name = "labelfName";
            this.labelfName.Size = new System.Drawing.Size(147, 31);
            this.labelfName.TabIndex = 0;
            this.labelfName.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this._country);
            this.groupBox2.Controls.Add(this._zipCode);
            this.groupBox2.Controls.Add(this._city);
            this.groupBox2.Controls.Add(this._street);
            this.groupBox2.Controls.Add(this.labelCountry);
            this.groupBox2.Controls.Add(this.labelZip);
            this.groupBox2.Controls.Add(this.labelCity);
            this.groupBox2.Controls.Add(this.labelStreet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(740, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // _country
            // 
            this._country.FormattingEnabled = true;
            this._country.Location = new System.Drawing.Point(260, 313);
            this._country.Margin = new System.Windows.Forms.Padding(6);
            this._country.Name = "_country";
            this._country.Size = new System.Drawing.Size(432, 45);
            this._country.TabIndex = 8;
            // 
            // _zipCode
            // 
            this._zipCode.Location = new System.Drawing.Point(260, 235);
            this._zipCode.Margin = new System.Windows.Forms.Padding(6);
            this._zipCode.Name = "_zipCode";
            this._zipCode.Size = new System.Drawing.Size(432, 44);
            this._zipCode.TabIndex = 7;
            // 
            // _city
            // 
            this._city.Location = new System.Drawing.Point(260, 150);
            this._city.Margin = new System.Windows.Forms.Padding(6);
            this._city.Name = "_city";
            this._city.Size = new System.Drawing.Size(432, 44);
            this._city.TabIndex = 6;
            // 
            // _street
            // 
            this._street.Location = new System.Drawing.Point(260, 65);
            this._street.Margin = new System.Windows.Forms.Padding(6);
            this._street.Name = "_street";
            this._street.Size = new System.Drawing.Size(432, 44);
            this._street.TabIndex = 5;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(46, 325);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(110, 31);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "Country";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(46, 246);
            this.labelZip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(124, 31);
            this.labelZip.TabIndex = 3;
            this.labelZip.Text = "Zip Code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(46, 162);
            this.labelCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(62, 31);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(46, 77);
            this.labelStreet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(87, 31);
            this.labelStreet.TabIndex = 1;
            this.labelStreet.Text = "Street";
            // 
            // labelRegCon
            // 
            this.labelRegCon.AutoSize = true;
            this.labelRegCon.Location = new System.Drawing.Point(854, 654);
            this.labelRegCon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegCon.Name = "labelRegCon";
            this.labelRegCon.Size = new System.Drawing.Size(243, 25);
            this.labelRegCon.TabIndex = 2;
            this.labelRegCon.Text = "No of registered records";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(944, 92);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 83);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(944, 333);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 85);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(944, 206);
            this.btnChange.Margin = new System.Windows.Forms.Padding(6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(202, 90);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listBoxConReg
            // 
            this.listBoxConReg.FormattingEnabled = true;
            this.listBoxConReg.ItemHeight = 25;
            this.listBoxConReg.Location = new System.Drawing.Point(24, 708);
            this.listBoxConReg.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxConReg.Name = "listBoxConReg";
            this.listBoxConReg.Size = new System.Drawing.Size(1154, 379);
            this.listBoxConReg.TabIndex = 6;
            // 
            // _NumofRegCon
            // 
            this._NumofRegCon.Enabled = false;
            this._NumofRegCon.Location = new System.Drawing.Point(1106, 648);
            this._NumofRegCon.Margin = new System.Windows.Forms.Padding(6);
            this._NumofRegCon.Name = "_NumofRegCon";
            this._NumofRegCon.Size = new System.Drawing.Size(72, 31);
            this._NumofRegCon.TabIndex = 7;
            // 
            // ConReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 1104);
            this.Controls.Add(this._NumofRegCon);
            this.Controls.Add(this.listBoxConReg);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelRegCon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ConReg";
            this.Text = "Contact Registry";
            this.Load += new System.EventHandler(this.ConReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _lName;
        private System.Windows.Forms.TextBox _fName;
        private System.Windows.Forms.Label labellName;
        private System.Windows.Forms.Label labelfName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _city;
        private System.Windows.Forms.TextBox _street;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelRegCon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox listBoxConReg;
        private System.Windows.Forms.TextBox _NumofRegCon;
        private System.Windows.Forms.ComboBox _country;
        private System.Windows.Forms.TextBox _zipCode;
    }
}

