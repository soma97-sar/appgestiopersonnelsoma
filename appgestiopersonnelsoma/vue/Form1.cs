using System;
using System.Collections.Generic;
using System.ComponentModel;
using appgestiopersonnelsoma.vue;
using appgestiopersonnelsoma.controleur;
using appgestiopersonnelsoma.connexion;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appgestiopersonnelsoma
{
    public partial class appgestio : Form

    {
        private classControl controle;
        /// <summary>
        /// appgestio
        /// </summary>
        public appgestio()
        {
            InitializeComponent();
            controle = new classControl();
        }
        /// <summary>
        /// controle
        /// </summary>
        /// <param name="controle"></param>
        public appgestio(classControl controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //if (!classControl.ValidateLogin(textBoxlogin.Text, textBoxpwd.Text))
            if(classControl.ValidateLogin(textBoxlogin.Text, textBoxpwd.Text))
            
            {
                MessageBox.Show("erreur!!!");
                textBoxlogin.Text = "";
                textBoxpwd.Text = "";

            }
            else
            {
                responsablegestioper resp1 = new responsablegestioper(this.controle);
                resp1.Show();
                this.Hide();

            }
        }
    }
}
