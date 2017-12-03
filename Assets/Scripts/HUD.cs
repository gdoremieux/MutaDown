using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] HeartSprites;
    public Image HeartUI;
    public Image MutUIJump;
    public Image MutUIJumpKill;
    public Image MutUISpeed;
    public Image MutUIShootGun;
    public Image MutUIFlame;
    public Image MutUIInvisible;
    public Image MutUIPush;
    public Text hText;
    public int Life;
    public string LifeRespawn;

    void Start()
    {
        Life = 5;
        MutUIJump.enabled = false;
        MutUIJumpKill.enabled = false;
        MutUISpeed.enabled = false;
        MutUIShootGun.enabled = false;
        MutUIFlame.enabled = false;
        MutUIInvisible.enabled = false;
        MutUIPush.enabled = false;
    }

    public void MutUIJumpEnabled()
    {
        if (MutUIJump.enabled == false)
        {
            Debug.Log("Jump enabled");
            MutUIJump.enabled = true;
        }
    }

    public void MutUIJumpKillEnabled()
    {
        if (MutUIJumpKill.enabled == false)
        {
            Debug.Log("JumpKill enabled");
            MutUIJumpKill.enabled = true;
        }
    }

    public void MutUISpeedEnabled()
    {
        if (MutUISpeed.enabled == false)
        {
            Debug.Log("Speed enabled");
            MutUISpeed.enabled = true;
        }
    }

    public void MutUIShootGunEnabled()
    {
        if (MutUIShootGun.enabled == false)
        {
            Debug.Log("ShootGun enabled");
            MutUIShootGun.enabled = true;
        }
    }

    public void MutUIFlameEnabled()
    {
        if (MutUIFlame.enabled == false)
        {
            Debug.Log("Flame enabled");
            MutUIFlame.enabled = true;
        }
    }

    public void MutUIInvisibleEnabled()
    {
        if (MutUIInvisible.enabled == false)
        {
            Debug.Log("Invisible enabled");
            MutUIInvisible.enabled = true;
        }
    }

    public void MutUIPushEnabled()
    {
        if (MutUIPush.enabled == false)
        {
            Debug.Log("Push enabled");
            MutUIPush.enabled = true;
        }
    }

    void Update()
    {
        HeartUI.sprite = HeartSprites[Life];
        hText.text = LifeRespawn;
    }
}
