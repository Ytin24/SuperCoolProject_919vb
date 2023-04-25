using Avalonia.Input;
using Avalonia.Interactivity;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;
using ReactiveUI.Validation.States;
using RestSharp;
using Splat;
using SuperCoolProject_919vb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperCoolProject_919vb.ViewModels {
    public class MainWindowViewModel : ReactiveValidationObject {
        public MainWindowViewModel() {
            new Thread(x => TimeNowFun()).Start();

            this.ValidationRule(
                x => x.Judges,
                Judge => !string.IsNullOrWhiteSpace(Judge) && string.IsNullOrWhiteSpace(Judge),
                "Не поддерживается");
            this.WhenAnyValue(x => x.Judges).Subscribe(x => Debugger.Log(0, " a ", x));
        }
        public ValidationContext ValidationContext { get; } = new ValidationContext();
        [Reactive] public string TimeNow { get; set; }
        [Reactive] public string Courts { get; set; }
        [Reactive] public string Judges { get; set; }
        [Reactive] public string CaseNumbers { get; set; }
        [Reactive] public string SideName { get; set; }
        public List<string> AutoCompleteTExt = CourtsCodes.names.ToList();
        private async void TimeNowFun() {
            while (true) {
                TimeNow = DateTime.Now.ToString("Сегодня: dddd, dd число. Время сейчас: H:m:ss", CultureInfo.GetCultureInfo("ru-RU"));
                await Task.Delay(500);
            }
        }



    }
}
