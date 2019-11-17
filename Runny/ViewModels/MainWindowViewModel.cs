using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runny.ViewModels
{
    using Caliburn.Micro;

    class MainWindowViewModel : PropertyChangedBase
    {
        private string title;
        private List<Models.Action> actions;

        public MainWindowViewModel()
        {
            Title = "Action List";
        }

        public string Title
        {
            get => title;
            set => Set(ref title, value, nameof(Title));
        }

        public List<Models.Action> Actions
        {
            get => actions;
            set => Set(ref actions, value);
        }
    }
}
