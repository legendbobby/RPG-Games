using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIntereactController : MonoBehaviour
{
    CharacterContoller2D characterController;
    Rigidbody2D rgbd2d;
    [SerializeField] float offsetDistance = 0.5f;
    [SerializeField] float sizeOfInteractableArea = 3f;
    Character character;
    [SerializeReference] HighlightController highlightController;
    public static bool interact = false;
    DialogueManager dialogueManager;

    private void Start()
    {
        dialogueManager = GameManager.instance.dialogueManager;
    }
        private void Awake()
    {
        characterController = GetComponent<CharacterContoller2D>();
        rgbd2d = GetComponent<Rigidbody2D>();
        character = GetComponent<Character>();
        
    }

    private void Update()
    {
        Check();
        if (Input.GetMouseButtonDown(1) || Input.GetButtonDown("Interact") && !dialogueManager.ngomong)
        {
            Interact();

        }
        
        /*if (!interact)
        {
            
        }*/

    }

    private void Check()
    {
        Vector2 position = rgbd2d.position + characterController.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            Interactable hit = c.GetComponent<Interactable>();
            if (hit != null)
            {
                highlightController.Highlight(hit.gameObject);
                
                return;
            }
            
        }
        
        highlightController.Hide();
    }

    private void Interact()
    {
        Vector2 position = rgbd2d.position + characterController.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            Interactable hit = c.GetComponent<Interactable>();
            
            
            if (hit != null)
            {
                
                interact = true;
                hit.Interact(character);
                break;
            }
        }
    }
}
