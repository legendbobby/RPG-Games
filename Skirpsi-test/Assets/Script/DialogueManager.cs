using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
   

    /*[SerializeField] Text nametag;
    [SerializeField] Text message;*/
    public GameObject textBox;
    public GameObject customButton;
    public GameObject optionPanel;
    public bool isTalking = false;
    public bool disableInput = false;
    static Story story;
    Text nametag;
    Text message;
    List<string> tags;
    static Choice choiceSelected;
    StoryScript storyscript;
    bool finish=false;
    string state;
    bool startdialogue=false;
    public bool ngomong = false;
    public int ip3=0;
    public int ip1 = 0;
    public int statemisi = 0;
    public int sm = 0;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        nametag = textBox.transform.GetChild(0).GetComponent<Text>();
        message = textBox.transform.GetChild(1).GetComponent<Text>();
        tags = new List<string>();
        choiceSelected = null;
        storyscript = GameManager.instance.storyscript;
        ngomong = false;
       

    }

    private void Update()
    {
        if (!isTalking)
        {
            if(Input.GetKeyDown(KeyCode.Space) && (disableInput == false) && (startdialogue) && (story.canContinue))
            {
                StartDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false) && (startdialogue) && (!story.canContinue))
            {
                FinishDialogue();
            }
        }
        if (story != null)
        {
            ip3 = (int)story.variablesState["ip3"];
            ip1 = (int)story.variablesState["IP1"];
            statemisi = (int)story.variablesState["StateMisi"];
            sm = (int)story.variablesState["SM"];


        }




    }

    public void ParsingFile(TextAsset inkFile, string nameChar)
    {
        if (story == null)
        {
            story = new Story(inkFile.text);
            nametag.text = nameChar;
        }
        story.onError += (msg, type) => {
             if (type == Ink.ErrorType.Warning)
                 Debug.LogWarning(msg);
             else
                 Debug.LogError(msg);
         };

    }
    public void StartDialogue()
    {
        ngomong = true;
        startdialogue = true;
        CharacterContoller2D.enableMovement = false;
        
        if (story.canContinue)
        {
           
            if (!textBox.activeSelf)
            {
                textBox.SetActive(true);
            }

           
            AdvanceDialogue();
          

            /*if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false))
            {
                Debug.Log("Lanjut");
                AdvanceDialogue();
            }*/

           
            //Are there any choices?
            if (story.currentChoices.Count != 0)
            {

                StartCoroutine(ShowChoices());

            }
            if (!story.canContinue)
            {
                
                if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false))
                {
                    if (story.currentText != "")
                    {
                        AdvanceDialogue();
                    }
                   
                    FinishDialogue();
                    
                    Debug.Log("End of Dialogue!, sudah selesai");
                }
            }
        }

        else if (!story.canContinue && !finish)
        {
            
            //storyscript.CheckStory();
            story.ChoosePathString(storyscript.state);
            Debug.Log(storyscript.state);
            StartDialogue();
            /*if (!textBox.activeSelf)
            {
                textBox.SetActive(true);
            }*/
            //AdvanceDialogue();
            /*if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false))
            {
                FinishDialogue();

                Debug.Log("state beda,End of Dialogue!");
            }*/
        }

        /*else if(!story.canContinue && !finish)
        {
            story.ChoosePathString(storyscript.state);
            Debug.Log(storyscript.state);
            state = storyscript.state;
            //StartDialogue();
            if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false))
            {
                FinishDialogue();
                Debug.Log("ga ada story,End of Dialogue! tapi belum selesai");
            }
        }*/
        else 
        {
            if (Input.GetKeyDown(KeyCode.Space) && (disableInput == false))
            {
                FinishDialogue();
                Debug.Log("story selesai");
            }
        }
        
            //Is there more to the story?
            
    }

    // Finished the Story (Dialogue)
    private void FinishDialogue()
    {
       
        
        textBox.SetActive(false);
        CharacterContoller2D.enableMovement = true;
        isTalking = false;
        startdialogue = false;
        ngomong = false;

    }

    // Advance through the story 
    void AdvanceDialogue()
    {
       
            string currentSentence = story.Continue();
            ParseTags();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(currentSentence));
          
          



    }

    // Type out the sentence letter by letter and make character idle if they were talking
    IEnumerator TypeSentence(string sentence)
    {
        message.text = "";
        disableInput = true;
        foreach (char letter in sentence.ToCharArray())
        {
            message.text += letter;
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        disableInput = false;
        yield return null;
    }

    // Create then show the choices on the screen until one got selected
    IEnumerator ShowChoices()
    {
        //Debug.Log("There are choices need to be made here!");
        List<Choice> _choices = story.currentChoices;
        Vector3 pos = customButton.transform.position;
        isTalking = true;
        float tempy = pos.y;
        optionPanel.SetActive(false);
        for (int i = 0; i < _choices.Count; i++)
        {
            GameObject temp = Instantiate(customButton, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity, optionPanel.transform);
            if (_choices.Count > 2)
            {
                if (i == 3)
                {
                    pos.x += 630f;
                    pos.y = tempy;
                }
                else
                {
                    pos.y -= 100f;
                }
               

            }
            else 
            {
                
                pos.y -= 100f;
                 
            }
           
            //GameObject temp = Instantiate(customButton, optionPanel.transform);
            
            temp.transform.GetChild(0).GetComponent<Text>().text = _choices[i].text;
            //Debug.Log(_choices[i].text);
            temp.AddComponent<Selectable>();
            temp.GetComponent<Selectable>().element = _choices[i];
            temp.GetComponent<Button>().onClick.AddListener(() => { temp.GetComponent<Selectable>().Decide(); });
        }
        
        optionPanel.SetActive(true);
        disableInput = true;
        yield return new WaitUntil(() => { return choiceSelected != null; });
        
        

        AdvanceFromDecision();
    }

    // Tells the story which branch to go to
    public static void SetDecision(object element)
    {
        choiceSelected = (Choice)element;
        story.ChooseChoiceIndex(choiceSelected.index);
    }

    // After a choice was made, turn off the panel and advance from that choice
    void AdvanceFromDecision()
    {
        optionPanel.SetActive(false);
        disableInput = false;
        isTalking = false;
        for (int i = 1; i < optionPanel.transform.childCount; i++)
        {
            Destroy(optionPanel.transform.GetChild(i).gameObject);
        }
        choiceSelected = null;
     
        AdvanceDialogue();
        
      
        // Forgot to reset the choiceSelected. Otherwise, it would select an option without player intervention.
        //StartDialogue();
    }

    /*** Tag Parser ***/
    /// In Inky, you can use tags which can be used to cue stuff in a game.
    /// This is just one way of doing it. Not the only method on how to trigger events. 
    void ParseTags()
    {
        tags = story.currentTags;
        foreach (string t in tags)
        {
            string prefix = t.Split(' ')[0];
            string param = t.Split(' ')[1];

            switch (prefix.ToLower())
            {
                
                case "color":
                    SetTextColor(param);
                    break;
            }
        }
    }
    
    void SetTextColor(string _color)
    {
        switch (_color)
        {
            case "red":
                message.color = Color.red;
                break;
            case "blue":
                message.color = Color.cyan;
                break;
            case "green":
                message.color = Color.green;
                break;
            case "white":
                message.color = Color.white;
                break;
            default:
                Debug.Log($"{_color} is not available as a text color");
                break;
        }
    }

}