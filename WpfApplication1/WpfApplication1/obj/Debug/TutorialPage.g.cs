﻿#pragma checksum "..\..\TutorialPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "459879FC9676AE799EE43D5BDD8F3F36"
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// TutorialPage
    /// </summary>
    public partial class TutorialPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Content;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PageTitle;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fave1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fave2;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fave3;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fave4;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fave5;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\TutorialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/tutorialpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TutorialPage.xaml"
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
            this.Content = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.PageTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\TutorialPage.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TutorialPage.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Fave1 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\TutorialPage.xaml"
            this.Fave1.Click += new System.Windows.RoutedEventHandler(this.whiteRussianFave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Fave2 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\TutorialPage.xaml"
            this.Fave2.Click += new System.Windows.RoutedEventHandler(this.tequilaSunriseFave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Fave3 = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\TutorialPage.xaml"
            this.Fave3.Click += new System.Windows.RoutedEventHandler(this.mojitoFave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Fave4 = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\TutorialPage.xaml"
            this.Fave4.Click += new System.Windows.RoutedEventHandler(this.cubaLibreFave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Fave5 = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\TutorialPage.xaml"
            this.Fave5.Click += new System.Windows.RoutedEventHandler(this.margaritaFave_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

