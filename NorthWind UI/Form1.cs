using BLL.EntityLists;
using BLL.EntityManagers;

namespace NorthWind_UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        Productlist products;
        private void toolStripMenuILoad_Click(object sender, EventArgs e)
        {
              products = Productmanager.SelectAllProducts();
           
            this.dataGridView1.DataSource = products;
        }
        int CurrentPage = 0;
        private void toolStripMenuUp_Click(object sender, EventArgs e)
        {
            int PageNum=(products.Count / 10)+1;
            this.dataGridView1.DataSource = products.Skip(CurrentPage++ * 10).Take(10).ToList();
            if (CurrentPage >= PageNum)
            {
                CurrentPage = 0;
            }
        }

      
       

    }
}
