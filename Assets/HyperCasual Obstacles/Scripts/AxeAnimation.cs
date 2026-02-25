using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class AxeAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform axeTransform;
    [SerializeField, Foldout("Settings")] private float rotationZ;
    [SerializeField, Foldout("Settings")] private float durationAxe;


    private void Start()
    {
        AxeBaseAnimation();
    }

    //[Button("Start Axe Animation")]

    private void AxeBaseAnimation()
    {
        axeTransform.localRotation = Quaternion.Euler(0, 0, -rotationZ);
        var rotationVector = new Vector3(0, 0, rotationZ);
        axeTransform.DOLocalRotate(rotationVector, durationAxe, RotateMode.Fast)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutCubic);
    }
}
