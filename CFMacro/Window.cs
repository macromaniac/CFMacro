using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace CFMacro
{
    public delegate void UpdateChartCallback( System.IO.MemoryStream memoryStream);
    public delegate void GetStockInfo(string stockInfo);
    public partial class Window : Form
    {
        private DataManager dataManager;

        public Window()
        {
            InitializeComponent();
            dataManager = new DataManager(updateChart, updateStockInfo);
        }

        public void updateChart(System.IO.MemoryStream memoryStream) {
            pictureBox.Image = System.Drawing.Image.FromStream(memoryStream);
        }

        public void updateStockInfo(string stockInfo) {
            lastTradePriceText.Text = stockInfo;
        }
        private void GUITick_Tick(object sender, EventArgs e) {

        }
    }
}
