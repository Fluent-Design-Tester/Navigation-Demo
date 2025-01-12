﻿using HelloWorld.Dto;
using HelloWorld.Models;
using HelloWorld.Resources.UI.Xaml;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Students : Page
    {
        public List<Student> StudentList;

        public Students()
        {
            this.InitializeComponent();

            StudentModel student = new StudentModel();
            StudentList = student.getStudent();
        }

        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            /*if (e.PropertyDescriptor is PropertyDescriptor descriptor)
            {
                e.Column.Header = descriptor.DisplayName ?? descriptor.Name;
            }*/

            switch (e.PropertyName)
            {
                case nameof(Student.student_id):
                    e.Column.Header = "No.";
                    break;

                case nameof(Student.name):
                    e.Column.Header = "Name";
                    break;

                case nameof(Student.gender):
                    e.Column.Header = "Gender";
                    break;

                case nameof(Student.nrc):
                    e.Column.Header = "NRC";
                    break;

                case nameof(Student.birthday):
                    e.Column.Header = "Birthday";
                    break;

                case nameof(Student.phone):
                    e.Column.Header = "Phone";
                    break;

                case nameof(Student.address):
                    e.Column.Header = "Address";
                    break;

                case nameof(Student.hostel_address):
                    e.Column.Header = "Hostel Address";
                    break;
            }
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            string searchString = sender.Text.ToLower().Trim();
            var matchedItems = new List<Student>();

            // Searchable Fields: Name, NRC, Birthday and Phone
            foreach (var student in StudentList)
            {
                if (student.name.ToLower().Contains(searchString)) matchedItems.Add(student);
                else if (student.nrc.ToLower().Contains(searchString)) matchedItems.Add(student);
                else if (student.birthday.ToLower().Contains(searchString)) matchedItems.Add(student);
                else if (student.phone.Contains(searchString)) matchedItems.Add(student);
            }

            var bindingList = new BindingList<Student>(matchedItems);
            DataGrid_Students.ItemsSource = bindingList;
        }

        private void ButtonClick_About(object sender, RoutedEventArgs e)
        {
            SplitView_OnClickAbout.IsPaneOpen = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddStudent));
        }
    }
}
