﻿#pragma checksum "..\..\rechargeManage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A1EAFA1FAEFC5A20F233D91F78935A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace TrainingAccounter {
    
    
    /// <summary>
    /// rechargeManage
    /// </summary>
    public partial class rechargeManage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSerPidNo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerSerStr;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label15;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerSerEnd;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label14;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxDevName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSerSerch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\rechargeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridFinace;
        
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
            System.Uri resourceLocater = new System.Uri("/TrainingAccounter;component/rechargemanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\rechargeManage.xaml"
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
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tbxSerPidNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datePickerSerStr = ((System.Windows.Controls.DatePicker)(target));
            
            #line 20 "..\..\rechargeManage.xaml"
            this.datePickerSerStr.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datePickerSerStr_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label15 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.datePickerSerEnd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 23 "..\..\rechargeManage.xaml"
            this.datePickerSerEnd.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datePickerSerEnd_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label14 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbxDevName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnSerSerch = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\rechargeManage.xaml"
            this.btnSerSerch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridFinace = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\rechargeManage.xaml"
            this.dataGridFinace.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGridFinace_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 50 "..\..\rechargeManage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeposit_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 57 "..\..\rechargeManage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDepositSer_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

