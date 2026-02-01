using UnityEngine;
using UnityEngine.Audio; // Not strictly needed for basic AudioSource but fine to keep
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip coinSound;
    [SerializeField] float delayValue = 0.05f;

    // FIXED 1: We need to create the variable to store the number
    private int scoreCount = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Optimization Tip: CompareTag is slightly faster/safer than == "Coin"
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin Collected!");

            // Destroy the coin
            Destroy(other.gameObject, delayValue);

            // Increase the score
            scoreCount++;

            // Play the sound
            if (audioSource != null && coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            // FIXED 2: This logic must be INSIDE the function to work
            if (scoreText != null)
            {
                scoreText.text = "Score : " + scoreCount.ToString();
            }
        }
    }
}