using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float timeLeft = 3f;
    private float buffer = 0.5f;
    public GameObject garden;
    public GameObject shakingPot;
    public GameObject nice;

    float accelerometerUpdateInterval = 1.0f / 60.0f;
    // The greater the value of LowPassKernelWidthInSeconds, the slower the
    // filtered value will converge towards current input sample (and vice versa).
    float lowPassKernelWidthInSeconds = 1.0f;
    // This next parameter is initialized to 2.0 per Apple's recommendation,
    // or at least according to Brady! ;)
    float shakeDetectionThreshold = 1.5f;

    float lowPassFilterFactor;
    Vector3 lowPassValue;

    bool isShaking = false;
    bool canMix = false;

    public GameObject plant;

    void Start()
    {
        lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
        shakeDetectionThreshold *= shakeDetectionThreshold;
        lowPassValue = Input.acceleration;
    }

    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        Vector3 deltaAcceleration = acceleration - lowPassValue;

        if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
        {
            // Perform your "shaking actions" here. If necessary, add suitable
            // guards in the if check above to avoid redundant handling during
            // the same shake (e.g. a minimum refractory period).
            Debug.Log("Shake event detected at time " + Time.time);
            //timer();
            isShaking = true;
            buffer = 0.4f;
        }
        else if (buffer < 0)
        {
            isShaking = false;
            buffer = 0.5f;
        }

        if (buffer < 0.5f)
            buffer -= Time.deltaTime;

        if (isShaking)
        {
            timer();
        }
        else if (timeLeft < 3f && !isShaking)
        {
            timeLeft = 3f;
            shakingPot.SetActive(false);
        }

        if (Input.GetKey(KeyCode.P))
        {
            timer();
        }
        else if (timeLeft < 3f)
        {
            timeLeft = 3f;
            shakingPot.SetActive(false);
        }
    }

    void timer()
    {
        shakingPot.SetActive(true);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && canMix)
        {
            nice.SetActive(true);
            GameObject newPlant = Instantiate(plant, new Vector3(garden.transform.position.x, garden.transform.position.y, garden.transform.position.z), Quaternion.identity);
            newPlant.transform.parent = garden.transform; 
            canMix = false;
        }
    }
}