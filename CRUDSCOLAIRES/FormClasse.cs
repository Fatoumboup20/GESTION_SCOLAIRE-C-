using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSCOLAIRES
{
    public partial class FormClasse : Form
    {
        Gestion_EcoleEntities2 context = new Gestion_EcoleEntities2();

        public FormClasse()
        {
            InitializeComponent();
            dataclasse.DataSource = context.Classe.ToList();
            dataclasse.CellDoubleClick += dataclasse_CellDoubleClick;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void comboniveau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combospecialite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclasse_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.libelle = comboniveau.Text + combospecialite.Text;
            c.specilaite = combospecialite.Text;
            c.niveau = comboniveau.Text;
            context.Classe.Add(c);
            context.SaveChanges();
            MessageBox.Show("Classe Enregistrée");
            dataclasse.DataSource = context.Classe.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataclasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataclasse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int classeID = Convert.ToInt32(dataclasse.Rows[e.RowIndex].Cells["id"].Value);
                AfficherDetailsClasse(classeID);
            }
        }

        private void AfficherDetailsClasse(int classeID)
        {
            Classe classe = context.Classe.FirstOrDefault(x => x.id == classeID);

            if (classe != null)
            {
                comboniveau.Text = classe.niveau;
                combospecialite.Text = classe.specilaite;
                
            }
            else
            {
                MessageBox.Show("La classe sélectionnée n'existe pas dans la base de données.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez si une ligne est sélectionnée dans le dataGridView
            if (dataclasse.SelectedRows.Count > 0)
            {
                int selectedIndex = dataclasse.SelectedRows[0].Index;
                int classeID = Convert.ToInt32(dataclasse.Rows[selectedIndex].Cells["id"].Value);

                Classe classe = context.Classe.FirstOrDefault(x => x.id == classeID);

                if (classe != null)
                {
                    // Mettez à jour les propriétés de l'objet Classe avec les nouvelles valeurs des contrôles
                    classe.niveau = comboniveau.Text;
                    classe.specilaite = combospecialite.Text;
                    classe.libelle = comboniveau.Text + combospecialite.Text;
                    // Autres champs...

                    try
                    {
                        // Sauvegardez les modifications dans la base de données
                        context.SaveChanges();
                        MessageBox.Show("Modification réussie...");
                        dataclasse.DataSource = context.Classe.ToList(); 

                        // Réinitialisez le texte du bouton pour revenir à l'état d'ajout
                        btnclasse.Text = "Enregistrer";


                    }
                    catch (DbEntityValidationException ex)
                    {
                        // Récupérez les erreurs de validation
                        var validationErrors = ex.EntityValidationErrors.SelectMany(error => error.ValidationErrors);

                        // Générez un message d'erreur contenant les détails des erreurs de validation
                        StringBuilder errorMessage = new StringBuilder();
                        errorMessage.AppendLine("Erreur lors de la validation des données :");
                        foreach (var validationError in validationErrors)
                        {
                            errorMessage.AppendLine($"- {validationError.PropertyName}: {validationError.ErrorMessage}");
                        }

                        MessageBox.Show(errorMessage.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("La classe sélectionnée n'existe pas dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier.");
            }
        }
        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (dataclasse.SelectedRows.Count > 0)
            {
                int selectedIndex = dataclasse.SelectedRows[0].Index;
                int classeID = Convert.ToInt32(dataclasse.Rows[selectedIndex].Cells["id"].Value);

                Classe classe = context.Classe.FirstOrDefault(x => x.id == classeID);

                if (classe != null)
                {
                    if (classe.Etudiant.Any())
                    {
                        MessageBox.Show("Impossible de supprimer cette classe car elle est associée à des étudiants. Veuillez d'abord supprimer les étudiants de cette classe.");
                    }
                    else
                    {
                        context.Classe.Remove(classe);
                        context.SaveChanges();
                        MessageBox.Show("Suppression réussie...");
                        dataclasse.DataSource = context.Classe.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("La classe sélectionnée n'existe pas dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe à supprimer.");
            }
        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            comboniveau.Text = "";
            combospecialite.Text = "";
        }
    }
}
