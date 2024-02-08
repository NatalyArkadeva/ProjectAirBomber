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
            int placeSizeWidth = _placeSizeWidth + 20;
            for (int i = 0; i < _pictureHeight / (_placeSizeHeight*3/2); i++)
            {
                for (int j = 0; j < _pictureWidth / placeSizeWidth + 1; j++)
                {
                    g.DrawLine(pen, _pictureWidth-(j * placeSizeWidth), i  * _placeSizeHeight*3/2 + _placeSizeHeight / 2, _pictureWidth - (j * placeSizeWidth), (i + 1) * (_placeSizeHeight * 3 / 2));
                }
                g.DrawLine(pen, _pictureWidth, (i+1) * (_placeSizeHeight*3/2), _pictureWidth-(_pictureWidth / placeSizeWidth * placeSizeWidth), (i + 1) * (_placeSizeHeight * 3 / 2));
            }
        }

        protected override void SetObjectsPosition()
        {
            int placeSizeWidth = _placeSizeWidth + 20;
            int x = _pictureWidth + 10;
            int y = _placeSizeHeight * 1 / 2;

            for (int i = 0; i < (_collection?.Count ?? 0); i++)
            {
                DrawningAirplane? obj = _collection?.Get(i);
                if (obj == null)
                {
                    x -= placeSizeWidth;
                    continue;
                }
                obj.SetPictureSize(_pictureWidth, _pictureHeight);

                x -= placeSizeWidth;

                if (x < 0)
                {
                    x = _pictureWidth + 10 - placeSizeWidth;
                    y += _placeSizeHeight*3/2;
                }
                obj.SetPosition(x, y);
            }
        }
    }
}
