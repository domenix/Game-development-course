using UnityEngine;

public class Tidy : MonoBehaviour
{
    private float timer = 0.0f;
    private float timeUntilFadingStarts = 3.0f;
    private float duration = 0.3f;
    private Color color;
    private float alphaInitial = 1.0f;

    void Start()
    {
        color = gameObject.GetComponent<Renderer>().material.color;
        color = Color.green;
        color.a = 1.0f;
        alphaInitial = color.a;

        gameObject.GetComponent<Renderer>().material.color = color;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeUntilFadingStarts)
        {
            float fadingStart = timeUntilFadingStarts;
            float fadingEnd = timeUntilFadingStarts + duration;
            float timeLeft = fadingEnd - timer;

            if (timer < fadingEnd)
            {
                float ratio = EaseOutCubic(timeLeft / duration);

                color.a = alphaInitial * ratio;
                gameObject.GetComponent<Renderer>().material.color = color;
            }

            if (timer >= fadingEnd)
            {
                Destroy(gameObject);
            }
        }
    }

    public float EaseOutCubic(float t)
    {
        return (--t) * t * t + 1;
}
}
