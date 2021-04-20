using UnityEngine;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour
{
    public InputField ifForward;
    public InputField ifBackward;
    public InputField ifJump;
    public InputField ifAttack;
    public Slider     slVolume;

    // Start is called before the first frame update
    void Start()
    {
        LoadPreferences();
    }

    public void LoadPreferences()
    {
        ifForward.text  = PlayerPrefs.GetString("ForwardKey" , "D");
        ifBackward.text = PlayerPrefs.GetString("BackwardKey", "A");
        ifJump.text     = PlayerPrefs.GetString("JumpKey"    , "J");
        ifAttack.text   = PlayerPrefs.GetString("AttackKey"  , "K");
        slVolume.value  = PlayerPrefs.GetInt   ("VolumeKey"  , 50);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        LoadPreferences();
    }

    public void SavePreferences()
    {
        PlayerPrefs.SetString("ForwardKey" , ifForward.text);
        PlayerPrefs.SetString("BackwardKey", ifBackward.text);
        PlayerPrefs.SetString("JumpKey"    , ifJump.text);
        PlayerPrefs.SetString("AttackKey"  , ifAttack.text);
        PlayerPrefs.SetInt   ("VolumeKey"  , (int)slVolume.value);
    }

   
}
