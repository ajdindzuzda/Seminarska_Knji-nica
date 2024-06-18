using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Seminarska_knjižnica
{
    public partial class Izposoja : Form
    {
       

        public Izposoja()
        {
            InitializeComponent();
            LoadComboBoxes();
            dateTimePickerPrevzema.ValueChanged += DateTimePickerPrevzema_ValueChanged;
        }

      

        private void LoadComboBoxes()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");
            {
                con.Open();

                // Punjenje ComboBox za id_člana
                SqlDataAdapter daClana = new SqlDataAdapter("SELECT id_člana, ime FROM Član", con);
                DataTable dtClana = new DataTable();
                daClana.Fill(dtClana);
                comboBoxIdClana.DataSource = dtClana;
                comboBoxIdClana.DisplayMember = "ime";
                comboBoxIdClana.ValueMember = "id_člana";

                // Punjenje ComboBox za id_knjige
                SqlDataAdapter daKnjige = new SqlDataAdapter("SELECT id_knjige, ime FROM Knjiga", con);
                DataTable dtKnjige = new DataTable();
                daKnjige.Fill(dtKnjige);
                comboBoxIdKnjige.DataSource = dtKnjige;
                comboBoxIdKnjige.DisplayMember = "ime";
                comboBoxIdKnjige.ValueMember = "id_knjige";
            }
        }

        private void DateTimePickerPrevzema_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerVracila.Value = dateTimePickerPrevzema.Value.AddDays(14);
        }

        private void shrani_gmb_Click(object sender, EventArgs e)
        {
            // Povezivanje sa bazom podataka
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");
            try
            {
                con.Open();

                // SQL upit za umetanje podataka
                SqlCommand cmd = new SqlCommand("INSERT INTO Izposoja (id_knjige, id_člana, datum_prevzema, datum_vračila) VALUES (@id_knjige, @id_člana, @datum_prevzema, @datum_vračila)", con);

                // Dodavanje parametara
                cmd.Parameters.AddWithValue("@id_knjige", comboBoxIdKnjige.SelectedValue);
                cmd.Parameters.AddWithValue("@id_člana", comboBoxIdClana.SelectedValue);
                cmd.Parameters.AddWithValue("@datum_prevzema", dateTimePickerPrevzema.Value);
                cmd.Parameters.AddWithValue("@datum_vračila", dateTimePickerVracila.Value);

                // Izvršenje SQL upita
                cmd.ExecuteNonQuery();

                // Prikazivanje poruke o uspešnom unosu podataka
                MessageBox.Show("Podatki so uspešno shranjeni.");
            }
            catch (Exception ex)
            {
                // Prikazivanje poruke o grešci
                MessageBox.Show("Prišlo je do napake: " + ex.Message);
            }
            finally
            {
                // Zatvaranje veze
                con.Close();
            }
        }

        private void prikaži_gmb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");
            try
            {
                con.Open();
                MessageBox.Show("Povezava uspešno vzpostavljena.");

                SqlCommand cnn = new SqlCommand("SELECT * FROM Izposoja", con);
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

        private void id_label_Click(object sender, EventArgs e)
        {

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
                SqlCommand cnn = new SqlCommand("SELECT * FROM Izposoja", con);

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

        private void izbrisi_gmb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23P3ODG\SQLEXPRESS;Initial Catalog=Knjižnica;Integrated Security=True");

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Izposoja WHERE id_izposoje = @id_izposoje", con);
                cmd.Parameters.AddWithValue("@id_izposoje", int.Parse(textBoxIdIzposoje.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Podatki so uspešno izbrisani.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prišlo je do napake: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
