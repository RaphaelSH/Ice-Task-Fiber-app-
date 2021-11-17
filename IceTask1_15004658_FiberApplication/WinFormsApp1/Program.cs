using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class IceTask1_15004658_FiberApplication
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Customer
    {
        private string strID, strName, strAddress, strContact, strInstaller;
        private double dblSpeed;
        private Boolean blCovered;

        public Customer()
        {
            strID = "";
            strName = "";
            strAddress = "";
            strContact = "";
            strInstaller = "";
            dblSpeed = 0.0;
            blCovered = false;
        }
        public Customer(string id, string name, string address, string contact, string installer, double speed, Boolean covered)
        {
            strID = id;
            strName = name;
            strAddress = address;
            strContact = contact;
            strInstaller = installer;
            dblSpeed = speed;
            blCovered = covered;
        }

        public override string ToString()
        {
            return "On hold";
        }
    }
