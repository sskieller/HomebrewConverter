﻿#pragma checksum "..\..\..\..\Views\Monsters\NewMonster.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ECBED1D86D7BD9082B2EB2FDFEE9995A794191C2"
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
        
        
        #line 63 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSizeComboBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterAlignmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSkill1ComboBox;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSkill2ComboBox;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSkill3ComboBox;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\..\Views\Monsters\NewMonster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterSkill4ComboBox;
        
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
            
            #line 58 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MonsterSizeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSizeComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MonsterTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterTypeComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MonsterAlignmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 78 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterAlignmentComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 84 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 89 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 91 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 91 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 96 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 101 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 102 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 104 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 112 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 122 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 126 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 126 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 132 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 135 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 142 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 146 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 146 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 152 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 155 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 156 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 156 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 162 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UIElement_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 165 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBase_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 166 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxTitle_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 166 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_OnGotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 18:
            this.MonsterSkill1ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 215 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSkill1ComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 19:
            this.MonsterSkill2ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 221 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSkill2ComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 20:
            this.MonsterSkill3ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 227 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSkill3ComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 21:
            this.MonsterSkill4ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 233 "..\..\..\..\Views\Monsters\NewMonster.xaml"
            this.MonsterSkill4ComboBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ComboBox_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

