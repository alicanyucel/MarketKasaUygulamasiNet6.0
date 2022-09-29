namespace MarketKasaUygulamasi
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        List<Sepet> Sepetim = new List<Sepet>();
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

        private void btnLenovoZ580_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(1,"Lenovo Z580",1450);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
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
            Sepet sepet = new Sepet(1, "Iphone X", 22250);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
        }

        private void btnLgG2_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(1, "LG G2", 1280);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
        }

        private void btnSamsungF20_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(1, "Samsung F20", 10450);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
        }

        private void btnMackbookPro_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(1, "MackbookPro", 20500);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
        }

        private void btnOppoReno_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(1, "Oppo Reno", 7500);
            Sepetim.Add(sepet);

            SepetiGoster();
            SepetToplam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}