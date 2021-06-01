using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using appgestiopersonnelsoma.controleur;
using appgestiopersonnelsoma.modele;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appgestiopersonnelsoma.vue
{
    public partial class responsablegestioper : Form
    {
        private classControl controle;
        private Boolean modification = false;
        BindingSource bdgpersonnels= new BindingSource();
        BindingSource bdgabsences= new BindingSource();

        public responsablegestioper(classControl controle)
        {
            InitializeComponent();
            this.controle = controle;
            remplirpersonnels();
            remplirabsences();


        }
        public void remplirpersonnels()
        {
            List<classPersonnels> lesPersonnels = controle.GetPersonnels();
           // MessageBox.Show("Taille : "+lesPersonnels.Count);
            bdgpersonnels.DataSource = lesPersonnels;
            dataGridViewpersonnel.DataSource = bdgpersonnels;
            dataGridViewpersonnel.Columns["idpersonnel"].Visible = false;
            dataGridViewpersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void remplirabsences()
        {
            List<classAbsences> lesAbsences = controle.GetAbsences();
           // MessageBox.Show("Taille : " + lesAbsences.Count);
            bdgabsences.DataSource = lesAbsences ;
            dataGridViewabsence.DataSource = bdgabsences;
            dataGridViewabsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void btnajouterpersonnel_Click(object sender, EventArgs e)
        {

        }

        private void btnmodifierpersonnel_Click(object sender, EventArgs e)
        {
            if (dataGridViewpersonnel.SelectedRows.Count > 0)
            {
                modification= true;
               
                classPersonnels personnel = (classPersonnels)bdgpersonnels.List[bdgpersonnels.Position];
                textBoxnompers.Text = personnel.Nom;
                textBoxprenompers.Text = personnel.Prenom;
                textBoxtelpers.Text = personnel.Tel;
                textBoxmailpers.Text = personnel.Mail;
                comboBoxservice.SelectedIndex = comboBoxservice.FindStringExact(personnel.Idservice+"");
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnmodifabsence_Click(object sender, EventArgs e)
        {
            if (dataGridViewabsence.SelectedRows.Count > 0)
            {
                 
                modification = true;
                
                classAbsences absence = (classAbsences)bdgabsences.List[bdgabsences.Position];
               
                textBoxdatedeb.Text = absence.Datedebut;
                textBoxdatefin.Text = absence.Datefin;
            //    comboBoxmotif.SelectedIndex = comboBoxmotif.FindStringExact(absence, idmotif);//???
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

        private void btnenregistrerpersonnel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnenregisabsence_Click(object sender, EventArgs e)
        {
           
        }

        private void btnannulerpersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxprenompers.Text = "";
                textBoxnompers.Text = "";
                textBoxmailpers.Text = "";
                textBoxtelpers.Text = "";

                comboBoxservice.SelectedIndex = 0;

                modification = false;

            }
        }

        private void btnannulerabsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                textBoxdatefin.Text = "";
                textBoxdatedeb.Text = "";
                
                comboBoxmotif.SelectedIndex = 0;

                modification = false;
                
            }
        }

        private void btnsupprimerpersonnel_Click(object sender, EventArgs e)
        {
            if (dataGridViewpersonnel.SelectedRows.Count > 0)
            {
                classPersonnels personnel = (classPersonnels)bdgpersonnels.List[bdgpersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnels(personnel);
                    remplirpersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnsupprabsence_Click(object sender, EventArgs e)
        {
            if (dataGridViewpersonnel.SelectedRows.Count > 0)
            {
                classAbsences absence = (classAbsences)bdgabsences.List[bdgabsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.Datedebut + " " + absence.Idmotif + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsences(absence);
                    remplirabsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
