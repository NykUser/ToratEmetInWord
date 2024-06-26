﻿#pragma checksum "..\..\..\Controls\AramaicDictionaryControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49B60725FF9BAACF19D43FEA3013E075D0F64A77967D60A00D233C676A9D61C6"
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


namespace ToratEmet.Controls {
    
    
    /// <summary>
    /// AramaicDictionaryControl
    /// </summary>
    public partial class AramaicDictionaryControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\Controls\AramaicDictionaryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Controls\AramaicDictionaryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton AramaicToHebrew;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Controls\AramaicDictionaryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton HebrewtoAramaic;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Controls\AramaicDictionaryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SuggestionsBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Controls\AramaicDictionaryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ToratEmet.Controls.WebViewControl ResultsWebView;
        
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
            System.Uri resourceLocater = new System.Uri("/ToratEmet;component/controls/aramaicdictionarycontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AramaicToHebrew = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 36 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            this.AramaicToHebrew.Checked += new System.Windows.RoutedEventHandler(this.AramaicToHebrew_CheckedChange);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            this.AramaicToHebrew.Unchecked += new System.Windows.RoutedEventHandler(this.AramaicToHebrew_CheckedChange);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HebrewtoAramaic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 42 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            this.HebrewtoAramaic.Checked += new System.Windows.RoutedEventHandler(this.HebrewtoAramaic_CheckedChange);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            this.HebrewtoAramaic.Unchecked += new System.Windows.RoutedEventHandler(this.HebrewtoAramaic_CheckedChange);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SuggestionsBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ResultsWebView = ((ToratEmet.Controls.WebViewControl)(target));
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
            case 5:
            
            #line 70 "..\..\..\Controls\AramaicDictionaryControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SuggestionTextBlock_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

