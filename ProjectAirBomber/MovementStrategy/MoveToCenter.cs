namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Стратегия перемещения объекта в центр экрана
    /// </summary>
    public class MoveToCenter : AbstractStrategy
    {
        protected override bool IsTargetGetDestination()
        {
            ObjectParametrs? objectParametrs = GetObjectParametrs;
            if (objectParametrs == null)
            {
                return false;
            }
            return objectParametrs.ObjectMiddleHorizontal - GetStep() <= FieldWidth / 2 && objectParametrs.ObjectMiddleHorizontal + GetStep() >= FieldWidth / 2 &&
                objectParametrs.ObjectMiddleVertical - GetStep() <= FieldHeight / 2 && objectParametrs.ObjectMiddleVertical + GetStep() >= FieldHeight / 2;
        }

        protected override void MoveToTarget()
        {
            ObjectParametrs? objectParametrs = GetObjectParametrs;
            if (objectParametrs == null)
            {
                return;
            }
            int diffX = objectParametrs.ObjectMiddleHorizontal - FieldWidth / 2;
            if(Math.Abs(diffX) > GetStep())
            {
                if(diffX > 0)
                {
                    MoveLeft();
                }
                else
                {
                   MoveRight();
                }
            }
            int diffY = objectParametrs.ObjectMiddleVertical - FieldHeight / 2;
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY > 0)
                {
                    MoveUp();
                }
                else
                {
                    MoveDown();
                }
            }
        }
    }
}
