using Stylet;

namespace Pc_Monitor.Wpf.ViewModels;
public class RootViewModel : PropertyChangedBase
{
    private string _title = "Pc Status Monitor";
    public string Title
    {
        get { return _title; }
        set { SetAndNotify(ref _title, value); }
    }

    public RootViewModel()
    {

    }
}