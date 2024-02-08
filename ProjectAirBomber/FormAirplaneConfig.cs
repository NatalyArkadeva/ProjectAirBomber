using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Entity;

namespace ProjectAirBomber
{
    /// <summary>
    /// Форма конфигурации объекта
    /// </summary>
    public partial class FormAirplaneConfig : Form
    {
        /// <summary>
        /// Объект - прорисовка самолета
        /// </summary>
        private DrawningAirplane? _airplane;
        /// <summary>
        /// Событие для передачи объекта
        /// </summary>
        private event AirplaneDelegate? _airplaneDelegate;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAirplaneConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += Panel_MouseDown;
            panelYellow.MouseDown += Panel_MouseDown;
            panelLime.MouseDown += Panel_MouseDown;
            panelBlue.MouseDown += Panel_MouseDown;
            panelFuchsia.MouseDown += Panel_MouseDown;
            panelCyan.MouseDown += Panel_MouseDown;
            panelBlack.MouseDown += Panel_MouseDown;
            panelWhite.MouseDown += Panel_MouseDown;

            buttonCancel.Click += (s, e) => Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="airplaneDelegate"></param>
        public void AddEvent(AirplaneDelegate airplaneDelegate)
        {
            _airplaneDelegate += airplaneDelegate;
        }

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        private void DrawObject()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _airplane?.SetPictureSize(pictureBoxObject.Width, pictureBoxObject.Height);
            _airplane?.SetPosition(15, 15);
            _airplane?.Draw(gr);
            pictureBoxObject.Image = bmp;
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label)?.DoDragDrop((sender as Label)?.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data?.GetDataPresent(DataFormats.Text) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data?.GetData(DataFormats.Text)?.ToString())
            {
                case "labelSimpleObject":
                    _airplane = new DrawningAirplane((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelModifiedObject":
                    _airplane = new DrawningAirBomber((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White,
                    Color.Black, checkBoxAirRefueling.Checked, checkBoxExtraFuelTank.Checked, checkBoxAircraftBomb.Checked);
                    break;
            }
            DrawObject();
        }

        /// <summary>
        /// Передаем информацию при нажатии на Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseDown(object? sender, MouseEventArgs e)
        {
            (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor ?? Color.Gray, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data?.GetDataPresent(typeof(Color)) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_airplane == null || _airplane.EntityAirplane == null)
                return;

            ((Label)sender).BackColor = (Color)e.Data.GetData(typeof(Color));
            switch (((Label)sender).Name)
            {
                case "labelBodyColor":
                    _airplane.EntityAirplane.ChangeColor((Color)e.Data.GetData(typeof(Color)));
                    break;
                case "labelAdditionalColor":
                    if (!(_airplane is DrawningAirBomber))
                    {
                        return;
                    }
                    ((EntityAirBomber)_airplane.EntityAirplane).ChangeAdditionalColor((Color)e.Data?.GetData(typeof(Color)));
                    break;
            }
            DrawObject();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_airplane != null)
            {
                _airplaneDelegate?.Invoke(_airplane);
                Close();
            }
        }
    }
}
