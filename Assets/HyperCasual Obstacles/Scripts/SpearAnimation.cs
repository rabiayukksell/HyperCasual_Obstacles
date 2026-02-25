using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class SpearAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform movementTransform;

    [SerializeField, BoxGroup("Durations")] private float upMovementDuration;
    [SerializeField, BoxGroup("Durations")] private float downMovementDuration;
    [SerializeField, BoxGroup("Durations")] private float waitduration;

    [SerializeField, BoxGroup("Value")] private float upMovementValue;
    [SerializeField, BoxGroup("Value")]private float downMovementValue;

    private void Start()
    {
        SpearMovementAnimation();
    }

    private void SpearMovementAnimation()
    {
        Tween upMovementTween = movementTransform.DOLocalMoveY(upMovementValue, upMovementDuration)
            .SetEase(Ease.InExpo);

        Tween downMovementTween = movementTransform.DOLocalMoveY(downMovementValue, downMovementDuration)
            .SetEase(Ease.InExpo);

        Sequence movementSequence = DOTween.Sequence();
        movementSequence.Append(upMovementTween)
            .AppendInterval(waitduration)
            .Append(downMovementTween)
            .SetLoops(-1, LoopType.Restart);
    }
}
