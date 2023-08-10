using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using Microsoft.SqlServer.Management.HadrData;
using System.Security.Cryptography;
using System.Data;


namespace AryaSoft // Uygulamanın ad alanı
{
    public partial class Form1 : Form // Uygulamanın ana formu
    {
        public Form1() // Formun yapıcı metodu
        {
            InitializeComponent(); // Form bileşenlerini başlatır
        }

        private void btn_sec_Click(object sender, EventArgs e) // Yedekleme dosyasının yolunu seçmek için butona tıklandığında çalışan metot
        {
            saveFileDialog1.Title = "yedeklenecek yolu belirtiniz:"; // Dosya seçim penceresinin başlığı
            saveFileDialog1.Filter = "Yedekleme Dosyaları (*.bak)|*.bak|Tüm Dosyalar(*.*)|*.*"; // Dosya seçim penceresinin filtresi

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Dosya seçim penceresinde Tamam butonuna basılırsa
            {

                Path_txt.Text = saveFileDialog1.FileName; // Seçilen dosyanın adını metin kutusuna yazdırır
            }

        }
        private void btn_yedekle_Click(object sender, EventArgs e) // Yedekleme işlemini başlatmak için butona tıklandığında çalışan metot
        {
            
            try
            {   

                if (string.IsNullOrEmpty(Path_txt.Text))//metin kutusu boş ise 
                {
                    MessageBox.Show("Lütfen yedeklenecek yolu seçiniz:", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else  // path metin kutusu dolu ise 
                {     
                    
                    SqlConnection connection = new SqlConnection(); // Veritabanına bağlanmak için bir SqlConnection nesnesi oluşturur

                    if (WindowsRadio.Checked == true) // Windows kimlik doğrulaması seçildiyse
                    {


                        Server databaseServer = new Server(new ServerConnection(Server_txt.Text)); // Veritabanı sunucusu için bir Server nesnesi oluşturur
                        Backup databaseBackup = new Backup(); // Yedekleme işlemi için bir Backup nesnesi oluşturur
                        databaseBackup.Action = BackupActionType.Database; // Yedekleme işleminin veritabanı düzeyinde olduğunu belirtir
                        databaseBackup.Database = Database_txt.Text; // Yedeklenecek veritabanının adını metin kutusundan alır
                        databaseBackup.Devices.AddDevice(Path_txt.Text, DeviceType.File); // Yedekleme dosyasının yolunu ve tipini belirtir
                        databaseBackup.Initialize = false; // Yedekleme dosyasının üzerine yazılmasına izin verir
                        databaseBackup.Complete += Dbbackup_Complete; // Yedekleme işlemi tamamlandığında çalışacak olayı tanımlar
                        databaseBackup.SqlBackup(databaseServer); // Yedekleme işlemini başlatır

                    }
                    else if (SqlRadio.Checked == true) // SQL Server kimlik doğrulaması seçildiyse
                    {

                        connection = new SqlConnection("data source=" + Server_txt.Text + ";Database=" + Database_txt.Text + ";Persist Security info=true" + ";Uid=" + Username_txt.Text + ";password=" + Password_txt.Text);
                        string backupScript = "BACKUP DATABASE " + Database_txt.Text + " TO DISK = '" + Path.Combine(Path_txt.Text + DateTime.Now.ToString("yyyymdd")) + "'"; // Yedekleme dosyasının adını ve yolunu belirtir
                        SqlCommand command = new SqlCommand(backupScript, connection); // Yedekleme komutunu oluşturur
                        Console.WriteLine(backupScript);
                        connection.Open(); // Veritabanına bağlanır
                        command.ExecuteNonQuery(); // Yedekleme komutunu çalıştırır
                        MessageBox.Show("yedekleme tamamlandı ", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close(); // Veritabanından ayrılır
                                     
                    }                                           
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            
        }
        private void Dbbackup_Complete(object sender, ServerMessageEventArgs eventArgs) // Yedekleme işlemi tamamlandığında çalışan metot
        {
            try // Hata olup olmadığını kontrol etmek için try-catch bloğu kullanır
            {
                MessageBox.Show("yedekleme işlemi başarılı bir şekilde gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Başarılı mesajı gösterir

            }
            catch (Exception) // Hata oluşursa
            {

                MessageBox.Show("hata", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajı gösterir

            }
        }

        private void WindowsRadio_CheckedChanged(object sender, EventArgs e) // Windows kimlik doğrulaması radyo düğmesinin durumu değiştiğinde çalışan metot
        {
            Username_txt.Enabled = false; // Kullanıcı adı metin kutusunu devre dışı bırakır
            Password_txt.Enabled = false; // Şifre metin kutusunu devre dışı bırakır


        }

        private void SqlRadio_CheckedChanged(object sender, EventArgs e) // SQL Server kimlik doğrulaması radyo düğmesinin durumu değiştiğinde çalışan metot
        {
            Username_txt.Enabled = true; // Kullanıcı adı metin kutusunu etkinleştirir
            Password_txt.Enabled = true; // Şifre metin kutusunu etkinleştirir


        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            try //bağlantıyı denemek için 
            {
                SqlConnection connection = new SqlConnection();  // yeni bir coonection nesnesi oluşturur
                if (WindowsRadio.Checked == true)
                {
                    connection.ConnectionString = "data source=" + Server_txt.Text + ";database=" + Database_txt.Text + ";Integrated Security=true";  //bağlantı dizesini ayarlar
                }
                else if (SqlRadio.Checked == true)
                {
                    connection.ConnectionString = "data source=" + Server_txt.Text + ";Database=" + Database_txt.Text + ";Persist Security info=true" + ";Uid=" + Username_txt.Text + ";password=" + Password_txt.Text;
                }
                else //seçim yapılmamış ise
                {
                    MessageBox.Show("Lütfen kimlik doğrulama türünü seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open(); // Bağlantıyı açar
                MessageBox.Show("Bağlantı başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Bilgi mesajı gösterir
                connection.Close(); // Bağlantıyı kapatır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajı gösterir
            }
            
        }

        private void btnrestoresec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Restore File|*.bak";//restore dosyasının uzanntısını bak olarak belirle
            openFileDialog1.InitialDirectory = @"C:\";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rpath.Text = openFileDialog1.FileName; //restore dosyasının tam yolunu rpath txt kutusuna yaz
                rdatabase.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName); //restore dosyasının adını rdatabase txt kutusuna yaz 
                rserver.Text = Environment.MachineName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();

                if (Rwindows_radio.Checked==true)
                {

               
                  //restore işlemini yapmak için bir sqlconnection nesnesi oluştur 
                 sqlConnection.ConnectionString = @"data source=" + rserver.Text + ";Initial Catalog=master;Integrated Security=true";  //sqlconnection nesnesinin bağlantı bilgilerini belirle
                SqlConnection conn=new SqlConnection(sqlConnection.ConnectionString);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();//restore işlemi için bir sqlcommand nesnesi ayarla
                sqlCommand.Connection = sqlConnection; //sql command nesnesinin bağlantısını sql connection nesnesi ile ayarla
                string sqlQuery = "USE master RESTORE DATABASE [" + rdatabase.Text + "] FROM DISK = '" + rpath.Text + "' WITH REPLACE"; //SQL KOMUTU
                sqlCommand.CommandText = sqlQuery;//sqlcomman nesnesinin komutunu sql komutu ilee ayarla 
                sqlConnection.Open();//bağlantıyı aç 
                sqlCommand.ExecuteNonQuery(); //komutu çalıştır
                                              // sqlConnection.Close();
                MessageBox.Show("işlem başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (RSql_radio.Checked==true)
                {
                    // Veritabanını geri yükle
                    // sqlConnection nesnesini oluştur ve bağlantı bilgilerini belirle
                    sqlConnection = new SqlConnection("data source=" + rserver.Text + ";Database=" + rdatabase.Text + ";Persist Security info=true" + ";Uid=" + Username_txt.Text + ";password=" + Password_txt.Text);
                    // Geri yükleme komutunu oluşturs
                    string sqlQuery = "USE master RESTORE DATABASE [" + rdatabase.Text + "] FROM DISK = '" + rpath.Text + "' WITH REPLACE, NEW_BROKER";
                    // sqlCommand nesnesini oluştur ve sqlConnection nesnesi ile bağla
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    // sqlConnection nesnesini aç
                    sqlConnection.Open();
                    // sqlCommand nesnesini çalıştır
                    sqlCommand.ExecuteNonQuery();
                    // İşlem başarılı olduğunda mesaj göster
                    MessageBox.Show("işlem başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rwindows_radio_CheckedChanged(object sender, EventArgs e)
        {
            Username_txt.Enabled = false; // Kullanıcı adı metin kutusunu devre dışı bırakır
            Password_txt.Enabled = false; 

        }

        private void RSql_radio_CheckedChanged(object sender, EventArgs e)
        {
            Username_txt.Enabled = true; // Kullanıcı adı metin kutusunu etkinleştirir
            Password_txt.Enabled = true; // Şifre metin kutusunu etkinleştirir
        }
    }
    }
