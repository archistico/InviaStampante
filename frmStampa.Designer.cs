namespace InviaStampante
{
    partial class frmStampa
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.cbStampantiLocali = new System.Windows.Forms.ComboBox();
            this.btStampa = new System.Windows.Forms.Button();
            this.cbStampantiRete = new System.Windows.Forms.ComboBox();
            this.rdStampantiLocali = new System.Windows.Forms.RadioButton();
            this.rdStampantiRete = new System.Windows.Forms.RadioButton();
            this.btEsci = new System.Windows.Forms.Button();
            this.btAggiorna = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShared = new System.Windows.Forms.Label();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lbSharedValue = new System.Windows.Forms.Label();
            this.lbDeviceIDValue = new System.Windows.Forms.Label();
            this.lbDriverValue = new System.Windows.Forms.Label();
            this.lbPortaValue = new System.Windows.Forms.Label();
            this.lbNomeValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(218, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Seleziona la stampante da utilizzare: ";
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.StampaPagina);
            // 
            // cbStampantiLocali
            // 
            this.cbStampantiLocali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStampantiLocali.FormattingEnabled = true;
            this.cbStampantiLocali.Location = new System.Drawing.Point(15, 59);
            this.cbStampantiLocali.Name = "cbStampantiLocali";
            this.cbStampantiLocali.Size = new System.Drawing.Size(335, 21);
            this.cbStampantiLocali.TabIndex = 1;
            this.cbStampantiLocali.SelectedIndexChanged += new System.EventHandler(this.cboLocalPrinters_SelectedIndexChanged);
            // 
            // btStampa
            // 
            this.btStampa.Location = new System.Drawing.Point(248, 323);
            this.btStampa.Name = "btStampa";
            this.btStampa.Size = new System.Drawing.Size(101, 37);
            this.btStampa.TabIndex = 2;
            this.btStampa.Text = "Stampa";
            this.btStampa.UseVisualStyleBackColor = true;
            this.btStampa.Click += new System.EventHandler(this.btStampa_Click);
            // 
            // cbStampantiRete
            // 
            this.cbStampantiRete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStampantiRete.FormattingEnabled = true;
            this.cbStampantiRete.Location = new System.Drawing.Point(15, 115);
            this.cbStampantiRete.Name = "cbStampantiRete";
            this.cbStampantiRete.Size = new System.Drawing.Size(335, 21);
            this.cbStampantiRete.TabIndex = 5;
            // 
            // rdStampantiLocali
            // 
            this.rdStampantiLocali.AutoSize = true;
            this.rdStampantiLocali.Location = new System.Drawing.Point(15, 36);
            this.rdStampantiLocali.Name = "rdStampantiLocali";
            this.rdStampantiLocali.Size = new System.Drawing.Size(107, 17);
            this.rdStampantiLocali.TabIndex = 6;
            this.rdStampantiLocali.TabStop = true;
            this.rdStampantiLocali.Text = "Stampante locale";
            this.rdStampantiLocali.UseVisualStyleBackColor = true;
            this.rdStampantiLocali.CheckedChanged += new System.EventHandler(this.rdStampantiLocali_CheckedChanged);
            // 
            // rdStampantiRete
            // 
            this.rdStampantiRete.AutoSize = true;
            this.rdStampantiRete.Location = new System.Drawing.Point(15, 92);
            this.rdStampantiRete.Name = "rdStampantiRete";
            this.rdStampantiRete.Size = new System.Drawing.Size(108, 17);
            this.rdStampantiRete.TabIndex = 7;
            this.rdStampantiRete.TabStop = true;
            this.rdStampantiRete.Text = "Stampante di rete";
            this.rdStampantiRete.UseVisualStyleBackColor = true;
            this.rdStampantiRete.CheckedChanged += new System.EventHandler(this.rdStampantiRete_CheckedChanged);
            // 
            // btEsci
            // 
            this.btEsci.Location = new System.Drawing.Point(15, 323);
            this.btEsci.Name = "btEsci";
            this.btEsci.Size = new System.Drawing.Size(101, 37);
            this.btEsci.TabIndex = 8;
            this.btEsci.Text = "Esci";
            this.btEsci.UseVisualStyleBackColor = true;
            this.btEsci.Click += new System.EventHandler(this.btEsci_Click);
            // 
            // btAggiorna
            // 
            this.btAggiorna.Location = new System.Drawing.Point(131, 323);
            this.btAggiorna.Name = "btAggiorna";
            this.btAggiorna.Size = new System.Drawing.Size(101, 37);
            this.btAggiorna.TabIndex = 9;
            this.btAggiorna.Text = "Aggiorna";
            this.btAggiorna.UseVisualStyleBackColor = true;
            this.btAggiorna.Click += new System.EventHandler(this.btAggiorna_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShared);
            this.groupBox1.Controls.Add(this.lblDeviceID);
            this.groupBox1.Controls.Add(this.lblDriver);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lbSharedValue);
            this.groupBox1.Controls.Add(this.lbDeviceIDValue);
            this.groupBox1.Controls.Add(this.lbDriverValue);
            this.groupBox1.Controls.Add(this.lbPortaValue);
            this.groupBox1.Controls.Add(this.lbNomeValue);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(15, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informazioni";
            // 
            // lblShared
            // 
            this.lblShared.AutoSize = true;
            this.lblShared.Location = new System.Drawing.Point(9, 118);
            this.lblShared.Name = "lblShared";
            this.lblShared.Size = new System.Drawing.Size(56, 13);
            this.lblShared.TabIndex = 1;
            this.lblShared.Text = "Condivisa:";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Location = new System.Drawing.Point(10, 96);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(55, 13);
            this.lblDeviceID.TabIndex = 1;
            this.lblDeviceID.Text = "DeviceID:";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(27, 72);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(38, 13);
            this.lblDriver.TabIndex = 1;
            this.lblDriver.Text = "Driver:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(30, 50);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Porta:";
            // 
            // lbSharedValue
            // 
            this.lbSharedValue.AutoSize = true;
            this.lbSharedValue.Location = new System.Drawing.Point(71, 118);
            this.lbSharedValue.Name = "lbSharedValue";
            this.lbSharedValue.Size = new System.Drawing.Size(157, 13);
            this.lbSharedValue.TabIndex = 0;
            this.lbSharedValue.Text = "Nessuna stampante selezionata";
            // 
            // lbDeviceIDValue
            // 
            this.lbDeviceIDValue.AutoSize = true;
            this.lbDeviceIDValue.Location = new System.Drawing.Point(71, 96);
            this.lbDeviceIDValue.Name = "lbDeviceIDValue";
            this.lbDeviceIDValue.Size = new System.Drawing.Size(157, 13);
            this.lbDeviceIDValue.TabIndex = 0;
            this.lbDeviceIDValue.Text = "Nessuna stampante selezionata";
            // 
            // lbDriverValue
            // 
            this.lbDriverValue.AutoSize = true;
            this.lbDriverValue.Location = new System.Drawing.Point(71, 72);
            this.lbDriverValue.Name = "lbDriverValue";
            this.lbDriverValue.Size = new System.Drawing.Size(157, 13);
            this.lbDriverValue.TabIndex = 0;
            this.lbDriverValue.Text = "Nessuna stampante selezionata";
            // 
            // lbPortaValue
            // 
            this.lbPortaValue.AutoSize = true;
            this.lbPortaValue.Location = new System.Drawing.Point(71, 50);
            this.lbPortaValue.Name = "lbPortaValue";
            this.lbPortaValue.Size = new System.Drawing.Size(157, 13);
            this.lbPortaValue.TabIndex = 0;
            this.lbPortaValue.Text = "Nessuna stampante selezionata";
            // 
            // lbNomeValue
            // 
            this.lbNomeValue.AutoSize = true;
            this.lbNomeValue.Location = new System.Drawing.Point(71, 29);
            this.lbNomeValue.Name = "lbNomeValue";
            this.lbNomeValue.Size = new System.Drawing.Size(157, 13);
            this.lbNomeValue.TabIndex = 0;
            this.lbNomeValue.Text = "Nessuna stampante selezionata";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // frmStampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAggiorna);
            this.Controls.Add(this.btEsci);
            this.Controls.Add(this.rdStampantiRete);
            this.Controls.Add(this.rdStampantiLocali);
            this.Controls.Add(this.cbStampantiRete);
            this.Controls.Add(this.btStampa);
            this.Controls.Add(this.cbStampantiLocali);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStampa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleziona la stampante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.ComboBox cbStampantiLocali;
        private System.Windows.Forms.Button btStampa;
        private System.Windows.Forms.ComboBox cbStampantiRete;
        private System.Windows.Forms.RadioButton rdStampantiLocali;
        private System.Windows.Forms.RadioButton rdStampantiRete;
        private System.Windows.Forms.Button btEsci;
        private System.Windows.Forms.Button btAggiorna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShared;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lbSharedValue;
        private System.Windows.Forms.Label lbDeviceIDValue;
        private System.Windows.Forms.Label lbDriverValue;
        private System.Windows.Forms.Label lbPortaValue;
        private System.Windows.Forms.Label lbNomeValue;
        private System.Windows.Forms.Label lblName;
    }
}

