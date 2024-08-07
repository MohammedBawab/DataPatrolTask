using RandomNumberApp.Helpers;
using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandomNumberApp
{
    public partial class Main : Form
    {
        private APIClient apiClient;
        private Thread thread;

        public Main()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            apiClient = new APIClient(tb_APIURL.Text, lv_Listeners);
            thread = new Thread(new ThreadStart(apiClient.Start));
            thread.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            apiClient.Stop();
            thread.Join();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var listener = new Listener(lv_Listeners.Items.Count + 1);
            apiClient.Register(listener);
            lv_Listeners.Items.Add(new ListViewItem(new string[] { listener.Id.ToString(), listener.Name, listener.TargetNumber.ToString(), listener.Counter.ToString() }));
        }

        private void btn_Unregister_Click(object sender, EventArgs e)
        {
            if (lv_Listeners.SelectedItems.Count > 0)
            {
                var selectedItem = lv_Listeners.SelectedItems[0];
                int listenerId = int.Parse(selectedItem.SubItems[0].Text);
                apiClient.Unregister(listenerId);
                lv_Listeners.Items.Remove(selectedItem);
            }
        }
    }
}