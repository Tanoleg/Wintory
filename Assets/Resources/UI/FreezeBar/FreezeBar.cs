using UnityEngine;
using UnityEngine.UI;

public class FreezeBar : MonoBehaviour
{
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fill;

    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }
    public void SetMaxFreezing(int _freezing)
    {
        _slider.maxValue = _freezing;

        _fill.color = _gradient.Evaluate(1f);
    }
    public void SetFreezing(int _freezing)
    {
        _slider.value = _freezing;

        _fill.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}