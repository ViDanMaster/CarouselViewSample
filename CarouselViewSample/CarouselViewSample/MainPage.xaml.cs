using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarouselViewSample.Data;
using CarouselViewSample.Models;
using Xamarin.Forms;

namespace CarouselViewSample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Feladatok> Employees { get; set; } = new ObservableCollection<Feladatok>();

        public MainPage()
        {
            InitializeComponent();

            // TODO Only do this when app first runs
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("ExistingSQLiteDbSample.FeladatokAdatbazis.db3"))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);

                    File.WriteAllBytes(EmployeeRepository.DbPath, memoryStream.ToArray());
                }
            }

            EmployeeRepository repository = new EmployeeRepository();
            foreach (var employee in repository.List())
            {
                Employees.Add(employee);
            }

            BindingContext = this;
        }
    }
}

