﻿#pragma checksum "..\..\..\Pages\RoutingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "081A6A682503EBE78D08F549C2529E0A10E4FF6AF186D3CB6015522EB491F25F"
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
using маршрутизация_событий.Pages;


namespace маршрутизация_событий.Pages {
    
    
    /// <summary>
    /// RoutingPage
    /// </summary>
    public partial class RoutingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\RoutingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RedRectangle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\RoutingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTop;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\RoutingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse RedEllipce;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\RoutingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockBottom;
        
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
            System.Uri resourceLocater = new System.Uri("/маршрутизация событий;component/pages/routingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RoutingPage.xaml"
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
            
            #line 13 "..\..\..\Pages\RoutingPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\Pages\RoutingPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Pages\RoutingPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RedRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 16 "..\..\..\Pages\RoutingPage.xaml"
            this.RedRectangle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBlockTop = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 29 "..\..\..\Pages\RoutingPage.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDownPreview);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 30 "..\..\..\Pages\RoutingPage.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDownPreview);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RedEllipce = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 31 "..\..\..\Pages\RoutingPage.xaml"
            this.RedEllipce.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDownPreview);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBlockBottom = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

