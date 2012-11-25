using System.ComponentModel;
using NotifyPropertyWeaver;

[NotifyForAll]
public class ClassWithCustomPropertyChanged : INotifyPropertyChanged
{
// ReSharper disable NotAccessedField.Local
    PropertyChangedEventHandler propertyChanged;
// ReSharper restore NotAccessedField.Local

    public event PropertyChangedEventHandler PropertyChanged
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