using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotEnoughText : MonoBehaviour
{
    private int thresholdToShowCurrent = 4;
    public CountAmountJars jarcount;
    public Text notEnough;
    int startAmount;
    int currentAmount;
    // Start is called before the first frame update
    void Start()
    {
        startAmount = jarcount.startAmountofJars;
        currentAmount = jarcount.currentAmountofJars;
        notEnough.text = "Collect all " + startAmount + " jars of jam and come back";
    }

    // Update is called once per frame
    void Update()
    {
        currentAmount = jarcount.currentAmountofJars;
        if (currentAmount <= thresholdToShowCurrent)
        {
            notEnough.text = "Collect " + currentAmount + " more jars of jam and come back";
        }
    }
}
