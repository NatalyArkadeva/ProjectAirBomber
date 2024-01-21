namespace ProjectAirBomber
{
    /// <summary>
    /// Форма работы с объектом Бомбардировщик
    /// </summary>
    public partial class FormAirBomber : Form
    {
        /// <summary>
        /// Поле объект для прорисовки объекта
        /// </summary>
        private DrawningAirBomber? _drawningAirBomber;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormAirBomber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод прорисовки истребителя
        /// </summary>
        private void Draw()
        {
            if (_drawningAirBomber == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Graphics g = Graphics.FromImage(bmp);
            _drawningAirBomber.Draw(g);
            pictureBoxAirBomber.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningAirBomber = new DrawningAirBomber();
            _drawningAirBomber.Init(random.Next(100, 300), random.Next(1000, 3000),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
                Convert.ToBoolean(random.Next(0, 2)));
            _drawningAirBomber.SetPictureSize(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            _drawningAirBomber.SetPosition(random.Next(5, 20), random.Next(5, 20));

            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок перемещения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (_drawningAirBomber == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningAirBomber.Move(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningAirBomber.Move(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningAirBomber.Move(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningAirBomber.Move(DirectionType.Right);
                    break;
            }
            if (result)
            {
                Draw();
            }
        }
    }
}
