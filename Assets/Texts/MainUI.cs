using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "TitleScreen", menuName = "ScriptableObjects/Texts", order = 1)]
public class MainUI : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] string[] boutons;
    public string getText(int k)
    {
        return boutons[k];
    }
}
