using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doolaeghe_ipcalcv4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int i;

            InitializeComponent();

            for(i = 0; i < 33; i++)
                comboBoxMasque.Items.Add(i);

            comboBoxMasque.SelectedIndex = 24;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int octet1, octet2, octet3, octet4;
            String masqueStr = comboBoxMasque.SelectedItem.ToString();

            int ip = 0;
            int masque = 0;

            int adresseReseau;
            int adresseBroadcast;

            String adresseReseauStr;
            String adresseBroadcastStr;

            int i;

            //-----------------------

            octet1 = Convert.ToInt32(textBoxIP1.Text) << 24;
            octet2 = Convert.ToInt32(textBoxIP2.Text) << 16;
            octet3 = Convert.ToInt32(textBoxIP3.Text) << 8;
            octet4 = Convert.ToInt32(textBoxIP4.Text);

            //-----------------------

            ip = octet1 | octet2 | octet3 | octet4;

            for (i = 0; i < Convert.ToInt32(masqueStr) ; i++)
                masque |= 1 << (31 - i);

            //MessageBox.Show(ip.ToString() + " | " + masque.ToString());

            //-----------------------

            adresseReseau = ip & masque;

            adresseBroadcast = ip | (~masque);
            
            //-----------------------

            octet1 = 0;
            octet2 = 0;
            octet3 = 0;
            octet4 = 0;

            for (i = 0; i < 8; i++)
            {
                octet1 |= ((adresseReseau >> i + 24) & 1) << i;
                octet2 |= ((adresseReseau >> i + 16) & 1) << i;
                octet3 |= ((adresseReseau >> i + 8) & 1) << i;
                octet4 |= ((adresseReseau >> i) & 1) << i;
            }

            adresseReseauStr = octet1.ToString() + "." + octet2.ToString() + "." + octet3.ToString() + "." + octet4.ToString();

            octet1 = 0;
            octet2 = 0;
            octet3 = 0;
            octet4 = 0;

            for (i = 0; i < 8; i++)
            {
                octet1 |= ((adresseBroadcast >> i + 24) & 1) << i;
                octet2 |= ((adresseBroadcast >> i + 16) & 1) << i;
                octet3 |= ((adresseBroadcast >> i + 8) & 1) << i;
                octet4 |= ((adresseBroadcast >> i) & 1) << i;
            }

            adresseBroadcastStr = octet1.ToString() + "." + octet2.ToString() + "." + octet3.ToString() + "." + octet4.ToString();

            //-----------------------

            labelAdresseReseau.Text = adresseReseauStr;
            labelBroadcast.Text = adresseBroadcastStr;
        }
    }
}
