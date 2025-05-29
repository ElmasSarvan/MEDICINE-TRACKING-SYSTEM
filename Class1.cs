using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İLAÇ_TAKİP_SİSTEMİ
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string KullaniciSoyadi {get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string dogum_tarihi { get; set; }
        public string ilac_adi { get; set; }
        public DateTime baslangic_tarihi { get; set; }
        public DateTime bitis_tarihi { get; set; }
        public string sabah { get; set; }
        public string ogle { get; set; }
        public string aksam { get; set; }

        public string ilac_ara { get; set; }
        public string barkod { get; set; }
        public string atc { get; set; }
        public string kullanma_talimati { get; set; }
        public string genel_bilgi { get; set; }
        public string recete_durumu { get; set; }
        public string satis_fiyati { get; set; }
        public string firma_adi { get; set; }
        public string etken_madde { get; set; }
        public string ilac_sinifi { get; set; }
        public string sik_gorulen { get; set; }
        public string nadir_gorulen { get; set; }
        public string onemli_uyarilar { get; set; }
        public string kullanim_uyari { get; set; }
        public string BILDIRIMLER { get; set; }





    }
    public class DatabaseHelper
    {
        private string connectionString = "Server=ASUS\\MSSQLSERVER01; Database=İLAÇLAR; Integrated Security=True;MultipleActiveResultSets=True;";
        public void ID_BELİRLEME(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM KISILER  WHERE AD=@KullaniciAdi AND SOYAD=@KullaniciSoyadi AND PAROLA=@Sifre";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@KullaniciSoyadi", kullanici.KullaniciSoyadi);
                    cmd.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kullanici.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        }
                    }
                   
                }
                conn.Close();
            }
        }
        public void kullanıcı_giriş(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KISILER  WHERE AD=@KullaniciAdi AND SOYAD=@KullaniciSoyadi AND PAROLA=@Sifre"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@KullaniciSoyadi", kullanici.KullaniciSoyadi);
                    cmd.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
                   
                    object value = cmd.ExecuteScalar(); // Dönen değeri önce object türünde al
                    int result = value != null && int.TryParse(value.ToString(), out int temp) ? temp : 0;



                    if (result > 0)
                    {
                        MessageBox.Show("✅ Kullanıcı doğrulandı!");
                        Form1 yeniform = new Form1(kullanici);
                        yeniform.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("❌ Hatalı giriş!");
                        Form6 yeniform = new Form6();
                        yeniform.Show();
                    }
                   
                }
                conn.Close();
            }
        }

      
        public void KullaniciEkle(Kullanici yeniKullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KISILER (AD,SOYAD,PAROLA,DOGUM_TARIHI) VALUES (@KullaniciAdi,@KullaniciSoyadi, @Sifre,@dogum_tarihi)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dogum_tarihi", yeniKullanici.dogum_tarihi);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", yeniKullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@KullaniciSoyadi", yeniKullanici.KullaniciSoyadi);
                    cmd.Parameters.AddWithValue("@Sifre", yeniKullanici.Sifre);

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("✅ Başarıyla eklendiniz!");
                        Form1 yeniform = new Form1(yeniKullanici);
                        yeniform.Show();

                    }
                    else
                    {
                        MessageBox.Show("❌ Eklenirken hata oluştu!");
                        Form9 form = new Form9();
                        form.Show();
                    }
                }
                conn.Close();
            }
        }
        

        public void VeriGetir(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ILACLAR WHERE ILAC_ADI=@ilac_ara"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ilac_ara", kullanici.ilac_ara);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kullanici.ilac_ara = reader.GetString(reader.GetOrdinal("ILAC_ADI"));
                            kullanici.atc = reader.GetString(reader.GetOrdinal("ATC_KODU"));
                            kullanici.barkod = reader.GetString(reader.GetOrdinal("GTIN"));
                            kullanici.kullanma_talimati = reader.GetString(reader.GetOrdinal("KULLANMA_TALIMATI"));
                            kullanici.genel_bilgi = reader.GetString(reader.GetOrdinal("KISA_URUN_BILGISI"));
                            kullanici.recete_durumu= reader.GetString(reader.GetOrdinal("RECETE_DURUMU"));
                            kullanici.satis_fiyati = reader.GetString(reader.GetOrdinal("SATIS_FIYATI"));
                            kullanici.firma_adi = reader.GetString(reader.GetOrdinal("FIRMA_ADI"));
                            kullanici.etken_madde = reader.GetString(reader.GetOrdinal("ETKEN_MADDE"));
                            kullanici.sik_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_SIK_GORULEN"));
                            kullanici.nadir_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_NADIR_GORULEN"));
                            kullanici.ilac_sinifi = reader.GetString(reader.GetOrdinal("ILAC_SINIFI"));
                            kullanici.onemli_uyarilar = reader.GetString(reader.GetOrdinal("ONEMLI_UYARILAR"));
                            kullanici.kullanim_uyari = reader.GetString(reader.GetOrdinal("KULLANIM_UYARI"));

                            Form11 form11 = new Form11(kullanici);
                            form11.Show();
                        }
                    }
                    conn.Close();
                }
            }
        }
        public void ilaç_ekle(Kullanici yeniKullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KULLANDIGI_ILACLAR (ID, KULLANDIGI_ILAC, BASLANGIC_TARIHI, BITIS_TARIHI, SABAH_SAAT, OGLE_SAAT, AKSAM_SAAT) VALUES (@ID,@ilac_adi,@baslangic_tarihi,@bitis_tarihi,@sabah,@ogle,@aksam)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", yeniKullanici.ID);
                        cmd.Parameters.AddWithValue("@ilac_adi", yeniKullanici.ilac_adi);
                        cmd.Parameters.AddWithValue("@baslangic_tarihi", yeniKullanici.baslangic_tarihi);
                        cmd.Parameters.AddWithValue("@bitis_tarihi", yeniKullanici.bitis_tarihi);
                        cmd.Parameters.AddWithValue("@sabah", yeniKullanici.sabah ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ogle", yeniKullanici.ogle ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@aksam", yeniKullanici.aksam ?? (object)DBNull.Value);


                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                             MessageBox.Show("✅ Kullandığınız ilaç başarıyla eklendi!");
                             Form1 form = new Form1(yeniKullanici);
                             form.Show();
                        }
                        else
                        {
                            MessageBox.Show("❌ Eklenirken hata oluştu!");
                            Form8 yeniform = new Form8(yeniKullanici);
                            yeniform.Show();
                        }
                    }
                conn.Close();
            }
        }
        public void KULLANDIĞI_İLAÇLAR(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KULLANDIGI_ILACLAR WHERE ID=@ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", kullanici.ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kullanici.ilac_adi = reader.GetString(reader.GetOrdinal("KULLANDIGI_ILAC"));
                            kullanici.baslangic_tarihi = reader.GetDateTime(reader.GetOrdinal("BASLANGIC_TARIHI"));
                            kullanici.bitis_tarihi = reader.GetDateTime(reader.GetOrdinal("BITIS_TARIHI"));
                            kullanici.sabah = reader.GetString(reader.GetOrdinal("SABAH_SAAT"));
                            kullanici.ogle = reader.GetString(reader.GetOrdinal("OGLE_SAAT"));
                            kullanici.aksam = reader.GetString(reader.GetOrdinal("AKSAM_SAAT"));
                            
 
                        }
                    }
                }
                conn.Close();
            }
        }
        private void EkleBildirim(SqlConnection conn, int kullaniciID, string mesaj)
        {
            string Query = "INSERT INTO BILDIRIMLER (ID, BILDIRIMLER) VALUES (@ID, @mesaj)";
            using (SqlCommand insertCmd = new SqlCommand(Query, conn))
            {
                insertCmd.Parameters.AddWithValue("@ID", kullaniciID);
                insertCmd.Parameters.AddWithValue("@mesaj", mesaj);
                insertCmd.ExecuteNonQuery();
            }
        }
        public void BİLDİRİMLER(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM BILDIRIMLER JOIN KULLANDIGI_ILACLAR ON BILDIRIMLER.ID = KULLANDIGI_ILACLAR.ID WHERE BILDIRIMLER.ID=@ID";
               
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", kullanici.ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            DateTime tamZaman = DateTime.Now;
                            TimeSpan sadeceSaat = tamZaman.TimeOfDay;

                            kullanici.ilac_ara = reader.GetString(reader.GetOrdinal("KULLANDIGI_ILAC"));
                            kullanici.baslangic_tarihi = reader.GetDateTime(reader.GetOrdinal("BASLANGIC_TARIHI"));
                            kullanici.bitis_tarihi = reader.GetDateTime(reader.GetOrdinal("BITIS_TARIHI"));
                            kullanici.sabah = reader.GetString(reader.GetOrdinal("SABAH_SAAT"));
                            kullanici.ogle = reader.GetString(reader.GetOrdinal("OGLE_SAAT"));
                            kullanici.aksam = reader.GetString(reader.GetOrdinal("AKSAM_SAAT"));

                            TimeSpan? sabah = kullanici.sabah != null ? Convert.ToDateTime(kullanici.sabah).TimeOfDay : (TimeSpan?)null;
                            TimeSpan? ogle = kullanici.ogle != null ? Convert.ToDateTime(kullanici.ogle).TimeOfDay : (TimeSpan?)null;
                            TimeSpan? aksam = kullanici.aksam != null ? Convert.ToDateTime(kullanici.aksam).TimeOfDay : (TimeSpan?)null;

                            if (kullanici.baslangic_tarihi <=tamZaman && tamZaman<= kullanici.bitis_tarihi)
                            {
                                if (sabah.HasValue && Math.Abs((sabah.Value - sadeceSaat).TotalMinutes) <= 1)
                                {
                                    EkleBildirim(conn, kullanici.ID, $"{kullanici.ilac_ara.ToUpper()} İLACINIZI İÇİNİZ!\nSABAH SAAT: {kullanici.sabah}");
                                }

                                if (ogle.HasValue && Math.Abs((ogle.Value - sadeceSaat).TotalMinutes) <= 1)
                                {
                                    EkleBildirim(conn, kullanici.ID, $"{kullanici.ilac_ara.ToUpper()} İLACINIZI İÇİNİZ!\nÖĞLE SAAT: {kullanici.ogle}");
                                }

                                if (aksam.HasValue && Math.Abs((aksam.Value - sadeceSaat).TotalMinutes) <= 1)
                                {
                                    EkleBildirim(conn, kullanici.ID, $"{kullanici.ilac_ara.ToUpper()} İLACINIZI İÇİNİZ!\nAKŞAM SAAT: {kullanici.aksam}");
                                }

                            }

                        }
                    }
                }
                string query1 = "SELECT * FROM BILDIRIMLER WHERE ID=@ID";

                using (SqlCommand cmd = new SqlCommand(query1, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", kullanici.ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kullanici.BILDIRIMLER= reader.GetString(reader.GetOrdinal("BILDIRIMLER"));

                        }
                    }
                }
                conn.Close();
            }
        }
        public void VeriGetir1(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ILACLAR WHERE GTIN=@barkod";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@barkod", kullanici.barkod);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kullanici.ilac_ara = reader.GetString(reader.GetOrdinal("ILAC_ADI"));
                            kullanici.atc = reader.GetString(reader.GetOrdinal("ATC_KODU"));
                            kullanici.barkod = reader.GetString(reader.GetOrdinal("GTIN"));
                            kullanici.kullanma_talimati = reader.GetString(reader.GetOrdinal("KULLANMA_TALIMATI"));
                            kullanici.genel_bilgi = reader.GetString(reader.GetOrdinal("KISA_URUN_BILGISI"));
                            kullanici.recete_durumu = reader.GetString(reader.GetOrdinal("RECETE_DURUMU"));
                            kullanici.satis_fiyati = reader.GetString(reader.GetOrdinal("SATIS_FIYATI"));
                            kullanici.firma_adi = reader.GetString(reader.GetOrdinal("FIRMA_ADI"));
                            kullanici.etken_madde = reader.GetString(reader.GetOrdinal("ETKEN_MADDE"));
                            kullanici.sik_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_SIK_GORULEN"));
                            kullanici.nadir_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_NADIR_GORULEN"));
                            kullanici.ilac_sinifi = reader.GetString(reader.GetOrdinal("ILAC_SINIFI"));
                            kullanici.onemli_uyarilar = reader.GetString(reader.GetOrdinal("ONEMLI_UYARILAR"));
                            kullanici.kullanim_uyari = reader.GetString(reader.GetOrdinal("KULLANIM_UYARI"));

                            Form11 form11 = new Form11(kullanici);
                            form11.Show();
                        }
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Barkod için veri bulunamadı.");
                        }
                    }
                }
                conn.Close();
            }
        }
        public void VeriGetir2(Kullanici kullanici)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ILACLAR WHERE BARKOD=@barkod";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@barkod", kullanici.barkod);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kullanici.ilac_ara = reader.GetString(reader.GetOrdinal("ILAC_ADI"));
                            kullanici.atc = reader.GetString(reader.GetOrdinal("ATC_KODU"));
                            kullanici.barkod = reader.GetString(reader.GetOrdinal("GTIN"));
                            kullanici.kullanma_talimati = reader.GetString(reader.GetOrdinal("KULLANMA_TALIMATI"));
                            kullanici.genel_bilgi = reader.GetString(reader.GetOrdinal("KISA_URUN_BILGISI"));
                            kullanici.recete_durumu = reader.GetString(reader.GetOrdinal("RECETE_DURUMU"));
                            kullanici.satis_fiyati = reader.GetString(reader.GetOrdinal("SATIS_FIYATI"));
                            kullanici.firma_adi = reader.GetString(reader.GetOrdinal("FIRMA_ADI"));
                            kullanici.etken_madde = reader.GetString(reader.GetOrdinal("ETKEN_MADDE"));
                            kullanici.sik_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_SIK_GORULEN"));
                            kullanici.nadir_gorulen = reader.GetString(reader.GetOrdinal("YAN_ETKILER_NADIR_GORULEN"));
                            kullanici.ilac_sinifi = reader.GetString(reader.GetOrdinal("ILAC_SINIFI"));
                            kullanici.onemli_uyarilar = reader.GetString(reader.GetOrdinal("ONEMLI_UYARILAR"));
                            kullanici.kullanim_uyari = reader.GetString(reader.GetOrdinal("KULLANIM_UYARI"));

                            Form11 form11 = new Form11(kullanici);
                            form11.Show();
                        }
                    }
                }
                conn.Close();
            }
        }
      
    }

}
