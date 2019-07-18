using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ArrayMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ARRAY SINIFI (CLASS)
        // Su ana dek gormus oldugumuz ilkel diziler, bize uzerinde cok fazla islem yapma olanagi saglamamaktadir. Eger dizinizi yeniden boyutlandirmak, temizlemek, siralamak, tersine cevirmek gibi temel islemler yapmak istiyorsaniz, Array sınıfı size yardimci olacaktir...


        string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };


        private void BtnClear_Click(object sender, EventArgs e)
        {
            // .Clear() => Dizi içerisinden bir(den fazla) eleman silmek için kullanılır.
            System.Array.Clear(ornekDizi, 0, 3);
            Array.Clear(ornekDizi, 0, ornekDizi.Length); // Dizinin tüm elemanlarını temizler

            // 1. Parametre : Hangi dizi ?
            // 2. Parametre : Kaçıncı Index değerinden başlayacağım ?
            // 3. Parametre : Kaç eleman sileceğim ? 
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            string[] kopyaDizi = new string[5];
            Array.Copy(ornekDizi, kopyaDizi, 5);

            // 1. ve 2. Overload (aralarındaki fark, 1. overload int , 2. overload long tipinde sayısal değer ister)
            // 1. Parametre : Kaynak dizi (verilerin alınacağı dizi)
            // 2. Parametre : Hedef dizi  (verilerin kopyalanacağı dizi)
            // 3. Parametre : Kopyalanacak eleman sayısı (0. index değerinden başlayarak verilen sayı kadar kopyalar)

            string[] copyArray = new string[5];
            Array.Copy(ornekDizi, 4, copyArray, 2, 2);

            // 3. ve 4. OverLoad

            // 1. Parametre : Kaynak dizi (veriler hangi diziden gelecek ?)
            // 2. Parametre : Kaynak dizinin, hangi index değerinden eleman kopyalama işlemine başlanacak ? 
            // 3. Parametre : Hedef dizi, veriler hangi diziye kopyalanacak ? 
            // 4. Parametre : Hedef dizinin, hangi index değerinden kopyala işlemine başlanacak ?
            // 5. Parametre : Kaynak diziden kaç eleman, hedef diziye kopyalanacak

        }
    }
}
