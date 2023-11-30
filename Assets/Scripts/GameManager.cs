using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float maxTime;
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

    private void ChangeCounter() {
        currentTime -= Time.deltaTime;
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
        ChangeTemporizer(true);
    }

    public void DesactivateTemporizer() {
        ChangeTemporizer(false);
    }
}
