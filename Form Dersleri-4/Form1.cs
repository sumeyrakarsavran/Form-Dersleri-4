using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dersleri_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global alan

        object nesne;
        //object yerine dynamic yazsan aynı sonuç çıkar burda
        object nesne2;

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 15;
            string metin = "Akay Yazılım";

            //var veri türü tüm değişken türlerini kapsamaktadır, hepsinin yerine geçebilmektedir
            //var degisken; diye bırakılamıyor ama değer verilmesi lazım
            var degisken = 15; //pregram, bunun int türünde bir değişken old algılıyor
            // var dizilerde felan çok kullanılıyor for each de felan
            //private void diye başlayan bu yerlerde kullanılabiliniyor, onların dışında (global alan) kullanılamıyor
            //object ve dynamic veri türleri programın her yerinde kullanılabiliniyor
            //o ve d için değer atılması önemli değil atılmasa da olur

            nesne = 15.85;
            label2.Text = nesne.ToString();
            nesne = "C# Form Dersleri";
            label3.Text = nesne.ToString(); //her seferinde illa stringe dönüştür
            //label23.Text = Convert.ToString(nesne); olması gerekir dynamic diye tanımlarsak yukarda
            //çünkü d nesne.tostringi aşağıda göstermiyor tab yapamıyoruz yani ama normal elle yazabiliriz convertte sorun yok ama
            //ya da label3.Text = nesne + ""; yazsan da olur sorun çıkmaz


            nesne2 = 1500; // böyle değer atamaya boxing diyoruz
            if ((int)nesne2!=2000) //burda tekrar int yapmamız lazım object de böyleymiş, kutudan çıkarma deniyormus buna da yani unboxing
            {
                label4.Text = "sayi 2000den farklı";
            }



        }
    }
}
