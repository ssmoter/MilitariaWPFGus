using MilitariaWPFGus.Helper;
using MilitariaWPFGus.Service;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MilitariaWPFGus.Gus
{
    public class GusVM : INotifyPropertyChanged
    {
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
        private GusService _service;

        public GusVM()
        {
            _service = new GusService();
            Task.Run(async () =>
            {
                GusMs = await _service.GetGus();
                for (int i = 0; i < GusMs.Length; i++)
                {
                    GusMs[i].Color = RecordColor.SetColor(GusMs[i].NazwaPoziom);
                }
            });
        }











        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
