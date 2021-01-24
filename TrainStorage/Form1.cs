using System;
using System.Windows.Forms;

namespace TrainStorage
{
    public partial class Form1 : Form
    {
        TrainStorage trainStorage;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            trainListBox.Items.Clear();
            trainListBox.Items.AddRange(trainStorage.GetStringifiedList());
        }

        private void UpdateList(Comparison<Train> comparer)
        {
            trainListBox.Items.Clear();
            trainListBox.Items.AddRange(trainStorage.GetStringifiedList(comparer));
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            trainStorage = new TrainStorage();
            UpdateList();

            clearButton.Enabled = true;
            deleteButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            trainStorage.RemoveAllTrains();
            UpdateList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (trainStorage is TrainStorage && trainListBox.Items.Count > 0)
            {
                var currentItemIndex = trainListBox.SelectedIndex;

                trainStorage.RemoveTrainByIndex(currentItemIndex);
                UpdateList();
            }
            else
            {
                MessageBox.Show("Нет элементов для очистки, либо коллекция не проинициализирована.", "Ошибка очистки");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (trainStorage is TrainStorage)
            { 
                string destination = destinationTextBox.Text;
                int number = 0;
                DateTime departure = departureDateTime.Value;

                if (destination == "")
                {
                    MessageBox.Show($"Ошибка в поле \"Пункт назначения\": строка пуста", "Ошибка добавления");
                    return;
                }

                try
                {
                    number = Convert.ToInt32(numberTextBox.Text);
                }
                catch (Exception err)
                {
                    if (numberTextBox.Text == "")
                    {
                        MessageBox.Show($"Ошибка в поле \"Номер поезда\": строка пуста", "Ошибка добавления");
                        return;
                    }

                    MessageBox.Show($"Ошибка в поле \"Номер поезда\": {err.Message}", "Ошибка добавления");
                    return;
                }

                if (trainStorage.AddTrain(destination, number, departure))
                {
                    UpdateList();
                }
                else
                {
                    MessageBox.Show($"Ошибка в поле \"Номер поезда\": номер должен быть уникальным", "Ошибка добавления");
                }
            }
        }

        private void destinationRadioButton_Click(object sender, EventArgs e)
        {
            UpdateList(new TrainDestinationComparer().Compare);
        }

        private void numberRadioButton_Click(object sender, EventArgs e)
        {
            UpdateList(new TrainNumberComparer().Compare);
        }

        private void departureRadioButton_Click(object sender, EventArgs e)
        {
            UpdateList(new TrainDepartureComparer().Compare);
        }
    }
}
