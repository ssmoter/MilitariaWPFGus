using MilitariaWPFGus.Helper;

using Newtonsoft.Json;

using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MilitariaWPFGus.Gus
{
    public class GusM : INotifyPropertyChanged
    {

        [JsonProperty("id")]
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }


        [JsonProperty("nazwa")]
        private string? _nazwa;
        public string? Nazwa
        {
            get { return _nazwa; }
            set
            {
                if (_nazwa != value)
                {
                    _nazwa = value;
                    OnPropertyChanged(nameof(Nazwa));
                }
            }
        }
        [JsonProperty("id-nadrzedny-element")]
        private int _idNadrzednyElement;
        public int IdNadrzednyElement
        {
            get { return _idNadrzednyElement; }
            set
            {
                if (_idNadrzednyElement != value)
                {
                    _idNadrzednyElement = value;
                    OnPropertyChanged(nameof(IdNadrzednyElement));
                }
            }
        }

        [JsonProperty("id-poziom")]
        private int _idPoziom;
        public int IdPoziom
        {
            get { return _idPoziom; }
            set
            {
                if (_idPoziom != value)
                {
                    _idPoziom = value;
                    OnPropertyChanged(nameof(IdPoziom));
                }
            }
        }

        [JsonProperty("nazwa-poziom")]
        private string? _nazwaPoziom;
        public string? NazwaPoziom
        {
            get { return _nazwaPoziom; }
            set
            {
                if (_nazwaPoziom != value)
                {
                    _nazwaPoziom = value;
                    Color = RecordColor.SetColor(_nazwaPoziom);
                    OnPropertyChanged(nameof(NazwaPoziom));
                }
            }
        }
        [JsonProperty("czy-zmienne")]
        private bool _czyZmienne;
        public bool CzyZmienne
        {
            get { return _czyZmienne; }
            set
            {
                if (_czyZmienne != value)
                {
                    _czyZmienne = value;
                    OnPropertyChanged(nameof(CzyZmienne));
                }
            }
        }

        private Color _color;
        public Color Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    _color = value;
                    OnPropertyChanged(nameof(Color));
                }
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
