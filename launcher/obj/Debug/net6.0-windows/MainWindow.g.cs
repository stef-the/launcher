﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9A81E7BE35CC249F79AB5244E367856B8DA2418"
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
using launcher;


namespace launcher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_play;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_mods;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_leaderboard;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_settings;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RiftArt;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.BlurEffect blur;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ModTitle;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ModBox;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddModBtn;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelModBtn;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RestoreGameBtn;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ModProgress;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label modProgressLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/launcher;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbl_play = ((System.Windows.Controls.Label)(target));
            
            #line 11 "..\..\..\MainWindow.xaml"
            this.lbl_play.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbl_play_MouseDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\MainWindow.xaml"
            this.lbl_play.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbl_play_MouseEnter);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\MainWindow.xaml"
            this.lbl_play.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbl_play_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl_mods = ((System.Windows.Controls.Label)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.lbl_mods.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbl_mods_MouseDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.lbl_mods.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbl_mods_MouseEnter);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.lbl_mods.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbl_mods_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbl_leaderboard = ((System.Windows.Controls.Label)(target));
            
            #line 49 "..\..\..\MainWindow.xaml"
            this.lbl_leaderboard.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbl_leaderboard_MouseDown);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow.xaml"
            this.lbl_leaderboard.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbl_leaderboard_MouseEnter);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow.xaml"
            this.lbl_leaderboard.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbl_leaderboard_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbl_settings = ((System.Windows.Controls.Label)(target));
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.lbl_settings.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbl_settings_MouseDown);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.lbl_settings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbl_settings_MouseLeave);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.lbl_settings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbl_settings_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RiftArt = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.blur = ((System.Windows.Media.Effects.BlurEffect)(target));
            return;
            case 7:
            this.ModTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ModBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.AddModBtn = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.AddModBtn.Click += new System.Windows.RoutedEventHandler(this.AddModBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DelModBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.RestoreGameBtn = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\MainWindow.xaml"
            this.RestoreGameBtn.Click += new System.Windows.RoutedEventHandler(this.RestoreGameBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ModProgress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 13:
            this.modProgressLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

