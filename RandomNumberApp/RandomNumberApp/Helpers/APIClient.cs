using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using RandomNumberApp.Models;
using System.Linq;
using System.Windows.Forms;

namespace RandomNumberApp.Helpers
{
    public class APIClient
    {
        private string _apiURL;
        private HttpClient _client;
        private List<Listener> _listeners;
        private bool working;
        private ListView _listViewControl;

        public APIClient(string apiURL, ListView listViewControl)
        {
            _apiURL = apiURL;
            _client = new HttpClient();
            _listeners = new List<Listener>();
            _listViewControl = listViewControl;
        }

        private async Task CallApi()
        {
            var response = await _client.GetStringAsync(_apiURL);
            ApiResult result = JsonSerializer.Deserialize<ApiResult>(response);

            foreach (var listener in _listeners)
            {
                listener.Count(result.data.number);

                UpdateListViewHelper.ControlInvoke(_listViewControl, () =>
                {
                    var item = _listViewControl.FindItemWithText(listener.Id.ToString(), true, 0);

                    _listViewControl.Items.Remove(item);

                    _listViewControl.Items.Add(new ListViewItem(new string[] { listener.Id.ToString(), listener.Name, listener.TargetNumber.ToString(), listener.Counter.ToString() }));
                });
            }
        }

        public void Start()
        {
            working = true;
            while (working)
            {
                Task.Run(async () => await CallApi());
                Thread.Sleep(10000);
            }
        }

        public void Stop()
        {
            working = false;
        }

        public void Register(Listener listener)
        {
            _listeners.Add(listener);
        }

        public void Unregister(int listenerId)
        {
            var listener = _listeners.FirstOrDefault(l => l.Id == listenerId);
            if (listener != null)
            {
                _listeners.Remove(listener);
            }
        }
    }
}