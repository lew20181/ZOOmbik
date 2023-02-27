using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider healthBarSlider;
    private Quaternion startRotation;

    private void Awake()
    {
        startRotation = transform.rotation;
        healthBarSlider = GetComponent<Slider>();
    }

    private void LateUpdate()
    {
        transform.rotation = startRotation;
    }
    public void UpdateHealthbar(int maxHealth, int currentHealth)
    {
        healthBarSlider.maxValue = maxHealth;
        healthBarSlider.minValue = 0;
        healthBarSlider.value = currentHealth;
    }
}
