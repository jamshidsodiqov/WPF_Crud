﻿#pragma checksum "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7734ACE26B59211A68787B880174491CAE93DC57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ADOCrud.Pages.Delete;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ADOCrud.Pages.Delete {
    
    
    /// <summary>
    /// DeleteSelectPage
    /// </summary>
    public partial class DeleteSelectPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletecourse_btn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletestudent_btn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteteacher_btn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitcreate_btn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame deleteFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ADOCrud;component/pages/delete/deleteselectpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.deletecourse_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
            this.deletecourse_btn.Click += new System.Windows.RoutedEventHandler(this.deletecourse_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.deletestudent_btn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
            this.deletestudent_btn.Click += new System.Windows.RoutedEventHandler(this.deletestudent_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteteacher_btn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
            this.deleteteacher_btn.Click += new System.Windows.RoutedEventHandler(this.deleteteacher_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exitcreate_btn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\Pages\Delete\DeleteSelectPage.xaml"
            this.exitcreate_btn.Click += new System.Windows.RoutedEventHandler(this.exitbtn_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

