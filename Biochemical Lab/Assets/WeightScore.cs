using UnityEngine;
using UnityEngine.UI;

public class WeightScore : MonoBehaviour
{
    // public GameObject weight;
    public Text weightResultToShow;
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

    void Start()
    {
        //Debug.Log("The weight is " + weightScaleScript.calculatedMass);
        //weightScaleScript.calculatedMass = 10.0f;
        //weightResultFromScript.calculatedMass = 10.0f;

    }

    // Update is called once per frame

    void Update()
    {
        //weightResultToShow.text = weightResultFromScript.calculatedMass.ToString();

    }
}
