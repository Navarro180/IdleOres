using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class MainMenuTransition : MonoBehaviour
{
    public GameObject transitionPanelRef;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //transitionPanelRef.transform.position = new Vector3(transform.position.x, 50, transform.position.z);
    }

    public void OnStartMenuTouch()
    {
        //transitionPanelRef.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        StartCoroutine(PlayAnimationAndWait());
    }

    IEnumerator PlayAnimationAndWait()
    {
        animator.SetBool("StartTransAnim", true);
        //animator.Play("StartMenuTransitionAnim");
        //yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        yield return new WaitForSeconds(0.5f);
        //SceneManager.LoadScene(1);
    }
}
