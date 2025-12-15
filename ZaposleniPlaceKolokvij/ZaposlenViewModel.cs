using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace ZaposleniPlace
{
    class ZaposlenViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<Zaposlen> Zaposleni { get; }
        = new ObservableCollection<Zaposlen>();

        public Zaposlen SelectedZaposlen { get; set; }

        public static void AddZaposlen(Zaposlen zaposlen)
        {
            if (zaposlen != null)
                Zaposleni.Add(zaposlen);
        }

        public static void RemoveZaposlen(Zaposlen zaposlen)
        {
            if (zaposlen != null && Zaposleni.Contains(zaposlen))
                Zaposleni.Remove(zaposlen);
        }

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        public ZaposlenViewModel()
        {
            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private void Add(object z)
        {
            Zaposlen newZaposlen = (Zaposlen)z;

            AddZaposlen(newZaposlen);
        }

        private void Remove(object z)
        {
            Zaposlen newZaposlen = (Zaposlen)z;

            RemoveZaposlen(newZaposlen);
        }

        public class RelayCommand : ICommand
        {
            private readonly Action<object> _execute;

            public RelayCommand(Action<object> execute)
            {
                _execute = execute;
            }

            public bool CanExecute(object parameter) => true;
            public void Execute(object parameter) => _execute(parameter);
            public event EventHandler CanExecuteChanged;
        }

        private void Update()
        {
            new NotImplementedException();
        }
    }
}
