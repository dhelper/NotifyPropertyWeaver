using System.ComponentModel;
using NotifyPropertyWeaver;

[NotifyForAll]
public class ClassWithExplicitPropertyChanged : INotifyPropertyChanged
{
// ReSharper disable NotAccessedField.Local
    PropertyChangedEventHandler propertyChanged;
// ReSharper restore NotAccessedField.Local
    event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
    {
        add
        {
            propertyChanged += value;
        }
        remove
        {
            propertyChanged -= value;
        }
    }

    public string Property1 { get; set; }

}