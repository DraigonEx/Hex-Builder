using UnityEngine;
using UnityEngine.UI;
using System;


class HudView : MonoBehaviour
{
    public void ToggleHud(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void progressTurn()
    {
        Text objPlayerTitle = GameObject.Find("txtPlayerName").GetComponent<Text>();
        Button btnOption1 = GameObject.Find("btnOption1").GetComponent<Button>();

        btnOption1.onClick.RemoveAllListeners();

        if (objPlayerTitle.text.Equals("Player 1",StringComparison.CurrentCultureIgnoreCase)) {
            objPlayerTitle.text = "Player 2";
            btnOption1.onClick.AddListener(() => { HideButton(btnOption1); });
            btnOption1.gameObject.SetActive(true);
        } else
        {
            objPlayerTitle.text = "Player 1";
            btnOption1.gameObject.SetActive(false);
        }
        //next turn logic here...
    }

    public void HideButton(Button btnButton)
    {
        btnButton.enabled = false;
    }
}
