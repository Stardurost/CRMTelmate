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

namespace CRMTelmate.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            LViewClients.ItemsSource = App.Context.Clients.ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            //это нерабочий примерный код навигации на страницу определенного клиента
            //var button = sender as Button;
            //var currentClient = button.DataContext as Entities.Clients;

            //NavigationService.Navigate(new ClientInfoPage(currentClient));
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateClients();
        }

        private void UpdateClients()
        {
            var clients = App.Context.Clients.ToList();
            clients = clients.Where(p => p.SurnameClient.ToLower()
                     .Contains(TBSearch.Text.ToLower())).ToList();


            LViewClients.ItemsSource = clients;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateClients();
        }
    }
}