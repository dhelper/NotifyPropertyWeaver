using System.ComponentModel;
using NotifyPropertyWeaver;

public class ClassWithBranchingReturnAndNoField : INotifyPropertyChanged
{
    public bool HasValue;
// ReSharper disable NotAccessedField.Local
    int x;
// ReSharper restore NotAccessedField.Local

    [NotifyProperty(PerformEqualityCheck = false)]
    public string Property1
    {
        get { return null; }
        set
        {
            if (HasValue)
            {
                x++;
            }
            else
            {
                x ++;
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}