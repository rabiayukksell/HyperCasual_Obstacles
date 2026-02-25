using DG.Tweening;
using NaughtyAttributes;
using System.Runtime.CompilerServices;
// using Unity.InferenceEngine.Tokenization.Padding;
using UnityEngine;

public class PressAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform leftPressTransform;
    [SerializeField, Foldout("References")] private Transform rightPressTransform;

    [SerializeField, BoxGroup("Duration")] private float collisionsMovementDuration;
    [SerializeField, BoxGroup("Duration")] private float resetMovementDuration;
    [SerializeField, BoxGroup("Duration")] private float waitDuration;

    [SerializeField, BoxGroup("Value")] private float collisionMovementValue;
    [SerializeField, BoxGroup("Value")] private float resetMovementValue;

    private void Start()
    {
        LeftPressAnimation();
        RightPressAnimation();
    }

    private void LeftPressAnimation()
    {
        Tween collisionTween = leftPressTransform.DOLocalMoveX(collisionMovementValue, collisionsMovementDuration)
            .SetEase(Ease.OutBounce);

        Tween resetMovementTween = leftPressTransform.DOLocalMoveX(resetMovementValue, resetMovementDuration)
            .SetEase(Ease.OutQuint);

        Sequence leftPressSequence = DOTween.Sequence();
        leftPressSequence.Append(collisionTween)
            .AppendInterval(waitDuration)
            .Append(resetMovementTween)
            .SetLoops(-1, LoopType.Restart);
    }

    private void RightPressAnimation()
    {
        Tween collisionTween = rightPressTransform.DOLocalMoveX(collisionMovementValue, collisionsMovementDuration)
            .SetEase(Ease.OutBounce);

        Tween resetMovementTween = rightPressTransform.DOLocalMoveX(resetMovementValue, resetMovementDuration)
            .SetEase(Ease.OutQuint);

        Sequence rightPressSequence = DOTween.Sequence();
        rightPressSequence.Append(collisionTween)
            .AppendInterval(waitDuration)
            .Append(resetMovementTween)
            .SetLoops(-1, LoopType.Restart);
    }

    





}
