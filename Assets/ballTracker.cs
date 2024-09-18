using UnityEngine;
using TMPro;

public class BallTracker : MonoBehaviour
{
    public int maxBalls = 3;  // Maximum number of balls allowed.
    private int ballsLeft;    // Current number of balls left.

    [SerializeField] private TMP_Text ballCountText;  // Reference to the UI Text component.

    private void Start()
    {
        ballsLeft = maxBalls;
        UpdateBallCountText();
    }

    private void UpdateBallCountText()
    {
        // Ensure the ballCountText variable is assigned.
        if (ballCountText != null)
        {
            ballCountText.text = "Balls Left: " + ballsLeft.ToString();
        }
    }

    public void DecreaseBallsLeft()
    {
        ballsLeft--;

        // Ensure the ball count doesn't go below zero.
        ballsLeft = Mathf.Max(ballsLeft, 0);

        UpdateBallCountText();

        if (ballsLeft <= 0)
        {
            // Implement game-over logic or disable shooting.
            Debug.Log("Out of balls!");
        }
    }

    // Public getter method to access ballsLeft.
    public int GetBallsLeft()
    {
        return ballsLeft;
    }
}