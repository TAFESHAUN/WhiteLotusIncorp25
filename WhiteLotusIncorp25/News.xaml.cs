namespace WhiteLotusIncorp25;

public partial class News : ContentPage
{
	public News()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Button button = (Button)sender;
        //Color color = Color.FromArgb("#FF0000");
        //button.TextColor = color;
        //newsBtn.TextColor = color;

        //Grid return the exact cell I last clicked
        //Canvas can have an arg of the exact X and Y coordinates of the click
        //Slider value out of 100 or % of slide
        //Entry -> current text in the entry

        NewsInfo passedNewsInfo = new NewsInfo
        {
            Title = CoolNews.Text,
            Description = "Some News Description",
            Image = "news.jpg"
        };

        //NewsInfo passedNewsInfo2 = new NewsInfo();
        //passedNewsInfo2.Title = "Cool News 2";
        //passedNewsInfo2.Description = "Some News Description 2";
        //passedNewsInfo2.Image = "news2.jpg";
        DisplayAlert("News", passedNewsInfo.Title, "OK");

        await Navigation.PushAsync(new NewsDetails(passedNewsInfo));
    }
}