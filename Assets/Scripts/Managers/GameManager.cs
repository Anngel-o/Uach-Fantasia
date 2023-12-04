using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private Slider slider;
    private float currentTime;
    private bool activateTime = false;

    void Start()
    {
        ActivateTemporizer();
    }

    void Update()
    {
        if (activateTime)
        {
            ChangeCounter();
        }
    }

    public void addTime() {
        currentTime+=10.0f;
        //slider.value+=10.0f;
    }

    private void ChangeCounter() {
        currentTime -= Time.deltaTime;
        if (currentTime >= 0) {
            slider.value = currentTime;
        }

        if (currentTime <= 0) {
            Debug.Log("Derrota");
            DesactivateTemporizer();
        }
    }

    private void ChangeTemporizer(bool state) {
        activateTime = state;
    }

    public void ActivateTemporizer() {
        currentTime = maxTime;
        slider.maxValue = maxTime;
        ChangeTemporizer(true);
    }

    public void DesactivateTemporizer() {
        ChangeTemporizer(false);
    }
}
