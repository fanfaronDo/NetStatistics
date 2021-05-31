using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NetStateSpeed
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private const double timerUpdate = 1000;
        private TraficModel trafic = new TraficModel();
        private static Producer producer = new Producer();
        private string urlServ = producer.urlProduserServer;
        private string host = producer.hostProduser;

        InitializeNetworkInterface initializeNetworkInterface = new InitializeNetworkInterface();



        public Form1()
        {
            InitializeComponent();
            initializeNetworkInterface.InitializAllInterface(cmbInterface);
            RunTimer();

        }

        public void RunTimer()
        {

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            DataOutput();
        }


        private void DataOutput()
        {
            var translate = new DataTranslation();

            var upData = new GetValueNetworkInterface();

            upData.UpdateNetworkInterface(cmbInterface, trafic);

            lblInterfaceType.Text = trafic.nameInterface;

            lblSpeed.Text = trafic.SpeedInterface.ToString();

            lblBytesReceived.Text = trafic.bytesReceived.ToString();

            lblBytesSent.Text = trafic.bytesSent.ToString();

            lblUpload.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesSentSpeedCurrent);

            lblDownload.Text = translate.ValueTranslate(cmbTranslateData, trafic.bytesReceivedSpeedCurrent);

            lblDownloadInSec.Text = translate.ValueTranslate(cmbTranslateData, trafic.downloadBytes).ToString();

            lblUploadInSec.Text = translate.ValueTranslate(cmbTranslateData, trafic.uploadBytes).ToString();

        }

       


        private async void GenerationData()
        {
            var repeat = 4;
            var bandwidthCalculation = new BandwidthCalculation();
            var resSpeed = 0.0;
            try
            {
               await Task.Run(() =>
                {
                    

                    for (int i = 0; i < repeat; i++)
                    {
                        resSpeed = bandwidthCalculation.GetDownloadSpeed(trafic);
                        trafic.downloadBytes = resSpeed;

                        trafic.MeasurementsSpeedReceived.Add(resSpeed);
                        resSpeed = 0.0;

                    }
                    trafic.MeasurementsSpeedAvgReceived = trafic.MeasurementsSpeedReceived.Average();

                    trafic.downloadBytes = trafic.MeasurementsSpeedAvgReceived;

                    for (int i = 0; i < repeat; i++) 
                    {
                        resSpeed = bandwidthCalculation.GetUploadSpeed(trafic);
                        trafic.uploadBytes = resSpeed;

                        trafic.MeasurementsSpeedSent.Add(resSpeed);
                        resSpeed = 0.0;
                    }
                    trafic.MeasurementsSpeedAvgSent = trafic.MeasurementsSpeedSent.Average();

                    trafic.uploadBytes = trafic.MeasurementsSpeedAvgSent;

                });

            }
            catch (Exception ex) 
            {
                lblError.Text = ex.Message.ToString();
            }
                
        }

        private void CheckPing()
        {
            try
            {
                var ping = new CheckPacketDelay();
                var rez = ping.CheckPing(host);
                checkPing.Text = rez.ToString() + " ms";

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }



        private void buttonCheckSpeed_Click(object sender, EventArgs e)
        {
            trafic.controller = true;

            GenerationData();

            CheckPing();

            trafic.controller = false;
        }

        


        private void lblBytesReceived_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBytesSent_Click(object sender, EventArgs e)
        {

        }

        private void cmbTranslateData_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
