﻿#pragma checksum "B:\workspace\placity\platforms\wp8\Plugins\phonegap-plugin-barcodescanner\BarcodeScannerUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0333FDB700E34FC03066BB5BD3A05759"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WPCordovaClassLib.Cordova.Commands {
    
    
    public partial class BarcodeScannerUI : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas CameraCanvas;
        
        internal System.Windows.Media.VideoBrush CameraBrush;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/io.cordova.placity;component/Plugins/phonegap-plugin-barcodescanner/BarcodeScann" +
                        "erUI.xaml", System.UriKind.Relative));
            this.CameraCanvas = ((System.Windows.Controls.Canvas)(this.FindName("CameraCanvas")));
            this.CameraBrush = ((System.Windows.Media.VideoBrush)(this.FindName("CameraBrush")));
        }
    }
}

