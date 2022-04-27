using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMCounter.ViewModel
{
    using Model;
    using System.Windows.Media;

    public class CounterViewModel : BaseViewModel
    {
        private readonly Model model = Settings.Read();
        
        public int CounterValue
        {
            get
            {
                return model.CounterValue;
            }
            set
            {
                model.CounterValue = value;
                onPropertyChanged(nameof(CounterValue));
            }
        }

        public byte CounterSize
        {
            get
            {
                return model.CounterSize;
            }
            set
            {
                model.CounterSize = value;
                onPropertyChanged(nameof(CounterSize));
            }
        }

        public byte R
        {
            get
            {
                return model.R;
            }
            set
            {
                model.R = value;
                onPropertyChanged(nameof(R), nameof(ButtonsColor));
            }
        }

        public byte G
        {
            get
            {
                return model.G;
            }
            set
            {
                model.G = value;
                onPropertyChanged(nameof(G), nameof(ButtonsColor));
            }
        }

        public byte B
        {
            get
            {
                return model.B;
            }
            set
            {
                model.B = value;
                onPropertyChanged(nameof(B), nameof(ButtonsColor));
            }
        }

        public Color ButtonsColor
        {
            get
            {
                return Color.FromRgb(model.R, model.G, model.B);
            }
        }

        private ICommand add;

        public ICommand Add
        {
            get
            {
                if (add == null) add = new RelayCommand(
                     (object o) =>
                     {
                         model.Add();
                         onPropertyChanged(nameof(CounterValue));
                     },
                     (object o) =>
                     {
                         return model.CounterValue < 99;
                     });
                return add;
            }
        }

        private ICommand sub;

        public ICommand Sub
        {
            get
            {
                if (sub == null) sub = new RelayCommand(
                     (object o) =>
                     {
                         model.Sub();
                         onPropertyChanged(nameof(CounterValue));
                     },
                     (object o) =>
                     {
                         return model.CounterValue > 0;
                     });
                return sub;
            }
        }

        private ICommand reset;

        public ICommand Reset
        {
            get
            {
                if (reset == null) reset = new RelayCommand(
                    (object o) =>
                    {
                        model.Reset();
                        onPropertyChanged(nameof(CounterValue));
                    },
                    (object o) =>
                    {
                        return model.CounterValue > 0;
                    });
                return reset;
            }
        }
    }
}
