using EntityFrameWork_1.Classes;
using System.Windows.Forms;

namespace EntityFrameWork_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadData loaddata = new LoadData();
            loaddata.PopulateDataGridView(dgvTickets);
            int numberofrows = dgvTickets.Rows.Count;
            lblnbmrows.Text += ": " + numberofrows.ToString();
            
        }

        private void DgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewTicket_Click(object sender, System.EventArgs e)
        {

        }
    }
}
