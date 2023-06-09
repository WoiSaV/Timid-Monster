using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NormalDialog1 : MonoBehaviour
{
    public Timmy timmy;
    public Button nextBtn;
    public Image dialogBox;
    public Image timmyImg;
    public Image friendImg;
    public Text dialog;
    public Button nextLevel;
    public Button mainMenu;

    public Image stone;

    public int dialogPocess = 1;
   
    // Start is called before the first frame update
    void Start()
    {
       SetAllInactive();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timmy.Victory){
            SetBtnActive();
            SetBoxActive();
            switch(dialogPocess){
                case 1:{
                    SetTextActive();
                    SetTimmyActive();
                    break;
                }
                case 2:{
                    SetTimmyInactive();
                    SetFriendActive();
                    ChangeText("Yes, it's my pleasure!");
                    break;
                }
                case 3:{
                    SetTimmyActive();
                    SetFriendInactive();
                    ChangeText("I have a firend now!");
                    
                    break;
                }
                case 4:{
                    SetStoneActive();
                    ChangeText("What's that?");
                    break;
                }
                case 5:{
                    ChangeText("Is it a stone?");
                    break;
                }
                case 6:{
                    SetTimmyInactive();
                    ChangeText("Timmy gets the Stone of Courage.");
                    SetBtnInactive();
                    SetNextMainBtnActive();
                    break;
                }
                
            }
       
        
        }
    }

    void SetAllInactive(){
         SetBoxInactive();
        SetBtnInactive();
        SetTimmyInactive();
        SetFriendInactive();
        SetTextInactive();
        SetNextMainBtnInactive();
        SetStoneInactive();

    }

    void SetBtnActive(){
        nextBtn.gameObject.SetActive(true);
    }
    void SetBoxActive(){
        dialogBox.color = new Color(dialogBox.color.r, dialogBox.color.g, dialogBox.color.b, 255);
    }
    void SetTimmyActive(){
        timmyImg.color = new Color(timmyImg.color.r, timmyImg.color.g, timmyImg.color.b, 255);
    }
    void SetFriendActive(){
        friendImg.color = new Color(friendImg.color.r, friendImg.color.g, friendImg.color.b, 255);
    }
    void SetTextActive(){
        dialog.gameObject.SetActive(true);
    }
    void SetNextMainBtnActive(){
        nextLevel.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
    }
    void SetStoneActive(){
        stone.color = new Color(stone.color.r, stone.color.g, stone.color.b, 255);

    }


    void SetBtnInactive(){
        nextBtn.gameObject.SetActive(false);
    }
    void SetBoxInactive(){
        dialogBox.color = new Color(dialogBox.color.r, dialogBox.color.g, dialogBox.color.b, 0);
    }
    void SetTimmyInactive(){
        timmyImg.color = new Color(timmyImg.color.r, timmyImg.color.g, timmyImg.color.b, 0);
    }
    void SetFriendInactive(){
        friendImg.color = new Color(friendImg.color.r, friendImg.color.g, friendImg.color.b, 0);
    }
    void SetTextInactive(){
        dialog.gameObject.SetActive(false);
    }
    void SetNextMainBtnInactive(){
        nextLevel.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }
    void ChangeText(string text){
        dialog.text = text;
    }
    void SetStoneInactive(){
        stone.color = new Color(stone.color.r, stone.color.g, stone.color.b, 0);
    }

    
}
