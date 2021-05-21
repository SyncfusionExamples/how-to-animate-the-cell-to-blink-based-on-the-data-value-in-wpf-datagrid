# How to animate the cell to blink based on the data value in WPF DataGrid (SfDataGrid)?

## About the sample

This example illustrates how to animate the cell to blink based on the data value in WPF DataGrid (SfDataGrid).

[WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) allows you to make the cells to blink based on the data value by creating Style with TargetType as GridCell.

```Xaml

<Window.Resources>
    <local:Converter x:Key="converetr"/>
</Window.Resources>

<syncfusion:GridDateTimeColumn HeaderText="OrderDate" MappingName="OrderDate">
    <syncfusion:GridDateTimeColumn.CellStyle>
        <Style TargetType="syncfusion:GridCell">
            <Style.Resources>
                <Storyboard x:Key="FadeStoryboard" >
                    <DoubleAnimation Storyboard.TargetProperty="Opacity" 
                        From="0" To="1" Duration="0:0:0.5"
                        RepeatBehavior="Forever" AutoReverse="True"/>
                </Storyboard>
            </Style.Resources>
            <Style.Triggers>
                <DataTrigger Binding="{Binding Path=OrderDate, Converter={StaticResource converetr}}" Value="True">
                    <Setter Property="Foreground" Value="Red" />
                    <DataTrigger.EnterActions>
                        <BeginStoryboard x:Name="Blink" Storyboard="{StaticResource FadeStoryboard}"/>
                    </DataTrigger.EnterActions>
                    <DataTrigger.ExitActions>
                        <StopStoryboard BeginStoryboardName="Blink"/>
                    </DataTrigger.ExitActions>
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </syncfusion:GridDateTimeColumn.CellStyle> 

```

```C#

public class Converter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        DateTime dateTime = (DateTime)value;
        if(dateTime < DateTime.Today)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

```

![Cell Animation](CellBlink.gif)

## Requirements to run the demo 

Visual Studio 2015 and above versions.
