namespace YomaGamingPanel;

public partial class MainPage : ContentPage
{
    private bool _drillRunning;

    public MainPage()
    {
        InitializeComponent();

        GeneralSlider.ValueChanged += (_, e) => GeneralValue.Text = ((int)e.NewValue).ToString();
        RedDotSlider.ValueChanged += (_, e) => RedDotValue.Text = ((int)e.NewValue).ToString();
        TwoXSlider.ValueChanged += (_, e) => TwoXValue.Text = ((int)e.NewValue).ToString();
        FourXSlider.ValueChanged += (_, e) => FourXValue.Text = ((int)e.NewValue).ToString();
        FireSizeSlider.ValueChanged += (_, e) => FireSizeValue.Text = $"{(int)e.NewValue}%";

        GeneralSlider.Value = Preferences.Get("general", 200);
        RedDotSlider.Value = Preferences.Get("redDot", 195);
        TwoXSlider.Value = Preferences.Get("twoX", 185);
        FourXSlider.Value = Preferences.Get("fourX", 170);
        FireSizeSlider.Value = Preferences.Get("fireSize", 45);
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        Preferences.Set("general", (int)GeneralSlider.Value);
        Preferences.Set("redDot", (int)RedDotSlider.Value);
        Preferences.Set("twoX", (int)TwoXSlider.Value);
        Preferences.Set("fourX", (int)FourXSlider.Value);
        Preferences.Set("fireSize", (int)FireSizeSlider.Value);
        SaveStatus.Text = "Profile saved on this device.";
    }

    private async void OnM1887Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("M1887 Practice",
            "Aim around the upper chest, then use a short upward swipe. Adjust for your control and distance.",
            "Got it");
    }

    private async void OnMP40Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("MP40 Practice",
            "Try short bursts and a small upward swipe. If your aim passes above the target, shorten the swipe.",
            "Got it");
    }

    private async void OnPracticeClicked(object sender, EventArgs e)
    {
        if (_drillRunning) return;
        _drillRunning = true;
        PracticeButton.IsEnabled = false;

        for (int remaining = 10; remaining >= 1; remaining--)
        {
            PracticeStatus.Text = $"Practice drill: {remaining}s";
            await Task.Delay(1000);
        }

        PracticeStatus.Text = "Drill complete — take a short break.";
        PracticeButton.Text = "START AGAIN";
        PracticeButton.IsEnabled = true;
        _drillRunning = false;
    }
}
