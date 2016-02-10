using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace TextBlock_Demo

{
   
    public sealed partial class MainPage : Page
    {
        Student student = new Student();

        public void constructStudent()
        {
            student.Name = "David";
            student.Rollno = "ENG-001";
            student.Phone = "01159989838";
        }

        public MainPage()

        {
            this.InitializeComponent();
            constructStudent();
            this.DataContext = student;

        }
    }
}
