using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Adıyaman");
            comboBox1.Items.Add("Afyonkarahisar");
            comboBox1.Items.Add("Ağrı");
            comboBox1.Items.Add("Amasya");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Antalya");
            comboBox1.Items.Add("Artvin");
            comboBox1.Items.Add("Aydın");
            comboBox1.Items.Add("Balıkesir");
            comboBox1.Items.Add("Bilecik");
            comboBox1.Items.Add("Bingöl");
            comboBox1.Items.Add("Bitlis");
            comboBox1.Items.Add("Bolu");
            comboBox1.Items.Add("Burdur");
            comboBox1.Items.Add("Bursa");
            comboBox1.Items.Add("Çanakkale");
            comboBox1.Items.Add("Çankırı");
            comboBox1.Items.Add("Çorum");
            comboBox1.Items.Add("Denizli");
            comboBox1.Items.Add("Diyarbakır");
            comboBox1.Items.Add("Edirne");
            comboBox1.Items.Add("Elazığ");
            comboBox1.Items.Add("Erzincan");
            comboBox1.Items.Add("Erzurum");
            comboBox1.Items.Add("Eskişehir");
            comboBox1.Items.Add("Gaziantep");
            comboBox1.Items.Add("Giresun");
            comboBox1.Items.Add("Gümüşhane");
            comboBox1.Items.Add("Hakkari");
            comboBox1.Items.Add("Hatay");
            comboBox1.Items.Add("Isparta");
            comboBox1.Items.Add("Mersin");
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Kars");
            comboBox1.Items.Add("Kastamonu");
            comboBox1.Items.Add("Kayseri");
            comboBox1.Items.Add("Kırklareli");
            comboBox1.Items.Add("Kırşehir");
            comboBox1.Items.Add("Kocaeli");
            comboBox1.Items.Add("Konya");
            comboBox1.Items.Add("Kütahya");
            comboBox1.Items.Add("Malatya");
            comboBox1.Items.Add("Manisa");
            comboBox1.Items.Add("Kahramanmaraş");
            comboBox1.Items.Add("Mardin");
            comboBox1.Items.Add("Muğla");
            comboBox1.Items.Add("Muş");
            comboBox1.Items.Add("Nevşehir");
            comboBox1.Items.Add("Niğde");
            comboBox1.Items.Add("Ordu");
            comboBox1.Items.Add("Rize");
            comboBox1.Items.Add("Sakarya");
            comboBox1.Items.Add("Samsun");
            comboBox1.Items.Add("Siirt");
            comboBox1.Items.Add("Sinop");
            comboBox1.Items.Add("Sivas");
            comboBox1.Items.Add("Tekirdağ");
            comboBox1.Items.Add("Tokat");
            comboBox1.Items.Add("Trabzon");
            comboBox1.Items.Add("Tunceli");
            comboBox1.Items.Add("Şanlıurfa");
            comboBox1.Items.Add("Uşak");
            comboBox1.Items.Add("Van");
            comboBox1.Items.Add("Yozgat");
            comboBox1.Items.Add("Zonguldak");
            comboBox1.Items.Add("Aksaray");
            comboBox1.Items.Add("Bayburt");
            comboBox1.Items.Add("Karaman");
            comboBox1.Items.Add("Kırıkkale");
            comboBox1.Items.Add("Batman");
            comboBox1.Items.Add("Şırnak");
            comboBox1.Items.Add("Bartın");
            comboBox1.Items.Add("Ardahan");
            comboBox1.Items.Add("Iğdır");
            comboBox1.Items.Add("Yalova");
            comboBox1.Items.Add("Karabük");
            comboBox1.Items.Add("Kilis");
            comboBox1.Items.Add("Osmaniye");
            comboBox1.Items.Add("Düzce");
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 80; i >= 0; i--) 
            { comboBox2.Items.Add(comboBox1.Items[i].ToString()); }
        }
    }
}
