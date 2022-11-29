using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WS.VisualizationUI.Model;

namespace WS.VisualizationUI.Code
{
    internal class SignalRClient
    {
        private HubConnection connection;
        private Form1 _form;
        public SignalRClient()
        {
            //_form = form;
            connection = new HubConnectionBuilder()
                .WithUrl(new Uri("https://localhost:7046/visualizationHub"), options =>
                {
                    options.HttpMessageHandlerFactory = handler =>
                    {
                        if (handler is HttpClientHandler clientHandler)
                        {
                            clientHandler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, certChain, policyError) =>
                            {
                                bool result = false;
                                X509Store store = new X509Store(StoreName.Root);
                                store.Open(OpenFlags.ReadOnly);
                                X509Certificate2Collection cc = store.Certificates.Find(X509FindType.FindByThumbprint,
                                     certChain.ChainElements[certChain.ChainElements.Count - 1].Certificate.Thumbprint, true);
                                store.Close();
                                if (cc.Count > 0)
                                {
                                    result = true;
                                }
                                return result;
                            };
                        }
                        return handler;
                    };
                    options.WebSocketConfiguration = socket =>
                    {
                        socket.RemoteCertificateValidationCallback = (httpRequestMessage, cert, certChain, policyError) =>
                        {
                            bool result = false;
                            X509Store store = new X509Store(StoreName.Root);
                            store.Open(OpenFlags.ReadOnly);
                            X509Certificate2Collection cc = store.Certificates.Find(X509FindType.FindByThumbprint,
                                 certChain.ChainElements[certChain.ChainElements.Count - 1].Certificate.Thumbprint, true);
                            store.Close();
                            if (cc.Count > 0)
                            {
                                result = true;
                            }
                            return result;
                        };
                    };
                }).Build();

            connection.Closed += async (error) =>
            {
                if (Program.form != null)
                    Program.form.SetResult(0);
                await Start();
            };
            connection.HandshakeTimeout = TimeSpan.FromMilliseconds(5000);
            connection.On("getName", () => {
                returnName();
            });
        }

        private async void returnName()
        {
            bool result = await connection.InvokeAsync<bool>("AddWithName", "VisualizationUI");
            if (!result)
            {
                if (Program.form != null)
                    Program.form.SetResult(1);
                await connection.StopAsync();
            }

        }

        public async Task Start()
        {
            while (true)
            {
                try
                {
                    await connection.StartAsync();
                    if(Program.form != null)
                        Program.form.SetResult(1);
                    return;
                }
                catch(Exception ex)
                {
                    if (Program.form != null)
                        Program.form.SetResult(0);
                    await Task.Delay(10000);
                }
            }
        }

        public async Task<int> CreateGlass(string serialNum)
        {
            int result = await connection.InvokeAsync<int>("CreateGlass", serialNum);
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        public async Task<int> VisualGlass(string serialNum)
        {
            int result = await connection.InvokeAsync<int>("VisualGlass", serialNum);
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        public async Task<int> SendPackNumber(string packNumber)
        {
            int result = await connection.InvokeAsync<int>("SendPackNumber", packNumber);
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        public async Task<int> SendCode(string code)
        {
            int result = await connection.InvokeAsync<int>("SendCode", code);
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        public async Task<int> SendDeformation(Coordination coordination)
        {
            int result = await connection.InvokeAsync<int>("SendDeformation", coordination);
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        internal async Task<int> DeleteLastDeformation()
        {
            int result = await connection.InvokeAsync<int>("DeleteLastDeformation");
            if (result == 0)
            {
                await connection.StopAsync();
            }
            return result;
        }

        internal bool IsConnected()
        {
            return connection.State == HubConnectionState.Connected;
        }
    }
}
