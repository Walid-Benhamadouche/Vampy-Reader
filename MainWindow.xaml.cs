﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace Vampy_Reader
{
    internal enum AccentState
    {
        ACCENT_DISABLED = 1,
        ACCENT_ENABLE_GRADIENT = 0,
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
        ACCENT_ENABLE_BLURBEHIND = 3,
        ACCENT_INVALID_STATE = 4
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }

    internal enum WindowCompositionAttribute
    {
        // ...
        WCA_ACCENT_POLICY = 19
        // ...
    }
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public MainWindow()
        {
            this.MaxHeight = SystemParameters.WorkArea.Height+8;
            this.MaxWidth = SystemParameters.WorkArea.Width+8;
            InitializeComponent();

            List<Book> Books = new List<Book>();
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));
            Books.Add(new Book("ReZero Vol 01", "C:/Users/Aures/Desktop/WpfDemo/Covers/1.png", 300, 0));
            Books.Add(new Book("Dragon Age - The Masked Empire", "C:/Users/Aures/Desktop/WpfDemo/Dragon Age - The Masked Empire/OEBPS/images/9781466828100.jpg", 300, 0));

            BookList.ItemsSource = Books;

            CloseApp.Click += (s, e) => { System.Windows.Application.Current.Shutdown(); };
            Minimize.Click += (s, e) => { WindowState = WindowState.Minimized; };
            DragBar.MouseDown += (s, e) => { this.DragMove(); };
            DragBar2.MouseDown += (s, e) => { this.DragMove(); };

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EnableBlur();
        }

        internal void EnableBlur()
        {
            var windowHelper = new WindowInteropHelper(this);

            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

            var accentStructSize = Marshal.SizeOf(accent);

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(windowHelper.Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {

        }

        private void Storyboard_Completed_1(object sender, EventArgs e)
        {

        }
    }
}
