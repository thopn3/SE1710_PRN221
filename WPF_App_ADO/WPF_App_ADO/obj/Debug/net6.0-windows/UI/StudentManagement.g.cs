﻿#pragma checksum "..\..\..\..\UI\StudentManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6B2816B06D922CCABF36BA71EB562E7CE30F1497"
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
using WPF_App_ADO.UI;


namespace WPF_App_ADO.UI {
    
    
    /// <summary>
    /// StudentManagement
    /// </summary>
    public partial class StudentManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMale;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFemale;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDob;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMajor;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkIsMarried;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\UI\StudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvStudents;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_App_ADO;component/ui/studentmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\StudentManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\UI\StudentManagement.xaml"
            ((WPF_App_ADO.UI.StudentManagement)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rbMale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rbFemale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.dpDob = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cbMajor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.chkIsMarried = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.lvStudents = ((System.Windows.Controls.ListView)(target));
            
            #line 78 "..\..\..\..\UI\StudentManagement.xaml"
            this.lvStudents.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvStudents_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

