namespace MarketKasaUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLenovoZ580 = new System.Windows.Forms.Button();
            this.btnIphoneX = new System.Windows.Forms.Button();
            this.btnLgG2 = new System.Windows.Forms.Button();
            this.btnSamsungF20 = new System.Windows.Forms.Button();
            this.btnMackbookPro = new System.Windows.Forms.Button();
            this.btnOppoReno = new System.Windows.Forms.Button();
            this.btnKrediKarti = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(486, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "0,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLenovoZ580
            // 
            this.btnLenovoZ580.Location = new System.Drawing.Point(29, 98);
            this.btnLenovoZ580.Name = "btnLenovoZ580";
            this.btnLenovoZ580.Size = new System.Drawing.Size(90, 49);
            this.btnLenovoZ580.TabIndex = 1;
            this.btnLenovoZ580.Text = "Lenovo Z580";
            this.btnLenovoZ580.UseVisualStyleBackColor = true;
            // 
            // btnIphoneX
            // 
            this.btnIphoneX.Location = new System.Drawing.Point(192, 98);
            this.btnIphoneX.Name = "btnIphoneX";
            this.btnIphoneX.Size = new System.Drawing.Size(90, 49);
            this.btnIphoneX.TabIndex = 2;
            this.btnIphoneX.Text = "İphone X";
            this.btnIphoneX.UseVisualStyleBackColor = true;
            // 
            // btnLgG2
            // 
            this.btnLgG2.Location = new System.Drawing.Point(341, 98);
            this.btnLgG2.Name = "btnLgG2";
            this.btnLgG2.Size = new System.Drawing.Size(90, 49);
            this.btnLgG2.TabIndex = 3;
            this.btnLgG2.Text = "Lg G2";
            this.btnLgG2.UseVisualStyleBackColor = true;
            // 
            // btnSamsungF20
            // 
            this.btnSamsungF20.Location = new System.Drawing.Point(29, 201);
            this.btnSamsungF20.Name = "btnSamsungF20";
            this.btnSamsungF20.Size = new System.Drawing.Size(90, 49);
            this.btnSamsungF20.TabIndex = 4;
            this.btnSamsungF20.Text = "Samsung F20";
            this.btnSamsungF20.UseVisualStyleBackColor = true;
            // 
            // btnMackbookPro
            // 
            this.btnMackbookPro.Location = new System.Drawing.Point(192, 201);
            this.btnMackbookPro.Name = "btnMackbookPro";
            this.btnMackbookPro.Size = new System.Drawing.Size(90, 49);
            this.btnMackbookPro.TabIndex = 5;
            this.btnMackbookPro.Text = "Macbook Pro";
            this.btnMackbookPro.UseVisualStyleBackColor = true;
            // 
            // btnOppoReno
            // 
            this.btnOppoReno.Location = new System.Drawing.Point(341, 201);
            this.btnOppoReno.Name = "btnOppoReno";
            this.btnOppoReno.Size = new System.Drawing.Size(90, 49);
            this.btnOppoReno.TabIndex = 6;
            this.btnOppoReno.Text = "Oppo Reno";
            this.btnOppoReno.UseVisualStyleBackColor = true;
            // 
            // btnKrediKarti
            // 
            this.btnKrediKarti.Location = new System.Drawing.Point(192, 393);
            this.btnKrediKarti.Name = "btnKrediKarti";
            this.btnKrediKarti.Size = new System.Drawing.Size(90, 49);
            this.btnKrediKarti.TabIndex = 7;
            this.btnKrediKarti.Text = "Kredi Kartı";
            this.btnKrediKarti.UseVisualStyleBackColor = true;
            // 
            // btnNakit
            // 
            this.btnNakit.Location = new System.Drawing.Point(41, 393);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(90, 49);
            this.btnNakit.TabIndex = 8;
            this.btnNakit.Text = "Nakit";
            this.btnNakit.UseVisualStyleBackColor = true;
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(486, 30);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowTemplate.Height = 25;
            this.dtg1.Size = new System.Drawing.Size(299, 341);
            this.dtg1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 482);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.btnNakit);
            this.Controls.Add(this.btnKrediKarti);
            this.Controls.Add(this.btnOppoReno);
            this.Controls.Add(this.btnMackbookPro);
            this.Controls.Add(this.btnSamsungF20);
            this.Controls.Add(this.btnLgG2);
            this.Controls.Add(this.btnIphoneX);
            this.Controls.Add(this.btnLenovoZ580);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Market Kasa Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btnLenovoZ580;
        private Button btnIphoneX;
        private Button btnLgG2;
        private Button btnSamsungF20;
        private Button btnMackbookPro;
        private Button btnOppoReno;
        private Button btnKrediKarti;
        private Button btnNakit;
        private DataGridView dtg1;
    }
}