using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fill;

    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }
    public void SetMaxHeath(int _health)
    {
        _slider.maxValue = _health;
        _slider.value = _health;

        _fill.color = _gradient.Evaluate(1f);
    }
    public void SetHealth(int _health)
    {
        _slider.value = _health;

        _fill.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}