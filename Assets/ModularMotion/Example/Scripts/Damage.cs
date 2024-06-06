//#define MODULARMOTION

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#if MODULARMOTION
using ModularMotion;
using Motion = ModularMotion.Core.Motion;

public class Damage : MonoBehaviour
{

    public Image TargetUI;
    public GameObject TextPrefab;
    public Transform TextSpawnPosition;
    public float AttackDMG;
    public float AnimationDuration = 1f;
    MotionBase AnimatedBar;
    bool Healed;

    public void Attack()
    {

        float Attack = UnityEngine.Random.Range(AttackDMG, AttackDMG + 50);
        if (AnimatedBar != null) AnimatedBar.Finish();
        AnimatedBar = Motion.Value(TargetUI.fillAmount, TargetUI.fillAmount - Attack * 0.0025f, DamageAnimation, AnimationDuration, 0, Motion.EaseOutStrong, Motion.LoopType.None);
        Healed = false;

        //Spawn Attack Number
        float RandomRange = 25;
        Vector3 RNDPosition = new Vector3(
            TextSpawnPosition.position.x + UnityEngine.Random.Range(-RandomRange, RandomRange),
            TextSpawnPosition.position.y + UnityEngine.Random.Range(-RandomRange, RandomRange), 0);

        GameObject Text = Instantiate(TextPrefab, RNDPosition, Quaternion.identity, TextSpawnPosition.parent);
        Text.GetComponentInChildren<UIMotion>().OnEnd.AddListener(() => DestoryAfterPlaying(Text)); 
        Text.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Attack.ToString("0");
    }

    void DestoryAfterPlaying(GameObject GO)
    {
        Destroy(GO.gameObject);
    }

    void Update()
    {

        if (AnimatedBar != null && AnimatedBar.Status == Motion.MotionStatus.Finished && !Healed)
        {
            Healed = true;
            Heal();
        }
    }

    private void DamageAnimation(float value)
    {
        TargetUI.fillAmount = value;
    }

    public void Heal()
    {
        if (AnimatedBar != null) AnimatedBar.Finish();
        AnimatedBar = Motion.Value(TargetUI.fillAmount, 1, DamageAnimation, 2, 0, Motion.EaseInStrong, Motion.LoopType.None);
    }
}

#endif