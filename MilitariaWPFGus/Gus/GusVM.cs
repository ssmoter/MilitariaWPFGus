using CommunityToolkit.Mvvm.Input;

using MilitariaWPFGus.Helper;
using MilitariaWPFGus.Service;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MilitariaWPFGus.Gus
{
    public class GusVM : INotifyPropertyChanged
    {
        #region Properties

        private GusM[] _gusMs;
        public GusM[] GusMs
        {
            get { return _gusMs; }
            set
            {
                if (_gusMs != value)
                {
                    _gusMs = value;
                    OnPropertyChanged(nameof(GusMs));
                }
            }
        }

        private string _selectedLanguage = SelectLanguage.PL;
        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                if (_selectedLanguage != value)
                {
                    _selectedLanguage = value;
                    OnPropertyChanged(nameof(SelectedLanguage));
                }
            }
        }

        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                if (_error != value)
                {
                    _error = value;
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        private GusService _service;
        #endregion

        public GusVM()
        {
            Initialization();
            _service = new GusService();
            GetData();
        }

        private void Initialization()
        {
            ChangeLanguage = new RelayCommand(_changeLanguage);
        }



        #region Commands
        public ICommand ChangeLanguage { get; private set; }
        #endregion

        #region Methods
        private void _changeLanguage()
        {
            if (SelectLanguage.Current == SelectLanguage.PL)
                SelectLanguage.Current = SelectLanguage.EN;
            else
                SelectLanguage.Current = SelectLanguage.PL;

            SelectedLanguage = SelectLanguage.Current;

            GetData(SelectedLanguage);
        }
        private void GetData(string lang = "")
        {
            Task.Run(async () =>
            {
                try
                {
                    GusMs = await _service.GetGus(lang);
                    for (int i = 0; i < GusMs.Length; i++)
                    {
                        GusMs[i].Color = RecordColor.SetColor(GusMs[i].NazwaPoziom);
                    }
                }
                catch (System.Exception ex)
                {
                    Error = ex.Message;
                }
            });
        }


        #endregion



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
