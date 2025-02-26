namespace WhiteLotusIncorp25;

public partial class NewsDetails : ContentPage
{
	public NewsDetails(NewsInfo newsInfo)
	{
		InitializeComponent();
		newsTitle.Text = newsInfo.Title;
		newsDsc.Text = newsInfo.Description;
		newsImg.Text = newsInfo.Image;	//STRING placeholder needs ImageSource
    }


}