using UnityEngine;
using UnityEngine.UI;

public class WeightScore : MonoBehaviour
{
    
    // public GameObject weight;
    public Text scoreText;

    // float score = 0;
    //public WeightScale weightResultFromScript;
    //public GameObject weightResultFromScript;

    //GameObject weightResultFromScript = GameObject.Find("podstawkaDoWagi");
    //WeightScale weightScaleScript = weightResultFromScript.GetComponent<WeightScale>;



    //void Awake()
    //{
    //    GameObject weightResultFromScript = GameObject.Find("podstawkaDoWagi");
    //    WeightScale weightScaleScript= weightResultFromScript.GetComponent<WeightScale>;
    //    weightScaleScript.calculatedMass -= 10.0f; 
    //}

    //void Start()
    //{
        // scoreText.text = score.ToString();
        // scoreText.text = WeightScale.instance.calculatedMass.ToString();

        //Debug.Log("The weight is " + weightScaleScript.calculatedMass);
        //weightScaleScript.calculatedMass = 10.0f;
        //weightResultFromScript.calculatedMass = 10.0f;

    //}

    // Update is called once per frame

    void Update()
    {
        scoreText.text = WeightScale.instance.calculatedMass.ToString();
        //weightResultToShow.text = weightResultFromScript.calculatedMass.ToString();
        // scoreText = WeightScale.instance.UpdateWeight();//.ToString();
    }
}
