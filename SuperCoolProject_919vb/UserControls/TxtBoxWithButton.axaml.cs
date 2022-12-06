using Avalonia.Controls;
using ReactiveUI.Fody.Helpers;

namespace SuperCoolProject_919vb.UserControls {
    public partial class TxtBoxWithButton : UserControl {
        public TxtBoxWithButton() {
            InitializeComponent();
            DataContext = this;
        }
        [Reactive] public string TextTb { get; set; }
    }
}
