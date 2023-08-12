using System;

using Microsoft.Maui.Controls;

using StedySoft.Maui.Framework;

namespace StedySoft.BindingIssues.Views {

	public partial class MainPage : ContentPage {

		public MainPage() =>
			this.InitializeComponent();

		public static readonly BindableProperty SliderValueProperty =
			BindableProperty.Create(
				nameof(MainPage.SliderValue),
				typeof(double),
				typeof(MainPage),
				50d);

		public double SliderValue {
			get => this.GetValue(MainPage.SliderValueProperty).CastTo<double>();
			set => this.SetValue(MainPage.SliderValueProperty, value);
		}

		private void OnUpdateBindablePropertyClicked(object sender, EventArgs e) =>
			this.SliderValue = 100;

		private void OnUpdateSliderValueClicked(object sender, EventArgs e) =>
			this.SliderControl.Value = 100;

	}

}
