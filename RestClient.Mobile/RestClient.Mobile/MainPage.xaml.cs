using RestClient.Provider.Concreate.Managers;
using RestClient.Provider.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestClient.Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        EmployeeManager manager = new EmployeeManager();

        public MainPage()
        {
            InitializeComponent();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            IEnumerable<EmployeeViewModel> employees = await manager.GetAllAsync();
            var employee = await manager.GetAsync(1);
            var added = await manager.PostAsync(new EmployeeViewModel { Name = "Mustafa", Gender = true });
            var edited = await manager.PutAsync(new EmployeeViewModel { Id = 1, Name = "Edited Mustafa", Gender = true });
        }
    }
}