using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_No_Formatı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCheckPhone_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string phoneLast = CheckPhone(phoneNumber);
            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                // Kullanıcıya sms gönderme işlemi
                MessageBox.Show($"{phoneLast} telefona mesaj gönderilmiştir.");
            }
        }

        public string CheckPhone(string phone)
        {

            try
            {
                if (phone == "")
                {
                    return "Hata mesajı => Lütfen telefon alanını doldurunuz.";
                }

                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");
                string firstCharacter = phone.Substring(0, 1);

                if (firstCharacter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }
                else if (firstCharacter != "0")
                {
                    phone = "0" + phone;
                }

                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone;
                }
                return "Hata mesajı => Lütfen girdiğiniz telefon formatını kontrol ediniz. (11 hane kabul edilmektedir.)";

            }
            catch (FormatException)
            {

                return "Hata mesajı => Lütfen uygun format ile telefon numarası giriniz...";
            }
            catch(Exception)
            {
                return "Hata mesajı => Bilinmeyen hata";
            }



        }

        // 05399825431

        // Boş girilmemesi gerekiyor.
        // Numaralar arasındaki boşluklar temizlenecek.
        // +90'lı telefon no girebilir. Bunu yukarıdaki formata çeviricez.
        // Başında 0 olmadan gönderebilir. Bunu yukarıdaki formata çeviricez.
        // Sayı yerine rakam göndermemesi gerekiyor.
    }
}
