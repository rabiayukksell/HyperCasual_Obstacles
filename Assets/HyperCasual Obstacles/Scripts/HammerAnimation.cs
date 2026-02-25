using DG.Tweening;
using NaughtyAttributes;
using Unity.Properties;
using UnityEngine;

public class HammerAnimation : MonoBehaviour
{
    [SerializeField, Foldout("References")] private Transform hammerHeadTransform;
    [SerializeField, BoxGroup("Settings")] private Vector3 rotationVector;
    [SerializeField, BoxGroup("Settings")] private float rotationDuration;

    private void Start()
    {
        HammerHeadAnimation();
    }

    //[Button("Start Hammerhead Animation")]
    private void HammerHeadAnimation()
    {
        hammerHeadTransform.DOLocalRotate(rotationVector, rotationDuration, RotateMode.Fast)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutCirc);
    }
}
