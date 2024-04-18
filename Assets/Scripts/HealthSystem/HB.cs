using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HB : MonoBehaviour
{
    [Header("Health Meter")]
    [SerializeField]
    private float tDrain = .5f;
    [SerializeField]
    private Gradient _gradient;
    private Image hbImage;
    private float target = 1f;
    private Color newHBColor;
    private Coroutine drainHB;

    private void Start()
    {
        hbImage = GetComponent<Image>();

        //set hb color
        hbImage.color = _gradient.Evaluate(target);

        HBGradientAmount();
    }

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        target = currentHealth / maxHealth;

        drainHB = StartCoroutine(DrainHB());

        HBGradientAmount();
    }

    private IEnumerator DrainHB()
    {
        float fillAmount = hbImage.fillAmount;

        Color currentColor = hbImage.color;

        float elapsedTime = 0f;
        while (elapsedTime < tDrain)
        {
            elapsedTime += Time.deltaTime;

            //lerp the fill amount
            hbImage.fillAmount = Mathf.Lerp(fillAmount, target, (elapsedTime / tDrain));

            //lerp the color based on the gradient
            hbImage.color = Color.Lerp(currentColor, newHBColor, (elapsedTime / tDrain));

            yield return null;
        }
    }

    private void HBGradientAmount()
    {
        newHBColor = _gradient.Evaluate(target);
    }
}
