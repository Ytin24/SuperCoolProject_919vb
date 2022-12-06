using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI.Fody.Helpers;

namespace SuperCoolProject_919vb.UserControls {
    public partial class TxtBoxWithButton : UserControl {
        public TxtBoxWithButton() {
            InitializeComponent();
            DataContext = this;
        }
        [Reactive] public string TextTb { get; set; }
        public void TEST(object sender, RoutedEventArgs args) {

        }
    }
}
