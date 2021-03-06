﻿#region

using System;
using System.Runtime.InteropServices;
using Tabster.Core.Plugins;
using Tabster.Core.Types;

#endregion

namespace PdfFile
{
    public class PdfFilePlugin : ITabsterPlugin
    {
        #region Implementation of ITabsterPluginAttributes

        public string Author
        {
            get { return "Nate Shoffner"; }
        }

        public string Copyright
        {
            get { return "Copyright © Nate Shoffner 2016"; }
        }

        public string Description
        {
            get { return "Supports importing and exporting to/from PDF files."; }
        }

        public string DisplayName
        {
            get { return "PDFFile"; }
        }

        public TabsterVersion Version
        {
            get { return new TabsterVersion("1.0"); }
        }

        public Uri Website
        {
            get { return new Uri("http://nateshoffner.com"); }
        }

        public Guid Guid
        {
            get { return new Guid(((GuidAttribute) typeof (PdfFilePlugin).Assembly.GetCustomAttributes(typeof (GuidAttribute), true)[0]).Value); }
        }

        public void Activate()
        {
            // not implemented
        }

        public void Deactivate()
        {
            // not implemented
        }

        public void Initialize()
        {
            // not implemented
        }

        #endregion
    }
}