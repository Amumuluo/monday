using UnityEngine;

namespace GTWEditor
{
    public enum TriggerOperator
    {
        And,
        Or
    }

    public enum CompareOperator
    {
        ABiggerThanB,
        ASmallerThanB,
        AEqualsToB,
        ABigOrEqualB,
        ASmallOrEqualB
    }
    namespace GetNumber
    {
        public enum PosGetUseXOrY
        {
            UseX,UseY
        }
    }

        public class DyncConfig
    {
        public static GameObject MainCharactor = null;
        public static float HalfMainCharactorWidth = 0;
        public static float HalfMainCharactorHeight = 0;
    }
}
