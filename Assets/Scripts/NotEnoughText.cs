using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotEnoughText : MonoBehaviour
{
    private int thresholdToShowCurrent;

    private bool didThisRunThreshold = false;
    public CountAmountJars jarcount;
    public Text notEnough;
    int startAmount;
    int currentAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        startAmount = jarcount.returnStartAmount();
        currentAmount = jarcount.returnCurrentAmount();
        if (!didThisRunThreshold)
            setWhenToShowCurrent();
        else
        {     
            if (currentAmount <= thresholdToShowCurrent)
            {
            notEnough.text = "Collect " + currentAmount + " more jars of jam and come back";
            }
            else
            {
             notEnough.text = "Collect all " + startAmount + " jars of jam and come back";
            }
        }
    }

    private void setWhenToShowCurrent()
    {
        float hold = startAmount/2;
        thresholdToShowCurrent = (int) Mathf.Round(hold);
        didThisRunThreshold = true;
    }
}
