using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTooltip : MonoBehaviour
{

    public GameObject Tooltip;
    bool enable = true;
    public void TriggerToolTip()
    {
        enable = !enable;
        Tooltip.SetActive(enable ? true : false);
    }

}
