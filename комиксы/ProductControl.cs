using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace комиксы
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
            AttachEventToAllControls(this, OpenApartamentClickHandler);
        }
        public void DisableClick()
        {
            DetachEventFromAllControls(this, OpenApartamentClickHandler);
        }
        private long pId;
        public void SetProductInfo(byte[] mainPhoto, string name, long productId)
        {
            pId = productId;

            label6.Text = name;
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
            long apId = pId;
            картат apartamentPage = new картат(apId);
            apartamentPage.Show();
        }


    }
}
