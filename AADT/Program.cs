using LibSVMsharp;
using LibSVMsharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Text.RegularExpressions;
using LibSVMsharp.Extensions;
using System.Windows.Forms;

namespace AADT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AADTForm());
            Label label = new Label();
        }
    }
}

