using System.CodeDom;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection;

namespace HostelApp
{
    public partial class EditEntityForm : Form
    {
        private Dictionary<string, Control> propertyNameControlMap = new();

        private void InitEditControls()
        {
            foreach (var prop in Entity.GetType()
                .GetProperties()
                .Where(p => p.CanWrite
                    && p.CanRead)
                .Where(p => p.GetCustomAttribute<KeyAttribute>() == null))
            {
                var label = new Label();

                label.Text = prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? prop.Name;

                var control = GetControlByProperty(prop, prop.GetValue(Entity));

                MainContentLayoutPanel.Controls.Add(label);

                //MainContentLayoutPanel.SetFlowBreak(label, true);

                MainContentLayoutPanel.Controls.Add(control);

                MainContentLayoutPanel.SetFlowBreak(control, true);

                propertyNameControlMap[prop.Name] = control;
            }
        }

        private Control GetControlByProperty(PropertyInfo property, object? value)
        {
            var propertyType = property.PropertyType;

            if (propertyType == typeof(string))
            {
                var textBox = new TextBox();

                textBox.Text = value as String ?? string.Empty;

                return textBox;
            }
            else if (propertyType == typeof(int)
                || propertyType == typeof(long)
                || propertyType == typeof(double))
            {
                var numeric = new NumericUpDown();

                numeric.Maximum = decimal.MaxValue;

                if (propertyType == typeof(double))
                {
                    numeric.Increment = (decimal)0.01;
                    numeric.DecimalPlaces = 2;
                }
                else
                {
                    numeric.Increment = 1;
                }

                numeric.Value = Convert.ToDecimal(value ?? 0);

                return numeric;
            }
            else if (propertyType.IsEnum)
            {
                var comboBox = new ComboBox();

                foreach (var en in Enum.GetValues(propertyType))
                {
                    comboBox.Items.Add(en);
                }

                comboBox.SelectedItem = value;

                return comboBox;
            }
            else if (propertyType == typeof(DateTime))
            {
                var picker = new DateTimePicker();

                if (property.GetCustomAttribute<DisplayFormatAttribute>()?.DataFormatString == "short")
                {
                    picker.Format = DateTimePickerFormat.Short;
                }

                var dateTime = value != null ? (DateTime)value : DateTime.UtcNow.Date;

                picker.Value = dateTime;

                return picker;
            }

            throw new Exception("Невозможно создать Control");
        }

        private void GetFromControls()
        {
            foreach (var (name, control) in propertyNameControlMap)
            {
                var prop = Entity.GetType().GetProperty(name)
                    ?? throw new NullReferenceException();

                if (control is TextBox textBox)
                {
                    prop.SetValue(Entity, textBox.Text);
                }
                else if (control is ComboBox comboBox)
                {
                    prop.SetValue(Entity, comboBox.SelectedItem);
                }
                else if (control is NumericUpDown numeric)
                {
                    object value;

                    if (prop.PropertyType == typeof(double))
                    {
                        value = Convert.ToDouble(numeric.Value);
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        value = Convert.ToInt32(numeric.Value);
                    }
                    else
                    {
                        value = Convert.ToInt64(numeric.Value);
                    }

                    prop.SetValue(Entity, value);
                }
                else if (control is DateTimePicker picker)
                {
                    prop.SetValue(Entity, picker.Value);
                }
                else
                {
                    throw new Exception("Не удалось получить значение");
                }
            }
        }

        public EditEntityForm(Object entity)
        {
            InitializeComponent();

            Entity = entity;

            InitEditControls();
        }

        public object Entity { get; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetFromControls();

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
