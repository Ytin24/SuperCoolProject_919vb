using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;
using SuperCoolProject_919vb.Models;
using SuperCoolProject_919vb.ViewModels;

namespace SuperCoolProject_919vb.Views {
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel> {
        public MainWindow() {
            AvaloniaXamlLoader.Load(this);
            this.WhenActivated(disposables => { });
        }
        private void OnButtonClick(object sender, RoutedEventArgs e) {
            new Parser(new KadArbitrClass() {
                Sides = new() {
                new Side(){Name = "��� ��� ����", Type = -1, ExactMatch = true},
            },
            });
        }
    }
}
