using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsInWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadingPrint();
            SettingTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainText = Txt_name.Text;
            if (mainText == "")
            {
                string v = Get();
                dynamic json = JsonConvert.DeserializeObject(v);
                if (json.erro != "")
                {
                    Lbl_result.Text = json.data[0].full_description;
                }
            }
            else
            {
                string[] items = { Txt_name.Text, QuantityItem.Text, DateItem.Text};
                InsertDataTable(items);
            }
        }
        public string Get()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://192.168.0.199:71/GLOBAL/Controller/CCPP/AppVersion.php?id=14");
            response.Wait();
            var data = response.Result;
            return data;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Lbl_result.Text = "";
            Txt_name.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LoadingPrint()
        {
            printComboBox.Items.Clear();
            foreach (var print in System.Drawing.Printing.PrinterSettings.InstalledPrinters) {
                printComboBox.Items.Add(print);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            using (var pd = new System.Drawing.Printing.PrintDocument())
            {
                pd.PrinterSettings.PrinterName = printComboBox.SelectedItem.ToString();
                pd.PrintPage += Pd_PrintPage1;
                text = Pd_PrintPage.Text;
                pd.Print();
            }
        }
        private string text;
        private void Pd_PrintPage1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            using(var font = new Font("Times New Roman", 14))
            using (var brush = new SolidBrush(Color.Black))
            {
                int caracteres = 0;
                int lines = 0;
                e.Graphics.MeasureString(text, font, new Size(e.MarginBounds.Width, e.MarginBounds.Height - font.Height+1), StringFormat.GenericDefault, out caracteres, out lines);
                e.Graphics.DrawString(text.Substring(0,caracteres), font, brush,e.MarginBounds);

                text = text.Substring(caracteres);
                e.HasMorePages = !string.IsNullOrWhiteSpace(text);
            }

            
        }

        private void Pd_PrintPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingTable()
        {
            ListData.View = View.Details;
            ListData.LabelEdit = true;
            ListData.AllowColumnReorder = true;
            ListData.FullRowSelect = true;
            ListData.GridLines = true;

            ListData.Columns.Add("DESCRIÇÃO", 100, HorizontalAlignment.Left);
            ListData.Columns.Add("QTD.", 50, HorizontalAlignment.Left);
            ListData.Columns.Add("DATA", 100, HorizontalAlignment.Left);
        }

        private void InsertDataTable(string[] data)
        {
            var newLine = new ListViewItem(data);
            ListData.Items.Add(newLine);
        }

        private void ListData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewWindow_Click(object sender, EventArgs e)
        {

        }
    }
}
