using ProjectAirBomber.Drawnings;

namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Реализация абстрактной компании - ангар
    /// </summary>
    public class Hangar : AbstractCompany
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        /// <param name="collection"></param>
        public Hangar(int picWidth, int picHeight, ICollectionGenericObjects<DrawningAirplane> collection) : base(picWidth, picHeight, collection)
        {
        }

        protected override void DrawBackgound(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            for (int i = 0; i < _pictureHeight / (_placeSizeHeight*3/2); i++)
            {
                for (int j = 0; j < _pictureWidth / _placeSizeWidth+1; j++)
                {
                    g.DrawLine(pen, j * _placeSizeWidth, i  * _placeSizeHeight*3/2 + _placeSizeHeight / 2, j * _placeSizeWidth, (i + 1) * (_placeSizeHeight * 3 / 2));
                }
                g.DrawLine(pen, 0, (i+1) * (_placeSizeHeight*3/2), _pictureWidth / _placeSizeWidth  * _placeSizeWidth, (i + 1) * (_placeSizeHeight * 3 / 2));
            }
        }

        protected override void SetObjectsPosition()
        {
            int width = _pictureWidth / _placeSizeWidth;
            int height = _pictureHeight / (_placeSizeHeight*3/2);
            for (int i = 0; i < (_collection?.Count ?? 0); i++)
            {
                DrawningAirplane? airplane = _collection.Get(i);
                if (airplane == null)
                    break;
                int r = i / width;
                int s = width - 1 - (i % width);
                airplane.SetPosition(15, 15);
            }
        }
    }
}
