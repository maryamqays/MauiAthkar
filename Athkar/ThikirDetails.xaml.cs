using Athkar.Models;

namespace Athkar;

public partial class ThikirDetails : ContentPage
{
	public ThikirDetails(Thikir thikiritem)
	{
		InitializeComponent();
		lbSubject.Text = thikiritem.Subject;
		lbContent.Text = thikiritem.Content;
		imgThikir.Source = thikiritem.Image;
	}
}