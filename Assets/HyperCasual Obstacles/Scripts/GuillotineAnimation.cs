using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class GuillotineAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform movementTransform;

    [SerializeField, BoxGroup("Durations")] private float upMovementDuration;
    [SerializeField, BoxGroup("Durations")] private float downMovementDuration;


    [SerializeField, BoxGroup("Values")] private float upMovementValue;
    [SerializeField, BoxGroup("Values")] private float downMovementValue;

    private void Start()
    {
        BladeMovementAnimation();
    }

    private void BladeMovementAnimation()
    {
        Tween downMovementTween = movementTransform.DOLocalMoveY(downMovementValue, downMovementDuration)
            .SetEase(Ease.OutBounce);

        Tween upMovementTween = movementTransform.DOLocalMoveY(upMovementValue, upMovementDuration)
            .SetEase(Ease.OutQuint);

        Sequence movementSequence = DOTween.Sequence();

        movementSequence.Append(downMovementTween)
            .AppendInterval(0.25f)
            .Append(upMovementTween)
            .SetLoops(-1, LoopType.Yoyo);

    }
}
