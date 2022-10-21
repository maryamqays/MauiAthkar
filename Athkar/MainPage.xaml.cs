using Athkar.Models;

namespace Athkar;

public partial class MainPage : ContentPage
{
	List<Thikir>athkarlist = new List<Thikir>()
	{
		new Thikir(){Subject="الصباح",Content="بِسـمِ اللهِ الذي لا يَضُـرُّ مَعَ اسمِـهِ شَيءٌ في الأرْضِ وَلا في السّمـاءِ وَهـوَ السّمـيعُ العَلـيم",Image="athkar.png"},
		new Thikir(){Subject="المساء",Content="اللّهُـمَّ بِكَ أَمْسَـينا وَبِكَ أَصْـبَحْنا، وَبِكَ نَحْـيا وَبِكَ نَمُـوتُ وَإِلَـيْكَ الْمَصِيرُ",Image="athkar.png"},
		new Thikir(){Subject="بعد الصلاة ",Content="لا إلهَ إلاّ اللّهُ وَحْـدَهُ لا شريكَ لهُ، لهُ الملكُ ولهُ الحَمْد، وهُوَ على كُلّ شَيءٍ قَـدير",Image="athkar.png"},
		new Thikir(){Subject="النوم",Content="بِاسْـمِكَ اللّهُـمَّ أَمـوتُ وَأَحْـيا",Image="athkar.png"},
		new Thikir(){Subject="الاستيقاظ",Content="الحمدُ للهِ الذي عافاني في جَسَدي وَرَدّ عَليّ روحي وَأَذِنَ لي بِذِكْرِه",Image="athkar.png"},
		new Thikir(){Subject="الوضوء",Content="أشْهَدُ أن لا إله إلا الله وحْدَهُ لا شريكَ لهُ ، وأشْهَدُ أنَّ محمداً عَبدُهُ ورسُولُه",Image="athkar.png"},
		new Thikir(){Subject="الخروج من المنزل",Content="بِسْمِ اللهِ ، تَوَكَّلْـتُ عَلى اللهِ وَلا حَوْلَ وَلا قُـوَّةَ إِلاّ بِالله",Image="athkar.png"},
		new Thikir(){Subject="الخلاء",Content="بِسْمِ الله اللّهُـمَّ إِنِّـي أَعـوذُ بِـكَ مِـنَ الْخُـبْثِ وَالْخَبائِث",Image="athkar.png"},
		new Thikir(){Subject="الطعام",Content="اَللَّهُمَّ بَارِكْ لَنَا فِيهِ, وَزِدْنَا مِنْهُ",Image="athkar.png"}
    };
	public MainPage()
	{
		InitializeComponent();
		lvAthkar.ItemsSource = athkarlist;
	}

	private void lvAthkar_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		var selectitem = e.SelectedItem as Thikir;
		if (selectitem == null) return;
		Navigation.PushAsync(new ThikirDetails(selectitem));
        ((ListView)sender).SelectedItem = null;
    }
}

