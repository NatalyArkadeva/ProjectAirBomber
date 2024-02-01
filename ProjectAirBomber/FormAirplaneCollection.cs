using ProjectAirBomber.CollectionGenericObjects;
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

        private Random random = new Random();
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAirplaneCollection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выбор компании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorCompany.Text)
            {
                case "Хранилище":
                    _company = new Hangar(pictureBox.Width, pictureBox.Height, new MassiveGenericObjects<DrawningAirplane>());
                    break;
            }
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
        private void ButtonAddAirplane_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningAirplane));
        /// <summary>
        /// Добавление бомбардировщика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddAirBomber_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningAirBomber));
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
            if (_company - pos)
            {
                MessageBox.Show("Объект удален");
                pictureBox.Image = _company.Show();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonGoToCheck_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                return;
            }
            DrawningAirplane? car = null;
            int counter = 100;
            while (car == null)
            {
                car = _company.GetDrawningObject();
                counter--;
                if (counter <= 0)
                {
                    break;
                }
            }
            if (car == null)
            {
                return;
            }
            FormAirBomber form = new()
            {
                SetAirplane = car
            };
            form.ShowDialog();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                return;
            }
            pictureBox.Image = _company.Show();
        }
    }
}
