using OnlineLibrary.Model;
using OnlineLibrary.View;
using OnlineLibrary.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineLibrary.ViewModel
{
    internal class MainViewModel : BindingHelper
    {

        public BindableCommand AddCommand { get; set; }
        public BindableCommand AddCommand1 { get; set; }
        public BindableCommand AddCommand2 { get; set; }
        public MainViewModel()
        {
            if (System.IO.Path.Exists(JsonConv.desktop)) titles = JsonConv.Deserilaz < ObservableCollection<Title>>();
            
            AddCommand = new BindableCommand(_ => Create_Button_Func());
            AddCommand1 = new BindableCommand(_ => Update_Button_Func());
            AddCommand2 = new BindableCommand(_ => Delete_Button_Func());
        }

        #region Свойства
        private Title title;

        public Title Title
        {
            get { return title; }
            set
            {
                Title = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Title> titles;

        public ObservableCollection<Title> Titles
        {
            get { return titles; }
            set
            {
                titles = value;
                OnPropertyChanged();
            }
        }
        #endregion

        private Title selectedTitle;
        public Title SelectedTitle
        {
            get { return selectedTitle; }
            set
            {
                selectedTitle = value;
                OnPropertyChanged();
            }
        }

        private void Create_Button_Func()
        {
            CreatWindow creatWindow = new CreatWindow();
            creatWindow.Show();
        }

        private void Update_Button_Func()
        {
            ChangeWindow changeWindow = new ChangeWindow();
            changeWindow.Show();
            
        }

        private void Delete_Button_Func()
        {

            titles.Remove(selectedTitle);
            JsonConv.Serilaz<ObservableCollection<Title>>(titles);
        }
    }
}
