﻿#pragma checksum "..\..\..\..\View\Pages\Page_addAccount.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6606702BADD406AF867801C6A73E767A25C35DCAEB78C6393BEFC5DEA50B4DF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using home_accounting.View.Pages;


namespace home_accounting.View.Pages {
    
    
    /// <summary>
    /// Page_addAccount
    /// </summary>
    public partial class Page_addAccount : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepick;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox select_type;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox select_category;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox summa;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comm;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\View\Pages\Page_addAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
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
            System.Uri resourceLocater = new System.Uri("/home_accounting;component/view/pages/page_addaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\Page_addAccount.xaml"
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
            this.datepick = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.select_type = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\..\View\Pages\Page_addAccount.xaml"
            this.select_type.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.select_type_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.select_category = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.summa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.comm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\View\Pages\Page_addAccount.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.btn_back_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\View\Pages\Page_addAccount.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

