namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Стратегия перемещения объекта в правый нижний угол
    /// </summary>
    public class MoveToBorder : AbstractStrategy
    {
        protected override bool IsTargetGetDestination()
        {
            ObjectParametrs? objectParametrs = GetObjectParametrs;
            if (objectParametrs == null)
            {
                return false;
            }
            return objectParametrs.RigthBorder + GetStep() >= FieldWidth && objectParametrs.DownBorder + GetStep() >= FieldHeight;
        }

        protected override void MoveToTarget()
        {
            ObjectParametrs? objectParametrs = GetObjectParametrs;
            if (objectParametrs == null)
            {
                return;
            }
             if (FieldWidth - objectParametrs.RigthBorder >= GetStep())
             {
                 MoveRight();
             }
             if (FieldHeight - objectParametrs.DownBorder >= GetStep())
             {
                 MoveDown();
             }
        }
    }
}
