using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignatureCaptureFroms
{
    public partial class Form1 : Form
    {

       
        SignatureControl signature = new SignatureControl();
        public Form1()
        {
            InitializeComponent();
            signature.Location = areaSignature.Location;
            signature.Size = areaSignature.Size;
            signature.Background = @"D:\SignatureCaptureFroms\SignatureCaptureFroms\Images\sign here.png";
            this.Controls.Add(signature);
        }

        

        private void butNew_Click(object sender, EventArgs e)
        {
            signature.Clear();
            this.Refresh();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            int baseX = 10;
            int baseY = 100;
            string signatureFile = "SignFile.txt";
            load_signature(baseX, baseY, signatureFile);
        }
        void load_signature(int baseX, int baseY, string signatureFile)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("SignFile.txt");
            string pointString = null;

            while ((pointString = streamReader.ReadLine()) != null)
            {
                if (pointString.Trim().Length > 0)
                {
                    String[] points = new String[4];
                    points = pointString.Split(new Char[] { ' ' });
                    Pen pen = new Pen(Color.Black);
                    this.CreateGraphics().DrawLine(pen, (baseX + int.Parse(points[0].ToString())), (baseY + int.Parse(points[1].ToString())), (baseX + int.Parse(points[2].ToString())), (baseY + int.Parse(points[3].ToString())));
                }
            }
            streamReader.Close();
        }
        private void areaSignature_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            signature.StoreSigData("SignFile.txt");
        }
    }
}
