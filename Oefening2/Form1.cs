using System.Text.Json;
using System.Text.Json.Nodes;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        Stapel<string> string_stapel = new Stapel<string>();
        Stapel<int> int_stapel = new Stapel<int>();
        Stapel<Persoon> persoon_stapel = new Stapel<Persoon>();
        public Form1()
        {
            InitializeComponent();
        }

        public void clearInputString()
        {
            ObejctToevoegen.Text = "";
            ObjectVerwijderen.Text = "";
            ObjectIsAanwezig.Text = "";
        }

        public void clearInputInt()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        public void clearInputPersoon()
        {
            PerToevoegen.Text = "";
            PerIsAanwezig.Text = "";
        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            string_stapel.Toevoegen(ObejctToevoegen.Text);
            ContentBox.Text = string_stapel.ToString();
            clearInputString();
        }

        private void Verwijderen_Click(object sender, EventArgs e)
        {
            string input = ObjectVerwijderen.Text;

            if (string_stapel.IsAanwezig(input))
            {
                string_stapel.Verwijderen(input);
                ContentBox.Text = string_stapel.ToString();
                MessageBox.Show(input + " is verwijdert.");
                clearInputString();
            } else
            {
                MessageBox.Show(input + " bestaat niet.");
                clearInputString();
            }
        }

        private void AllesVerwijderen_Click(object sender, EventArgs e)
        {
            string_stapel.Leegmaken();
            ContentBox.Text = string_stapel.ToString();
            MessageBox.Show("De string stapel is leeg.");
            clearInputString();
        }

        private void IsAanwezig_Click(object sender, EventArgs e)
        {
            bool isAanwezig = string_stapel.IsAanwezig(ObjectIsAanwezig.Text);
            ContentBox.Text = isAanwezig.ToString();
            clearInputString();
        }

        private void IntToevoegen_Click(object sender, EventArgs e)
        {
            int input_waarde = Convert.ToInt32(numericUpDown1.Value);
            int_stapel.Toevoegen(input_waarde);
            ContentBox.Text = int_stapel.ToString();
            clearInputInt();
        }

        private void IntVerwijderen_Click(object sender, EventArgs e)
        {
            int input_waarde = Convert.ToInt32(numericUpDown2.Value);
            
            if (int_stapel.IsAanwezig(input_waarde))
            {
                int_stapel.Verwijderen(input_waarde);
                ContentBox.Text = int_stapel.ToString();
                MessageBox.Show(input_waarde + " is verwijdert.");
                clearInputInt();
            } else
            {
                MessageBox.Show(input_waarde + " bestaat niet.");
                clearInputInt();
            }
        }

        private void IntIsAanwezig_Click(object sender, EventArgs e)
        {
            int int_waarde = Convert.ToInt32(numericUpDown3.Value);
            bool isAanwezig = int_stapel.IsAanwezig(int_waarde);
            ContentBox.Text = isAanwezig.ToString();
            clearInputInt();
        }

        private void ClearInt_Click(object sender, EventArgs e)
        {
            int_stapel.Leegmaken();
            ContentBox.Text = int_stapel.ToString();
            MessageBox.Show("De string stapel is leeg.");
            clearInputInt();
        }

        private void KopieString_Click(object sender, EventArgs e)
        {
            Stapel<string> new_string_stapel = string_stapel.Copy();
            ContentBox.Text = string_stapel.ToString() + " " + new_string_stapel;
        }

        private void IntKopie_Click(object sender, EventArgs e)
        {
            Stapel<int> new_int_stapel = int_stapel.Copy();
            ContentBox.Text = int_stapel.ToString() + " " + new_int_stapel;
        }

        private void PersoonToevoegen_Click(object sender, EventArgs e)
        {
            string naam = PerToevoegen.Text;
            Persoon persoon = new Persoon(naam);
            persoon_stapel.Toevoegen(persoon);
            ContentBox.Text = persoon_stapel.ToString();
            clearInputPersoon();
        }

        private void PersoonVerwijderen_Click(object sender, EventArgs e)
        {
            //string naam = PerVerwijderen.Text;
            //Persoon persoon = new Persoon(naam);

            //if (persoon_stapel.IsAanwezig(persoon))
            //{
            //    persoon_stapel.Verwijderen(persoon);
            //    ContentBox.Text = persoon_stapel.ToString();
            //    MessageBox.Show(persoon.ToString() + " is verwijdert.");
            //    clearInputPersoon();
            //}
            //else
            //{
            //    MessageBox.Show(persoon.ToString() + " bestaat niet.");
            //    clearInputPersoon();
            //}
            
            persoon_stapel.verwijderPersoon();
            ContentBox.Text = persoon_stapel.ToString();
            clearInputPersoon();

        }

        // Nog niet klaar
        private void PersoonIsAanwezig_Click(object sender, EventArgs e)
        {
            string naam = PerIsAanwezig.Text;
            Persoon persoon = new Persoon(naam);
            bool isAanwezig = persoon_stapel.IsAanwezig(persoon);
            ContentBox.Text = isAanwezig.ToString();
            clearInputPersoon();

            //foreach (var item in (dynamic)(persoon_stapel))
            //{
            //    if (item.naam == naam)
            //    {
            //        ContentBox.Text = true.ToString();
            //    }
            //}

            //clearInputPersoon();
        }

        private void ClearPersoon_Click(object sender, EventArgs e)
        {
            persoon_stapel.Leegmaken();
            ContentBox.Text = persoon_stapel.ToString();
            MessageBox.Show("De persoon stapel is leeg.");
            clearInputPersoon();
        }

        private void PersoonKopie_Click(object sender, EventArgs e)
        {
            Stapel<Persoon> new_persoon_stapel = persoon_stapel.Copy();
            ContentBox.Text = persoon_stapel.ToString() + " " + new_persoon_stapel;
        }
    }
}