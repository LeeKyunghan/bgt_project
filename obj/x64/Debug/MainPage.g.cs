﻿#pragma checksum "D:\Project\Project_bgt\BGTviewer-2020.10.07\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8212B74D779AEC6ED546F1A142B0935E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BGTviewer
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(global::Windows.UI.Xaml.Controls.InkToolbar obj, global::Windows.UI.Xaml.Controls.InkCanvas value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.InkCanvas) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.InkCanvas), targetNullValue);
                }
                obj.TargetInkCanvas = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_SymbolIcon_Symbol(global::Windows.UI.Xaml.Controls.SymbolIcon obj, global::Windows.UI.Xaml.Controls.Symbol value)
            {
                obj.Symbol = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::BGTviewer.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.InkToolbar obj50;
            private global::Windows.UI.Xaml.Controls.SymbolIcon obj58;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj50TargetInkCanvasDisabled = false;
            private static bool isobj58SymbolDisabled = false;

            public MainPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 33 && columnNumber == 46)
                {
                    isobj50TargetInkCanvasDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 37)
                {
                    isobj58SymbolDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 50: // MainPage.xaml line 33
                        this.obj50 = (global::Windows.UI.Xaml.Controls.InkToolbar)target;
                        break;
                    case 58: // MainPage.xaml line 35
                        this.obj58 = (global::Windows.UI.Xaml.Controls.SymbolIcon)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BGTviewer.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BGTviewer.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_inkCanvas(obj.inkCanvas, phase);
                        this.Update_LassoSelect(obj.LassoSelect, phase);
                    }
                }
            }
            private void Update_inkCanvas(global::Windows.UI.Xaml.Controls.InkCanvas obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 33
                    if (!isobj50TargetInkCanvasDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(this.obj50, obj, null);
                    }
                }
            }
            private void Update_LassoSelect(global::Windows.UI.Xaml.Controls.Symbol obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 35
                    if (!isobj58SymbolDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SymbolIcon_Symbol(this.obj58, obj);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {
                    this.Page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // MainPage.xaml line 21
                {
                    this.titlePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // MainPage.xaml line 74
                {
                    this.instruction = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 76
                {
                    this.selectionCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 5: // MainPage.xaml line 79
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 6: // MainPage.xaml line 113
                {
                    this.fA = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.fA).Click += this.fA_select;
                }
                break;
            case 7: // MainPage.xaml line 114
                {
                    this.f1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f1).Click += this.f1_select;
                }
                break;
            case 8: // MainPage.xaml line 115
                {
                    this.f2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f2).Click += this.f2_select;
                }
                break;
            case 9: // MainPage.xaml line 116
                {
                    this.f3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f3).Click += this.f3_select;
                }
                break;
            case 10: // MainPage.xaml line 117
                {
                    this.f4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f4).Click += this.f4_select;
                }
                break;
            case 11: // MainPage.xaml line 118
                {
                    this.f5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f5).Click += this.f5_select;
                }
                break;
            case 12: // MainPage.xaml line 119
                {
                    this.f6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f6).Click += this.f6_select;
                }
                break;
            case 13: // MainPage.xaml line 120
                {
                    this.f7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f7).Click += this.f7_select;
                }
                break;
            case 14: // MainPage.xaml line 121
                {
                    this.f8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.f8).Click += this.f8_select;
                }
                break;
            case 15: // MainPage.xaml line 122
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // MainPage.xaml line 123
                {
                    this.age = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // MainPage.xaml line 124
                {
                    this.number = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // MainPage.xaml line 125
                {
                    this.징후1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // MainPage.xaml line 126
                {
                    this.점수1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // MainPage.xaml line 127
                {
                    this.징후2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // MainPage.xaml line 128
                {
                    this.점수2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // MainPage.xaml line 129
                {
                    this.배열순서 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 23: // MainPage.xaml line 130
                {
                    this.도형A의위치 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 24: // MainPage.xaml line 131
                {
                    this.공간사용 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 25: // MainPage.xaml line 132
                {
                    this.중첩 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 26: // MainPage.xaml line 133
                {
                    this.용지회전 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 27: // MainPage.xaml line 134
                {
                    this.폐쇄손란 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 28: // MainPage.xaml line 136
                {
                    this.교차곤란 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.교차곤란).Click += this.Click_Crossing;
                }
                break;
            case 29: // MainPage.xaml line 137
                {
                    this.resultCrossing = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30: // MainPage.xaml line 139
                {
                    this.곡선곤란 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 31: // MainPage.xaml line 140
                {
                    this.각의변화 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 32: // MainPage.xaml line 141
                {
                    this.지각적회전 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 33: // MainPage.xaml line 142
                {
                    this.퇴영 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 34: // MainPage.xaml line 143
                {
                    this.단순화 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 35: // MainPage.xaml line 144
                {
                    this.단편화 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 36: // MainPage.xaml line 145
                {
                    this.중복곤란 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 37: // MainPage.xaml line 146
                {
                    this.정교화 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 38: // MainPage.xaml line 147
                {
                    this.고집화 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 39: // MainPage.xaml line 148
                {
                    this.재묘사 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 40: // MainPage.xaml line 149
                {
                    this.평균 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41: // MainPage.xaml line 150
                {
                    this.결과 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42: // MainPage.xaml line 151
                {
                    this.소속집단 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43: // MainPage.xaml line 153
                {
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 44: // MainPage.xaml line 168
                {
                    this.text1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 45: // MainPage.xaml line 169
                {
                    this.text2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 46: // MainPage.xaml line 154
                {
                    this.Pressure = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries)(target);
                }
                break;
            case 47: // MainPage.xaml line 160
                {
                    this.Selected = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries)(target);
                }
                break;
            case 48: // MainPage.xaml line 77
                {
                    this.img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 49: // MainPage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Image element49 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element49).Tapped += this.Image_Tapped_Load;
                }
                break;
            case 50: // MainPage.xaml line 33
                {
                    this.toolbar = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                }
                break;
            case 51: // MainPage.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Image element51 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element51).Tapped += this.pressure_select;
                }
                break;
            case 52: // MainPage.xaml line 49
                {
                    this.clear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.clear).Click += this.ClearDrawnBoundingRect;
                }
                break;
            case 53: // MainPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element53 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element53).Click += this.use_click;
                }
                break;
            case 54: // MainPage.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element54 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element54).Click += this.use_stroke;
                }
                break;
            case 55: // MainPage.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element55 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element55).Click += this.use_auto;
                }
                break;
            case 56: // MainPage.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element56 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element56).Click += this.end_use;
                }
                break;
            case 57: // MainPage.xaml line 34
                {
                    this.toolButtonLasso = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)this.toolButtonLasso).Click += this.ToolButton_Lasso;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

