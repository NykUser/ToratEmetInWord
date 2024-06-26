﻿#pragma checksum "..\..\..\Controls\OpenFileControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30D29EA35FE3C1ACA80832C9694C18D74494FA7F04CC146E35066270FE9F4680"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Emoji.Wpf;
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
using ToratEmet.Controls;
using ToratEmet.TreeModels;


namespace ToratEmet.Controls {
    
    
    /// <summary>
    /// OpenFileControl
    /// </summary>
    public partial class OpenFileControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 45 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SearchComboBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RecentSearchesCombo;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RecentSearchesButton;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView;
        
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
            System.Uri resourceLocater = new System.Uri("/ToratEmet;component/controls/openfilecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\OpenFileControl.xaml"
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
            this.SearchComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\Controls\OpenFileControl.xaml"
            this.SearchComboBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchComboBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\Controls\OpenFileControl.xaml"
            this.SearchTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 75 "..\..\..\Controls\OpenFileControl.xaml"
            this.SearchTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.SearchTextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RecentSearchesCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 83 "..\..\..\Controls\OpenFileControl.xaml"
            this.RecentSearchesCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecentSearchesCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Controls\OpenFileControl.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RecentSearchesButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Controls\OpenFileControl.xaml"
            this.RecentSearchesButton.Click += new System.Windows.RoutedEventHandler(this.RecentSearchesButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.treeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 101 "..\..\..\Controls\OpenFileControl.xaml"
            this.treeView.KeyDown += new System.Windows.Input.KeyEventHandler(this.treeView_KeyDown);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\Controls\OpenFileControl.xaml"
            this.treeView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.treeView_MouseDoubleClick);
            
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            
            #line 52 "..\..\..\Controls\OpenFileControl.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ItemPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseDownEvent;
            
            #line 62 "..\..\..\Controls\OpenFileControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.SearchComboBoxItem_PreviewMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

