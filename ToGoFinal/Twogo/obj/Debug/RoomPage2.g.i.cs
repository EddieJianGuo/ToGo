﻿#pragma checksum "..\..\RoomPage2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E467D73CF8403BBC984A0790B6F5C6FB41957C70"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
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
using ToGo;


namespace ToGo {
    
    
    /// <summary>
    /// RoomPage2
    /// </summary>
    public partial class RoomPage2 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SmallGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QuantityComeBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cancellabel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HotelNameRoomPage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomNameRoomPage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\RoomPage2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomIDRoomPage;
        
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
            System.Uri resourceLocater = new System.Uri("/ToGo;component/roompage2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RoomPage2.xaml"
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
            this.SmallGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Buy = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\RoomPage2.xaml"
            this.Buy.Click += new System.Windows.RoutedEventHandler(this.Buy_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuantityComeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.RoomUnitPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.RoomName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            
            #line 38 "..\..\RoomPage2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancellabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.HotelNameRoomPage = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.RoomNameRoomPage = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.RoomIDRoomPage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

