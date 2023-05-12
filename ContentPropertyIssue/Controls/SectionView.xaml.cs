namespace ContentPropertyIssue.Controls;

[ContentProperty(nameof(Fire))]
public partial class SectionView : ContentView
{
    public static readonly BindableProperty FireProperty = BindableProperty.Create(nameof(Fire), typeof(string), typeof(SectionView));

    public string Fire
    {
        get => GetValue(FireProperty) as string;
        set => SetValue(FireProperty, value);
    }

    public SectionView()
	{
		InitializeComponent();
	}
}