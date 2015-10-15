using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Management;

namespace InviaStampante
{
    public partial class frmStampa : Form
    {
		
        private string nomeStampante;
        private bool defaultNetwork = false;

        public frmStampa()
        {
            InitializeComponent();

			// FINO AL CARICAMENTO DELLA LISTA STAMPANTI - DISABILITA IL TASTO STAMPA
			btStampa.Enabled = false;

			// CARICA LA LISTA STAMPANTI
            CaricaStampanti();

            if (defaultNetwork)
                rdStampantiRete.Checked = true;
            else
                rdStampantiLocali.Checked = true;
        }

		private void CaricaStampanti()
        {
			// PULISCE I COMBOBOX
			cbStampantiRete.Items.Clear();
			cbStampantiLocali.Items.Clear();

            // PER AVERE LA LISTA STAMPANTI -> ObjectQuery
            System.Management.ObjectQuery oquery = new System.Management.ObjectQuery("SELECT * FROM Win32_Printer");
            System.Management.ManagementObjectSearcher mosearcher = new System.Management.ManagementObjectSearcher(oquery);
            System.Management.ManagementObjectCollection moc = mosearcher.Get();

			// SE ALMENO UNA STAMPANTE ALLORA ATTIVO LA POSSIBILITA' DI STAMPARE
			if (moc != null && moc.Count > 0)
			{
				// PER OGNI STAMPANTE
				foreach (ManagementObject mo in moc)
				{
                    bool network = false;
                    string[] ipAddress = mo["PortName"].ToString().Split('.');

					// SE E' UNA STAMPANTE DI RETE
                    if (mo["PortName"] != null && ipAddress.Length == 4)
					{
						cbStampantiRete.Items.Add(mo["Name"].ToString());
                        network = true;
					}
					// SE E' UNA STAMPANTE LOCALE
					else
					{
						cbStampantiLocali.Items.Add(mo["Name"].ToString());
					}

					// SE CE N'E' UNA DI DEFAULT -> SELEZIONALA
					if ((bool)mo["Default"])
					{
                        if (network) {
                            cbStampantiRete.SelectedItem = mo["Name"].ToString();
                            defaultNetwork = true;
                        }
                        else {
						    cbStampantiLocali.SelectedItem = mo["Name"].ToString();
                            defaultNetwork = false;
                        }

                        lbNomeValue.Text = mo["Name"].ToString();
                        lbPortaValue.Text = mo["PortName"].ToString();
                        lbDriverValue.Text = mo["DriverName"].ToString();
                        lbDeviceIDValue.Text = mo["DeviceID"].ToString();
                        lbSharedValue.Text = mo["Shared"].ToString();
					}
				}

				// ATTIVA IL TASTO STAMPA
				btStampa.Enabled = true;
			}
        }

		private void btStampa_Click(object sender, EventArgs e)
        {
			// SE IL RADIOBUTTON E' SU LOCAL USA QUELLA STAMPANTE SELEZIONATA
            if (rdStampantiLocali.Checked)
                nomeStampante = cbStampantiLocali.SelectedItem.ToString();
			// ALTRIMENTI USA QUELLA DI RETE
            else
                nomeStampante = cbStampantiRete.SelectedItem.ToString();

            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = nomeStampante;

			// SE E' VALIDA -> STAMPA
            if (printerSettings.IsValid)
            {
                printDoc.PrinterSettings = printerSettings;

				// PROVIAMO A STAMPARE
				try
				{
					printDoc.Print();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
        }

        private void StampaPagina(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
			// TESTO DI ESEMPIO
            using (Graphics g = e.Graphics)
            {
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;

				using (Font font1 = new Font("Arial", 14),
                            font2 = new Font("Arial", 11))
				{
					RectangleF rectF1 = new RectangleF(20, 90, 160, 25);
					e.Graphics.DrawRectangle(Pens.White, Rectangle.Round(rectF1));
					g.DrawString("Esempio", font1, Brushes.Black, rectF1, stringFormat);

                    RectangleF rectF2 = new RectangleF(20, 130, 160, 15);
                    e.Graphics.DrawRectangle(Pens.Red, Rectangle.Round(rectF2));

                    g.DrawString("Testo", font2, Brushes.Black, rectF2, stringFormat);
				}
            }
        }

		private void rdStampantiLocali_CheckedChanged(object sender, EventArgs e)
        {
			// SE IL CHECKBOX E' ATTIVATO
            // DESELEZIONE LE STAMPANTI DI RETE
            if (rdStampantiLocali.Checked)
            {
                rdStampantiRete.Checked = false;
                cbStampantiRete.Enabled = false;
                cbStampantiLocali.Enabled = true;
            }
            else
            {
                rdStampantiRete.Checked = true;
                cbStampantiRete.Enabled = true;
                cbStampantiLocali.Enabled = false;
            }
        }

        private void rdStampantiRete_CheckedChanged(object sender, EventArgs e)
        {
			// SE IL CHECKBOX E' ATTIVO
            // DESELEZIONE LE STAMPANTI LOCALI
            if (rdStampantiRete.Checked)
            {
                rdStampantiLocali.Checked = false;
                cbStampantiRete.Enabled = true;
                cbStampantiLocali.Enabled = false;
            }
            else
            {
                rdStampantiLocali.Checked = true;
                cbStampantiRete.Enabled = false;
                cbStampantiLocali.Enabled = true;
            }
        }

		private void btEsci_Click(object sender, EventArgs e)
        {
			Environment.Exit(0);
        }

		private void btAggiorna_Click(object sender, EventArgs e)
        {
            // MENTRE AGGIORNO DISABILITO IL TASTO STAMPA
            btStampa.Enabled = false;
            
            // RICARICA LE STAMPANTI
            CaricaStampanti();

            if (defaultNetwork)
                rdStampantiRete.Checked = true;
            else
                rdStampantiLocali.Checked = true;

            // RIABILITO IL TASTO STAMPA
            btStampa.Enabled = true;
        }

        private void cboLocalPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNomeValue.Text = "";
            lbPortaValue.Text = "";
            lbDriverValue.Text = "";
            lbDeviceIDValue.Text = "";
            lbSharedValue.Text = "";

            System.Management.ObjectQuery oquery = new System.Management.ObjectQuery("SELECT * FROM Win32_Printer WHERE Name = '" + ((String)cbStampantiLocali.SelectedItem).Replace("\\", "\\\\") + "'");
            System.Management.ManagementObjectSearcher mosearcher = new System.Management.ManagementObjectSearcher(oquery);
            System.Management.ManagementObjectCollection moc = mosearcher.Get();

            foreach (ManagementObject mo in moc)
            {
                lbNomeValue.Text = mo["Name"].ToString();
                lbPortaValue.Text = mo["PortName"].ToString();
                lbDriverValue.Text = mo["DriverName"].ToString();
                lbDeviceIDValue.Text = mo["DeviceID"].ToString();
                lbSharedValue.Text = mo["Shared"].ToString();
            }
        }
    }
}
