using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace комиксы
{
    public partial class BasketContorll : UserControl
    {
        public BasketContorll()
        {
            InitializeComponent();
        }
        public void DisableClick()
        {
            DetachEventFromAllControls(this, OpenApartamentClickHandler);
        }
        private long productId;
        public void SetProductInfo(byte[] mainPhoto, string name, int price, long productid)
        {
            productId = productid;
       
            label3.Text = name;
            label6.Text = price.ToString();
            using (MemoryStream ms = new MemoryStream(mainPhoto))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }

        }

        

        private void AttachEventToAllControls(Control control, EventHandler eventHandler)
        {
            foreach (Control ctrl in control.Controls)
            {
                AttachEventToAllControls(ctrl, eventHandler);
                ctrl.Click += eventHandler;
            }
        }

        private void DetachEventFromAllControls(Control control, EventHandler eventHandler)
        {
            foreach (Control ctrl in control.Controls)
            {
                DetachEventFromAllControls(ctrl, eventHandler);
                ctrl.Click -= eventHandler;
            }
        }

        private void OpenApartamentClickHandler(object sender, EventArgs e)
        {
            картат apartamentPage = new картат(productId);
            apartamentPage.Show();
        }

        
    }
}
