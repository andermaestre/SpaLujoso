using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Usuario
{
    class Program
    {
        
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);
        
        static void Main(string[] args)
        {
            Mutex m;
            bool nuevo;
            Semaphore s = Semaphore.OpenExisting("semaforotoallar");
            int idmensajecoje = RegisterWindowMessage("WM_COJE");
            int idmensajedeja = RegisterWindowMessage("WM_DEJA");
            int idmensajeentra = RegisterWindowMessage("WM_ENTRA");
            int idmensajesale = RegisterWindowMessage("WM_SALE");

            s.WaitOne();
            Process[] p = Process.GetProcessesByName("SpaLujoso");
            IntPtr hand = p[0].MainWindowHandle;
            PostMessage(hand, idmensajecoje, IntPtr.Zero, IntPtr.Zero);

            m = new Mutex(false, "MutexDucha");
            m.WaitOne();
            PostMessage(hand, idmensajeentra, IntPtr.Zero, IntPtr.Zero);
            DateTime timor = DateTime.Now;
            DateTime exit = timor.AddSeconds(5);
            while (DateTime.Now<exit)
            {
                Console.WriteLine("laralala");
            }
            m.ReleaseMutex();
            PostMessage(hand, idmensajesale, IntPtr.Zero, IntPtr.Zero);
            s.Release();
            PostMessage(hand, idmensajedeja, IntPtr.Zero, IntPtr.Zero);
            
        }
    }
}
