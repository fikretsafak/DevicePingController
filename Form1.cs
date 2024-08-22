using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;
using System.Net;
using System.Timers;

namespace DevicePingController
{
    public partial class Form_Main : Form
    {
        string devInfo;
        string[] tempDevice;
        string tempIP;
        DataTable pingTable = new DataTable();
        List<string> ipAddress = new List<string>();
        List<PictureBox> pictureboxList = new List<PictureBox>();
        private System.Timers.Timer timer;
        public Form_Main()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void FillPingTable()
        {
            pingTable.Columns.Add("ip",typeof(string));
            pingTable.Columns.Add("picturebox ", typeof(string));

            pingTable.Rows.Add();

            for (int i = 0; i < devList.Items.Count;i++)
            {
                pingTable.Rows.Add(devList.Items[i].ToString(), pictureboxList[i]);
            }
        }
        private void DeviceAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devNameLbl.Text) || string.IsNullOrEmpty(DevIPlbl.Text))
                return;
            ListViewItem item = new ListViewItem(devNameLbl.Text);
            item.SubItems.Add(DevIPlbl.Text);
            devList.Items.Add(item);
            devNameLbl.Clear();
            DevIPlbl.Clear();
            dgwFill();

        }

        private void devList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            timer=new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Elapsed += timer_Elapsed;

        }
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void devList_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (devList.Items.Count > 0)
            {
                devList.Items.Remove(devList.SelectedItems[0]);
            }
        }

        private void DeviceExportBtn_Click(object sender, EventArgs e)
        {
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true; // dosya yoksa üret
                save.OverwritePrompt = true; // üzerine yazma uyarısı
                save.Title = "CSV Dosyası";
                save.DefaultExt = "csv";
                save.Filter = "Veri Dosyaları (*.csv)|*.csv|Tüm Dosyalar(*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (false)
                    {
                        // Burada AppandText metodunu kullanmak için FileStream kullandık. Bunun amacı farklı yöntemleri görmenizi istememdir.
                        FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        fs.Close();
                        File.AppendAllText(save.FileName, Environment.NewLine);
                    }
                    else
                    {
                        if (File.Exists(save.FileName))
                        {
                            StreamReader Oku = new StreamReader(save.FileName);
                            string okunan = Oku.ReadToEnd();
                            Oku.Close();
                            if (okunan.Trim() != string.Empty)
                            {
                                switch (MessageBox.Show("Seçtiğiniz belge boş değil. Üzerine yazmak istiyorsanız -EVET-, ekrana getirmek istiyorsanız -HAYIR-, işlemi iptal etmek istiyorsanız -VAZGEÇ-'i seçin"
                                , "İşlem Seçin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                                {
                                    case DialogResult.Cancel:
                                        break;
                                    case DialogResult.Yes:
                                        StreamWriter sw = new StreamWriter(save.FileName, true);
                                        for (int i = 0; i < devList.Items.Count; i++)
                                        {
                                            sw.WriteLine(devList.Items[i].Text.ToString() + ";" + devList.Items[i].SubItems[1].Text.ToString());
                                        }
                                        sw.Close();
                                        MessageBox.Show("Device exported.");
                                        break;
                                    case DialogResult.No:

                                        break;
                                }
                            }
                        }
                        else
                        {
                            StreamWriter sw = new StreamWriter(save.FileName, true);
                            for (int i = 0; i < devList.Items.Count; i++)
                            {
                                sw.WriteLine(devList.Items[i].Text.ToString() + ";" + devList.Items[i].SubItems[1].Text.ToString());
                            }
                            sw.Close();
                             MessageBox.Show("Device exported.");
                    }
                    }
                }


            
        }

        private void DeviceImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Metin Dosyası Seçiniz..";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(file.FileName);
                devList.Items.Clear();
                while (sr.EndOfStream==false)
                {
                    string line = sr.ReadLine();
                    tempDevice = line.Split(';');
                    ListViewItem item = new ListViewItem(tempDevice[0]);
                    item.SubItems.Add(tempDevice[1]);
                    devList.Items.Add(item);
                }
                sr.Close();
                dgwFill();
                MessageBox.Show("Device imported.");
            }
        }

        private void dgwFill()
        {
            pingStatDGW.Rows.Clear();
            for (int i = 0; i < devList.Items.Count; i++)
            {
                pingStatDGW.Rows.Add();
                pingStatDGW.Rows[i].Cells[0].Value = devList.Items[i].SubItems[0].Text;
                pingStatDGW.Rows[i].Cells[1].Value = devList.Items[i].SubItems[1].Text;
                // pingStatDGW.Rows[i].Cells[2].Value = false;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                Parallel.For(0, devList.Items.Count, (i, loopState) =>
                {
                    Ping ping = new Ping();
                    PingReply pingReply = ping.Send(pingStatDGW.Rows[i].Cells[1].ToString());
                    this.BeginInvoke((Action)delegate ()
                    {
                        if (pingReply.Status == IPStatus.Success)
                        {
                            pingStatDGW.Rows[i].Cells[1].Value = "Succesful";
                        }
                        else
                        {
                            pingStatDGW.Rows[i].Cells[2].Value = "Not Pinged";
                        }

                    });
                });



            }
            catch (Exception)
            {

            }
        }
    }
}
