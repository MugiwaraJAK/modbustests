using System;
using HIES.IJP.RX;

namespace ModbusPOC.Library
{
    //TODO: refactor
    public class PrinterClient
    {
        private IJP _ijp;
        private readonly string _printerName;

        public PrinterClient(string printerName, string ip, string port)
        {
            _ijp = new IJP();
            _ijp.IPAddress = ip;
            _ijp.PortNumber = ushort.Parse(port);
            _printerName = printerName;
        }

        //todo async
        public bool SendMessage(string content)
        {
            try
            {
                //1. Setup IJP Connection
                _ijp.Connect();
                _ijp.SetComPort(IJPOnlineStatus.Online);
                
                var message = new IJPMessage();

                try
                {
                    _ijp.SetMessage(message);
                    var msgInfo = new IJPMessageInfo(1, 1, message.Nickname);
                    _ijp.SaveMessage(msgInfo);
                }
                catch (Exception ex) //we can also catch specific-ijp error and analysis info as well
                {
                    Console.WriteLine(ex);//log

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);//log the error
            }
            finally
            {
                try
                {
                    _ijp.SetComPort(IJPOnlineStatus.Offline);
                }
                catch { }
                _ijp.Disconnect();
            }



            //TODO
            return true;
        }
    }

}
