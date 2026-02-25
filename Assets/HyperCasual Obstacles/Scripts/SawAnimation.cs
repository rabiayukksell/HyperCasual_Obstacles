using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class SawAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform movementTransform;
    [SerializeField, Foldout("References")] private Transform rotationTransform;

    [SerializeField, BoxGroup("Settings")] private float movementX;
    [SerializeField, BoxGroup("Settings")] private float movementDuration;

    [SerializeField, BoxGroup("Settings")] private float rotationDuration;

    //[Button()]
    private void Start()
    {
        SawRotationAnimation();
        SawMovementAnimation();
    }


    private void SawMovementAnimation()
    {
        movementTransform.DOLocalMoveX(movementX, movementDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }

    private void SawRotationAnimation()
    {
        var rotationVector = new Vector3(0, 0, 360);
        rotationTransform.DOLocalRotate(rotationVector, rotationDuration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Incremental) // incremental Her loop’ta hareketi öncekinin ÜSTÜNE ekler.
            .SetEase(Ease.Linear)
            .SetRelative(true); // daha düzgün linear yapabilmesi için
    }
}

