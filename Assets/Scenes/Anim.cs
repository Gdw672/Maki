using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField] private GameObject ui;
    [SerializeField] private Material skybox2;
    int sumOfdefoultAnim;
    Animator animationDodik;
    void Start()
    {
        animationDodik = GetComponent<Animator>();
    }

    private void Update()
    {
        if(animationDodik.GetBool("isScared") && animationDodik.GetBool("isIdle2") && animationDodik.GetBool("isSitDown") && animationDodik.GetBool("isAgain"))
        {
            ui.SetActive(true);
        }
    }

    public void sumAnim()
    {
        sumOfdefoultAnim += 1;
        print(sumOfdefoultAnim);
        if(sumOfdefoultAnim == 3)
        {
            animationDodik.SetBool("isIdle2", true);
            sumOfdefoultAnim = 0;
        }
    }


    public void setDefaultState()
    {
        animationDodik.SetBool("isIdle2", false);
    }

    public void scared()
    {
        animationDodik.SetBool("isScared", true);
        RenderSettings.skybox = skybox2;

    }


    public void sit()
    {
        animationDodik.SetBool("isSitDown", true);
    }


    public void startDefaultAnimFromSitting()
    {
        StartCoroutine(cancelAllFuncCor());
    }
    private IEnumerator cancelAllFuncCor()
    {
        
        yield return new WaitForSeconds(0.6f);
        sumOfdefoultAnim = 0;
        setDefaultState();
        animationDodik.SetBool("isAgain", true);
        animationDodik.SetBool("isScared", false);
        animationDodik.SetBool("isSitDown", true);

    }
}
