#region Using directives
using FTOptix.NetLogic;
using FTOptix.UI;
using UAManagedCore;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        label = Owner.Get<Label>("Label1");
        textbox = Owner.Get<TextBox>("TextBox1");
        editableLabel = Owner.Get<EditableLabel>("EditableLabel1");
        led = Owner.Get<Led>("LED1");
        button = Owner.Get<Button>("Button1");
        switchItem = Owner.Get<Switch>("Switch1");
        checkBox = Owner.Get<CheckBox>("Checkbox1");
        radioButton = Owner.Get<RadioButton>("OptionButton1");
        linearGauge = Owner.Get<LinearGauge>("LinearGauge1");
        datePicker = Owner.Get<DateTimePicker>("DateAndTime1");
        durationPicker = Owner.Get<DurationPicker>("Duration1");
        comboBox = Owner.Get<ComboBox>("ComboBox1");
        listBox = Owner.Get<ListBox>("ListBox1");
        histogramChart = Owner.Get<HistogramChart>("HistogramChart1");
        image = Owner.Get<Image>("Image1");
        dropDownButton = Owner.Get<DropDownButton>("DropdownButton1");
        dataGrid = Owner.Get<DataGrid>("DataGrid1");

        //var column = dataGrid.Columns.Get("DataGridColumn1");
        //dataGridItemTemplate = column.DataItemTemplate as DataGridLabelItemTemplate;
        //Log.Info("|Temp" + dataGridItemTemplate == null ? "null" : "not null " + dataGridItemTemplate.TextColor.ARGB);
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void SetUp()
    {
        {
            var value = Colors.Green;
            label.TextColor = value;
            textbox.TextColor = value;
            editableLabel.TextColor = value;
            led.TextColor = value;
            button.TextColor = value;
            dropDownButton.TextColor = value;
            switchItem.TextColor = value;
            radioButton.TextColor = value;
            datePicker.TextColor = value;
            durationPicker.TextColor = value;
            comboBox.TextColor = value;
            listBox.TextColor = value;
            checkBox.TextColor= value;
            //dataGridItemTemplate.TextColor = value;
        }

        {
            var value = true;
            label.FontItalic = value;
            textbox.FontItalic = value;
            editableLabel.FontItalic = value;
            led.FontItalic = value;
            button.FontItalic = value;
            dropDownButton.FontItalic = value;
            switchItem.FontItalic = value;
            radioButton.FontItalic = value;
            datePicker.FontItalic = value;
            durationPicker.FontItalic = value;
            comboBox.FontItalic = value;
            listBox.FontItalic = value;
            checkBox.FontItalic = value;
        }

        {
            var value = 14;
            label.FontSize = value;
            textbox.FontSize = value;
            editableLabel.FontSize = value;
            led.FontSize = value;
            button.FontSize = value;
            dropDownButton.FontSize = value;
            switchItem.FontSize = value;
            radioButton.FontSize = value;
            datePicker.FontSize = value;
            durationPicker.FontSize = value;
            comboBox.FontSize = value;
            listBox.FontSize = value;
            checkBox.FontSize = value;
        }

        {
            var value = "Times";
            label.FontFamily = value;
            textbox.FontFamily = value;
            editableLabel.FontFamily = value;
            led.FontFamily = value;
            button.FontFamily = value;
            dropDownButton.FontFamily = value;
            switchItem.FontFamily = value;
            radioButton.FontFamily = value;
            datePicker.FontFamily = value;
            durationPicker.FontFamily = value;
            comboBox.FontFamily = value;
            listBox.FontFamily = value;
            checkBox.FontFamily = value;
        }

        {
            var value = FontWeight.Bold;
            label.FontWeight = value;
            textbox.FontWeight = value;
            editableLabel.FontWeight = value;
            led.FontWeight = value;
            button.FontWeight = value;
            dropDownButton.FontWeight = value;
            switchItem.FontWeight = value;
            radioButton.FontWeight = value;
            datePicker.FontWeight = value;
            durationPicker.FontWeight = value;
            comboBox.FontWeight = value;
            listBox.FontWeight = value;
            checkBox.FontWeight = value;
        }

        {
            dataGrid.RowBackgroundColor = Colors.Red;
            dataGrid.RowTextColor = Colors.White;
        }

        {
            linearGauge.FillColor = Colors.Green;
        }

        {
            image.DynamicColor = Colors.Green;
        }

        {
            histogramChart.BarColor = Colors.Green;
        }

        {
            textbox.BorderColor = Colors.Green;
            editableLabel.BorderColor = Colors.Green;
        }

        {
            button.BackgroundColor = Colors.Red;
            dropDownButton.BackgroundColor = Colors.Red;
        }
    }

    [ExportMethod]
    public void Reset()
    {
        {
            label.TextColorVariable.Delete();
            textbox.TextColorVariable.Delete();
            editableLabel.TextColorVariable.Delete();
            led.TextColorVariable.Delete();
            button.TextColorVariable.Delete();
            dropDownButton.TextColorVariable.Delete();
            switchItem.TextColorVariable.Delete();
            radioButton.TextColorVariable.Delete();
            datePicker.TextColorVariable.Delete();
            durationPicker.TextColorVariable.Delete();
            comboBox.TextColorVariable.Delete();
            listBox.TextColorVariable.Delete();
            checkBox.TextColorVariable.Delete();
            //dataGridItemTemplate.TextColorVariable.Delete();
        }

        {
            label.FontItalicVariable.Delete();
            textbox.FontItalicVariable.Delete();
            editableLabel.FontItalicVariable.Delete();
            led.FontItalicVariable.Delete();
            button.FontItalicVariable.Delete();
            dropDownButton.FontItalicVariable.Delete();
            switchItem.FontItalicVariable.Delete();
            radioButton.FontItalicVariable.Delete();
            datePicker.FontItalicVariable.Delete();
            durationPicker.FontItalicVariable.Delete();
            comboBox.FontItalicVariable.Delete();
            listBox.FontItalicVariable.Delete();
            checkBox.FontItalicVariable.Delete();
        }

        {
            label.FontSizeVariable.Delete();
            textbox.FontSizeVariable.Delete();
            editableLabel.FontSizeVariable.Delete();
            led.FontSizeVariable.Delete();
            button.FontSizeVariable.Delete();
            dropDownButton.FontSizeVariable.Delete();
            switchItem.FontSizeVariable.Delete();
            radioButton.FontSizeVariable.Delete();
            datePicker.FontSizeVariable.Delete();
            durationPicker.FontSizeVariable.Delete();
            comboBox.FontSizeVariable.Delete();
            listBox.FontSizeVariable.Delete();
            checkBox.FontSizeVariable.Delete();
        }

        {
            label.FontFamilyVariable.Delete();
            textbox.FontFamilyVariable.Delete();
            editableLabel.FontFamilyVariable.Delete();
            led.FontFamilyVariable.Delete();
            button.FontFamilyVariable.Delete();
            dropDownButton.FontFamilyVariable.Delete();
            switchItem.FontFamilyVariable.Delete();
            radioButton.FontFamilyVariable.Delete();
            datePicker.FontFamilyVariable.Delete();
            durationPicker.FontFamilyVariable.Delete();
            comboBox.FontFamilyVariable.Delete();
            listBox.FontFamilyVariable.Delete();
            checkBox.FontFamilyVariable.Delete();
        }

        {
            label.FontWeightVariable.Delete();
            textbox.FontWeightVariable.Delete();
            editableLabel.FontWeightVariable.Delete();
            led.FontWeightVariable.Delete();
            button.FontWeightVariable.Delete();
            dropDownButton.FontWeightVariable.Delete();
            switchItem.FontWeightVariable.Delete();
            radioButton.FontWeightVariable.Delete();
            datePicker.FontWeightVariable.Delete();
            durationPicker.FontWeightVariable.Delete();
            comboBox.FontWeightVariable.Delete();
            listBox.FontWeightVariable.Delete();
            checkBox.FontWeightVariable.Delete();
        }

        {
            dataGrid.RowBackgroundColorVariable.Delete();
            dataGrid.RowTextColorVariable.Delete();
        }

        {
            linearGauge.FillColorVariable.Delete();
        }

        {
            image.DynamicColorVariable.Delete();
        }

        {
            histogramChart.BarColorVariable.Delete();
        }

        {
            textbox.BorderColorVariable.Delete();
            editableLabel.BorderColorVariable.Delete();
        }

        {
            button.BackgroundColorVariable.Delete();
            dropDownButton.BackgroundColorVariable.Delete();
        }
    }

    Label label;
    TextBox textbox;
    EditableLabel editableLabel;
    Led led;
    Button button;
    DropDownButton dropDownButton;
    Switch switchItem;
    CheckBox checkBox;
    RadioButton radioButton;
    LinearGauge linearGauge;
    DateTimePicker datePicker;
    DurationPicker durationPicker;
    ComboBox comboBox;
    ListBox listBox;
    DataGrid dataGrid;
    Image image;
    HistogramChart histogramChart;
    DataGridLabelItemTemplate dataGridItemTemplate;
}
