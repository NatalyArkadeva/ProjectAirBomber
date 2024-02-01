using ProjectAirBomber.Drawnings;
using ProjectAirBomber.MovementStrategy;

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
        private DrawningAirplane? _drawningAirplane;
        /// <summary>
        /// Стратегия перемещения
        /// </summary>
        private AbstractStrategy? _strategy;
        /// <summary>
        /// Объект класса рандом
        /// </summary>
        private Random random = new();

        /// <summary>
        /// Получение объекта
        /// </summary>
        public DrawningAirplane SetAirplane
        {
            set
            {
                _drawningAirplane = value;
                _drawningAirplane.SetPictureSize(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
                comboBoxStrategy.Enabled = true;
                _strategy = null;
                Draw();
            }
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormAirBomber()
        {
            InitializeComponent();
            _strategy = null;
        }

        /// <summary>
        /// Метод прорисовки истребителя
        /// </summary>
        private void Draw()
        {
            if (_drawningAirplane == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Graphics g = Graphics.FromImage(bmp);
            _drawningAirplane.Draw(g);
            pictureBoxAirBomber.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопок перемещения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (_drawningAirplane == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningAirplane.Move(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningAirplane.Move(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningAirplane.Move(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningAirplane.Move(DirectionType.Right);
                    break;
            }
            if (result)
            {
                Draw();
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Шаг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrategyStep_Click(object sender, EventArgs e)
        {
            if (_drawningAirplane == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _strategy = comboBoxStrategy.SelectedIndex switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null,
                };
                if(_strategy == null)
                {
                    return;
                }
                _strategy.SetData(new MoveableAirplane(_drawningAirplane), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            }
            if (_strategy == null)
            {
                return;
            }
            comboBoxStrategy.Enabled = false;
            _strategy.MakeStep();
            Draw();

            if(_strategy.GetStatus() == StrategyStatus.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _strategy = null;
            }
        }
    }
}
