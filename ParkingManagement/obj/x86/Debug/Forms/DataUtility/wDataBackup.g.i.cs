﻿#pragma checksum "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BCDB2C14A06F439885269A75F3EC0CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace ParkingManagement.Forms.DataUtility {
    
    
    /// <summary>
    /// wDataBackup
    /// </summary>
    public partial class wDataBackup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFullBackup;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbTranLog;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDirectory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFile;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtExt;
        
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
            System.Uri resourceLocater = new System.Uri("/ParkingManagement;component/forms/datautility/wdatabackup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
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
            this.rbFullBackup = ((System.Windows.Controls.RadioButton)(target));
            
            #line 9 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
            this.rbFullBackup.Checked += new System.Windows.RoutedEventHandler(this.rbFullBackup_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rbTranLog = ((System.Windows.Controls.RadioButton)(target));
            
            #line 10 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
            this.rbTranLog.Checked += new System.Windows.RoutedEventHandler(this.rbTranLog_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtDirectory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 18 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtFile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtExt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 28 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 29 "..\..\..\..\..\Forms\DataUtility\wDataBackup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

