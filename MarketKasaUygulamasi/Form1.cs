using Excel = Microsoft.Office.Interop.Excel;
namespace MarketKasaUygulamasi
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        List<Sepet> Sepetim = new List<Sepet>();
        Sepet sepet = new Sepet();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        // tl olarak yazacak
            label1.Text = String.Format("{0:C2}",total);

           
        }
        void MesajGoster(string message)
        {
            if (Sepetim.Count > 0)
            {
                FisOlustur(message);
                return;
                Sepetim = new List<Sepet>();
                SepetiGoster();
                MessageBox.Show(message, "Ödeme Yapýldý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sepetiniz boþ", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLenovoZ580_Click(object sender, EventArgs e)
        {
            butonlariKapat();
            sepet = new Sepet(1,"Lenovo Z580",1450);
            SepetiGoster();
            SepetToplam();
        }
        void Vazgec()
        {
            txtAdet.Text = "1";
            gbx1.Visible = false;
            bool status = true;
            btnIphoneX.Enabled = status;
            btnLenovoZ580.Enabled = status;
            btnNakit.Enabled = status;
            btnOppoReno.Enabled = status;
            btnKrediKarti.Enabled = status;
            btnMackbookPro.Enabled = status;
            btnLgG2.Enabled = status;
            btnSamsungF20.Enabled = status;
        }
        void butonlariKapat()
        {
            gbx1.Visible = true;
            bool status=false;
            btnIphoneX.Enabled = status;
            btnLenovoZ580.Enabled = status;
            btnNakit.Enabled = status;
            btnOppoReno.Enabled = status;
            btnKrediKarti.Enabled = status;
            btnMackbookPro.Enabled = status;
            btnLgG2.Enabled = status;
            btnSamsungF20.Enabled = status;

        }
        void SepetiGoster()
        {
            dtg1.DataSource = "";
            dtg1.DataSource = Sepetim;

        }
        void SepetToplam()
        {
            total = 0;

            foreach (var item in Sepetim)
            {
                total = item.Toplam + total;


            }
            label1.Text = String.Format("{0:C2}", total);
        }

        private void btnIphoneX_Click(object sender, EventArgs e)
        {
            butonlariKapat();
             sepet = new Sepet(1, "Iphone X", 22250);
        

            SepetiGoster();
            SepetToplam();
        }

        private void btnLgG2_Click(object sender, EventArgs e)
        {
            butonlariKapat();
             sepet = new Sepet(1, "LG G2", 1280);
           

            SepetiGoster();
            SepetToplam();
        }

        private void btnSamsungF20_Click(object sender, EventArgs e)
        {
            butonlariKapat();
            sepet = new Sepet(1, "Samsung F20", 10450);
            
            SepetiGoster();
            SepetToplam();
        }

        private void btnMackbookPro_Click(object sender, EventArgs e)
        {
            butonlariKapat();
             sepet = new Sepet(1, "MackbookPro", 20500);
           
           
            SepetiGoster();
            SepetToplam();
        }

        private void btnOppoReno_Click(object sender, EventArgs e)
        {
            butonlariKapat();
           sepet = new Sepet(1, "Oppo Reno", 7500);
          

            SepetiGoster();
            SepetToplam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Vazgec();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sepet.Adet = Convert.ToInt32(txtAdet.Text);
            sepet.Toplam =(decimal) sepet.Adet * sepet.BirimFiyat;
            Sepetim.Add(sepet);
            SepetiGoster();
            Vazgec();
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex]is DataGridViewButtonColumn && e.RowIndex>=0)
            {
               string urunadi = dtg1.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
                if (MessageBox.Show($"{urunadi}urunu silmek istiyormusunuz","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster();
                }
                
           
            }
        }
        void FisOlustur(string message)
        {
            Excel.Application excel = new Excel.Application();
            object Missing = Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.Sheets[1];

            worksheet.Range["A1"].Value = "#";
            worksheet.Range["B1"].Value = "Ürün Adi";
            worksheet.Range["C1"].Value = "Adet";
            worksheet.Range["D1"].Value = "Birim Fiyati";
            worksheet.Range["E1"].Value = "Toplam Tutar";

            worksheet.Range["A1"].ColumnWidth = 3.43;
            worksheet.Range["B1"].ColumnWidth = 13.29;
            worksheet.Range["C1"].ColumnWidth = 4.57;
            worksheet.Range["D1"].ColumnWidth = 10.57;
            worksheet.Range["E1"].ColumnWidth = 13.71;

            worksheet.Range["A1:E1"].Font.ColorIndex = 3;

            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;

            rowCount++;
            for (int x = 0; x < Sepetim.Count; x++)
            {
                worksheet.Range["A" + rowCount].Value = (x + 1);
                worksheet.Range["B" + rowCount].Value = Sepetim[x].UrunAdi;
                worksheet.Range["C" + rowCount].Value = Sepetim[x].Adet;
                worksheet.Range["D" + rowCount].Value = Sepetim[x].BirimFiyat;
                worksheet.Range["E" + rowCount].Value = Sepetim[x].Toplam;
                rowCount++;
            }

            worksheet.Range["A1:E" + (rowCount - 1)].Borders.LineStyle = 1;

            worksheet.Range["E" + rowCount].Formula = "=Sum(E2:E" + (rowCount - 1) + ")";
            worksheet.Range["E" + rowCount].Borders.LineStyle = 1;
            rowCount++;

            worksheet.Range["A" + rowCount].Value = message;
            worksheet.Range["A" + rowCount + ":E" + rowCount].MergeCells = true;
            worksheet.Range["A" + rowCount].HorizontalAlignment = 3;
            worksheet.Range["A" + rowCount].VerticalAlignment = 2;
            worksheet.Range["A" + rowCount].Font.ColorIndex = 3;
            worksheet.Range["A" + rowCount].Font.Bold = true;

            worksheet.Range["D2:E" + rowCount].NumberFormat = "#,##0.00";

            // worksheet.PrintOutEx();

            workbook.SaveAs(@"C:\1\Test.xlsx");

            excel.Visible = true;
        }

        private void gbx1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler nakit olarak ödendi");
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler kredi kartý ile ödendi");
        }
    }
}