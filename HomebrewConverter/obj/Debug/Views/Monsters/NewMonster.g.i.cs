﻿#pragma checksum "..\..\..\..\Views\Monsters\NewMonster.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "097885783517F8C5961A01FDF46288FE0DBB5B91"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HomebrewConverter.Views.Monsters;
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


namespace HomebrewConverter.Views.Monsters {
    
    
    /// <summary>
    /// NewMonster
    /// </summary>
    public partial class NewMonster : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSizeComboBox;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrintedValues;
        
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
            System.Uri resourceLocater = new System.Uri("/HomebrewConverter;component/views/monsters/newmonster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Monsters\NewMonster.xaml"
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
            
            #line 10 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((HomebrewConverter.Views.Monsters.NewMonster)(target)).Loaded += new System.Windows.RoutedEventHandler(this.NewMonster_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 70 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MonsterSizeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 78 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSizeComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 85 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.ComboBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 91 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.ComboBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PrintedValues = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

