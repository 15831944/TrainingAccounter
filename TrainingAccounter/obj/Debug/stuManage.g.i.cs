﻿#pragma checksum "..\..\stuManage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D7C41265A9E220470FD55A647CF7EA6"
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
using TrainingControl;


namespace TrainingAccounter {
    
    
    /// <summary>
    /// stuManage
    /// </summary>
    public partial class stuManage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPidNo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtFrom;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label15;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtTo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label14;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxSerDrv;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchTrainee;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTrainee;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSearchTrainee;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\stuManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu dgStuMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/TrainingAccounter;component/stumanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\stuManage.xaml"
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
            this.txbPidNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dtFrom = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\stuManage.xaml"
            this.dtFrom.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dtFrom_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label15 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.dtTo = ((System.Windows.Controls.DatePicker)(target));
            
            #line 24 "..\..\stuManage.xaml"
            this.dtTo.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dtTo_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label14 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cboxSerDrv = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnSearchTrainee = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\stuManage.xaml"
            this.btnSearchTrainee.Click += new System.Windows.RoutedEventHandler(this.btnSearchTrainee_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddTrainee = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\stuManage.xaml"
            this.btnAddTrainee.Click += new System.Windows.RoutedEventHandler(this.btnAddTrainee_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgSearchTrainee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\stuManage.xaml"
            this.dgSearchTrainee.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgSearchTrainee_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgStuMenu = ((System.Windows.Controls.ContextMenu)(target));
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
            case 12:
            
            #line 69 "..\..\stuManage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeposit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

