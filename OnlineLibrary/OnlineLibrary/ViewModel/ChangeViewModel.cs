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
    class ChangeViewModel : BindingHelper
    {
        public MainViewModel mainWindow = new MainViewModel();
        public BindableCommand AddCommand { get; set; }
        public List<string> typeLis { get; } = new List<string>() { "Книга", "Фильм", "Сериал", "Манга", "Комикс", "Мультфильм", "Аниме" };
        public ChangeViewModel()
        {
            if (System.IO.Path.Exists(JsonConv.desktop)) titles = JsonConv.Deserilaz<ObservableCollection<Title>>();
            AddCommand = new BindableCommand(_ => AddList());
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged();
            }
        }

        private int duration;
        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set
            {
                genre = value;
                OnPropertyChanged();
            }
        }

        private bool cheked;
        public bool Cheked
        {
            get { return cheked; }
            set
            {
                cheked = value;
                OnPropertyChanged();
            }
        }

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
        private void AddList()
        {
            
            int i = titles.IndexOf(selectedTitle);
            selectedTitle.Name = Name;
            selectedTitle.Type = Type;
            selectedTitle.Duration = Duration;
            selectedTitle.Genre = Genre;
            selectedTitle.Cheked = Cheked;
            titles[i] = selectedTitle;
            JsonConv.Serilaz<ObservableCollection<Title>>(titles);
            Titles = titles;
            OnPropertyChanged(nameof(Titles));
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
    }
}
