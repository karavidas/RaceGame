using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float score =  0;
    public CollisionPlayer collision;

    private float ScoreUp()
    {
        if (collision.kopanise)
        {
            collision.kopanise = false;
            return 10;
        }
        else
        {
            return 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = score + 10*Time.deltaTime + ScoreUp();
        scoreText.text = score.ToString("0");
        if (collision.trakare)
        {
            enabled = false;
        }
    }
}
