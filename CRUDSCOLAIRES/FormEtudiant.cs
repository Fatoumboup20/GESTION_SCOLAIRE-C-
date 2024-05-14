using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace CRUDSCOLAIRES
{
    public partial class FormEtudiant : Form
    {
        Gestion_EcoleEntities2 context = new Gestion_EcoleEntities2();

        public FormEtudiant()
        {
            InitializeComponent();
            ChargerDonneesEtudiants();
        }

        private void ChargerDonneesEtudiants()
        {
            comboCLASSE.DataSource = context.Classe.ToList();
            comboCLASSE.DisplayMember = "libelle";
            comboCLASSE.ValueMember = "id";

            var etudiantsAvecClasse = context.Etudiant
                .Include(e => e.Classe)
                .ToList();

            var data = new List<object>();

            foreach (var etudiant in etudiantsAvecClasse)
            {
                var rowData = new
                {
                    etudiant.id,
                    etudiant.prenom,
                    etudiant.nom,
                    etudiant.credit,
                    etudiant.reglement,
                    etudiant.annee,
                    etudiant.idclasse,
                    ClasseLibelle = etudiant.Classe != null ? $"{etudiant.Classe.libelle}" : ""
                };

                data.Add(rowData);
            }

            dataetudiant.DataSource = data;
        }

        private void btnetudiant_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.prenom = txtprenom.Text;
            et.credit = int.Parse(txtcredit.Text);
            et.nom = txtnom.Text;
            et.reglement = int.Parse(txtreglement.Text);
            et.annee = txtannee.Text;
            et.idclasse = Convert.ToInt32(comboCLASSE.SelectedValue);
            context.Etudiant.Add(et);
            context.SaveChanges();
            MessageBox.Show("Etudiant Enregistrer ");
            ChargerDonneesEtudiants();
        }


        //modif

        private void btnmodif_Click(object sender, EventArgs e)
        {
            if (dataetudiant.SelectedRows.Count > 0)
            {
                int selectedIndex = dataetudiant.SelectedRows[0].Index;
                int etudiantID = Convert.ToInt32(dataetudiant.Rows[selectedIndex].Cells["id"].Value);

                Etudiant etudiant = context.Etudiant.FirstOrDefault(x => x.id == etudiantID);

                if (etudiant != null)
                {
                    // Récupérer les anciennes informations de l'étudiant
                    string ancienneAnnee = etudiant.annee;
                    string ancienNom = etudiant.nom;
                    int ancienCredit = (int)etudiant.credit;
                    int ancienReglement = (int)etudiant.reglement;
                    string ancienPrenom = etudiant.prenom;

                    // Effectuer les modifications si nécessaire
                    string nouvelleAnnee = txtannee.Text;
                    string nouveauNom = txtnom.Text;
                    int nouveauCredit;
                    int nouveauReglement;
                    string nouveauPrenom = txtprenom.Text;

                    if (int.TryParse(txtcredit.Text, out nouveauCredit) && int.TryParse(txtreglement.Text, out nouveauReglement))
                    {
                        if (ancienneAnnee != nouvelleAnnee || ancienNom != nouveauNom || ancienCredit != nouveauCredit || ancienReglement != nouveauReglement || ancienPrenom != nouveauPrenom)
                        {
                            try
                            {
                                etudiant.annee = nouvelleAnnee;
                                etudiant.nom = nouveauNom;
                                etudiant.credit = nouveauCredit;
                                etudiant.reglement = nouveauReglement;
                                etudiant.prenom = nouveauPrenom;

                                context.SaveChanges();
                                MessageBox.Show("Modification réussie...");
                                ChargerDonneesEtudiants();
                            }
                            catch (DbUpdateException ex)
                            {
                                MessageBox.Show("Erreur lors de l'enregistrement des modifications : " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune modification apportée.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur de conversion des données.");
                    }

                    // Afficher les nouvelles informations dans les contrôles
                    txtannee.Text = etudiant.annee;
                    txtnom.Text = etudiant.nom;
                    txtcredit.Text = etudiant.credit.ToString();
                    txtreglement.Text = etudiant.reglement.ToString();
                    txtprenom.Text = etudiant.prenom;

                    btnetudiant.Text = "Enregistrer";
                }
                else
                {
                    MessageBox.Show("L'étudiant sélectionné n'existe pas dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }
        private void btnefface_Click(object sender, EventArgs e)
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtreglement.Text = "";
            txtcredit.Text = "";
            txtannee.Text = "";
            comboCLASSE.Text = "";
            textBox1.Text = "";
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (dataetudiant.SelectedRows.Count > 0)
            {
                int selectedIndex = dataetudiant.SelectedRows[0].Index;
                int personneID = Convert.ToInt32(dataetudiant.Rows[selectedIndex].Cells["id"].Value);

                var context = new Gestion_EcoleEntities2();
                Etudiant etud = context.Etudiant.FirstOrDefault(x => x.id == personneID);

                if (etud != null)
                {
                    context.Etudiant.Remove(etud);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    ChargerDonneesEtudiants();
                }
                else
                {
                    MessageBox.Show("L'Etudiant sélectionnée n'existe pas dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }
        }

        private void btnrecherhce_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            string libelleClasse = comboCLASSE.Text.Trim();

            var etudiants = context.Etudiant.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                etudiants = etudiants.Where(etudiant => etudiant.annee.StartsWith(searchText));
            }

            if (!string.IsNullOrEmpty(libelleClasse))
            {
                etudiants = etudiants.Where(etudiant => etudiant.Classe.libelle.Contains(libelleClasse));
            }

            dataetudiant.DataSource = etudiants.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnrecherhce_Click(sender, e);
        }

        private void dataetudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ce gestionnaire d'événements peut être utilisé pour effectuer des actions lorsque le contenu d'une cellule est cliqué
            // Par exemple, vous pouvez afficher les détails de l'étudiant sélectionné dans d'autres contrôles
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
