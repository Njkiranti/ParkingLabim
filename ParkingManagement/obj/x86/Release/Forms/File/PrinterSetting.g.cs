﻿#pragma checksum "..\..\..\..\..\Forms\File\PrinterSetting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DE6C85331F35835A7189F2DC97FE3D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ParkingManagement.Forms.File {
    
    
    /// <summary>
    /// PrinterSetting
    /// </summary>
    public partial class PrinterSetting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPrinter;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrinterProps;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStatus;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtType;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtWhere;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtComment;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ParkingManagement;component/forms/file/printersetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbPrinter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
            this.cmbPrinter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbPrinter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPrinterProps = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
            this.btnPrinterProps.Click += new System.Windows.RoutedEventHandler(this.btnPrinterProps_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtWhere = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtComment = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 41 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 42 "..\..\..\..\..\Forms\File\PrinterSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

