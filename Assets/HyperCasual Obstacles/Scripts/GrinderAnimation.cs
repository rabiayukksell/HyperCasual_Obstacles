using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class GrinderAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform rotationTransform;
    [SerializeField, Foldout("Settings")] private float rotationDuration;

    private void Start()
    {
        GrinderRotationAnimation();
    }

    private void GrinderRotationAnimation()
    {
        var rotationVector = new Vector3(0, -360, 0);
        rotationTransform.DOLocalRotate(rotationVector, rotationDuration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Incremental) 
            .SetEase(Ease.Linear)
            .SetRelative(true);
    }
}
