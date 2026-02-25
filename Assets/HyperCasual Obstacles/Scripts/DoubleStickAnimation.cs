using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class DoubleStickAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform rotationTransform;

    [SerializeField, BoxGroup("Settings")] private float rotationDuration;

    private void Start()
    {
        DoubleStickRotatingAnimation();
    }
        
    private void DoubleStickRotatingAnimation()
    {
        rotationTransform.DOLocalRotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear)
            .SetRelative(true);
    }      
}
