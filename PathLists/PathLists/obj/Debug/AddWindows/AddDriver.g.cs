﻿#pragma checksum "..\..\..\AddWindows\AddDriver.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A3CB532EAA611FC7F570BCA301681011D31883CE2847E67DE5EC7386A9C3161"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PathLists.AddWindows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace PathLists.AddWindows {
    
    
    /// <summary>
    /// AddDriver
    /// </summary>
    public partial class AddDriver : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passbox_1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passbox_2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSurname;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPatronymic;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AddWindows\AddDriver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDriveLicense;
        
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
            System.Uri resourceLocater = new System.Uri("/PathLists;component/addwindows/adddriver.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddWindows\AddDriver.xaml"
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
            this.TextBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passbox_1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.passbox_2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.TextBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBoxDriveLicense = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 26 "..\..\..\AddWindows\AddDriver.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Reg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

