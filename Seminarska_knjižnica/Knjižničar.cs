using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarska_knjižnica
{
    public partial class Knjižničar : Form
    {
        public Knjižničar()
        {
            InitializeComponent();
        }

        private void shrani_gmb_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                // Otvaranje veze
                con.Open();

                // SQL upit za umetanje podataka
                SqlCommand cnn = new SqlCommand("INSERT INTO Delavec (id_delavca, ime_delavca, naslov, datum_začetka_dela) VALUES (@id_delavca, @ime_delavca, @naslov, @datum_začetka_dela)", con);

                // Dodavanje vrednosti za parametre iz tekstualnih polja
                cnn.Parameters.AddWithValue("@id_delavca", int.Parse(id_text.Text));
                cnn.Parameters.AddWithValue("@ime_delavca", ime_text.Text);
                cnn.Parameters.AddWithValue("@naslov", enaslov_text.Text);

                // Validacija i parsiranje datuma
                DateTime datumVclanitve;
                if (DateTime.TryParse(datum_text.Text, out datumVclanitve))
                {
                    cnn.Parameters.AddWithValue("@datum_začetka_dela", datumVclanitve);
                }
                else
                {
                    // Prikazivanje poruke o grešci ako je datum neispravan
                    MessageBox.Show("Napačen format datuma. Prosimo vnesite datum v obliki yyyy-MM-dd.");
                    return;
                }

                // Izvršenje SQL upita
                cnn.ExecuteNonQuery();

                // Prikazivanje poruke o uspešnom unosu podataka
                MessageBox.Show("Podatki uspešno shranjeni.");
            }
            catch (Exception ex) // Hvatanje izuzetaka
            {
                // Prikazivanje poruke o grešci
                MessageBox.Show("Prišlo je do napake: " + ex.Message);
            }
            finally // Zatvaranje veze, čak i ako dođe do greške
            {
                con.Close();
            }
        }

        private void dodaj_gmb_Click(object sender, EventArgs e)
        {

            // Kreiranje veze sa bazom podataka
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                // Otvaranje veze
                con.Open();

                // Kreiranje SQL upita
                SqlCommand cnn = new SqlCommand("SELECT * FROM Delavec", con);

                // Kreiranje DataAdapter-a
                SqlDataAdapter da = new SqlDataAdapter(cnn);

                // Kreiranje DataTable-a za čuvanje podataka
                DataTable table = new DataTable();

                // Popunjavanje DataTable-a podacima iz baze
                da.Fill(table);

                // Postavljanje izvora podataka za DataGridView
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                // Obrada grešaka
                MessageBox.Show("Prišlo je do napake: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                // Zatvaranje veze sa bazom podataka
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void prikaži_gmb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                con.Open();
                MessageBox.Show("Povezava uspešno vzpostavljena.");

                SqlCommand cnn = new SqlCommand("SELECT * FROM Delavec", con);
                SqlDataAdapter da = new SqlDataAdapter(cnn);
                DataTable table = new DataTable();

                da.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL napaka: " + sqlEx.Message + "\n" + sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prišlo je do napake: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Povezava zaprta.");
            }
        }

        private void posodobi_gmb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                // Otvaranje veze
                con.Open();

                // SQL upit za umetanje podataka
                SqlCommand cnn = new SqlCommand("UPDATE Delavec set id_delavca=@id_delavca, ime_delavca=@ime_delavca, naslov=@naslov, datum_začetka_dela=@datum_začetka_dela", con);

                // Dodavanje vrednosti za parametre iz tekstualnih polja
                cnn.Parameters.AddWithValue("@id_delavca", int.Parse(id_text.Text));
                cnn.Parameters.AddWithValue("@ime_delavca", ime_text.Text);
                cnn.Parameters.AddWithValue("@naslov", enaslov_text.Text);

                // Validacija i parsiranje datuma
                DateTime datumVclanitve;
                if (DateTime.TryParse(datum_text.Text, out datumVclanitve))
                {
                    cnn.Parameters.AddWithValue("@datum_začetka_dela", datumVclanitve);
                }
                else
                {
                    // Prikazivanje poruke o grešci ako je datum neispravan
                    MessageBox.Show("Napačen format datuma. Prosimo vnesite datum v obliki yyyy-MM-dd.");
                    return;
                }

                // Izvršenje SQL upita
                cnn.ExecuteNonQuery();

                // Prikazivanje poruke o uspešnom unosu podataka
                MessageBox.Show("Podatki uspešno posodobljeni.");
            }
            catch (Exception ex) // Hvatanje izuzetaka
            {
                // Prikazivanje poruke o grešci
                MessageBox.Show("Prišlo je do napake: " + ex.Message);
            }
            finally // Zatvaranje veze, čak i ako dođe do greške
            {
                con.Close();
            }
        }

        private void izbrisi_gmb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                // Odpiranje povezave
                con.Open();

                // SQL povpraševanje za brisanje podatkov
                SqlCommand cnn = new SqlCommand("DELETE FROM Delavec WHERE id_člana=@id_člana", con);

                //Dodajanje vrednosti za parametar @id_člana
                cnn.Parameters.AddWithValue("@id_člana", int.Parse(id_text.Text));


                // Izvršenje SQL povpraševanja
                int rowsAffected = cnn.ExecuteNonQuery();

                // Provera da li je neki red obrisan
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Podatki so uspešno izbrisani.");
                }
                else
                {
                    // Prikazivanje poruke ako nije obrisan nijedan red
                    MessageBox.Show("Ni bilo podatkov za brisanje s tem ID-jem.");
                }
            }
            catch (Exception ex) // Hvatanje izuzetaka
            {
                // Prikazivanje poruke o grešci
                MessageBox.Show("Prišlo je do napake: " + ex.Message);
            }
            finally // Zatvaranje veze, čak i ako dođe do greške
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
