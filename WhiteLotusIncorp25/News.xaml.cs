namespace WhiteLotusIncorp25;

public partial class News : ContentPage
{
	public News()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
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


        await Navigation.PushAsync(new NewsDetails(passedNewsInfo));
    }
}