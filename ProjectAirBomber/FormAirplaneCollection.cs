﻿using Microsoft.Extensions.Logging;
using ProjectAirBomber.CollectionGenericObjects;
using ProjectAirBomber.Database;
using ProjectAirBomber.Database.Impl;
using ProjectAirBomber.Drawnings;

namespace ProjectAirBomber
{
    /// <summary>
    /// Форма работы с компанией и ее коллекцией
    /// </summary>
    public partial class FormAirplaneCollection : Form
    {
        /// <summary>
        /// Компания
        /// </summary>
        private AbstractCompany? _company = null;
        /// <summary>
        /// Логер
        /// </summary>
        private readonly ILogger _logger;
        /// <summary>
        /// Хранилише коллекций
        /// </summary>
        private readonly StorageCollection<DrawningAirplane> _storageCollection;

        private readonly ICollectionRepository _collectionRepository;

        private Random random = new Random();
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAirplaneCollection(ILogger<FormAirplaneCollection> logger)
        {
            InitializeComponent();
            _storageCollection = new();
            _logger = logger;
            _collectionRepository = new CollectionRepositoryImpl();
        }
        /// <summary>
        /// Выбор компании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCompanyTools.Enabled = false;
        }
        /// <summary>
        /// Создание объекта класса-перемещения
        /// </summary>
        /// <param name="type">Тип создаваемого объекта</param>
        private void CreateObject(string type)
        {
            if (_company == null)
            {
                return;
            }
            DrawningAirplane drawningAirplane;

            switch (type)
            {
                case nameof(DrawningAirplane):
                    drawningAirplane = new DrawningAirplane(random.Next(100, 300), random.Next(1000, 3000),
                        GetColor(random));
                    break;
                case nameof(DrawningAirBomber):
                    drawningAirplane = new DrawningAirBomber(random.Next(100, 300), random.Next(1000, 3000),
                         GetColor(random), GetColor(random),
                        Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
                        Convert.ToBoolean(random.Next(0, 2)));
                    break;
                default:
                    return;
            }
            if (_company + drawningAirplane)
            {
                MessageBox.Show("Объект добавлен");
                pictureBox.Image = _company.Show();
            }
            else
            {
                MessageBox.Show("Не удалось добавить объект");
            }
        }
        /// Получение цвета
        /// </summary>
        /// <param name="random">Генератор случайных чисел</param>
        /// <returns></returns>
        private static Color GetColor(Random random)
        {
            Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            return color;
        }
        /// <summary>
        /// Добавление обычного самолета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ButtonAddAirplane_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningAirplane));
        private void ButtonAddAirplane_Click(object sender, EventArgs e)
        {
            FormAirplaneConfig form = new();
            form.AddEvent(SetAirplane);
            form.Show();
        }
        /// <summary>
        /// Добавление объекта
        /// </summary>
        /// <param name="drawningAirplane"></param>
        private void SetAirplane(DrawningAirplane drawningAirplane)
        {
            if (_company == null || drawningAirplane == null)
            {
                return;
            }
            try
            {
                bool isSet = _company + drawningAirplane;
                MessageBox.Show("Объект добавлен");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Добавлен объект: {drawningAirplane}", saveFileDialog.FileName);

                var collectionName = listBoxCollection.SelectedItem.ToString();
                _collectionRepository.AddAirplane(collectionName, drawningAirplane);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }
        }
        /// <summary>
        /// Удаление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveAirplane_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox.Text) || _company == null)
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBox.Text);
            try
            {
                bool isRemove = _company - pos;
                MessageBox.Show("Объект удален");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Удален объект с индексом: {pos}", saveFileDialog.FileName);

                var collectionName = listBoxCollection.SelectedItem.ToString();
                DrawningAirplane? drawningAirplane = _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty].Get(pos);
                _collectionRepository.RemoveAirplane(collectionName, drawningAirplane);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }
        }
        /// <summary>
        /// Передача на тесты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGoToCheck_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                return;
            }
            DrawningAirplane? airplane = null;
            int counter = 100;
            while (airplane == null)
            {
                airplane = _company.GetDrawningObject();
                counter--;
                if (counter <= 0)
                {
                    break;
                }
            }
            if (airplane == null)
            {
                return;
            }
            FormAirBomber form = new()
            {
                SetAirplane = airplane
            };
            form.ShowDialog();
        }
        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                return;
            }
            pictureBox.Image = _company.Show();
        }

        /// <summary>
        /// Добавление коллекции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCollectionAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: Не все данные заполнены");
                return;
            }
            CollectionType collectionType = CollectionType.None;
            if (radioButtonMassive.Checked)
            {
                collectionType = CollectionType.Massive;
            }
            else if (radioButtonList.Checked)
            {
                collectionType = CollectionType.List;
            }
            _storageCollection.AddCollection(textBoxCollectionName.Text, collectionType);
            RerfreshListBoxItems();
            _logger.LogInformation("Добавлена коллекция: {textBoxCollectionName.Text}", saveFileDialog.FileName);
            _collectionRepository.Insert(textBoxCollectionName.Text, collectionType);
        }

        /// <summary>
        /// Удаление коллекции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCollectionDel_Click(object sender, EventArgs e)
        {
            // TODO прописать логику удаления элемента из коллекции
            // нужно убедиться, что есть выбранная коллекция
            // спросить у пользователя через MessageBox, что он подтверждает, что хочет удалить запись
            // удалить и обновить ListBox
            if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
            {
                MessageBox.Show("Коллекция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: Коллекция не выбрана");
                return;
            }
            if (MessageBox.Show("Удалить коллекцию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            _storageCollection.DelCollection(textBoxCollectionName.Text);
            MessageBox.Show("Коллекция удалена");
            RerfreshListBoxItems();
            _logger.LogInformation("Удалена коллекция: {textBoxCollectionName.Text}", saveFileDialog.FileName);
        }

        /// <summary>
        /// Обновление списка в listBoxCollection
        /// </summary>
        private void RerfreshListBoxItems()
        {
            listBoxCollection.Items.Clear();
            for (int i = 0; i < _storageCollection.Keys?.Count; ++i)
            {
                string? colName = _storageCollection.Keys?[i].Name;
                if (!string.IsNullOrEmpty(colName))
                {
                    listBoxCollection.Items.Add(colName);
                }
            }
        }

        /// <summary>
        /// Создание компании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
            {
                MessageBox.Show("Коллекция не выбрана");
                return;
            }
            ICollectionGenericObjects<DrawningAirplane>? collection = _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty];
            if (collection == null)
            {
                MessageBox.Show("Коллекция не проинициализирована");
                return;
            }
            switch (comboBoxSelectorCompany.Text)
            {
                case "Хранилище":
                    _company = new Hangar(pictureBox.Width, pictureBox.Height, collection);
                    break;
            }
            panelCompanyTools.Enabled = true;
            RerfreshListBoxItems();
        }
        /// <summary>
        /// Обработка нажатия "Сохранение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storageCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation("Сохранение в файл: {filename}", saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogError("Ошибка: {Message}", ex.Message);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия "Загрузка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storageCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RerfreshListBoxItems();
                    _logger.LogInformation("Сохранение в файл: {filename}", saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogError("Ошибка: {Message}", ex.Message);
                }
            }
        }
        /// <summary>
        /// Сортировка по типу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortByType_Click(object sender, EventArgs e)
        {
            CompareAirplane(new DrawningAirplaneCompareByType());
        }
        /// <summary>
        /// Сортировка по цвету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortByColor_Click(object sender, EventArgs e)
        {
            CompareAirplane(new DrawningAirplaneCompareByColor());
        }
        /// <summary>
        /// Сортировка по сравнителю
        /// </summary>
        /// <param name="comparer">Сравнитель объектов</param>
        private void CompareAirplane(IComparer<DrawningAirplane?> comparer)
        {
            if (_company == null)
            {
                return;
            }
            _company.Sort(comparer);
            pictureBox.Image = _company.Show();
        }
    }
}
