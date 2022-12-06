using Avalonia.Controls;
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

    }
}
