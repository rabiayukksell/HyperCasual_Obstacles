using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class MaceAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform maceTransform;
    [SerializeField, Foldout("Settings")] private float rotationZ;
    [SerializeField, Foldout("Settings")] private float durationAxe;


    private void Start()
    {
        maceBaseAnimation();
    }

    //[Button("Start Mace Animation")]

    private void maceBaseAnimation()
    {
        maceTransform.localRotation = Quaternion.Euler(0, 0, -rotationZ);
        var rotationVector = new Vector3(0, 0, rotationZ);
        maceTransform.DOLocalRotate(rotationVector, durationAxe, RotateMode.Fast)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutCubic);
    }
}
