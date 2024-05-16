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
                int selectedStudentId = Convert.ToInt32(dataetudiant.SelectedRows[0].Cells["id"].Value);
                Etudiant etudiantAModifier = context.Etudiant.Find(selectedStudentId);

                if (etudiantAModifier != null)
                {
                    // Mettre à jour les propriétés de l'étudiant avec les nouvelles valeurs des contrôles du formulaire
                    etudiantAModifier.prenom = txtprenom.Text;
                    etudiantAModifier.nom = txtnom.Text;

                    int reglement;
                    if (int.TryParse(txtreglement.Text, out reglement))
                    {
                        etudiantAModifier.reglement = reglement;
                    }
                    else
                    {
                        MessageBox.Show("Le montant du règlement n'est pas un nombre valide.");
                        return; // Sortir de la méthode si la conversion échoue
                    }

                    etudiantAModifier.annee = txtannee.Text;

                    int credit;
                    if (int.TryParse(txtcredit.Text, out credit))
                    {
                        etudiantAModifier.credit = credit;
                    }
                    else
                    {
                        MessageBox.Show("Le crédit n'est pas un nombre valide.");
                        return; // Sortir de la méthode si la conversion échoue
                    }

                    etudiantAModifier.idclasse = Convert.ToInt32(comboCLASSE.SelectedValue);
                    // Sauvegarder les modifications dans la base de données
                    context.SaveChanges();
                    // Actualiser la liste des étudiants affichée dans le DataGridView
                    dataetudiant.DataSource = context.Etudiant.ToList();
                    MessageBox.Show("Étudiant modifié avec succès...");
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
           // btnrecherhce_Click(sender, e);
        }

        private void dataetudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboCLASSE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
