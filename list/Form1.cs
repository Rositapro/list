namespace list
{
    public partial class Form1 : Form
    {
        private ListViewItem[] allItems; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                string[] headers = lines[0].Split(',');
                lstvData.Columns.Clear();
                lstvData.Items.Clear();
                foreach (string header in headers)
                {
                    lstvData.Columns.Add(header);
                }

                allItems = new ListViewItem[lines.Length - 1]; // Inicializa el arreglo
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    ListViewItem lvi = new ListViewItem(fields);
                    lstvData.Items.Add(lvi);
                    allItems[i - 1] = lvi; // Guarda el elemento en el arreglo
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtFilter.Text.Trim() == "")
            {
                return;
            }


            lstvData.Items.Clear(); 

            string filter = txtFilter.Text.ToLower();
            foreach (ListViewItem item in allItems) 
            {
                if (item.SubItems.Count > 0)
                {
                    if (item.SubItems[2].Text.ToLower().Contains(filter))
                    {
                        lstvData.Items.Add(item);
                    }
                }
            }
        }

        private void btnSearchTime_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            lstvData.Items.Clear();

            foreach (ListViewItem item in allItems) 
            {
                if (item.SubItems.Count > 6) 
                {
                    
                    if (DateTime.TryParse(item.SubItems[6].Text, out DateTime releaseDate))
                    {
                        
                        if (releaseDate >= startDate && releaseDate <= endDate)
                        {
                          
                            lstvData.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
   