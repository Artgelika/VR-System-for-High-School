using UnityEngine;
using UnityEngine.UI;

public class WeightScore : MonoBehaviour
{
    public Text scoreText;
    public WeightScale weightResults;


    void Start()
    {
        scoreText.text = weightResults.calculatedMass.ToString("f2");
    }

    void Update()
    {
        scoreText.text = weightResults.calculatedMass.ToString("f2"); 
    }
    
}
