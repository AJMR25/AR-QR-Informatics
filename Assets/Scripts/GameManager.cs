using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private Button startButton, howToButton, aboutButton;
    private bool onBack;

    private void Start()
    {
        onBack = false;
    }
    void Update()
    {

        /*if (SimpleInput.GetButtonDown("OnStart"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        

        if (SimpleInput.GetButtonDown("OnAbout"))
        {
            
            SceneManager.LoadScene(5);

        }

        if (SimpleInput.GetButtonDown("OnHowToUse"))
        {
            
            SceneManager.LoadScene(6);

        }

        if (SimpleInput.GetButtonDown("OnScan"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }*/

        if (SimpleInput.GetButtonDown("OnModelDescription"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

        if (Input.GetKey(KeyCode.Escape) || onBack)
        {
            onBack = false;
            int index = SceneManager.GetActiveScene().buildIndex;

            if (index > 4)
            {

                SceneManager.LoadScene(1);

            }
            else
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }
            
        }

    }

    public void OnAnimate(bool _bool)
    {

        animator.SetBool("isDescriptionOpen", _bool);

    }

    public void ButtonClick()
    {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void HowtoUseButtonClick()
    {

        SceneManager.LoadScene(6);

    }
    public void AboutButtonClick()
    {

        SceneManager.LoadScene(5);

    }
    public void MapButtonClick()
    {

        SceneManager.LoadScene(7);

    }
    public void OnButtonBack()
    {

        onBack = true;

    }

    //StartCoroutine("HoldButtonPress");
    //IEnumerator HoldButtonPress()
    //{
    //    yield return new WaitForSeconds(5);
    //}
}